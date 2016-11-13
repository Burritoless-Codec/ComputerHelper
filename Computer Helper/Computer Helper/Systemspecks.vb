Public Class Systemspecks

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Me.Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraProgressBar1.Increment(1)
        Timer1.Start()
        If HuraProgressBar1.Value = 100 Then
            Timer1.Stop()
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        HuraTextBox1.Text = ("OS Full Name: " + My.Computer.Info.OSFullName)
        HuraTextBox2.Text = ("OS Platform: " + My.Computer.Info.OSPlatform)
        HuraTextBox3.Text = ("OS Version: " + My.Computer.Info.OSVersion)
        HuraTextBox4.Text = ("PC Name: " + System.Environment.MachineName.ToString)
        HuraTextBox5.Text = ("Current user: " + System.Environment.UserName.ToString)
        HuraTextBox6.Text = ("Processor count: " + System.Environment.ProcessorCount.ToString)
        If System.Environment.Is64BitOperatingSystem = True Then
            HuraTextBox7.Text = ("Bit Version: 64 bit")
        Else
            If System.Environment.Is64BitOperatingSystem = False Then
                HuraTextBox7.Text = ("Bit Version: 32 bit")
            Else
                HuraTextBox7.Text = ("Bit Version: Unknown")
            End If
        End If
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub
End Class