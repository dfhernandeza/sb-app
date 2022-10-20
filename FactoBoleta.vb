Public Class FactoBoleta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        factura = "Boleta"
        Me.Close()
        Mediopago.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        facturas.Show()
        facturas.StartPosition = FormStartPosition.CenterScreen
        factura = "Factura"
    End Sub

    Private Sub FactoBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class