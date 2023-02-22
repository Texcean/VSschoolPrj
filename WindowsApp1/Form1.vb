Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim label1, label2, result, total1 As Integer, total2 As Integer, total3 As Integer, total4 As Integer

        label1 = TextBox1.Text

        label2 = TextBox2.Text


        total1 = CInt(label1 + label2)
        total2 = label1 - label2
        total3 = label1 * label2
        total4 = label1 / label2

        Label3.Text = total1
        Label4.Text = total2
        Label5.Text = total3
        Label6.Text = total4

    End Sub
End Class
