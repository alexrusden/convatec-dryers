<Command("Flow  ", "SIO |0-9|"), _
 Description("This command is used to program the direction of the fan if the FR (flow reversals) command is not used. It can also be used to stop the fan"), _
 Category("Flow")> _
Public Class OL : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As OL


  ' The possible states of this command
  Public Enum OL
    Off
    FlowFwds
    FlowRev
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> OL.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As OL
    Get
      Return state_
    End Get
    Private Set(ByVal value As OL)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.FR.Cancel()

    If param(1) = 0 Then Cancel()
    If param(1) = 1 Then state_ = OL.FlowFwds
    If param(1) = 2 Then state_ = OL.FlowRev






  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run

    Select Case state_

      Case OL.FlowFwds

      Case OL.FlowRev

    End Select



  End Function

  Public ReadOnly Property FlowIsInToOut() As Boolean
    Get
      Return State = OL.FlowFwds
    End Get
  End Property

  Public ReadOnly Property FlowIsOutToIn() As Boolean
    Get
      Return State = OL.FlowRev
    End Get
  End Property

  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = OL.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
