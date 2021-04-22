Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getStr As String
        getStr = TextBox1.Text
        TextBox2.Text = Microsoft.VisualBasic.Left(getStr, 3)
        TextBox3.Text = Microsoft.VisualBasic.Right(getStr, 3)
        TextBox4.Text = Mid(getStr, 5, 3)
        TextBox5.Text = Len(getStr)

    End Sub
End Class