Public Class IVACalculoFormulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New CalculoIVA_DLL.CalculoIVA(TextBox1.Text, ComboBox1.SelectedItem)

        TextBox2.Text = ComboBox1.SelectedValue
    End Sub

    Private Sub IVACalculoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("General")
        ComboBox1.Items.Add("Reducido")
        ComboBox1.Items.Add("Productos Basicos")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
