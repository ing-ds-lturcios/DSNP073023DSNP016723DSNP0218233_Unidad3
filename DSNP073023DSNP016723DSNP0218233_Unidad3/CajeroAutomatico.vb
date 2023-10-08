Public Class CajeroAutomatico
    Dim cajero As Cajero = New Cajero()
    Dim operacion As SByte = 0
    Public Sub New()
        InitializeComponent()
        actualizarSaldo()
        txtCanMonto.Select()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        operacion = 0
        txtCanMonto.Select()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        operacion = 1
        txtCanMonto.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case operacion
                Case 0
                    If txtCanMonto.Text <= cajero.getDisponibilidad() Then
                        cajero.movimiento(txtCanMonto.Text, operacion)
                        actualizarSaldo()
                        mostrarBilletes()
                    Else
                        MessageBox.Show("Lo siento, no tengo suficiente efectivo para tu retiro", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Case 1
                    cajero.movimiento(txtCanMonto.Text, operacion)
                    actualizarSaldo()
                    mostrarBilletes()
            End Select
        Catch ex As InvalidCastException
            MessageBox.Show("Por favor, ingrese un monto numérico válido")
        End Try
    End Sub

    Private Sub actualizarSaldo()
        StatusStrip1.Items.Item(1).Text = cajero.getDisponibilidad().ToString("C2")
    End Sub

    Private Sub mostrarBilletes()
        Dim billetess = cajero.getBilletes()
        billete50.Text = billetess(0).ToString
        billete20.Text = billetess(1).ToString
        billete10.Text = billetess(2).ToString
        billete5.Text = billetess(3).ToString
        billete1.Text = billetess(4).ToString
        moneda25.Text = billetess(5).ToString
        moneda10.Text = billetess(6).ToString
        moneda5.Text = billetess(7).ToString
        moneda1.Text = billetess(8).ToString
    End Sub

    Sub limpiar()
        billete50.Text = ""
        billete20.Text = ""
        billete10.Text = ""
        billete5.Text = ""
        billete1.Text = ""
        moneda25.Text = ""
        moneda10.Text = ""
        moneda5.Text = ""
        moneda1.Text = ""
        txtCanMonto.Text = ""
        txtCanMonto.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub CajeroAutomatico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuInicio.Show()
    End Sub
End Class