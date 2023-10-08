Public Class CalculoImpuestos
    Dim impuestos As Impuestos = New Impuestos()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If Double.Parse(txtActivo.Text) > impuestos.getMaximo() Then
            MessageBox.Show("El monto ingresado se encuentra fuera del rango")
            Return
        End If
        Dim calculo = impuestos.calcular(Double.Parse(txtActivo.Text))
        If calculo = 0 Then
            MessageBox.Show("Activo no soportado en tabla de impuestos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        txtImpuesto.Text = calculo.ToString("C2")
    End Sub

    Private Sub CalculoImpuestos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuInicio.Show()
    End Sub
End Class
