Public Class Form1
    Dim nameVal = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PictureBox1.Image = Image.FromFile(CurDir() + $"/picture1/{nameVal}.jpg")
        nameVal += 1
        If nameVal = 5 Then
            nameVal = 1
        End If
    End Sub
End Class
