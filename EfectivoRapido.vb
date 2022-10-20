Public Class EfectivoRapido
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VentaRapida.TextBox2.Text = CDbl(crecibidatxt.Text).ToString("$#,##0")
        VentaRapida.TextBox5.Text = (crecibidatxt.Text - CDbl(VentaRapida.TextBox4.Text)).ToString("$#,##0")
        If Not factura = "Factura" Then
            VentaRapida.ReciboTextBox.Text = InputBox("Ingrese Número de Boleta", "Boleta")

        End If

        Me.Close()
    End Sub
End Class