

Public Class NuevoItem
    Public sqlb As New Sqlcontrol


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sqlb.execquery("INSERT INTO Inventario (ID, Item, Tipo, Categoria, Pventa, Pcompra, Stock, Proveedor)  values ('" & IDT.Text.ToString & "','" & ItemT.Text.ToString & "', '" & TipoT.Text.ToString & "','" & UnidadT.Text.ToString & "', '" & CaT.Text.ToString & "','" & VentaT.Text.ToString & "','" & CompraT.Text.ToString & "','" & StockT.Text.ToString & "','" & ProveedorT.Text.ToString & "');")
        InsertItem()

    End Sub

    Private Sub InsertItem()
        sqlb.Addparam("@ID", IDT.Text)
        sqlb.Addparam("@Item", ItemT.Text)
        sqlb.Addparam("@Cat", cat.Text)
        sqlb.Addparam("@Venta", VentaT.Text)
        sqlb.Addparam("@Compra", CompraT.Text)
        sqlb.Addparam("@Stock", StockT.Text)

        sqlb.execquery("INSERT INTO Inventario (ID, Item, Categoria, Pventa, Pcompra, Stock, StockInicial, Adiciones, StockFinal) VALUES (@ID,@Item,@Cat,@Venta,@Compra,@Stock,0,0,0);")

        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Item creado exitosamente", Title:="Inventario")
        Close()
    End Sub

End Class