Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("입력해라", "경고한다")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("입력해라", "경고한다.")
            TextBox1.Focus()
            Exit Sub
        End If
        If Len(TextBox1.Text) <> 3 Then
            MessageBox.Show("3글자만;;;", "경고한다.")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox1.Text = 123 Then
            MessageBox.Show("123 치지마셈", "경고한다.")
            TextBox1.Focus()
            Exit Sub
        End If

        ' 중복체크 하기위한 배열 0으로 초기화
        Dim counter = New Integer() {0, 0, 0}
        Dim swapArr = New Integer() {0, 0, 0}
        For i = 1 To 3
            ' 입력한 수를 Mid 함수를 통해 하나하나 분리시킴
            Dim getInt As Integer = Mid(TextBox1.Text, i, 1)
            ' 각각의 숫자들이 1에서 3사이일때만 처리 나머지경우는 거름
            If getInt > 0 And getInt < 4 Then
                swapArr(i - 1) = getInt
                ' 하나하나뽑은 숫자를 순서에 맞게 배열에 넣음 
                ' 예시 Mid 로 뽑은 수가 1 일경우 0번째 배열에 1 증가 
                '      Mid 로 뽑은 수가 2 일경우 1번째 배열에 1 증가
                '      Mid 로 뽑은 수가 3 일경우 2번째 배열에 1 증가
                ' 즉 중복값이 안나올려면 앞에서 선언한 배열이 {1,1,1} 형태로 되야함
                If counter(getInt - 1) = 0 Then
                    counter(getInt - 1) += 1

                Else
                    MessageBox.Show("중복되는 숫자가 나오잖아", "경고한다.")
                    TextBox1.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("1과 3 사이에서만 쳐라", "경고한다.")
                TextBox1.Focus()
                Exit Sub
            End If
        Next
        ' 글자수가 3으로 나누어떨어지지 않을경우 마지막글자가 한글이면 가, 나로 채움 영어이면 x, y로 채움
        Dim textLen As Integer = Len(TextBox2.Text)
        If textLen Mod 3 <> 0 Then

            If 96 < Asc(Microsoft.VisualBasic.Right(TextBox2.Text, 1)) And
                    Asc(Microsoft.VisualBasic.Right(TextBox2.Text, 1)) < 123 Then
                If textLen Mod 3 = 1 Then
                    textLen += 2
                    TextBox2.Text += "xy"
                Else
                    textLen += 1
                    TextBox2.Text += "x"
                End If
            ElseIf Asc(Microsoft.VisualBasic.Right(TextBox2.Text, 1)) < 0 Then
                If textLen Mod 3 = 1 Then
                    textLen += 2
                    TextBox2.Text += "가나"
                Else
                    textLen += 1
                    TextBox2.Text += "가"
                End If
            End If
        End If

        Dim getStringArr(textLen) As String
        ' 특수문자나 대문자가 포함되있는지 체크
        For i = 0 To textLen - 1
            Dim getText As String = Mid(TextBox2.Text, i + 1, 1)
            If 0 < Asc(getText) And 96 > Asc(getText) Or Asc(getText) > 123 Then
                MessageBox.Show("대문자나 특수문자는 올수없다;")
                TextBox2.Focus()
                Exit Sub
            End If
            getStringArr(i) = getText

        Next

        Dim resultArr(textLen) As String
        For i = 0 To textLen - 1 Step 3
            'Label1.Text = $"{Label1.Text} {swapArr(0)} {swapArr(1)} {swapArr(2)}"

            resultArr(i) = getStringArr(i + swapArr(0) - 1)
            resultArr(i + 1) = getStringArr(i + swapArr(1) - 1)
            resultArr(i + 2) = getStringArr(i + swapArr(2) - 1)
        Next
        TextBox3.Text = ""
        For i = 0 To textLen - 1
            If 96 < Asc(resultArr(i)) And Asc(resultArr(i)) < 123 Then
                resultArr(i) = Chr(Asc(resultArr(i)) - 32)
            End If
            TextBox3.Text = $"{TextBox3.Text}{resultArr(i)}"
        Next
    End Sub
End Class