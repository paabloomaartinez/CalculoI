Public Class CalculoIVA

    Enum ivas
        general = 0.21
        reducido = 0.1
        productosBasicos = 0.04
    End Enum

    Private totalAPagar As Double

    Private tipoIVA As ivas

    Public Sub New(ByVal pTotalAPagar As Double, ByVal pTipoIVA As Byte)
        totalAPagar = pTotalAPagar
        tipoIVA = pTipoIVA
    End Sub


    Public Function totalSinIVA() As Double

        totalSinIVA = totalAPagar / (1 + tipoIVA)

    End Function

    Public Function IVA() As Double

        IVA = totalAPagar - (totalAPagar / (1 + tipoIVA))

    End Function
End Class
