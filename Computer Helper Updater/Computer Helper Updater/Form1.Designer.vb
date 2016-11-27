<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1 = New Computer_Helper_Updater.HuraForm()
        Me.HuraProgressBar2 = New Computer_Helper_Updater.HuraProgressBar()
        Me.HuraButton2 = New Computer_Helper_Updater.HuraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraProgressBar1 = New Computer_Helper_Updater.HuraProgressBar()
        Me.HuraTextBox2 = New Computer_Helper_Updater.HuraTextBox()
        Me.HuraTextBox1 = New Computer_Helper_Updater.HuraTextBox()
        Me.HuraButton1 = New Computer_Helper_Updater.HuraButton()
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper_Updater.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraProgressBar2)
        Me.HuraForm1.Controls.Add(Me.HuraButton2)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.HuraProgressBar1)
        Me.HuraForm1.Controls.Add(Me.HuraTextBox2)
        Me.HuraForm1.Controls.Add(Me.HuraTextBox1)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(497, 136)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Computer Helper Updater"
        '
        'HuraProgressBar2
        '
        Me.HuraProgressBar2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraProgressBar2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.HuraProgressBar2.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraProgressBar2.Location = New System.Drawing.Point(12, 101)
        Me.HuraProgressBar2.Maximum = 100
        Me.HuraProgressBar2.Name = "HuraProgressBar2"
        Me.HuraProgressBar2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraProgressBar2.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HuraProgressBar2.Size = New System.Drawing.Size(181, 23)
        Me.HuraProgressBar2.TabIndex = 6
        Me.HuraProgressBar2.Text = "HuraProgressBar2"
        Me.HuraProgressBar2.TwoColour = True
        Me.HuraProgressBar2.Value = 0
        Me.HuraProgressBar2.Visible = False
        '
        'HuraButton2
        '
        Me.HuraButton2.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton2.BaseColour = System.Drawing.Color.White
        Me.HuraButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Location = New System.Drawing.Point(330, 98)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Size = New System.Drawing.Size(160, 30)
        Me.HuraButton2.TabIndex = 5
        Me.HuraButton2.Text = "Download and install update"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(199, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 4
        '
        'HuraProgressBar1
        '
        Me.HuraProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.HuraProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.HuraProgressBar1.Location = New System.Drawing.Point(12, 101)
        Me.HuraProgressBar1.Maximum = 100
        Me.HuraProgressBar1.Name = "HuraProgressBar1"
        Me.HuraProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HuraProgressBar1.Size = New System.Drawing.Size(181, 23)
        Me.HuraProgressBar1.TabIndex = 3
        Me.HuraProgressBar1.Text = "HuraProgressBar1"
        Me.HuraProgressBar1.TwoColour = True
        Me.HuraProgressBar1.Value = 0
        '
        'HuraTextBox2
        '
        Me.HuraTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox2.Location = New System.Drawing.Point(12, 63)
        Me.HuraTextBox2.MaxLength = 32767
        Me.HuraTextBox2.Multiline = False
        Me.HuraTextBox2.Name = "HuraTextBox2"
        Me.HuraTextBox2.ReadOnly = True
        Me.HuraTextBox2.Size = New System.Drawing.Size(478, 29)
        Me.HuraTextBox2.Style = Computer_Helper_Updater.HuraTextBox.Styles.Normal
        Me.HuraTextBox2.TabIndex = 2
        Me.HuraTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox2.UseSystemPasswordChar = False
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox1.Location = New System.Drawing.Point(12, 28)
        Me.HuraTextBox1.MaxLength = 32767
        Me.HuraTextBox1.Multiline = False
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.ReadOnly = True
        Me.HuraTextBox1.Size = New System.Drawing.Size(478, 29)
        Me.HuraTextBox1.Style = Computer_Helper_Updater.HuraTextBox.Styles.Normal
        Me.HuraTextBox1.TabIndex = 1
        Me.HuraTextBox1.Text = "http://modjokergaming.tk/ComputerHelper/NewVersion/"
        Me.HuraTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox1.UseSystemPasswordChar = False
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(473, 4)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(21, 18)
        Me.HuraButton1.TabIndex = 0
        Me.HuraButton1.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 136)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Computer Helper Updater"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As Computer_Helper_Updater.HuraForm
    Friend WithEvents HuraTextBox2 As Computer_Helper_Updater.HuraTextBox
    Friend WithEvents HuraTextBox1 As Computer_Helper_Updater.HuraTextBox
    Friend WithEvents HuraButton1 As Computer_Helper_Updater.HuraButton
    Friend WithEvents HuraProgressBar1 As Computer_Helper_Updater.HuraProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HuraButton2 As Computer_Helper_Updater.HuraButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents HuraProgressBar2 As Computer_Helper_Updater.HuraProgressBar

End Class
