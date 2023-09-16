Imports MySql.Data.MySqlClient

Module Conexion
    Public connection As MySqlConnection
    Public comandos As MySqlCommand

    Sub conexionBD()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userId=root;password='';database=clase7"

        Try
            connection.Open()
            MsgBox("Conexion satisfactoria.")
        Catch ex As Exception
            MsgBox("Error no hay conexion :(")
            connection.Close()
        End Try
    End Sub

End Module
