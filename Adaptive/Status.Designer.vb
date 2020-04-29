<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status))
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.lblTempIn = New System.Windows.Forms.Label
    Me.lblMessages = New System.Windows.Forms.Label
    Me.changeMessageTimer_ = New System.Windows.Forms.Timer(Me.components)
    Me.AckLatch = New System.Windows.Forms.PictureBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblCyclename = New System.Windows.Forms.Label
    Me.labbb = New System.Windows.Forms.Label
    Me.lblPressure = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.lblTempOut = New System.Windows.Forms.Label
    Me.lblTempCon = New System.Windows.Forms.Label
    CType(Me.AckLatch, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.Label3.Location = New System.Drawing.Point(1, -1)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(21, 12)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "TIn"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.Label4.Location = New System.Drawing.Point(378, -3)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(216, 12)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Active Alarms - Press Triangle to Cancel Alarms"
    '
    'lblTempIn
    '
    Me.lblTempIn.AutoSize = True
    Me.lblTempIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTempIn.Location = New System.Drawing.Point(-4, 14)
    Me.lblTempIn.Name = "lblTempIn"
    Me.lblTempIn.Size = New System.Drawing.Size(0, 19)
    Me.lblTempIn.TabIndex = 2
    '
    'lblMessages
    '
    Me.lblMessages.AutoSize = True
    Me.lblMessages.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMessages.Location = New System.Drawing.Point(323, 11)
    Me.lblMessages.Name = "lblMessages"
    Me.lblMessages.Size = New System.Drawing.Size(0, 19)
    Me.lblMessages.TabIndex = 3
    '
    'changeMessageTimer_
    '
    Me.changeMessageTimer_.Enabled = True
    Me.changeMessageTimer_.Interval = 800
    '
    'AckLatch
    '
    Me.AckLatch.Dock = System.Windows.Forms.DockStyle.Right
    Me.AckLatch.Image = CType(resources.GetObject("AckLatch.Image"), System.Drawing.Image)
    Me.AckLatch.Location = New System.Drawing.Point(715, 0)
    Me.AckLatch.Name = "AckLatch"
    Me.AckLatch.Size = New System.Drawing.Size(31, 36)
    Me.AckLatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.AckLatch.TabIndex = 9
    Me.AckLatch.TabStop = False
    Me.AckLatch.Visible = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.Label1.Location = New System.Drawing.Point(239, -1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(58, 12)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Cycle Name"
    '
    'lblCyclename
    '
    Me.lblCyclename.AutoSize = True
    Me.lblCyclename.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCyclename.Location = New System.Drawing.Point(197, 11)
    Me.lblCyclename.Name = "lblCyclename"
    Me.lblCyclename.Size = New System.Drawing.Size(0, 19)
    Me.lblCyclename.TabIndex = 10
    '
    'labbb
    '
    Me.labbb.AutoSize = True
    Me.labbb.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.labbb.Location = New System.Drawing.Point(163, -1)
    Me.labbb.Name = "labbb"
    Me.labbb.Size = New System.Drawing.Size(15, 12)
    Me.labbb.TabIndex = 11
    Me.labbb.Text = "P:"
    '
    'lblPressure
    '
    Me.lblPressure.AutoSize = True
    Me.lblPressure.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPressure.Location = New System.Drawing.Point(150, 14)
    Me.lblPressure.Name = "lblPressure"
    Me.lblPressure.Size = New System.Drawing.Size(0, 19)
    Me.lblPressure.TabIndex = 12
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.Label2.Location = New System.Drawing.Point(43, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 12)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "TOut"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.0!)
    Me.Label5.Location = New System.Drawing.Point(95, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(30, 12)
    Me.Label5.TabIndex = 14
    Me.Label5.Text = "TCon"
    '
    'lblTempOut
    '
    Me.lblTempOut.AutoSize = True
    Me.lblTempOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTempOut.Location = New System.Drawing.Point(38, 14)
    Me.lblTempOut.Name = "lblTempOut"
    Me.lblTempOut.Size = New System.Drawing.Size(0, 19)
    Me.lblTempOut.TabIndex = 15
    '
    'lblTempCon
    '
    Me.lblTempCon.AutoSize = True
    Me.lblTempCon.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTempCon.Location = New System.Drawing.Point(90, 14)
    Me.lblTempCon.Name = "lblTempCon"
    Me.lblTempCon.Size = New System.Drawing.Size(0, 19)
    Me.lblTempCon.TabIndex = 16
    '
    'Status
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.Controls.Add(Me.lblTempCon)
    Me.Controls.Add(Me.lblTempOut)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lblPressure)
    Me.Controls.Add(Me.labbb)
    Me.Controls.Add(Me.AckLatch)
    Me.Controls.Add(Me.lblCyclename)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblMessages)
    Me.Controls.Add(Me.lblTempIn)
    Me.Name = "Status"
    Me.Size = New System.Drawing.Size(746, 36)
    CType(Me.AckLatch, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents lblTempIn As System.Windows.Forms.Label
  Friend WithEvents lblMessages As System.Windows.Forms.Label
  Friend WithEvents changeMessageTimer_ As System.Windows.Forms.Timer
  Friend WithEvents AckLatch As System.Windows.Forms.PictureBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblCyclename As System.Windows.Forms.Label
  Friend WithEvents labbb As System.Windows.Forms.Label
  Friend WithEvents lblPressure As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblTempOut As System.Windows.Forms.Label
  Friend WithEvents lblTempCon As System.Windows.Forms.Label

End Class
