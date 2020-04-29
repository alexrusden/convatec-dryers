<Command("Pressurise Kier"), _
 Description("This command is used to pressurise the kier to the programmed pressure"), _
 Category("PressureControl")> _
Public Class PK : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As PK

  Private DrainDelay As New Timer

  ' The possible states of this command
  Public Enum PK
    Off
    Interlock
    ClearLevelPressure
    Drain
    WaitForPressure
    Done
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> PK.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As PK
    Get
      Return state_
    End Get
    Private Set(ByVal value As PK)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.NP.Cancel()
    ControlCode.DK.Cancel()
    state_ = PK.Interlock



  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case PK.Off

        Case PK.Interlock

          If Not ControlCode.FullyClosed Then Exit Function 'Check lid is closed and locked
          If ControlCode.IO.KierEmptyLevel Then
            .PressuriseIsRequired = False
            .DepressuriseIsRequired = False
            State = PK.ClearLevelPressure
            DrainDelay.TimeRemaining = 2
          Else
            state_ = PK.WaitForPressure
          End If


        Case PK.ClearLevelPressure
          If ControlCode.KierPressure < 1000 Then DrainDelay.TimeRemaining = 2
          If DrainDelay.Finished Then
            State = PK.Drain
          End If


        Case PK.Drain
          If ControlCode.KierPressure < 100 Then
            If ControlCode.IO.KierEmptyLevel Then
              State = PK.ClearLevelPressure
            Else
              State = PK.WaitForPressure
            End If
          End If
        



        Case PK.WaitForPressure
          .PressuriseIsRequired = True
          .DepressuriseIsRequired = False
          If .KierPressure >= .Parameters.WorkingPressureSetting Then state_ = PK.Done

        Case PK.Done
          .PressuriseIsRequired = False
          .DepressuriseIsRequired = False
          Cancel()
          Return True

      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = PK.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
