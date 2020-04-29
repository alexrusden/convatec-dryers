<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUsers
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
    Me.Panel1 = New MimicControls.Panel
    Me.Label1 = New System.Windows.Forms.Label
    Me.UserNameList = New System.Windows.Forms.ListBox
    Me.Panel3 = New MimicControls.Panel
    Me.Label3 = New System.Windows.Forms.Label
    Me.Button3 = New System.Windows.Forms.Button
    Me.TextBoxUserName = New System.Windows.Forms.TextBox
    Me.TextBoxPin = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Panel4 = New MimicControls.Panel
    Me.Button2 = New System.Windows.Forms.Button
    Me.btUpdate = New System.Windows.Forms.Button
    Me.Button1 = New System.Windows.Forms.Button
    Me.Panel2 = New MimicControls.Panel
    Me.KeyPad1 = New MimicControls.KeyPad
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Panel1.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.UserNameList)
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Controls.Add(Me.Panel4)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(800, 535)
    Me.Panel1.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(94, 473)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(132, 19)
    Me.Label1.TabIndex = 35
    Me.Label1.Text = "User Name List"
    '
    'UserNameList
    '
    Me.UserNameList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.UserNameList.BackColor = System.Drawing.Color.LightGray
    Me.UserNameList.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UserNameList.FormattingEnabled = True
    Me.UserNameList.HorizontalScrollbar = True
    Me.UserNameList.ItemHeight = 25
    Me.UserNameList.Location = New System.Drawing.Point(7, 4)
    Me.UserNameList.Name = "UserNameList"
    Me.UserNameList.Size = New System.Drawing.Size(310, 454)
    Me.UserNameList.TabIndex = 34
    '
    'Panel3
    '
    Me.Panel3.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Controls.Add(Me.Button3)
    Me.Panel3.Controls.Add(Me.TextBoxUserName)
    Me.Panel3.Controls.Add(Me.TextBoxPin)
    Me.Panel3.Controls.Add(Me.Label2)
    Me.Panel3.Location = New System.Drawing.Point(322, 4)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(471, 113)
    Me.Panel3.TabIndex = 41
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.ForeColor = System.Drawing.Color.White
    Me.Label3.Location = New System.Drawing.Point(16, 13)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(98, 19)
    Me.Label3.TabIndex = 42
    Me.Label3.Text = "User Name"
    '
    'Button3
    '
    Me.Button3.BackColor = System.Drawing.Color.LightGray
    Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button3.Location = New System.Drawing.Point(256, 128)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(109, 33)
    Me.Button3.TabIndex = 39
    Me.Button3.Text = "Clear"
    Me.Button3.UseVisualStyleBackColor = False
    '
    'TextBoxUserName
    '
    Me.TextBoxUserName.AcceptsReturn = True
    Me.TextBoxUserName.BackColor = System.Drawing.Color.LightGray
    Me.TextBoxUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TextBoxUserName.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxUserName.Location = New System.Drawing.Point(138, 8)
    Me.TextBoxUserName.Name = "TextBoxUserName"
    Me.TextBoxUserName.Size = New System.Drawing.Size(322, 30)
    Me.TextBoxUserName.TabIndex = 40
    Me.TextBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'TextBoxPin
    '
    Me.TextBoxPin.BackColor = System.Drawing.Color.LightGray
    Me.TextBoxPin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TextBoxPin.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxPin.Location = New System.Drawing.Point(138, 60)
    Me.TextBoxPin.Name = "TextBoxPin"
    Me.TextBoxPin.Size = New System.Drawing.Size(322, 30)
    Me.TextBoxPin.TabIndex = 38
    Me.TextBoxPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(56, 65)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 19)
    Me.Label2.TabIndex = 37
    Me.Label2.Text = "Pin"
    '
    'Panel4
    '
    Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Panel4.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel4.Controls.Add(Me.Button2)
    Me.Panel4.Controls.Add(Me.btUpdate)
    Me.Panel4.Controls.Add(Me.Button1)
    Me.Panel4.Location = New System.Drawing.Point(321, 458)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(471, 51)
    Me.Panel4.TabIndex = 40
    '
    'Button2
    '
    Me.Button2.BackColor = System.Drawing.Color.LightGray
    Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button2.Location = New System.Drawing.Point(171, 5)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(128, 41)
    Me.Button2.TabIndex = 38
    Me.Button2.Text = "Add"
    Me.Button2.UseVisualStyleBackColor = False
    '
    'btUpdate
    '
    Me.btUpdate.BackColor = System.Drawing.Color.LightGray
    Me.btUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btUpdate.Location = New System.Drawing.Point(5, 5)
    Me.btUpdate.Name = "btUpdate"
    Me.btUpdate.Size = New System.Drawing.Size(128, 41)
    Me.btUpdate.TabIndex = 34
    Me.btUpdate.Text = "Update"
    Me.btUpdate.UseVisualStyleBackColor = False
    '
    'Button1
    '
    Me.Button1.BackColor = System.Drawing.Color.LightGray
    Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button1.Location = New System.Drawing.Point(338, 5)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(123, 41)
    Me.Button1.TabIndex = 37
    Me.Button1.Text = "Remove"
    Me.Button1.UseVisualStyleBackColor = False
    '
    'Panel2
    '
    Me.Panel2.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel2.Controls.Add(Me.KeyPad1)
    Me.Panel2.Location = New System.Drawing.Point(321, 118)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(471, 339)
    Me.Panel2.TabIndex = 38
    '
    'KeyPad1
    '
    Me.KeyPad1.BackColor = System.Drawing.Color.Black
    Me.KeyPad1.Font = New System.Drawing.Font("Tahoma", 41.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
    Me.KeyPad1.ForeColor = System.Drawing.Color.Black
    Me.KeyPad1.Location = New System.Drawing.Point(5, 5)
    Me.KeyPad1.Name = "KeyPad1"
    Me.KeyPad1.Size = New System.Drawing.Size(458, 327)
    Me.KeyPad1.Style = MimicControls.KeypadStyle.Alpha
    Me.KeyPad1.TabIndex = 20
    '
    'EditUsers
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.Panel1)
    Me.Name = "EditUsers"
    Me.Size = New System.Drawing.Size(800, 526)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As MimicControls.Panel
  Friend WithEvents UserNameList As System.Windows.Forms.ListBox
  Friend WithEvents Panel2 As MimicControls.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel4 As MimicControls.Panel
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents btUpdate As System.Windows.Forms.Button
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents KeyPad1 As MimicControls.KeyPad
  Friend WithEvents Panel3 As MimicControls.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
  Friend WithEvents TextBoxPin As System.Windows.Forms.TextBox

End Class
