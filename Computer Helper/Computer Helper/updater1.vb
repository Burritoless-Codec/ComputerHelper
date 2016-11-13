Public Class updater1
    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("https://www.google.com/")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Private Sub updater1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If InternetConnection() = True Then
            MsgBox("true")
        Else
            If InternetConnection() = False Then
                MsgBox("false")
            End If
        End If
    End Sub
End Class