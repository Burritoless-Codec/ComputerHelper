Public Class Form2
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
  Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
            WebBrowser1.GoBack()
        End Sub

        Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
            WebBrowser1.GoForward()
        End Sub

        Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
            WebBrowser1.Refresh()
        End Sub

        Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
            WebBrowser1.Navigate(ToolStripComboBox1.Text)
        End Sub

        Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

        End Sub

        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub ToolStripComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripComboBox1.KeyPress
        If (GetAsyncKeyState(13)) Then
            WebBrowser1.Navigate(ToolStripComboBox1.Text)
        End If
        End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            ToolStripComboBox1.Text = WebBrowser1.Url.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class