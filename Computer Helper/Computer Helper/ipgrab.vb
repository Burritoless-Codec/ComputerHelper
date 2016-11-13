Imports System.Net
Imports System.IO
Imports System
Public Class ipgrab

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        TextBox1.Text = HuraTextBox2.Text
        TextBox1.Copy()
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        HuraTextBox1.Text = ""
        HuraTextBox2.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        If HuraTextBox1.Text = "" Then
            MessageBox.Show("Please enter a website.")
            HuraTextBox2.Text = ""
            TextBox1.Clear()
        Else
            Dim Hostname As IPHostEntry = Dns.GetHostEntry(HuraTextBox1.Text)
            Dim ip As IPAddress() = Hostname.AddressList
            HuraTextBox2.Text = ip(0).ToString
        End If
    End Sub
End Class