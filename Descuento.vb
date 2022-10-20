Public Class Descuento
    Public origen As String
    Private Sub Porcentajebtn_Click(sender As Object, e As EventArgs) Handles Porcentajebtn.Click
        If origen = "Neumaticos" Then
            Dim descuento As Decimal = CDec(InputBox("Ingrese porcentaje de descuento", Title:="Descuento"))
            Dim montodescuento As Decimal = CDec(CotiNeumaticos.TotalBox.Text) * descuento / 100
            CotiNeumaticos.DescuentoBox.Text = montodescuento.ToString("$#,##0")
            Dim suma As Double
            For Each fila As DataGridViewRow In CotiNeumaticos.DGVDetalle.Rows
                suma += fila.Cells(6).Value
            Next
            CotiNeumaticos.TotalBox.Text = (suma - montodescuento).ToString("$#,##0")

            origen = Nothing
        Else

            Dim descuento As Decimal = CDec(InputBox("Ingrese porcentaje de descuento", Title:="Descuento"))
            Dim montodescuento As Decimal = CDec(Cotizacion.TextBox4.Text) * descuento / 100
            Cotizacion.DGVDetalle.Rows.Add({"20201010", "DESCUENTO", "1", montodescuento * -1, montodescuento * -1})
            Cotizacion.TextBox9.Text = montodescuento.ToString("$#,##0")
            Cotizacion.Sumar()
        End If

        Close()
    End Sub

    Private Sub CantidadBtn_Click(sender As Object, e As EventArgs) Handles CantidadBtn.Click
        If origen = "Neumaticos" Then
            Dim descuento As Decimal = CDbl(InputBox("Ingrese monto de descuento", Title:="Descuento"))
            CotiNeumaticos.DescuentoBox.Text = descuento.ToString("$#,##0")
            Dim suma As Double
            For Each fila As DataGridViewRow In CotiNeumaticos.DGVDetalle.Rows
                suma += fila.Cells(6).Value
            Next
            CotiNeumaticos.TotalBox.Text = (suma - descuento).ToString("$#,##0")


        Else
            Dim descuento As Decimal = CDbl(InputBox("Ingrese monto de descuento", Title:="Descuento"))
            Cotizacion.TextBox9.Text = descuento.ToString("$#,##0")
            Cotizacion.DGVDetalle.Rows.Add({"20201010", "DESCUENTO", "1", descuento * -1, descuento * -1})
            Cotizacion.Sumar()

        End If

        Close()
    End Sub


End Class