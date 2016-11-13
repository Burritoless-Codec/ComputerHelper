Imports CoreAudioApi
Imports System.Windows.Forms
Imports System
Public Class Volumecontrol
    Dim Svol As Integer = 0

    Private Function SetVol() As Integer
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
    End Function

    Private Function GetVol() As Integer
        Dim MasterMin As Integer = 0
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        Dim Vol As Integer = 0

        With device.AudioEndpointVolume
            Vol = CInt(.MasterVolumeLevelScalar * 100)
            If Vol < MasterMin Then
                Vol = MasterMin / 100
            End If
        End With
        Return Vol
    End Function

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub Volumecontrol_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = GetVol() & "%"
        TrackBar1.Value = GetVol()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Svol = TrackBar1.Value
        If Svol < 0 Then
            Svol = 0
        Else
            If Svol > 100 Then
                Svol = 100
            End If
        End If
        Label1.Text = GetVol() & "%"
        SetVol()
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        Close()
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        HuraProgressBar1.Value = GetVol()
    End Sub
End Class