<Command("Flow Reversals", "I/O |0-99|:|0-99|   O/I |0-99|:|0-99| Start |0-1|"), _
 Description("This command is used to set the flow reversal times for the IO (in-out) and OI (out-in) flow and to select the start direction. This command should be used in conjunction with the FR (Fan Speed) command."), _
 Category("Type Of Command")> _
Public Class FR : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As FR
  Public StatusString As String
  Public InToOutTime As Integer
  Public OutToInTime As Integer
  Public Timer As New Timer
  Public IO As Boolean
  Public OI As Boolean

  Public Paused As Boolean

  ' The possible states of this command
  Public Enum FR
    Off
    InToOut
    Dwell
    OutToIn

  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> FR.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As FR
    Get
      Return state_
    End Get
    Private Set(ByVal value As FR)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.FL.Cancel()

    InToOutTime = param(1) * 60 + param(2)
    OutToInTime = param(3) * 60 + param(4)

    If param(5) = 1 Then
      Timer.TimeRemaining = InToOutTime
      state_ = FR.InToOut
    Else
      Timer.TimeRemaining = OutToInTime
      state_ = FR.OutToIn
    End If



    Return True 'Step on 

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run

    If Not ControlCode.IO.FanRunning And (state_ <> FR.Off) Then
      Timer.Pause()
      Paused = True
    Else
      Timer.Restart()
      Paused = False
    End If

    Select Case state_

      Case FR.InToOut
        IO = True
        StatusString = "In To Out Time " & TimerString(Timer.TimeRemaining)
        If Timer.Finished Then
          Timer.TimeRemaining = ControlCode.Parameters.FlowDwellTime
          state_ = FR.Dwell
        End If

      Case FR.Dwell
        StatusString = "Dwell Time " & TimerString(Timer.TimeRemaining)
        If Timer.Finished Then

          If IO = True Then
            Timer.TimeRemaining = OutToInTime
            state_ = FR.OutToIn
          Else
            Timer.TimeRemaining = InToOutTime
            state_ = FR.InToOut
          End If

        End If


      Case FR.OutToIn
        StatusString = "Out To In Time " & TimerString(Timer.TimeRemaining)
        If Timer.Finished Then
          Timer.TimeRemaining = ControlCode.Parameters.FlowDwellTime
          state_ = FR.Dwell
          IO = False
        End If


    End Select

    If Paused And (IO = True) Then StatusString = "FR is Paused " & TimerString(Timer.TimeRemaining) & " I/O"
    If Paused And (IO = False) Then StatusString = "FR is Paused " & TimerString(Timer.TimeRemaining) & " O/I"


    Return True 'Step on 

  End Function
  Public ReadOnly Property FlowIsInToOut() As Boolean
    Get
      Return State = FR.InToOut
    End Get
  End Property
  Public ReadOnly Property FlowIsOutToIn() As Boolean
    Get
      Return State = FR.OutToIn Or State = FR.Dwell
    End Get
  End Property



  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = FR.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
