<Command("Fan Speed", "I/O |0-100|%  O/I |0-100|%"), _
 Description("This command is used to program the percentage speed for IO (In-Out) and OI (Out-In) flow. This command should be used in conjunction with the FR (Flow Reversal) or the FL (Flow) commands."), _
 Category("Time")> _
Public Class FS : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As FS
  Public FanSetSpeedInToOut As Integer
  Public FanSetSpeedOutToIn As Integer

  ' The possible states of this command
  Public Enum FS
    Off
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode
  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> FS.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As FS
    Get
      Return state_
    End Get
    Private Set(ByVal value As FS)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start


    ControlCode.FP.Cancel()

    FanSetSpeedInToOut = param(1) * 10 'Set fan speed in toout

    FanSetSpeedOutToIn = param(2) * 10 'set fan speedout to in

    State = FS.Running

    Return True 'Step on

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
  End Function

  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = FS.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
