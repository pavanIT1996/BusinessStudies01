Public Class Form15

    Dim count = 0
    Dim x
    Dim y
    Dim x2
    Dim y2
    Dim x3
    Dim y3
    Dim x4
    Dim y4
    Dim x5
    Dim y5
    Dim x6
    Dim y6
    Dim x7
    Dim y7
    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 0.2
        x2 += 0.4
        x3 += 0.6
        x4 += 0.8
        x5 += 1
        x6 += 1.2
        x7 += 1.4
        Label1.Location = New Point(x, y)
        Label2.Location = New Point(x2, y2)
        Label3.Location = New Point(x3, y3)
        Label4.Location = New Point(x4, y4)
        Label5.Location = New Point(x5, y5)
        Label6.Location = New Point(x6, y6)
        Label7.Location = New Point(x7, y7)
        If Label1.Location.X = 1264 Then
            x = 0
        End If
        If Label2.Location.X = 1264 Then
            x2 = 0
        End If
        If Label3.Location.X = 1264 Then
            x3 = 0
        End If
        If Label4.Location.X = 1264 Then
            x4 = 0
        End If
        If Label5.Location.X = 1264 Then
            x5 = 0
        End If
        If Label6.Location.X = 1264 Then
            x6 = 0
        End If
        If Label7.Location.X = 1264 Then
            x7 = 0
        End If

    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        x = Label1.Location.X
        y = Label1.Location.Y

        x2 = Label2.Location.X
        y2 = Label2.Location.Y

        x3 = Label3.Location.X
        y3 = Label3.Location.Y

        x4 = Label4.Location.X
        y4 = Label4.Location.Y

        x5 = Label5.Location.X
        y5 = Label5.Location.Y

        x6 = Label6.Location.X
        y6 = Label6.Location.Y

        x7 = Label7.Location.X
        y7 = Label7.Location.Y
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown, Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        Timer1.Stop()
    End Sub

    Private Sub Label15_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown, Label8.MouseDown, Label15.MouseDown, Label14.MouseDown, Label12.MouseDown, Label11.MouseDown, Label10.MouseDown
        Timer1.Start()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        Theory10.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        Theory10.Show()
    End Sub
End Class