Imports System.Drawing.Text

Public Class Form1
    Private Sub BunifuTextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim BunifuLabel1, BunifuLabel2, BunifuLabel3, BunifuLabel4, total As Integer

        BunifuLabel1 = BunifuTextBox1.Text
        BunifuLabel2 = BunifuTextBox2.Text
        BunifuLabel3 = BunifuTextBox3.Text

        total = BunifuLabel1 + BunifuLabel2 + BunifuLabel3
        BunifuLabel4 = total / 3

        BunifuTextBox4.Text = BunifuLabel4




    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        BunifuTextBox1.Clear()
        BunifuTextBox2.Clear()
        BunifuTextBox3.Clear()
        BunifuTextBox4.Clear()

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Application.Exit()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        WindowState = WindowState.Minimized
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        WindowState = WindowState.Maximized
    End Sub
End Class
