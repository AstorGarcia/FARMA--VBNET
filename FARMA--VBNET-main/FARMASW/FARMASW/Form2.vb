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

    Dim connectionString As String = "Server= localhost;database= farma;user id=root; password= ; convert zero datetime=True"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(connectionString)
    Dim seleccion As MySqlCommand = New MySqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        holausu.Text = Form1.usu.Text

        seleccion.Connection = MysqlConexion
        seleccion.CommandText = "SELECT * FROM Facturas"
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(seleccion)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        MysqlConexion.Close()

        seleccion.Connection = MysqlConexion
        seleccion.CommandText = "SELECT * FROM Recetas"
        Dim di As DataTable = New DataTable
        Dim dh As MySqlDataAdapter = New MySqlDataAdapter(seleccion)
        dh.Fill(di)
        DataGridView2.DataSource = di
        MysqlConexion.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub conectar()
        Try
            MysqlConexion.Open()
            MsgBox("Conexion establecida")

        Catch ex As Exception
            MsgBox("A ocurrido un error")

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        conectar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class



