Public Class DesTipicaMedArmonica
    Private sumaDatos As Double
    Private sumaInversos As Double
    Private sumaCuadrados As Double
    Private mediaAritmetica As Double
    Private numDatos As SByte

    Public Sub New()
        sumaInversos = 0
        sumaDatos = 0
        mediaAritmetica = 0
        sumaCuadrados = 0
        numDatos = 0
    End Sub

    Public Sub agregarNumDatos()
        numDatos += 1
    End Sub
    Public Sub setSumaDatos(ByVal valor As SByte)
        sumaDatos += valor
    End Sub

    Public Sub setSumaInversos(ByVal valor As SByte)
        sumaInversos += 1 / valor
    End Sub

    Public Sub setSumaCuadrados(ByVal valor As SByte)
        sumaCuadrados += Math.Pow(valor - mediaAritmetica, 2)
    End Sub
    Public Sub setMediaAritmetica()
        mediaAritmetica = sumaDatos / numDatos
    End Sub

    Function calcularMediaArmonica()
        Return Math.Round(numDatos / sumaInversos, 4)
    End Function
    Function calcularDesviacionTipica()
        Return Math.Round(Math.Sqrt(sumaCuadrados / numDatos), 4)
    End Function
End Class
