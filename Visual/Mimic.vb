Public Class Mimic
  Public ControlCode As ControlCode
  Public ReqUp As Boolean



  Public ReqDown As Boolean

  Public Sub New()
    DoubleBuffered = True  ' no flicker 
    InitializeComponent()
  End Sub




  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    InletTempSetting.Value = 0
    If ControlCode.CK.IsOn Then InletTempSetting.Value = ControlCode.Parameters.CleanTemperatureSetting
    If ControlCode.IT.IsOn Then InletTempSetting.Value = ControlCode.IT.InletTempSetpoint

    OutletTempSetting.Value = 0
    If ControlCode.OT.IsOn Then OutletTempSetting.Value = ControlCode.OT.FinalTempDV
    If ControlCode.FT.IsOn Then OutletTempSetting.Value = ControlCode.FT.FinalTempSetting


    Lamp1.Value = ControlCode.lampLatch


    If ControlCode.IO.FlowChanger Then
      DPSetPoint.Value = ControlCode.FP.ReqOutToInDP
    Else
      DPSetPoint.Value = ControlCode.FP.ReqInToOutDP
    End If

    ' If ControlCode.FR.State = FR.FR.Dwell Then 

    DPSetPoint.Value = 0

    CoolSetting.Value = ControlCode.CT.CoolerSetpoint


    If (Not ControlCode.FullyOpen) And ControlCode.LidControlState = Global.ControlCode.LidControl.RequestOpen Then
      OpenLid_PB.BackColor = Color.LawnGreen
    Else
      OpenLid_PB.BackColor = Color.LightGray
    End If


    If (Not ControlCode.FullyClosed) And ControlCode.LidControlState = Global.ControlCode.LidControl.RequestClose Then
      CloseLid_PB.BackColor = Color.LawnGreen
    Else
      CloseLid_PB.BackColor = Color.LightGray
    End If




    If (OpenLid_PB.BackColor = Color.LawnGreen) Or (CloseLid_PB.BackColor = Color.LawnGreen) Then
      StopLid_PB.BackColor = Color.Red
    Else
      StopLid_PB.BackColor = Color.LightGray
    End If





    ShootBoltOut.Value = Not ControlCode.IO.ShootBoltIn



    PressIsSafeTimer.Text = (TimerString(ControlCode.PressSaveValue))


    'If ControlCode.IO.CloseLid And Not ControlCode.IO.LidOpen Then
    '  If x <> 0 Then x = x - 1
    'End If

    'If ControlCode.IO.OpenLid And Not ControlCode.IO.LidClosed Then
    '  If x <> 7 Then x = x + 1
    'End If



    'If (Not ControlCode.IO.LidOpen) And (Not ControlCode.IO.LidClosed) And (Not ControlCode.IO.CloseLid) And (Not ControlCode.IO.OpenLid) Then
    '  x = 3
    'End If

    'Lid1.Visible = x < 2
    'Lid2.Visible = x = 2
    'Lid3.Visible = x = 3
    '' Lid4.Visible = x = 4
    'Lid5.Visible = x = 5
    'Lid6.Visible = x > 5

    Lid6.Visible = ControlCode.IO.LidIsOpen

    Lid3.Visible = (Not ControlCode.IO.LidIsOpen) And (Not ControlCode.IO.LidIsClosed)

    Lid1.Visible = ControlCode.IO.LidIsClosed

    OpenLid_PB.Enabled = ControlCode.PressureIsSafe And (Not ControlCode.IO.KierFullLevel) And (Not ControlCode.IO.FanRunning) And (Not ControlCode.IO.FanCoolerMotorRunning)
    CloseLid_PB.Enabled = Not (ControlCode.IO.LidIsClosed)

    '----------------
    FlowOutToIn.Value = ControlCode.IO.FlowChanger

    FlowInToOut.Value = Not ControlCode.IO.FlowChanger

    RevLabel.Text = (TimerString(ControlCode.RevTimer))
    '---------------

  End Sub



  Private Sub StopLid_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopLid_PB.Click
    ControlCode.LidControlState = Global.ControlCode.LidControl.Off

  End Sub

  Private Sub OpenLid_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLid_PB.Click
    If MessageBox.Show("Confirm: Open Lid", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub
    ControlCode.LidControlState = Global.ControlCode.LidControl.RequestOpen
  End Sub

  Private Sub CloseLid_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseLid_PB.Click
    If MessageBox.Show("Confirm: Close Lid", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub
    ControlCode.LidControlState = Global.ControlCode.LidControl.RequestClose
  End Sub



  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    If MessageBox.Show("Confirm: Start/Stop Fan", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub
  End Sub

  Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ControlCode.lampLatch = False
    ControlCode.Statusalarm = ""
  End Sub



End Class
