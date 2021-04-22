Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.Text)
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Remove(ListBox2.Text)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListBox1
            .Items.Add("보조배터리")
            .Items.Add("간식")
            .Items.Add("돈")
            .Items.Add("여벌옷")
            .Items.Add("이어폰")
            .Items.Add("노트북")

        End With
    End Sub
End Class