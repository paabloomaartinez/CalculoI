Public Class CalculoIVAMedianteCreadorDeDatos

    Public array As Double(,)
    Public Sub New(ByVal indice As Integer, ByVal val As CapaDeDatos.GeneradorDeDatos)
        array = CapaDeDatos.GeneradorDeDatos.getInstance()
    End Sub

    Public Function totalSinIVA() As Double

        totalSinIVA = Math.Round(totalAPagar / (1 + tipoIVA), 2)

    End Function

    Public Function IVA() As Double

        IVA = Math.Round(totalAPagar - (totalAPagar / (1 + tipoIVA)), 2)

    End Function
End Class
