<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCycleView
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Label4 = New System.Windows.Forms.Label
    Me.Batchnamelable = New System.Windows.Forms.Label
    Me.NoProg = New System.Windows.Forms.Label
    Me.EnterUser = New System.Windows.Forms.Label
    Me.KeyPad1 = New MimicControls.KeyPad
    Me.Panel3 = New MimicControls.Panel
    Me.KeyPad2 = New MimicControls.KeyPad
    Me.Panel2 = New MimicControls.Panel
    Me.Program8_PB = New System.Windows.Forms.Button
    Me.Program7_PB = New System.Windows.Forms.Button
    Me.Program6_PB = New System.Windows.Forms.Button
    Me.Program5_PB = New System.Windows.Forms.Button
    Me.Program1_PB = New System.Windows.Forms.Button
    Me.Program3_PB = New System.Windows.Forms.Button
    Me.Program4_PB = New System.Windows.Forms.Button
    Me.Program2_PB = New System.Windows.Forms.Button
    Me.Panel1 = New MimicControls.Panel
    Me.CheckBoxStart = New System.Windows.Forms.CheckBox
    Me.Button1 = New System.Windows.Forms.Button
    Me.EnterPinNumber = New System.Windows.Forms.Button
    Me.Exit_PB = New System.Windows.Forms.Button
    Me.Start_PB = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.UserNameBox = New System.Windows.Forms.TextBox
    Me.BatchNameBox = New System.Windows.Forms.TextBox
    Me.DisplayDate = New System.Windows.Forms.TextBox
    Me.Panel3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Timer1
    '
    Me.Timer1.Enabled = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.Red
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(239, 180)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(356, 33)
    Me.Label4.TabIndex = 21
    Me.Label4.Text = "BATCH NAME MISMATCH"
    Me.Label4.Visible = False
    '
    'Batchnamelable
    '
    Me.Batchnamelable.BackColor = System.Drawing.Color.Red
    Me.Batchnamelable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Batchnamelable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Batchnamelable.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Batchnamelable.Location = New System.Drawing.Point(254, 178)
    Me.Batchnamelable.Name = "Batchnamelable"
    Me.Batchnamelable.Size = New System.Drawing.Size(341, 35)
    Me.Batchnamelable.TabIndex = 20
    Me.Batchnamelable.Text = "Please enter a Batch Name"
    Me.Batchnamelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.Batchnamelable.Visible = False
    '
    'NoProg
    '
    Me.NoProg.BackColor = System.Drawing.Color.Red
    Me.NoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.NoProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.NoProg.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NoProg.Location = New System.Drawing.Point(245, 178)
    Me.NoProg.Name = "NoProg"
    Me.NoProg.Size = New System.Drawing.Size(365, 35)
    Me.NoProg.TabIndex = 10
    Me.NoProg.Text = "PLEASE SELECT A PROGRAM"
    Me.NoProg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.NoProg.Visible = False
    '
    'EnterUser
    '
    Me.EnterUser.AutoSize = True
    Me.EnterUser.BackColor = System.Drawing.Color.Red
    Me.EnterUser.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.EnterUser.Location = New System.Drawing.Point(277, 180)
    Me.EnterUser.Name = "EnterUser"
    Me.EnterUser.Size = New System.Drawing.Size(299, 33)
    Me.EnterUser.TabIndex = 22
    Me.EnterUser.Text = "PLEASE ENTER USER"
    Me.EnterUser.Visible = False
    '
    'KeyPad1
    '
    Me.KeyPad1.Font = New System.Drawing.Font("Tahoma", 37.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.KeyPad1.ForeColor = System.Drawing.Color.Black
    Me.KeyPad1.Location = New System.Drawing.Point(396, 229)
    Me.KeyPad1.Name = "KeyPad1"
    Me.KeyPad1.Size = New System.Drawing.Size(394, 303)
    Me.KeyPad1.Style = MimicControls.KeypadStyle.Alpha
    Me.KeyPad1.TabIndex = 20
    '
    'Panel3
    '
    Me.Panel3.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel3.Controls.Add(Me.KeyPad2)
    Me.Panel3.Location = New System.Drawing.Point(390, 228)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(406, 305)
    Me.Panel3.TabIndex = 18
    '
    'KeyPad2
    '
    Me.KeyPad2.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.KeyPad2.ForeColor = System.Drawing.Color.Black
    Me.KeyPad2.Location = New System.Drawing.Point(12, 7)
    Me.KeyPad2.Name = "KeyPad2"
    Me.KeyPad2.Size = New System.Drawing.Size(375, 295)
    Me.KeyPad2.Style = MimicControls.KeypadStyle.Numeric
    Me.KeyPad2.TabIndex = 19
    '
    'Panel2
    '
    Me.Panel2.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel2.Controls.Add(Me.Program8_PB)
    Me.Panel2.Controls.Add(Me.Program7_PB)
    Me.Panel2.Controls.Add(Me.Program6_PB)
    Me.Panel2.Controls.Add(Me.Program5_PB)
    Me.Panel2.Controls.Add(Me.Program1_PB)
    Me.Panel2.Controls.Add(Me.Program3_PB)
    Me.Panel2.Controls.Add(Me.Program4_PB)
    Me.Panel2.Controls.Add(Me.Program2_PB)
    Me.Panel2.Location = New System.Drawing.Point(13, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(770, 161)
    Me.Panel2.TabIndex = 17
    '
    'Program8_PB
    '
    Me.Program8_PB.BackColor = System.Drawing.Color.Silver
    Me.Program8_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program8_PB.Location = New System.Drawing.Point(589, 97)
    Me.Program8_PB.Name = "Program8_PB"
    Me.Program8_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program8_PB.TabIndex = 12
    Me.Program8_PB.Text = "-"
    Me.Program8_PB.UseVisualStyleBackColor = False
    '
    'Program7_PB
    '
    Me.Program7_PB.BackColor = System.Drawing.Color.Silver
    Me.Program7_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program7_PB.Location = New System.Drawing.Point(399, 97)
    Me.Program7_PB.Name = "Program7_PB"
    Me.Program7_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program7_PB.TabIndex = 11
    Me.Program7_PB.Text = "-"
    Me.Program7_PB.UseVisualStyleBackColor = False
    '
    'Program6_PB
    '
    Me.Program6_PB.BackColor = System.Drawing.Color.Silver
    Me.Program6_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program6_PB.Location = New System.Drawing.Point(209, 97)
    Me.Program6_PB.Name = "Program6_PB"
    Me.Program6_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program6_PB.TabIndex = 10
    Me.Program6_PB.Text = "-"
    Me.Program6_PB.UseVisualStyleBackColor = False
    '
    'Program5_PB
    '
    Me.Program5_PB.BackColor = System.Drawing.Color.Silver
    Me.Program5_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program5_PB.Location = New System.Drawing.Point(19, 97)
    Me.Program5_PB.Name = "Program5_PB"
    Me.Program5_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program5_PB.TabIndex = 9
    Me.Program5_PB.Text = "-"
    Me.Program5_PB.UseVisualStyleBackColor = False
    '
    'Program1_PB
    '
    Me.Program1_PB.BackColor = System.Drawing.Color.Silver
    Me.Program1_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program1_PB.Location = New System.Drawing.Point(19, 14)
    Me.Program1_PB.Name = "Program1_PB"
    Me.Program1_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program1_PB.TabIndex = 5
    Me.Program1_PB.Text = "-"
    Me.Program1_PB.UseVisualStyleBackColor = False
    '
    'Program3_PB
    '
    Me.Program3_PB.BackColor = System.Drawing.Color.Silver
    Me.Program3_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program3_PB.Location = New System.Drawing.Point(399, 14)
    Me.Program3_PB.Name = "Program3_PB"
    Me.Program3_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program3_PB.TabIndex = 6
    Me.Program3_PB.Text = "-"
    Me.Program3_PB.UseVisualStyleBackColor = False
    '
    'Program4_PB
    '
    Me.Program4_PB.BackColor = System.Drawing.Color.Silver
    Me.Program4_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program4_PB.Location = New System.Drawing.Point(589, 14)
    Me.Program4_PB.Name = "Program4_PB"
    Me.Program4_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program4_PB.TabIndex = 7
    Me.Program4_PB.Text = "-"
    Me.Program4_PB.UseVisualStyleBackColor = False
    '
    'Program2_PB
    '
    Me.Program2_PB.BackColor = System.Drawing.Color.Silver
    Me.Program2_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program2_PB.Location = New System.Drawing.Point(209, 14)
    Me.Program2_PB.Name = "Program2_PB"
    Me.Program2_PB.Size = New System.Drawing.Size(165, 52)
    Me.Program2_PB.TabIndex = 8
    Me.Program2_PB.Text = "-"
    Me.Program2_PB.UseVisualStyleBackColor = False
    '
    'Panel1
    '
    Me.Panel1.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel1.Controls.Add(Me.CheckBoxStart)
    Me.Panel1.Controls.Add(Me.Button1)
    Me.Panel1.Controls.Add(Me.EnterPinNumber)
    Me.Panel1.Controls.Add(Me.Exit_PB)
    Me.Panel1.Controls.Add(Me.Start_PB)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.UserNameBox)
    Me.Panel1.Controls.Add(Me.BatchNameBox)
    Me.Panel1.Controls.Add(Me.DisplayDate)
    Me.Panel1.Location = New System.Drawing.Point(13, 228)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(374, 304)
    Me.Panel1.TabIndex = 9
    '
    'CheckBoxStart
    '
    Me.CheckBoxStart.AutoSize = True
    Me.CheckBoxStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.CheckBoxStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckBoxStart.ForeColor = System.Drawing.Color.White
    Me.CheckBoxStart.Location = New System.Drawing.Point(35, 203)
    Me.CheckBoxStart.Name = "CheckBoxStart"
    Me.CheckBoxStart.Size = New System.Drawing.Size(102, 20)
    Me.CheckBoxStart.TabIndex = 21
    Me.CheckBoxStart.Text = "Block Start"
    Me.CheckBoxStart.UseVisualStyleBackColor = False
    '
    'Button1
    '
    Me.Button1.BackColor = System.Drawing.Color.Silver
    Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button1.Location = New System.Drawing.Point(152, 159)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(104, 30)
    Me.Button1.TabIndex = 19
    Me.Button1.Text = "Clear Name"
    Me.Button1.UseVisualStyleBackColor = False
    '
    'EnterPinNumber
    '
    Me.EnterPinNumber.BackColor = System.Drawing.Color.Silver
    Me.EnterPinNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.EnterPinNumber.Location = New System.Drawing.Point(29, 159)
    Me.EnterPinNumber.Name = "EnterPinNumber"
    Me.EnterPinNumber.Size = New System.Drawing.Size(117, 30)
    Me.EnterPinNumber.TabIndex = 18
    Me.EnterPinNumber.Text = "Enter Pin"
    Me.EnterPinNumber.UseVisualStyleBackColor = False
    '
    'Exit_PB
    '
    Me.Exit_PB.BackColor = System.Drawing.Color.Silver
    Me.Exit_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Exit_PB.Location = New System.Drawing.Point(197, 236)
    Me.Exit_PB.Name = "Exit_PB"
    Me.Exit_PB.Size = New System.Drawing.Size(165, 52)
    Me.Exit_PB.TabIndex = 17
    Me.Exit_PB.Text = "Return (Exit)"
    Me.Exit_PB.UseVisualStyleBackColor = False
    '
    'Start_PB
    '
    Me.Start_PB.BackColor = System.Drawing.Color.Silver
    Me.Start_PB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Start_PB.Location = New System.Drawing.Point(7, 236)
    Me.Start_PB.Name = "Start_PB"
    Me.Start_PB.Size = New System.Drawing.Size(165, 52)
    Me.Start_PB.TabIndex = 13
    Me.Start_PB.Text = "Start Cycle"
    Me.Start_PB.UseVisualStyleBackColor = False
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(267, 131)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(86, 16)
    Me.Label3.TabIndex = 15
    Me.Label3.Text = "User Name"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(267, 66)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(89, 16)
    Me.Label2.TabIndex = 14
    Me.Label2.Text = "Date/ Time "
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(267, 98)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(92, 16)
    Me.Label1.TabIndex = 13
    Me.Label1.Text = "Batch Name"
    '
    'UserNameBox
    '
    Me.UserNameBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UserNameBox.Location = New System.Drawing.Point(29, 126)
    Me.UserNameBox.Name = "UserNameBox"
    Me.UserNameBox.Size = New System.Drawing.Size(227, 27)
    Me.UserNameBox.TabIndex = 12
    Me.UserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'BatchNameBox
    '
    Me.BatchNameBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BatchNameBox.Location = New System.Drawing.Point(29, 93)
    Me.BatchNameBox.Name = "BatchNameBox"
    Me.BatchNameBox.Size = New System.Drawing.Size(227, 27)
    Me.BatchNameBox.TabIndex = 11
    Me.BatchNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'DisplayDate
    '
    Me.DisplayDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DisplayDate.Location = New System.Drawing.Point(29, 60)
    Me.DisplayDate.Name = "DisplayDate"
    Me.DisplayDate.Size = New System.Drawing.Size(227, 27)
    Me.DisplayDate.TabIndex = 10
    Me.DisplayDate.Text = "-"
    Me.DisplayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'NewCycleView
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Controls.Add(Me.EnterUser)
    Me.Controls.Add(Me.KeyPad1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Batchnamelable)
    Me.Controls.Add(Me.Panel3)
    Me.Controls.Add(Me.NoProg)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "NewCycleView"
    Me.Size = New System.Drawing.Size(800, 535)
    Me.Panel3.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Program2_PB As System.Windows.Forms.Button
  Friend WithEvents Program4_PB As System.Windows.Forms.Button
  Friend WithEvents Program3_PB As System.Windows.Forms.Button
  Friend WithEvents Program1_PB As System.Windows.Forms.Button
  Friend WithEvents Panel1 As MimicControls.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents UserNameBox As System.Windows.Forms.TextBox
  Friend WithEvents BatchNameBox As System.Windows.Forms.TextBox
  Friend WithEvents DisplayDate As System.Windows.Forms.TextBox
  Friend WithEvents Panel2 As MimicControls.Panel
  Friend WithEvents Panel3 As MimicControls.Panel
  Friend WithEvents Program5_PB As System.Windows.Forms.Button
  Friend WithEvents Program6_PB As System.Windows.Forms.Button
  Friend WithEvents Program8_PB As System.Windows.Forms.Button
  Friend WithEvents Program7_PB As System.Windows.Forms.Button
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents Start_PB As System.Windows.Forms.Button
  Friend WithEvents Exit_PB As System.Windows.Forms.Button
  Friend WithEvents NoProg As System.Windows.Forms.Label
  Friend WithEvents EnterPinNumber As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents KeyPad2 As MimicControls.KeyPad
  Friend WithEvents Batchnamelable As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents EnterUser As System.Windows.Forms.Label
  Friend WithEvents CheckBoxStart As System.Windows.Forms.CheckBox
  Friend WithEvents KeyPad1 As MimicControls.KeyPad

End Class
