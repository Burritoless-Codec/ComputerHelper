Imports System.Net
Imports System.IO
Public Class Form1
    Public WithEvents download As New WebClient
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraForm1.Text = ("| " + Application.ProductName + " | Made By: MJGC-Jonathan | Version: " + Application.ProductVersion + " | " + TimeOfDay + " | ")
    End Sub
    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        f1.Show()
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Reset.Show()
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        Form12.Show()
    End Sub

    Private Sub HuraButton6_Click(sender As Object, e As EventArgs) Handles HuraButton6.Click
        Calls.Show()
    End Sub

    Private Sub HuraButton7_Click(sender As Object, e As EventArgs) Handles HuraButton7.Click
        Form2.Show()
    End Sub

    Private Sub HuraButton8_Click(sender As Object, e As EventArgs) Handles HuraButton8.Click
        CheckForUpdates()
    End Sub
    Public Sub CheckForUpdates()
        Dim ws As New WebClient
        'HuraTextBox3.Text = ws.DownloadString("http://modjokergaming.tk/ComputerHelper/Version/")
        Dim newestversion = ws.DownloadString("http://modjokergaming.tk/ComputerHelper/Version/")
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            HuraAlertBox1.Visible = True
            HuraAlertBox1.Text = ("Sorry an update has not been found! | Current Version: " + currentversion + " | Latest Version:  " + newestversion + " |")
            HuraRadioButton1.Visible = False
            HuraRadioButton2.Visible = False
            RichTextBox4.Visible = False
            HuraAlertBox2.Visible = False
            HuraRadioButton2.Checked = True
        Else
            HuraRadioButton2.Checked = True
            HuraRadioButton2.Checked = True
            HuraRadioButton2.Checked = True
            HuraRadioButton2.Checked = True
            RichTextBox4.Visible = True
            HuraAlertBox2.Visible = True
            HuraAlertBox2.Text = ("Great a New Version has been found! | Time Found: " + TimeOfDay + "| Latest Version:  " + newestversion + " |")
            HuraRadioButton1.Visible = True
            HuraRadioButton2.Visible = True
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If HuraRadioButton1.Checked = True Then
            HuraButton9.Visible = True
        Else
            If HuraRadioButton2.Checked = True Then
                HuraButton9.Visible = False
            End If
        End If
    End Sub

    Private Sub HuraButton9_Click(sender As Object, e As EventArgs) Handles HuraButton9.Click
        Process.Start("Updater.exe")
        Close()
    End Sub

    Private Sub HuraButton10_Click(sender As Object, e As EventArgs) Handles HuraButton10.Click
        Tempcleaner.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("https://www.youtube.com/user/jblackops99")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Process.Start("https://www.twitter.com/@GTAVTWOPOINTo")
    End Sub

    Private Sub HuraButton11_Click(sender As Object, e As EventArgs) Handles HuraButton11.Click
        ToolS.Show()
    End Sub

    Private Sub HuraButton12_Click(sender As Object, e As EventArgs) Handles HuraButton12.Click
        Systemspecks.Show()
    End Sub

    Private Sub HuraButton13_Click(sender As Object, e As EventArgs) Handles HuraButton13.Click
        MediaPlayer.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        HuraForm1.Text = ("| " + Application.ProductName + " | Made By: MJGC-Jonathan | Version: " + Application.ProductVersion + " | " + TimeOfDay + " | No Internet Please connect for updates...")
    End Sub

    Private Sub HuraButton14_Click(sender As Object, e As EventArgs) Handles HuraButton14.Click
        Playlist.Show()
    End Sub

    Private Sub HuraButton15_Click(sender As Object, e As EventArgs) Handles HuraButton15.Click
        pdfviewer.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Environment.Is64BitOperatingSystem = True Then
            If Directory.Exists("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update") = True Then
                HuraButton8.Enabled = True
            Else
                If Directory.Exists("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update") = False Then
                    HuraButton26.Enabled = True
                    HuraButton8.Enabled = False
                End If
            End If
        Else
            If Directory.Exists("C:\Program Files\ModJokerGaming\Computer Helper\Update") = True Then
                HuraButton8.Enabled = True
            Else
                If Directory.Exists("C:\Program Files\ModJokerGaming\Computer Helper\Update") = False Then
                    HuraButton26.Enabled = True
                    HuraButton8.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub HuraButton16_Click(sender As Object, e As EventArgs) Handles HuraButton16.Click
        mal.Show()
    End Sub

    Private Sub HuraButton17_Click(sender As Object, e As EventArgs) Handles HuraButton17.Click
        textedit.Show()
    End Sub

    Private Sub HuraButton18_Click(sender As Object, e As EventArgs) Handles HuraButton18.Click
        updatefeed.Show()
    End Sub

    Private Sub HuraButton19_Click(sender As Object, e As EventArgs) Handles HuraButton19.Click
        proxylist.Show()
    End Sub

    Private Sub HuraButton20_Click(sender As Object, e As EventArgs) Handles HuraButton20.Click
        Textencry.Show()
    End Sub

    Private Sub HuraButton22_Click(sender As Object, e As EventArgs) Handles HuraButton22.Click
        imgconver.Show()
    End Sub

    Private Sub HuraButton23_Click(sender As Object, e As EventArgs) Handles HuraButton23.Click
        pdfedit.Show()
    End Sub

    Private Sub HuraButton24_Click(sender As Object, e As EventArgs) Handles HuraButton24.Click
        ipinfo.Show()
    End Sub

    Private Sub HuraButton25_Click(sender As Object, e As EventArgs) Handles HuraButton25.Click
        ipgrab.Show()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If Environment.Is64BitOperatingSystem = True Then
            If Directory.Exists("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update") = True Then
                HuraButton8.Enabled = True
                HuraButton26.Visible = False
            Else
                If Directory.Exists("C:\Program Files (x86)\ModJokerGaming\Computer Helper\Update") = False Then
                    HuraButton26.Enabled = True
                    HuraButton8.Enabled = False
                End If
            End If
        Else
            If Directory.Exists("C:\Program Files\ModJokerGaming\Computer Helper\Update") = True Then
                HuraButton8.Enabled = True
                HuraButton26.Visible = False
            Else
                If Directory.Exists("C:\Program Files\ModJokerGaming\Computer Helper\Update") = False Then
                    HuraButton26.Enabled = True
                    HuraButton8.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub HuraButton26_Click(sender As Object, e As EventArgs) Handles HuraButton26.Click
        If Environment.Is64BitOperatingSystem = True Then
            Directory.CreateDirectory("C:\Program Files (x86)\ModJokergaming\Computer Helper\Update")
        Else
            Directory.CreateDirectory("C:\Program Files\ModJokergaming\Computer Helper\Update")
        End If
    End Sub

    Private Sub HuraButton28_Click(sender As Object, e As EventArgs) Handles HuraButton28.Click
        dvd1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        settings1.Show()
    End Sub

    Private Sub HuraButton29_Click(sender As Object, e As EventArgs) Handles HuraButton29.Click
        Volumecontrol.Show()
    End Sub

    Private Sub HuraButton30_Click(sender As Object, e As EventArgs) Handles HuraButton30.Click
        ss.Show()
    End Sub

    Private Sub HuraButton31_Click(sender As Object, e As EventArgs) Handles HuraButton31.Click
        progstop.Show()
    End Sub
End Class