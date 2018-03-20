Public Class Theory8

    Dim audiofile As String = "KriyakarakamN5.wav"
    Dim sound16 As New Media.SoundPlayer(audiofile)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound16.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound16.Stop()
        Me.Close()
        Form11.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound16.Stop()
        Me.Close()
        Form10.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Theory8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound16.Play()
    End Sub
End Class