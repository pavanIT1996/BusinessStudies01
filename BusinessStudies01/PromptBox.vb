Public Class PromptBox

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If ComboBox1.SelectedIndex = 0 Then
    '        Main.Show()
    '        Me.Close()
    '    ElseIf ComboBox1.SelectedIndex = 1 Then
    '        MessageBox.Show("Under Construction-I")
    '    ElseIf ComboBox1.SelectedIndex = 2 Then
    '        MessageBox.Show("Under Construction-II")
    '    Else
    '        MessageBox.Show("කරුණාකර භාෂාව තෝරන්න")
    '    End If
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Theory3.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            MessageBox.Show("Under Construction-I")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            MessageBox.Show("Under Construction-II")
        Else
            MessageBox.Show("කරුණාකර භාෂාව තෝරන්න")
        End If
    End Sub

    Private Sub PromptBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class