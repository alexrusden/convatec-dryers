<Command("Cooler Temperature", "|0-999|C"), _
 Description("This command is used to program the desired temperature to be achieved and maintained in the cooler. The fan must be on for this command to operate."), _
 Category("TempControl")> _
Public Class CT : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As CT
  Public CoolerSetpoint As Integer

  Public CoolerValveOutPut As Integer

  ' The possible states of this command
  Public Enum CT
    Off
    Interlock
    Running
  End Enum

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
  Friend ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return State <> CT.Off
    End Get
  End Property

  ' Returns the current state of this command.
  Public Property State() As CT
    Get
      Return state_
    End Get
    Private Set(ByVal value As CT)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    'Cancel Some commands

    CoolerSetpoint = param(1)


    state_ = CT.Interlock

    Return True
  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode
      Select Case state_

        Case CT.Off

        Case CT.Interlock
          If .IO.FanRunning Then state_ = CT.Running


        Case CT.Running


          Static TempErrorOutlet As Integer
          TempErrorOutlet = MinMax((.IO.CondenserTemperature) - (.CT.CoolerSetpoint * 10), 0, 1000)
          If .CT.IsOn Then
            CoolerValveOutPut = CShort(MinMax(((TempErrorOutlet * 1000) \ (.Parameters.CTCoolingPropBand * 10)), 0, 1000))
          End If

          '
          If Not .IO.FanRunning Then state_ = CT.Interlock

      End Select

    End With

    CoolerValveOutPut = MinMax(CoolerValveOutPut, 0, 1000) 'NEVER GO PAST 100% OR 0%
  End Function




  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = CT.Off
    ' You can put other stuff you need to cancel here
  End Sub
End Class
