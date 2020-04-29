Namespace Ports
  Public Class RockwellEthernetIP
    Private state_ As State, asyncResult_ As IAsyncResult, result_ As Result   ' valid when state_ = Complete
    Private Structure WorkData
      Dim Tag As String, IsRead As Boolean, Count As Integer
      Dim RxDataLength As Integer, TxData() As Byte, TxDataType As Type
    End Structure
    Private work_ As WorkData
    Private ReadOnly writeOptimisation_ As New WriteOptimisation

    Private ReadOnly stm_ As Stream
    Private rx_(400 - 1) As Byte, rxLength_ As Integer
    Private oks_, faults_, tnsFaults_ As Integer
    Private sessionHandle_, connectionId_ As Integer
    Private tns_ As Short

    Private Enum State
      Idle
      Begin
      SessionTX
      SessionRX
      BeginConnection
      ConnectionTX
      ConnectionRX
      BeginReadOrWrite
      ReadTX
      ReadRX
      WriteTX
      WriteRX
      Complete
    End Enum

    Public Enum Result
      Busy
      OK
      Fault
      TnsFault
    End Enum

    Public Sub New(ByVal computer As String)
      Dim stm As New NetworkPort(computer, 44818)   ' always this port number
      stm.ReadTimeout = 300
      stm_ = New Stream(stm)
      ' Start the transaction somewhere different each time
      With New Random : tns_ = CType(.Next(10000), Short) : End With
    End Sub

    Friend ReadOnly Property BaseStream() As Stream
      Get
        Return stm_
      End Get
    End Property


    Public Function Read(ByVal tag As String, ByVal values As Array) As Result
      ' Start a completely new task
      If state_ = State.Idle Then
        With work_
          .Tag = tag : .IsRead = True
          .Count = values.Length - 1
          Dim elType As Type = values.GetType.GetElementType()
          Dim datumBytes As Integer
          If elType Is GetType(Boolean) Then
            datumBytes = 1
          ElseIf elType Is GetType(Short) Then
            datumBytes = 2
          Else
            datumBytes = 4
          End If
          .RxDataLength = datumBytes * work_.Count   ' how many bytes of data we hope for
        End With
        state_ = State.Begin
      End If

      ' See if we're finished
      RunStateMachine()

      ' Maybe it's someone else's job - TODO: timeout if no-one comes for it for a long time
      If state_ <> State.Complete OrElse work_.Tag <> tag OrElse work_.IsRead <> True Then Return Result.Busy ' not yet 
      state_ = State.Idle ' the end of this job

      ' Decode the values returned
      If result_ = Result.OK Then
        Dim count As Integer = values.Length - 1, ofs As Integer = 52
        Dim ints() As Integer = TryCast(values, Integer())
        If ints IsNot Nothing Then
          For i As Integer = 0 To count - 1
            ints(i + 1) = System.BitConverter.ToInt32(rx_, ofs) : ofs += 4
          Next i
        Else
          Dim shorts() As Short = TryCast(values, Short())
          If shorts IsNot Nothing Then
            For i As Integer = 0 To count - 1
              shorts(i + 1) = System.BitConverter.ToInt16(rx_, ofs) : ofs += 2
            Next i
          Else
            Dim bools() As Boolean = TryCast(values, Boolean())
            If bools IsNot Nothing Then
              For i As Integer = 0 To count - 1
                bools(i + 1) = (rx_(ofs) <> 0) : ofs += 1
              Next i
            Else
              Stop
            End If
          End If
        End If
      End If
      Return result_
    End Function


    Public Function Write(ByVal tag As String, ByVal values As Array, ByVal writeMode As WriteMode) As Result
      If state_ = State.Idle Then
        ' Start a completely new task

        ' Optionally, do write-optimisation, meaning we usually do not write the same values to the same
        ' registers in the same slave.
        If writeMode = Ports.WriteMode.Optimised AndAlso writeOptimisation_.RecentlyWrote(values, tag) Then Return Result.OK

        Dim count As Integer = values.Length - 1, txData() As Byte
        Dim ints() As Integer = TryCast(values, Integer())
        If ints IsNot Nothing Then
          Const datumBytes As Integer = 4
          txData = New Byte(datumBytes * count - 1) {}
          For i As Integer = 0 To count - 1
            System.BitConverter.GetBytes(ints(i + 1)).CopyTo(txData, i * datumBytes)
          Next i
        Else
          Dim shorts() As Short = TryCast(values, Short())
          If shorts IsNot Nothing Then
            Const datumBytes As Integer = 2
            txData = New Byte(datumBytes * count - 1) {}
            For i As Integer = 0 To count - 1
              System.BitConverter.GetBytes(shorts(i + 1)).CopyTo(txData, i * datumBytes)
            Next i
          Else
            Dim bools() As Boolean = TryCast(values, Boolean())
            If bools IsNot Nothing Then
              txData = New Byte(count - 1) {}
              For i As Integer = 0 To count - 1
                If bools(i + 1) Then txData(i) = 255
              Next i
            Else
              Stop
            End If
          End If
        End If

        With work_
          .Tag = tag : .IsRead = False
          .Count = count : .TxData = txData : .TxDataType = values.GetType.GetElementType()
        End With

        ' Set it going.
        state_ = State.Begin
      End If

      ' See if we're finished
      RunStateMachine()

      ' Maybe it's someone else's job - TODO: timeout if no-one comes for it for a long time
      If state_ <> State.Complete OrElse work_.Tag <> tag OrElse work_.IsRead <> False Then Return Result.Busy ' not yet 
      state_ = State.Idle ' the end of this job
      Return result_
    End Function

    Private Sub RunStateMachine()
      Select Case state_
        Case State.Begin
          If sessionHandle_ <> 0 Then GoTo stateBeginConnection
          Dim txEncap() As Byte = { _
              &H65, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0}
          ' And then begin the write of the bytes
          stm_.Flush() : asyncResult_ = stm_.BeginWrite(txEncap, 0, txEncap.Length, Nothing, Nothing)
          state_ = State.SessionTX : GoTo stateSessionTX

        Case State.SessionTX
stateSessionTX:
          If Not asyncResult_.IsCompleted Then Exit Sub
          stm_.EndWrite(asyncResult_)
          rxLength_ = 28 : asyncResult_ = stm_.BeginRead(rx_, 0, rxLength_, Nothing, Nothing)
          state_ = State.SessionRX : GoTo stateSessionRX

        Case State.SessionRX
stateSessionRX:
          If Not asyncResult_.IsCompleted Then Exit Sub ' it'll be completed soon, because of the timeout
          Dim bytesRead As Integer = stm_.EndRead(asyncResult_) : asyncResult_ = Nothing

          If bytesRead <> rxLength_ Then
            SetResult(Result.Fault)
            state_ = State.Complete
          End If
          sessionHandle_ = System.BitConverter.ToInt32(rx_, 4)
          state_ = State.BeginConnection

        Case State.BeginConnection
stateBeginConnection:
          If connectionId_ <> 0 Then GoTo stateBeginReadOrWrite
          Dim txForwardOpen() As Byte = { _
            &H6F, 0, &H40, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
            0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, &HB2, 0, &H30, 0, &H54, 2, &H20, 6, &H24, 1, _
            7, &HE8, 0, 0, 0, 0, &H11, &H22, &H33, &H44, 0, &H20, 1, 0, &H12, &H34, &H56, &H78, 0, 0, 0, 0, _
            &HE0, &H70, &H72, 0, &HF6, &H43, &HE0, &H70, &H72, 0, &HF6, &H43, &HA3, 3, _
            1, 0, &H20, 2, &H24, 1}
          System.BitConverter.GetBytes(sessionHandle_).CopyTo(txForwardOpen, 4)

          ' And then begin the write of the bytes
          stm_.Flush() : asyncResult_ = stm_.BeginWrite(txForwardOpen, 0, txForwardOpen.Length, Nothing, Nothing)
          state_ = State.ConnectionTX : GoTo stateConnectionTX

        Case State.ConnectionTX
stateConnectionTX:
          If Not asyncResult_.IsCompleted Then Exit Sub
          stm_.EndWrite(asyncResult_)
          rxLength_ = 70 : asyncResult_ = stm_.BeginRead(rx_, 0, rxLength_, Nothing, Nothing)
          state_ = State.ConnectionRX : GoTo stateConnectionRX

        Case State.ConnectionRX
stateConnectionRX:
          If Not asyncResult_.IsCompleted Then Exit Sub ' it'll be completed soon, because of the timeout
          Dim bytesRead As Integer = stm_.EndRead(asyncResult_) : asyncResult_ = Nothing

          If bytesRead <> rxLength_ Then
            sessionHandle_ = 0  ' this needs re-opening as well
            SetResult(Result.Fault)
            state_ = State.Complete
          End If
          connectionId_ = System.BitConverter.ToInt32(rx_, 44)
          state_ = State.BeginReadOrWrite

        Case State.BeginReadOrWrite
stateBeginReadOrWrite:
          If work_.isRead Then
            ' Do a read
            Dim tx() As Byte = PrepareTx(&H4C, work_.Tag, 2), ofs As Integer = tx.Length - 2
            ' Item count
            System.BitConverter.GetBytes(CType(work_.Count, Short)).CopyTo(tx, ofs)

            stm_.Flush() : asyncResult_ = stm_.BeginWrite(tx, 0, tx.Length, Nothing, Nothing)
            state_ = State.ReadTX : GoTo stateReadTX

          Else
            ' Do a write
            Dim txDataLength As Integer = work_.TxData.Length, _
                tx() As Byte = PrepareTx(&H4D, work_.Tag, 4 + txDataLength), _
                ofs As Integer = tx.Length - (4 + txDataLength)

            ' Data type
            Dim txDataType As Type = work_.TxDataType
            Dim dataType As Integer

            If txDataType Is GetType(Boolean) Then
              dataType = &HC1
            ElseIf txDataType Is GetType(Short) Then
              dataType = &HC3
            Else
              dataType = &HC4
            End If

            System.BitConverter.GetBytes(CType(dataType, Short)).CopyTo(tx, ofs) : ofs += 2

            ' Item count
            System.BitConverter.GetBytes(CType(work_.Count, Short)).CopyTo(tx, ofs) : ofs += 2

            ' Data
            Array.Copy(work_.TxData, 0, tx, ofs, txDataLength)

            stm_.Flush() : asyncResult_ = stm_.BeginWrite(tx, 0, tx.Length, Nothing, Nothing)
            state_ = State.WriteTX : GoTo stateWriteTX
          End If

        Case State.ReadTX
stateReadTX:
          If Not asyncResult_.IsCompleted Then Exit Sub
          stm_.EndWrite(asyncResult_)

          rxLength_ = 52 + work_.RxDataLength
          asyncResult_ = stm_.BeginRead(rx_, 0, rxLength_, Nothing, Nothing)
          state_ = State.ReadRX : GoTo stateReadRX

        Case State.ReadRX
stateReadRX:
          If Not asyncResult_.IsCompleted Then Exit Sub ' it'll be completed soon, because of the timeout
          Dim bytesRead As Integer = stm_.EndRead(asyncResult_) : asyncResult_ = Nothing

          Dim result As Result
          If bytesRead <> rxLength_ Then
            If bytesRead >= 50 Then
              Dim status As Byte = rx_(48), extraStatusLen As Integer = rx_(49) * 2
              If bytesRead >= 50 + extraStatusLen Then
                Dim extStatus As Short = System.BitConverter.ToInt16(rx_, 50)  ' get the first status code
              End If
            End If
            result = RockwellEthernetIP.Result.Fault
          ElseIf System.BitConverter.ToInt16(rx_, 44) <> tns_ Then
            result = RockwellEthernetIP.Result.TnsFault
          Else
            result = RockwellEthernetIP.Result.OK
          End If
          If result <> RockwellEthernetIP.Result.OK Then connectionId_ = 0 : sessionHandle_ = 0
          SetResult(result)
          state_ = State.Complete

          ' TODO: there's quite a lot of identical code around - work with just one copy
        Case State.WriteTX
stateWriteTX:
          If Not asyncResult_.IsCompleted Then Exit Sub
          stm_.EndWrite(asyncResult_)
          rxLength_ = 50 ' won't be very interesting, but check for it all the same
          asyncResult_ = stm_.BeginRead(rx_, 0, rxLength_, Nothing, Nothing)
          state_ = State.WriteRX : GoTo stateWriteRX

        Case State.WriteRX
stateWriteRX:
          If Not asyncResult_.IsCompleted Then Exit Sub ' it'll be completed soon, because of the timeout
          Dim bytesRead As Integer = stm_.EndRead(asyncResult_) : asyncResult_ = Nothing

          Dim result As Result
          If bytesRead <> rxLength_ Then
            result = RockwellEthernetIP.Result.Fault
          ElseIf System.BitConverter.ToInt16(rx_, 44) <> tns_ Then
            result = RockwellEthernetIP.Result.TnsFault
          Else
            Dim status As Byte = rx_(48), extraStatusLen As Integer = rx_(49) * 2
            If status <> 0 Then
              If bytesRead >= 50 + extraStatusLen Then
                Dim extStatus As Short = System.BitConverter.ToInt16(rx_, 50)  ' get the first status code - won't have read this from the socket...
              End If
              result = RockwellEthernetIP.Result.Fault
            Else
              result = RockwellEthernetIP.Result.OK
            End If
          End If
          If result <> RockwellEthernetIP.Result.OK Then connectionId_ = 0 : sessionHandle_ = 0
          SetResult(result)
          state_ = State.Complete
      End Select
    End Sub

    Private Shared ReadOnly txFixed_() As Byte = { _
            &H70, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
            0, 0, 0, 0, 0, 0, 2, 0, &HA1, 0, 4, 0, 0, 0, 0, 0, &HB1}

    Private Function PrepareTx(ByVal serviceCode As Byte, ByVal tag As String, ByVal extraLen As Integer) As Byte()
      Dim tagBytes() As Byte = GetTagBytes(tag)
      Dim extraLen2 As Integer = extraLen + tagBytes.Length
      Dim tx(txFixed_.Length + 6 + extraLen2 - 1) As Byte
      txFixed_.CopyTo(tx, 0) : tx(txFixed_.Length + 5) = serviceCode

      ' The two handles
      System.BitConverter.GetBytes(sessionHandle_).CopyTo(tx, 4)
      System.BitConverter.GetBytes(connectionId_).CopyTo(tx, 36)

      ' Pop in a couple of lengths  
      System.BitConverter.GetBytes(CType(&H17 + extraLen2, Short)).CopyTo(tx, 2)
      System.BitConverter.GetBytes(CType(3 + extraLen2, Short)).CopyTo(tx, 42)

      ' The sequence count
      tns_ += 1S  ' will overflow back round
      System.BitConverter.GetBytes(tns_).CopyTo(tx, 44)

      ' Put the tag at the end
      tagBytes.CopyTo(tx, txFixed_.Length + 6)
      Return tx
    End Function

    Private Shared Function GetTagBytes(ByVal tag As String) As Byte()
      Dim ret As New List(Of Byte)
      ' Split at dots (but not colons)
      For Each str As String In tag.Split("."c)
        ret.Add(&H91)
        ret.Add(CType(str.Length, Byte))
        ret.AddRange(System.Text.ASCIIEncoding.ASCII.GetBytes(str))
      Next str
      If (ret.Count And 1) <> 0 Then ret.Add(0) ' ensure an even length
      ret.Insert(0, CType(ret.Count \ 2, Byte))
      Return ret.ToArray
    End Function

    ' TODO: Friend
    Public ReadOnly Property OKs() As Integer
      Get
        Return oks_
      End Get
    End Property
    Public ReadOnly Property Faults() As Integer
      Get
        Return faults_
      End Get
    End Property
    Public ReadOnly Property TnsFaults() As Integer
      Get
        Return tnsFaults_
      End Get
    End Property
    Private Sub SetResult(ByVal value As Result)
      result_ = value
      Select Case value
        Case Result.OK : oks_ += 1
        Case Result.Fault : faults_ += 1
        Case Else : tnsFaults_ += 1
      End Select
    End Sub
  End Class
End Namespace