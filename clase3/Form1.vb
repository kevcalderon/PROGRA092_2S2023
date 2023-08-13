Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero1 As Double = Val(textBoxNumero1.Text)
        Dim numero2 As Double = Val(textBoxNumero2.Text)
        Dim operacion As String = comboOperacion.Text
        Dim total As Double

        If operacion = "+" Then
            'poniendo los valores en sumar(10, 20)
            '30
            total = sumar(numero1, numero2)

        ElseIf operacion = "-" Then
            total = resta(numero1, numero2)
        ElseIf operacion = "*" Then
            total = multiplicacion(numero1, numero2)
        ElseIf operacion = "/" Then
            total = division(numero1, numero2)
        ElseIf operacion = "#" Then
            total = raiz(numero1)
        ElseIf operacion = "^" Then
            total = potencia(numero1, numero2)
        End If

        ' alt + 123 {   alt + 125  }
        listBoxResultado.Items.Add($"El resultado de la operación es: {total}")


    End Sub


    'recibir 10 , 20
    Private Function sumar(num1, num2) As Double
        Return num1 + num2
    End Function

    Private Function resta(num1, num2) As Double
        Dim resultado As Double = num1 - num2
        Return resultado
    End Function

    Private Function multiplicacion(num1, num2) As Double
        Return num1 * num2
    End Function


    Private Function division(num1, num2) As Double
        Return num1 / num2
    End Function

    Private Function raiz(num1) As Double
        Return Math.Sqrt(num1)
    End Function

    Private Function potencia(num1, num2) As Double
        Return Math.Pow(num1, num2)
    End Function

End Class

