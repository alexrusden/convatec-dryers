<Command("Lid Open"), _
 Description("This command is used to open the Lid once the process has finished and the machine is safe."), _
 Category("LidControl")> _
Public Class LO : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As LO


  ' The possible states of this command
  Public Enum LO
    Off
    Interlock
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> LO.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As LO
    Get
      Return state_
    End Get
    Private Set(ByVal value As LO)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.FR.Cancel()
    ControlCode.FL.Cancel()

    state_ = LO.Interlock



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case LO.Off

        Case LO.Interlock
          If (ControlCode.PressureIsSafe) And (Not ControlCode.IO.KierFullLevel) And _
                 (Not ControlCode.IO.FanRunning) And (Not ControlCode.IO.FanCoolerMotorRunning) Then
            state_ = LO.Running
            ControlCode.LidControlState = Global.ControlCode.LidControl.RequestOpen
          End If


        Case LO.Running
          If ControlCode.FullyOpen Then Cancel()

      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = LO.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
