Public Class Theory9

    Dim audiofile As String = "KriyakarakamN6.wav"
    Dim sound17 As New Media.SoundPlayer(audiofile)
    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound17.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound17.Stop()
        Me.Close()
        Form12.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound17.Stop()
        Me.Close()
        Form13.Show()
    End Sub

    Private Sub Theory9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound17.Play()
    End Sub
End Class