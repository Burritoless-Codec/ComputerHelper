<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Volumecontrol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Volumecontrol))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.HuraProgressBar1 = New Computer_Helper.HuraProgressBar()
        Me.HuraButton2 = New Computer_Helper.HuraButton()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraForm1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraProgressBar1)
        Me.HuraForm1.Controls.Add(Me.HuraButton2)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Controls.Add(Me.TrackBar1)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(139, 247)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Volume"
        '
        'HuraProgressBar1
        '
        Me.HuraProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.HuraProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraProgressBar1.Location = New System.Drawing.Point(22, 228)
        Me.HuraProgressBar1.Maximum = 100
        Me.HuraProgressBar1.Name = "HuraProgressBar1"
        Me.HuraProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HuraProgressBar1.Size = New System.Drawing.Size(95, 11)
        Me.HuraProgressBar1.TabIndex = 4
        Me.HuraProgressBar1.Text = "HuraProgressBar1"
        Me.HuraProgressBar1.TwoColour = True
        Me.HuraProgressBar1.Value = 0
        '
        'HuraButton2
        '
        Me.HuraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraButton2.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton2.BaseColour = System.Drawing.Color.White
        Me.HuraButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HuraButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton2.ForeColor = System.Drawing.Color.Black
        Me.HuraButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Location = New System.Drawing.Point(84, 3)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton2.TabIndex = 3
        Me.HuraButton2.Text = "-"
        '
        'HuraButton1
        '
        Me.HuraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.ForeColor = System.Drawing.Color.Black
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(113, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton1.TabIndex = 2
        Me.HuraButton1.Text = "X"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(47, 41)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 181)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "100%"
        '
        'Volumecontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(139, 247)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Volumecontrol"
        Me.Text = "Volume Master"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As Computer_Helper.HuraForm
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents HuraButton2 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton1 As Computer_Helper.HuraButton
    Friend WithEvents HuraProgressBar1 As Computer_Helper.HuraProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
