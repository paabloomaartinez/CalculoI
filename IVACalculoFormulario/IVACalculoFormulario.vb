Public Class IVACalculoFormulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New CalculoIVA_DLL.CalculoIVA(CDbl(TextBox1.Text), ComboBox1.SelectedValue)

        TextBox2.Text = c.totalSinIVA()
        TextBox3.Text = c.IVA()

    End Sub

    Private Sub IVACalculoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("General")
        ComboBox1.Items.Add("Reducido")
        ComboBox1.Items.Add("Productos Basicos")
    End Sub
End Class
