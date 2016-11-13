Public Class Form12
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public WithEvents browser As New WebBrowser
    Dim isRefre As Boolean = False
    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        Dim x As New TabPage
        Dim p As New WebBrowser
        p.ScriptErrorsSuppressed = True
        p.Navigate(My.Settings.homepage)
        x.Controls.Add(p)
        p.Dock = DockStyle.Fill
        TabControl1.TabPages.Add(x)
        AddHandler p.Navigating, AddressOf browser_Navigating
        AddHandler p.DocumentCompleted, AddressOf browser_DocumentCompleted
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click
        Dim input = InputBox("Please Enter a home page")
        If Not input = "" Then
            My.Settings.homepage = input
            My.Settings.Save()
            MsgBox("Applied new homepage: " & My.Settings.homepage)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If CType(TabControl1.SelectedTab.Controls(0), WebBrowser).CanGoBack Then
                CType(TabControl1.SelectedTab.Controls(0), WebBrowser).GoBack()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If CType(TabControl1.SelectedTab.Controls(0), WebBrowser).CanGoForward Then
                CType(TabControl1.SelectedTab.Controls(0), WebBrowser).GoForward()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        Try
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(ToolStripComboBox1.Text)
            ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Try
            CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(My.Settings.homepage)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Try
            If isRefre Then
                CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Refresh()
                isRefre = True
            Else
                CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Stop()
                isRefre = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles browser.DocumentCompleted
        Try
            If CType(TabControl1.SelectedTab.Controls(0), WebBrowser).DocumentTitle.ToString.Length > 21 Then
                TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls(0), WebBrowser).DocumentTitle.ToString.Substring(0, 20) & "..."
            Else
                TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls(0), WebBrowser).DocumentTitle
            End If
        Catch ex As Exception

        End Try
        isRefre = False
        Try
            ToolStripComboBox1.Text = CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Url.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub browser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles browser.Navigating
        isRefre = True
    End Sub

    Private Sub ExitTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitTabToolStripMenuItem.Click
        TabControl1.SelectedTab.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
    End Sub

    Private Sub ToolStripComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ToolStripComboBox1.KeyPress
        If (GetAsyncKeyState(13)) Then
            Try
                CType(TabControl1.SelectedTab.Controls(0), WebBrowser).Navigate(ToolStripComboBox1.Text)
                ToolStripComboBox1.Items.Add(ToolStripComboBox1.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub NewTabToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem1.Click
        Dim x As New TabPage
        Dim p As New WebBrowser
        p.ScriptErrorsSuppressed = True
        p.Navigate(My.Settings.homepage)
        x.Controls.Add(p)
        p.Dock = DockStyle.Fill
        TabControl1.TabPages.Add(x)
        AddHandler p.Navigating, AddressOf browser_Navigating
        AddHandler p.DocumentCompleted, AddressOf browser_DocumentCompleted
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        TabControl1.SelectedTab.Dispose()
    End Sub
End Class