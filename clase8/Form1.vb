Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub buttonConexion_Click(sender As Object, e As EventArgs) Handles buttonConexion.Click
        Dim connectionString As String = "server=localhost;userId=root;password='';database=Progra092"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim tabla As String = "SELECT Id_artista, nombre FROM Artista"
        Dim command As New MySqlCommand(tabla, connection)
        Dim lectura As MySqlDataReader = command.ExecuteReader()

        listArtistas.Items.Clear()

        While lectura.Read()
            'GetString -> varchar
            'GetUInt16/32 -> enteros
            listArtistas.Items.Add(lectura.GetString("Id_artista") + "," + lectura.GetString("nombre"))
        End While

    End Sub

    Private Sub buttonEliminar_Click(sender As Object, e As EventArgs) Handles buttonEliminar.Click
        If listArtistas.SelectedIndex <> -1 Then
            Dim elementoSeleccionado As String = listArtistas.SelectedItem.ToString()
            'Dividir elemento seleccionado en dos 1,Artista1
            Dim Separacion As String() = elementoSeleccionado.Split(","c)
            'Obtengo el id
            Dim idArtista As String = Separacion(0)

            'Elimina el artista en el listbox
            listArtistas.Items.RemoveAt(listArtistas.SelectedIndex)

            'eliminar artista en base datos
            Dim connectionString As String = "server=localhost;userId=root;password='';database=Progra092"
            Dim consulta As String = "DELETE FROM Artista WHERE Id_Artista = @Id_Artista"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(consulta, connection)
                    command.Parameters.AddWithValue("@Id_Artista", idArtista)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub
End Class
