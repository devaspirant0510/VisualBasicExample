Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = $"{TextBox1.Text}  님 환영합니다. 당신의 학번은 {TextBox3.Text} 이고, 입문자가 된걸 진심으로 축하해요"
        MessageBox.Show(TextBox2.Text, "[ 경 가입 축]")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
