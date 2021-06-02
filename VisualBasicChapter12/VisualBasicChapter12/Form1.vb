Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("제발", "잘좀해봐")
            TextBox1.Focus()
            Exit Sub
        End If

        Dim strLen As Integer = TextBox1.Text.Length
        If strLen Mod 2 = 1 Then
            If Asc(Microsoft.VisualBasic.Right(TextBox1.Text, 1)) < 0 Then
                TextBox1.Text += "다"
            ElseIf 97 <= Asc(Microsoft.VisualBasic.Right(TextBox1.Text, 1)) And
                        Asc(Microsoft.VisualBasic.Right(TextBox1.Text, 1)) <= 122 Then
                TextBox1.Text += "x"
            End If
            strLen += 1
        End If

        For i = 0 To strLen - 1
            Dim getStr = Mid(TextBox1.Text, i + 1, 1)
            If Asc(getStr) > 0 And Asc(getStr) <= 96 Or Asc(getStr) >= 122 Then
                MessageBox.Show("한글이나 영어 소문자가 아닙니다.", "제목")
                TextBox1.Focus()
                Exit Sub
            End If
        Next
        Dim result As String = ""
        For i = 0 To strLen - 1 Step 2
            Dim getStr = Mid(TextBox1.Text, i + 1, 1)
            Dim temp = Mid(TextBox1.Text, i + 2, 1)
            If 97 <= Asc(getStr) And Asc(getStr) <= 122 Then
                getStr = Chr(Asc(getStr) - 32)
                temp = Chr(Asc(temp) - 32)
            End If
            result += temp & getStr

        Next
        TextBox2.Text = result
    End Sub
End Class
