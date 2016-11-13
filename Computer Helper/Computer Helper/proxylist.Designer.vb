<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proxylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proxylist))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.HuraButton8 = New Computer_Helper.HuraButton()
        Me.HuraButton7 = New Computer_Helper.HuraButton()
        Me.HuraButton6 = New Computer_Helper.HuraButton()
        Me.HuraButton5 = New Computer_Helper.HuraButton()
        Me.HuraTextBox3 = New Computer_Helper.HuraTextBox()
        Me.HuraTextBox2 = New Computer_Helper.HuraTextBox()
        Me.HuraButton3 = New Computer_Helper.HuraButton()
        Me.HuraTextBox1 = New Computer_Helper.HuraTextBox()
        Me.HuraButton2 = New Computer_Helper.HuraButton()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.HuraTextBox5 = New Computer_Helper.HuraTextBox()
        Me.HuraTextBox4 = New Computer_Helper.HuraTextBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Location = New System.Drawing.Point(12, 27)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(258, 248)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP Address"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Port"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Country"
        Me.ColumnHeader3.Width = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IP Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Country:"
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(521, 286)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Proxy Keep"
        '
        'HuraButton8
        '
        Me.HuraButton8.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton8.BaseColour = System.Drawing.Color.White
        Me.HuraButton8.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton8.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton8.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton8.Location = New System.Drawing.Point(393, 244)
        Me.HuraButton8.Name = "HuraButton8"
        Me.HuraButton8.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton8.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton8.Size = New System.Drawing.Size(98, 31)
        Me.HuraButton8.TabIndex = 18
        Me.HuraButton8.Text = "Load"
        '
        'HuraButton7
        '
        Me.HuraButton7.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton7.BaseColour = System.Drawing.Color.White
        Me.HuraButton7.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton7.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton7.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton7.Location = New System.Drawing.Point(289, 244)
        Me.HuraButton7.Name = "HuraButton7"
        Me.HuraButton7.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton7.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton7.Size = New System.Drawing.Size(98, 31)
        Me.HuraButton7.TabIndex = 17
        Me.HuraButton7.Text = "Save"
        '
        'HuraButton6
        '
        Me.HuraButton6.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton6.BaseColour = System.Drawing.Color.White
        Me.HuraButton6.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton6.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton6.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton6.Location = New System.Drawing.Point(276, 207)
        Me.HuraButton6.Name = "HuraButton6"
        Me.HuraButton6.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton6.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton6.Size = New System.Drawing.Size(233, 31)
        Me.HuraButton6.TabIndex = 16
        Me.HuraButton6.Text = "Remove All"
        '
        'HuraButton5
        '
        Me.HuraButton5.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton5.BaseColour = System.Drawing.Color.White
        Me.HuraButton5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton5.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton5.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Location = New System.Drawing.Point(276, 170)
        Me.HuraButton5.Name = "HuraButton5"
        Me.HuraButton5.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton5.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Size = New System.Drawing.Size(233, 31)
        Me.HuraButton5.TabIndex = 15
        Me.HuraButton5.Text = "Remove Selected"
        '
        'HuraTextBox3
        '
        Me.HuraTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox3.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox3.Location = New System.Drawing.Point(348, 99)
        Me.HuraTextBox3.MaxLength = 32767
        Me.HuraTextBox3.Multiline = False
        Me.HuraTextBox3.Name = "HuraTextBox3"
        Me.HuraTextBox3.ReadOnly = False
        Me.HuraTextBox3.Size = New System.Drawing.Size(161, 29)
        Me.HuraTextBox3.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox3.TabIndex = 8
        Me.HuraTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox3.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox3.UseSystemPasswordChar = False
        '
        'HuraTextBox2
        '
        Me.HuraTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox2.Location = New System.Drawing.Point(348, 64)
        Me.HuraTextBox2.MaxLength = 32767
        Me.HuraTextBox2.Multiline = False
        Me.HuraTextBox2.Name = "HuraTextBox2"
        Me.HuraTextBox2.ReadOnly = False
        Me.HuraTextBox2.Size = New System.Drawing.Size(161, 29)
        Me.HuraTextBox2.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox2.TabIndex = 7
        Me.HuraTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox2.UseSystemPasswordChar = False
        '
        'HuraButton3
        '
        Me.HuraButton3.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton3.BaseColour = System.Drawing.Color.White
        Me.HuraButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Location = New System.Drawing.Point(434, 134)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Size = New System.Drawing.Size(75, 30)
        Me.HuraButton3.TabIndex = 6
        Me.HuraButton3.Text = "Add"
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox1.Location = New System.Drawing.Point(348, 29)
        Me.HuraTextBox1.MaxLength = 32767
        Me.HuraTextBox1.Multiline = False
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.ReadOnly = False
        Me.HuraTextBox1.Size = New System.Drawing.Size(161, 29)
        Me.HuraTextBox1.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox1.TabIndex = 5
        Me.HuraTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox1.UseSystemPasswordChar = False
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
        Me.HuraButton2.Location = New System.Drawing.Point(466, 3)
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
        Me.HuraButton1.Location = New System.Drawing.Point(495, 3)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton1.TabIndex = 2
        Me.HuraButton1.Text = "X"
        '
        'HuraTextBox5
        '
        Me.HuraTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox5.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox5.Location = New System.Drawing.Point(157, 234)
        Me.HuraTextBox5.MaxLength = 32767
        Me.HuraTextBox5.Multiline = False
        Me.HuraTextBox5.Name = "HuraTextBox5"
        Me.HuraTextBox5.ReadOnly = False
        Me.HuraTextBox5.Size = New System.Drawing.Size(75, 29)
        Me.HuraTextBox5.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox5.TabIndex = 14
        Me.HuraTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox5.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox5.UseSystemPasswordChar = False
        Me.HuraTextBox5.Visible = False
        '
        'HuraTextBox4
        '
        Me.HuraTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox4.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox4.Location = New System.Drawing.Point(157, 224)
        Me.HuraTextBox4.MaxLength = 32767
        Me.HuraTextBox4.Multiline = False
        Me.HuraTextBox4.Name = "HuraTextBox4"
        Me.HuraTextBox4.ReadOnly = False
        Me.HuraTextBox4.Size = New System.Drawing.Size(75, 29)
        Me.HuraTextBox4.Style = Computer_Helper.HuraTextBox.Styles.Normal
        Me.HuraTextBox4.TabIndex = 13
        Me.HuraTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HuraTextBox4.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox4.UseSystemPasswordChar = False
        Me.HuraTextBox4.Visible = False
        '
        'proxylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 286)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "proxylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxy List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraButton2 As HuraButton
    Friend WithEvents HuraButton1 As HuraButton
    Friend WithEvents HuraButton3 As HuraButton
    Friend WithEvents HuraTextBox1 As HuraTextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents HuraTextBox3 As HuraTextBox
    Friend WithEvents HuraTextBox2 As HuraTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HuraButton4 As HuraButton
    Friend WithEvents HuraTextBox5 As HuraTextBox
    Friend WithEvents HuraTextBox4 As HuraTextBox
    Friend WithEvents HuraButton5 As HuraButton
    Friend WithEvents HuraButton6 As HuraButton
    Friend WithEvents HuraButton7 As HuraButton
    Friend WithEvents HuraButton8 As HuraButton
    Friend WithEvents HuraGroupBox1 As HuraGroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HuraTextBox6 As HuraTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HuraTextBox7 As HuraTextBox
    Friend WithEvents HuraTextBox8 As HuraTextBox
    Friend WithEvents HuraButton9 As HuraButton
End Class
