<Command("Lid Close"), _
 Description("This command is used to close the machine Lid. "), _
 Category("LidControl")> _
Public Class LC : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As LC


  ' The possible states of this command
  Public Enum LC
    Off
    Interlock
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> LC.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As LC
    Get
      Return state_
    End Get
    Private Set(ByVal value As LC)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands


    state_ = LC.Interlock



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case LC.Off

        Case LC.Interlock
          If (Not ControlCode.PressureIsSafe) And _
              (Not ControlCode.IO.FanRunning) And (Not ControlCode.IO.FanCoolerMotorRunning) Then Exit Function

          state_ = LC.Running
          ControlCode.LidControlState = Global.ControlCode.LidControl.RequestClose

        Case LC.Running

          If ControlCode.FullyClosed Then Cancel()

      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = LC.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
