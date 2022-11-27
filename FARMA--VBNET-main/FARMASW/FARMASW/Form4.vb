Imports MySql.Data.MySqlClient

Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Dim connectionString As String = "Server= localhost;database= farma;user id=root; password= ;"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim seleccion As MySqlCommand = New MySqlCommand
    Public cmd As New MySqlCommand
    Public sql As String


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If Id_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Cant_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Imp_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Dom_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        ElseIf Ven_factura.Text = "" Then
            MsgBox("Casilla Incompleta")
        Else
            Crear()
        End If
    End Sub
    Public Sub Crear()

        Try
            Dim fecha As String = Format(CDate(Ven_factura.Text), "yyyy/MM/dd")
            MysqlConexion.Open()
            sql = "INSERT INTO Facturas(id_fac,cant_fac,imp_fac,dom_fac,ven_fac)VALUES(@id_fac,@cant_fac,@imp_fac,@dom_fac,@ven_fac)"
            cmd = New MySqlCommand(sql, MysqlConexion)
            Dim ad As MySqlParameter
            cmd.Parameters.AddWithValue("@id_fac", Id_factura.Text)
            cmd.Parameters.AddWithValue("@cant_fac", Cant_factura.Text)
            cmd.Parameters.AddWithValue("@imp_fac", Imp_factura.Text)
            cmd.Parameters.AddWithValue("@dom_fac", Dom_factura.Text)
            cmd.Parameters.AddWithValue("@ven_fac", fecha)


            cmd.ExecuteNonQuery()
            MsgBox("datos guardados")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MysqlConexion.Close()
    End Sub


End Class