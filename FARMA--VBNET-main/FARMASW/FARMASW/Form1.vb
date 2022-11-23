Public Class Form1
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        If usu.Text = "Astor" Then
            If contra.Text = "12345" Then
                Me.Hide()
                Form2.Show()
            End If
        End If
        If usu.Text = "Luciano" Then
            If contra.Text = "12345" Then
                Me.Hide()
                Form2.Show()
            End If
        End If
        If usu.Text = "Facundo" Then
            If contra.Text = "12345" Then
                Me.Hide()
                Form2.Show()
            End If
        End If
        If usu.Text = "Maia" Then
            If contra.Text = "12345" Then
                Me.Hide()
                Form2.Show()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
