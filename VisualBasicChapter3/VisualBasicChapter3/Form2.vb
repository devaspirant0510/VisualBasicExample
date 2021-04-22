Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show($"{TextBox2.Text} {TextBox1.Text} 님은 {ComboBox1.SelectedItem} 에 사십니다.", "[ 알림 ]")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Add("서울")
            .Items.Add("인천")
            .Items.Add("대전")
            .Items.Add("대구")
            .Items.Add("부산")
            .Items.Add("광주")
            .Items.Add("울산")
            .Items.Add("경기도")
            .Items.Add("충청도")
            .Items.Add("강원도")
            .Items.Add("경상도")
            .Items.Add("전라도")
            .Items.Add("제주도")
        End With
        ComboBox1.Text = ComboBox1.Items.Item(0)
    End Sub
End Class