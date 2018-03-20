Public Class Form6

    Dim audiofile As String = "Kriyakarakam2.2.wav"
    Dim sound4 As New Media.SoundPlayer(audiofile)
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover, PictureBox2.MouseHover, PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.BackColor = Color.LawnGreen And Label2.BackColor = Color.GreenYellow And
            Label3.BackColor = Color.LawnGreen And Label4.BackColor = Color.GreenYellow And
            Label5.BackColor = Color.LawnGreen And Label6.BackColor = Color.GreenYellow And
            Label7.BackColor = Color.LawnGreen And Label8.BackColor = Color.GreenYellow Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")

        Else

            Label9.Visible = True
            Label10.Visible = True
            Label1.BackColor = Color.LawnGreen
            Label12.Visible = True
            Label13.Visible = True
            Label2.BackColor = Color.GreenYellow
            Label14.Visible = True
            Label15.Visible = True
            Label3.BackColor = Color.LawnGreen
            Label16.Visible = True
            Label17.Visible = True
            Label4.BackColor = Color.GreenYellow
            Label18.Visible = True
            Label19.Visible = True
            Label5.BackColor = Color.LawnGreen
            Label20.Visible = True
            Label21.Visible = True
            Label6.BackColor = Color.GreenYellow
            Label22.Visible = True
            Label23.Visible = True
            Label7.BackColor = Color.LawnGreen
            Label24.Visible = True
            Label25.Visible = True
            Label8.BackColor = Color.GreenYellow
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox17.Visible = False
            PictureBox18.Visible = False
            PictureBox19.Visible = False
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Label1.BackColor = Color.HotPink
        Label10.Visible = False
        check()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label1.BackColor = Color.Plum
        Label9.Visible = False
        check()
    End Sub

    Private Sub Label24_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover, Label25.MouseHover, Label24.MouseHover, Label23.MouseHover, Label22.MouseHover, Label21.MouseHover, Label20.MouseHover, Label19.MouseHover, Label18.MouseHover, Label17.MouseHover, Label16.MouseHover, Label15.MouseHover, Label14.MouseHover, Label13.MouseHover, Label12.MouseHover, Label10.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label24_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave, Label25.MouseLeave, Label24.MouseLeave, Label23.MouseLeave, Label22.MouseLeave, Label21.MouseLeave, Label20.MouseLeave, Label19.MouseLeave, Label18.MouseLeave, Label17.MouseLeave, Label16.MouseLeave, Label15.MouseLeave, Label14.MouseLeave, Label13.MouseLeave, Label12.MouseLeave, Label10.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label2.BackColor = Color.HotPink
        Label12.Visible = False
        check()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label2.BackColor = Color.Plum
        Label13.Visible = False
        check()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Label3.BackColor = Color.HotPink
        Label14.Visible = False
        check()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Label3.BackColor = Color.Plum
        Label15.Visible = False
        check()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Label4.BackColor = Color.HotPink
        Label16.Visible = False
        check()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Label4.BackColor = Color.Plum
        Label17.Visible = False
        check()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Label5.BackColor = Color.HotPink
        Label18.Visible = False
        check()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Label5.BackColor = Color.Plum
        Label19.Visible = False
        check()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Label6.BackColor = Color.HotPink
        Label20.Visible = False
        check()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Label6.BackColor = Color.Plum
        Label21.Visible = False
        check()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Label7.BackColor = Color.HotPink
        Label22.Visible = False
        check()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Label7.BackColor = Color.Plum
        Label23.Visible = False
        check()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Label8.BackColor = Color.HotPink
        Label24.Visible = False
        check()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Label8.BackColor = Color.Plum
        Label25.Visible = False
        check()
    End Sub

    Private Sub check()
        If Label1.BackColor = Color.LawnGreen Or Label2.BackColor = Color.GreenYellow Or
            Label3.BackColor = Color.LawnGreen Or Label4.BackColor = Color.GreenYellow Or
            Label5.BackColor = Color.LawnGreen Or Label6.BackColor = Color.GreenYellow Or
            Label7.BackColor = Color.LawnGreen Or Label8.BackColor = Color.GreenYellow Then
        Else

            If Label1.BackColor = Color.HotPink Then
                'MessageBox.Show("1-correct")
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            Else
                'MessageBox.Show("1-wrong")
                PictureBox5.Visible = True
                PictureBox4.Visible = False
            End If
            If Label2.BackColor = Color.Plum Then
                'MessageBox.Show("2-correct")
                PictureBox7.Visible = True
                PictureBox6.Visible = False
            Else
                'MessageBox.Show("2-wrong")
                PictureBox6.Visible = True
                PictureBox7.Visible = False
            End If
            If Label3.BackColor = Color.HotPink Then
                'MessageBox.Show("3-correct")
                PictureBox9.Visible = True
                PictureBox8.Visible = False
            Else
                ' MessageBox.Show("3-wrong")
                PictureBox8.Visible = True
                PictureBox9.Visible = False
            End If
            If Label4.BackColor = Color.Plum Then
                ' MessageBox.Show("4-correct")
                PictureBox11.Visible = True
                PictureBox10.Visible = False
            Else
                'MessageBox.Show("4-wrong")
                PictureBox10.Visible = True
                PictureBox11.Visible = False
            End If
            If Label5.BackColor = Color.HotPink Then
                ' MessageBox.Show("5-correct")
                PictureBox13.Visible = True
                PictureBox12.Visible = False
            Else
                'MessageBox.Show("5-wrong")
                PictureBox12.Visible = True
                PictureBox13.Visible = False
            End If
            If Label6.BackColor = Color.Plum Then
                'MessageBox.Show("6-correct")
                PictureBox15.Visible = True
                PictureBox14.Visible = False
            Else
                'MessageBox.Show("6-wrong")
                PictureBox14.Visible = True
                PictureBox15.Visible = False
            End If
            If Label7.BackColor = Color.HotPink Then
                'MessageBox.Show("7-correct")
                PictureBox17.Visible = True
                PictureBox16.Visible = False
            Else
                ' MessageBox.Show("7-wrong")
                PictureBox16.Visible = True
                PictureBox17.Visible = False
            End If
            If Label8.BackColor = Color.Plum Then
                ' MessageBox.Show("8-correct")
                PictureBox19.Visible = True
                PictureBox18.Visible = False
            Else
                'MessageBox.Show("8-wrong")
                PictureBox18.Visible = True
                PictureBox19.Visible = False
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound4.Stop()
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound4.Play()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound4.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound4.Stop()
        Me.Hide()
        Theory6.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        Theory5.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory5.Show()
    End Sub
End Class