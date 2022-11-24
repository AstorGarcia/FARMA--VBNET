Imports MySql.Data.MySqlClient



Public Class Form3
    Public connectionString As String = "Server= localhost;database= farma;user id=root; password= ;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Public cmd As New MySqlCommand
    Public sql As String
    Dim seleccion As MySqlCommand = New MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cod_receta.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Cant_receta.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Id_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        Else
            Crear()
        End If
    End Sub
    Public Sub Crear()
        Try
            MysqlConexion.Open()
            sql = "INSERT INTO Recetas(cod_caj,cant_rec,id_fac)VALUES(@cod_caj,@cant_rec,@id_fac)"
            cmd = New MySqlCommand(sql, MysqlConexion)
            Dim ad As MySqlParameter
            cmd.Parameters.AddWithValue("@cod_caj", Cod_receta.Text)
            cmd.Parameters.AddWithValue("@cant_rec", Cant_receta.Text)
            cmd.Parameters.AddWithValue("@id_fac", Id_factura.Text)


            cmd.ExecuteNonQuery()
            MsgBox("datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MysqlConexion.Close()
    End Sub

End Class