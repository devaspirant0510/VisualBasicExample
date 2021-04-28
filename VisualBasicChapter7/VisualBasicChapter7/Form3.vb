Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = TextBox1.Text
        Dim i As Integer = 1
        TextBox2.Text = ""
        Do
            TextBox2.Text = $"{TextBox2.Text} {n} x {i} = {n * i} {vbCrLf}"
            i += 1
        Loop While i <= 9
    End Sub
End Class