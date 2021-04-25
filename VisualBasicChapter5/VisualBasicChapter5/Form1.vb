Public Class Form1
    Dim sum As Integer = 0
    Dim N As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        N = TextBox1.Text
        For i = 1 To N - 1
            sum += i
            TextBox2.Text = $"{TextBox2.Text} {i} + "
            TextBox3.Text = $"{TextBox3.Text} {N - i + 1} + "
        Next

        sum += N
        TextBox2.Text = $" {TextBox2.Text} {N} = {sum}"
        TextBox3.Text = $"{TextBox3.Text} 1 = {sum}"
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
