Public Class EditarItem
    Public sqlb As New Sqlcontrol

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditarItem()
        Me.Close()
    End Sub

    Private Sub EditarItem()
        sqlb.Addparam("@ID", IDTextBox.Text)
        sqlb.Addparam("@Item", ItemTextBox.Text)

        sqlb.Addparam("@Cat", CategoriaTextBox.Text)
        sqlb.Addparam("@Venta", CDbl(VentaTextBox.Text))
        sqlb.Addparam("@Compra", CDbl(CompraTextBox.Text))
        sqlb.Addparam("@Stock", Decimal.Parse(StockTextBox.Text))


        sqlb.execquery("UPDATE Inventario SET Item = @Item, Categoria = @Cat, Pventa = @Venta, Pcompra = @Compra, Stock = @Stock  WHERE ID = @ID;")

        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Item editado exitosamente", Title:="Inventario")

    End Sub

End Class