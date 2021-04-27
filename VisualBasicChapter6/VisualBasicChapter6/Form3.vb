Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        For i = 1 To 9 Step 3
            For j = 1 To 9
                For k = 0 To 2
                    TextBox1.Text = $"{TextBox1.Text} {i + k} x {j} = {(i + k) * j}      "
                Next
                TextBox1.Text = $"{TextBox1.Text}{vbCrLf}"
            Next
            TextBox1.Text = $"{TextBox1.Text}{vbCrLf}{vbCrLf}"
        Next
    End Sub
End Class