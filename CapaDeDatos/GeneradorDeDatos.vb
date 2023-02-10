Public Class GeneradorDeDatos

    Private Shared instance As GeneradorDeDatos
    Private ImportesFacturasYTiposIVA As Double(,)

    Private Sub New()
        ImportesFacturasYTiposIVA = New Double(,) {{2500, 0.1}, {3150.55, 0.21}, {25000, 0.21}, {315.35, 0.04}}
    End Sub

    Public Shared Function getInstance() As GeneradorDeDatos
        If instance Is Nothing Then
            instance = New CapaDeDatos.GeneradorDeDatos()
        End If
        getInstance = instance
    End Function

    Public Function totalDeLaFactura(ByVal indice As Integer) As Double
        totalDeLaFactura = ImportesFacturasYTiposIVA(indice - 1, 0)
    End Function

    Public Function tipoIVADeLaFactura(ByVal indice As Integer) As Double
        tipoIVADeLaFactura = ImportesFacturasYTiposIVA(indice - 1, 1)
    End Function

End Class
