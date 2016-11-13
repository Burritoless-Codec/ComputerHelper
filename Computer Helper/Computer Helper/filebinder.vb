Public Class filebinder
    Dim F, F2 As String
    Function Secure(ByVal data As Byte()) As Byte()

        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7}
            SA.Key = New Byte() {7, 6, 5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Function UnSecure(ByVal data As Byte()) As Byte()

        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7}
            SA.Key = New Byte() {7, 6, 5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            Return SA.CreateDecryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "*.*"
            .Title = "Choose a File..."
            .Filter = "All Files (*.*)|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                F = .SafeFileName
                HuraTextBox1.Text = .FileName
            End If
        End With
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "*.*"
            .Title = "Choose a File..."
            .Filter = "All Files (*.*)|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                F2 = .SafeFileName
                HuraTextBox2.Text = .FileName
            End If
        End With
    End Sub

    'Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
    'Dim sfd As New SaveFileDialog
    ' With sfd
    '  .FileName = "*.*"
    ' .Title = "Choose and location"
    '  .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    '  If .ShowDialog = Windows.Forms.DialogResult.OK Then
    ' Dim sp As String = "[SPLITTER]"
    ' Dim buffer As Byte() = My.Resources.stub
    '             My.Computer.FileSystem.WriteAllBytes(.FileName, buffer, False)
    ' Dim file1 As Byte() = Secure(My)
    '        End If
    '    End With
    ' End Sub
End Class