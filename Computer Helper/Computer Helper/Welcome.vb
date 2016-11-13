Public Class Welcome

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraProgressBar1.Increment(1)
        If HuraProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class