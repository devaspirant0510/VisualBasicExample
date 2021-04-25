Public Class Form2
    Dim N As Integer
    Dim sum1 As Integer = 0
    Dim sum2 As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        N = TextBox1.Text
        TextBox3.Text = ""
        TextBox2.Text = ""
        For i = 1 To N
            If i Mod 2 = 0 Then
                sum1 += i
                TextBox3.Text = $"{TextBox3.Text} {i} +"
            Else
                TextBox2.Text = $"{TextBox2.Text} {i} +"
                sum2 += i
            End If

        Next
        TextBox2.Text = $"{TextBox2.Text} = {sum1}"
        TextBox3.Text = $"{TextBox3.Text} = {sum2}"
    End Sub
End Class