Imports System.Net
Imports System
Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bit As String
        bit = ("C:\Program Files (x86)")
        If System.IO.File.Exists(bit) = True Then
            System.Diagnostics.Process.Start("C:/Program Files (x86)/ModJokerGaming/Computer Helper/bat/progstart.bat")
        Else
            System.Diagnostics.Process.Start("C:/Program Files/ModJokerGaming/Computer Helper/bat/progstart.bat")
        End If
    End Sub
End Class
