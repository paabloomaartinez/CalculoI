Public Class CalculoIVAMedianteCreadorDeDatos

    Public generador As CapaDeDatos.GeneradorDeDatos
    Public indice As Integer
    Public Sub New(ByVal indice As Integer)
        generador = CapaDeDatos.GeneradorDeDatos.getInstance()
        indice = indice
    End Sub

    Public Function totalSinIVA() As Double

        Dim total As Double = generador.totalDeLaFactura(indice)
        Dim tipoIVA As Double = generador.tipoIVADeLaFactura(indice)

        Dim calculador As New CalculoIVA_DLL.CalculoIVA(total, tipoIVA)

        totalSinIVA = calculador.totalSinIVA()

    End Function

    Public Function IVA() As Double

        Dim total As Double = generador.totalDeLaFactura(indice)
        Dim tipoIVA As Double = generador.tipoIVADeLaFactura(indice)

        Dim calculador As New CalculoIVA_DLL.CalculoIVA(total, tipoIVA)

        IVA = calculador.IVA()

    End Function
End Class
