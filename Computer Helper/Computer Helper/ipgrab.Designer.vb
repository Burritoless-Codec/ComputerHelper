<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ipgrab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ipgrab))
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraTextBox2 = New Computer_Helper.HuraTextBox()
        Me.HuraTextBox1 = New Computer_Helper.HuraTextBox()
        Me.HuraButton5 = New Computer_Helper.HuraButton()
        Me.HuraButton4 = New Computer_Helper.HuraButton()
        Me.HuraButton3 = New Computer_Helper.HuraButton()
        Me.HuraButton2 = New Computer_Helper.HuraButton()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.Label2)
        Me.HuraForm1.Controls.Add(Me.Label1)
        Me.HuraForm1.Controls.Add(Me.HuraTextBox2)
        Me.HuraForm1.Controls.Add(Me.HuraTextBox1)
        Me.HuraForm1.Controls.Add(Me.HuraButton5)
        Me.HuraForm1.Controls.Add(Me.HuraButton4)
        Me.HuraForm1.Controls.Add(Me.HuraButton3)
        Me.HuraForm1.Controls.Add(Me.HuraButton2)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Controls.Add(Me.TextBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(255, 164)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "IP Grab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ip address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Website"
        '
        'HuraTextBox2
        '
        Me.HuraTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox2.Location = New System.Drawing.Point(12, 96)
        Me.HuraTextBox2.MaxLength = 32767
        Me.HuraTextBox2.Multiline = False
        Me.HuraTextBox2.Name = "HuraTextBox2"
        Me.HuraTextBox2.ReadOnly = True
        Me.HuraTextBox2.Size = New System.Drawing.Size(237, 29)
        Me.HuraTextBox2.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox2.TabIndex = 8
        Me.HuraTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox2.UseSystemPasswordChar = False
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox1.Location = New System.Drawing.Point(12, 44)
        Me.HuraTextBox1.MaxLength = 32767
        Me.HuraTextBox1.Multiline = False
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.ReadOnly = False
        Me.HuraTextBox1.Size = New System.Drawing.Size(237, 29)
        Me.HuraTextBox1.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox1.TabIndex = 7
        Me.HuraTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox1.UseSystemPasswordChar = False
        '
        'HuraButton5
        '
        Me.HuraButton5.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton5.BaseColour = System.Drawing.Color.White
        Me.HuraButton5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton5.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton5.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Location = New System.Drawing.Point(12, 131)
        Me.HuraButton5.Name = "HuraButton5"
        Me.HuraButton5.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton5.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton5.TabIndex = 6
        Me.HuraButton5.Text = "Copy IP"
        '
        'HuraButton4
        '
        Me.HuraButton4.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton4.BaseColour = System.Drawing.Color.White
        Me.HuraButton4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton4.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Location = New System.Drawing.Point(93, 131)
        Me.HuraButton4.Name = "HuraButton4"
        Me.HuraButton4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton4.TabIndex = 5
        Me.HuraButton4.Text = "Clear"
        '
        'HuraButton3
        '
        Me.HuraButton3.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton3.BaseColour = System.Drawing.Color.White
        Me.HuraButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Location = New System.Drawing.Point(174, 131)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton3.TabIndex = 4
        Me.HuraButton3.Text = "Grab"
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
        Me.HuraButton2.Location = New System.Drawing.Point(200, 3)
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
        Me.HuraButton1.Location = New System.Drawing.Point(229, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton1.TabIndex = 2
        Me.HuraButton1.Text = "X"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 24)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'ipgrab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 164)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ipgrab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP Grab"
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HuraForm1 As Computer_Helper.HuraForm
    Friend WithEvents HuraButton2 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton1 As Computer_Helper.HuraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HuraTextBox2 As Computer_Helper.HuraTextBox
    Friend WithEvents HuraTextBox1 As Computer_Helper.HuraTextBox
    Friend WithEvents HuraButton5 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton4 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton3 As Computer_Helper.HuraButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
