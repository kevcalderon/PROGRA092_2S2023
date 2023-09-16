Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonRegistrar.Click
        'seleccionar archivo.

        'OpenFileDialog1.Title = "Selecciona el archivo"
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    'Do things here, the path is stored in openFileDialog1.Filename
        '    'If no files were selected, openFileDialog1.Filename is ""  
        'End If

        'LOGICA EN LOGIN.
        If textboxNombre.Text = "admin" And textBoxContra.Text = "admin" Then
            'dirigir a pantalla correcta
        Else
            'select en base de datos
            'Select Nombre, PasswordHash from Usuario Where Nombre = '' AND PasswordHash = ''
        End If


        Dim codigoInsertar = $"INSERT INTO Usuario(Nombre, Username, PasswordHash, TipoUsuario) VALUES ('{textboxNombre.Text}', '{textBoxUsuario.Text}','{textBoxContra.Text}', 'Cliente')"
        Dim lectura As MySqlDataReader
        comandos = New MySqlCommand(codigoInsertar, connection)
        lectura = comandos.ExecuteReader
        MsgBox("Usuario registrado correctamente :D")


    End Sub

    Private Sub buttonConexion_Click(sender As Object, e As EventArgs) Handles buttonConexion.Click
        conexionBD()
    End Sub
End Class
