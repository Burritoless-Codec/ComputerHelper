Public Class imgconver
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click

        If HuraComboBox1.SelectedItem = "JPEG" Then
            Try
                SaveFileDialog1.Filter = "JPEG |*.jpeg"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If HuraComboBox1.SelectedItem = "PNG" Then
            Try
                SaveFileDialog1.Filter = "PNG |*.png"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If HuraComboBox1.SelectedItem = "TIFF" Then
            Try
                SaveFileDialog1.Filter = "TIFF |*.tiff"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If HuraComboBox1.SelectedItem = "GIF" Then
            Try
                SaveFileDialog1.Filter = "GIF |*.gif"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If HuraComboBox1.SelectedItem = "BMP" Then
            Try
                SaveFileDialog1.Filter = "BMP |*.bmp"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If HuraComboBox1.SelectedItem = "SVG" Then
            Try
                SaveFileDialog1.Filter = "SVG |*.svg"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub imgconver_Load(sender As Object, e As EventArgs) Handles Me.Load
        HuraComboBox1.SelectedItem = "PNG"
    End Sub
End Class