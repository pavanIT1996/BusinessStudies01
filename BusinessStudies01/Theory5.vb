Public Class Theory5

    Dim count As Integer = 0

    Dim audiofile As String = "KriyakarakamN2.wav"
    Dim sound13 As New Media.SoundPlayer(audiofile)
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        count += 1

        If count = 1 Then
            Panel1.Visible = False
            Panel2.Visible = True
        Else
            count = 0
            Panel2.Visible = False
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        count += 1

        If count = 1 Then
            Panel2.Visible = False
            Panel1.Visible = True
        Else
            count = 0
            Panel1.Visible = False
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Theory5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound13.Play()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound13.Stop()
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound13.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound13.Stop()
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub
End Class