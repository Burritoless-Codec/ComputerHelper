Public Class pdfviewer

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "PDF Files (*.pdf)|*.pdf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                AxAcroPDF1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "PDF Files (*.pdf)|*.pdf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                AxAcroPDF1.LoadFile(dlg.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class