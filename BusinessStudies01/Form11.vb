Public Class Form11

    Dim lab As Label
    Dim lab2 As Label
    Dim test
    Dim value

    Dim audiofile As String = "Kriyakarakam5.1.wav"
    Dim sound9 As New Media.SoundPlayer(audiofile)
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound9.Play()
    End Sub

    Private Sub Label16_MouseHover(sender As Object, e As EventArgs)
        'Panel1.Visible = True
    End Sub

    Private Sub Label16_MouseLeave(sender As Object, e As EventArgs)
        'Panel1.Visible = False
    End Sub


    Private Sub Label17_MouseDown(sender As Object, e As MouseEventArgs) Handles Label29.MouseDown, Label28.MouseDown, Label27.MouseDown, Label26.MouseDown, Label25.MouseDown, Label24.MouseDown, Label23.MouseDown, Label22.MouseDown, Label21.MouseDown, Label20.MouseDown, Label19.MouseDown, Label18.MouseDown, Label17.MouseDown, Label16.MouseDown
        Panel1.Visible = True
        lab = CType(sender, Label)
        'MessageBox.Show(lab.ToString())

        Try
            If test.text = value Then
                test.BackColor = Color.DarkOrange
            End If
        Catch ex As Exception

        End Try

        lab.BackColor = Color.Yellow
        test = lab
        value = lab.Text

    End Sub


    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown, Label8.MouseDown, Label7.MouseDown, Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label15.MouseDown, Label14.MouseDown, Label12.MouseDown, Label11.MouseDown, Label10.MouseDown, Label1.MouseDown
        Panel1.Visible = False
        lab2 = CType(sender, Label)
        test.Text = lab2.Text
        test.Enabled = False
        lab.BackColor = Color.DarkBlue
        lab2.Visible = False
        check()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Label16.Text = "අයිතම 1" And Label17.Text = "අයිතම 2" And
            Label18.Text = "අයිතම 3" And Label19.Text = "අයිතම 4" And
            Label20.Text = "අයිතම 5" And Label21.Text = "අයිතම 6" And
            Label22.Text = "අයිතම 7" And Label23.Text = "අයිතම 8" And
            Label24.Text = "අයිතම 9" And Label25.Text = "අයිතම 10" And
            Label26.Text = "අයිතම 11" And Label27.Text = "අයිතම 12" And
            Label28.Text = "අයිතම 13" And Label29.Text = "අයිතම 14" Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            Label16.Text = "අයිතම 1"
            Label17.Text = "අයිතම 2"
            Label18.Text = "අයිතම 3"
            Label19.Text = "අයිතම 4"
            Label20.Text = "අයිතම 5"
            Label21.Text = "අයිතම 6"
            Label22.Text = "අයිතම 7"
            Label23.Text = "අයිතම 8"
            Label24.Text = "අයිතම 9"
            Label25.Text = "අයිතම 10"
            Label26.Text = "අයිතම 11"
            Label27.Text = "අයිතම 12"
            Label28.Text = "අයිතම 13"
            Label29.Text = "අයිතම 14"

            Label16.Enabled = True
            Label17.Enabled = True
            Label18.Enabled = True
            Label19.Enabled = True
            Label20.Enabled = True
            Label21.Enabled = True
            Label22.Enabled = True
            Label23.Enabled = True
            Label24.Enabled = True
            Label25.Enabled = True
            Label26.Enabled = True
            Label27.Enabled = True
            Label28.Enabled = True
            Label29.Enabled = True

            Label16.BackColor = Color.DarkOrange
            Label17.BackColor = Color.DarkOrange
            Label18.BackColor = Color.DarkOrange
            Label19.BackColor = Color.DarkOrange
            Label20.BackColor = Color.DarkOrange
            Label21.BackColor = Color.DarkOrange
            Label22.BackColor = Color.DarkOrange
            Label23.BackColor = Color.DarkOrange
            Label24.BackColor = Color.DarkOrange
            Label25.BackColor = Color.DarkOrange
            Label26.BackColor = Color.DarkOrange
            Label27.BackColor = Color.DarkOrange
            Label28.BackColor = Color.DarkOrange
            Label29.BackColor = Color.DarkOrange

            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True

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
            PictureBox24.Visible = False
            PictureBox25.Visible = False
            PictureBox26.Visible = False
            PictureBox27.Visible = False
            PictureBox28.Visible = False
            PictureBox29.Visible = False
            PictureBox30.Visible = False
            PictureBox31.Visible = False
            PictureBox32.Visible = False
            PictureBox33.Visible = False
            PictureBox34.Visible = False
            PictureBox35.Visible = False
            PictureBox36.Visible = False
        End If
    End Sub

    Private Sub Label25_MouseHover(sender As Object, e As EventArgs) Handles Label29.MouseHover, Label28.MouseHover, Label27.MouseHover, Label26.MouseHover, Label25.MouseHover, Label24.MouseHover, Label23.MouseHover, Label22.MouseHover, Label21.MouseHover, Label20.MouseHover, Label19.MouseHover, Label18.MouseHover, Label17.MouseHover, Label16.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label25_MouseLeave(sender As Object, e As EventArgs) Handles Label29.MouseLeave, Label28.MouseLeave, Label27.MouseLeave, Label26.MouseLeave, Label25.MouseLeave, Label24.MouseLeave, Label23.MouseLeave, Label22.MouseLeave, Label21.MouseLeave, Label20.MouseLeave, Label19.MouseLeave, Label18.MouseLeave, Label17.MouseLeave, Label16.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover, Label8.MouseHover, Label7.MouseHover, Label6.MouseHover, Label5.MouseHover, Label4.MouseHover, Label3.MouseHover, Label2.MouseHover, Label15.MouseHover, Label14.MouseHover, Label12.MouseHover, Label11.MouseHover, Label10.MouseHover, Label1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave, Label8.MouseLeave, Label7.MouseLeave, Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label15.MouseLeave, Label14.MouseLeave, Label12.MouseLeave, Label11.MouseLeave, Label10.MouseLeave, Label1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub check()
        If Label16.Text = "අයිතම 1" Or Label17.Text = "අයිතම 2" Or
            Label18.Text = "අයිතම 3" Or Label19.Text = "අයිතම 4" Or
            Label20.Text = "අයිතම 5" Or Label21.Text = "අයිතම 6" Or
            Label22.Text = "අයිතම 7" Or Label23.Text = "අයිතම 8" Or
            Label24.Text = "අයිතම 9" Or Label25.Text = "අයිතම 10" Or
            Label26.Text = "අයිතම 11" Or Label27.Text = "අයිතම 12" Or
            Label28.Text = "අයිතම 13" Or Label29.Text = "අයිතම 14" Then

        Else

            If Label16.Text = "වාණිජ්‍යය" Then
                'MessageBox.Show("Correct 1")
                PictureBox10.Visible = True
                PictureBox9.Visible = False
            Else
                'MessageBox.Show("Wrong 1")
                PictureBox9.Visible = True
                PictureBox10.Visible = False
            End If
            If Label17.Text = "වෙළෙදාම" Then
                'MessageBox.Show("Correct 2")
                PictureBox36.Visible = True
                PictureBox35.Visible = False
            Else
                'MessageBox.Show("Wrong 2")
                PictureBox35.Visible = True
                PictureBox36.Visible = False
            End If
            If Label18.Text = "උපකාරක සේවා" Then
                'MessageBox.Show("Correct 3")
                PictureBox12.Visible = True
                PictureBox11.Visible = False
            Else
                'MessageBox.Show("Wrong 3")
                PictureBox11.Visible = True
                PictureBox12.Visible = False
            End If
            If Label19.Text = "දේශීය" Then
                'MessageBox.Show("Correct 4")
                PictureBox34.Visible = True
                PictureBox33.Visible = False
            Else
                'MessageBox.Show("Wrong 4")
                PictureBox33.Visible = True
                PictureBox34.Visible = False
            End If
            If Label20.Text = "විදේශීය" Then
                'MessageBox.Show("Correct 5")
                PictureBox32.Visible = True
                PictureBox31.Visible = False
            Else
                'MessageBox.Show("Wrong 5")
                PictureBox31.Visible = True
                PictureBox32.Visible = False
            End If
            If Label21.Text = "බැංකු" Or Label21.Text = "ප්‍රවාහනය" Or Label21.Text = "රක්ෂණය" Or Label21.Text = "සන්නිවේදනය" Or Label21.Text = "ගබඩාකරණය" Then
                'MessageBox.Show("Correct 6")
                PictureBox14.Visible = True
                PictureBox13.Visible = False
            Else
                'MessageBox.Show("Wrong 6")
                PictureBox13.Visible = True
                PictureBox14.Visible = False
            End If
            If Label22.Text = "බැංකු" Or Label22.Text = "ප්‍රවාහනය" Or Label22.Text = "රක්ෂණය" Or Label22.Text = "සන්නිවේදනය" Or Label22.Text = "ගබඩාකරණය" Then
                'MessageBox.Show("Correct 7")
                PictureBox16.Visible = True
                PictureBox15.Visible = False
            Else
                'MessageBox.Show("Wrong 8")
                PictureBox15.Visible = True
                PictureBox16.Visible = False
            End If
            If Label23.Text = "බැංකු" Or Label23.Text = "ප්‍රවාහනය" Or Label23.Text = "රක්ෂණය" Or Label23.Text = "සන්නිවේදනය" Or Label23.Text = "ගබඩාකරණය" Then
                'MessageBox.Show("Correct 9")
                PictureBox18.Visible = True
                PictureBox17.Visible = False
            Else
                'MessageBox.Show("Wrong 9")
                PictureBox17.Visible = True
                PictureBox18.Visible = False
            End If
            If Label24.Text = "බැංකු" Or Label24.Text = "ප්‍රවාහනය" Or Label24.Text = "රක්ෂණය" Or Label24.Text = "සන්නිවේදනය" Or Label24.Text = "ගබඩාකරණය" Then
                'MessageBox.Show("Correct 10")
                PictureBox20.Visible = True
                PictureBox19.Visible = False
            Else
                'MessageBox.Show("Wrong 10")
                PictureBox19.Visible = True
                PictureBox20.Visible = False
            End If
            If Label25.Text = "බැංකු" Or Label25.Text = "ප්‍රවාහනය" Or Label25.Text = "රක්ෂණය" Or Label25.Text = "සන්නිවේදනය" Or Label25.Text = "ගබඩාකරණය" Then
                'MessageBox.Show("Correct 11")
                PictureBox22.Visible = True
                PictureBox21.Visible = False
            Else
                'MessageBox.Show("Wrong 11")
                PictureBox21.Visible = True
                PictureBox22.Visible = False
            End If
            If Label26.Text = "සිල්ලර 
වෙළෙදාම" Or Label26.Text = "තොග 
වෙළෙදාම" Then
                'MessageBox.Show("Correct 12")
                PictureBox30.Visible = True
                PictureBox29.Visible = False
            Else
                'MessageBox.Show("Wrong 12")
                PictureBox29.Visible = True
                PictureBox30.Visible = False
            End If
            If Label27.Text = "තොග 
වෙළෙදාම" Or Label27.Text = "සිල්ලර 
වෙළෙදාම" Then
                'MessageBox.Show("Correct 13")
                PictureBox28.Visible = True
                PictureBox27.Visible = False
            Else
                'MessageBox.Show("Wrong 13")
                PictureBox27.Visible = True
                PictureBox28.Visible = False
            End If
            If Label28.Text = "ආනයන 
වෙළෙදාම" Or Label28.Text = "අපනයන 
වෙළෙදාම" Then
                'MessageBox.Show("Correct 14")
                PictureBox26.Visible = True
                PictureBox25.Visible = False
            Else
                'MessageBox.Show("Wrong 14")
                PictureBox25.Visible = True
                PictureBox26.Visible = False
            End If
            If Label29.Text = "අපනයන 
වෙළෙදාම" Or Label29.Text = "ආනයන 
වෙළෙදාම" Then
                'MessageBox.Show("Correct 15")
                PictureBox24.Visible = True
                PictureBox23.Visible = False
            Else
                'MessageBox.Show("Wrong 15")
                PictureBox23.Visible = True
                PictureBox24.Visible = False
            End If
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound9.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound9.Stop()
        Me.Hide()
        Theory8.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        sound9.Stop()
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory8.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub
End Class