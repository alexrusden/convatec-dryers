Public Class ControlCode : Inherits MarshalByRefObject : Implements ACControlCode
  ' Standard definitions
  Public Parent As ACParent
  Public Alarms As New Alarms, IO As IO, Parameters As New Parameters
  '-------------------------------------

  ' Delays
  Public Delays_TooSlow As Boolean


  ' Commands 
  Public FS As New FS(Me)
  Public FR As New FR(Me)
  Public HT As New HT(Me)
  Public FL As New FL(Me)
  Public FP As New FP(Me)
  Public IT As New IT(Me)
  Public NP As New NP(Me)
  Public OT As New OT(Me)
  Public CT As New CT(Me)
  Public PK As New PK(Me)
  Public DK As New DK(Me)
  Public CK As New CK(Me)
  Public LC As New LC(Me)
  Public LO As New LO(Me)
  Public FT As New FT(Me)
  Public DR As New DR(Me)
  Public WP As New WP(Me)

  ' Timers
  Public PressureSafeTimer As New Timer

  Public PressSaveValue As Integer

  Public OneSecTimer As New Timer
  Public OneSec As Boolean

  ' General variables
  Public PressureIsSafe As Boolean
  Public OverPressure As Boolean
  Public FanRequired As Boolean

  Public RequestOpenLid As Boolean
  Public RequestCloseLid As Boolean
  '-----------------------------------------
  Public FullyOpen As Boolean
  Public FullyClosed As Boolean

  Public ShouldBeOpen As Boolean
  Public ShouldBeClosed As Boolean
  '-----------------------------------------
  Public PressuriseIsRequired As Boolean

  Public DepressuriseIsRequired As Boolean

  Public KierPressure As Integer

  Public DepressedFailedDelay As New Timer
  '-----------------------------------------
  Public LidMovement As Boolean
  Public LidControlState As LidControl
  Public DifferentialPressure As Integer
  Public ProgramSetSpeed As Integer

  Public Statusalarm As String

  Public lampLatch As Boolean

  Public StartBatch As Boolean

  Friend PressButton As Boolean

  Public RevTimer As Integer

  Public UserName As String

  Public FanCurrentDV As Double

  Public MaxTempRange As Integer

  Public HeatingValveDV As Short

  Public ReScaleOutput As Integer

  Public DisplayCKTemp As Integer

  Public Enum EventID
    LogIn
    LogOut
    StartCycle
    AbortCycle
    UserName
  End Enum
  Public Enum LidControl
    Off
    RequestOpen
    RequestClose
  End Enum
  Public Function GetPercent(ByVal Value As Long, ByVal MinValue As Long, ByVal MaxValue As Long) As Long
    On Error GoTo Err_GetPercent

    Dim Range As Long, Offset As Long
    Range = MaxValue - MinValue
    Offset = Value - MinValue
    GetPercent = MinMax(CInt((Offset * 1000) / Range), 0, 1000)
    Exit Function

Err_GetPercent:
    GetPercent = -1
  End Function



  Public Sub New(ByVal parent As ACParent)
    Me.Parent = parent



    ' Load the tool images
    Dim il As New ImageList
    With il
      .ImageSize = New Size(16, 16) : .TransparentColor = Color.Magenta
      .Images.AddStrip(My.Resources.ToolImages)
    End With

    parent.AddStandardButton(StandardButton.IO, ButtonPosition.Expert)
    parent.AddStandardButton(StandardButton.Programs, ButtonPosition.Expert)
    parent.AddStandardButton(StandardButton.Variables, ButtonPosition.Expert)
    parent.AddStandardButton(StandardButton.Parameters, ButtonPosition.Expert)


    parent.AddButton(New ToolStripButton("Edit Users", il.Images(1)), ButtonPosition.Expert, New EditUsers)


    parent.AddStandardButton(StandardButton.WorkList, ButtonPosition.Operator)
    parent.AddStandardButton(StandardButton.Program, ButtonPosition.Operator)
    parent.AddStandardButton(StandardButton.Graph, ButtonPosition.Operator)
    parent.AddStandardButton(StandardButton.Mimic, ButtonPosition.Operator)
    parent.AddStandardButton(StandardButton.History, ButtonPosition.Operator)
    parent.AddButton(New ToolStripSeparator, ButtonPosition.Operator)
    parent.AddButton(New ToolStripSeparator, ButtonPosition.Operator)
    parent.AddButton(New ToolStripSeparator, ButtonPosition.Operator)
    parent.AddButton(New ToolStripSeparator, ButtonPosition.Operator)
    parent.AddButton(New ToolStripSeparator, ButtonPosition.Operator)

    parent.AddButton(New ToolStripButton("Enter New Cycle", il.Images(1)), ButtonPosition.Operator, New NewCycleView)
    parent.AddButton(New ToolStripButton("Abort Program", il.Images(1)), ButtonPosition.Operator, New StopCycleView)

    IO = New IO(parent.Setting("IpAddress"), Me)
    ' parent.SetStatusView(New Status)

  End Sub

  ' Called all the time to run the control.
  Private Sub Run() Implements ACControlCode.Run
    '----------------------------------------------------------------------------
    MaxTempRange = 123

    PressSaveValue = PressureSafeTimer.TimeRemaining
    '----------------------------------------------------------------------------------
    Static TestTimer As New Timer

    If Not Parent.IsProgramRunning Then
      TestTimer.TimeRemainingMs = 500
      Parent.SetButtonVisible(ButtonPosition.Operator, 6, False)
    Else
      Parent.SetButtonVisible(ButtonPosition.Operator, 6, True)
    End If


    'If TestTimer.Finished Then
    '  If Parameters.TestGoDown = 1 Then
    '    Parameters.TestGoUp = 0

    '    IO.InletTemperature = CShort(IO.InletTemperature - 1)

    '  End If

    '  If Parameters.TestGoUp = 1 Then
    '    Parameters.TestGoDown = 0
    '    IO.InletTemperature = CShort(IO.InletTemperature + 1)
    '  End If

    '  TestTimer.TimeRemainingMs = 500
    'End If


    '-----------------------------------------------------------------------------------------------------
    'Default Parameter Settings - Give the parameters a valve if set to zero
    '------------------------------------------------------------------------------------------------------
    If Parameters.PressureSafeDelayTime = 0 Then Parameters.PressureSafeDelayTime = 30
    If Parameters.WorkingPressureSetting = 0 Then Parameters.WorkingPressureSetting = 2500
    If Parameters.PurgePressureSetting = 0 Then Parameters.PurgePressureSetting = 1500

    If Parameters.DefaultFanSpeed = 0 Then Parameters.DefaultFanSpeed = 80
    If Parameters.FlowDwellTime = 0 Then Parameters.FlowDwellTime = 5
    If Parameters.MaxInToOutPressure = 0 Then Parameters.MaxInToOutPressure = 500
    If Parameters.MaxOutToInPressure = 0 Then Parameters.MaxOutToInPressure = 500
    If Parameters.FanCurrentAt10Percent = 0 Then Parameters.FanCurrentAt10Percent = 10
    If Parameters.FanCurrentAt20Percent = 0 Then Parameters.FanCurrentAt20Percent = 20
    If Parameters.FanCurrentAt30Percent = 0 Then Parameters.FanCurrentAt30Percent = 30
    If Parameters.FanCurrentAt40Percent = 0 Then Parameters.FanCurrentAt40Percent = 40
    If Parameters.FanCurrentAt50Percent = 0 Then Parameters.FanCurrentAt50Percent = 50
    If Parameters.FanCurrentAt60Percent = 0 Then Parameters.FanCurrentAt60Percent = 60
    If Parameters.FanCurrentAt70Percent = 0 Then Parameters.FanCurrentAt70Percent = 70
    If Parameters.FanCurrentAt80Percent = 0 Then Parameters.FanCurrentAt80Percent = 80
    If Parameters.FanCurrentAt90Percent = 0 Then Parameters.FanCurrentAt90Percent = 90
    If Parameters.FanCurrentAt100Percent = 0 Then Parameters.FanCurrentAt100Percent = 100
    If Parameters.FanMaximumCurrent = 0 Then Parameters.FanMaximumCurrent = 500
    If Parameters.KierMaximumTemperature = 0 Or (Parameters.KierMaximumTemperature > 130) Then Parameters.KierMaximumTemperature = 1200
    If Parameters.TemperatureSmoothing = 0 Then Parameters.TemperatureSmoothing = 10

    If Parameters.KierMaximumPressure = 0 Or Parameters.KierMaximumPressure > 3500 Then Parameters.KierMaximumPressure = 3500
    If Parameters.FanMotorMaxTemp = 0 Then Parameters.FanMotorMaxTemp = 60
    If Parameters.CleanFillSettleTime = 0 Then Parameters.CleanFillSettleTime = 10
    If Parameters.CleanHoldTime = 0 Then Parameters.CleanHoldTime = 10
    If Parameters.GravityDrainTime = 0 Then Parameters.GravityDrainTime = 300
    If Parameters.CleanTemperatureSetting = 0 Then Parameters.CleanTemperatureSetting = 80
    If Parameters.CleanOverFillTime = 0 Then Parameters.CleanOverFillTime = 3
    If Parameters.CleanHeatPropBand = 0 Then Parameters.CleanHeatPropBand = 20

    ' If Parameters.ITHeatPropBand = 0 Then Parameters.ITHeatPropBand = 20
    If Parameters.CTCoolingPropBand = 0 Then Parameters.CTCoolingPropBand = 20

    If Parameters.FinalTempCoolingPercent = 0 Then Parameters.FinalTempCoolingPercent = 100

    If Parameters.MaximumTemp1Range = 0 Then Parameters.MaximumTemp1Range = 1500
    If Parameters.MaximumTemp2Range = 0 Then Parameters.MaximumTemp2Range = 1500
    If Parameters.MaximumTemp3Range = 0 Then Parameters.MaximumTemp3Range = 1500
    If Parameters.MaximumTemp4Range = 0 Then Parameters.MaximumTemp4Range = 1500
    If Parameters.MaximumTemp5Range = 0 Then Parameters.MaximumTemp5Range = 1500

    If Parameters.CKHeatValveMaxOpen = 0 Then Parameters.CKHeatValveMaxOpen = 50

    With Parameters
      If .PT1PressureSetZero = 0 Then .PT1PressureSetZero = 6273
      If .PT2PressureSetZero = 0 Then .PT2PressureSetZero = 6273
      If .PT1PressureSet100Percent = 0 Then .PT1PressureSet100Percent = 31192
      If .PT2PressureSet100Percent = 0 Then .PT2PressureSet100Percent = 31192
      If .PT1PressureRange = 0 Then .PT1PressureRange = 6000
      If .PT2PressureRange = 0 Then .PT2PressureRange = 6000
    End With

    '-----------------------------------------------------------------------------------------------------
    'Remote push Buttons
    Parent.PressButtons(IO.RemoteRun Or PressButton, IO.RemoteHalt, False, IO.RemoteYes, IO.RemoteNo)
    '-----------------------------------------------------------------------------------------------------
    'OneSec

    If OneSecTimer.Finished Then
      OneSecTimer.TimeRemainingMs = 1000
    End If

    OneSec = OneSecTimer.TimeRemainingMs >= 500 'Give me a pulse every sec
    '-----------------------------------------------------------------------------------------------------
    'Pressure  Control
    '----------------------------------------------------------------------------------------------------

    If IO.PT2Pressure > IO.PT1Pressure Then
      KierPressure = IO.PT2Pressure
    Else
      KierPressure = IO.PT1Pressure
    End If


    OverPressure = (IO.PT1Pressure > 3500) Or (IO.PT2Pressure > 3500) 'Over Presure varable


    If (Not IO.KierPressureSafe) Or (IO.PT1Pressure > 200) Or (IO.PT2Pressure > 200) _
    Then PressureSafeTimer.TimeRemaining = Parameters.PressureSafeDelayTime

    PressureIsSafe = PressureSafeTimer.Finished 'Pressure safe variable

    If Not Parent.IsProgramRunning Then DepressuriseIsRequired = True ' If there is no program running depressurise

    If DepressuriseIsRequired Then PressuriseIsRequired = False

    If (Not IO.KierFullLevel) And (Not IO.KierEmptyLevel) Then Parameters.WaterInTheKier = 0

    With IO 'Outputs for Pressure Control
      'Output

      If (CK.IsOn And CK.State = Global.CK.CK.Pressurise) Or (PK.State = Global.PK.PK.ClearLevelPressure) Then
        .Pressurise = True
      Else
        .Pressurise = PressuriseIsRequired And (KierPressure < (Parameters.WorkingPressureSetting)) And FullyClosed And (Not IO.KierFullLevel) And (Parameters.WaterInTheKier = 0)

      End If
      'Output
      .Depressurise = DepressuriseIsRequired And (Not CK.IsOn) And (Parameters.WaterInTheKier = 0)
    End With
    '--------------------------------------------------------------------------------------------
    'Outputs Cleaning
    '--------------------------------------------------------------------------------------------
    With IO
      'Output
      .KierWaterFill = CK.State = Global.CK.CK.Fill And PressureIsSafe And FullyClosed
      'Output
      .KierWaterVent = CK.IsOn And (Not CK.State = Global.CK.CK.Pressurise) And (Not CK.State = Global.CK.CK.DrainWithPressure)
      'Output


      'If Parent.IsProgramRunning Then
      '  .KierWaterDrain = PressureIsSafe And CK.State = Global.CK.CK.DrainAtmos And (Not IO.FanRunning) And (Not IO.FanCoolerMotorRunning) And FullyClosed
      'Else
      '  .KierWaterDrain = PressureIsSafe
      'End If


      'Output

      'Output
      If CK.State = Global.CK.CK.DrainAtmos Or CK.State = Global.CK.CK.DrainWithPressure Then
        If CK.State = Global.CK.CK.DrainAtmos Then
          .SumpDrain = True
          .CondenserDrain = True
        Else
          .SumpDrain = Not IO.KierEmptyLevel
          .CondenserDrain = False
        End If



      Else
        .SumpDrain = IO.Depressurise And (KierPressure <= 200) And (Not CK.IsOn) And (Not IO.KierFullLevel) And (Parameters.WaterInTheKier = 0)
        .CondenserDrain = .SumpDrain
      End If

    End With

    '--------------------------------------------------------------------------------------------
    'Outputs Heating & Cooling
    '--------------------------------------------------------------------------------------------






    If Not Parent.IsProgramRunning Then
      IO.HeatingValve = 0 'DEFAULT OFF
      IO.CoolingValve = 0 'DEFAULT OFF
    End If







    HeatingValveDV = 0

    If IT.IsOn Then 'Control heating with IT Command
      HeatingValveDV = CShort(CShort(IT.HeatControlOutput))
    End If



    '------------------------------------------------------------------------------------------------------------------

    Static Integral As Integer
    Static TempGoingUp As Boolean
    Static TempGoingDown As Boolean
    Static LastTemp As Integer
    Static TempErrorInlet As Integer
    Static CleanHeatValve As Short
    Static AdjustNow As Boolean


    Static TempCheckTimer As New Timer

    If TempCheckTimer.Finished Then
      TempGoingUp = False
      TempGoingDown = False


      If IO.InletTemperature > LastTemp Then
        TempGoingUp = True
        TempGoingDown = False
      End If

      If IO.InletTemperature < LastTemp Then
        TempGoingUp = False
        TempGoingDown = True
      End If

      AdjustNow = True
      LastTemp = IO.InletTemperature
      TempCheckTimer.TimeRemaining = Parameters.CleanHeatChangeDelay
    End If

    TempErrorInlet = MinMax((Parameters.CleanTemperatureSetting * 10) - IO.InletTemperature, 0, 1000)

    DisplayCKTemp = HeatingValveDV * 10
    '-----------------------------------------------------------------------------
    If CK.IsOn And (CK.State = Global.CK.CK.Heat Or CK.State = Global.CK.CK.Hold) Then  'Control heating with CK Command

      CleanHeatValve = CShort(MinMax(((TempErrorInlet * 1000) \ (Parameters.CleanHeatPropBand * 10)), 0, Parameters.CKHeatValveMaxOpen * 10))


      If AdjustNow Then
        If IO.InletTemperature < (Parameters.CleanTemperatureSetting * 10) And (IO.HeatingValve < Parameters.CKHeatValveMaxOpen * 10) Then
          If AdjustNow Then
            If Not TempGoingUp Then Integral = Integral + Parameters.CleanHeatMaxChange * 10
          End If
        End If

        If IO.InletTemperature > (Parameters.CleanTemperatureSetting * 10) And (IO.HeatingValve > 0) Then
          If AdjustNow Then
            If Not TempGoingDown Then Integral = Integral - Parameters.CleanHeatMaxChange * 10
          End If
        End If

        AdjustNow = False
      End If



      Integral = (MinMax(Integral, 0, 1000))


      HeatingValveDV = CShort(CleanHeatValve + Integral)

      HeatingValveDV = CShort((MinMax(HeatingValveDV, 0, 1000)))

      DisplayCKTemp = CleanHeatValve


    Else
      Integral = 0
    End If


    ' Static DivideBy As Integer
    'DivideBy = CInt(100 / Parameters.InletHeatValveMaxOpen) 'Set The max output

    'ReScaleOutput = CInt(HeatingValveDV / DivideBy)

    '-----------------------------------------------------------------------------------------------------------------
    'INTERLOCK



    If Parent.IsPaused Or (Not Parent.IsProgramRunning) Or (IO.InletTemperature > Parameters.KierMaximumTemperature * 10) Then
      HeatingValveDV = 0
    End If

    Static HeatLatch As Boolean

    If OneSec And (Not HeatLatch) Then 'Final Output to Heating valve
      If IO.HeatingValve < HeatingValveDV Then IO.HeatingValve = CShort(IO.HeatingValve + 20) 'Ramp it up slowly
    End If

    HeatLatch = OneSec

    If IO.HeatingValve > HeatingValveDV Then
      IO.HeatingValve = CShort(HeatingValveDV)
    End If

    'If CK.IsOn Then
    '  IO.HeatingValve = CShort(MinMax(IO.HeatingValve, 0, Parameters.CKHeatValveMaxOpen * 10)) 'THE OUTPUT
    'Else
    IO.HeatingValve = CShort(MinMax(IO.HeatingValve, 0, 1000)) 'THE OUTPUT
    ' End If


    If (CK.State = Global.CK.CK.Heat Or CK.State = Global.CK.CK.Hold) And (Not PressureIsSafe) Then
      IO.HeatingValve = 0
    End If

    If (IO.InletTemperature > Parameters.KierMaximumTemperature * 10) Then IT.Cancel()
    '------
    '-------------------------------------------------
    'Cooling
    IO.CoolingValve = 0


    If CT.IsOn Then
      IO.CoolingValve = CShort(CT.CoolerValveOutPut)
    End If

    If FT.IsOn Then IO.CoolingValve = CShort((Parameters.FinalTempCoolingPercent) * 10)

    '----------

    '--------------------------------------------------------------------------------------------
    'Outputs Flow & Fan
    '--------------------------------------------------------------------------------------------
    With IO
      'Output
      .FlowChanger = FR.FlowIsOutToIn Or FL.FlowIsOutToIn
      'Output

      RevTimer = FR.Timer.TimeRemaining

      .FanCoolerMotor = IO.FanRunning And (Not IO.FanInverterFault) And (Not Alarms.CoolerFanMotorFault) And FullyClosed And (Parameters.NoCoolerMotor <> 1)

      '-------
      If .Pressurise Or FR.IsOn Or FL.IsOn Then .FanSeal = True
      If .Depressurise And (KierPressure <= 500) And (Not CK.IsOn) And (Not IO.FanRun) Then .FanSeal = False
      '------
      Static FanOnDelay As New Timer
      If (Not .FanSeal) Then FanOnDelay.TimeRemaining = 2 'Fan Seal on first then start fan


      If Parameters.NoCoolerMotor = 1 Then
        .FanRun = FanOnDelay.Finished And (FR.IsOn Or FL.IsOn) And IO.ShootBoltIn And (Not IO.FanInverterFault) And FullyClosed
      Else
        .FanRun = FanOnDelay.Finished And (FR.IsOn Or FL.IsOn) And IO.ShootBoltIn And (Not IO.FanInverterFault) And (Not Alarms.CoolerFanMotorFault) And (Not Alarms.CoolerFanMotorNotRunning) And FullyClosed
        'Output
      End If



      'Output

      If CK.IsOn And (CK.State = Global.CK.CK.DrainWithPressure Or CK.State = Global.CK.CK.DrainAtmos) Or (PK.State = Global.PK.PK.Drain) Then

        If CK.State = Global.CK.CK.DrainAtmos Then
          .HeatExchangeDrain = True
        Else
          .HeatExchangeDrain = Not .FanDrain
        End If

        .FanDrain = IO.KierEmptyLevel


      Else
        .FanDrain = .Depressurise And (KierPressure <= 500) And (Not IO.FanRunning) And (Not IO.FanCoolerMotorRunning)
        .HeatExchangeDrain = False
      End If



      ''Output
      'If Parent.IsProgramRunning Then
      '  .HeatExchangeDrain = PressureIsSafe And CK.State = Global.CK.CK.DrainAtmos And (Not IO.FanRunning) And (Not IO.FanCoolerMotorRunning) And FullyClosed
      'Else
      '  .HeatExchangeDrain = PressureIsSafe
      'End If





      .TrapIsolationValve = Not CK.IsOn And (Parameters.WaterInTheKier = 0)

    End With


    '--------------------------------------------------------------------------------------------
    'Fan Speed Control
    '--------------------------------------------------------------------------------------------



    If FP.IsOn Then
      IO.FanSpeed = CShort(FP.ControlSpeed)
    End If


    If FS.IsOn Then
      If IO.FlowChanger Then
        IO.FanSpeed = CShort(FS.FanSetSpeedOutToIn)
      Else
        IO.FanSpeed = CShort(FS.FanSetSpeedInToOut)
      End If
    End If

    If FS.IsOn Or FP.IsOn Then

    Else

      IO.FanSpeed = CShort(Parameters.DefaultFanSpeed * 10) 'If No FS Or FP Then default to this speed
    End If





    If Not IO.FanRun Then IO.FanSpeed = 0 'No fan no output
    '--------------------------------
    'Differential Pressure

    DifferentialPressure = (IO.PT1Pressure - IO.PT2Pressure)


    If FR.State = Global.FR.FR.Dwell Then DifferentialPressure = 0


    '--------------------------------------------------------------------------------------------
    'Outputs Alarms and calls
    '--------------------------------------------------------------------------------------------
    IO.AlarmCall = Parent.IsAlarmUnacknowledged
    IO.OperatorCall = Parent.IsSignalUnacknowledged
    IO.Siren = Parent.IsAlarmUnacknowledged Or Parent.IsSignalUnacknowledged


    If IO.AlarmCall Or IO.OperatorCall Or IO.Siren Then Statusalarm = Parent.UnacknowledgedAlarms

    If IO.AlarmCall Or IO.OperatorCall Or IO.Siren Then lampLatch = True
    '--------------------------------------------------------------------------------------------
    'Outputs For Lid Control
    '--------------------------------------------------------------------------------------------
    With IO
      '---------------------------
      'Common to Open and Close

      'Output
      .PressureLidSeal = .ShootBoltIn And .LidIsClosed And .LidRingIsClosed

      'Output
      .VacuumLidSeal = (Not .PressureLidSeal) And (LidControlState = LidControl.RequestClose Or LidControlState = LidControl.RequestOpen) And .LidIsClosed



      '----------------------------


      Select Case LidControlState


        Case LidControl.Off

          .LidOpen = False
          .LidClose = False
          .LidRingOpen = False
          .LidRingClose = False



        Case LidControl.RequestOpen  'Ok we are going to open the lid

          ShouldBeClosed = False

          'Output
          .UnlockShootBolt = PressureIsSafe And (Not .FanRunning) And (Not .FanCoolerMotorRunning) And (Not .KierFullLevel)

          Static OpenRingDelay As New Timer 'Small Delay for Mechanical movement 2 secs
          If .ShootBoltIn Then OpenRingDelay.TimeRemaining = 2

          'Output
          .LidRingOpen = PressureIsSafe And OpenRingDelay.Finished And (Not .LidRingIsOpen)


          Static OpenLidDelay As New Timer 'Small Delay for Mechanical movement 2 secs
          If (Not .LidRingIsOpen) Then OpenLidDelay.TimeRemaining = 2

          'Output
          .LidOpen = PressureIsSafe And OpenLidDelay.Finished And (Not IO.LidIsOpen)
          .LidClose = False

        Case LidControl.RequestClose  'Ok we are going to close the lid

          ShouldBeOpen = False

          .UnlockShootBolt = PressureIsSafe And (Not .FanRunning) And (Not .FanCoolerMotorRunning) And _
                         (Not .KierFullLevel) And (Not .LidRingIsClosed)

          'Output
          .LidRingOpen = PressureIsSafe And (Not .LidRingIsOpen) And (Not .LidIsClosed)
          'Output
          .LidOpen = False
          .LidClose = PressureIsSafe And .LidRingIsOpen And (Not .ShootBoltIn)

          Static LockRingDelay As New Timer 'Small Delay for Mechanical movement 2 secs
          If (Not .LidIsClosed) Or .ShootBoltIn Then LockRingDelay.TimeRemaining = 2

          'Output
          .LidRingClose = PressureIsSafe And LockRingDelay.Finished And .VacuumLidSeal And (Not .LidRingIsClosed)


      End Select


      FullyOpen = .LidIsOpen And .LidRingIsOpen 'set Varable

      FullyClosed = .LidIsClosed And .LidRingIsClosed And .ShootBoltIn  'set Varable

      LidMovement = .LidRingClose Or .LidRingIsOpen Or .LidOpen Or .LidClose  'set Varable


      If FullyClosed Then
        ShouldBeClosed = True
        ShouldBeOpen = False
      End If

      If FullyOpen Then
        ShouldBeClosed = False
        ShouldBeOpen = True
      End If

    End With


    '---------------------------------------------------------------------------------------------
    'ALARMS
    '--------------------------------------------------------------------------------------------

    Static FanMotorMaxTempDelay As New Timer

    Alarms.WaterInKier = (Not CK.IsOn) And Parameters.WaterInTheKier = 1

    Alarms.PressureDetected = (CK.State = Global.CK.CK.InterlockPressure)

    If (IO.FanBearing1Temp Or IO.FanBearing2Temp) > (Parameters.FanMotorMaxTemp * 10) Then

    Else
      FanMotorMaxTempDelay.TimeRemaining = 5
    End If

    Static MaximumFanMotorTemp As Boolean

    MaximumFanMotorTemp = FanMotorMaxTempDelay.Finished

    Alarms.Missing24VdcSupply = Not IO.Control24Volt
    Alarms.EmergencyStopPressed = Not IO.EmergencyStop

    Alarms.CondenserPt100ProbeFault = (IO.CondenserTemperature <= 0) Or (IO.CondenserTemperature > 1500)

    Alarms.OutletPt100ProbeFault = (IO.OutletTemperature <= 0) Or (IO.OutletTemperature > 1500)
    '------
    Static FanCoolerMotorFaultDelay As New Timer
    If (Not IO.FanCoolerMotor) Then FanCoolerMotorFaultDelay.TimeRemaining = 5
    Alarms.CoolerFanMotorNotRunning = FanCoolerMotorFaultDelay.Finished And (Not IO.FanCoolerMotorRunning)
    '-----
    Alarms.CoolerFanMotorFault = IO.FanCoolerMotorFault


    Static CoolingAlarmDelay As New Timer

    If IO.CoolingValve > 0 Then
      If ((IO.CondenserTemperature - 20) <= (CT.CoolerSetpoint * 10)) Then CoolingAlarmDelay.TimeRemaining = 300
      Alarms.CoolingSlow = CoolingAlarmDelay.Finished
    Else
      CoolingAlarmDelay.TimeRemaining = 420
      Alarms.CoolingSlow = False
    End If



    Alarms.LidNotLocked = (PressuriseIsRequired And Not FullyClosed)

    '-----------------------
    'If the lid has been closed and locked and we loose the input then Alarm or 
    'If we are closing the lid and we have no input after a time then Alarm 

    Static LidClosingAlarmDelay As New Timer
    If (Not ShouldBeClosed) And IO.LidClose Then
    Else
      LidClosingAlarmDelay.TimeRemaining = 45
    End If
    Alarms.LidNotClosed = (ShouldBeClosed And (Not IO.LidIsClosed)) Or (LidClosingAlarmDelay.Finished)

    '-----------------------
    'If the lid has been Opened and locked and we loose the input then Alarm or 
    'If we are Opening the lid and we have no input after a time then Alarm 

    Static LidOpeningAlarmDelay As New Timer
    If (Not ShouldBeOpen) And IO.LidOpen And Not IO.LidIsOpen Then
    Else
      LidOpeningAlarmDelay.TimeRemaining = 45
    End If
    Alarms.LidNotOpen = (ShouldBeOpen And (Not IO.LidIsOpen)) Or (LidOpeningAlarmDelay.Finished)

    '-----------------------
    'If the lid has been closed and locked and we loose the input then Alarm or 
    'If we are closing the lid and we have no input after a time then Alarm 

    Static RingClosingAlarmDelay As New Timer
    If (Not ShouldBeClosed) And IO.LidRingIsClosed And (Not IO.LidRingIsClosed) Then
    Else
      LidClosingAlarmDelay.TimeRemaining = 45
    End If
    Alarms.RingNotClosed = (ShouldBeClosed And (Not IO.LidRingIsClosed)) Or (LidClosingAlarmDelay.Finished)
    '--------------------------
    'If the lid has been closed and locked and we loose the input then Alarm or 
    'If we are closing the lid and we have no input after a time then Alarm 

    Static RingOpenAlarmDelay As New Timer
    If (Not ShouldBeOpen) And IO.LidRingOpen And (Not IO.LidRingIsOpen) Then
    Else
      RingOpenAlarmDelay.TimeRemaining = 45
    End If
    Alarms.RingNotOpen = (ShouldBeOpen And (Not IO.LidRingIsOpen)) Or (RingOpenAlarmDelay.Finished)
    '--------------------------
    'And (Parent.Mode = Mode.Run


    Alarms.NoPlcComs = IO.PlcFault



    '-------------------------

    Static PressureSwitchFault As New Timer

    If (KierPressure < 300) And IO.KierPressureSafe Then
      PressureSwitchFault.TimeRemaining = 30
    End If

    If (KierPressure > 300) And (Not IO.KierPressureSafe) Then
      PressureSwitchFault.TimeRemaining = 30
    End If

    Alarms.PressureSwitchFault = PressureSwitchFault.Finished
    '-------------------------
    Alarms.SystemInDebug = Parent.Mode = Mode.Debug And Parent.IsProgramRunning

    Alarms.SystemInOveride = Parent.Mode = Mode.Override And Parent.IsProgramRunning

    Alarms.SystemInTest = Parent.Mode = Mode.Test And Parent.IsProgramRunning
    '-------------------------


    Alarms.SystemPaused = Parent.IsPaused And Parent.IsProgramRunning

    Alarms.KierNotEmpty = NP.State = Global.NP.NP.Interlock And (IO.KierEmptyLevel Or IO.KierFullLevel)

    '------------------------------------------------------------------------------------



    Static FanMinCurrent As Integer
    Static FanMaxCurrent As Integer
    Static FanSpeedMin As Integer
    Static FanSpeedMax As Integer
    '------------------------

    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 10 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)
    'If (IO.FanSpeed > 0 And IO.FanSpeed <= 10) Then FanCurrentDV = (Parameters.FanCurrentAt10Percent)



    If (IO.FanSpeed < 100) Then
      FanMinCurrent = 0
      FanMaxCurrent = (Parameters.FanCurrentAt10Percent)
      FanSpeedMin = 0
      FanSpeedMax = 100
    End If

    If (IO.FanSpeed >= 100 And IO.FanSpeed < 200) Then
      FanMinCurrent = (Parameters.FanCurrentAt10Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt20Percent)
      FanSpeedMin = 100
      FanSpeedMax = 200
    End If

    If (IO.FanSpeed >= 200 And IO.FanSpeed < 300) Then
      FanMinCurrent = (Parameters.FanCurrentAt20Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt30Percent)
      FanSpeedMin = 200
      FanSpeedMax = 300
    End If

    If (IO.FanSpeed >= 300 And IO.FanSpeed < 400) Then
      FanMinCurrent = (Parameters.FanCurrentAt30Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt40Percent)
      FanSpeedMin = 300
      FanSpeedMax = 400
    End If

    If (IO.FanSpeed >= 400 And IO.FanSpeed < 500) Then
      FanMinCurrent = (Parameters.FanCurrentAt40Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt50Percent)
      FanSpeedMin = 400
      FanSpeedMax = 500
    End If

    If (IO.FanSpeed >= 500 And IO.FanSpeed < 600) Then
      FanMinCurrent = (Parameters.FanCurrentAt50Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt60Percent)
      FanSpeedMin = 500
      FanSpeedMax = 600
    End If

    If (IO.FanSpeed >= 600 And IO.FanSpeed <= 700) Then
      FanMinCurrent = (Parameters.FanCurrentAt60Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt70Percent)
      FanSpeedMin = 600
      FanSpeedMax = 700
    End If

    If (IO.FanSpeed >= 700 And IO.FanSpeed < 800) Then
      FanMinCurrent = (Parameters.FanCurrentAt70Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt80Percent)
      FanSpeedMin = 700
      FanSpeedMax = 800
    End If

    If (IO.FanSpeed >= 800 And IO.FanSpeed < 900) Then
      FanMinCurrent = (Parameters.FanCurrentAt80Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt90Percent)
      FanSpeedMin = 800
      FanSpeedMax = 900
    End If

    If (IO.FanSpeed >= 900) Then
      FanMinCurrent = (Parameters.FanCurrentAt90Percent)
      FanMaxCurrent = (Parameters.FanCurrentAt100Percent)
      FanSpeedMin = 900
      FanSpeedMax = 1000
    End If

    Static FanCurrentSetpoint As Double
    Static FanCurrentAlarmDelay As New Timer
    Static GetThePercent As Integer
    Static a As Long
    Static b As Long
    Static c As Double


    If IO.FanSpeed > 0 Then

      GetThePercent = CInt((GetPercent(IO.FanSpeed, FanSpeedMin, FanSpeedMax))) 'What percent between min /max

      a = (FanMaxCurrent * 10) - (FanMinCurrent * 10) 'range

      b = CLng((a * 10) / GetThePercent)

      c = a / b

      FanCurrentSetpoint = (FanMinCurrent) + (c / 10)

      FanCurrentDV = (FanCurrentSetpoint * 20) / 100 '20%

      FanCurrentDV = (FanCurrentSetpoint + FanCurrentDV)

    End If


    If Not IO.FanRunning Then FanCurrentAlarmDelay.TimeRemaining = 30
    If (IO.FanCurrent < FanCurrentDV) Then
      FanCurrentAlarmDelay.TimeRemaining = 10
    End If

    Alarms.FanCurrentExceeded = FanCurrentAlarmDelay.Finished

    '------------------------------------------------------------------------------------




    Alarms.FanInverterFault = IO.FanInverterFault
    '-----
    Static FanMaxCurrentAlarmDelay As New Timer
    If IO.FanCurrent < (Parameters.FanMaximumCurrent) Then FanMaxCurrentAlarmDelay.TimeRemaining = 3
    If Not IO.FanRunning Then FanCurrentAlarmDelay.TimeRemaining = 10
    Alarms.FanMaxCurrentExceeded = FanMaxCurrentAlarmDelay.Finished
    '------

    Static FanRunningAlarmDelay As New Timer
    If Not IO.FanRun Then FanRunningAlarmDelay.TimeRemaining = 3
    Alarms.FanNotRunning = FanRunningAlarmDelay.Finished And (Not IO.FanRunning)

    '------

    Alarms.HeatingSlow = False

    '----

    Alarms.InletPt100ProbeFault = (IO.InletTemperature <= 0) Or (IO.InletTemperature > 1500)

    '----

    Alarms.InsidePressureFault = (IO.PT1Pressure < 0) Or (IO.PT1Pressure > 5000)

    Alarms.InterlockCageSwitch = (Not IO.CageInterlock) And Parent.IsProgramRunning

    Alarms.KierMaxPressureExceeded = KierPressure > Parameters.KierMaximumPressure * 10
    '--------------
    'Level Alarm

    Static LevelAlarmDelay As New Timer
    If IO.KierFullLevel And Not IO.KierEmptyLevel Then
    Else
      LevelAlarmDelay.TimeRemaining = 3
    End If
    Alarms.LevelFault = LevelAlarmDelay.Finished
    '----------------
    Static ShootBoltAlarmDelay As New Timer
    If IO.UnlockShootBolt <> (IO.ShootBoltIn) Then ShootBoltAlarmDelay.TimeRemaining = 3


    Alarms.ShootBoltFault = ShootBoltAlarmDelay.Finished


    If Not IO.Depressurise Then DepressedFailedDelay.TimeRemaining = Parameters.PressureSafeDelayTime + 60
    Alarms.KierHasNotDepressurised = IO.Depressurise And (Not PressureIsSafe) And DepressedFailedDelay.Finished
    '--------------------------------------------------------------------------------------------
    'MAIN INTERLOCKS
    '--------------------------------------------------------------------------------------------
    If (Not IO.Control24Volt) Or (Not IO.EmergencyStop) Or (Not IO.CageInterlock) Then
      IO.SumpDrain = False
      IO.FanRun = False
      IO.FanCoolerMotor = False
      IO.FanDrain = False
      IO.FlowChanger = False
      IO.Pressurise = False
      IO.Depressurise = False
      IO.LidOpen = False
      IO.LidClose = False
      IO.LidRingOpen = False
      IO.LidRingClose = False
      IO.UnlockShootBolt = False
      IO.FanSeal = False
      IO.KierWaterFill = False
      IO.KierWaterVent = False
      IO.CondenserDrain = False
      IO.HeatExchangeDrain = False
      IO.VacuumLidSeal = False
      IO.PressureLidSeal = False
      IO.TrapIsolationValve = False

      IO.HeatingValve = 0
      IO.CoolingValve = 0
      IO.FanSpeed = 0
    End If

    Static StopJob1Latch As Boolean
    '  ((CK.State = Global.CK.CK.Heat Or CK.State = Global.CK.CK.Hold) And (Not IO.KierFullLevel))

    'Temperature and Pressure To High interlock
    If (IO.InletTemperature > Parameters.KierMaximumTemperature * 10) Or (IO.OutletTemperature > Parameters.KierMaximumTemperature * 10) Or _
      Alarms.InletPt100ProbeFault Or MaximumFanMotorTemp Or _
    (IO.PT1Pressure > 3500) Or (IO.PT2Pressure > 3500) Then
      IO.HeatingValve = 0
      IO.Depressurise = True
      IO.Pressurise = False
      PressuriseIsRequired = False
      DepressuriseIsRequired = True
      Alarms.AbortedPressureAtMax = (IO.PT1Pressure > 3500) Or (IO.PT2Pressure > 3500)
      Alarms.KierMaxTempExceeded = (IO.InletTemperature > Parameters.KierMaximumTemperature * 10) Or (IO.OutletTemperature > Parameters.KierMaximumTemperature * 10)
      Alarms.MaximumFanMotorTemp = True
      'Alarms.TopLevelLost = (CK.State = Global.CK.CK.Heat Or CK.State = Global.CK.CK.Hold) And (Not IO.KierFullLevel)
      If (Not StopJob1Latch) And Parent.IsProgramRunning Then
        Parent.StopJob()
        StopJob1Latch = True
      End If

    End If

    If Not Parent.IsProgramRunning Then StopJob1Latch = False

    '--------------------------------------------------------------------------------------------
    'End of main control code and interlocks *** NO Control code after this line ***
    '--------------------------------------------------------------------------------------------

  End Sub

  ' Called to read input values into the given arrays.
  ' You should return true if a cycle of I/O reads has completed without errors.
  Private Function ReadInputs(ByVal dinp() As Boolean, ByVal aninp() As Short, ByVal temp() As Short) As Boolean Implements ACControlCode.ReadInputs
    ' The work is passed over to the IO class
    Return IO.ReadInputs(dinp, aninp, temp) 'here
  End Function

  ' Called to write output values found in the given arrays.
  Private Sub WriteOutputs(ByVal dout() As Boolean, ByVal anout() As Short) Implements ACControlCode.WriteOutputs
    ' The work is passed over to the IO class
    IO.WriteOutputs(dout, anout)
  End Sub

  <ScreenButton("Main", 1, ButtonImage.Vessel), _
   ScreenButton("Temps", 2, ButtonImage.Thermometer)> _
  Private Sub DrawScreen(ByVal screen As Integer, ByVal row() As String) Implements ACControlCode.DrawScreen
    ' For example
    If screen = 1 Then
      row(1) = FR.StatusString

    ElseIf screen = 2 Then
      row(1) = "Temperature Screen"
      row(2) = "Not Used"
    End If
  End Sub

  ' Return a suitable message to display on the status line at the top.
  Public ReadOnly Property Status() As String
    Get

      If HT.State = Global.HT.HT.WaitTemp Then Return "Wait Inlet  >= " & IT.InletTempSetpoint & "C"

      If FT.State = Global.FT.FT.WaitForTemp Then Return "Cooling To " & FT.FinalTempSetting & "C"


      If OT.State = Global.OT.OT.WaitForTemp Or OT.State = Global.OT.OT.WaitForTemp Then Return "Drying To " & OT.FinalTempDV & "C"

      If OT.State = Global.OT.OT.Settle Then Return "Drying Settle Time " & OT.SettleTime.TimeRemaining

      If DK.IsOn And DK.State = Global.DK.DK.Interlock Then Return "Waiting Fan Stopped"

      If IO.Depressurise And Not PressureIsSafe Then Return "Depressurising " & TimerString(PressureSafeTimer.TimeRemaining)

      If LidControlState = LidControl.RequestOpen And Not PressureIsSafe Then Return "Wait Kier Pressure Safe " & TimerString(PressureSafeTimer.TimeRemaining)

      If LO.IsOn Then Return "Lid Opening"

      If LC.IsOn Then Return "Lid Closing"

      If PK.State = Global.PK.PK.WaitForPressure Then Return "Pressurising Kier"

      If PK.State = Global.PK.PK.ClearLevelPressure Or PK.State = Global.PK.PK.Drain Then Return "Clearing Level"

      If DK.State = Global.DK.DK.WaitDepress Then Return "Depressurising Kier"

      If CK.IsOn Then Return CK.StatusString

      If WP.IsOn Then Return WP.StatusString

      If HT.IsOn Then Return HT.StatusString

      
      If NP.IsOn Then Return NP.StatusString



      If Parent.IsProgramRunning Then Return "Program Running"
      Return "No Program Running"
    End Get
  End Property

  ' Return the main value of temperature, to go in the status line at the top.
  Public ReadOnly Property Temperature() As String
    Get
      Return IO.OutletTemperature / 10 & "°C"
    End Get
  End Property

  ' Called just once when the control system starts up for the first time.
  ' This will be shortly after our Sub New() has been called.  
  ' Any other control systems will have been created at this time.
  Private Sub StartUp() Implements ACControlCode.StartUp


    DepressedFailedDelay.TimeRemaining = 30


    PressureSafeTimer.TimeRemaining = 20

    If Parent.Setting("Debug") = "1" Then

      Parent.Mode = Mode.Debug

      IO.Control24Volt = True
      IO.LidIsClosed = True
      IO.LidRingIsClosed = True
      IO.EmergencyStop = True
      IO.CageInterlock = True
      IO.KierPressureSafe = True
      IO.ShootBoltIn = True

      IO.OutletTemperature = 200
      IO.InletTemperature = 200
      IO.CondenserTemperature = 200
      IO.FanBearing1Temp = 200
      IO.FanBearing2Temp = 200

    End If

    Parent.PressButton(ButtonPosition.Operator, 3)


  End Sub

  ' Called just once when the control system is being shut down.  
  ' At this time, there will be approximately 3 seconds remaining 
  ' before ReadInputs, Run and WriteOutputs stop being called.
  Private Sub ShutDown() Implements ACControlCode.ShutDown
  End Sub

  ' Called each time a job (program) starts.
  Private Sub ProgramStart() Implements ACControlCode.ProgramStart

    Alarms.MaximumFanMotorTemp = False

    Alarms.AbortedPressureAtMax = False

    Alarms.CleaningCycleAborted = False

    Parent.LogEvent(LogEventType.Information, EventID.UserName, UserName)


  End Sub


  ' Called each time a job (program) stops.
  Private Sub ProgramStop() Implements ACControlCode.ProgramStop
    FanRequired = False

    'Dim history As Object = Parent.History
    'If history IsNot Nothing Then
    '  ' We store dates in local time in the database so as not to confuse people
    '  Dim startTime As Date = DirectCast(history.GetType.GetProperty("StartTime").GetValue(history, Nothing), Date).ToLocalTime, _
    '      endTime As Date = DirectCast(history.GetType.GetProperty("EndTime").GetValue(history, Nothing), Date).ToLocalTime, _
    '      saveAsBytes() As Byte = DirectCast(history.GetType.GetMethod("SaveAsBytes", Type.EmptyTypes).Invoke(history, Nothing), Byte())
    '  Parent.DbExecute("INSERT INTO Batches (Batch, StartTime, EndTime, Passed, History) VALUES (" & _
    '                    Parent.DbSqlString(Parent.Job) & ", " & Parent.DbSqlString(startTime) & ", " & _
    '                     Parent.DbSqlString(endTime) & _
    '                     ", @History)", "@History", saveAsBytes)
    'End If
  End Sub
End Class
