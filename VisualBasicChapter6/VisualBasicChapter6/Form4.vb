Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 9 Step 3
            For j = 1 To 9
                TextBox1.Text = $"{TextBox1.Text}{i}x{j}={i * j}     {i + 1}x{j}={(i + 1) * j}      {i + 2}x{j}={(i + 2) * j}{vbCrLf}"
            Next
            TextBox1.Text = $"{TextBox1.Text}{vbCrLf}"


        Next
    End Sub
End Class