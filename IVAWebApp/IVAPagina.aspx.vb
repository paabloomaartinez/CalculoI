Public Class IVAPagina
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iva As Double

        If DropDownList1.SelectedValue = "General" Then
            iva = 0.21
        ElseIf DropDownList1.SelectedValue = "Reducido" Then
            iva = 0.1
        ElseIf DropDownList1.SelectedValue = "Productos Basicos" Then
            iva = 0.04
        End If

        Dim c As New CalculoIVA_DLL.CalculoIVA(CDbl(TextBox1.Text), iva)

        TextBox2.Text = c.totalSinIVA()
        TextBox3.Text = c.IVA()

    End Sub
End Class