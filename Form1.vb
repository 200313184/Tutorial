Public Class Form1
    Dim a, b, c
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a + b
        TextBox3.Text = c


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a - b
        TextBox3.Text = c

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a * b
        TextBox3.Text = c

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = a / b
        TextBox3.Text = c

    End Sub
End Class
