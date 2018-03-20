Public Class Form14

    Dim count = 0
    Dim count2 = 0
    Dim click
    Dim click2
    Dim count3 = 0
    Dim word(12) As String
    Dim word2(12) As String
    'array[][]=New string[][]


    Dim audiofile As String = "Kriyakarakam6.2.wav"
    Dim sound12 As New Media.SoundPlayer(audiofile)
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown, Button8.MouseDown, Button7.MouseDown, Button6.MouseDown, Button5.MouseDown, Button4.MouseDown, Button3.MouseDown, Button2.MouseDown, Button12.MouseDown, Button11.MouseDown, Button10.MouseDown, Button1.MouseDown
        If count = 0 Then
            If sender Is Button1 Then
                Label5.Text = "නිෂ්පාදන කර්මාන්ත"
            ElseIf sender Is Button2 Then
                Label5.Text = "ජලය පිරිසිදු කිරීම හා බෙදාහැරීම"
            ElseIf sender Is Button3 Then
                Label5.Text = "ඉදි කිරීම් කර්මාන්ත"
            ElseIf sender Is Button4 Then
                Label5.Text = "වෘත්තීය ම ය සේවා සහ වෙනත් පෞද්ගලික සේවා"
            ElseIf sender Is Button5 Then
                Label5.Text = "මලාපවහන කටයුතු, කසල කළමනාකරණය 
සහ එම ද්‍රව්‍ය ප්‍රතිචක්‍රීයකරණය"
            ElseIf sender Is Button6 Then
                Label5.Text = "කෘෂිකර්මාන්තය, වන වගාව හා ධීවර කර්මාන්තය"
            ElseIf sender Is Button7 Then
                Label5.Text = "තොරතුරු සහ සන්නිවේදන කටයුතු"
            ElseIf sender Is Button8 Then
                Label5.Text = "රාජ්‍ය පරිපාලන, ජාතික ආරක්ෂාව, අධ්‍යාපනය, සෞඛ්‍යය 
සහ සමාජ ආරක්ෂණ සේවා"
            ElseIf sender Is Button9 Then
                Label5.Text = "මූල්‍ය, රක්ෂණය හා නිවාස අයිතිය හා දේපළ වෙළෙදාම්"
            ElseIf sender Is Button10 Then
                Label5.Text = "පතල් හා කැණීම් කර්මාන්තය"
            ElseIf sender Is Button11 Then
                Label5.Text = "වෙළදාම, ප්‍රවාහන සේවා, නවාතැන් සැපයීම
හා ආහාරපාන සැපයීම"
            ElseIf sender Is Button12 Then
                Label5.Text = "විදුලිය, ගෑස්, වාෂ්ප හා වායු සමීකරණ සැපයීම"
            End If
            click = sender
        Else
            'MessageBox.Show("You Locked the Answer")
            'Panel1.Visible = False

        End If

        sender.backcolor = Color.SteelBlue
        'check()
    End Sub

    Private Sub Form14_MouseDown(sender As Object, e As MouseEventArgs) Handles Button15.MouseDown, Button14.MouseDown, Button13.MouseDown
        If count2 = 1 Then
            'count = 0
            'Label5.Text = ""
            'Label6.Text = ""
            'Button16.Text = "UNLOCK"
        Else

            If sender Is Button14 Then
                Label6.Text = "ද්වීතීයක අංශය"
            ElseIf sender Is Button13 Then
                Label6.Text = "තෘතීයික අංශය"
            ElseIf sender Is Button15 Then
                Label6.Text = "ප්‍රාථමික අංශය"
            End If

        End If
        sender.backcolor = Color.SteelBlue
        'check()
        'Panel1.Visible = True
    End Sub

    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover, Button8.MouseHover, Button7.MouseHover, Button6.MouseHover, Button5.MouseHover, Button4.MouseHover, Button3.MouseHover, Button2.MouseHover, Button12.MouseHover, Button11.MouseHover, Button10.MouseHover, Button1.MouseHover
        Cursor = Cursors.Hand
        sender.backcolor = Color.Navy
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave, Button8.MouseLeave, Button7.MouseLeave, Button6.MouseLeave, Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button12.MouseLeave, Button11.MouseLeave, Button10.MouseLeave, Button1.MouseLeave
        Cursor = Cursors.Default
        sender.backcolor = Color.Teal
    End Sub

    Private Sub Button14_MouseHover(sender As Object, e As EventArgs) Handles Button15.MouseHover, Button14.MouseHover, Button13.MouseHover
        Cursor = Cursors.Hand
        sender.backcolor = Color.Navy
    End Sub

    Private Sub Button14_MouseLeave(sender As Object, e As EventArgs) Handles Button15.MouseLeave, Button14.MouseLeave, Button13.MouseLeave
        Cursor = Cursors.Default
        sender.backcolor = Color.Magenta
    End Sub

    'Private Sub check()
    '    If Label6.Text = "ප්‍රාථමික අංශය" And Label5.Text = "කෘෂිකර්මාන්තය, වන වගාව හා ධීවර කර්මාන්තය" Then
    '        MessageBox.Show("Correct")
    '    Else
    '        MessageBox.Show("Wrong")
    '    End If
    'End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        count += 1
        If count = 1 Then
            If Label5.Text = "වර්ගීකරණ කරුණු" Then
                MessageBox.Show("වර්ගීකරණ කරුණු වෙනස් කර නොමැත")
                count = 0
            Else
                Button16.Text = "LOCK"
                Panel1.Visible = False
                Panel3.Visible = True
                click.visible = False
            End If
        Else
            Button16.Text = "UNLOCK"
            Panel1.Visible = True
            Panel3.Visible = False
            click.visible = True
            count = 0
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        count2 += 1
        If count2 = 1 Then
            If Label6.Text = "අංශය" Then
                MessageBox.Show("අංශය වෙනස් කර නොමැත")
                count2 = 0
            Else
                Button17.Text = "LOCK"
                'Button17.BackgroundImage = 
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                Panel3.Visible = False
                Panel1.Visible = True
            End If

            'click.visible = False
        Else

            Button17.Text = "UNLOCK"
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            Panel3.Visible = True
                Panel1.Visible = False


            'click.visible = True
            count2 = 0
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Button16.Text = "LOCK" And Button17.Text = "LOCK" Then
            word(count3) = Label5.Text
            word2(count3) = Label6.Text
            count3 += 1

            Label5.Text = "වර්ගීකරණ කරුණු"
            Label6.Text = "අංශය"
            Panel1.Visible = True
            Panel3.Visible = True
            Button18.Visible = False
            Button16.Text = "UNLOCK"
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            Button17.Text = "UNLOCK"
            click.visible = False
            MessageBox.Show("සාර්ථකව ඇතුලත් කර ගන්නා ලදී.")

            TextBox1.Text = ""
            TextBox3.Text = ""
            For i As Integer = 0 To word.Length - 1
                If word(i) = "" And word2(i) = "" Then

                Else
                    Dim val = i + 1
                    TextBox1.Text += val.ToString() + " ) " + word2(i) + "  -  " + word(i) + Environment.NewLine
                    TextBox3.Text += val.ToString() + " ) " + word2(i) + "  -  " + word(i) + Environment.NewLine
                    TextBox3.SelectionStart = TextBox3.Text.Length
                    TextBox3.ScrollToCaret()
                End If

            Next
            count = 0
            count2 = 0
            check()
        Else
            MessageBox.Show("කරුණාකර සියල්ල අගුලු දමන්න")

        End If
    End Sub

    Private Sub check()
        TextBox2.Text = ""
        For i As Integer = 0 To 11
            If word(i) = "" And word2(i) = "" Then

            Else
                Dim val = i + 1
                If word(i) = "කෘෂිකර්මාන්තය, වන වගාව හා ධීවර කර්මාන්තය" Or word(i) = "පතල් හා කැණීම් කර්මාන්තය" Then
                    If word2(i) = "ප්‍රාථමික අංශය" Then
                        'MessageBox.Show("Correct 1")
                        TextBox2.Text += val.ToString() + " ) " + "නිවැරදියි" + Environment.NewLine
                    Else
                        TextBox2.Text += val.ToString() + " ) " + "වැරදියි" + Environment.NewLine
                    End If
                ElseIf word(i) = "නිෂ්පාදන කර්මාන්ත" Or word(i) = "ඉදි කිරීම් කර්මාන්ත" Then
                    If word2(i) = "ද්වීතීයක අංශය" Then
                        TextBox2.Text += val.ToString() + " ) " + "නිවැරදියි" + Environment.NewLine
                    Else
                        TextBox2.Text += val.ToString() + " ) " + "වැරදියි" + Environment.NewLine
                    End If

                ElseIf word(i) = "විදුලිය, ගෑස්, වාෂ්ප හා වායු සමීකරණ සැපයීම" Or word(i) = "ජලය පිරිසිදු කිරීම හා බෙදාහැරීම" Or
                    word(i) = "මලාපවහන කටයුතු, කසල කළමනාකරණය 
සහ එම ද්‍රව්‍ය ප්‍රතිචක්‍රීයකරණය" Or word(i) = "වෙළදාම, ප්‍රවාහන සේවා, නවාතැන් සැපයීම
හා ආහාරපාන සැපයීම" Or word(i) = "තොරතුරු සහ සන්නිවේදන කටයුතු" Or word(i) = "මූල්‍ය, රක්ෂණය හා නිවාස අයිතිය හා දේපළ වෙළෙදාම්" Or
                    word(i) = "වෘත්තීය ම ය සේවා සහ වෙනත් පෞද්ගලික සේවා" Or word(i) = "රාජ්‍ය පරිපාලන, ජාතික ආරක්ෂාව, අධ්‍යාපනය, සෞඛ්‍යය 
සහ සමාජ ආරක්ෂණ සේවා" Then
                    If word2(i) = "තෘතීයික අංශය" Then
                        TextBox2.Text += val.ToString() + " ) " + "නිවැරදියි" + Environment.NewLine
                    Else
                        'MessageBox.Show("Incorrect 1")
                        TextBox2.Text += val.ToString() + " ) " + "වැරදියි" + Environment.NewLine
                    End If
                End If
            End If
        Next

        If Button1.Visible = False And Button2.Visible = False And Button3.Visible = False And Button4.Visible = False And
                Button5.Visible = False And Button6.Visible = False And Button7.Visible = False And Button8.Visible = False And
                Button9.Visible = False And Button10.Visible = False And Button11.Visible = False And Button12.Visible = False Then
            Panel4.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button17.Text = "UNLOCK"
        PictureBox2.Visible = True
        PictureBox1.Visible = False
        Panel3.Visible = True
        If PictureBox1.Visible = False And PictureBox4.Visible = False Then
            Button18.Visible = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If Label6.Text = "අංශය" Then
            MessageBox.Show("අංශයක් තෝරා නොමැත")

        Else
            Button17.Text = "LOCK"
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Panel3.Visible = False
            If PictureBox1.Visible = True And PictureBox4.Visible = True Then
                Button18.Visible = True
            End If
        End If


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        If Label5.Text = "වර්ගීකරණ කරුණු" Then
            MessageBox.Show("වර්ගීකරණ කරුණක් තෝරා නොමැත")
            count = 0
        Else
            Button16.Text = "LOCK"
            PictureBox4.Visible = True
            PictureBox3.Visible = False
            Panel1.Visible = False
            click.visible = False
            If PictureBox1.Visible = True And PictureBox4.Visible = True Then
                Button18.Visible = True
            End If
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Button16.Text = "UNLOCK"
        PictureBox3.Visible = True
        PictureBox4.Visible = False
        Panel1.Visible = True
        click.visible = True
        If PictureBox1.Visible = False And PictureBox4.Visible = False Then
            Button18.Visible = False
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If Panel4.Visible = False And Panel4.Visible = False And
            Button1.Visible = True And
            Button2.Visible = True And
            Button3.Visible = True And
            Button4.Visible = True And
            Button5.Visible = True And
            Button6.Visible = True And
            Button7.Visible = True And
            Button8.Visible = True And
            Button9.Visible = True And
            Button10.Visible = True And
            Button11.Visible = True And
            Button12.Visible = True Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            Panel4.Visible = False
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            TextBox3.Text = ""
            count3 = 0
        End If

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound12.Play()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound12.Stop()
        Me.Hide()
        Form13.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound12.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'Me.Hide()
        'Theory10.Show()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.Hide()
        Theory9.Show()
    End Sub
End Class