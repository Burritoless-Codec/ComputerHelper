Imports System.Security.AccessControl
Imports System.IO
Public Class fllocker
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Dim text1 As String = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        Shell("cmd /c" & "ren " & HuraTextBox1.Text & " " & HuraTextBox2.Text & text1)
        Shell("cmd /c" & "attrib +s +h " & HuraTextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
        Shell("cmd /c" & "attrib +s +h " & HuraTextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Dim text1 As String = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        Shell("cmd /c" & "attrib -s -h " & HuraTextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}" & " /S /D")
        Shell("cmd /c" & "attrib -s -h " & HuraTextBox1.Text & ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\*.*" & " /S /D")
        System.Threading.Thread.Sleep(1000)
        Shell("cmd /c" & "ren " & HuraTextBox1.Text & text1 & " " & HuraTextBox2.Text)
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
    End Sub
End Class