Public Class Tempcleaner

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Diagnostics.Process.Start("temp.exe")
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class