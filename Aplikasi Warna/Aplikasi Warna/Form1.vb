Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Orange Then

            Me.BackColor = Color.Purple
        Else
            Me.BackColor = Color.DarkBlue


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Orange
    End Sub
End Class
