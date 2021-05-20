Public Class Form3
    Dim shift As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        shift = TextBox4.Text
        If TextBox1.Text = "" Then
            MessageBox.Show("똑바로 해라;;;;;", "제발")
            TextBox1.Focus()
            Exit Sub
        End If
        Dim str2pwd As String = ""
        Dim lenstr = Len(TextBox1.Text)
        Dim count As Integer = 0
        Dim index As Integer = 0
        TextBox2.Text = ""
        For i = 0 To Val(TextBox1.Text.Length) - 1
            Dim getStr As String = Mid(TextBox1.Text, i + 1, 1)
            If 97 > Asc(getStr) Or 122 < Asc(getStr) Then
                MessageBox.Show("바로해", "똑")
                TextBox1.Focus()
                Exit Sub
            End If
            For j = 0 To 26 - 1
                If Asc(getStr) = 97 + j Then
                    index = j
                    Exit For
                End If
            Next
            TextBox2.Text = $"{TextBox2.Text}{Chr(((index + shift) Mod 26 + 65))}"
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("똑바로좀;;", "제발")
            TextBox2.Focus()
            Exit Sub
        End If
        Dim box2Len As Integer = Len(TextBox2.Text)
        Dim index As Integer = 0
        Dim isUpper As Boolean = False
        TextBox3.Text = ""
        For i = 0 To box2Len - 1
            Dim getStr As String = Mid(TextBox2.Text, i + 1, 1)
            If Asc(getStr) < 65 Or Asc(getStr) > 90 Then
                MessageBox.Show("대문자 쓰라", "ㅇ")
                TextBox2.SelectionStart = i
                TextBox2.SelectionLength = 1
                TextBox2.Focus()
                Exit Sub

            End If
            For j = 0 To 26 - 1
                If Asc(getStr) = j + 65 Then
                    index = j
                    Exit For
                End If
            Next
            TextBox3.Text = $"{TextBox3.Text}{Chr(((index - shift + 26) Mod 26) + 97)}"
            index = 0
        Next
    End Sub
End Class