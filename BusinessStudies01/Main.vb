Public Class Main

    Dim count
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover
        Label7.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        Form9.Show()
    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover
        Label9.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()
        Form11.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Theory3.Show()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button2.MouseHover, Button3.MouseHover, Button4.MouseHover, Button5.MouseHover, Button6.MouseHover, Button7.MouseHover
        Cursor = Cursors.Hand
        sender.BackColor = Color.White
        If sender Is Button1 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 1"
            Label10.Text = "ක්‍රියාකාරකම් 1.1"
            Label11.Text = "ක්‍රියාකාරකම් 1.2"

        ElseIf sender Is Button2 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 2"
            Label10.Text = "ක්‍රියාකාරකම් 2.1"
            Label11.Text = "ක්‍රියාකාරකම් 2.2"

        ElseIf sender Is Button3 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 3"
            Label10.Text = "ක්‍රියාකාරකම් 3.1"
            Label11.Text = "ක්‍රියාකාරකම් 3.2"

        ElseIf sender Is Button4 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 4"
            Label10.Text = "ක්‍රියාකාරකම් 4.1"
            Label11.Text = "ක්‍රියාකාරකම් 4.2"

        ElseIf sender Is Button5 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 5"
            Label10.Text = "ක්‍රියාකාරකම් 5.1"
            Label11.Text = "ක්‍රියාකාරකම් 5.2"

        ElseIf sender Is Button6 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 6"
            Label10.Text = "ක්‍රියාකාරකම් 6.1"
            Label11.Text = "ක්‍රියාකාරකම් 6.2"
        ElseIf sender Is Button7 Then
            Panel3.Location = New Point(768, 271)
            Panel3.Visible = True
            Label12.Text = "නිබන්ධන 7"
            Label10.Text = "ක්‍රියාකාරකම් 7.1"
            Label11.Text = "ක්‍රියාකාරකම් 7.2"
        End If
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave, Button6.MouseLeave, Button7.MouseLeave
        Cursor = Cursors.Default
        sender.BackColor = Color.Gainsboro
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Theory5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Theory6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Theory7.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Theory8.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count Mod 3 = 0 Then
            Label12.ForeColor = Color.Purple
            Label10.ForeColor = Color.Black
            Label11.ForeColor = Color.Black
        ElseIf count Mod 3 = 1 Then
            Label12.ForeColor = Color.Black
            Label10.ForeColor = Color.Purple
            Label11.ForeColor = Color.Black
        ElseIf count Mod 3 = 2 Then
            Label12.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label11.ForeColor = Color.Purple
        End If

        If count = 10 Then
            Panel3.Visible = False
            count = 0
            Timer1.Start()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Theory9.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form14.Show()
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

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click, Label11.Click, Label10.Click
        If sender Is Label12 Then
            If Label12.Text = "නිබන්ධන 1" Then
                Me.Close()
                Theory3.Show()
            ElseIf Label12.Text = "නිබන්ධන 2" Then
                Me.Close()
                Theory5.Show()
            ElseIf Label12.Text = "නිබන්ධන 3" Then
                Me.Close()
                Theory6.Show()
            ElseIf Label12.Text = "නිබන්ධන 4" Then
                Me.Close()
                Theory7.Show()
            ElseIf Label12.Text = "නිබන්ධන 5" Then
                Me.Close()
                Theory8.Show()
            ElseIf Label12.Text = "නිබන්ධන 6" Then
                Me.Close()
                Theory9.Show()
            ElseIf Label12.Text = "නිබන්ධන 7" Then
                Me.Close()
                Theory10.Show()
            End If
        End If
        If sender Is Label10 Then
            If Label10.Text = "ක්‍රියාකාරකම් 1.1" Then
                Me.Close()
                Form3.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 2.1" Then
                Me.Close()
                Form5.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 3.1" Then
                Me.Close()
                Form7.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 4.1" Then
                Me.Close()
                Form9.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 5.1" Then
                Me.Close()
                Form11.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 6.1" Then
                Me.Close()
                Form13.Show()
            ElseIf Label10.Text = "ක්‍රියාකාරකම් 7.1" Then
                Me.Close()
                Form15.Show()
            End If
        End If
        If sender Is Label11 Then
            If Label11.Text = "ක්‍රියාකාරකම් 1.2" Then
                Me.Close()
                Form4.Show()
            ElseIf Label11.Text = "ක්‍රියාකාරකම් 2.2" Then
                Me.Close()
                Form6.Show()
            ElseIf Label11.Text = "ක්‍රියාකාරකම් 3.2" Then
                Me.Close()
                Form8.Show()
            ElseIf Label11.Text = "ක්‍රියාකාරකම් 4.2" Then
                Me.Close()
                Form10.Show()
            ElseIf Label11.Text = "ක්‍රියාකාරකම් 5.2" Then
                Me.Close()
                Form12.Show()
            ElseIf Label11.Text = "ක්‍රියාකාරකම් 6.2" Then
                Me.Close()
                Form14.Show()
            End If
        End If
    End Sub

    Private Sub Label12_MouseHover(sender As Object, e As EventArgs) Handles Label12.MouseHover, Label11.MouseHover, Label10.MouseHover
        Cursor = Cursors.Hand
        sender.forecolor = Color.White
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave, Label11.MouseLeave, Label10.MouseLeave
        Cursor = Cursors.Default
        sender.forecolor = Color.Black
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Theory10.Show()
    End Sub
End Class