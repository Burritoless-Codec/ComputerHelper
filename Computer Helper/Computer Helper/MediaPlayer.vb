Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.IO


Public Class MediaPlayer

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        lbNama.Items.Add(OpenFileDialog1.SafeFileName)
        lb.Items.Add(AxWindowsMediaPlayer1.URL)
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        lb.Items.Remove(lb.SelectedItem)
        lbNama.Items.Remove(lbNama.SelectedItem)
    End Sub

    Private Sub lbNama_DoubleClick(sender As Object, e As EventArgs) Handles lbNama.DoubleClick
        AxWindowsMediaPlayer1.URL = lbNama.SelectedItem
    End Sub

    Private Sub lbNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbNama.SelectedIndexChanged
        lb.SelectedIndex = lbNama.SelectedIndex
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub
End Class