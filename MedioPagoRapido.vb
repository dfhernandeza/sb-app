Public Class MedioPagoRapido
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        VentaRapida.MediodepagoTextBox.Text = "T. Crédito"
        VentaRapida.ReciboTextBox.Text = InputBox("Ingrese Número de Voucher", "Voucher")
        VentaRapida.Button3.Enabled = True
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VentaRapida.MediodepagoTextBox.Text = "T. Débito"
        VentaRapida.ReciboTextBox.Text = InputBox("Ingrese Número de Voucher", "Voucher")
        VentaRapida.Button3.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentaRapida.MediodepagoTextBox.Text = "Crédito"
        VentaRapida.Button3.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        EfectivoRapido.Show()
        VentaRapida.MediodepagoTextBox.Text = "Efectivo"
        VentaRapida.Button3.Enabled = True
        Me.Close()

    End Sub

    Private Sub Mediopago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        VentaRapida.MediodepagoTextBox.Text = "Transferencia"
        If Not factura = "Factura" Then
            VentaRapida.ReciboTextBox.Text = InputBox("Ingrese Número de Boleta", "Boleta")

        End If
        VentaRapida.Button3.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        esrapida = "Rapida"
        PagoMixto.Show()
    End Sub
End Class