Public Class Form1
    Dim outputText As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        outputText = "당신이 사용하는 데이터베이스는" & Chr(13)
        If RadioButton1.Checked = True Then
            outputText = outputText & RadioButton1.Text
        End If
        If RadioButton2.Checked = True Then
            outputText = outputText & RadioButton2.Text
        End If
        If RadioButton3.Checked = True Then
            outputText = outputText & RadioButton3.Text
        End If
        If RadioButton4.Checked = True Then
            outputText = outputText & RadioButton4.Text
        End If
        If RadioButton5.Checked = True Then
            outputText = outputText & RadioButton5.Text
        End If
        If RadioButton6.Checked = True Then
            outputText = outputText & RadioButton6.Text
        End If
        outputText = outputText & Chr(13) & Chr(13) & "당신이 사용하는 언어는 " & Chr(13)
        If CheckBox1.Checked = True Then
            outputText = outputText & CheckBox1.Text & Chr(13)
        End If
        If CheckBox2.Checked = True Then
            outputText = outputText & CheckBox2.Text & Chr(13)
        End If
        If CheckBox3.Checked = True Then
            outputText = outputText & CheckBox3.Text & Chr(13)
        End If
        If CheckBox4.Checked = True Then
            outputText = outputText & CheckBox4.Text & Chr(13)
        End If
        If CheckBox5.Checked = True Then
            outputText = outputText & CheckBox5.Text & Chr(13)
        End If
        If CheckBox6.Checked = True Then
            outputText = outputText & CheckBox6.Text & Chr(13)
        End If
        Label1.Text = outputText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
