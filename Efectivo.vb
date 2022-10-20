Public Class Efectivo
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click



        PuntoVenta.TextBox4.Text = CDbl(crecibidatxt.Text).ToString("$#,##0")
        PuntoVenta.TextBox5.Text = (crecibidatxt.Text - CDbl(PuntoVenta.TextBox8.Text)).ToString("$#,##0")
        If Not factura = "Factura" Then
            PuntoVenta.ReciboTextBox.Text = InputBox("Ingrese Número de Boleta", "Boleta")

        End If

        Me.Close()
    End Sub

    Private Sub Efectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crecibidatxt.Select()
    End Sub
End Class