<Command("Fan Pressure", "I/O |0-999|mB  O/I |0-999|mB"), _
 Description("This command is used to program the differential pressure you want in kier in the IO and the OI directions. The fan speed will be adjusted throughout to maintain this pressure. This command over-rides the FS."), _
 Category("Flow")> _
Public Class FP : Inherits MarshalByRefObject : Implements ACCommand
  Private ControlCode As ControlCode
  Private state_ As FP

  Public ReqInToOutDP As Integer
  Public ReqOutToInDP As Integer
  Public ReqInToOutSpeed As Integer
  Public ReqOutToInSpeed As Integer
  Public LastInToOutSpeed As Integer
  Public LastOutToInSpeed As Integer

  Public StartPercent As Integer

  Public FlowControlDelay As New Timer

  Public ControlSpeed As Integer

  Public TimeDelay As New Timer

  ' The possible states of this command
  Public Enum FP
    Off
    Running
  End Enum

  Public FPState As FP

  Public Sub New(ByVal controlCode As ControlCode)
    Me.ControlCode = controlCode




  End Sub
 

  ' Returns the current state of this command.
  Public Property State() As FP
    Get
      Return state_
    End Get
    Private Set(ByVal value As FP)
      state_ = value
    End Set
  End Property


  ' Called when a command starts - the parameter values are in 'param', starting from param(1)
  Public Function Start(ByVal ParamArray param() As Integer) As Boolean Implements ACCommand.Start

    ControlCode.FS.Cancel()

    ReqInToOutDP = param(1)
    If ReqInToOutDP > ControlCode.Parameters.MaxInToOutPressure Then ReqInToOutDP = ControlCode.Parameters.MaxInToOutPressure

    ReqOutToInDP = param(2)
    If ReqOutToInDP > ControlCode.Parameters.MaxOutToInPressure Then ReqInToOutDP = ControlCode.Parameters.MaxOutToInPressure

    If ControlCode.FS.FanSetSpeedInToOut = 0 Then ControlCode.FS.FanSetSpeedInToOut = ControlCode.Parameters.DefaultFanSpeed

    If ControlCode.FS.FanSetSpeedOutToIn = 0 Then ControlCode.FS.FanSetSpeedOutToIn = ControlCode.Parameters.DefaultFanSpeed


    ReqOutToInSpeed = ControlCode.FS.FanSetSpeedOutToIn * 10

    ReqInToOutSpeed = ControlCode.FS.FanSetSpeedInToOut * 10


    FlowControlDelay.TimeRemaining = 15


    FPState = FP.Running

    Return True 'Step on

  End Function

  ' Called all the time
  Public Function Run() As Boolean Implements ACCommand.Run
    With ControlCode

      If .FP.FPState = FP.Off Then Exit Function
      
      If TimeDelay.Finished Then


        If .FR.State = FR.FR.InToOut Then
          If .DifferentialPressure > (ReqInToOutDP - 10) Then ReqInToOutSpeed = ReqInToOutSpeed - 10
          If .DifferentialPressure < (ReqInToOutDP + 10) And (.DifferentialPressure < ControlCode.Parameters.MaxInToOutPressure) Then ReqInToOutSpeed = ReqInToOutSpeed + 10
          ReqInToOutSpeed = MinMax(ReqInToOutSpeed, 0, 1000)

          ControlSpeed = ReqInToOutSpeed
        End If

        If .FR.State = FR.FR.Dwell Then ControlSpeed = 0

        If .FR.State = FR.FR.OutToIn Then
          If .DifferentialPressure > (ReqOutToInDP - 10) Then ReqOutToInSpeed = ReqOutToInSpeed - 10
          If .DifferentialPressure < (ReqOutToInDP + 10) And (.DifferentialPressure < ControlCode.Parameters.MaxOutToInPressure) Then ReqOutToInSpeed = ReqOutToInSpeed + 10
          ReqOutToInSpeed = MinMax(ReqOutToInSpeed, 0, 1000)
          ControlSpeed = ReqOutToInSpeed
        End If
        TimeDelay.TimeRemaining = 2





      End If



    End With

  End Function

  ' Called when this command is cancelled
  Public Sub Cancel() Implements ACCommand.Cancel
    State = FP.Off
    ' You can put other stuff you need to cancel here
  End Sub



  Public ReadOnly Property IsOn() As Boolean Implements ACCommand.IsOn
    Get
      Return FPState <> FP.Off
    End Get

  End Property
End Class
