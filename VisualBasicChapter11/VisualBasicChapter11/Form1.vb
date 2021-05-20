Public Class Form1
    Dim alphabetArraySmaller() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                            "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                            "u", "v", "w", "x", "y", "z"}
    Dim alphabetArrayBigger() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                            "U", "V", "W", "X", "Y", "Z"}
    Dim alphaLen As Integer = 26
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            For j = 0 To 26 - 1
                If getStr = alphabetArraySmaller(j) Then
                    count = 1
                    index = j
                    Exit For
                End If
            Next
            If count = 0 Then
                MessageBox.Show("제발 소문자만 입력하라고ㅎ;^^", "하....")
                TextBox1.Focus()
                TextBox1.SelectionStart = i
                TextBox1.SelectionLength = 1
                Exit Sub
            End If
            TextBox2.Text = $"{TextBox2.Text}{alphabetArrayBigger((index + 3) Mod 26)}"
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
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
            For j = 0 To 26 - 1
                If getStr = alphabetArrayBigger(j) Then
                    index = j
                    isUpper = True
                End If
            Next
            If isUpper = False Then
                MessageBox.Show("대문자 쓰라", "ㅇ")
                TextBox2.SelectionStart = i
                TextBox2.SelectionLength = 1
                TextBox2.Focus()
                Exit Sub

            End If
            If index - 3 < 0 Then
                TextBox3.Text = $"{TextBox3.Text} {alphabetArraySmaller(index - 3 + 26)}"
            Else
                TextBox3.Text = $"{TextBox3.Text} {alphabetArraySmaller(index - 3)}"
            End If
            isUpper = False
            index = 0
        Next
    End Sub
End Class
