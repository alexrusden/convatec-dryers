Public Class Parameters : Inherits MarshalByRefObject


  <Category("Temperature Control"), Description("Time delay after 'KierPressureSafe' (input 9) and analog pressures before Kier pressure is safe ")> _
  Public TemperatureSmoothing As Integer

  <Category("Temperature Control"), Description("Maximum allowable kier Temperature. Degrees celsius")> _
Public KierMaximumTemperature As Integer

  <Category("Pressure Control"), Description("Maximum allowable kier pressure. mBar")> _
Public KierMaximumPressure As Integer


  <Category("Pressure Control"), Description("Time delay after 'KierPressureSafe' (input 9) and analog pressures before Kier pressure is safe ")> _
    Public PressureSafeDelayTime As Integer

  <Category("Pressure Control"), Description("When kier is pressurised kier will pressure to this setting. mBar")> _
  Public WorkingPressureSetting As Integer

  <Category("Pressure Control"), Description("When kier is Purging kier will pressure to this setting. mBar")> _
Public PurgePressureSetting As Integer

  <Category("Pressure Calibration"), Description("Enter The value of the raw analog input that represents zero Pressure ")> _
Public PT1PressureSetZero As Integer

  <Category("Pressure Calibration"), Description("Enter The value of the raw analog input that represents 100% Pressure ")> _
Public PT1PressureSet100Percent As Integer

  <Category("Pressure Calibration"), Description("If the transducer at 100% (20mA) = 6 Bar then enter 6000. mBar")> _
Public PT1PressureRange As Integer

  <Category("Pressure Calibration"), Description("Enter The value of the raw analog input that represents zero Pressure ")> _
Public PT2PressureSetZero As Integer

  <Category("Pressure Calibration"), Description("Enter The value of the raw analog input that represents 100% Pressure ")> _
Public PT2PressureSet100Percent As Integer

  <Category("Pressure Calibration"), Description("If the transducer at 100% (20mA) = 6 Bar then enter 6000. mBar")> _
Public PT2PressureRange As Integer


  <Category("Flow Control"), Description("Dwell Time between flow reversals. Secs")> _
  Public FlowDwellTime As Integer

  <Category("Flow Control"), Description("If No Fan speed has been selected then use this default speed setting. Percent")> _
Public DefaultFanSpeed As Integer

  <Category("Flow Control"), Description("Maxiumum pressure for in to out flow when using FP command. mBar ")> _
Public MaxInToOutPressure As Integer

  <Category("Flow Control"), Description("Maxiumum pressure for out to in flow when using FP command. mBar ")> _
Public MaxOutToInPressure As Integer

  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 10 Percent.Amps tenths")> _
  Public FanCurrentAt10Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 20 Percent.Amps tenths")> _
Public FanCurrentAt20Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 30 Percent.Amps tenths")> _
Public FanCurrentAt30Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 40 Percent.Amps tenths")> _
Public FanCurrentAt40Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 50 Percent.Amps tenths")> _
Public FanCurrentAt50Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 60 Percent.Amps tenths")> _
Public FanCurrentAt60Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 70 Percent.Amps tenths")> _
Public FanCurrentAt70Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 80 Percent.Amps tenths")> _
Public FanCurrentAt80Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 90 Percent.Amps tenths")> _
Public FanCurrentAt90Percent As Integer
  <Category("Fan Current"), Description("The normal Fan current when the fan speed is 100 Percent.Amps tenths")> _
  Public FanCurrentAt100Percent As Integer

  <Category("Flow Control"), Description("Maximum allowable Fan Current. Amps tenths")> _
Public FanMaximumCurrent As Integer





  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
Public TemperatureAt10PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt20PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt30PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt40PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt50PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt60PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt70PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt80PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt90PercentOpen As Integer
  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
 Public TemperatureAt100PercentOpen As Integer


  '  <Category("Inlet Temperature Control"), Description("Help For parameter")> _
  'Public InletHeatValveMaxOpen As Integer

  <Category("Inlet Temperature Control"), Description("The proportional band for Heating using the IT command.  Degrees celsius")> _
Public ITHeatPropBand As Integer

  <Category("Inlet Temperature Control"), Description("The time delay before a change in the heating output. Secs")> _
Public ITHeatChangeDelay As Integer

  <Category("Inlet Temperature Control"), Description("The Maximum amount of change to the Heating output after ITHeatChangeDelay")> _
Public ITHeatMaxChange As Integer


  <Category("Clean Control"), Description("Maximum allowable kier Temperature. Degrees celsius")> _
Public CKHeatValveMaxOpen As Integer

  <Category("Clean Control"), Description("When using CK command if the working level is reached and overfill time has timed out the wait for settle time before heating. Secs")> _
Public CleanFillSettleTime As Integer

  <Category("Clean Control"), Description("When using CK command if the Kier Temperature has been reached set by parameter 'CleanTemperatureSetting' then hold for this time . Mins ")> _
Public CleanHoldTime As Integer

  <Category("Clean Control"), Description("After the Kier has lost the input 'KierFullLevel' then continue draining for this parameter time . Secs ")> _
Public GravityDrainTime As Integer

  <Category("Clean Control"), Description("The target temperature using the CK command.  Degrees celsius")> _
  Public CleanTemperatureSetting As Integer

  <Category("Clean Control"), Description("Continue filling for this time after the input 'KierFullLevel' is on. Secs")> _
Public CleanOverFillTime As Integer

  <Category("Clean Control"), Description("The proportional band for Heating using the CK command.  Degrees celsius")> _
Public CleanHeatPropBand As Integer

  <Category("Clean Control"), Description("The time delay before a change in the heating output. Secs")> _
Public CleanHeatChangeDelay As Integer

  <Category("Clean Control"), Description("The Maximum amount of change to the Heating output after CleanHeatChangeDelay")> _
Public CleanHeatMaxChange As Integer
  '---------
  <Category("Cooler Temperature Control"), Description("The proportional band for Cooling using the CT command.  Degrees celsius")> _
Public CTCoolingPropBand As Integer

  <Category("Cooler Temperature Control"), Description("The time delay before a change in the Cooling output. Secs")> _
Public CTHeatChangeDelay As Integer

  <Category("Cooler Temperature Control"), Description("When at cooling temp Valve will open to this parameter setting. %")> _
Public FinalTempCoolingPercent As Integer


  <Category("Cooler Temperature Control"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
Public CTHeatMaxChange As Integer

  <Category("FanMotor"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
Public FanMotorMaxTemp As Integer

  <Category("CoolerMotor"), Description("If there is no Cooler Motor then set to 1")> _
Public NoCoolerMotor As Integer

  <Category("Interlock"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
Public WaterInTheKier As Integer

  <Category("Calibration"), Description("The Setting for the minimum range of the PT100 200 = -20C Temp 1 ")> _
Public MinimumTemp1Range As Integer
  <Category("Calibration"), Description("The Setting for the minimum range of the PT100 200 = -20C Temp 2 ")> _
  Public MinimumTemp2Range As Integer
  <Category("Calibration"), Description("The Setting for the minimum range of the PT100 200 = -20C Temp 3 ")> _
  Public MinimumTemp3Range As Integer
  <Category("Calibration"), Description("The Setting for the minimum range of the PT100 200 = -20C Temp 4 ")> _
  Public MinimumTemp4Range As Integer
  <Category("Calibration"), Description("The Setting for the minimum range of the PT100 200 = -20C Temp 5 ")> _
  Public MinimumTemp5Range As Integer



  <Category("Calibration"), Description("The Setting for the Maximum range of the PT100 1500 = 150C  Temp 1 ")> _
Public MaximumTemp1Range As Integer
  <Category("Calibration"), Description("The Setting for the Maximum range of the PT100 1500 = 150C  Temp 2 ")> _
 Public MaximumTemp2Range As Integer
  <Category("Calibration"), Description("The Setting for the Maximum range of the PT100 1500 = 150C  Temp 3 ")> _
 Public MaximumTemp3Range As Integer
  <Category("Calibration"), Description("The Setting for the Maximum range of the PT100 1500 = 150C  Temp 4 ")> _
 Public MaximumTemp4Range As Integer
  <Category("Calibration"), Description("The Setting for the Maximum range of the PT100 1500 = 150C  Temp 5 ")> _
 Public MaximumTemp5Range As Integer

  '  <Category("Test"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
  'Public test As Integer


  '  <Category("Test"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
  'Public TestGoDown As Integer
  '  ' <Category("AnalogInputs"), Description("The Maximum amount of change to the Cooling output after CTHeatChangeDelay. Percent")> _
  '  'Public FanCurrentAt100Percent As Integer

  '-------------
  ' You can also limit the range of parameter values using <Parameter(min, max)>
End Class
