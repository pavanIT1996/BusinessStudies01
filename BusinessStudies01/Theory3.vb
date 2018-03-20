Public Class Theory3

    Dim count As Integer = 0


    Dim audiofile As String = "KriyakarakamN1.wav"
    Dim sound12 As New Media.SoundPlayer(audiofile)
    Public ReadOnly Property PForm As Form

    Private Sub Theory3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound12.Play()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound12.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound12.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        count += 1

        If count = 1 Then
            Panel2.Visible = True
            Panel1.Visible = False
        End If
        If count = 2 Then
            count = 0
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        count += 1

        If count = 1 Then
            Panel1.Visible = True
            Panel2.Visible = False
        End If

        If count = 2 Then
            count = 0
            Panel2.Visible = True
            Panel1.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound12.Stop()
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs)
        sender.BackColor = Color.Yellow
        sender.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs)
        sender.backcolor = Color.Transparent
        sender.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        count += 1

        If count = 1 Then
            Panel1.Visible = True
            Panel2.Visible = False
        End If

        If count = 2 Then
            count = 0
            Panel2.Visible = True
            Panel1.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    '    Dim SAPI
    '    SAPI = CreateObject("SAPI.spvoice")
    '    SAPI.speak(Label1.Text)
    'End Sub
End Class