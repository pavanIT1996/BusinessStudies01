Public Class Theory6

    Dim audiofile As String = "KriyakarakamN3.wav"
    Dim sound14 As New Media.SoundPlayer(audiofile)
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound14.Stop()
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound14.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound14.Stop()
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Theory6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound14.Play()
    End Sub
End Class