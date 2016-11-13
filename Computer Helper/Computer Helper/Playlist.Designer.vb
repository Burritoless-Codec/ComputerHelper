<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Playlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Playlist))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1 = New Computer_Helper.HuraForm()
        Me.HuraButton2 = New Computer_Helper.HuraButton()
        Me.HuraButton1 = New Computer_Helper.HuraButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.HuraButton3 = New Computer_Helper.HuraButton()
        Me.HuraButton4 = New Computer_Helper.HuraButton()
        Me.HuraForm1.SuspendLayout
        Me.SuspendLayout
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 10000
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraForm1.ColorScheme = Computer_Helper.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraButton3)
        Me.HuraForm1.Controls.Add(Me.HuraButton4)
        Me.HuraForm1.Controls.Add(Me.HuraButton2)
        Me.HuraForm1.Controls.Add(Me.HuraButton1)
        Me.HuraForm1.Controls.Add(Me.ListBox1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(478, 585)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Task Manager"
        '
        'HuraButton2
        '
        Me.HuraButton2.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton2.BaseColour = System.Drawing.Color.White
        Me.HuraButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.HuraButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.HuraButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton2.Location = New System.Drawing.Point(323, 547)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.HuraButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton2.Size = New System.Drawing.Size(143, 30)
        Me.HuraButton2.TabIndex = 2
        Me.HuraButton2.Text = "End Task"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(12, 547)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(143, 30)
        Me.HuraButton1.TabIndex = 1
        Me.HuraButton1.Text = "Refresh"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(454, 514)
        Me.ListBox1.TabIndex = 0
        '
        'HuraButton3
        '
        Me.HuraButton3.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton3.BaseColour = System.Drawing.Color.White
        Me.HuraButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.HuraButton3.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold)
        Me.HuraButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.HuraButton3.ForeColor = System.Drawing.Color.Black
        Me.HuraButton3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton3.Location = New System.Drawing.Point(423, 3)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.HuraButton3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton3.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton3.TabIndex = 4
        Me.HuraButton3.Text = "-"
        '
        'HuraButton4
        '
        Me.HuraButton4.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton4.BaseColour = System.Drawing.Color.White
        Me.HuraButton4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(220,Byte),Integer))
        Me.HuraButton4.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold)
        Me.HuraButton4.FontColour = System.Drawing.Color.FromArgb(CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer), CType(CType(150,Byte),Integer))
        Me.HuraButton4.ForeColor = System.Drawing.Color.Black
        Me.HuraButton4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton4.Location = New System.Drawing.Point(452, 3)
        Me.HuraButton4.Name = "HuraButton4"
        Me.HuraButton4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.HuraButton4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.HuraButton4.Size = New System.Drawing.Size(23, 20)
        Me.HuraButton4.TabIndex = 3
        Me.HuraButton4.Text = "X"
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 585)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Playlist"
        Me.Text = "Task Manager"
        Me.HuraForm1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents HuraForm1 As Computer_Helper.HuraForm
    Friend WithEvents HuraButton2 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton1 As Computer_Helper.HuraButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HuraButton3 As Computer_Helper.HuraButton
    Friend WithEvents HuraButton4 As Computer_Helper.HuraButton
End Class
