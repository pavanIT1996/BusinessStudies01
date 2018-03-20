Public Class Form3
    Dim lab2 As Label
    Dim value
    Dim value2
    Dim count = 0
    Dim count2 = 0
    Dim audiofile As String = "Kriyakarakam1.1.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)
    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover
        Label9.ForeColor = Color.Blue
        Cursor = Cursors.Hand
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = DefaultForeColor
        Cursor = Cursors.Default
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound1.Stop()
        Me.Hide()
        Theory3.Show()
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Cursor = Cursors.Default
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        MessageBox.Show("අවශ්‍යතා යනු මිනිසාගේ පැවැත්ම තහවුරු කරගැනීමට අත්‍යවශයෙන්ම සපුරා ගත යුතු කායික හා මානසික තත්ත්වයන් ය.")
    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Cursor = Cursors.Default
    End Sub
    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        MessageBox.Show("වුවමනා යනු අවශ්‍යතා සපුරා ගත හැකි විවිධ මාර්ගයන් ය.")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound1.Stop()
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover, PictureBox2.MouseHover, PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub


    Private Sub check()

        If Label17.Text = "බත්" Or Label17.Text = "පාන්" Or Label17.Text = "ඉදිආප්ප" Or Label17.Text = "තේ" Then
            'MessageBox.Show("Correct 1")
            Label17.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 1")
            Label17.BackColor = Color.Red
        End If
        If Label18.Text = "බත්" Or Label18.Text = "පාන්" Or Label18.Text = "ඉදිආප්ප" Or Label18.Text = "තේ" Then
            'MessageBox.Show("Correct 2")
            Label18.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 2")
            Label18.BackColor = Color.Red
        End If
        If Label19.Text = "බත්" Or Label19.Text = "පාන්" Or Label19.Text = "ඉදිආප්ප" Or Label19.Text = "තේ" Then
            'MessageBox.Show("Correct 3")
            Label19.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 3")
            Label19.BackColor = Color.Red
        End If
        If Label20.Text = "බත්" Or Label20.Text = "පාන්" Or Label20.Text = "ඉදිආප්ප" Or Label20.Text = "තේ" Then
            'MessageBox.Show("Correct 4")
            Label20.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 4")
            Label20.BackColor = Color.Red
        End If


        If Label21.Text = "ගවුම්" Or Label21.Text = "සාරි" Or Label21.Text = "කලිසම්" Or Label21.Text = "සරම" Then
            'MessageBox.Show("Correct 5")
            Label21.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 5")
            Label21.BackColor = Color.Red
        End If
        If Label22.Text = "ගවුම්" Or Label22.Text = "සාරි" Or Label22.Text = "කලිසම්" Or Label22.Text = "සරම" Then
            'MessageBox.Show("Correct 6")
            Label22.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 6")
            Label22.BackColor = Color.Red
        End If
        If Label23.Text = "ගවුම්" Or Label23.Text = "සාරි" Or Label23.Text = "කලිසම්" Or Label23.Text = "සරම" Then
            'MessageBox.Show("Correct 7")
            Label23.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 7")
            Label23.BackColor = Color.Red
        End If
        If Label2.Text = "ගවුම්" Or Label2.Text = "සාරි" Or Label2.Text = "කලිසම්" Or Label2.Text = "සරම" Then
            'MessageBox.Show("Correct 8")
            Label2.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label2.BackColor = Color.Red
        End If


        If Label48.Text = "තට්ටු නිවාස" Or Label48.Text = "නේවාසිකාගාර" Or Label48.Text = "නිල නිවාස" Or Label48.Text = "යුගල නිවාස" Then
            'MessageBox.Show("Correct 8")
            Label48.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label48.BackColor = Color.Red
        End If
        If Label4.Text = "තට්ටු නිවාස" Or Label4.Text = "නේවාසිකාගාර" Or Label4.Text = "නිල නිවාස" Or Label4.Text = "යුගල නිවාස" Then
            'MessageBox.Show("Correct 8")
            Label4.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label4.BackColor = Color.Red
        End If
        If Label5.Text = "තට්ටු නිවාස" Or Label5.Text = "නේවාසිකාගාර" Or Label5.Text = "නිල නිවාස" Or Label5.Text = "යුගල නිවාස" Then
            'MessageBox.Show("Correct 8")
            Label5.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label5.BackColor = Color.Red
        End If
        If Label6.Text = "තට්ටු නිවාස" Or Label6.Text = "නේවාසිකාගාර" Or Label6.Text = "නිල නිවාස" Or Label6.Text = "යුගල නිවාස" Then
            'MessageBox.Show("Correct 8")
            Label6.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label6.BackColor = Color.Red
        End If



        If Label7.Text = "පාඨමාලා" Or Label7.Text = "පාසල්" Or Label7.Text = "පොත්පත්" Or Label7.Text = "පිරිවෙන්" Then
            'MessageBox.Show("Correct 8")
            Label7.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label7.BackColor = Color.Red
        End If
        If Label8.Text = "පාඨමාලා" Or Label8.Text = "පාසල්" Or Label8.Text = "පොත්පත්" Or Label8.Text = "පිරිවෙන්" Then
            'MessageBox.Show("Correct 8")
            Label8.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label8.BackColor = Color.Red
        End If
        If Label47.Text = "පාඨමාලා" Or Label47.Text = "පාසල්" Or Label47.Text = "පොත්පත්" Or Label47.Text = "පිරිවෙන්" Then
            'MessageBox.Show("Correct 8")
            Label47.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label47.BackColor = Color.Red
        End If
        If Label3.Text = "පාඨමාලා" Or Label3.Text = "පාසල්" Or Label3.Text = "පොත්පත්" Or Label3.Text = "පිරිවෙන්" Then
            'MessageBox.Show("Correct 8")
            Label3.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label3.BackColor = Color.Red
        End If



        If Label56.Text = "බෙහෙත්" Or Label56.Text = "රජයේ රෝහල්" Or Label56.Text = "පෞද්: රෝහල්" Or Label56.Text = "වෛද්‍ය සැත්කම්" Then
            'MessageBox.Show("Correct 8")
            Label56.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label56.BackColor = Color.Red
        End If
        If Label50.Text = "බෙහෙත්" Or Label50.Text = "රජයේ රෝහල්" Or Label50.Text = "පෞද්: රෝහල්" Or Label50.Text = "වෛද්‍ය සැත්කම්" Then
            'MessageBox.Show("Correct 8")
            Label50.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label50.BackColor = Color.Red
        End If
        If Label51.Text = "බෙහෙත්" Or Label51.Text = "රජයේ රෝහල්" Or Label51.Text = "පෞද්: රෝහල්" Or Label51.Text = "වෛද්‍ය සැත්කම්" Then
            'MessageBox.Show("Correct 8")
            Label51.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label51.BackColor = Color.Red
        End If
        If Label52.Text = "බෙහෙත්" Or Label52.Text = "රජයේ රෝහල්" Or Label52.Text = "පෞද්: රෝහල්" Or Label52.Text = "වෛද්‍ය සැත්කම්" Then
            'MessageBox.Show("Correct 8")
            Label52.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label52.BackColor = Color.Red
        End If



        If Label53.Text = "පොලීසිය" Or Label53.Text = "හමුදාව" Or Label53.Text = "ආයුධ" Or Label53.Text = "සුනඛයින්" Then
            'MessageBox.Show("Correct 8")
            Label53.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label53.BackColor = Color.Red
        End If
        If Label54.Text = "පොලීසිය" Or Label54.Text = "හමුදාව" Or Label54.Text = "ආයුධ" Or Label54.Text = "සුනඛයින්" Then
            'MessageBox.Show("Correct 8")
            Label54.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label54.BackColor = Color.Red
        End If
        If Label55.Text = "පොලීසිය" Or Label55.Text = "හමුදාව" Or Label55.Text = "ආයුධ" Or Label55.Text = "සුනඛයින්" Then
            'MessageBox.Show("Correct 8")
            Label55.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label55.BackColor = Color.Red
        End If
        If Label49.Text = "පොලීසිය" Or Label49.Text = "හමුදාව" Or Label49.Text = "ආයුධ" Or Label49.Text = "සුනඛයින්" Then
            'MessageBox.Show("Correct 8")
            Label49.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label49.BackColor = Color.Red
        End If



        If Label58.Text = "දුරකථන" Or Label58.Text = "ෆැක්ස්" Or Label58.Text = "අන්තර්ජාලය" Or Label58.Text = "විද්‍යුත් තැපෑල" Then
            'MessageBox.Show("Correct 8")
            Label58.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label58.BackColor = Color.Red
        End If
        If Label59.Text = "දුරකථන" Or Label59.Text = "ෆැක්ස්" Or Label59.Text = "අන්තර්ජාලය" Or Label59.Text = "විද්‍යුත් තැපෑල" Then
            'MessageBox.Show("Correct 8")
            Label59.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label59.BackColor = Color.Red
        End If
        If Label60.Text = "දුරකථන" Or Label60.Text = "ෆැක්ස්" Or Label60.Text = "අන්තර්ජාලය" Or Label60.Text = "විද්‍යුත් තැපෑල" Then
            'MessageBox.Show("Correct 8")
            Label60.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label60.BackColor = Color.Red
        End If
        If Label57.Text = "දුරකථන" Or Label57.Text = "ෆැක්ස්" Or Label57.Text = "අන්තර්ජාලය" Or Label57.Text = "විද්‍යුත් තැපෑල" Then
            'MessageBox.Show("Correct 8")
            Label57.BackColor = Color.Green
        Else
            'MessageBox.Show("Wrong 8")
            Label57.BackColor = Color.Red
        End If

        MessageBox.Show("රතු පැහැය වැරදි පිලිතුරු සහ කොල පැහැය නිවැරදි පිලිතුරු නිරූපනය කරයි.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Label24.Visible = True And
                Label25.Visible = True And
                Label26.Visible = True And
                Label27.Visible = True And
                Label28.Visible = True And
                Label29.Visible = True And
                Label30.Visible = True And
                Label31.Visible = True And
                Label32.Visible = True And
                Label34.Visible = True And
                Label35.Visible = True And
                Label36.Visible = True And
                Label37.Visible = True And
                Label38.Visible = True And
                Label39.Visible = True And
                Label40.Visible = True And
                Label41.Visible = True And
                Label43.Visible = True And
                Label44.Visible = True And
                Label45.Visible = True And
                Label46.Visible = True And
                Label61.Visible = True And
                Label62.Visible = True And
                Label63.Visible = True And
                Label64.Visible = True And
                Label65.Visible = True And
                Label66.Visible = True Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else


            Label17.Text = "වුවමනා1"
            Label18.Text = "වුවමනා2"
            Label19.Text = "වුවමනා3"
            Label20.Text = "වුවමනා4"
            Label21.Text = "වුවමනා5"
            Label22.Text = "වුවමනා6"
            Label23.Text = "වුවමනා7"
            Label2.Text = "වුවමනා8"
            Label48.Text = "වුවමනා9"
            Label4.Text = "වුවමනා10"
            Label5.Text = "වුවමනා11"
            Label6.Text = "වුවමනා12"
            Label7.Text = "වුවමනා13"
            Label8.Text = "වුවමනා14"
            Label47.Text = "වුවමනා15"
            Label3.Text = "වුවමනා16"
            Label56.Text = "වුවමනා17"
            Label50.Text = "වුවමනා18"
            Label51.Text = "වුවමනා19"
            Label52.Text = "වුවමනා20"
            Label53.Text = "වුවමනා21"
            Label54.Text = "වුවමනා22"
            Label55.Text = "වුවමනා23"
            Label49.Text = "වුවමනා24"
            Label58.Text = "වුවමනා25"
            Label59.Text = "වුවමනා26"
            Label60.Text = "වුවමනා27"
            Label57.Text = "වුවමනා28"

            Label17.BackColor = Color.Orange
            Label18.BackColor = Color.Orange
            Label19.BackColor = Color.Orange
            Label20.BackColor = Color.Orange
            Label21.BackColor = Color.Orange
            Label22.BackColor = Color.Orange
            Label23.BackColor = Color.Orange
            Label2.BackColor = Color.Orange
            Label48.BackColor = Color.Orange
            Label4.BackColor = Color.Orange
            Label5.BackColor = Color.Orange
            Label6.BackColor = Color.Orange
            Label7.BackColor = Color.Orange
            Label8.BackColor = Color.Orange
            Label47.BackColor = Color.Orange
            Label3.BackColor = Color.Orange
            Label56.BackColor = Color.Orange
            Label50.BackColor = Color.Orange
            Label51.BackColor = Color.Orange
            Label52.BackColor = Color.Orange
            Label53.BackColor = Color.Orange
            Label54.BackColor = Color.Orange
            Label55.BackColor = Color.Orange
            Label49.BackColor = Color.Orange
            Label58.BackColor = Color.Orange
            Label59.BackColor = Color.Orange
            Label60.BackColor = Color.Orange
            Label57.BackColor = Color.Orange

            Label17.AllowDrop = True
            Label18.AllowDrop = True
            Label19.AllowDrop = True
            Label20.AllowDrop = True
            Label21.AllowDrop = True
            Label22.AllowDrop = True
            Label23.AllowDrop = True
            Label2.AllowDrop = True
            Label48.AllowDrop = True
            Label4.AllowDrop = True
            Label5.AllowDrop = True
            Label6.AllowDrop = True
            Label7.AllowDrop = True
            Label8.AllowDrop = True
            Label47.AllowDrop = True
            Label3.AllowDrop = True
            Label56.AllowDrop = True
            Label50.AllowDrop = True
            Label51.AllowDrop = True
            Label52.AllowDrop = True
            Label53.AllowDrop = True
            Label54.AllowDrop = True
            Label55.AllowDrop = True
            Label49.AllowDrop = True
            Label58.AllowDrop = True
            Label59.AllowDrop = True
            Label60.AllowDrop = True
            Label57.AllowDrop = True

            Label24.Visible = True
            Label25.Visible = True
            Label26.Visible = True
            Label27.Visible = True
            Label28.Visible = True
            Label29.Visible = True
            Label30.Visible = True
            Label31.Visible = True
            Label32.Visible = True
            Label34.Visible = True
            Label35.Visible = True
            Label36.Visible = True
            Label37.Visible = True
            Label38.Visible = True
            Label39.Visible = True
            Label40.Visible = True
            Label41.Visible = True
            Label42.Visible = True
            Label43.Visible = True
            Label44.Visible = True
            Label45.Visible = True
            Label46.Visible = True
            Label61.Visible = True
            Label62.Visible = True
            Label63.Visible = True
            Label64.Visible = True
            Label65.Visible = True
            Label66.Visible = True



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory3.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound1.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If Label17.Text = "වුවමනා1" Or
            Label18.Text = "වුවමනා2" Or
            Label19.Text = "වුවමනා3" Or
            Label20.Text = "වුවමනා4" Or
            Label21.Text = "වුවමනා5" Or
            Label22.Text = "වුවමනා6" Or
            Label23.Text = "වුවමනා7" Or
            Label2.Text = "වුවමනා8" Or
            Label48.Text = "වුවමනා9" Or
            Label4.Text = "වුවමනා10" Or
            Label5.Text = "වුවමනා11" Or
            Label6.Text = "වුවමනා12" Or
            Label7.Text = "වුවමනා13" Or
            Label8.Text = "වුවමනා14" Or
            Label47.Text = "වුවමනා15" Or
            Label3.Text = "වුවමනා16" Or
            Label56.Text = "වුවමනා17" Or
            Label50.Text = "වුවමනා18" Or
            Label51.Text = "වුවමනා19" Or
            Label52.Text = "වුවමනා20" Or
            Label53.Text = "වුවමනා21" Or
            Label54.Text = "වුවමනා22" Or
            Label55.Text = "වුවමනා23" Or
            Label49.Text = "වුවමනා24" Or
            Label58.Text = "වුවමනා25" Or
            Label59.Text = "වුවමනා26" Or
            Label60.Text = "වුවමනා27" Or
            Label57.Text = "වුවමනා28" Then

            MessageBox.Show("කරුණාකර සියලු කරුණු පිරවීමෙන් පසු පරීක්ෂා කරන්න.")
        Else
            check()
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label17_DragDrop_1(sender As Object, e As DragEventArgs) Handles Label8.DragDrop, Label7.DragDrop, Label60.DragDrop, Label6.DragDrop, Label59.DragDrop, Label58.DragDrop, Label57.DragDrop, Label56.DragDrop, Label55.DragDrop, Label54.DragDrop, Label53.DragDrop, Label52.DragDrop, Label51.DragDrop, Label50.DragDrop, Label5.DragDrop, Label49.DragDrop, Label48.DragDrop, Label47.DragDrop, Label4.DragDrop, Label3.DragDrop, Label23.DragDrop, Label22.DragDrop, Label21.DragDrop, Label20.DragDrop, Label2.DragDrop, Label19.DragDrop, Label18.DragDrop, Label17.DragDrop
        sender.Text = e.Data.GetData(DataFormats.Text)
        lab2.Visible = False
        sender.AllowDrop = False
        sender.Backcolor = Color.Navy
        value2.backcolor = Color.PowderBlue
    End Sub

    Private Sub Label17_DragEnter_1(sender As Object, e As DragEventArgs) Handles Label8.DragEnter, Label7.DragEnter, Label60.DragEnter, Label6.DragEnter, Label59.DragEnter, Label58.DragEnter, Label57.DragEnter, Label56.DragEnter, Label55.DragEnter, Label54.DragEnter, Label53.DragEnter, Label52.DragEnter, Label51.DragEnter, Label50.DragEnter, Label5.DragEnter, Label49.DragEnter, Label48.DragEnter, Label47.DragEnter, Label4.DragEnter, Label3.DragEnter, Label23.DragEnter, Label22.DragEnter, Label21.DragEnter, Label20.DragEnter, Label2.DragEnter, Label19.DragEnter, Label18.DragEnter, Label17.DragEnter
        e.Effect = DragDropEffects.Copy
        'sender.Backcolor = Color.Red
    End Sub

    Private Sub Label32_MouseDown(sender As Object, e As MouseEventArgs) Handles Label66.MouseDown, Label65.MouseDown, Label64.MouseDown, Label63.MouseDown, Label62.MouseDown, Label61.MouseDown, Label46.MouseDown, Label45.MouseDown, Label44.MouseDown, Label43.MouseDown, Label42.MouseDown, Label41.MouseDown, Label40.MouseDown, Label39.MouseDown, Label38.MouseDown, Label37.MouseDown, Label36.MouseDown, Label35.MouseDown, Label34.MouseDown, Label32.MouseDown, Label31.MouseDown, Label30.MouseDown, Label29.MouseDown, Label28.MouseDown, Label27.MouseDown, Label26.MouseDown, Label25.MouseDown, Label24.MouseDown
        lab2 = CType(sender, Label)
        lab2.DoDragDrop(lab2.Text, DragDropEffects.Copy)

        'Try
        '    If value.visible = True Then
        '        value.backcolor = Color.PowderBlue
        '    End If
        'Catch ex As Exception

        'End Try


        'sender.backcolor = Color.Navy
        'value = sender

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound1.Play()
    End Sub

    Private Sub Label63_MouseHover_1(sender As Object, e As EventArgs) Handles Label66.MouseHover, Label65.MouseHover, Label64.MouseHover, Label63.MouseHover, Label62.MouseHover, Label61.MouseHover, Label46.MouseHover, Label45.MouseHover, Label44.MouseHover, Label43.MouseHover, Label42.MouseHover, Label41.MouseHover, Label40.MouseHover, Label39.MouseHover, Label38.MouseHover, Label37.MouseHover, Label36.MouseHover, Label35.MouseHover, Label34.MouseHover, Label32.MouseHover, Label31.MouseHover, Label30.MouseHover, Label29.MouseHover, Label28.MouseHover, Label27.MouseHover, Label26.MouseHover, Label25.MouseHover, Label24.MouseHover
        Cursor = Cursors.Hand
        Try
            If value2.visible = True Then
                value2.Backcolor = Color.PowderBlue
            End If
        Catch ex As Exception

        End Try
        sender.backcolor = Color.Navy
        value2 = sender
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count2 += 1
        If count2 = 5 Then
            value2.Backcolor = Color.PowderBlue
            Label10.BackColor = Color.Transparent
            Label11.BackColor = Color.Transparent
            Label12.BackColor = Color.Transparent
            Label13.BackColor = Color.Transparent
            Label14.BackColor = Color.Transparent
            Label15.BackColor = Color.Transparent
            Label16.BackColor = Color.Transparent
            count2 = 0
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub Label57_DragOver(sender As Object, e As DragEventArgs) Handles Label8.DragOver, Label7.DragOver, Label60.DragOver, Label6.DragOver, Label59.DragOver, Label58.DragOver, Label57.DragOver, Label56.DragOver, Label55.DragOver, Label54.DragOver, Label53.DragOver, Label52.DragOver, Label51.DragOver, Label50.DragOver, Label5.DragOver, Label49.DragOver, Label48.DragOver, Label47.DragOver, Label4.DragOver, Label3.DragOver, Label23.DragOver, Label22.DragOver, Label21.DragOver, Label20.DragOver, Label2.DragOver, Label19.DragOver, Label18.DragOver, Label17.DragOver
        If sender Is Label20 Or sender Is Label19 Or sender Is Label18 Or sender Is Label17 Then
            Label10.BackColor = Color.Black
        ElseIf sender Is Label21 Or sender Is Label22 Or sender Is Label23 Or sender Is Label2 Then
            Label11.BackColor = Color.Black
        ElseIf sender Is Label48 Or sender Is Label4 Or sender Is Label5 Or sender Is Label6 Then
            Label12.BackColor = Color.Black
        ElseIf sender Is Label7 Or sender Is Label8 Or sender Is Label47 Or sender Is Label3 Then
            Label13.BackColor = Color.Black
        ElseIf sender Is Label56 Or sender Is Label50 Or sender Is Label51 Or sender Is Label52 Then
            Label14.BackColor = Color.Black
        ElseIf sender Is Label53 Or sender Is Label54 Or sender Is Label55 Or sender Is Label49 Then
            Label15.BackColor = Color.Black
        ElseIf sender Is Label58 Or sender Is Label59 Or sender Is Label60 Or sender Is Label57 Then
            Label16.BackColor = Color.Black
        End If
    End Sub

    Private Sub Label57_DragLeave(sender As Object, e As EventArgs) Handles Label8.DragLeave, Label7.DragLeave, Label60.DragLeave, Label6.DragLeave, Label59.DragLeave, Label58.DragLeave, Label57.DragLeave, Label56.DragLeave, Label55.DragLeave, Label54.DragLeave, Label53.DragLeave, Label52.DragLeave, Label51.DragLeave, Label50.DragLeave, Label5.DragLeave, Label49.DragLeave, Label48.DragLeave, Label47.DragLeave, Label4.DragLeave, Label3.DragLeave, Label23.DragLeave, Label22.DragLeave, Label21.DragLeave, Label20.DragLeave, Label2.DragLeave, Label19.DragLeave, Label18.DragLeave, Label17.DragLeave
        If sender Is Label20 Or sender Is Label19 Or sender Is Label18 Or sender Is Label17 Then
            Label10.BackColor = Color.Transparent
        ElseIf sender Is Label21 Or sender Is Label22 Or sender Is Label23 Or sender Is Label2 Then
            Label11.BackColor = Color.Transparent
        ElseIf sender Is Label48 Or sender Is Label4 Or sender Is Label5 Or sender Is Label6 Then
            Label12.BackColor = Color.Transparent
        ElseIf sender Is Label7 Or sender Is Label8 Or sender Is Label47 Or sender Is Label3 Then
            Label13.BackColor = Color.Transparent
        ElseIf sender Is Label56 Or sender Is Label50 Or sender Is Label51 Or sender Is Label52 Then
            Label14.BackColor = Color.Transparent
        ElseIf sender Is Label53 Or sender Is Label54 Or sender Is Label55 Or sender Is Label49 Then
            Label15.BackColor = Color.Transparent
        ElseIf sender Is Label58 Or sender Is Label59 Or sender Is Label60 Or sender Is Label57 Then
            Label16.BackColor = Color.Transparent
        End If
    End Sub
End Class