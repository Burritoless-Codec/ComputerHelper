Public Class Textencry
    Dim RC2 As New System.Security.Cryptography.RC2CryptoServiceProvider
    Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
    Dim AES As New System.Security.Cryptography.AesCryptoServiceProvider
    Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        If HuraRadioButton1.Checked = True Then
            Try
                DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                DES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateEncryptor
                Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(RichTextBox1.Text)
                RichTextBox1.Text = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If HuraRadioButton2.Checked = True Then
            Try
                AES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim AESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
                Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(RichTextBox1.Text)
                RichTextBox1.Text = Convert.ToBase64String(AESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If HuraRadioButton3.Checked = True Then
            Try
                RC2.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                RC2.Mode = Security.Cryptography.CipherMode.ECB
                Dim RC2Encrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateEncryptor
                Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(RichTextBox1.Text)
                RichTextBox1.Text = Convert.ToBase64String(RC2Encrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        If Timer1.Enabled = True Then
            HuraRadioButton1.Enabled = True
            HuraRadioButton2.Enabled = True
            HuraRadioButton3.Enabled = True
            Timer1.Enabled = False
        Else
            HuraRadioButton1.Enabled = False
            HuraRadioButton2.Enabled = False
            HuraRadioButton3.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub HuraButton6_Click(sender As Object, e As EventArgs) Handles HuraButton6.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.InitialDirectory = ("C:\Users" + Environment.UserName + "\Desktop")
        Save.Filter = "ModJokerGaming [*.MJGC]|*.MJGC|Doxx [*.doxx]|*.doxx|Wizard [*.wiz]|*.wiz|Text Files [*.txt]|*.txt|All Files [*.*]|*.*"
        Save.CheckPathExists = True
        Save.Title = "Save File"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName)
            myStreamWriter.Write(RichTextBox1.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.InitialDirectory = ("C:\Users" + Environment.UserName + "\Desktop")
        Open.Filter = "ModJokerGaming [*.MJGC]|*.MJGC|Doxx [*.doxx]|*.doxx|Wizard [*.wiz]|*.wiz|Text Files [*.txt]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "Open File"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            RichTextBox1.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub HuraButton7_Click(sender As Object, e As EventArgs) Handles HuraButton7.Click
        If HuraRadioButton1.Checked = True Then
            Try
                DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                DES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateDecryptor
                Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If HuraRadioButton2.Checked = True Then
            Try
                AES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim AESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
                Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(AESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If HuraRadioButton3.Checked = True Then
            Try
                RC2.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                RC2.Mode = Security.Cryptography.CipherMode.ECB
                Dim RC2Decrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateDecryptor
                Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(RC2Decrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                MessageBox.Show("The following error(s) have occurred: " & ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraRadioButton1.Checked = True
        If HuraRadioButton1.Checked = True Then
            Try
                DES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                DES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateDecryptor
                Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Catch ex As Exception
                Text = "Decrypting."
                HuraRadioButton2.Checked = True
                If HuraRadioButton2.Checked = True Then
                    Try
                        AES.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                        AES.Mode = Security.Cryptography.CipherMode.ECB
                        Dim AESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
                        Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                        RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(AESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
                    Catch ex1 As Exception
                        Text = "Decrypting.."
                        HuraRadioButton3.Checked = True
                        If HuraRadioButton3.Checked = True Then
                            Try
                                RC2.Key = Hash.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(HuraTextBox1.Text))
                                RC2.Mode = Security.Cryptography.CipherMode.ECB
                                Dim RC2Decrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateDecryptor
                                Dim Buffer As Byte() = Convert.FromBase64String(RichTextBox1.Text)
                                RichTextBox1.Text = System.Text.ASCIIEncoding.ASCII.GetString(RC2Decrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
                            Catch ex2 As Exception
                            End Try
                        End If

                    End Try
                End If

            End Try
        End If
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub Textencry_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub
End Class