<Command("Final Temperature", "|0-100|C"), _
 Description("This command is used to program the desired Final temperature. This is the temperature after the kier has held at the desired Outlet temperature for a time that it will cool down to.The Inlet and Cooler Temperature commands are cancelled and the Cooler cooling valve opens a fixed amount (set by parameter ‘Final Temp Cooling Percent’)"), _
 Category("TempControl")> _
Public Class FT : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As FT
  Public FinalTempSetting As Integer
  Private CancelTimer As New Timer
  ' The possible states of this command
  Public Enum FT
    Off
    WaitForTemp
    AtTemp
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> FT.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As FT
    Get
      Return state_
    End Get
    Private Set(ByVal value As FT)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    FinalTempSetting = param(1)
    With ControlCode
      .CT.Cancel()
      .IT.Cancel()
      .OT.Cancel()
    End With



    state_ = FT.WaitForTemp
  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case FT.Off

        Case FT.WaitForTemp
          If .IO.OutletTemperature <= (FinalTempSetting * 10) Then
            CancelTimer.TimeRemaining = 3
            state_ = FT.AtTemp
          End If


        Case FT.AtTemp

          Return (True)

          If CancelTimer.Finished Then
            If .HT.IsOn Then
              If .HT.HoldTimer.TimeRemaining <= 1 Then Cancel()
            Else
              Cancel()
            End If
          End If



      End Select
    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = FT.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
