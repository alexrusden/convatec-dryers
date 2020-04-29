<Command("Clean Kier"), _
 Description("This command is used to clean the kier. Fill the Kier up to level 2. Heat the Kier to the programmed temperature. Hold for the programmed time. Drain the Kier until level 1 is lost."), _
 Category("TempControl")> _
Public Class CK : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Public state_ As CK
  Public StatusString As String
  Public SettleTimer As New Timer
  Public OverfillTimer As New Timer
  Public HoldTimer As New Timer
  Public KierDrainTimer As New Timer
  Public AtmosDrainTimer As New Timer

  ' The possible states of this command
  Public Enum CK
    Off
    Interlock
    Fill
    Settle
    Heat
    Hold
    InterlockPressure
    DrainAtmos
    Pressurise
    DrainWithPressure
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode


  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> CK.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As CK
    Get
      Return state_
    End Get
    Private Set(ByVal value As CK)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    ControlCode.IT.Cancel()
    ControlCode.CT.Cancel()
    ControlCode.DepressuriseIsRequired = True


    state_ = CK.Interlock

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode

      If (Not .IO.KierFullLevel) Then OverfillTimer.TimeRemaining = .Parameters.CleanOverFillTime
      If .IO.KierEmptyLevel Then KierDrainTimer.TimeRemaining = 5

      Select Case state_

        Case CK.Off

        Case CK.Interlock
          StatusString = "Wait Kier Safe To Fill"
          If .PressureIsSafe And .FullyClosed Then state_ = CK.Fill


        Case CK.Fill
          StatusString = "Filling With Water"
          ControlCode.Parameters.WaterInTheKier = 1
          If .IO.KierFullLevel Then StatusString = "Overfill " & TimerString(OverfillTimer.TimeRemaining) & " Over Fill Time"
          If OverfillTimer.Finished Then
            SettleTimer.TimeRemaining = .Parameters.CleanFillSettleTime
            state_ = CK.Settle
          End If



        Case CK.Settle
          StatusString = "Settle Time " & TimerString(SettleTimer.TimeRemaining) & " Settle Time"
          If (Not .IO.KierFullLevel) Then state_ = CK.Fill

          If SettleTimer.Finished Then
            state_ = CK.Heat
          End If

        Case CK.Heat
          StatusString = "Heating to " & .Parameters.CleanTemperatureSetting & "C"
          If Not .PressureIsSafe Then State = CK.InterlockPressure
          If .IO.InletTemperature >= (.Parameters.CleanTemperatureSetting * 10) Then
            HoldTimer.TimeRemaining = .Parameters.CleanHoldTime * 60
            state_ = CK.Hold
          End If



        Case CK.Hold
          StatusString = "Holding Time " & TimerString(HoldTimer.TimeRemaining)
          'If Not .PressureIsSafe Then State = CK.InterlockPressure
          If HoldTimer.Finished Then
            AtmosDrainTimer.TimeRemaining = ControlCode.Parameters.GravityDrainTime
            state_ = CK.DrainAtmos
          End If



        Case CK.InterlockPressure
          If .PressureIsSafe Then State = CK.Heat

          If (ControlCode.IO.PT1Pressure >= ControlCode.Parameters.KierMaximumPressure) Or (ControlCode.IO.PT2Pressure >= ControlCode.Parameters.KierMaximumPressure) Then
            State = CK.DrainAtmos
            ControlCode.Alarms.CleaningCycleAborted = True
          End If




        Case CK.DrainAtmos
          StatusString = "Gravity Drain Kier  " & TimerString(AtmosDrainTimer.TimeRemaining)
          If ControlCode.IO.KierFullLevel Then AtmosDrainTimer.TimeRemaining = ControlCode.Parameters.GravityDrainTime
          If AtmosDrainTimer.Finished Then State = CK.Pressurise


        Case CK.Pressurise
          StatusString = "Pressurising Kier"
          If (ControlCode.KierPressure >= 1000) Then State = CK.DrainWithPressure


        Case CK.DrainWithPressure
          StatusString = "Pressure Drain Kier  " & TimerString(KierDrainTimer.TimeRemaining)
         
          If KierDrainTimer.Finished And ControlCode.KierPressure < 100 Then
            ControlCode.Parameters.WaterInTheKier = 0
            Cancel()
          End If



      End Select

    End With

  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = CK.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
