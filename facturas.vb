Public Class facturas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(facturatxtbx.Text) Then
            MsgBox("Ingrese número de factura", Title:="Facturas")
        Else
            PuntoVenta.facturaTextBox.Text = facturatxtbx.Text
            Me.Close()
            Mediopago.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PuntoVenta.facturaTextBox.Text = "Pendiente"
        Me.Close()
        Mediopago.Show()
    End Sub
End Class