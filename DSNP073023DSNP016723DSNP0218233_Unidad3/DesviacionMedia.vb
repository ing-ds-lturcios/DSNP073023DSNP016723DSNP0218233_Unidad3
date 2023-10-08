Public Class DesviacionMedia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNumero.Text.Contains(",") Then
            Dim valor As Int16
            Dim ignorados As SByte = 0
            Dim listado() = txtNumero.Text.Split(",")
            For Each elemento In listado
                If Int16.TryParse(elemento, valor) Then
                    setDatos.Items.Add(valor)
                Else
                    ignorados += 1
                End If
            Next
            If ignorados > 0 Then
                MessageBox.Show("Se ignoraron valores no numéricos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Serie de datos agregada correctamente en el conjunto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Dim valor As Int16
            If Int16.TryParse(txtNumero.Text, valor) Then
                setDatos.Items.Add(valor)
            Else
                MessageBox.Show("El valor ingresado no es número, o no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        txtNumero.Text = ""
        txtNumero.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If setDatos.Items.Count = 0 Then
            MessageBox.Show("Aun no ha ingresado datos a su conjunto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Button2.PerformClick()
            Return
        End If
        Dim calculos As New DesTipicaMedArmonica()
        For Each dato In setDatos.Items
            calculos.setSumaInversos(dato)
            calculos.setSumaDatos(dato)
            calculos.agregarNumDatos()
        Next
        calculos.setMediaAritmetica()
        For Each dato In setDatos.Items
            calculos.setSumaCuadrados(dato)
        Next
        txtMedia.Text = calculos.calcularMediaArmonica()
        txtDesviacion.Text = calculos.calcularDesviacionTipica()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtDesviacion.Text = ""
        txtMedia.Text = ""
        setDatos.Items.Clear()
        txtNumero.Text = ""
        txtNumero.Select()
    End Sub

    Private Sub DesviacionMedia_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        MenuInicio.Show()
    End Sub
End Class