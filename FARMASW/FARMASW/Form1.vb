Public Class Form1
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        If usu.Text = "AstorGarcia" Then
            If contra.Text = "elpap123" Then
                Me.Hide()
                Form2.Show()
            End If
        End If
    End Sub
End Class
