Public Class Form3
    Private Const kor As String = "kor"
    Private Const engupper As String = "engu"
    Private Const englower As String = "engl"

    Private Const korPadding As String = "가나다라마바"
    Private Const engPadding As String = "abcdef"


    Private Function CheckLanguage(str As String) As String
        Dim str2asc = Asc(str)
        If str2asc < 0 Then
            Return kor
        ElseIf Asc("a") <= str2asc And str2asc <= Asc("z") Then
            Return englower
        ElseIf Asc("A") <= str2asc And str2asc <= Asc("Z") Then
            Return engupper
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If 2 > TextBox1.Text Or TextBox1.Text > 7 Then
            MessageBox.Show("2에서 7글자 사이", "제목")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "" Then
            MessageBox.Show("빈칸채우시오")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("빈칸을 채우시오")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("빈칸을 채우시오")
            TextBox3.Focus()
            Exit Sub
        End If

        Dim stepSize As Integer = TextBox1.Text
        If TextBox2.Text.Length <> stepSize Then
            MessageBox.Show("나눌길이만큼만 입력해라")
            TextBox2.Focus()
            Exit Sub
        End If
        Dim sparseMatrix(stepSize) As Integer
        Dim upStr3 As Integer = 0 ' 3자리가 연달아 있는지세기위한 변수
        Dim upStrAll As String = "" ' 숫자 n을 받아 1부터 n까지 오름차순으로 배열하여 TextBox2 와 비교
        For i = 1 To stepSize
            upStrAll = $"{upStrAll}{i}"
        Next
        If upStrAll = TextBox2.Text Then
            MessageBox.Show("증가하는 수열은 안됩니다.", "경고")
            TextBox2.Focus()
            Exit Sub
        End If
        ' 나눌 길이만큼 배열을 0으로 초기화
        For i = 0 To stepSize - 1
            sparseMatrix(i) = 0
        Next
        For i = 0 To stepSize - 1
            ' 섞을 순서에 있는거 하나씩 뽑아옴
            Dim getStr As Integer = Mid(TextBox2.Text, i + 1, 1)
            ' 숫자 범위 체크
            If 0 < getStr And getStr < stepSize + 1 Then
                '3자리가 연달아 있는지 체크
                If i < 3 Then
                    If (i = getStr - 1) Then
                        upStr3 += 1
                    End If

                End If
                If upStr3 = 3 Then
                    MessageBox.Show("숫자 3자리가 연달아 올수는 없어요", "경고")
                    TextBox2.Focus()
                    Exit Sub
                End If
                ' sparse matrix의 값이 0이면 1을 더함
                If sparseMatrix(getStr - 1) = 0 Then
                    sparseMatrix(getStr - 1) += 1
                    ' sparse matrix의 값이 0이 아니라면 이미 한번 나온값이기 때문에 종료
                Else
                    MessageBox.Show("중복되는게 있다고", "경고")
                    TextBox2.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("숫자 범위 확인해라", "경고")
                TextBox2.Focus()
                Exit Sub
            End If
        Next

        Dim inputTextLen As Integer = Len(TextBox3.Text)
        Dim paddingLen As Integer = inputTextLen Mod stepSize
        If paddingLen <> 0 Then
            Dim getLastLang As String = CheckLanguage(Microsoft.VisualBasic.Right(TextBox3.Text, 1))
            If getLastLang = kor Then
                TextBox3.Text = $"{TextBox3.Text}{Mid(korPadding, 1, stepSize - paddingLen)}"
                inputTextLen += paddingLen
            Else
                TextBox3.Text = $"{TextBox3.Text}{Mid(engPadding, 1, stepSize - paddingLen)}"
                inputTextLen += paddingLen
            End If
        End If
        ' 섞을 순서 배열로 변환
        Dim swapArr(stepSize) As Integer
        For i = 0 To stepSize - 1
            swapArr(i) = Mid(TextBox2.Text, i + 1, 1)
        Next
        ' 암호화 시킬 문장 배열로 변환
        Dim encryArr(inputTextLen) As String
        For i = 0 To inputTextLen - 1
            encryArr(i) = Mid(TextBox3.Text, i + 1, 1)
        Next

        Dim result As String = ""
        For i = 0 To inputTextLen - 1 Step stepSize

            For j = 0 To stepSize - 1
                result = $"{result}{encryArr(i + swapArr(j) - 1)}"
            Next
        Next



        TextBox4.Text = result


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class