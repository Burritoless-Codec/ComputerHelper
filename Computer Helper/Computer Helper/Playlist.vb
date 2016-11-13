Public Class Playlist

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        ShowProcess()
    End Sub
    Private Sub ShowProcess()
        ListBox1.Items.Clear()
        Dim p As Process
        For Each p In Process.GetProcesses
            ListBox1.Items.Add(p.ProcessName)
        Next
    End Sub
    Private Sub EndProcess()
        Dim p As Process
        For Each p In Process.GetProcesses
            If p.ProcessName = ListBox1.SelectedItem Then
                p.Kill()
            End If
        Next
        ShowProcess()
        MsgBox("Killed Process!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        EndProcess()
        ShowProcess()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShowProcess()
    End Sub

    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowProcess()
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Me.Close()
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class