Public Class Form10
    Dim lab As Label
    Dim count = 60
    Public firstlocation
    Dim test
    Dim test2
    Dim test3
    Dim test4
    Dim test5
    Dim test6
    Dim test7

    Dim audiofile As String = "Kriyakarakam4.2.wav"
    Dim sound8 As New Media.SoundPlayer(audiofile)
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound8.Stop()
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound8.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        sound8.Stop()
        Me.Hide()
        Theory8.Show()
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown, Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        lab = CType(sender, Label)
        lab.DoDragDrop(lab.Text, DragDropEffects.All)
        Timer1.Stop()
    End Sub

    Private Sub Label7_DragEnter(sender As Object, e As DragEventArgs) Handles Label7.DragEnter, Label6.DragEnter, Label5.DragEnter, Label4.DragEnter, Label3.DragEnter, Label2.DragEnter, Label1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Label7_DragDrop(sender As Object, e As DragEventArgs) Handles Label7.DragDrop, Label6.DragDrop, Label5.DragDrop, Label4.DragDrop, Label3.DragDrop, Label2.DragDrop, Label1.DragDrop

        Dim lab2 As Label = CType(sender, Label)
        Dim pt As Point = lab2.Location

        lab2.Location = lab.Location
        lab.Location = pt

    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover, Label6.MouseHover, Label5.MouseHover, Label4.MouseHover, Label3.MouseHover, Label2.MouseHover, Label1.MouseHover
        Cursor = Cursors.Hand
        lab = CType(sender, Label)
        lab.BackColor = Color.Yellow
        Label17.Visible = True
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound8.Play()
        Timer1.Start()
        test = Label1.Location
        test2 = Label2.Location
        test3 = Label3.Location
        test4 = Label4.Location
        test5 = Label5.Location
        test6 = Label6.Location
        test7 = Label7.Location
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Location = test And Label2.Location = test2 And
        Label3.Location = test3 And Label4.Location = test4 And
        Label5.Location = test5 And Label6.Location = test6 And
        Label7.Location = test7 And PictureBox9.Visible = False And
        PictureBox10.Visible = False And PictureBox1.Visible = False And
        PictureBox2.Visible = False And PictureBox3.Visible = False And
        PictureBox4.Visible = False And PictureBox5.Visible = False And
        PictureBox11.Visible = False And PictureBox12.Visible = False And
        PictureBox13.Visible = False And PictureBox14.Visible = False And
        PictureBox15.Visible = False And PictureBox16.Visible = False And
        PictureBox17.Visible = False Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            Label1.Location = test
            Label2.Location = test2
            Label3.Location = test3
            Label4.Location = test4
            Label5.Location = test5
            Label6.Location = test6
            Label7.Location = test7

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
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            Timer1.Start()
        End If
    End Sub

    Private Sub check()
        If Label1.Location = test4 Then
            'MessageBox.Show("Correct 1")
            PictureBox10.Visible = True
            PictureBox9.Visible = False
        Else
            'MessageBox.Show("Wrong 1")
            PictureBox9.Visible = True
            PictureBox10.Visible = False
        End If
        If Label2.Location = test6 Then
            'MessageBox.Show("Correct 2")
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        Else
            'MessageBox.Show("Wrong 2")
            PictureBox1.Visible = True
            PictureBox2.Visible = False
        End If
        If Label3.Location = test7 Then
            'MessageBox.Show("Correct 3")
            PictureBox4.Visible = True
            PictureBox3.Visible = False
        Else
            'MessageBox.Show("Wrong 3")
            PictureBox3.Visible = True
            PictureBox4.Visible = False
        End If
        If Label4.Location = test Then
            'MessageBox.Show("Correct 4")
            PictureBox11.Visible = True
            PictureBox5.Visible = False
        Else
            ' MessageBox.Show("Wrong 4")
            PictureBox5.Visible = True
            PictureBox11.Visible = False
        End If
        If Label5.Location = test3 Then
            'MessageBox.Show("Correct 5")
            PictureBox13.Visible = True
            PictureBox12.Visible = False
        Else
            'MessageBox.Show("Wrong 5")
            PictureBox12.Visible = True
            PictureBox13.Visible = False
        End If
        If Label6.Location = test2 Then
            'MessageBox.Show("Correct 6")
            PictureBox15.Visible = True
            PictureBox14.Visible = False
        Else
            'MessageBox.Show("Wrong 6")
            PictureBox14.Visible = True
            PictureBox15.Visible = False
        End If
        If Label7.Location = test5 Then
            'MessageBox.Show("Correct 7")
            PictureBox17.Visible = True
            PictureBox16.Visible = False
        Else
            'MessageBox.Show("Wrong 7")
            PictureBox16.Visible = True
            PictureBox17.Visible = False
        End If
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label1.MouseLeave
        Cursor = Cursors.Default
        lab = CType(sender, Label)
        lab.BackColor = Color.DarkOrange
        Label17.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        check()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count Mod 5 = 0 Then
            Label1.Location = test7
            Label2.Location = test6
            Label3.Location = test5
            Label4.Location = test4
            Label5.Location = test3
            Label6.Location = test2
            Label7.Location = test
        ElseIf count Mod 5 = 1 Then
            Label1.Location = test6
            Label2.Location = test5
            Label3.Location = test4
            Label4.Location = test3
            Label5.Location = test2
            Label6.Location = test
            Label7.Location = test7
        ElseIf count Mod 5 = 2 Then
            Label1.Location = test5
            Label2.Location = test4
            Label3.Location = test3
            Label4.Location = test2
            Label5.Location = test
            Label6.Location = test7
            Label7.Location = test6
        ElseIf count Mod 5 = 3 Then
            Label1.Location = test4
            Label2.Location = test3
            Label3.Location = test2
            Label4.Location = test
            Label5.Location = test7
            Label6.Location = test6
            Label7.Location = test5
        ElseIf count Mod 5 = 4 Then
            Label1.Location = test3
            Label2.Location = test2
            Label3.Location = test
            Label4.Location = test7
            Label5.Location = test6
            Label6.Location = test5
            Label7.Location = test4
        ElseIf count Mod 5 = 5 Then
            Label1.Location = test2
            Label2.Location = test
            Label3.Location = test7
            Label4.Location = test6
            Label5.Location = test5
            Label6.Location = test4
            Label7.Location = test3
        ElseIf count Mod 5 = 6 Then
            Label1.Location = test
            Label2.Location = test7
            Label3.Location = test6
            Label4.Location = test5
            Label5.Location = test4
            Label6.Location = test3
            Label7.Location = test2
        End If
        If count = 0 Then
            Timer1.Stop()
            count += 60
        End If
    End Sub

    Private Sub Label16_DoubleClick(sender As Object, e As EventArgs) Handles Label16.DoubleClick

    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Theory7.Show()
    End Sub
End Class