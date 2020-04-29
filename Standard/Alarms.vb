Public Class Alarms 
  <Description("The 24Vdc supply to the panel is missing. Check circuit breakers.")> _
    Public Missing24VdcSupply As Boolean

  <Description("The emergency stop has been activated.")> _
  Public EmergencyStopPressed As Boolean

  <Description("There is a fault with the reading from the Condenser Temperature probe.")> _
 Public CondenserPt100ProbeFault As Boolean

  <Description("There is a fault with the reading from the outlet Temperature probe.")> _
Public OutletPt100ProbeFault As Boolean

  <Description("The cooler fan motor is showing a fault condition. Reset the Cooler Fan motor. If the fault continues then an engineer must check out the motor.")> _
 Public CoolerFanMotorFault As Boolean

  <Description("The software is requesting the cooler fan to run but there is no running signal. Reset the Cooler Fan motor. If the fault continues then an engineer must check out the motor.")> _
Public CoolerFanMotorNotRunning As Boolean

  <Description("There is a problem with the cooling. The temperature is not decreasing at an acceptable rate.")> _
Public CoolingSlow As Boolean

  <Description("The current reading for the Fan motor has exceeded its expected limit for a pre-determined time. Set by parameters ‘Fan Current At 10%’Etc.")> _
Public FanCurrentExceeded As Boolean

  <Description("The fan inverter is showing a fault condition. Press the Reset button on the inverter panel. If the fault continues then an engineer must check out the motor and inverter.")> _
Public FanInverterFault As Boolean

  <Description("The current reading for the Fan motor has exceeded the maximum allowable current limit as set by parameter ‘Fan Maximum Current’")> _
Public FanMaxCurrentExceeded As Boolean

  <Description("The software is requesting the fan to run but there is no running signal from the inverter showing.. Press the Reset button on the inverter panel. If the fault continues then an engineer must check out the motor and inverter")> _
Public FanNotRunning As Boolean

  <Description("There is a problem with the heating. The temperature is not increasing at an acceptable rate.")> _
Public HeatingSlow As Boolean

  <Description("There is a fault with the reading from the Inlet Temperature probe.")> _
Public InletPt100ProbeFault As Boolean

  <Description("There is a fault with the reading from the Inside pressure sensor")> _
Public InsidePressureFault As Boolean

  <Description("The cage interlock switch is not engaged.")> _
 Public InterlockCageSwitch As Boolean

  <Description("The temperature in the kier has exceeded the maximum allowable temperature as set by parameter ‘Kier Maximum Temperature’")> _
 Public KierMaxTempExceeded As Boolean

  <Description("The pressure in the kier has exceeded the maximum allowable pressure as set by parameter ‘Kier Maximum Pressure’")> _
 Public KierMaxPressureExceeded As Boolean

  <Description("The Kier Full Level probe is indicating it is on but the Kier Empty level is not. Check the Levels.")> _
 Public LevelFault As Boolean
  '------
  <Description("The lid is not reading as closed and Locked and the kier has asked for pressure")> _
 Public LidNotLocked As Boolean

  <Description("There is a fault with the Lid. The Lid should be in the closed position but the feedback switch is not indicating this. Check Switch feedback.")> _
Public LidNotClosed As Boolean

  <Description("There is a fault with the Lid. The Lid should be in the Open position but the feedback switch is not indicating this. Check Switch feedback.")> _
Public LidNotOpen As Boolean

  <Description("There is a fault with the Lid ring . The Lid ring should be in the Closed position but the feedback switch is not indicating this. Check Switch feedback.")> _
Public RingNotClosed As Boolean

  <Description("There is a fault with the Lid ring. The Lid ring should be in the Open position but the feedback switch is not indicating this. Check Switch feedback.")> _
Public RingNotOpen As Boolean

  '------
  <Description("The shoot bolt should be in the locked position but the feedback switch is not indicating this. Check Switch feedback.")> _
 Public ShootBoltFault As Boolean

  <Description("Communications to the PLC has failed. Check connections.")> _
Public NoPlcComs As Boolean

  <Description("The analog pressure input is saying we are above 200 mBar but the switch input (input 9) is saying we are below 200mBar. Check the switch.")> _
Public PressureSwitchFault As Boolean

  <Description("The controller has been switched to Debug mode. Press Expert,Engineer and select Run on the dial ")> _
  Public SystemInDebug As Boolean

  <Description("The controller has been switched to Overide mode. Press Expert,Engineer and select Run on the dial ")> _
Public SystemInOveride As Boolean

  <Description("The controller has been switched to Test mode. Press Expert,Engineer and select Run on the dial ")> _
Public SystemInTest As Boolean

  <Description("The controller has been paused (or the Halt button pressed), to continue press Run.  ")> _
Public SystemPaused As Boolean

  <Description("The kier has asked for pressure and there is water still in the kier")> _
Public KierNotEmpty As Boolean

  <Description("The Kier has not depressurised in the time set by parameter 'Pressure Safe Time'")> _
Public KierHasNotDepressurised As Boolean

  <Description("The Kier has been at maximum pressure and has aborted the program")> _
Public AbortedPressureAtMax As Boolean

  <Description("The fan motor temperature has exceeded the maximum setting")> _
Public MaximumFanMotorTemp As Boolean

  <Description("Pressure has been detected when in cleaning Mode")> _
Public PressureDetected As Boolean

  <Description("Pressure Still rising in cleaning mode so cleaning Aborted")> _
Public CleaningCycleAborted As Boolean

  <Description("There is water in the kier after CK command")> _
Public WaterInKier As Boolean

  <Description("If after Settle time we lose the kier full level  Alarm and abort cleaning cycle onley when useing  CK command")> _
Public TopLevelLost As Boolean

End Class
