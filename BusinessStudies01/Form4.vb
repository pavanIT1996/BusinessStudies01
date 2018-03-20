Public Class Form4
    Dim audiofile As String = "Kriyakarakam1.2.wav"
    Dim sound2 As New Media.SoundPlayer(audiofile)
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sound2.Play()
        Dim value As Integer = CInt(Int((10 * Rnd()) + 1))

        If value = 1 Then
            Label5.Text = "සීමිත වේ."
            Label4.Text = "අසීමිත වේ."
            Label3.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label2.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label1.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label10.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label9.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label8.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label7.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label6.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            'MessageBox.Show(value.ToString())
        ElseIf value = 2 Then
            Label4.Text = "සීමිත වේ."
            Label3.Text = "අසීමිත වේ."
            Label2.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label1.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label5.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label6.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label10.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label9.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label8.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label7.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            'MessageBox.Show(value.ToString())
        ElseIf value = 3 Then
            Label3.Text = "සීමිත වේ."
            Label2.Text = "අසීමිත වේ."
            Label1.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label5.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label4.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label7.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label6.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label10.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label9.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label8.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 4 Then
            Label2.Text = "සීමිත වේ."
            Label1.Text = "අසීමිත වේ."
            Label5.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label4.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label3.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label8.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label7.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label6.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label10.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label9.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            'MessageBox.Show(value.ToString())
        ElseIf value = 5 Then
            Label1.Text = "සීමිත වේ."
            Label5.Text = "අසීමිත වේ."
            Label4.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label3.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label2.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label9.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label8.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label7.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label6.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label10.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 6 Then
            Label6.Text = "සීමිත වේ."
            Label7.Text = "අසීමිත වේ."
            Label8.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label9.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label10.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label1.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label2.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label3.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label4.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label5.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 7 Then
            Label7.Text = "සීමිත වේ."
            Label8.Text = "අසීමිත වේ."
            Label9.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label10.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label6.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label2.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label3.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label4.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label5.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label1.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 8 Then
            Label8.Text = "සීමිත වේ."
            Label9.Text = "අසීමිත වේ."
            Label10.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label6.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label7.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label3.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label4.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label5.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label1.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label2.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 9 Then
            Label9.Text = "සීමිත වේ."
            Label10.Text = "අසීමිත වේ."
            Label6.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label7.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label8.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label4.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label5.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label1.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label2.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label3.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        ElseIf value = 10 Then
            Label10.Text = "සීමිත වේ."
            Label6.Text = "අසීමිත වේ."
            Label7.Text = "සෑම පුද්ගලයාටම පොදුයි."
            Label8.Text = "පුද්ගලයාගෙන් පුද්ගලයාට වෙනස් වේ."
            Label9.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ."
            Label5.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු නොවේ."
            Label1.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය."
            Label2.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ හැකි ය."
            Label3.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය."
            Label4.Text = "සමාජ බලවේග මගින් වෙනස්  කළ හැකි ය."
            ' MessageBox.Show(value.ToString())
        End If

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Label1.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        Label1.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Label2.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Label2.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Label3.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Label3.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Label4.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Label4.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        Label5.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Label5.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        Label6.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        Label6.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        Label7.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        Label7.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        Label8.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        Label8.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        Label9.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Label9.BackColor = Color.Lime
        check()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Label10.BackColor = Color.Yellow
        check()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        Label10.BackColor = Color.Lime
        check()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Label1.BackColor = Color.Violet And Label2.BackColor = Color.Violet And Label3.BackColor = Color.Violet And Label4.BackColor = Color.Violet And Label5.BackColor = Color.Violet And Label6.BackColor = Color.Violet And Label7.BackColor = Color.Violet And Label8.BackColor = Color.Violet And Label9.BackColor = Color.Violet And Label10.BackColor = Color.Violet Then
            MessageBox.Show("සැකසීමට කිසිවක් නොමැත")
        Else

            Form4_Load(Me, e)
            Label1.BackColor = Color.Violet
            Label2.BackColor = Color.Violet
            Label3.BackColor = Color.Violet
            Label4.BackColor = Color.Violet
            Label5.BackColor = Color.Violet
            Label6.BackColor = Color.Violet
            Label7.BackColor = Color.Violet
            Label8.BackColor = Color.Violet
            Label9.BackColor = Color.Violet
            Label10.BackColor = Color.Violet
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
            PictureBox54.Visible = False
            PictureBox55.Visible = False

        End If
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover, PictureBox2.MouseHover, PictureBox1.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave, PictureBox2.MouseLeave, PictureBox1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    'Private Sub check()
    '    If (Label1.BackColor = Color.Yellow And Label2.BackColor = Color.Lime And Label3.BackColor = Color.Yellow And Label4.BackColor = Color.Lime And Label5.BackColor = Color.Yellow And Label6.BackColor = Color.Lime And Label7.BackColor = Color.Yellow And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Yellow And Label10.BackColor = Color.Lime) Then
    '        MessageBox.Show("All Are Correct")
    '    End If
    'End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sound2.Stop()
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub check()
        If Label1.BackColor = Color.Violet Or Label2.BackColor = Color.Violet Or
        Label3.BackColor = Color.Violet Or Label4.BackColor = Color.Violet Or
        Label5.BackColor = Color.Violet Or Label6.BackColor = Color.Violet Or
        Label7.BackColor = Color.Violet Or Label8.BackColor = Color.Violet Or
        Label9.BackColor = Color.Violet Or Label10.BackColor = Color.Violet Then

        Else
            If Label1.Text = "සීමිත වේ." Or
                    Label1.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label1.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label1.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label1.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label1.BackColor = Color.Lime Then
                    ' MessageBox.Show("1-Correct")
                    PictureBox37.Visible = True
                    PictureBox36.Visible = False
                Else
                    ' MessageBox.Show("1-Wrong")
                    PictureBox36.Visible = True
                    PictureBox37.Visible = False
                End If
            Else
                If Label1.BackColor = Color.Yellow Then
                    ' MessageBox.Show("1-Correct")
                    PictureBox37.Visible = True
                    PictureBox36.Visible = False
                Else
                    ' MessageBox.Show("1-Wrong")
                    PictureBox36.Visible = True
                    PictureBox37.Visible = False
                End If

            End If
            If Label2.Text = "සීමිත වේ." Or
                    Label2.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label2.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label2.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label2.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label2.BackColor = Color.Lime Then
                    ' MessageBox.Show("2-Correct")
                    PictureBox39.Visible = True
                    PictureBox38.Visible = False
                Else
                    '  MessageBox.Show("2-Wrong")
                    PictureBox38.Visible = True
                    PictureBox39.Visible = False
                End If
            Else
                If Label2.BackColor = Color.Yellow Then
                    ' MessageBox.Show("2-Correct")
                    PictureBox39.Visible = True
                    PictureBox38.Visible = False
                Else
                    '  MessageBox.Show("2-Wrong")
                    PictureBox38.Visible = True
                    PictureBox39.Visible = False
                End If
            End If
            If Label3.Text = "සීමිත වේ." Or
                    Label3.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label3.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label3.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label3.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label3.BackColor = Color.Lime Then
                    ' MessageBox.Show("3-Correct")
                    PictureBox41.Visible = True
                    PictureBox40.Visible = False
                Else
                    ' MessageBox.Show("3-Wrong")
                    PictureBox40.Visible = True
                    PictureBox41.Visible = False
                End If
            Else
                If Label3.BackColor = Color.Yellow Then
                    ' MessageBox.Show("3-Correct")
                    PictureBox41.Visible = True
                    PictureBox40.Visible = False
                Else
                    ' MessageBox.Show("3-Wrong")
                    PictureBox40.Visible = True
                    PictureBox41.Visible = False
                End If
            End If
            If Label4.Text = "සීමිත වේ." Or
                    Label4.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label4.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label4.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label4.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label4.BackColor = Color.Lime Then
                    ' MessageBox.Show("4-Correct")
                    PictureBox43.Visible = True
                    PictureBox42.Visible = False
                Else
                    ' MessageBox.Show("4-Wrong")
                    PictureBox42.Visible = True
                    PictureBox43.Visible = False
                End If
            Else
                If Label4.BackColor = Color.Yellow Then
                    ' MessageBox.Show("4-Correct")
                    PictureBox43.Visible = True
                    PictureBox42.Visible = False
                Else
                    ' MessageBox.Show("4-Wrong")
                    PictureBox42.Visible = True
                    PictureBox43.Visible = False
                End If
            End If
            If Label5.Text = "සීමිත වේ." Or
                    Label5.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label5.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label5.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label5.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label5.BackColor = Color.Lime Then
                    '  MessageBox.Show("5-Correct")
                    PictureBox45.Visible = True
                    PictureBox44.Visible = False
                Else
                    ' MessageBox.Show("5-Wrong")
                    PictureBox44.Visible = True
                    PictureBox45.Visible = False
                End If
            Else
                If Label5.BackColor = Color.Yellow Then
                    '  MessageBox.Show("5-Correct")
                    PictureBox45.Visible = True
                    PictureBox44.Visible = False
                Else
                    ' MessageBox.Show("5-Wrong")
                    PictureBox44.Visible = True
                    PictureBox45.Visible = False
                End If
            End If
            If Label6.Text = "සීමිත වේ." Or
                    Label6.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label6.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label6.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label6.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label6.BackColor = Color.Lime Then
                    ' MessageBox.Show("6-Correct")
                    PictureBox47.Visible = True
                    PictureBox46.Visible = False
                Else
                    ' MessageBox.Show("6-Wrong")
                    PictureBox46.Visible = True
                    PictureBox47.Visible = False
                End If
            Else
                If Label6.BackColor = Color.Yellow Then
                    ' MessageBox.Show("6-Correct")
                    PictureBox47.Visible = True
                    PictureBox46.Visible = False
                Else
                    ' MessageBox.Show("6-Wrong")
                    PictureBox46.Visible = True
                    PictureBox47.Visible = False
                End If
            End If
            If Label7.Text = "සීමිත වේ." Or
                    Label7.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label7.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label7.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label7.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label7.BackColor = Color.Lime Then
                    ' MessageBox.Show("7-Correct")
                    PictureBox49.Visible = True
                    PictureBox48.Visible = False
                Else
                    ' MessageBox.Show("7-Wrong")
                    PictureBox48.Visible = True
                    PictureBox49.Visible = False
                End If
            Else
                If Label7.BackColor = Color.Yellow Then
                    ' MessageBox.Show("7-Correct")
                    PictureBox49.Visible = True
                    PictureBox48.Visible = False
                Else
                    ' MessageBox.Show("7-Wrong")
                    PictureBox48.Visible = True
                    PictureBox49.Visible = False
                End If
            End If
            If Label8.Text = "සීමිත වේ." Or
                    Label8.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label8.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label8.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label8.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label8.BackColor = Color.Lime Then
                    '  MessageBox.Show("8-Correct")
                    PictureBox51.Visible = True
                    PictureBox50.Visible = False
                Else
                    ' MessageBox.Show("8-Wrong")
                    PictureBox50.Visible = True
                    PictureBox51.Visible = False
                End If
            Else
                If Label8.BackColor = Color.Yellow Then
                    '  MessageBox.Show("8-Correct")
                    PictureBox51.Visible = True
                    PictureBox50.Visible = False
                Else
                    ' MessageBox.Show("8-Wrong")
                    PictureBox50.Visible = True
                    PictureBox51.Visible = False
                End If
            End If
            If Label9.Text = "සීමිත වේ." Or
                    Label9.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label9.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label9.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label9.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label9.BackColor = Color.Lime Then
                    ' MessageBox.Show("9-Correct")
                    PictureBox53.Visible = True
                    PictureBox52.Visible = False
                Else
                    ' MessageBox.Show("9-Wrong")
                    PictureBox52.Visible = True
                    PictureBox53.Visible = False
                End If
            Else
                If Label9.BackColor = Color.Yellow Then
                    ' MessageBox.Show("9-Correct")
                    PictureBox53.Visible = True
                    PictureBox52.Visible = False
                Else
                    ' MessageBox.Show("9-Wrong")
                    PictureBox52.Visible = True
                    PictureBox53.Visible = False
                End If
            End If
            If Label10.Text = "සීමිත වේ." Or
                    Label10.Text = "සෑම පුද්ගලයාටම පොදුයි." Or
                    Label10.Text = "ජීවත්වීම සදහා අත්‍යවශ්‍යයෙන්ම සපුරාගත යුතු වේ." Or
                    Label10.Text = "ව්‍යාපාරිකයන්ට නිර්මාණය කළ නොහැකි ය." Or
                    Label10.Text = "සමාජ බලවේග මගින් වෙනස්  කළ නොහැකි ය." Then
                If Label10.BackColor = Color.Lime Then
                    'MessageBox.Show("10-Correct")
                    PictureBox55.Visible = True
                    PictureBox54.Visible = False
                Else
                    'MessageBox.Show("10-Wrong")
                    PictureBox54.Visible = True
                    PictureBox55.Visible = False
                End If
            Else
                If Label10.BackColor = Color.Yellow Then
                    'MessageBox.Show("10-Correct")
                    PictureBox55.Visible = True
                    PictureBox54.Visible = False
                Else
                    'MessageBox.Show("10-Wrong")
                    PictureBox54.Visible = True
                    PictureBox55.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        sound2.Stop()
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        sound2.Stop()
        Me.Hide()
        Theory5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Close()
        Theory3.Show()

    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Theory3.Show()
    End Sub
End Class