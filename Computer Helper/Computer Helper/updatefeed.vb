Imports System.Net

Public Class updatefeed
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckForUpdates()
    End Sub
    Public Sub CheckForUpdates()
        Dim ws As New WebClient
        Dim newestversion = ws.DownloadString("http://modjokergaming.tk/ComputerHelper/Version/")
        Dim request As HttpWebRequest = WebRequest.Create("http://modjokergaming.tk/Computer%20Helper/UpdateFeed/")
        Dim response As HttpWebResponse = request.GetResponse()
        Dim sr As IO.StreamReader = New IO.StreamReader(response.GetResponseStream())
        RichTextBox1.Text = newestversion
    End Sub

    Private Sub updatefeed_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForUpdates()
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub
End Class