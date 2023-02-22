Public Class Form1
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim yAge As Integer = 0

        yAge = Val(BunifuTextBox1.Text)

        If yAge >= 18 And yAge <= 59 Then
            MsgBox("You Are Not A Minor", vbInformation, "Your Age")
        ElseIf yAge >= 60 Then
            MsgBox("You Are Senior Citizen", vbInformation, "Your Age")
        Else
            MsgBox("You Are A Minor!", vbCritical, "Your Age")
        End If
    End Sub
End Class
