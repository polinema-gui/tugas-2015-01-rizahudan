Public Class Form1
    Dim x As Integer = 0
    Private Sub ubahButton_Click(sender As Object, e As EventArgs) Handles ubahButton.Click
        Select Case Me.x
            Case 0
                Me.BackColor = Color.White
                Me.x = 1
            Case 1
                Me.BackColor = Color.Red
                Me.x = 0
        End Select
    End Sub
End Class
