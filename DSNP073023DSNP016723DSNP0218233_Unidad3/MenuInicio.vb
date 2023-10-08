Public Class MenuInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DesviacionMedia.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CajeroAutomatico.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CalculoImpuestos.Show()
        Me.Hide()
    End Sub
End Class