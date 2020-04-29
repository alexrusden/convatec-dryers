
Public Class NewCycleView

  '' Only draw the BackgroundImage, not the BackgroundColor, for less flicker
  'Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
  '  e.Graphics.DrawImage(BackgroundImage, 0, 0)
  'End Sub

  Private controlCode_ As ControlCode

  Public Property ControlCode() As ControlCode
    Get
      Return controlCode_
    End Get
    Set(ByVal value As ControlCode)
      controlCode_ = value
    End Set
  End Property


  Public ProgSelected As Integer

  Public NoProgTimer As New Timer

  Public UserName As String

  Public pinEntered As Boolean

  Public BatchAlarm As Boolean

  Public ProgButton1NumberIs As Integer
  Public ProgButton2NumberIs As Integer
  Public ProgButton3NumberIs As Integer
  Public ProgButton4NumberIs As Integer
  Public ProgButton5NumberIs As Integer
  Public ProgButton6NumberIs As Integer
  Public ProgButton7NumberIs As Integer
  Public ProgButton8NumberIs As Integer

  Public ProgButton1NameIs As String
  Public ProgButton2NameIs As String
  Public ProgButton3NameIs As String
  Public ProgButton4NameIs As String
  Public ProgButton5NameIs As String
  Public ProgButton6NameIs As String
  Public ProgButton7NameIs As String
  Public ProgButton8NameIs As String

  Public Prog As String
  Public Batch As String
  Public ProgramNumber As Integer
  Public ProgramName As String
  Public Redye As Integer
  Public BatchTrimed As String
  Public Blocked As Integer
  Public TimeoutTimer As New Timer
  Public NameEntered As Boolean

  Private Enum EventId
    BatchStartUser
  End Enum

  Public Sub OnControlCodeRefreshed()
    With ControlCode

      If TimeoutTimer.TimeRemaining = 1 Then
        'Clear inputs
        ProgSelected = 0

        BatchNameBox.Text = ""


        UserNameBox.Text = ""
        ControlCode.Parent.PressButton(ButtonPosition.Operator, 3)
      End If




      Static ReadTimer As New Timer

      If ReadTimer.Finished Then


        '----------------------

        Dim DT = ControlCode.Parent.DbGetDataTable("SELECT * FROM Programs order by ProgramNumber ")
        Dim rows = DT.Rows
        Dim RowsCount = rows.Count 'How Many Programs do we have 

        If rows.Count > 0 Then

          If rows.Count > 0 Then Program1_PB.Text = (rows(0)("ProgramNumber")).ToString & "-" & (rows(0)("Name")).ToString
          If rows.Count > 1 Then Program2_PB.Text = (rows(1)("ProgramNumber")).ToString & "-" & (rows(1)("Name")).ToString
          If rows.Count > 2 Then Program3_PB.Text = (rows(2)("ProgramNumber")).ToString & "-" & (rows(2)("Name")).ToString
          If rows.Count > 3 Then Program4_PB.Text = (rows(3)("ProgramNumber")).ToString & "-" & (rows(3)("Name")).ToString
          If rows.Count > 4 Then Program5_PB.Text = (rows(4)("ProgramNumber")).ToString & "-" & (rows(4)("Name")).ToString
          If rows.Count > 5 Then Program6_PB.Text = (rows(5)("ProgramNumber")).ToString & "-" & (rows(5)("Name")).ToString
          If rows.Count > 6 Then Program7_PB.Text = (rows(6)("ProgramNumber")).ToString & "-" & (rows(6)("Name")).ToString
          If rows.Count > 7 Then Program8_PB.Text = (rows(7)("ProgramNumber")).ToString & "-" & (rows(7)("Name")).ToString


          If rows.Count > 0 Then ProgButton1NumberIs = CInt((rows(0)("ProgramNumber")))
          If rows.Count > 1 Then ProgButton2NumberIs = CInt((rows(1)("ProgramNumber")))
          If rows.Count > 2 Then ProgButton3NumberIs = CInt((rows(2)("ProgramNumber")))
          If rows.Count > 3 Then ProgButton4NumberIs = CInt((rows(3)("ProgramNumber")))
          If rows.Count > 4 Then ProgButton5NumberIs = CInt((rows(4)("ProgramNumber")))
          If rows.Count > 5 Then ProgButton6NumberIs = CInt((rows(5)("ProgramNumber")))
          If rows.Count > 6 Then ProgButton7NumberIs = CInt((rows(6)("ProgramNumber")))
          If rows.Count > 7 Then ProgButton8NumberIs = CInt((rows(7)("ProgramNumber")))

          If rows.Count > 0 Then ProgButton1NameIs = CStr(((rows(0)("Name"))))
          If rows.Count > 1 Then ProgButton2NameIs = CStr(((rows(1)("Name"))))
          If rows.Count > 2 Then ProgButton3NameIs = CStr(((rows(2)("Name"))))
          If rows.Count > 3 Then ProgButton4NameIs = CStr(((rows(3)("Name"))))
          If rows.Count > 4 Then ProgButton5NameIs = CStr(((rows(4)("Name"))))
          If rows.Count > 5 Then ProgButton6NameIs = CStr(((rows(5)("Name"))))
          If rows.Count > 6 Then ProgButton7NameIs = CStr(((rows(6)("Name"))))
          If rows.Count > 7 Then ProgButton8NameIs = CStr(((rows(7)("Name"))))


        End If


        Program1_PB.Visible = rows.Count > 0
        Program2_PB.Visible = rows.Count > 1
        Program3_PB.Visible = rows.Count > 2
        Program4_PB.Visible = rows.Count > 3
        Program5_PB.Visible = rows.Count > 4
        Program6_PB.Visible = rows.Count > 5
        Program7_PB.Visible = rows.Count > 6
        Program8_PB.Visible = rows.Count > 7

        ReadTimer.TimeRemaining = 2



      End If


    End With
  End Sub

  Private Sub Program1_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program1_PB.Click
    ProgSelected = 1
    ' BatchNameBox.Text = Program1_PB.Text
    BatchNameBox.Focus()
  End Sub

  Private Sub Program2_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program2_PB.Click
    ProgSelected = 2
    BatchNameBox.Focus()
  End Sub

  Private Sub Program3_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program3_PB.Click
    ProgSelected = 3
    BatchNameBox.Focus()
  End Sub

  Private Sub Program4_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program4_PB.Click
    ProgSelected = 4
    BatchNameBox.Focus()
  End Sub

  Private Sub Program5_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program5_PB.Click
    ProgSelected = 5
    BatchNameBox.Focus()
  End Sub

  Private Sub Program6_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program6_PB.Click
    ProgSelected = 6
    BatchNameBox.Focus()
  End Sub

  Private Sub Program7_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program7_PB.Click
    ProgSelected = 7
    BatchNameBox.Focus()
  End Sub

  Private Sub Program8_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Program8_PB.Click
    ProgSelected = 8
    BatchNameBox.Focus()
  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    KeyPad1.Visible = Not UserNameBox.Focused

    KeyPad2.Visible = UserNameBox.Focused

    If BatchNameBox.Text = "" Then

    Else
      Batchnamelable.Visible = False
    End If

    EnterPinNumber.Enabled = (Not UserNameBox.Text = "") 'And (Not pinEntered)

    If ProgSelected > 0 Then NoProg.Visible = False

    DisplayDate.Text = CStr(Date.Now)

    If ProgSelected = 1 Then
      Program1_PB.BackColor = Color.LightGreen
    Else
      Program1_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 2 Then
      Program2_PB.BackColor = Color.LightGreen
    Else
      Program2_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 3 Then
      Program3_PB.BackColor = Color.LightGreen
    Else
      Program3_PB.BackColor = Color.LightGray
    End If



    If ProgSelected = 4 Then
      Program4_PB.BackColor = Color.LightGreen
    Else
      Program4_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 5 Then
      Program5_PB.BackColor = Color.LightGreen
    Else
      Program5_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 6 Then
      Program6_PB.BackColor = Color.LightGreen
    Else
      Program6_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 7 Then
      Program7_PB.BackColor = Color.LightGreen
    Else
      Program7_PB.BackColor = Color.LightGray
    End If


    If ProgSelected = 8 Then
      Program8_PB.BackColor = Color.LightGreen
    Else
      Program8_PB.BackColor = Color.LightGray
    End If
    '------------------------------------------------------------------------------------------------

    '   Starting a program screen and checking the Job is the correct name,  AGN, HYD, MED or ALG
    If ProgSelected = 1 Then ProgramNumber = ProgButton1NumberIs
    If ProgSelected = 2 Then ProgramNumber = ProgButton2NumberIs
    If ProgSelected = 3 Then ProgramNumber = ProgButton3NumberIs
    If ProgSelected = 4 Then ProgramNumber = ProgButton4NumberIs
    If ProgSelected = 5 Then ProgramNumber = ProgButton5NumberIs
    If ProgSelected = 6 Then ProgramNumber = ProgButton6NumberIs
    If ProgSelected = 7 Then ProgramNumber = ProgButton7NumberIs
    If ProgSelected = 8 Then ProgramNumber = ProgButton8NumberIs

    If ProgSelected = 1 Then ProgramName = ProgButton1NameIs
    If ProgSelected = 2 Then ProgramName = ProgButton2NameIs
    If ProgSelected = 3 Then ProgramName = ProgButton3NameIs
    If ProgSelected = 4 Then ProgramName = ProgButton4NameIs
    If ProgSelected = 5 Then ProgramName = ProgButton5NameIs
    If ProgSelected = 6 Then ProgramName = ProgButton6NameIs
    If ProgSelected = 7 Then ProgramName = ProgButton7NameIs
    If ProgSelected = 8 Then ProgramName = ProgButton8NameIs


    If ProgramName <> "" Then
      If BatchNameBox.TextLength > 3 Then 'Check Batch is correct name
        Dim BatchNameTrimmed = BatchNameBox.Text.Remove(3)
        Dim ProgramNameTrimmed = ProgramName.Remove(3)
        Label4.Visible = BatchNameTrimmed <> ProgramNameTrimmed
      Else
        Label4.Visible = False
      End If


    End If



    '---------------------------------------------------------------------------------------------------





  End Sub


  Private Sub Exit_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_PB.Click
    ProgSelected = 0
    ControlCode.Parent.PressButton(ButtonPosition.Operator, 3)

  End Sub

  Private Sub Start_PB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_PB.Click


    If ProgSelected = 0 Then
      NoProg.Visible = True
      Exit Sub
    End If

    If BatchNameBox.Text = "" Then
      Batchnamelable.Visible = True
      Exit Sub
    End If

    EnterUser.Visible = False

    If UserNameBox.Text = "" Or UserNameBox.Text = "No Name" Or (Not NameEntered) Then
      EnterUser.Visible = True

      Exit Sub
    End If

    ' If CheckBoxStart.Checked Then Blocked = 1



    Prog = ProgSelected.ToString

    Batch = BatchNameBox.Text



    If BatchNameBox.Text.Remove(3) <> ProgramName.Remove(3) Then Exit Sub



    Dim DT = ControlCode.Parent.DbGetDataTable("SELECT * FROM Dyelots  where dyelot = '" & Batch & "'")
    Dim rows = DT.Rows
    Dim RowsCount = rows.Count


    If rows.Count > 0 Then
      Redye = rows.Count
    Else
      Redye = 0
    End If


    If ProgSelected > 0 Then
      Dim DR2 = ControlCode.Parent.DbExecute("INSERT INTO dyelots (Dyelot,redye,machine,Blocked,program) values ('" & Batch & "'," & Redye & ",'Local',0,'" & ProgramNumber & "')")
    End If

    Dim TheUser = "fred"

    ControlCode.Parent.LogEvent(LogEventType.Information, EventId.BatchStartUser, "TheUser")

    ControlCode.Parent.PressButton(ButtonPosition.Operator, 3)

    '------------------------------------------------
    'Clear inputs
    ProgSelected = 0

    BatchNameBox.Text = ""


    UserNameBox.Text = ""


    NameEntered = False
    '-------------------------------------------------


    '  ("Update  Products set  ChemicalCode = '" & TextBoxCode.Text & "' Where ValveID = '" & ValveID & "'")



  End Sub

  Private Sub EnterPinNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterPinNumber.Click

    pinEntered = True

    If UserNameBox.Text = "" Then Exit Sub

    Dim Userpin As Integer

    Userpin = CInt(UserNameBox.Text)

    Dim PinNames = ControlCode.Parent.DbGetDataTable("SELECT UserName FROM Users WHERE Pin = " & Userpin)

    If (PinNames.Rows.Count > 0) Then

      Dim DR = PinNames.Rows(0)

      ControlCode.UserName = DR(0).ToString

      UserNameBox.Text = ControlCode.UserName
      NameEntered = True
    Else
      ControlCode.UserName = "No Name"
      UserNameBox.Text = ControlCode.UserName
      NameEntered = False
    End If


  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    pinEntered = False
    UserNameBox.Text = ""
    UserNameBox.Focus()
  End Sub
End Class






