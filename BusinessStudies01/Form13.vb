Public Class Form13

    Dim lab2 As Label
    Dim value

    Dim audiofile As String = "Kriyakarakam6.1.wav"
    Dim sound11 As New Media.SoundPlayer(audiofile)
    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover, Button4.MouseHover, Button3.MouseHover, Button2.MouseHover, Button1.MouseHover
        Cursor = Cursors.Hand
        sender.backcolor = Color.Green

        Try
            value.backcolor = Color.YellowGreen
        Catch ex As Exception

        End Try

        value = sender
    End Sub

    'Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button1.MouseLeave
    '    Cursor = Cursors.Default
    '    sender.backcolor = Color.YellowGreen
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabPage1.Visible = True
        TabPage2.Visible = False
        TabPage3.Visible = False
        TabPage4.Visible = False
        TabPage5.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabPage2.Visible = True
        TabPage1.Visible = False
        TabPage3.Visible = False
        TabPage4.Visible = False
        TabPage5.Visible = False
    End Sub

    Private Sub Label5_DragEnter(sender As Object, e As DragEventArgs) Handles Label7.DragEnter, Label6.DragEnter, Label5.DragEnter, Label9.DragEnter, Label10.DragEnter, Label15.DragEnter, Label16.DragEnter, Label19.DragEnter, Label20.DragEnter, Label22.DragEnter, Label23.DragEnter, Label25.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Label5_DragDrop(sender As Object, e As DragEventArgs) Handles Label7.DragDrop, Label6.DragDrop, Label5.DragDrop, Label9.DragDrop, Label10.DragDrop, Label15.DragDrop, Label16.DragDrop, Label19.DragDrop, Label20.DragDrop, Label22.DragDrop, Label23.DragDrop, Label25.DragDrop
        sender.Text = e.Data.GetData(DataFormats.Text)
        lab2.Visible = False
        sender.AllowDrop = False
        sender.Backcolor = Color.YellowGreen
        If Label5.BackColor = Color.YellowGreen And Label6.BackColor = Color.YellowGreen And
            Label7.BackColor = Color.YellowGreen And Label10.BackColor = Color.YellowGreen And
            Label9.BackColor = Color.YellowGreen And Label16.BackColor = Color.YellowGreen And
            Label15.BackColor = Color.YellowGreen And Label20.BackColor = Color.YellowGreen And
            Label19.BackColor = Color.YellowGreen And Label23.BackColor = Color.YellowGreen And
            Label22.BackColor = Color.YellowGreen And Label25.BackColor = Color.YellowGreen Then
            check()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabPage3.Visible = True
        TabPage1.Visible = False
        TabPage4.Visible = False
        TabPage2.Visible = False
        TabPage5.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabPage4.Visible = True
        TabPage1.Visible = False
        TabPage3.Visible = False
        TabPage2.Visible = False
        TabPage5.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabPage5.Visible = True
        TabPage1.Visible = False
        TabPage3.Visible = False
        TabPage2.Visible = False
        TabPage4.Visible = False
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown, Label4.MouseDown, Label30.MouseDown, Label3.MouseDown, Label29.MouseDown, Label28.MouseDown, Label27.MouseDown, Label26.MouseDown, Label2.MouseDown, Label18.MouseDown, Label14.MouseDown, Label12.MouseDown
        lab2 = CType(sender, Label)
        lab2.DoDragDrop(lab2.Text, DragDropEffects.Copy)
        sender.backcolor = Color.Red
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If Label2.BackColor = Color.Green And Label3.BackColor = Color.Green And
            Label4.BackColor = Color.Green And Label8.BackColor = Color.Green And
            Label12.BackColor = Color.Green And Label18.BackColor = Color.Green And
            Label14.BackColor = Color.Green And Label26.BackColor = Color.Green And
            Label27.BackColor = Color.Green And Label28.BackColor = Color.Green And
            Label29.BackColor = Color.Green And Label30.BackColor = Color.Green And
            Label2.Visible = True And Label3.Visible = True And Label4.Visible = True And
            Label8.Visible = True And Label12.Visible = True And Label18.Visible = True And
            Label14.Visible = True And Label26.Visible = True And Label27.Visible = True And
            Label28.Visible = True And Label29.Visible = True And Label30.Visible = True Then

            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")

        Else
            Label2.BackColor = Color.Green
            Label3.BackColor = Color.Green
            Label4.BackColor = Color.Green

            Label8.BackColor = Color.Green
            Label12.BackColor = Color.Green
            Label18.BackColor = Color.Green

            Label14.BackColor = Color.Green
            Label26.BackColor = Color.Green
            Label27.BackColor = Color.Green

            Label28.BackColor = Color.Green
            Label29.BackColor = Color.Green
            Label30.BackColor = Color.Green

            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True

            Label8.Visible = True
            Label12.Visible = True
            Label18.Visible = True

            Label14.Visible = True
            Label26.Visible = True
            Label27.Visible = True

            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True

            Label5.Text = "අයිතම 1"
            Label6.Text = "අයිතම 2"
            Label7.Text = "අයිතම 3"
            Label5.BackColor = Color.Green
            Label6.BackColor = Color.Green
            Label7.BackColor = Color.Green
            Label5.AllowDrop = True
            Label6.AllowDrop = True
            Label7.AllowDrop = True

            Label10.Text = "අයිතම 1"
            Label9.Text = "අයිතම 2"
            Label10.BackColor = Color.Green
            Label9.BackColor = Color.Green
            Label10.AllowDrop = True
            Label9.AllowDrop = True


            Label16.Text = "අයිතම 1"
            Label15.Text = "අයිතම 2"
            Label16.BackColor = Color.Green
            Label15.BackColor = Color.Green
            Label16.AllowDrop = True
            Label15.AllowDrop = True

            Label20.Text = "අයිතම 1"
            Label19.Text = "අයිතම 2"
            Label20.BackColor = Color.Green
            Label19.BackColor = Color.Green
            Label20.AllowDrop = True
            Label19.AllowDrop = True

            Label23.Text = "අයිතම 1"
            Label22.Text = "අයිතම 2"
            Label25.Text = "අයිතම 3"
            Label23.BackColor = Color.Green
            Label22.BackColor = Color.Green
            Label25.BackColor = Color.Green
            Label23.AllowDrop = True
            Label22.AllowDrop = True
            Label25.AllowDrop = True

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
        End If



    End Sub


    Private Sub check()
        If Label5.Text = "ප්‍රාථමික" Or Label5.Text = "ද්වීතීයක" Or Label5.Text = "තෘතීයික" Then
            'MessageBox.Show("Correct 1")
            PictureBox10.Visible = True
            PictureBox9.Visible = False
        Else
            'MessageBox.Show("Wrong 1")
            PictureBox9.Visible = True
            PictureBox10.Visible = False
        End If
        If Label6.Text = "ප්‍රාථමික" Or Label6.Text = "ද්වීතීයක" Or Label6.Text = "තෘතීයික" Then
            'MessageBox.Show("Correct 2")
            PictureBox12.Visible = True
            PictureBox11.Visible = False
        Else
            'MessageBox.Show("Wrong 2")
            PictureBox11.Visible = True
            PictureBox12.Visible = False
        End If
        If Label7.Text = "ප්‍රාථමික" Or Label7.Text = "ද්වීතීයක" Or Label7.Text = "තෘතීයික" Then
            'MessageBox.Show("Correct 3")
            PictureBox14.Visible = True
            PictureBox13.Visible = False
        Else
            ' MessageBox.Show("Wrong 3")
            PictureBox13.Visible = True
            PictureBox14.Visible = False
        End If


        If Label10.Text = "පෞද්ගලික" Or Label10.Text = "පොදු" Then
            'MessageBox.Show("Correct 4")
            PictureBox16.Visible = True
            PictureBox15.Visible = False
        Else
            'MessageBox.Show("Wrong 4")
            PictureBox15.Visible = True
            PictureBox16.Visible = False
        End If
        If Label9.Text = "පෞද්ගලික" Or Label9.Text = "පොදු" Then
            'MessageBox.Show("Correct 5")
            PictureBox18.Visible = True
            PictureBox17.Visible = False
        Else
            'MessageBox.Show("Wrong 5")
            PictureBox17.Visible = True
            PictureBox18.Visible = False
        End If



        If Label16.Text = "ලාභ අරමුණු කර නොගත්" Or Label16.Text = "ලාභ අරමුණු කරගත්" Then
            'MessageBox.Show("Correct 6")
            PictureBox20.Visible = True
            PictureBox19.Visible = False
        Else
            'MessageBox.Show("Wrong 6")
            PictureBox19.Visible = True
            PictureBox20.Visible = False
        End If
        If Label15.Text = "ලාභ අරමුණු කර නොගත්" Or Label15.Text = "ලාභ අරමුණු කරගත්" Then
            'MessageBox.Show("Correct 7")
            PictureBox22.Visible = True
            PictureBox21.Visible = False
        Else
            'MessageBox.Show("Wrong 7")
            PictureBox21.Visible = True
            PictureBox22.Visible = False
        End If


        If Label20.Text = "සුළු හා මධ්‍ය පරිමාණ" Or Label20.Text = "මහා පරිමාණ" Then
            'MessageBox.Show("Correct 8")
            PictureBox24.Visible = True
            PictureBox23.Visible = False
        Else
            'MessageBox.Show("Wrong 8")
            PictureBox23.Visible = True
            PictureBox24.Visible = False
        End If
        If Label19.Text = "සුළු හා මධ්‍ය පරිමාණ" Or Label19.Text = "මහා පරිමාණ" Then
            'MessageBox.Show("Correct 9")
            PictureBox26.Visible = True
            PictureBox25.Visible = False
        Else
            'MessageBox.Show("Wrong 9")
            PictureBox25.Visible = True
            PictureBox26.Visible = False
        End If


        If Label23.Text = "කාර්මික" Or Label23.Text = "කෘෂිකාර්මික" Or Label23.Text = "සේවා" Then
            'MessageBox.Show("Correct 10")
            PictureBox28.Visible = True
            PictureBox27.Visible = False
        Else
            'MessageBox.Show("Wrong 10")
            PictureBox27.Visible = True
            PictureBox28.Visible = False
        End If
        If Label22.Text = "කාර්මික" Or Label22.Text = "කෘෂිකාර්මික" Or Label22.Text = "සේවා" Then
            'MessageBox.Show("Correct 11")
            PictureBox30.Visible = True
            PictureBox29.Visible = False
        Else
            'MessageBox.Show("Wrong 11")
            PictureBox29.Visible = True
            PictureBox30.Visible = False
        End If
        If Label25.Text = "කාර්මික" Or Label25.Text = "කෘෂිකාර්මික" Or Label25.Text = "සේවා" Then
            'MessageBox.Show("Correct 12")
            PictureBox32.Visible = True
            PictureBox31.Visible = False
        Else
            'MessageBox.Show("Wrong 12")
            PictureBox31.Visible = True
            PictureBox32.Visible = False
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Theory9.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        sound11.Stop()
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound11.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound11.Stop()
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button5.MouseDown, Button4.MouseDown, Button3.MouseDown, Button2.MouseDown, Button1.MouseDown


    End Sub

    Private Sub Label12_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover, Label4.MouseHover, Label30.MouseHover, Label3.MouseHover, Label29.MouseHover, Label28.MouseHover, Label27.MouseHover, Label26.MouseHover, Label2.MouseHover, Label18.MouseHover, Label14.MouseHover, Label12.MouseHover
        Cursor = Cursors.Hand
        sender.backcolor = Color.Yellow

        Try
            If value.visible = True Then
                value.backcolor = Color.Green
            End If
        Catch ex As Exception

        End Try

        value = sender
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound11.Play()
    End Sub
End Class