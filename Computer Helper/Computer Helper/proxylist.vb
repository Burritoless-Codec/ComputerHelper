Imports System.IO
Imports System.Runtime.InteropServices
Public Class proxylist
    <Runtime.InteropServices.DllImport("wininet.dll", SetLastError:=True)>
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    End Function

    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure
    Dim AllItems As String = ""
    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Dim Item As New ListViewItem(HuraTextBox1.Text)
        Item.SubItems.Add(HuraTextBox2.Text)
        Item.SubItems.Add(HuraTextBox3.Text)

        ListView1.Items.AddRange(New ListViewItem() {Item})


        HuraTextBox1.Text = ""
        HuraTextBox2.Text = ""
        HuraTextBox3.Text = ""
    End Sub
    Private Sub HuraButton4_Click(sender As Object, e As EventArgs)
        UseProxy("" & ":" & "")
        HuraTextBox1.Text = ""
        HuraTextBox2.Text = ""
        HuraTextBox3.Text = "UNKNOWN"
        HuraTextBox2.Text = "Local Area"
        HuraTextBox1.Text = "Local Area"
    End Sub
    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        ListView1.Items.RemoveAt(ListView1.SelectedItems(0).Index)
    End Sub

    Private Sub HuraButton6_Click(sender As Object, e As EventArgs) Handles HuraButton6.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub HuraButton7_Click(sender As Object, e As EventArgs) Handles HuraButton7.Click
        Try

            For Each item As ListViewItem In ListView1.Items
                AllItems = AllItems & item.Text & ":" & item.SubItems(1).Text & ":" & item.SubItems(2).Text & vbNewLine
            Next

            AllItems = AllItems.Trim

        Catch ex As Exception
        End Try

        If My.Computer.FileSystem.FileExists("ProxyList.prox") Then
            My.Computer.FileSystem.DeleteFile("ProxyList.prox")
        End If
        My.Computer.FileSystem.WriteAllText("ProxyList.prox", AllItems, True)
        save.Show()
    End Sub

    Private Sub HuraButton8_Click(sender As Object, e As EventArgs) Handles HuraButton8.Click
        Try
            ListView1.Items.Clear()
            AllItems = My.Computer.FileSystem.ReadAllText("ProxyList.prox")

            Dim ItemLines As New TextBox
            ItemLines.Text = AllItems


            For Each line As String In ItemLines.Lines

                Dim a1() As String = line.Split(":")

                Dim ItemName As String = a1(0)
                Dim SubItem1 As String = a1(1)
                Dim SubItem2 As String = a1(2)

                Dim Item As New ListViewItem(ItemName)

                Item.SubItems.Add(SubItem1)
                Item.SubItems.Add(SubItem2)

                ListView1.Items.AddRange(New ListViewItem() {Item})

            Next

        Catch ex As Exception
            MsgBox("Error" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Error ")
        End Try
    End Sub

    Public Sub UseProxy(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3

        Dim struct_IPI As Struct_INTERNET_PROXY_INFO

        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local")

        Dim intptrStruct As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI))

        Marshal.StructureToPtr(struct_IPI, intptrStruct, True)

        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub
    Private Sub HuraButton9_Click(sender As Object, e As EventArgs)
        UseProxy(HuraTextBox8.Text & ":" & HuraTextBox7.Text)
        If My.Computer.FileSystem.FileExists("ProxyList.prox") Then
            My.Computer.FileSystem.WriteAllText("ProxyList.prox", vbNewLine & HuraTextBox8.Text & ":" & HuraTextBox7.Text & ":" & HuraTextBox3.Text, True)
        End If
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub
End Class