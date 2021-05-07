Public Class Form4

    Dim max1 = 5
    Dim max2 = 6
    Dim max3 = 7
    Dim cur1 = 1
    Dim cur2 = 1
    Dim cur3 = 1

    Dim SLOW = 500
    Dim NORMAL = 300
    Dim FAST = 100

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cur1 = max1 Then
            cur1 = 1
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
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Minimum = 1
        HScrollBar1.Maximum = 500
        HScrollBar1.RightToLeft = RightToLeft.Yes
        HScrollBar1.Value = 1
        Timer1.Interval = HScrollBar1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = SLOW
        HScrollBar1.Value = SLOW
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Interval = NORMAL
        HScrollBar1.Value = NORMAL
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Interval = FAST
        HScrollBar1.Value = FAST
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Timer1.Interval = HScrollBar1.Value + 1
    End Sub
End Class