Public Class GeneradorDeDatos

    Private Shared ImportesFacturasYTiposIVA As Double(,)

    Private Sub New()
        ImportesFacturasYTiposIVA = New Double(,) {{2500, 10}, {3150.55, 21}, {25000, 21}, {315.35, 4}}
    End Sub

    Public Shared Function totalDeLaFactura(ByVal indice As Integer) As Double
        Dim c As New GeneradorDeDatos()
        totalDeLaFactura = ImportesFacturasYTiposIVA.GetValue(indice)
    End Function

    Public Shared Function tipoIVADeLaFactura(ByVal indice As Integer) As Double
        Dim c As New GeneradorDeDatos()
        tipoIVADeLaFactura = ImportesFacturasYTiposIVA.GetValue(indice)
    End Function

End Class
