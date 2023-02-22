Imports Microsoft.SqlServer

Public Class Form1
    Private Sub BunifuTextBox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChanged

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Application.Exit()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If BunifuTextBox1.Text = "" Then
            MessageBox.Show("Please enter your username")
            BunifuTextBox1.Focus()
            Exit Sub
        ElseIf BunifuTextBox2.Text = "" Then
            MessageBox.Show("Please enter your password")
            BunifuTextBox2.Focus()
            Exit Sub
        End If
        If BunifuTextBox1.Text = "Jeyms22" And BunifuTextBox2.Text = "admin" Then
            MessageBox.Show("Welcome! Have a Great Day.")
        Else
            MessageBox.Show("Incorrect Username or Password")
        End If
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Process.Start("https://www.facebook.com/jeymsmaykel22")

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Process.Start("https://github.com/Texcean")
    End Sub
End Class

