Public Class Form1

    Dim variableGlobal As String = "Ingrid"

    Private Sub ButtonAlert_Click(sender As Object, e As EventArgs) Handles ButtonAlert.Click
        'Asignacion de una sola linea
        'Variable para caracteres
        Dim nombre As String = textBoxNombre.Text
        Dim carnet As Integer = textBoxCarnet.Text
        'Variable para numeros enteros
        Dim numero1 As Integer
        'variable para numeros decimales
        Dim numero2 As Double
        'variable para numeros booleanos v/f
        Dim isLogin As Boolean
        'variable para fecha 
        Dim fechaActual As Date

        variableGlobal = "Maria"

        'validacion de texto para imprimir
        If nombre = "Maria" Then

            'convertir numeros(Int, Double, Boolean) en string CStr
            'MsgBox("Mi nombre es: " + nombre + " y mi carnet es: " + CStr(carnet))

            listaEstudiantes.Items.Add("Mi nombre es: " + nombre + " y mi carnet es: " + CStr(carnet))
        End If



        LimpiarTextBox()


    End Sub

    Public Sub LimpiarTextBox()
        textBoxNombre.Text = ""
        textBoxCarnet.Text = ""

    End Sub


End Class


