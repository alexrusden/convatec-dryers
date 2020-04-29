<Command("Drain Kier"), _
 Description("This command is used to drain the kier. "), _
 Category("LidControl")> _
Public Class DR : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As DR


  ' The possible states of this command
  Public Enum DR
    Off
    Draining

  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> DR.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As DR
    Get
      Return state_
    End Get
    Private Set(ByVal value As DR)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands


    state_ = DR.Draining


    ControlCode.CK.state_ = CK.CK.DrainAtmos



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case DR.Off

        Case DR.Draining
          If ControlCode.CK.IsOn Then Exit Function
          Cancel()



      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = DR.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
