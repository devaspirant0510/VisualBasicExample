Public Class Form3
    Dim max1 = 5
    Dim max2 = 6
    Dim max3 = 7
    Dim cur1 = 1
    Dim cur2 = 1
    Dim cur3 = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cur1 = max1 Then
            cur1 = 1
        End If
        If cur2 = max2 Then
            cur2 = 1
        End If
        If cur3 = max3 Then
            cur3 = 1
        End If


        PictureBox1.Image = Image.FromFile($"{CurDir()}/picture1/{cur1}.jpg")
        PictureBox2.Image = Image.FromFile($"{CurDir()}/picture2/{cur2}.jpg")
        PictureBox3.Image = Image.FromFile($"{CurDir()}/picture3/{cur3}.jpg")
        cur1 += 1
        cur2 += 1
        cur3 += 1

    End Sub
End Class