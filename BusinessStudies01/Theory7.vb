Public Class Theory7

    Dim count As Integer = 0


    Dim audiofile As String = "KriyakarakamN4.wav"
    Dim sound15 As New Media.SoundPlayer(audiofile)
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound15.Stop()
        Me.Close()
        Form8.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound15.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound15.Stop()
        Me.Close()
        Form9.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Theory7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound15.Play()
    End Sub
End Class