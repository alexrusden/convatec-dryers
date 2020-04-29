<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopCycleView
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
    Me.Program1 = New System.Windows.Forms.Button
    Me.Program2 = New System.Windows.Forms.Button
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
    Me.Panel1.Border.Style = MimicControls.BorderStyle.FrameRaised
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Program1)
    Me.Panel1.Controls.Add(Me.Program2)
    Me.Panel1.Location = New System.Drawing.Point(153, 157)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(527, 231)
    Me.Panel1.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(83, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(371, 37)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "Confirm Abort Program"
    '
    'Program1
    '
    Me.Program1.BackColor = System.Drawing.Color.Silver
    Me.Program1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program1.Location = New System.Drawing.Point(65, 140)
    Me.Program1.Name = "Program1"
    Me.Program1.Size = New System.Drawing.Size(165, 52)
    Me.Program1.TabIndex = 5
    Me.Program1.Text = "Confirm"
    Me.Program1.UseVisualStyleBackColor = False
    '
    'Program2
    '
    Me.Program2.BackColor = System.Drawing.Color.Silver
    Me.Program2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Program2.Location = New System.Drawing.Point(289, 140)
    Me.Program2.Name = "Program2"
    Me.Program2.Size = New System.Drawing.Size(165, 52)
    Me.Program2.TabIndex = 8
    Me.Program2.Text = "Cancel"
    Me.Program2.UseVisualStyleBackColor = False
    '
    'StopCycleView
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.Panel1)
    Me.Name = "StopCycleView"
    Me.Size = New System.Drawing.Size(800, 526)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Program2 As System.Windows.Forms.Button
  Friend WithEvents Program1 As System.Windows.Forms.Button
  Friend WithEvents Panel1 As MimicControls.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
