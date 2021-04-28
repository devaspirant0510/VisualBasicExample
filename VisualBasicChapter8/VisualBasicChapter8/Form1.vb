Public Class Form1
    Private Function Get_Grade(score As Integer) As String
        Dim gradeArray = New String() {"D+", "C0", "C+", "B0", "B+", "A0", "A+"}
        If score >= 96 Then
            Return "A+"
        ElseIf score >= 92 Then
            Return "A0"
        ElseIf score >= 88 Then
            Return "B+"
        ElseIf score >= 84 Then
            Return "B0"
        ElseIf score >= 80 Then
            Return "C+"
        ElseIf score >= 76 Then
            Return "C0"
        ElseIf score >= 72 Then
            Return "D+"
        ElseIf score >= 68 Then
            Return "D0"
        Else
            Return "F"
        End If

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9}
        Dim output = New TextBox() {TextBox18, TextBox17, TextBox16, TextBox15, TextBox14, TextBox13, TextBox12, TextBox11, TextBox10}
        For i = 0 To input.Length() - 1
            Dim getStr = Val(input(i).Text)
            If getStr <= 0 Or getStr > 100 Then
                MessageBox.Show($"0에서 100사이만 입력해", $"[waring TextBox{i + 1}]") : input(i).Focus()
                Exit Sub
            End If
        Next
        For i = 0 To output.Length() - 1
            output(i).Text = Get_Grade(input(i).Text)
        Next
    End Sub
End Class
