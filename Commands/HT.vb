<Command("Hold Time", "|0-99|:|0-99| Minutes/Seconds"), _
 Description("This command allows all active commands to run for the programmed time before advancing to the next step."), _
 Category("Time")> _
Public Class HT : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As HT
  Public StatusString As String
  Public HoldTime As Integer
  Public HoldTimer As New Timer

  ' The possible states of this command
  Public Enum HT
    Off
    WaitTemp
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> HT.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As HT
    Get
      Return state_
    End Get
    Private Set(ByVal value As HT)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    HoldTime = param(1) * 60 + param(2)

    HoldTimer.TimeRemaining = HoldTime

    ControlCode.WP.Cancel()

    State = HT.WaitTemp



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run

    Select Case state_

      Case HT.WaitTemp
        HoldTimer.TimeRemaining = HoldTime

        If ControlCode.OT.IsOn Then
          State = HT.Running
        End If

        If ControlCode.IT.IsOn Then
          If ControlCode.IO.InletTemperature >= (ControlCode.IT.InletTempSetpoint * 10) Then State = HT.Running
        Else
          State = HT.Running
        End If


      Case HT.Running
        StatusString = "Hold Time " & TimerString(HoldTimer.TimeRemaining)
        If HoldTimer.Finished Then Cancel()
    End Select



  End Function

  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = HT.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
