Public Class f1

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton7_Click(sender As Object, e As EventArgs) Handles HuraButton7.Click
        System.Diagnostics.Process.Start("Shutdown", "-a")
        System.Diagnostics.Process.Start("Shutdown", "-a")
        System.Diagnostics.Process.Start("Shutdown", "-a")
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("Shutdown", "-l -t 120")
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("Shutdown", "-r -t 120")
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("Shutdown", "-s -t 120")
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If HuraRadioButton1.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        If HuraRadioButton2.Checked = True Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
        If HuraRadioButton3.Checked = True Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub HuraRadioButton1_CheckedChanged(sender As Object) Handles HuraRadioButton1.CheckedChanged

    End Sub
End Class