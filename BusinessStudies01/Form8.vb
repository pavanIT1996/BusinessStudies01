Public Class Form8
    Dim Lab As Label


    Dim audiofile As String = "Kriyakarakam3.2.wav"
    Dim sound6 As New Media.SoundPlayer(audiofile)
    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown, Label8.MouseDown, Label7.MouseDown, Label6.MouseDown, Label5.MouseDown, Label4.MouseDown, Label3.MouseDown, Label2.MouseDown, Label1.MouseDown
        'Dim Lab As Label
        Lab = CType(sender, Label)
        Lab.DoDragDrop(Lab, DragDropEffects.Copy)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.BackColor = Color.MediumSlateBlue And Label2.BackColor = Color.MediumSlateBlue And
            Label3.BackColor = Color.MediumSlateBlue And Label4.BackColor = Color.MediumSlateBlue And
            Label5.BackColor = Color.MediumSlateBlue And Label6.BackColor = Color.MediumSlateBlue And
            Label7.BackColor = Color.MediumSlateBlue And Label8.BackColor = Color.MediumSlateBlue And
            Label9.BackColor = Color.MediumSlateBlue Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else
            Form8_Load(Me, e)
            Label1.BackColor = Color.MediumSlateBlue
            Label2.BackColor = Color.MediumSlateBlue
            Label3.BackColor = Color.MediumSlateBlue
            Label4.BackColor = Color.MediumSlateBlue
            Label5.BackColor = Color.MediumSlateBlue
            Label6.BackColor = Color.MediumSlateBlue
            Label7.BackColor = Color.MediumSlateBlue
            Label8.BackColor = Color.MediumSlateBlue
            Label9.BackColor = Color.MediumSlateBlue

            PictureBox36.Visible = False
            PictureBox37.Visible = False
            PictureBox38.Visible = False
            PictureBox39.Visible = False
            PictureBox40.Visible = False
            PictureBox41.Visible = False
            PictureBox42.Visible = False
            PictureBox43.Visible = False
            PictureBox44.Visible = False
            PictureBox45.Visible = False
            PictureBox46.Visible = False
            PictureBox47.Visible = False
            PictureBox48.Visible = False
            PictureBox49.Visible = False
            PictureBox50.Visible = False
            PictureBox51.Visible = False
            PictureBox52.Visible = False
            PictureBox53.Visible = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound6.Stop()
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound6.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound6.Stop()
        Me.Hide()
        Theory7.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Label1.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Label1.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Label2.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Label2.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Label3.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Label3.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Label4.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Label4.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Label5.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Label5.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Label6.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Label6.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Label7.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Label7.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Label8.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Label8.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Label9.BackColor = Color.Red
        check()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Label9.BackColor = Color.OrangeRed
        check()
    End Sub

    Private Sub check()
        If Label1.BackColor = Color.MediumSlateBlue Or Label2.BackColor = Color.MediumSlateBlue Or
           Label3.BackColor = Color.MediumSlateBlue Or Label4.BackColor = Color.MediumSlateBlue Or
           Label5.BackColor = Color.MediumSlateBlue Or Label6.BackColor = Color.MediumSlateBlue Or
           Label7.BackColor = Color.MediumSlateBlue Or Label8.BackColor = Color.MediumSlateBlue Or
           Label9.BackColor = Color.MediumSlateBlue Then

        Else

            If Label1.Text = "වෙළදපොළේ රැදී සිටීම" Or Label1.Text = "ලාභ උපරිම කිරීම" Or Label1.Text = "විකුණුම් උපරිම කිරීම" Or
                Label1.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label1.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label1.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
               Label1.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label1.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label1.Text = "සේවක සුභ සාධනය" Then

                If Label1.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 1")
                    PictureBox37.Visible = True
                    PictureBox36.Visible = False
                Else
                    'MessageBox.Show("Wrong 1")
                    PictureBox36.Visible = True
                    PictureBox37.Visible = False
                End If
            Else
                If Label1.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 1")
                    PictureBox37.Visible = True
                    PictureBox36.Visible = False
                Else
                    'MessageBox.Show("Wrong 1")
                    PictureBox36.Visible = True
                    PictureBox37.Visible = False
                End If
            End If


            If Label2.Text = "වෙළදපොළේ රැදී සිටීම" Or Label2.Text = "ලාභ උපරිම කිරීම" Or Label2.Text = "විකුණුම් උපරිම කිරීම" Or
               Label2.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label2.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label2.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
                Label2.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label2.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label2.Text = "සේවක සුභ සාධනය" Then
                If Label2.BackColor = Color.Red Then
                    ' MessageBox.Show("Correct 2")
                    PictureBox39.Visible = True
                    PictureBox38.Visible = False
                Else
                    'MessageBox.Show("Wrong 2")
                    PictureBox38.Visible = True
                    PictureBox39.Visible = False
                End If
            Else
                If Label2.BackColor = Color.OrangeRed Then
                    ' MessageBox.Show("Correct 2")
                    PictureBox39.Visible = True
                    PictureBox38.Visible = False
                Else
                    'MessageBox.Show("Wrong 2")
                    PictureBox38.Visible = True
                    PictureBox39.Visible = False
                End If

            End If

            If Label3.Text = "වෙළදපොළේ රැදී සිටීම" Or Label3.Text = "ලාභ උපරිම කිරීම" Or Label3.Text = "විකුණුම් උපරිම කිරීම" Or
               Label3.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label3.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label3.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
               Label3.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label3.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label3.Text = "සේවක සුභ සාධනය" Then
                If Label3.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 3")
                    PictureBox41.Visible = True
                    PictureBox40.Visible = False
                Else
                    'MessageBox.Show("Wrong 3")
                    PictureBox40.Visible = True
                    PictureBox41.Visible = False
                End If
            Else

                If Label3.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 3")
                    PictureBox41.Visible = True
                    PictureBox40.Visible = False
                Else
                    'MessageBox.Show("Wrong 3")
                    PictureBox40.Visible = True
                    PictureBox41.Visible = False
                End If

            End If

            If Label4.Text = "වෙළදපොළේ රැදී සිටීම" Or Label4.Text = "ලාභ උපරිම කිරීම" Or Label4.Text = "විකුණුම් උපරිම කිරීම" Or
             Label4.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label4.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label4.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
             Label4.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label4.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label4.Text = "සේවක සුභ සාධනය" Then
                If Label4.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 4")
                    PictureBox43.Visible = True
                    PictureBox42.Visible = False
                Else
                    'MessageBox.Show("Wrong 4")
                    PictureBox42.Visible = True
                    PictureBox43.Visible = False
                End If
            Else
                If Label4.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 4")
                    PictureBox43.Visible = True
                    PictureBox42.Visible = False
                Else
                    'MessageBox.Show("Wrong 4")
                    PictureBox42.Visible = True
                    PictureBox43.Visible = False
                End If
            End If

            If Label5.Text = "වෙළදපොළේ රැදී සිටීම" Or Label5.Text = "ලාභ උපරිම කිරීම" Or Label5.Text = "විකුණුම් උපරිම කිරීම" Or
             Label5.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label5.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label5.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
             Label5.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label5.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label5.Text = "සේවක සුභ සාධනය" Then
                If Label5.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 5")
                    PictureBox45.Visible = True
                    PictureBox44.Visible = False
                Else
                    'MessageBox.Show("Wrong 5")
                    PictureBox44.Visible = True
                    PictureBox45.Visible = False
                End If
            Else
                If Label5.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 5")
                    PictureBox45.Visible = True
                    PictureBox44.Visible = False
                Else
                    'MessageBox.Show("Wrong 5")
                    PictureBox44.Visible = True
                    PictureBox45.Visible = False
                End If

            End If

            If Label6.Text = "වෙළදපොළේ රැදී සිටීම" Or Label6.Text = "ලාභ උපරිම කිරීම" Or Label6.Text = "විකුණුම් උපරිම කිරීම" Or
             Label6.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label6.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label6.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
             Label6.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label6.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label6.Text = "සේවක සුභ සාධනය" Then
                If Label6.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 6")
                    PictureBox47.Visible = True
                    PictureBox46.Visible = False
                Else
                    'MessageBox.Show("Wrong 6")
                    PictureBox46.Visible = True
                    PictureBox47.Visible = False
                End If
            Else
                If Label6.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 6")
                    PictureBox47.Visible = True
                    PictureBox46.Visible = False
                Else
                    'MessageBox.Show("Wrong 6")
                    PictureBox46.Visible = True
                    PictureBox47.Visible = False
                End If
            End If

            If Label7.Text = "වෙළදපොළේ රැදී සිටීම" Or Label7.Text = "ලාභ උපරිම කිරීම" Or Label7.Text = "විකුණුම් උපරිම කිරීම" Or
            Label7.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label7.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label7.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
             Label7.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label7.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label7.Text = "සේවක සුභ සාධනය" Then
                If Label7.BackColor = Color.Red Then
                    ' MessageBox.Show("Correct 7")
                    PictureBox49.Visible = True
                    PictureBox48.Visible = False
                Else
                    'MessageBox.Show("Wrong 7")
                    PictureBox48.Visible = True
                    PictureBox49.Visible = False
                End If
            Else
                If Label7.BackColor = Color.OrangeRed Then
                    ' MessageBox.Show("Correct 7")
                    PictureBox49.Visible = True
                    PictureBox48.Visible = False
                Else
                    'MessageBox.Show("Wrong 7")
                    PictureBox48.Visible = True
                    PictureBox49.Visible = False
                End If

            End If

            If Label8.Text = "වෙළදපොළේ රැදී සිටීම" Or Label8.Text = "ලාභ උපරිම කිරීම" Or Label8.Text = "විකුණුම් උපරිම කිරීම" Or
             Label8.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label8.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label8.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
             Label8.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label8.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label8.Text = "සේවක සුභ සාධනය" Then
                If Label8.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 8")
                    PictureBox51.Visible = True
                    PictureBox50.Visible = False
                Else
                    'MessageBox.Show("Wrong 8")
                    PictureBox50.Visible = True
                    PictureBox51.Visible = False
                End If
            Else
                If Label8.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 8")
                    PictureBox51.Visible = True
                    PictureBox50.Visible = False
                Else
                    'MessageBox.Show("Wrong 8")
                    PictureBox50.Visible = True
                    PictureBox51.Visible = False
                End If
            End If

            If Label9.Text = "වෙළදපොළේ රැදී සිටීම" Or Label9.Text = "ලාභ උපරිම කිරීම" Or Label9.Text = "විකුණුම් උපරිම කිරීම" Or
              Label9.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම" Or Label9.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම" Or Label9.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම" Or
              Label9.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය" Or Label9.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය" Or Label9.Text = "සේවක සුභ සාධනය" Then

                If Label9.BackColor = Color.Red Then
                    'MessageBox.Show("Correct 9")
                    PictureBox53.Visible = True
                    PictureBox52.Visible = False
                Else
                    'MessageBox.Show("Wrong 9")
                    PictureBox52.Visible = True
                    PictureBox53.Visible = False
                End If
            Else
                If Label9.BackColor = Color.OrangeRed Then
                    'MessageBox.Show("Correct 9")
                    PictureBox53.Visible = True
                    PictureBox52.Visible = False
                Else
                    'MessageBox.Show("Wrong 9")
                    PictureBox52.Visible = True
                    PictureBox53.Visible = False
                End If
            End If
        End If

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sound6.Play()

        Dim value As Integer = CInt(Int((9 * Rnd()) + 1))

        If value = 1 Then
            Label4.Text = "වෙළදපොළේ රැදී සිටීම"
            Label3.Text = "ලාභ උපරිම නොකිරීම"
            Label2.Text = "විකුණුම් උපරිම කිරීම"
            Label1.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label9.Text = "පාරිභෝගික තෘප්තිය වැඩි නොකිරීම"
            Label8.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label7.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label6.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label5.Text = "සේවක සුභ සාධනය"
            'MessageBox.Show(value.ToString())
        ElseIf value = 2 Then
            Label3.Text = "වෙළදපොළේ රැදී නොසිටීම"
            Label2.Text = "ලාභ උපරිම කිරීම"
            Label1.Text = "විකුණුම් උපරිම නොකිරීම"
            Label4.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label8.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label7.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label6.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label5.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label9.Text = "සේවක සුභ සාධනය"
            'MessageBox.Show(value.ToString())
        ElseIf value = 3 Then
            Label2.Text = "වෙළදපොළේ රැදී සිටීම"
            Label1.Text = "ලාභ උපරිම කිරීම"
            Label4.Text = "විකුණුම් උපරිම කිරීම"
            Label3.Text = "වෙළෙදපොළ කොටස වැඩි කර නොගැනීම"
            Label7.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label6.Text = "කොටස්වල වෙළෙද අගය උපරිම නොකිරීම"
            Label5.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label9.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label8.Text = "සේවක සුභ සාධනය"
            'MessageBox.Show(value.ToString())
        ElseIf value = 4 Then
            Label1.Text = "වෙළදපොළේ රැදී නොසිටීම"
            Label4.Text = "ලාභ උපරිම කිරීම"
            Label3.Text = "විකුණුම් උපරිම කිරීම"
            Label2.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label6.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label5.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label9.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label8.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය නොකිරීම"
            Label7.Text = "සේවක සුභ සාධනය"
            'MessageBox.Show(value.ToString())
        ElseIf value = 5 Then
            Label9.Text = "වෙළදපොළේ රැදී නොසිටීම"
            Label8.Text = "ලාභ උපරිම නොකිරීම"
            Label7.Text = "විකුණුම් උපරිම කිරීම"
            Label6.Text = "වෙළෙදපොළ කොටස වැඩි කර නොගැනීම"
            Label5.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label1.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label2.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label3.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label4.Text = "සේවක සුභ සාධනය නොකිරීම"
            'MessageBox.Show(value.ToString())
        ElseIf value = 6 Then
            Label8.Text = "වෙළදපොළේ රැදී සිටීම"
            Label7.Text = "ලාභ උපරිම කිරීම"
            Label6.Text = "විකුණුම් උපරිම කිරීම"
            Label5.Text = "වෙළෙදපොළ කොටස වැඩි කර නොගැනීම"
            Label9.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label3.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label2.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label1.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label4.Text = "සේවක සුභ සාධනය නොකිරීම"
            'MessageBox.Show(value.ToString())
        ElseIf value = 7 Then
            Label7.Text = "වෙළදපොළේ රැදී සිටීම"
            Label6.Text = "ලාභ උපරිම නොකිරීම"
            Label5.Text = "විකුණුම් උපරිම නොකිරීම"
            Label9.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label8.Text = "පාරිභෝගික තෘප්තිය වැඩි නොකිරීම"
            Label2.Text = "කොටස්වල වෙළෙද අගය උපරිම නොකිරීම"
            Label1.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label4.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය නොකිරීම"
            Label3.Text = "සේවක සුභ සාධනය නොකිරීම"
            'MessageBox.Show(value.ToString())
        ElseIf value = 8 Then
            Label6.Text = "වෙළදපොළේ රැදී සිටීම"
            Label5.Text = "ලාභ උපරිම කිරීම"
            Label9.Text = "විකුණුම් උපරිම නොකිරීම"
            Label8.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label7.Text = "පාරිභෝගික තෘප්තිය වැඩි නොකිරීම"
            Label1.Text = "කොටස්වල වෙළෙද අගය උපරිම කිරීම"
            Label4.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label3.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය නොකිරීම"
            Label2.Text = "සේවක සුභ සාධනය"
            'MessageBox.Show(value.ToString())
        ElseIf value = 9 Then
            Label5.Text = "වෙළදපොළේ රැදී නොසිටීම"
            Label9.Text = "ලාභ උපරිම නොකිරීම"
            Label8.Text = "විකුණුම් උපරිම කිරීම"
            Label7.Text = "වෙළෙදපොළ කොටස වැඩි කර ගැනීම"
            Label1.Text = "පාරිභෝගික තෘප්තිය වැඩි කිරීම"
            Label4.Text = "කොටස්වල වෙළෙද අගය උපරිම නොකිරීම"
            Label3.Text = "ව්‍යාපාරිකයන්ගේ පුද්ගලික තෘප්තිය"
            Label2.Text = "සමාජ හා ප්‍රජාවගේ සුභසාධනය"
            Label6.Text = "සේවක සුභ සාධනය නොකිරීම"
            'MessageBox.Show(value.ToString())
        End If



    End Sub

    Private Sub Form8_MouseHover(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover, PictureBox8.MouseHover, PictureBox7.MouseHover, PictureBox6.MouseHover, PictureBox5.MouseHover, PictureBox4.MouseHover, PictureBox21.MouseHover, PictureBox20.MouseHover, PictureBox19.MouseHover, PictureBox18.MouseHover, PictureBox17.MouseHover, PictureBox16.MouseHover, PictureBox15.MouseHover, PictureBox14.MouseHover, PictureBox13.MouseHover, PictureBox12.MouseHover, PictureBox11.MouseHover, PictureBox10.MouseHover, MyBase.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub Form8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave, PictureBox8.MouseLeave, PictureBox7.MouseLeave, PictureBox6.MouseLeave, PictureBox5.MouseLeave, PictureBox4.MouseLeave, PictureBox21.MouseLeave, PictureBox20.MouseLeave, PictureBox19.MouseLeave, PictureBox18.MouseLeave, PictureBox17.MouseLeave, PictureBox16.MouseLeave, PictureBox15.MouseLeave, PictureBox14.MouseLeave, PictureBox13.MouseLeave, PictureBox12.MouseLeave, PictureBox11.MouseLeave, PictureBox10.MouseLeave, MyBase.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Theory6.Show()
    End Sub
End Class