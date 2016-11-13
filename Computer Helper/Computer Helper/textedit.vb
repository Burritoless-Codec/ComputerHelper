Imports System.IO
Public Class textedit
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim x As New TabPage
        Dim p As New RichTextBox
        p.BorderStyle = BorderStyle.None
        x.Controls.Add(p)
        p.Dock = DockStyle.Fill
        HuraTabControl1.TabPages.Add(x)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ofd = New OpenFileDialog
        ofd.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim sr As New System.IO.StreamReader(ofd.FileName)
            ' Me.RichTextBox1.Text = sr.ReadToEnd
            sr.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim sfd = New SaveFileDialog
        sfd.Filter = "Text (*.txt)|*.txt|All Files (*.*)|*.*"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(sfd.FileName)
            'sw.Write(Me.RichTextBox1.Text)
            sw.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        ' RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        ' RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        ' RichTextBox1.SelectAll()
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        ' RichTextBox1.DeselectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim fd = New FontDialog()
        fd.ShowColor = True
        fd.ShowEffects = True
        'If fd.ShowDialog() = System.Windows.Forms.DialogResult.OK And Not [String].IsNullOrEmpty('Me.RichTextBox1.Text) Then
        '   Me.RichTextBox1.SelectionFont = fd.Font
        '   Me.RichTextBox1.SelectionColor = fd.Color
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ' RichTextBox1.Undo()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        ' RichTextBox1.Redo()
    End Sub
End Class