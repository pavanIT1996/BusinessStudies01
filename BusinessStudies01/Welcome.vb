Public Class Welcome

    Dim location1 As Point
    Dim location2 As Point
    Dim location3 As Point



    Dim count = 60
    Dim count2 = 60
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.White
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PromptBox.Show()
        'Main.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label1.Text = count
        location1 = PictureBox2.Location
        location2 = PictureBox3.Location
        location3 = PictureBox4.Location
        count = 60
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Label1.Text = Label1.Text - 1
        count2 = count2 + 1
        If count2 Mod 5 = 0 Then
            Label1.BackColor = Color.Red
        ElseIf count2 Mod 5 = 1 Then
            Label1.BackColor = Color.Orange
        ElseIf count2 Mod 5 = 2 Then
            Label1.BackColor = Color.Blue
        ElseIf count2 Mod 5 = 3 Then
            Label1.BackColor = Color.Yellow
        ElseIf count2 Mod 5 = 4 Then
            Label1.BackColor = Color.Indigo
        ElseIf count2 Mod 5 = 5 Then
            Label1.BackColor = Color.Azure
        End If
        If count2 = 0 Then
            Timer1.Stop()
            count2 += 60
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        count = count + 1
        If count Mod 5 = 0 Then
            PictureBox2.Location = location3
            PictureBox3.Location = location2
            PictureBox4.Location = location1
        ElseIf count Mod 5 = 1 Then

        ElseIf count Mod 5 = 2 Then
            PictureBox2.Location = location2
            PictureBox3.Location = location1
            PictureBox4.Location = location3
        ElseIf count Mod 5 = 3 Then

        ElseIf count Mod 5 = 4 Then
            PictureBox2.Location = location1
            PictureBox3.Location = location3
            PictureBox4.Location = location2
        ElseIf count Mod 5 = 5 Then

        End If
        If count = 0 Then
            Timer2.Stop()
            count += 60
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Cursor = Cursors.Default
    End Sub
End Class
