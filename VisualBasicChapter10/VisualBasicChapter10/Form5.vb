Public Class Form5
    ' 다른 클래스에서 Form 5의 변수 또는 함수를 사용하는게 아니라면 접근제한자는 private로 하는것이 좋음
    ' 변하지 않는 값은 상수로 지정하는것이 좋음 Const
    ' Const 상수는 한번 선언한 값은 변경하지 못함
    Private Const max1 As Integer = 9
    Private Const max2 As Integer = 6
    Private Const max3 As Integer = 10

    ' 현재 사진값 변수 선언
    Private cur1 As Integer = 1
    Private cur2 As Integer = 1
    Private cur3 As Integer = 1

    ' 속도 값을 변수로 통해 접근할수 있게 전역변수로 할당
    Private Const SLOW As Integer = 1000
    Private Const NORMAL As Integer = 500
    Private Const FAST As Integer = 100


    ' 메뉴에서 전체중지 버튼을 눌렀을때 
    Private Sub 전체중지ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 전체중지ToolStripMenuItem1.Click
        If Timer1.Enabled = True And Timer2.Enabled = True And Timer3.Enabled = True Then
            Call AllShutDown()
            전체중지ToolStripMenuItem1.Text = "전체시작"
        ElseIf Timer1.Enabled = False And Timer2.Enabled = False And Timer3.Enabled = False Then
            Call AllShutUp()
            전체중지ToolStripMenuItem1.Text = "전체중지"
        End If
    End Sub

    ' 추가 설명 : Sub는 리턴값이 없는 함수 Function은 리턴값이 있는 함수
    ' 모든 타이머를 False 로 바꿈
    Private Sub AllShutDown()
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub

    ' 모든 타이머를 True로 바꿈
    Private Sub AllShutUp()
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub

    ' 파라미터로 speed 값을 받아 모든 타이머의 스피드 지정
    Private Sub setSpeed(speed As Integer)
        Timer1.Interval = speed : Timer2.Interval = speed : Timer3.Interval = speed
    End Sub

    ' 초기 속도값 설정
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setSpeed(NORMAL)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cur1 > max1 Then
            cur1 = 1
        End If
        PictureBox1.Image = Image.FromFile($"{CurDir()}/picture1/{cur1}.jpg")
        cur1 += 1


    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If cur2 > max2 Then
            cur2 = 1
        End If
        PictureBox2.Image = Image.FromFile($"{CurDir()}/picture2/{cur2}.jpg")
        cur2 += 1

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If cur3 > max3 Then
            cur3 = 1
        End If
        PictureBox3.Image = Image.FromFile($"{CurDir()}/picture3/{cur3}.jpg")
        cur3 += 1
    End Sub

    Private Sub 종료ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem1.Click
        End
    End Sub

    ' 전체 속도 조절 빠르게
    Private Sub 빠르게ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles 빠르게ToolStripMenuItem5.Click
        Call setSpeed(FAST)
    End Sub

    ' 전체 속도 조절 중간
    Private Sub 중간ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 중간ToolStripMenuItem4.Click
        Call setSpeed(NORMAL)
    End Sub

    ' 전체 속도 조절 느리게
    Private Sub 느리게1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 느리게1ToolStripMenuItem.Click
        Call setSpeed(SLOW)
    End Sub



    ' 책정리하기 -> 빠르게
    Private Sub 빠르게ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles 빠르게ToolStripMenuItem6.Click
        Timer1.Interval = FAST
    End Sub
    ' 책정리하기 -> 중간
    Private Sub 중간ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles 중간ToolStripMenuItem5.Click
        Timer1.Interval = NORMAL
    End Sub
    ' 책정리하기 -> 느리게
    Private Sub 느리ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 느리ToolStripMenuItem.Click
        Timer1.Interval = SLOW
    End Sub

    ' 뭔가 좀 이상한 자동문 -> 빠르게
    Private Sub 빠르게ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles 빠르게ToolStripMenuItem7.Click
        Timer2.Interval = FAST
    End Sub

    ' 뭔가 좀 이상한 자동문 -> 중간
    Private Sub 중간ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles 중간ToolStripMenuItem6.Click
        Timer2.Interval = NORMAL
    End Sub

    ' 뭔가 좀 이상한 자동문 -> 느리게
    Private Sub 느리게ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 느리게ToolStripMenuItem4.Click
        Timer2.Interval = SLOW
    End Sub

    ' 가출하는 마우스 -> 빠르게
    Private Sub 빠르게ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles 빠르게ToolStripMenuItem8.Click
        Timer3.Interval = FAST
    End Sub
    ' 가출하는 마우스 -> 중간
    Private Sub 중간ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles 중간ToolStripMenuItem7.Click
        Timer3.Interval = NORMAL
    End Sub
    ' 가출하는 마우스 -> 느리게
    Private Sub 느리게ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles 느리게ToolStripMenuItem5.Click
        Timer3.Interval = SLOW
    End Sub

    Private Sub 개발환경ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 개발환경ToolStripMenuItem1.Click
        MessageBox.Show($"[ 운영체제 ] Windows10 Home{Environment.NewLine}[ 개발툴 ]Visual Basic 2019 ", "[개발환경]")
    End Sub

    Private Sub 개발자소개ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 개발자소개ToolStripMenuItem1.Click
        Dim develop As Form6 = New Form6
        develop.Show()
        Me.Hide()
    End Sub


    Private Sub 교수님에게하고픈말ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 교수님에게하고픈말ToolStripMenuItem1.Click
        Dim form7 As Form7 = New Form7
        form7.Show()
        Me.Hide()
    End Sub

End Class