Public Class Form3

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.URL = "C:/Users/Swindya/Downloads/IntroTeamMorpig.mp4"
        AxWindowsMediaPlayer1.Show()
    End Sub
End Class