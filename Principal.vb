Public Class Principal
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Graficos.Show()
        Graficos.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Inventario.Show()
        Inventario.BringToFront()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventas.Show()
        Ventas.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Trabajos.Show()
        Trabajos.BringToFront()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Compras.Show()
        Compras.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Clientes.Show()
        Clientes.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Cotizaciones.Show()
        Cotizaciones.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Caja.Show()
        Caja.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Graficos.Close()
        Graficos.Show()
        Graficos.BringToFront()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        VentaRapida.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Personalform.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Proveedores.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        prueba.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        PedidosNeumaticos.Show()
    End Sub
End Class