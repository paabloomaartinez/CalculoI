Public Class CalculoIVAMedianteCreadorDeDatos

    Public generador As CapaDeDatos.GeneradorDeDatos
    Public Sub New(ByVal indice As Integer, ByVal val As CapaDeDatos.GeneradorDeDatos)
        generador = CapaDeDatos.GeneradorDeDatos.getInstance()
    End Sub

    Public Function totalSinIVA(ByVal indice As Integer) As Double

        Dim total As Double = generador.totalDeLaFactura(indice)
        Dim tipoIVA As Double = generador.tipoIVADeLaFactura(indice)

        Dim calculador As New CalculoIVA_DLL.CalculoIVA(total, tipoIVA)

        totalSinIVA = calculador.totalSinIVA()

    End Function

    Public Function IVA(ByVal indice As Integer) As Double

        Dim total As Double = generador.totalDeLaFactura(indice)
        Dim tipoIVA As Double = generador.tipoIVADeLaFactura(indice)

        Dim calculador As New CalculoIVA_DLL.CalculoIVA(total, tipoIVA)

        IVA = calculador.IVA()

    End Function
End Class
