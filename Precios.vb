Public Class Precios
    Public sql As New Sqlcontrol
    Private Sub buscarbox_TextChanged(sender As Object, e As EventArgs) Handles buscarbox.TextChanged
        If buscarpobox.Text = "ITEM" Then

            sql.Addparam("@Buscar", "%" + buscarbox.Text + "%")
            sql.execquery("Select Categoria, Compras.Nombre, Precio, Proveedores.Nombre Proveedor from Compras inner join Proveedores on Compras.Proveedor = Proveedores.ID where Compras.Nombre like @Buscar")
            DGVPrecios.DataSource = sql.DBDT
            DGVPrecios.Columns(2).DefaultCellStyle.Format = "$#,##0"
        ElseIf buscarpobox.Text = "AUTOMÓVIL" Then

            sql.Addparam("@Buscar", "%" + buscarbox.Text + "%")
            sql.execquery("Select Ventas.Item,Inventario.Categoria, Ventas.PVenta, Costos.Costo, Registro.Vehiculo from Ventas 
                           inner Join Registro on Ventas.OT = Registro.OT 
                        	inner join Costos on Ventas.IDVenta = Costos.IDVenta
                           inner join Inventario on Ventas.CodItem = Inventario.ID
                            where Registro.Vehiculo like @Buscar and Inventario.Categoria <> 'SERVICIOS'
                             order by Inventario.Categoria")
            DGVPrecios.DataSource = sql.DBDT
            DGVPrecios.Columns(2).DefaultCellStyle.Format = "$#,##0"
            DGVPrecios.Columns(3).DefaultCellStyle.Format = "$#,##0"
        End If

    End Sub

    Private Sub Precios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        sql.execquery("Select Categoria, Compras.Nombre Item, Compras.Precio Precio, Proveedores.Nombre Proveedor from Compras inner join Proveedores on Compras.Proveedor = Proveedores.ID")
        DGVPrecios.DataSource = sql.DBDT
        DGVPrecios.Columns(1).DefaultCellStyle.Format = "$#,##0"


    End Sub


End Class