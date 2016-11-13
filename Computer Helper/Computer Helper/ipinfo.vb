Imports System.Net
Imports System.IO
Public Class ipinfo

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        HuraTextBox1.Text = Dns.GetHostEntry(Dns.GetHostName).AddressList(0).ToString
    End Sub
    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Dim ws As New WebClient
        HuraTextBox2.Text = ws.DownloadString("http://bot.whatismyipaddress.com")
    End Sub
End Class