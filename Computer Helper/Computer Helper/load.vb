Public Class load

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraProgressBar1.Increment(1)
        If HuraProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub load_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Settings.username = Environment.UserName
        TopMost = True
        TopMost = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class