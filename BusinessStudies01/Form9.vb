Public Class Form9
    Public L As Label
    Dim count = 60
    Dim value
    Dim test
    Dim test2
    Dim test3
    Dim test4
    Dim test5
    Dim test6

    Dim audiofile As String = "Kriyakarakam4.1.wav"
    Dim sound7 As New Media.SoundPlayer(audiofile)
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        L = CType(sender, Label)
        L.DoDragDrop(L.Text, DragDropEffects.All)
    End Sub

    Private Sub Label7_DragEnter(sender As Object, e As DragEventArgs) Handles Label7.DragEnter, Label8.DragEnter, Label9.DragEnter, Label10.DragEnter, Label11.DragEnter, Label12.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub Label7_DragDrop(sender As Object, e As DragEventArgs) Handles Label7.DragDrop, Label8.DragDrop, Label9.DragDrop, Label10.DragDrop, Label11.DragDrop, Label12.DragDrop
        If sender.Backcolor = Color.Tomato Then
            sender.Text = e.Data.GetData(DataFormats.Text)
            sender.backcolor = Color.OrangeRed
            check()
            L.Visible = False
        Else
            MessageBox.Show("දැමූ එකක් මත නැවත එකක් දැමිය නොහැක")
        End If


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound7.Play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label7.Text = "1 අදියර" And
            Label8.Text = "2 අදියර" And
            Label9.Text = "3 අදියර" And
            Label10.Text = "4 අදියර" And
            Label11.Text = "5 අදියර" And
            Label12.Text = "6 අදියර" Then

            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else

            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True

            Label7.Text = "1 අදියර"
            Label8.Text = "2 අදියර"
            Label9.Text = "3 අදියර"
            Label10.Text = "4 අදියර"
            Label11.Text = "5 අදියර"
            Label12.Text = "6 අදියර"

            Label7.BackColor = Color.Tomato
            Label8.BackColor = Color.Tomato
            Label9.BackColor = Color.Tomato
            Label10.BackColor = Color.Tomato
            Label11.BackColor = Color.Tomato
            Label12.BackColor = Color.Tomato


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
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        sound7.Stop()
        Me.Hide()
        Theory7.Show()
    End Sub

    Private Sub check()
        If Label7.Text = "1 අදියර" Or
            Label8.Text = "2 අදියර" Or
            Label9.Text = "3 අදියර" Or
            Label10.Text = "4 අදියර" Or
            Label11.Text = "5 අදියර" Or
            Label12.Text = "6 අදියර" Then
        Else


            If Label7.Text = Label1.Text Then
                'MessageBox.Show("Correct-1")
                PictureBox10.Visible = True
                PictureBox9.Visible = False
            Else
                'MessageBox.Show("Wrong-1")
                PictureBox9.Visible = True
                PictureBox10.Visible = False
            End If
            If Label8.Text = Label2.Text Then
                'MessageBox.Show("Correct-2")
                PictureBox12.Visible = True
                PictureBox11.Visible = False
            Else
                'MessageBox.Show("Wrong-2")
                PictureBox11.Visible = True
                PictureBox12.Visible = False
            End If
            If Label9.Text = Label3.Text Then
                'MessageBox.Show("Correct-3")
                PictureBox14.Visible = True
                PictureBox13.Visible = False
            Else
                'MessageBox.Show("Wrong-3")
                PictureBox13.Visible = True
                PictureBox14.Visible = False
            End If
            If Label10.Text = Label4.Text Then
                'MessageBox.Show("Correct-4")
                PictureBox16.Visible = True
                PictureBox15.Visible = False
            Else
                ' MessageBox.Show("Wrong-4")
                PictureBox15.Visible = True
                PictureBox16.Visible = False
            End If
            If Label11.Text = Label5.Text Then
                'MessageBox.Show("Correct-5")
                PictureBox18.Visible = True
                PictureBox17.Visible = False
            Else
                'MessageBox.Show("Wrong-5")
                PictureBox17.Visible = True
                PictureBox18.Visible = False
            End If
            If Label12.Text = Label6.Text Then
                'MessageBox.Show("Correct-6")
                PictureBox20.Visible = True
                PictureBox19.Visible = False
            Else
                'MessageBox.Show("Wrong-6")
                PictureBox19.Visible = True
                PictureBox20.Visible = False
            End If
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        sound7.Stop()
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        sound7.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory7.Show()
    End Sub

    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover, Label5.MouseHover, Label4.MouseHover, Label3.MouseHover, Label2.MouseHover, Label1.MouseHover
        Cursor = Cursors.Hand
        sender.backcolor = Color.Yellow
        Try
            If value.visible = True Then
                value.backcolor = Color.OrangeRed
            End If
        Catch ex As Exception

        End Try
        value = sender
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub
End Class