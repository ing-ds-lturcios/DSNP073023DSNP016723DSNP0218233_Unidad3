Public Class Impuestos
    Private rangos()() As Double = {
        New Double() {0.01, 500, 1.5, 0},
        New Double() {500.01, 1000, 3, 3},
        New Double() {1000.01, 2000, 3, 3},
        New Double() {2000.01, 3000, 6, 3},
        New Double() {3000.01, 6000, 9, 2},
        New Double() {8000.01, 18000, 15, 2},
        New Double() {18000.01, 30000, 39, 2},
        New Double() {30000.01, 60000, 63, 1},
        New Double() {60000.01, 100000, 93, 0.8},
        New Double() {100000.01, 200000, 125, 0.7},
        New Double() {200000.01, 300000, 195, 0.6},
        New Double() {300000.01, 400000, 255, 0.45},
        New Double() {400000.01, 500000, 300, 0.4},
        New Double() {500000.01, 1000000, 340, 0.3},
        New Double() {1000000.01, 99999999, 490, 0.18}
    }

    Function getMaximo() As Double
        Return rangos(rangos.Length - 1)(1)
    End Function

    Function calcular(ByVal activo As Double) As Double
        Dim calculo As Double = 0.00
        For Each rango In rangos
            If rango(0) < activo And rango(1) > activo Then
                calculo = Math.Round((((activo - rango(0)) / 1000) * rango(3)) + rango(2), 2)
            End If
        Next
        Return calculo
    End Function
End Class
