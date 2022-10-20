Public Class FacturaRapida
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(facturatxtbx.Text) Then
            MsgBox("Ingrese número de factura", Title:="Facturas")
        Else
            VentaRapida.facturaTextBox.Text = facturatxtbx.Text
            Me.Close()
            MedioPagoRapido.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VentaRapida.facturaTextBox.Text = "Pendiente"
        Me.Close()
        MedioPagoRapido.Show()
    End Sub
End Class