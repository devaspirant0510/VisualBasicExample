Public Class Form2
    Dim wating As Integer = 0
    Dim red As Integer = 1
    Dim yellow As Integer = 2
    Dim green As Integer = 3
    Private Sub ChangeImage(Color As Integer)
        Select Case Color
            Case wating
                picTraffic.Image = Image.FromFile(CurDir() + "\신호등(준비중).png")
            Case red
                picTraffic.Image = Image.FromFile(CurDir() + "\신호등(적색).png")
            Case yellow
                picTraffic.Image = Image.FromFile(CurDir() + "\신호등(노란색).png")
            Case green
                picTraffic.Image = Image.FromFile(CurDir() + "\신호등(녹색).png")
        End Select
    End Sub
    Dim time As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        ChangeImage(time)
        If time = 3 Then
            time = 0
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeImage(wating)
    End Sub
End Class