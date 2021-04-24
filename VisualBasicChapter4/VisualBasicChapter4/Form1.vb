Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "+"
        TextBox3.Text = num1 + +num2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "-"
        TextBox3.Text = num1 - num2
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "x"
        TextBox3.Text = num1 * num2
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "/"
        TextBox3.Text = num1 / num2
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "mod"
        TextBox3.Text = num1 Mod num2
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num1 = TextBox1.Text
        Dim num2 = TextBox2.Text
        Label4.Text = "mod"
        TextBox3.Text = num1 ^ num2
    End Sub
End Class
