Imports System.Net
Public Class Form1
    Public WithEvents download As New WebClient
    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If System.Environment.Is64BitOperatingSystem = True Then
            HuraTextBox2.Text = ("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update\Computerhelperupdate.exe")
        Else
            If System.Environment.Is64BitOperatingSystem = False Then
                HuraTextBox2.Text = ("C:\Program Files\ModJokerGaming\Computer Helper\Update\Computerhelperupdate.exe")
            End If
        End If
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Application.Exit()
    End Sub

    Private Sub HuraProgressBar1_Click(sender As Object, e As EventArgs) Handles HuraProgressBar1.Click

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        HuraProgressBar1.Value = e.ProgressPercentage
        Label1.Text = HuraProgressBar1.Value & "%"
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Try
            download.DownloadFileAsync(New Uri(HuraTextBox1.Text), HuraTextBox2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If HuraProgressBar1.Value = 100 Then
            Timer2.Enabled = True
            Timer2.Start()
            If System.Environment.Is64BitOperatingSystem = True Then
                System.Diagnostics.Process.Start("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update\Computerhelperupdate.exe")
            Else
                If System.Environment.Is64BitOperatingSystem = False Then
                    System.Diagnostics.Process.Start("C:\Program Files\ModJokerGaming\Computer Helper\Update\Computerhelperupdate.exe")
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        HuraProgressBar2.Increment(5)
        If HuraProgressBar2.Value = 100 Then
            Me.Close()
            If System.Environment.Is64BitOperatingSystem = True Then
                System.Diagnostics.Process.Start("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Computer Helper.exe")
            Else
                If System.Environment.Is64BitOperatingSystem = False Then
                    System.Diagnostics.Process.Start("C:\Program Files\ModJokerGaming\Computer Helper\Computer Helper.exe")
                End If
            End If
        End If
    End Sub
End Class
