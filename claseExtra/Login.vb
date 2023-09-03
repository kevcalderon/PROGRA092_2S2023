Imports MySql.Data.MySqlClient

Public Class Login
    Dim connection As MySqlConnection
    Dim comandos As MySqlCommand

    Private Sub buttonIrLogin_Click(sender As Object, e As EventArgs) Handles buttonIrLogin.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userId=root;password='';database=progra092"
        Try
            connection.Open()
            MsgBox("Conexion correctamente a BD!!!! :)")
            connection.Close()
        Catch ex As Exception
            MsgBox("Error al conectarme, no funciono :C")
            connection.Close()
        End Try

    End Sub
End Class
