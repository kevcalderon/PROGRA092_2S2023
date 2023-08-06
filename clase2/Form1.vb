Public Class Form1
    Private Sub buttonNota_Click(sender As Object, e As EventArgs) Handles buttonNota.Click
        ' variable que recibe la nota 
        Dim nota As Integer = textBoxNota.Text
        Dim selecciono As String
        Dim resultado As String

        ' si seleccciona IF ELSE
        If checkBoxIf.Checked = True Then
            selecciono = "SELECCIONO IF"

            If nota < 0 Or nota > 100 Then
                MsgBox("Solo permiten notas mayores a cero y menor igual que 100.")
            ElseIf nota >= 90 Then
                resultado = "Calificacion A"
            ElseIf nota >= 80 Then
                resultado = "Calificacion B"
            ElseIf nota >= 70 Then
                resultado = "Calificacion C"
            ElseIf nota >= 60 Then
                resultado = "Calificacion D"
            Else
                resultado = "Calificacion F"
            End If

        End If

        ' si selecciona CASE
        If checkBoxCase.Checked = True Then
            selecciono = "SELECCIONO CASE"

            Select Case nota
                Case < 0, Is > 100
                    MsgBox("Solo se permiten notas mayores a cero y menores o iguales a 100.")
                Case >= 90
                    resultado = "Calificación A"
                Case >= 80
                    resultado = "Calificación B"
                Case >= 70
                    resultado = "Calificación C"
                Case >= 60
                    resultado = "Calificación D"
                Case Else
                    resultado = "Calificación F"
            End Select
        End If


        If nota >= 0 And nota <= 100 Then
            listBoxResultados.Items.Add(selecciono)
            listBoxResultados.Items.Add("El alumno obtuvo: " + resultado)
        End If



    End Sub
End Class
