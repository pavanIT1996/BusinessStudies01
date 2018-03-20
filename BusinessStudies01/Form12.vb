Public Class Form12

    Dim test
    Dim count
    Dim loc
    Dim loc2
    Dim loc3
    Dim loc4
    Dim loc5
    Dim loc6

    Dim audiofile As String = "Kriyakarakam5.2.wav"
    Dim sound10 As New Media.SoundPlayer(audiofile)
    Private Sub Label11_MouseDown_1(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown, Label8.MouseDown, Label7.MouseDown, Label6.MouseDown, Label11.MouseDown, Label10.MouseDown

        If sender.backcolor = Color.OrangeRed Or sender.backcolor = Color.DarkGray Or
            sender.backcolor = Color.DeepSkyBlue Or sender.backcolor = Color.Gold Or
            sender.backcolor = Color.Fuchsia Or sender.backcolor = Color.LimeGreen Then
            MessageBox.Show("එක කරුණක් වර්ණ ගැන්විය හැක්කේ එක වාරයක් පමණි.")
        Else
            sender.backcolor = Color.Blue
            test = sender
            Panel1.Visible = True
        End If

        Timer1.Stop()
    End Sub

    Private Sub Label11_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover, Label8.MouseHover, Label7.MouseHover, Label6.MouseHover, Label11.MouseHover, Label10.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label11.MouseLeave, Label10.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button6.MouseDown, Button5.MouseDown, Button4.MouseDown, Button3.MouseDown, Button2.MouseDown, Button1.MouseDown
        Panel1.Visible = False

        If sender.backcolor = Color.OrangeRed Or sender.backcolor = Color.DarkGray Or
            sender.backcolor = Color.DeepSkyBlue Or sender.backcolor = Color.Gold Or
            sender.backcolor = Color.Fuchsia Or sender.backcolor = Color.LimeGreen Then
            test.backcolor = sender.backcolor
            sender.backcolor = Color.Red
        Else
            MessageBox.Show("එක වර්ණයක් භාවිත කල හැක්කේ එක වාරයක් පමණි.")

        End If
        Timer1.Start()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover, Button5.MouseHover, Button4.MouseHover, Button3.MouseHover, Button2.MouseHover, Button1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave, Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        count += 1
        If count Mod 5 = 0 Then
            Label6.Location = loc6
            Label7.Location = loc5
            Label8.Location = loc4
            Label9.Location = loc3
            Label10.Location = loc2
            Label11.Location = loc
        ElseIf count Mod 5 = 1 Then
            Label6.Location = loc5
            Label7.Location = loc4
            Label8.Location = loc3
            Label9.Location = loc2
            Label10.Location = loc
            Label11.Location = loc6
        ElseIf count Mod 5 = 2 Then
            Label6.Location = loc4
            Label7.Location = loc3
            Label8.Location = loc2
            Label9.Location = loc
            Label10.Location = loc6
            Label11.Location = loc5
        ElseIf count Mod 5 = 3 Then
            Label6.Location = loc3
            Label7.Location = loc2
            Label8.Location = loc
            Label9.Location = loc6
            Label10.Location = loc5
            Label11.Location = loc4
        ElseIf count Mod 5 = 4 Then
            Label6.Location = loc2
            Label7.Location = loc
            Label8.Location = loc6
            Label9.Location = loc5
            Label10.Location = loc4
            Label11.Location = loc3
        ElseIf count Mod 5 = 5 Then
            Label6.Location = loc
            Label7.Location = loc6
            Label8.Location = loc5
            Label9.Location = loc4
            Label10.Location = loc3
            Label11.Location = loc2
        End If
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound10.Play()
        loc = Label6.Location
        loc2 = Label7.Location
        loc3 = Label8.Location
        loc4 = Label9.Location
        loc5 = Label10.Location
        loc6 = Label11.Location
        Timer1.Start()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Label6.BackColor = Color.DarkOrange And
            Label7.BackColor = Color.DarkOrange And
        Label8.BackColor = Color.DarkOrange And
        Label9.BackColor = Color.DarkOrange And
        Label10.BackColor = Color.DarkOrange And
        Label11.BackColor = Color.DarkOrange Then

            MessageBox.Show("පිළිතුරු සපයා නැත")

        Else
            Timer1.Stop()
            Panel1.Visible = False
            check()
        End If

    End Sub

    Private Sub check()
        If Label6.BackColor = Color.OrangeRed Then
            'MessageBox.Show("Correct 1")
            PictureBox10.Visible = True
            PictureBox9.Visible = False
        Else
            'MessageBox.Show("Wrong 1")
            PictureBox9.Visible = True
            PictureBox10.Visible = False
        End If
        If Label7.BackColor = Color.DeepSkyBlue Then
            'MessageBox.Show("Correct 2")
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        Else
            'MessageBox.Show("Wrong 2")
            PictureBox1.Visible = True
            PictureBox2.Visible = False
        End If
        If Label8.BackColor = Color.DarkGray Then
            'MessageBox.Show("Correct 3")
            PictureBox4.Visible = True
            PictureBox3.Visible = False
        Else
            'MessageBox.Show("Wrong 3")
            PictureBox3.Visible = True
            PictureBox4.Visible = False
        End If
        If Label9.BackColor = Color.Gold Then
            'MessageBox.Show("Correct 4")
            PictureBox11.Visible = True
            PictureBox5.Visible = False
        Else
            'MessageBox.Show("Wrong 4")
            PictureBox5.Visible = True
            PictureBox11.Visible = False
        End If
        If Label10.BackColor = Color.Fuchsia Then
            'MessageBox.Show("Correct 5")
            PictureBox13.Visible = True
            PictureBox12.Visible = False
        Else
            'MessageBox.Show("Wrong 5")
            PictureBox12.Visible = True
            PictureBox13.Visible = False
        End If

        If Label11.BackColor = Color.LimeGreen Then
            'MessageBox.Show("Correct 6")
            PictureBox15.Visible = True
            PictureBox14.Visible = False
        Else
            'MessageBox.Show("Wrong 6")
            PictureBox14.Visible = True
            PictureBox15.Visible = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Label6.BackColor = Color.DarkOrange And
            Label7.BackColor = Color.DarkOrange And
        Label8.BackColor = Color.DarkOrange And
        Label9.BackColor = Color.DarkOrange And
        Label10.BackColor = Color.DarkOrange And
        Label11.BackColor = Color.DarkOrange Then

            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")

        Else

            Label6.BackColor = Color.DarkOrange
            Label7.BackColor = Color.DarkOrange
            Label8.BackColor = Color.DarkOrange
            Label9.BackColor = Color.DarkOrange
            Label10.BackColor = Color.DarkOrange
            Label11.BackColor = Color.DarkOrange

            Button1.BackColor = Color.OrangeRed
            Button2.BackColor = Color.DeepSkyBlue
            Button3.BackColor = Color.DarkGray
            Button4.BackColor = Color.Gold
            Button5.BackColor = Color.Fuchsia
            Button6.BackColor = Color.LimeGreen

            Panel1.Visible = False

            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False

            Timer1.Start()
        End If


    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound10.Stop()
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound10.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        sound10.Stop()
        Me.Hide()
        Theory9.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Theory8.Show()
    End Sub
End Class