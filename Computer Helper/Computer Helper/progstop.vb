Imports System.IO
Public Class progstop
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub
    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Dim FileToDelete As String
        FileToDelete = ("C:/Users/" + My.Settings.username + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/progstart.bat")
        If System.IO.File.Exists(FileToDelete) = True Then
            System.IO.File.Delete(FileToDelete)
        End If
        Dim ws As System.IO.StreamWriter
        ws = My.Computer.FileSystem.OpenTextFileWriter("C:/Users/" + My.Settings.username + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/progstart.bat", True)
        If HuraCheckBox1.Checked = True Then
            ws.WriteLine()
        End If
        If HuraCheckBox2.Checked = True Then
            ws.WriteLine("taskkill /F /IM SkyDrive.exe")
        End If
        If HuraCheckBox4.Checked = True Then
            ws.WriteLine("taskkill /F /IM PnkBstrA.exe")
        End If
        If HuraCheckBox3.Checked = True Then
            ws.WriteLine("taskkill /F /IM TabTip.exe")
            ws.WriteLine("taskkill /F /IM TabTip32.exe")
        End If
        ws.WriteLine("echo Los test")
        ws.Close()
    End Sub
    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Dim FileToDelete As String
        FileToDelete = ("C:/Users/" + My.Settings.username + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/progstart.bat")
        System.IO.File.Delete(FileToDelete)
    End Sub
    Private Sub progstop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim FileToDelete As String
        FileToDelete = ("C:/Users/" + My.Settings.username + "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/progstart.bat")
        If System.IO.File.Exists(FileToDelete) = True Then
            HuraButton4.Enabled = True
        End If
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        progsh.Show()
    End Sub

    Private Sub HuraCheckBox2_CheckedChanged(sender As Object) Handles HuraCheckBox2.CheckedChanged

    End Sub

    Private Sub HuraCheckBox4_CheckedChanged(sender As Object) Handles HuraCheckBox4.CheckedChanged

    End Sub
End Class