Public Class CalculoIVA

    Private totalAPagar As Double
    Private tipoIVA As Double

    Public Sub New(ByVal pTotalAPagar As Double, ByVal pTipoIVA As Double)
        totalAPagar = pTotalAPagar
        tipoIVA = pTipoIVA
    End Sub

    Public Function totalSinIVA() As Double
        totalSinIVA = Math.Round(totalAPagar / (1 + tipoIVA), 2)
    End Function

    Public Function IVA() As Double
        IVA = Math.Round(totalAPagar - (totalAPagar / (1 + tipoIVA)), 2)
    End Function
End Class
