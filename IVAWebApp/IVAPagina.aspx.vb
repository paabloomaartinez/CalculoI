Public Class IVAPagina
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New CalculoIVA_DLL.CalculoIVA(CDbl(TextBox1.Text), DropDownList1.SelectedValue)

        TextBox2.Text = c.totalSinIVA()
        TextBox3.Text = c.IVA()

    End Sub
End Class