<Command("Inlet Temperature", "|0-999|C"), _
 Description("This command is used to program the desired temperature to be achieved and maintained at the inlet to the Kier. The fan does not need to be on for this command to operate."), _
 Category("TempControl")> _
Public Class IT : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As IT
  Public InletTempSetpoint As Integer
  Public integral As Integer
  Public TempErrorInlet As Integer
  Public TempGoingUp As Boolean
  Public TempGoingDown As Boolean
  Public LastTemp As Integer
  Public PropBand As Integer
  Public AdjustNow As Boolean
  Public HeatControlOutput As Integer

  ' The possible states of this command
  Public Enum IT
    Off
    HeatUptoValue
    SwitchToControl

  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode
  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> IT.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As IT
    Get
      Return state_
    End Get
    Private Set(ByVal value As IT)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands
    InletTempSetpoint = (param(1))
    ControlCode.CK.Cancel() 'Cancel CK command


    If ControlCode.Parameters.ITHeatPropBand = 0 Then
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt10PercentOpen) Then integral = 100
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt20PercentOpen) Then integral = 200
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt30PercentOpen) Then integral = 300
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt40PercentOpen) Then integral = 400
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt50PercentOpen) Then integral = 500
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt60PercentOpen) Then integral = 600
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt70PercentOpen) Then integral = 700
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt80PercentOpen) Then integral = 800
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt90PercentOpen) Then integral = 900
      If InletTempSetpoint >= (ControlCode.Parameters.TemperatureAt100PercentOpen) Then integral = 1000
    End If



    state_ = IT.HeatUptoValue

    Return True

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode


      Static TempCheckTimer As New Timer

      If TempCheckTimer.Finished Then
        TempGoingUp = False
        TempGoingDown = False


        If .IO.InletTemperature > LastTemp Then
          TempGoingUp = True
          TempGoingDown = False
        End If

        If .IO.InletTemperature < LastTemp Then
          TempGoingUp = False
          TempGoingDown = True
        End If

        AdjustNow = True
        LastTemp = .IO.InletTemperature
        TempCheckTimer.TimeRemaining = .Parameters.ITHeatChangeDelay
      End If



      Select Case state_

        Case IT.Off
          integral = 0

        Case IT.HeatUptoValue

          If (.IO.InletTemperature + 50) >= (InletTempSetpoint * 10) Then State = IT.SwitchToControl

          If AdjustNow Then
            If Not TempGoingUp And .IO.HeatingValve < 1000 Then integral = integral + .Parameters.ITHeatMaxChange * 10
            AdjustNow = False
          End If



        Case IT.SwitchToControl
          If AdjustNow Then

            If (.IO.InletTemperature - 10) > (InletTempSetpoint * 10) And (ControlCode.IO.HeatingValve > 0) Then
              If Not TempGoingDown Then integral = integral - .Parameters.ITHeatMaxChange * 10
            End If

            If (.IO.InletTemperature + 10) < (InletTempSetpoint * 10) And (ControlCode.IO.HeatingValve < 1000) Then
              If Not TempGoingUp And .IO.HeatingValve < 1000 Then integral = integral + .Parameters.ITHeatMaxChange * 10
            End If

            AdjustNow = False
          End If

          'If ControlCode.OT.IsOn Then
          '  Return True
          'Else
          '  If ControlCode.IO.InletTemperature >= (InletTempSetpoint * 10) Then Return True
          'End If




      End Select


      If .IO.InletTemperature > 30 Then

      End If

      TempErrorInlet = MinMax((InletTempSetpoint * 10) - ControlCode.IO.InletTemperature, 0, 1000)



      If ControlCode.Parameters.ITHeatPropBand > 0 Then
        PropBand = CShort(MinMax(((TempErrorInlet * 1000) \ (ControlCode.Parameters.ITHeatPropBand * 10)), 0, 1000))

        HeatControlOutput = MinMax(PropBand + integral, 0, 1000) 'NEVER GO PAST 100% OR 0%
      Else
        HeatControlOutput = MinMax(integral, 0, 1000) 'NEVER GO PAST 100% OR 0%
      End If


    End With
  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = IT.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
