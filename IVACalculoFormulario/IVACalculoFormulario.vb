Public Class IVACalculoFormulario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iva As Double

        If ComboBox1.SelectedItem = "General" Then
            iva = 0.21
        ElseIf ComboBox1.SelectedItem = "Reducido" Then
            iva = 0.1
        ElseIf ComboBox1.SelectedItem = "Productos Basicos" Then
            iva = 0.04
        End If

        Dim c As New CalculoIVA_DLL.CalculoIVA(CDbl(TextBox1.Text), iva)

        TextBox2.Text = c.totalSinIVA()
        TextBox3.Text = c.IVA()

    End Sub

    Private Sub IVACalculoFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("General")
        ComboBox1.Items.Add("Reducido")
        ComboBox1.Items.Add("Productos Basicos")
    End Sub
End Class
