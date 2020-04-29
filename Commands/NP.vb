<Command("Nitrogen Purge", "Number of Purges |0-9|"), _
 Description("This command purges the kier with Nitrogen to remove all the oxygen"), _
 Category("Pressure")> _
Public Class NP : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As NP

  Public NumberOfPurgesReq As Integer
  Public NumberOfPurges As Integer
  Public StatusString As String
  Public HoldTimer As New Timer

  ' The possible states of this command
  Public Enum NP
    Off
    Interlock
    Pressurise
    Hold
    CheckNumberOfPurges
    Depressurise
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode





  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> NP.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As NP
    Get
      Return state_
    End Get
    Private Set(ByVal value As NP)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.FR.Cancel()
    ControlCode.FL.Cancel()
    ControlCode.PK.Cancel()

    NumberOfPurges = 0

    NumberOfPurgesReq = param(1)


    State = NP.Interlock

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case NP.Interlock
          If Not .FullyClosed Then Exit Function 'Wait until lid is locked
          If .IO.KierFullLevel Or .IO.KierEmptyLevel Then Exit Function 'Wait kier is empty
          state_ = NP.Pressurise

        Case NP.Pressurise
          StatusString = "N/Purge >" & .Parameters.PurgePressureSetting & "mBar : " & NumberOfPurges & "/" & NumberOfPurgesReq
          .PressuriseIsRequired = True
          .DepressuriseIsRequired = False
          If .KierPressure >= .Parameters.PurgePressureSetting Then
            HoldTimer.TimeRemaining = 10
            state_ = NP.Hold
          End If


        Case NP.Hold
          StatusString = "Nitrogen Purge  " & " Holding: " & TimerString(HoldTimer.TimeRemaining)
          If HoldTimer.Finished Then
            NumberOfPurges = NumberOfPurges + 1
            State = NP.CheckNumberOfPurges
          End If


        Case NP.CheckNumberOfPurges
          If NumberOfPurges >= NumberOfPurgesReq Then
            Cancel()
          Else
            state_ = NP.Depressurise
          End If



        Case NP.Depressurise
          StatusString = "Nitrogen Purge Count: " & NumberOfPurges & "/" & NumberOfPurgesReq
          .DepressuriseIsRequired = True
          .PressuriseIsRequired = False
          If .PressureIsSafe Then state_ = NP.Interlock


      End Select


    End With
  End Function



  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = NP.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
