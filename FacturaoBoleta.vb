Public Class FacturaoBoleta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        factura = "Boleta"
        Me.Close()
        MedioPagoRapido.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        FacturaRapida.Show()
        FacturaRapida.StartPosition = FormStartPosition.CenterScreen
        factura = "Factura"
    End Sub
End Class