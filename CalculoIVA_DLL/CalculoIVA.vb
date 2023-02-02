Public Class CalculoIVA

    Enum ivas
        general = 0.21
        reducido = 0.1
        productosBasicos = 0.04
    End Enum

    Private totalAPagar As Double

    Private tipoIVA As ivas

    Public Sub New(ByVal pTotalAPagar As Double, ByVal pTotalIVA As Byte)
        totalAPagar = pTotalAPagar
        tipoIVA = pTotalIVA
    End Sub


    Public Function totalSinIVA(ByVal totalAPagar As Double, ByVal tipoIVA As Double) As Double

        totalSinIVA = (totalAPagar / (1 + tipoIVA))

    End Function

    Public Function IVA(ByVal totalAPagar As Double, ByVal tipoIVA As Double) As Double

        IVA = totalAPagar - (totalAPagar / (1 + tipoIVA))

    End Function
End Class
