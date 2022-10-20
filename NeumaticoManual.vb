Public Class NeumaticoManual
    Private Sub IngresarBtn_Click(sender As Object, e As EventArgs) Handles IngresarBtn.Click
        If String.IsNullOrEmpty(PrecioBox.Text) Or String.IsNullOrWhiteSpace(PrecioBox.Text) Then
            CotiNeumaticos.DGVDetalle.Rows.Add({AnchoBox.Text, PerfilBox.Text, RadioBox.Text, CargaBox.Text, VelocidadBox.Text, CantidadBox.Text, PrecioBox.Text})


        Else
            CotiNeumaticos.DGVDetalle.Rows.Add({AnchoBox.Text, PerfilBox.Text, RadioBox.Text, CargaBox.Text, VelocidadBox.Text, CantidadBox.Text, CDbl(PrecioBox.Text)})
            CotiNeumaticos.Sumar()

        End If


        Close()
    End Sub


    Private Sub PrecioBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PrecioBox.KeyUp
        If String.IsNullOrWhiteSpace(PrecioBox.Text) Then Exit Sub
        Dim monto As Double = PrecioBox.Text
        PrecioBox.Text = monto.ToString("$#,##0")
        PrecioBox.Select(PrecioBox.Text.Length, 0)
    End Sub
End Class