<Command("Depressurise Kier"), _
 Description("This command is used to depressurise the kier"), _
 Category("PressureControl")> _
Public Class DK : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As DK


  ' The possible states of this command
  Public Enum DK
    Off
    Interlock
    WaitDepress
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> DK.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As DK
    Get
      Return state_
    End Get
    Private Set(ByVal value As DK)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.FR.Cancel()
    ControlCode.FL.Cancel()
    ControlCode.PK.Cancel()
    ControlCode.IT.Cancel()
    ControlCode.HT.Cancel()
    ControlCode.OT.Cancel()



    state_ = DK.Interlock

    Return True 'Step On

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case DK.Off

        Case DK.Interlock
          .PressuriseIsRequired = False
          .DepressuriseIsRequired = True
          state_ = DK.WaitDepress

        Case DK.WaitDepress
          If ControlCode.PressureIsSafe Then Cancel()



      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = DK.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
