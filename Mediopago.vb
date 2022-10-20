Public Class Mediopago

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PuntoVenta.MediodepagoTextBox.Text = "T. Crédito"
        PuntoVenta.ReciboTextBox.Text = InputBox("Ingrese Número de Voucher", "Voucher")
        Me.Close()
        PuntoVenta.Button7.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PuntoVenta.MediodepagoTextBox.Text = "T. Débito"
        PuntoVenta.ReciboTextBox.Text = InputBox("Ingrese Número de Voucher", "Voucher")
        PuntoVenta.Button7.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PuntoVenta.MediodepagoTextBox.Text = "Crédito"
        PuntoVenta.Button7.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Efectivo.Show()
        PuntoVenta.MediodepagoTextBox.Text = "Efectivo"
        PuntoVenta.Button7.Enabled = True
        Me.Close()

    End Sub

    Private Sub Mediopago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        PuntoVenta.MediodepagoTextBox.Text = "Transferencia"
        If Not factura = "Factura" Then
            PuntoVenta.ReciboTextBox.Text = InputBox("Ingrese Número de Boleta", "Boleta")

        End If
        PuntoVenta.Button7.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        esrapida = "No"
        PagoMixto.Show()
        Me.Close()
    End Sub
End Class