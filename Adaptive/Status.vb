Public Class Status
  Public ControlCode As ControlCode
  Private messageTicker_ As Integer, extraMessage_ As String, messages_ As New List(Of String)

  Public Sub New()
    InitializeComponent()
    'DirectCast(pbTemperature.Image, Bitmap).MakeTransparent(Color.Magenta)
  End Sub

  Public Sub OnControlCodeRefreshed()

    '" ºC"

    lblPressure.Text = ControlCode.KierPressure / 10 & " mBar"


    lblCyclename.Text = ControlCode.Parent.ProgramNumber & " - " & ControlCode.Parent.ProgramName



    lblTempIn.Text = CStr(ControlCode.IO.InletTemperature / 10 & "ºC")
    lblTempOut.Text = CStr(ControlCode.IO.OutletTemperature / 10 & " ºC")
    lblTempCon.Text = CStr(ControlCode.IO.CondenserTemperature / 10 & "ºC")



    If Not ControlCode.Parent.IsProgramRunning Then lblTempIn.Text = ""
    If Not ControlCode.Parent.IsProgramRunning Then lblPressure.Text = ""


    '        imgPaused.Visible = data.Parent_Paused 

    ' Build a collection of all the possible messages
    ' We show whether it's paused; anything in the Status variable; the step
    ' text; the button text;  and all unacknowledged alarms
    With messages_
      .Clear()
      ' If we are not running and there are no alarms, we may end up with nothing
      ' Unacknowleged alarms
      Dim isAlarm As Boolean
      Dim unackAlarms As String = ControlCode.Parent.UnacknowledgedAlarms
      If Not String.IsNullOrEmpty(unackAlarms) Then
        For Each alarm As String In unackAlarms.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
          isAlarm = True
          .Add(alarm)
        Next alarm
      End If
      AckLatch.Visible = isAlarm

      ' Any button text
      Dim buttonText As String = ControlCode.Parent.ButtonText
      If Not String.IsNullOrEmpty(buttonText) Then
        .Add(buttonText)
      Else
        ' Or a non-empty status string that has been created by the control
        Dim status As String = ControlCode.Status
        If Not String.IsNullOrEmpty(status) Then
          .Add(status)
        Else
          ' Or failing that, the step text (if any)
          Dim stepText As String = ControlCode.Parent.StepText
          If Not String.IsNullOrEmpty(stepText) Then .Add(stepText)
        End If
      End If
    End With
    ' Show any messages
    ShowAnyMessages()
  End Sub


  Private Sub changeMessageTimer__Tick(ByVal sender As Object, ByVal e As EventArgs) Handles changeMessageTimer_.Tick
    ' If IsControlObscured(Me) Then Exit Sub
    messageTicker_ += 1 : If messageTicker_ = 1000 Then messageTicker_ = 0
    ShowAnyMessages()
  End Sub

  Private Sub ShowAnyMessages()
    If Not String.IsNullOrEmpty(extraMessage_) Then lblMessages.Text = extraMessage_ : Exit Sub

    ' Choose just one of these messages, based on the message ticker
    If messages_.Count <> 0 Then
      lblMessages.Text = messages_(messageTicker_ Mod messages_.Count)
      Exit Sub
    End If

    ' Or ensure we clear the messages shown
    lblMessages.Text = ""
  End Sub
  ' Clicking on the alarm button sends a 'Run' to any command-sequencer
  Private Sub alarm__Click(ByVal sender As Object, ByVal e As EventArgs) Handles AckLatch.Click
    ' We already have a handy feature in the control code for this, so we use it
    ControlCode.PressButton = True
    ControlCode.PressButton = True
  End Sub

  
End Class
