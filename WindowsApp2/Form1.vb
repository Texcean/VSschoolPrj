Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text += BunifuTextBox1.Text + " - " + BunifuTextBox2.Text

        Dim yName, yC, yOrder As Integer

        yOrder = 30

        yOrder = BunifuTextBox2.Text

        yC = yOrder

        If yC <= 30 Then
            MsgBox("Your Order Is Confirm", vbInformation, "Order Status")
        ElseIf yC >= 30 Then
            MsgBox("Only 30 Order", vbCritical, "Order Status")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
        BunifuTextBox1.Clear()
        BunifuTextBox2.Clear()
    End Sub
End Class
