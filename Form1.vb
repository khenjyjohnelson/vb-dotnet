Public Class Form1
    Private Sub Btnstart_Click(sender As Object, e As EventArgs) Handles Btnstart.Click
        MessageBox.Show("Hello, World! " & Txtnama.Text & "!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
