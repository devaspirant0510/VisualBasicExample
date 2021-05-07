Public Class Form2
    Dim nameVal As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Image.FromFile(CurDir() + $"/picture3/{nameVal}.jpg")
        nameVal += 1
        If nameVal = 7 Then
            nameVal = 1
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "미친토끼 ㅋㅋ"
        Timer1.Enabled = True
        Timer1.Interval = 10
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
End Class