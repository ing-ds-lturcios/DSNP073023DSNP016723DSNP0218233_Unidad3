Public Class Cajero
    Dim denominaciones As Decimal() = {50, 20, 10, 5, 1, 0.25, 0.1, 0.05, 0.01}
    Dim disponibilidad As Int16() = {10, 40, 40, 40, 75, 40, 100, 90, 50}
    Dim billetes As Int16() = {0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim disponible As Decimal = 0

    Sub calcularDisponible()
        disponible = 0
        For i = 0 To disponibilidad.Length - 1
            disponible += disponibilidad(i) * denominaciones(i)
        Next
    End Sub

    Function getDisponibilidad() As Decimal
        calcularDisponible()
        Return disponible
    End Function

    Sub movimiento(ByVal monto As Decimal, ByVal tipo As SByte)
        billetes = {0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim efectivo As Decimal = monto
        For i = 0 To (denominaciones.Length - 1)
            Dim requeridos = CType(Math.Floor(efectivo / denominaciones(i)), Int16)
            If tipo = 0 Then
                If disponibilidad(i) > 0 Then
                    If disponibilidad(i) >= requeridos Then
                        billetes(i) = requeridos
                        disponibilidad(i) -= requeridos
                        efectivo -= (billetes(i) * denominaciones(i))
                    Else
                        billetes(i) = disponibilidad(i)
                        disponibilidad(i) = 0
                        efectivo -= Decimal.Parse((billetes(i) * denominaciones(i)).ToString("0.00"))
                    End If
                End If
            ElseIf tipo = 1 Then
                billetes(i) = requeridos
                disponibilidad(i) += requeridos
                efectivo -= Math.Round(billetes(i) * denominaciones(i), 2)
            End If
            If efectivo = 0 Then
                Exit For
            End If
        Next
    End Sub

    Function getBilletes() As Int16()
        Return billetes
    End Function

End Class
