Public Class IO : Inherits MarshalByRefObject
  Public Plc As Ports.RockwellEthernetIP

  Private ControlCode As ControlCode
  Public PlcFailedTimer As New Timer

  Public PlcFault As Boolean

  Public AnalogInput1mA As Integer
  Public AnalogInput2mA As Integer
  Public AnalogInput3mA As Integer
  Public AnalogInput4mA As Integer
  Public AnalogInput5mA As Integer
  Public AnalogInput6mA As Integer
  Public AnalogInput7mA As Integer
  Public AnalogInput8mA As Integer

  Public AnalogInput1Raw As Integer
  Public AnalogInput2Raw As Integer
  Public AnalogInput3Raw As Integer
  Public AnalogInput4Raw As Integer
  Public AnalogInput5Raw As Integer
  Public AnalogInput6Raw As Integer
  Public AnalogInput7Raw As Integer
  Public AnalogInput8Raw As Integer



  Public AnalogInput1Smooth As Integer
  Public AnalogInput2Smooth As Integer
  Public AnalogInput3Smooth As Integer
  Public AnalogInput4Smooth As Integer
  Public AnalogInput5Smooth As Integer
  Public AnalogInput6Smooth As Integer
  Public AnalogInput7Smooth As Integer
  Public AnalogInput8Smooth As Integer

  Public MinTemp1 As Integer
  Public MinTemp2 As Integer
  Public MinTemp3 As Integer
  Public MinTemp4 As Integer
  Public MinTemp5 As Integer



  Public MaxTemp1 As Integer
  Public MaxTemp2 As Integer
  Public MaxTemp3 As Integer
  Public MaxTemp4 As Integer
  Public MaxTemp5 As Integer



  <IO(IOType.Dinp, 1)> Public RemoteRun As Boolean
  <IO(IOType.Dinp, 2)> Public RemoteHalt As Boolean
  <IO(IOType.Dinp, 3)> Public RemoteYes As Boolean
  <IO(IOType.Dinp, 4)> Public RemoteNo As Boolean
  <IO(IOType.Dinp, 5)> Public Control24Volt As Boolean
  <IO(IOType.Dinp, 6)> Public EmergencyStop As Boolean
  <IO(IOType.Dinp, 7)> Public CageInterlock As Boolean
  <IO(IOType.Dinp, 8)> Public ShootBoltIn As Boolean
  <IO(IOType.Dinp, 9)> Public KierPressureSafe As Boolean
  <IO(IOType.Dinp, 10)> Public FanRunning As Boolean
  <IO(IOType.Dinp, 11)> Public FanInverterFault As Boolean
  <IO(IOType.Dinp, 13)> Public FanCoolerMotorRunning As Boolean
  <IO(IOType.Dinp, 14)> Public FanCoolerMotorFault As Boolean
  <IO(IOType.Dinp, 15)> Public LidIsOpen As Boolean
  <IO(IOType.Dinp, 16)> Public LidIsClosed As Boolean

  <IO(IOType.Dinp, 17)> Public LidRingIsOpen As Boolean
  <IO(IOType.Dinp, 18)> Public LidRingIsClosed As Boolean
  <IO(IOType.Dinp, 19)> Public KierEmptyLevel As Boolean
  <IO(IOType.Dinp, 20)> Public KierFullLevel As Boolean


  <IO(IOType.Dout, 1)> Public SumpDrain As Boolean
  <IO(IOType.Dout, 2)> Public FanRun As Boolean
  <IO(IOType.Dout, 3)> Public FanCoolerMotor As Boolean
  <IO(IOType.Dout, 4)> Public FanDrain As Boolean
  <IO(IOType.Dout, 5)> Public FlowChanger As Boolean
  <IO(IOType.Dout, 6)> Public Pressurise As Boolean
  <IO(IOType.Dout, 7)> Public Depressurise As Boolean 'Normaly open
  <IO(IOType.Dout, 8)> Public LidOpen As Boolean
  <IO(IOType.Dout, 9)> Public LidClose As Boolean
  <IO(IOType.Dout, 10)> Public LidRingOpen As Boolean
  <IO(IOType.Dout, 11)> Public LidRingClose As Boolean
  <IO(IOType.Dout, 12)> Public UnlockShootBolt As Boolean
  <IO(IOType.Dout, 13)> Public AlarmCall As Boolean
  <IO(IOType.Dout, 14)> Public OperatorCall As Boolean
  <IO(IOType.Dout, 15)> Public Siren As Boolean
  <IO(IOType.Dout, 16)> Public FanSeal As Boolean

  <IO(IOType.Dout, 17)> Public KierWaterFill As Boolean
  <IO(IOType.Dout, 18)> Public KierWaterVent As Boolean
  <IO(IOType.Dout, 19)> Public CondenserDrain As Boolean
  <IO(IOType.Dout, 20)> Public HeatExchangeDrain As Boolean
  <IO(IOType.Dout, 21)> Public VacuumLidSeal As Boolean
  <IO(IOType.Dout, 22)> Public PressureLidSeal As Boolean
  <IO(IOType.Dout, 23)> Public TrapIsolationValve As Boolean




  <IO(IOType.Temp, 1, , , "%tºC"), GraphTrace(0, 1500, , 5000, "Red", "%tºC"), _
   GraphLabel("0C", 0), _
   GraphLabel("25C", 250), _
   GraphLabel("50C", 500), _
   GraphLabel("75C", 750), _
   GraphLabel("100C", 1000), _
   GraphLabel("125C", 1250), _
   GraphLabel("150C", 1500) _
> Public InletTemperature As Short




  <IO(IOType.Temp, 2, ), GraphTrace(1, 1500, , 5000, "Pink", "%tºC")> Public OutletTemperature As Short
  <IO(IOType.Temp, 3), GraphTrace(1, 1500, , 5000, "DarkRed", "%tºC")> Public CondenserTemperature As Short
  <IO(IOType.Temp, 4), GraphTrace(1, 1500, , 5000, "DarkGreen", "%tºC")> Public FanBearing1Temp As Short
  <IO(IOType.Temp, 5), GraphTrace(1, 1500, , 5000, "DarkGreen", "%tºC")> Public FanBearing2Temp As Short

  '<IO(IOType.Aninp, 4, , , "%tAmp "), GraphTrace(1, 10000, , , "DarkGreen", "%tAmp")> Public FanCurrent As Short
  <IO(IOType.Aninp, 4, , , "%tAmp ")> Public FanCurrent As Short


  <IO(IOType.Aninp, 5, , , "%dmB"), GraphTrace(1, 10000, 5500, 10000, "Purple", "%dmB"), _
   GraphLabel("0mBar", 0), _
GraphLabel("2000mBar", 2000), _
 GraphLabel("4000mBar", 4000), _
 GraphLabel("6000mBar", 6000), _
GraphLabel("8000mBar", 8000), _
 GraphLabel("10000mBar", 10000) _
 > Public PT1Pressure As Short

  <IO(IOType.Aninp, 6, , , "%dmB"), GraphTrace(1, 10000, 5500, 10000, "Blue", "%dmB")> Public PT2Pressure As Short


  <IO(IOType.Anout, 1, , , "%t%")> Public HeatingValve As Short
  <IO(IOType.Anout, 2, , , "%t%")> Public CoolingValve As Short
  <IO(IOType.Anout, 3, , , "%t%")> Public FanSpeed As Short

  Public Sub New(ByVal plcIpAddress As String, ByVal controlCode As ControlCode)
    Plc = New Ports.RockwellEthernetIP(plcIpAddress)
    Me.ControlCode = controlCode
  End Sub

  Public Function GetPercent(ByVal Value As Long, ByVal MinValue As Long, ByVal MaxValue As Long) As Long
    Try
      Dim Range As Long, Offset As Long
      Range = MaxValue - MinValue
      Offset = Value - MinValue
      Return MinMax(CInt((Offset * 1000) / Range), 0, 1000)
    Catch
      Return -1
    End Try
  End Function

  Public Function ReadInputs(ByVal dinp() As Boolean, ByVal aninp() As Short, ByVal temp() As Short) As Boolean
    Dim x(10) As Integer


    PlcFault = PlcFailedTimer.Finished




    Select Plc.Read("X", x)
      Case Ports.RockwellEthernetIP.Result.OK

        ' Plc Failed alarm
        PlcFailedTimer.TimeRemaining = 8

        '---------------------------------------------------------
        'Use For testing
        'Static PercentTest As Integer
        'Static Rawvalue As Integer

        'PercentTest = 100

        'Rawvalue = ReScale(PercentTest, 0, 100, 6248, 31192)

        'Dim z As Integer
        'For z = 1 To 6
        '  x(z) = Rawvalue
        'Next z
        '------------------------------------------------------------

        Static howMuchSmoothing As Short = CShort(ControlCode.Parameters.TemperatureSmoothing)

        Static SmoothVesselTemp1 As New Smoothing
        Static SmoothVesselTemp2 As New Smoothing
        Static SmoothVesselTemp3 As New Smoothing
        Static SmoothVesselTemp4 As New Smoothing
        Static SmoothVesselTemp5 As New Smoothing



        MaxTemp1 = ControlCode.Parameters.MaximumTemp1Range * 10
        MaxTemp2 = ControlCode.Parameters.MaximumTemp2Range * 10
        MaxTemp3 = ControlCode.Parameters.MaximumTemp3Range * 10
        MaxTemp4 = ControlCode.Parameters.MaximumTemp4Range * 10
        MaxTemp5 = ControlCode.Parameters.MaximumTemp5Range * 10

        MinTemp1 = ControlCode.Parameters.MinimumTemp1Range * 10
        MinTemp2 = ControlCode.Parameters.MinimumTemp2Range * 10
        MinTemp3 = ControlCode.Parameters.MinimumTemp3Range * 10
        MinTemp4 = ControlCode.Parameters.MinimumTemp4Range * 10
        MinTemp5 = ControlCode.Parameters.MinimumTemp5Range * 10

        'x(1) = 31192
        'x(2) = 31192
        'x(3) = 0
        'x(4) = 31192
        'x(5) = 31192


        '---Temperatures
        ' temp(1) = CShort(ReScale(x(1), 6272, 31192, 0, MaxTemp)) ' InletTemperature      X0 INPUT 1 ON SLOT ONE ON THE PLC
        Dim Temp1 = CType(SmoothVesselTemp1.Smooth(ReScale(x(1), 6272, 31192, -MinTemp1, MaxTemp1), howMuchSmoothing), Short)
        temp(1) = CShort(Temp1 / 10)



        'temp(2) = CShort(ReScale(x(2), 6272, 31192, 0, MaxTemp)) ' OutletTemperature     X1 INPUT 2 ON SLOT ONE ON THE PLC
        Dim Temp2 = CType(SmoothVesselTemp2.Smooth(ReScale(x(2), 6272, 31192, -MinTemp2, MaxTemp2), howMuchSmoothing), Short)
        temp(2) = CShort(Temp2 / 10)

        ' temp(3) = CShort(ReScale(x(3), 6272, 31192, 0, MaxTemp)) ' CondenserTemperature  X2 INPUT 3 ON SLOT ONE ON THE PLC
        Dim Temp3 = CType(SmoothVesselTemp3.Smooth(ReScale(x(3), 6272, 31192, -MinTemp3, MaxTemp3), howMuchSmoothing), Short)
        temp(3) = CShort(Temp3 / 10)


        'temp(4) = CShort(ReScale(x(4), 6272, 31192, 0, MaxTemp)) ' Fan Bearing Temp1     X3 INPUT 3 ON SLOT SIX ON THE PLC
        Dim Temp4 = CType(SmoothVesselTemp4.Smooth(ReScale(x(4), 6272, 31192, -MinTemp4, MaxTemp4), howMuchSmoothing), Short)
        temp(4) = CShort(Temp4 / 10)

        'temp(5) = CShort(ReScale(x(5), 6272, 31192, 0, MaxTemp)) ' Fan Bearing Temp2     X4 INPUT 4 ON SLOT SIX ON THE PLC
        Dim Temp5 = CType(SmoothVesselTemp5.Smooth(ReScale(x(5), 6272, 31192, -MinTemp5, MaxTemp5), howMuchSmoothing), Short)
        temp(5) = CShort(Temp5 / 10)

        aninp(4) = CShort(ReScale(x(6), 6272, 31192, 0, 750))    'Fan Current            X5 INPUT 4 ON SLOT ONE ON THE PLC


        With ControlCode.Parameters
          aninp(5) = CShort(ReScale(x(7), .PT1PressureSetZero, .PT1PressureSet100Percent, 0, .PT1PressureRange)) ' InsidePressure          X6 INPUT 1 ON SLOT SIX ON THE PLC
          aninp(6) = CShort(ReScale(x(8), .PT2PressureSetZero, .PT2PressureSet100Percent, 0, .PT1PressureRange)) ' OutsidePressure         X7 INPUT 2 ON SLOT SIX ON THE PLC
        End With
        '--------------------------------------------------------------------------------------
        ' Digital inputs
        Array.Copy(Ports.BitConverter.GetBooleans(x, 9, 1), 1, dinp, 1, 16)             'X8
        Array.Copy(Ports.BitConverter.GetBooleans(x, 10, 1), 1, dinp, 17, dinp.Length - 17) ' to the end 4)  'X9
        '--------------------------------------------------------------------------------------
        AnalogInput1mA = (ReScale(x(1), 0, 31192, 0, 200))
        AnalogInput2mA = (ReScale(x(2), 0, 31192, 0, 200))
        AnalogInput3mA = (ReScale(x(3), 0, 31192, 0, 200))
        AnalogInput4mA = (ReScale(x(6), 0, 31192, 0, 200))

        AnalogInput5mA = (ReScale(x(7), 0, 31192, 0, 200))
        AnalogInput6mA = (ReScale(x(8), 0, 31192, 0, 200))
        AnalogInput7mA = (ReScale(x(4), 0, 31192, 0, 200))
        AnalogInput8mA = (ReScale(x(5), 0, 31192, 0, 200))
        '---------------------------------------------------------------------------------------
        AnalogInput1Raw = x(1)
        AnalogInput2Raw = x(2)
        AnalogInput3Raw = x(3)
        AnalogInput4Raw = x(4)
        AnalogInput5Raw = x(5)
        AnalogInput6Raw = x(6)
        AnalogInput7Raw = x(7)
        AnalogInput8Raw = x(8)


        Static X1 As New Smoothing
        Static X2 As New Smoothing
        Static X3 As New Smoothing
        Static X4 As New Smoothing
        Static X5 As New Smoothing
        Static X6 As New Smoothing
        Static X7 As New Smoothing
        Static X8 As New Smoothing


        AnalogInput1Smooth = CType(X1.Smooth(x(1), howMuchSmoothing), Short)
        AnalogInput2Smooth = CType(X2.Smooth(x(2), howMuchSmoothing), Short)
        AnalogInput3Smooth = CType(X3.Smooth(x(3), howMuchSmoothing), Short)
        AnalogInput4Smooth = CType(X4.Smooth(x(4), howMuchSmoothing), Short)
        AnalogInput5Smooth = CType(X5.Smooth(x(5), howMuchSmoothing), Short)
        AnalogInput6Smooth = CType(X6.Smooth(x(6), howMuchSmoothing), Short)
        AnalogInput7Smooth = CType(X7.Smooth(x(7), howMuchSmoothing), Short)
        AnalogInput8Smooth = CType(X8.Smooth(x(8), howMuchSmoothing), Short)
        '---------------------------------------------------------------------------------------
        ReadInputs = True
    End Select
  End Function

  Public Sub WriteOutputs(ByVal dout() As Boolean, ByVal anout() As Short)
    Dim y(8) As Integer
    ' Analog outputs

    y(1) = ReScale(anout(1), 0, 1000, 6248, 31192)
    y(2) = ReScale(anout(2), 0, 1000, 6248, 31192)
    y(3) = ReScale(anout(3), 0, 1000, 6248, 31192)

    ' Digital outputs




    dout(7) = Not dout(7) 'Reverse output Depressurise 'Normaly open

    'dout(23) = Not dout(23) 'Reverse output Trap Isolate 'Normaly open



    y(6) = Ports.BitConverter.GetInt32s(dout, 1, 16)(1) 'main
    y(7) = Ports.BitConverter.GetInt32s(dout, 17, dout.Length - 17)(1) ' to the end

    y(8) = 0 ' keep writing this as 0 to keep the other outputs on at the plc (watchdog)


    Plc.Write("Y", y, Ports.WriteMode.Always)
  End Sub
End Class

