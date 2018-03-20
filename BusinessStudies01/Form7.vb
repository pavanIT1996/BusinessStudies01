Public Class Form7

    Dim audiofile As String = "Kriyakarakam3.1.wav"
    Dim sound5 As New Media.SoundPlayer(audiofile)
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound5.Play()
    End Sub

    Private Sub Label23_MouseHover(sender As Object, e As EventArgs) Handles Label24.MouseHover, Label23.MouseHover, Label22.MouseHover, Label21.MouseHover, Label20.MouseHover, Label19.MouseHover, Label18.MouseHover, Label17.MouseHover, Label16.MouseHover, Label15.MouseHover, Label14.MouseHover, Label13.MouseHover, Label12.MouseHover, Label10.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label23_MouseLeave(sender As Object, e As EventArgs) Handles Label24.MouseLeave, Label23.MouseLeave, Label22.MouseLeave, Label21.MouseLeave, Label20.MouseLeave, Label19.MouseLeave, Label18.MouseLeave, Label17.MouseLeave, Label16.MouseLeave, Label15.MouseLeave, Label14.MouseLeave, Label13.MouseLeave, Label12.MouseLeave, Label10.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Label12.Visible = False
        Label3.BackColor = Color.Chocolate
        Label10.Location = New Point(613, Label10.Location.Y)
        check()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label10.Visible = False
        Label3.BackColor = Color.SaddleBrown
        Label12.Location = New Point(613, Label12.Location.Y)
        check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label3.BackColor = Color.Salmon And
            Label4.BackColor = Color.Salmon And
            Label5.BackColor = Color.Salmon And
            Label6.BackColor = Color.Salmon And
            Label7.BackColor = Color.Salmon And
            Label8.BackColor = Color.Salmon And
            Label9.BackColor = Color.Salmon Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            Label10.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            Label24.Visible = True
            Label3.BackColor = Color.Salmon
            Label4.BackColor = Color.Salmon
            Label5.BackColor = Color.Salmon
            Label6.BackColor = Color.Salmon
            Label7.BackColor = Color.Salmon
            Label8.BackColor = Color.Salmon
            Label9.BackColor = Color.Salmon
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
            Label10.Location = New Point(666, Label10.Location.Y)
            Label12.Location = New Point(756, Label12.Location.Y)
            Label14.Location = New Point(666, Label14.Location.Y)
            Label13.Location = New Point(756, Label13.Location.Y)
            Label16.Location = New Point(666, Label16.Location.Y)
            Label15.Location = New Point(756, Label15.Location.Y)
            Label18.Location = New Point(666, Label18.Location.Y)
            Label17.Location = New Point(756, Label17.Location.Y)
            Label20.Location = New Point(666, Label20.Location.Y)
            Label19.Location = New Point(756, Label19.Location.Y)
            Label22.Location = New Point(666, Label22.Location.Y)
            Label21.Location = New Point(756, Label21.Location.Y)
            Label24.Location = New Point(666, Label24.Location.Y)
            Label23.Location = New Point(756, Label23.Location.Y)
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Label13.Visible = False
        Label4.BackColor = Color.Chocolate
        Label14.Location = New Point(613, Label14.Location.Y)
        check()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label14.Visible = False
        Label4.BackColor = Color.SaddleBrown
        Label13.Location = New Point(613, Label13.Location.Y)
        check()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Label15.Visible = False
        Label5.BackColor = Color.Chocolate
        Label16.Location = New Point(543, Label16.Location.Y)
        check()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Label16.Visible = False
        Label5.BackColor = Color.SaddleBrown
        Label15.Location = New Point(543, Label15.Location.Y)
        check()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Label17.Visible = False
        Label6.BackColor = Color.Chocolate
        Label18.Location = New Point(582, Label18.Location.Y)
        check()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Label18.Visible = False
        Label6.BackColor = Color.SaddleBrown
        Label17.Location = New Point(582, Label17.Location.Y)
        check()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Label19.Visible = False
        Label7.BackColor = Color.Chocolate
        Label20.Location = New Point(461, Label19.Location.Y)
        check()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Label20.Visible = False
        Label7.BackColor = Color.SaddleBrown
        Label19.Location = New Point(461, Label19.Location.Y)
        check()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Label21.Visible = False
        Label8.BackColor = Color.Chocolate
        Label22.Location = New Point(541, Label22.Location.Y)
        check()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Label22.Visible = False
        Label8.BackColor = Color.SaddleBrown
        Label21.Location = New Point(541, Label21.Location.Y)
        check()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Label23.Visible = False
        Label9.BackColor = Color.Chocolate
        Label24.Location = New Point(556, Label24.Location.Y)
        check()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Label24.Visible = False
        Label9.BackColor = Color.SaddleBrown
        Label23.Location = New Point(556, Label23.Location.Y)
        check()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound5.Stop()
        Me.Hide()
        Theory6.Show()
    End Sub

    Private Sub check()
        If Label3.BackColor = Color.Salmon Or
            Label4.BackColor = Color.Salmon Or
            Label5.BackColor = Color.Salmon Or
            Label6.BackColor = Color.Salmon Or
            Label7.BackColor = Color.Salmon Or
            Label8.BackColor = Color.Salmon Or
            Label9.BackColor = Color.Salmon Then

        Else
            If Label3.BackColor = Color.Chocolate Then
                'MessageBox.Show("1-correct")
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            Else
                ' MessageBox.Show("1-wrong")
                PictureBox5.Visible = True
                PictureBox4.Visible = False
            End If
            If Label4.BackColor = Color.Chocolate Then
                ' MessageBox.Show("2-correct")
                PictureBox7.Visible = True
                PictureBox6.Visible = False
            Else
                ' MessageBox.Show("2-wrong")
                PictureBox6.Visible = True
                PictureBox7.Visible = False
            End If
            If Label5.BackColor = Color.Chocolate Then
                ' MessageBox.Show("3-correct")
                PictureBox9.Visible = True
                PictureBox8.Visible = False
            Else
                ' MessageBox.Show("3-wrong")
                PictureBox8.Visible = True
                PictureBox9.Visible = False
            End If
            If Label6.BackColor = Color.Chocolate Then
                '  MessageBox.Show("4-correct")
                PictureBox11.Visible = True
                PictureBox10.Visible = False
            Else
                '  MessageBox.Show("4-wrong")
                PictureBox10.Visible = True
                PictureBox11.Visible = False
            End If
            If Label7.BackColor = Color.Chocolate Then
                ' MessageBox.Show("5-correct")
                PictureBox13.Visible = True
                PictureBox12.Visible = False
            Else
                '  MessageBox.Show("5-wrong")
                PictureBox12.Visible = True
                PictureBox13.Visible = False
            End If
            If Label8.BackColor = Color.Chocolate Then
                ' MessageBox.Show("6-correct")
                PictureBox15.Visible = True
                PictureBox14.Visible = False
            Else
                ' MessageBox.Show("6-wrong")
                PictureBox14.Visible = True
                PictureBox15.Visible = False
            End If
            If Label3.BackColor = Color.Chocolate Then
                'MessageBox.Show("7-correct")
                PictureBox17.Visible = True
                PictureBox16.Visible = False
            Else
                'MessageBox.Show("7-wrong")
                PictureBox16.Visible = True
                PictureBox17.Visible = False
            End If
            If Label3.BackColor = Color.Chocolate And
           Label4.BackColor = Color.Chocolate And
           Label5.BackColor = Color.Chocolate And
           Label6.BackColor = Color.Chocolate And
           Label7.BackColor = Color.Chocolate And
           Label8.BackColor = Color.Chocolate And
           Label9.BackColor = Color.Chocolate Then
                MessageBox.Show("සුභ පැතුම් ඔබ ව්‍යාපාරයක ගති ලක්ෂණ හදුනා ගන්නා ලදී.")
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound5.Stop()
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound5.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory6.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub
End Class