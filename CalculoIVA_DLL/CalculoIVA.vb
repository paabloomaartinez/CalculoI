Public Class CalculoIVA

    Enum ivas
        general = 0.21
        reducido = 0.1
        productosBasicos = 0.04
    End Enum

    Private totalAPagar As Double

    Private tipoIVA As ivas

    Public Sub New(ByVal pTotalAPagar As Double, ByVal pTotalIVA As ivas)
        totalAPagar = pTotalAPagar
        tipoIVA = pTotalIVA
    End Sub


    Public Function totalSinIVA() As Double

        totalSinIVA = totalAPagar

    End Function

    Public Function IVA() As Double

        IVA = tipoIVA

    End Function
End Class
