Public Class dvd1
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        If HuraCheckBox1.Checked = False Then
            mciSendString("set cdaudio door open", 0, 0, 0)
            HuraCheckBox1.Checked = True
        Else
            If HuraCheckBox1.Checked = True Then
                mciSendString("set cdaudio door closed", 0, 0, 0)
                HuraCheckBox1.Checked = False
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If HuraCheckBox1.Checked = True Then
            HuraButton3.Text = ("Close DVD drive")
        Else

            If HuraCheckBox1.Checked = False Then
                HuraButton3.Text = ("Open DVD drive")
            End If
        End If
    End Sub
End Class