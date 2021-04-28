Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = TextBox1.Text
        Dim i As Integer = 1
        TextBox2.Text = ""
        Do Until i = 10
            TextBox2.Text = $"{TextBox2.Text} {n} x {i} = {n * i} {vbCrLf}"
            i += 1
        Loop
    End Sub
End Class