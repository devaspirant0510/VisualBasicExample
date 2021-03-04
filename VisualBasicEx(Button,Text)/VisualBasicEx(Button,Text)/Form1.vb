Public Class Form1
    '상수 지정
    ' 변수&상수 As 자료형
    Private Const V As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("open messageBox", "title")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    '변수명 바꾸기 속성 -> name 값 변경 -> 메서드 이름은 수동으로 설정해줘야함
    Private Sub aa_Click(sender As Object, e As EventArgs) Handles aa.Click
        If TextBox1.TextLength = V Then
            MessageBox.Show("이창을 닫고 입력해라", "입력창이 비어있다.")
        Else
            MessageBox.Show($"너가 입력한 값{TextBox1.Text}", $"글자수 {TextBox1.TextLength}")
        End If

    End Sub
End Class
