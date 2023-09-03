Public Class Form1
    Private Sub cicloButton_Click(sender As Object, e As EventArgs) Handles cicloButton.Click

        'Ejercicio FOR
        Dim i As Integer = 0
        Dim totalRepeticion As Integer = 10

        'incremental
        'For i = 1 To totalRepeticion
        '    listBoxCiclos.Items.Add($"Esta linea ha sido repetida {i} veces")
        'Next

        'decrement
        'For x As Integer = 25 To 0 Step -5
        '    listBoxCiclos.Items.Add($"Esta linea ha sido repetida {x} veces")
        'Next


        Dim suma As Integer = 0
        Dim contador As Integer = 0
        Do While suma < 100
            ' 1era. suma = 0 + 20 = 20
            ' 2da. suma = 20 + 20 = 40
            ' 3ra. suma = 40 + 20 = 60
            ' 4ta. suma = 60 + 20 = 80
            ' 5ta. suma = 80 + 20 = 100
            suma = suma + 20
            '1era. contador = 0 + 1 = 1
            '2da. contador = 1 +1 = 2
            '3era. contador = 2+1=3
            '4ta. contador = 3+1=4
            '5ta. contador = 4 +1 = 5
            contador = contador + 1
        Loop
        listBoxCiclos.Items.Add($"Este numero se ha sumado {contador} veces en este ciclo do while para llegar a 100.")

    End Sub
End Class
