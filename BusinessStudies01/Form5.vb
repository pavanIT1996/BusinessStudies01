Public Class Form5
    Public L As Label

    Dim audiofile As String = "Kriyakarakam2.1.wav"
    Dim sound3 As New Media.SoundPlayer(audiofile)

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox9.DragDrop, TextBox8.DragDrop, TextBox7.DragDrop, TextBox6.DragDrop, TextBox5.DragDrop, TextBox4.DragDrop, TextBox3.DragDrop, TextBox2.DragDrop, TextBox10.DragDrop, TextBox1.DragDrop
        sound3.Play()

        sender.Text = e.Data.GetData(DataFormats.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Or
            TextBox3.Text = "" Or TextBox4.Text = "" Or
            TextBox5.Text = "" Or TextBox6.Text = "" Or
            TextBox7.Text = "" Or TextBox8.Text = "" Or
            TextBox9.Text = "" Or TextBox10.Text = "" Then
        Else
            Check()
            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
            Panel8.Visible = False
            Panel9.Visible = False
            Panel10.Visible = False
            Label3.ForeColor = Color.Blue
            Label4.ForeColor = Color.Blue
            Label5.ForeColor = Color.Blue
            TextBox1.AllowDrop = False
            TextBox2.AllowDrop = False
            TextBox3.AllowDrop = False
            TextBox4.AllowDrop = False
            TextBox5.AllowDrop = False
            TextBox6.AllowDrop = False
            TextBox7.AllowDrop = False
            TextBox8.AllowDrop = False
            TextBox9.AllowDrop = False
            TextBox10.AllowDrop = False
        End If

    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox9.DragEnter, TextBox8.DragEnter, TextBox7.DragEnter, TextBox6.DragEnter, TextBox5.DragEnter, TextBox4.DragEnter, TextBox3.DragEnter, TextBox2.DragEnter, TextBox10.DragEnter, TextBox1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And
            TextBox3.Text = "" And TextBox4.Text = "" And
            TextBox5.Text = "" And TextBox6.Text = "" And
            TextBox7.Text = "" And TextBox8.Text = "" And
            TextBox9.Text = "" And TextBox10.Text = "" Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
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
            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            Panel1.Visible = True
            Panel2.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = True
            Panel7.Visible = True
            Panel8.Visible = True
            Panel9.Visible = True
            Panel10.Visible = True
            Label3.ForeColor = DefaultForeColor
            Label4.ForeColor = DefaultForeColor
            Label5.ForeColor = DefaultForeColor
            TextBox1.AllowDrop = True
            TextBox2.AllowDrop = True
            TextBox3.AllowDrop = True
            TextBox4.AllowDrop = True
            TextBox5.AllowDrop = True
            TextBox6.AllowDrop = True
            TextBox7.AllowDrop = True
            TextBox8.AllowDrop = True
            TextBox9.AllowDrop = True
            TextBox10.AllowDrop = True

        End If
    End Sub

    Private Sub Label32_MouseDown(sender As Object, e As MouseEventArgs) Handles Label32.MouseDown, Label31.MouseDown, Label30.MouseDown, Label29.MouseDown, Label28.MouseDown, Label27.MouseDown, Label2.MouseDown, Label1.MouseDown
        L = CType(sender, Label)
        L.DoDragDrop(L.Text, DragDropEffects.Copy)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover, PictureBox2.MouseHover, PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound3.Stop()
        Me.Hide()
        Theory5.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound3.Stop()
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Check()
        If TextBox1.Text = "" Then
        Else
            If TextBox1.Text = "නිෂ්පාදිත" Then
                'MessageBox.Show("1-Correct")
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            Else
                'MessageBox.Show("1-Wrong")
                PictureBox5.Visible = True
                PictureBox4.Visible = False
            End If
        End If
        If TextBox2.Text = "" Then
        Else
            If TextBox2.Text = "අවශ්‍යතා" Then
                'MessageBox.Show("2-Correct")
                PictureBox7.Visible = True
                PictureBox6.Visible = False
            Else
                'MessageBox.Show("2-Wrong")
                PictureBox6.Visible = True
                PictureBox7.Visible = False
            End If
        End If
        If TextBox3.Text = "" Then
        Else
            If TextBox3.Text = "වුවමනා" Then
                'MessageBox.Show("3-Correct")
                PictureBox9.Visible = True
                PictureBox8.Visible = False
            Else
                'MessageBox.Show("3-Wrong")
                PictureBox8.Visible = True
                PictureBox9.Visible = False
            End If
        End If
        If TextBox4.Text = "" Then
        Else
            If TextBox4.Text = "වෙළෙදපොළ" Then
                'MessageBox.Show("4-Correct")
                PictureBox11.Visible = True
                PictureBox10.Visible = False
            Else
                'MessageBox.Show("4-Wrong")
                PictureBox10.Visible = True
                PictureBox11.Visible = False
            End If
        End If
        If TextBox5.Text = "" Then
        Else
            If TextBox5.Text = "වෙළෙදපොළ" Then
                'MessageBox.Show("5-Correct")
                PictureBox13.Visible = True
                PictureBox12.Visible = False
            Else
                'MessageBox.Show("5-Wrong")
                PictureBox12.Visible = True
                PictureBox13.Visible = False
            End If
        End If
        If TextBox6.Text = "" Then
        Else
            If TextBox6.Text = "ගැනුම්කරුවන්" Then
                'MessageBox.Show("6-Correct")
                PictureBox15.Visible = True
                PictureBox14.Visible = False
            Else
                'MessageBox.Show("6-Wrong")
                PictureBox14.Visible = True
                PictureBox15.Visible = False
            End If
        End If
        If TextBox7.Text = "" Then
        Else
            If TextBox7.Text = "විකුණුම්කරුවන්" Then
                'MessageBox.Show("7-Correct")
                PictureBox17.Visible = True
                PictureBox16.Visible = False
            Else
                'MessageBox.Show("7-Wrong")
                PictureBox16.Visible = True
                PictureBox17.Visible = False
            End If
        End If
        If TextBox8.Text = "" Then
        Else
            If TextBox8.Text = "නිෂ්පාදිත" Then
                'MessageBox.Show("8-Correct")
                PictureBox19.Visible = True
                PictureBox18.Visible = False
            Else
                'MessageBox.Show("8-Wrong")
                PictureBox18.Visible = True
                PictureBox19.Visible = False
            End If
        End If
        If TextBox9.Text = "" Then
        Else
            If TextBox9.Text = "භාණ්ඩ" Then
                ' MessageBox.Show("9-Correct")
                PictureBox21.Visible = True
                PictureBox20.Visible = False
            Else
                'MessageBox.Show("9-Wrong")
                PictureBox20.Visible = True
                PictureBox21.Visible = False
            End If
        End If
        If TextBox10.Text = "" Then
        Else
            If TextBox10.Text = "සේවා" Then
                'MessageBox.Show("10-Correct")
                PictureBox23.Visible = True
                PictureBox22.Visible = False
            Else
                ' MessageBox.Show("10-Wrong")
                PictureBox22.Visible = True
                PictureBox23.Visible = False
            End If
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound3.Play()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound3.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory5.Show()
    End Sub

    Private Sub Label32_MouseHover(sender As Object, e As EventArgs) Handles Label32.MouseHover, Label31.MouseHover, Label30.MouseHover, Label29.MouseHover, Label28.MouseHover, Label27.MouseHover, Label2.MouseHover, Label1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label32_MouseLeave(sender As Object, e As EventArgs) Handles Label32.MouseLeave, Label31.MouseLeave, Label30.MouseLeave, Label29.MouseLeave, Label28.MouseLeave, Label27.MouseLeave, Label2.MouseLeave, Label1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub
End Class