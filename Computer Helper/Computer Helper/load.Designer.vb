<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class load
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(load))
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.HuraProgressBar1 = New Computer_Helper.HuraProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Controls.Add(Me.HuraProgressBar1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(350, 200)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Load"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.Label1.Location = New System.Drawing.Point(49, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.ForeColor = System.Drawing.Color.Black
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(324, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton1.TabIndex = 1
        Me.HuraButton1.Text = "X"
        '
        'HuraProgressBar1
        '
        Me.HuraProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.HuraProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraProgressBar1.Location = New System.Drawing.Point(12, 174)
        Me.HuraProgressBar1.Maximum = 100
        Me.HuraProgressBar1.Name = "HuraProgressBar1"
        Me.HuraProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HuraProgressBar1.Size = New System.Drawing.Size(326, 23)
        Me.HuraProgressBar1.TabIndex = 0
        Me.HuraProgressBar1.Text = "HuraProgressBar1"
        Me.HuraProgressBar1.TwoColour = True
        Me.HuraProgressBar1.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 200)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "load"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As Computer_Helper.HuraForm
    Friend WithEvents HuraProgressBar1 As Computer_Helper.HuraProgressBar
    Friend WithEvents HuraButton1 As Computer_Helper.HuraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
