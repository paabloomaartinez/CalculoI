Public Class IVACalculoFormulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New CalculoIVA_DLL.CalculoIVA(ComboBox1.SelectedValue)
    End Sub
End Class
