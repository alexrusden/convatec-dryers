<Command("Outlet Temperature", "|0-999|C"), _
 Description("This command is used to program the desired Outlet temperature. Should be used in conjunction with the IT (Inlet Temperature) and the CT (Cooler Temperature) commands"), _
 Category("TempControl")> _
Public Class OT : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As OT
  Public FinalTempDV As Integer
  Public SettleTime As New Timer
  Public HoldOffTimer As New Timer
  ' The possible states of this command
  Public Enum OT
    Off
    WaitForTemp
    Settle
    Done
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> OT.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As OT
    Get
      Return state_
    End Get
    Private Set(ByVal value As OT)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands


    FinalTempDV = param(1)

    SettleTime.TimeRemaining = 30

    state_ = OT.WaitForTemp



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode



      If .FR.Timer.TimeRemaining = 3 Then
        HoldOffTimer.TimeRemaining = 300
      End If


      If (Not HoldOffTimer.Finished) Or (.IO.OutletTemperature < (FinalTempDV * 10)) Or (Not ControlCode.IO.FanRunning) Then SettleTime.TimeRemaining = 60



      Select Case state_

        Case OT.Off

        Case OT.WaitForTemp
          If SettleTime.TimeRemaining < 58 Then state_ = OT.Settle


        Case OT.Settle
          If SettleTime.TimeRemaining > 58 Then state_ = OT.WaitForTemp
          If SettleTime.Finished Then State = OT.Done


        Case OT.Done

          Return True




      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = OT.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
