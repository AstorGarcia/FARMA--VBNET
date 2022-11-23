Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        holausu.Text = Form1.usu.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Dim connectionString As String = "Server= localhost;database= farma;user id=root; password= ;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim seleccion As MySqlCommand = New MySqlCommand

    Private Sub conectar()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion establecida")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("A ocurrido un error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conectar()
    End Sub
End Class



