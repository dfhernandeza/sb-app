Imports ClasesLibreria

Public Class CotiNeumaticos
    Public sql As New Sqlcontrol
    Public metodos As New Funciones
    Public guardado As String
    Private Sub CotiNeumaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal

        '================================================================================================================
        'Clientes
        sql.execquery("Select ID, IdCLiente, Nombre, Apellido from Clientes")

        For Each fila As DataRow In sql.DBDT.Rows
            DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
        Next
        ''Inventarios
        ''=================================================================================================================
        sql.execquery("SELECT ID, Item, PVenta, Stock FROM Inventario Where Categoria = 'Neumaticos'")
        If sql.Masexception(True) Then Exit Sub
        DGVInventario.DataSource = sql.DBDT
        DGVInventario.Columns(2).DefaultCellStyle.Format = "$#,##0"
        'Detalle
        '==================================================================================================================
        DGVDetalle.Columns(6).ValueType = GetType(Double)
        DGVDetalle.Columns(6).DefaultCellStyle.Format = "$#,##0"
        'ID
        sql.execquery("Select max(id) from CotNeumaticos")
        If IsDBNull(sql.DBDT.Rows(0).Item(0)) Then
            IDPEdidoBox.Text = 1
        Else
            IDPEdidoBox.Text = sql.DBDT.Rows(0).Item(0) + 1
        End If


    End Sub

    Private Sub NuevoClienteBtn_Click(sender As Object, e As EventArgs) Handles NuevoClienteBtn.Click
        cotineumatico = "Neumatico"
        NuevoCliente.Show()
    End Sub
    Public Sub Sumar()
        Dim suma As Double
        For Each fila As DataGridViewRow In DGVDetalle.Rows
            suma += (CDbl(fila.Cells(6).Value) * CInt(fila.Cells(5).Value))

        Next
        TotalBox.Text = suma.ToString("$#,##0")



    End Sub
    Private Sub ManualBtn_Click(sender As Object, e As EventArgs) Handles ManualBtn.Click
        NeumaticoManual.Show()
    End Sub

    Private Sub DescuentoBtn_Click(sender As Object, e As EventArgs) Handles DescuentoBtn.Click
        Descuento.origen = "Neumaticos"
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        sql.Addparam("@ID", IDPEdidoBox.Text)
        sql.execquery("Select * from CotNeumaticos where ID = @ID ")
        If sql.DBDT.Rows.Count = 0 Then
            For Each fila As DataGridViewRow In DGVDetalle.Rows
                Dim a = {{"@Cliente", IDClienteInternaBox.Text}, {"@Ancho", fila.Cells(0).Value}, {"@Perfil", fila.Cells(1).Value}, {"@Radio", fila.Cells(2).Value}, {"@Carga", fila.Cells(3).Value}, {"@Velocidad", fila.Cells(4).Value}, {"@Cantidad", fila.Cells(5).Value}, {"@Precio", fila.Cells(6).Value}, {"@Estado", "1"}, {"@Detalles", DetalleBox.Text}}
                sql.Addparam(a)
            Next
            sql.execquery("Insert into CotNeumaticos (Cliente, Ancho, Perfil, Radio, Carga, Velocidad, Cantidad, Precio, Estado, Detalles) Values (@Cliente, @Ancho, @Perfil, @Radio, @Carga, @Velocidad, @Cantidad, @Precio, @Estado, @Detalles)")

            If Not String.IsNullOrWhiteSpace(DescuentoBox.Text) Or Not String.IsNullOrEmpty(DescuentoBox.Text) Then
                Dim b = {{"@IDPedido", IDPEdidoBox.Text}, {"@Descuento", CDbl(DescuentoBox.Text)}}
                sql.Addparam(b)
                sql.execquery("Insert into DescuentosNeumaticos (IDCotizacionNeumaticos, Descuento) Values (@IDPedido, @Descuento) ")

            End If
        Else

            For Each fila As DataGridViewRow In DGVDetalle.Rows
                Dim a = {{"@ID", IDPEdidoBox.Text}, {"@Cliente", IDClienteInternaBox.Text}, {"@Ancho", fila.Cells(0).Value}, {"@Perfil", fila.Cells(1).Value}, {"@Radio", fila.Cells(2).Value}, {"@Carga", fila.Cells(3).Value}, {"@Velocidad", fila.Cells(4).Value}, {"@Cantidad", fila.Cells(5).Value}, {"@Precio", fila.Cells(6).Value}, {"@Estado", "1"}, {"@Detalles", DetalleBox.Text}}
                sql.Addparam(a)
            Next
            sql.execquery("Update CotNeumaticos Set Cliente = @Cliente , Ancho = @Ancho, Perfil = @Perfil, Radio = @Radio, Carga = @Carga, Velocidad = @Velocidad, Cantidad = @Cantidad, Precio = @Precio, Estado = @Estado, Detalles = @Detalles where ID = @ID")

            'Descuentos
            '====================================================================================================
            sql.Addparam("@ID", IDPEdidoBox.Text)
            sql.execquery("Select * from DescuentosNeumaticos where IDCotizacionNeumaticos = @ID")

            If sql.DBDT.Rows.Count = 0 And (Not String.IsNullOrWhiteSpace(DescuentoBox.Text) Or Not String.IsNullOrEmpty(DescuentoBox.Text)) Then
                Dim b = {{"@IDPedido", IDPEdidoBox.Text}, {"@Descuento", CDbl(DescuentoBox.Text)}}
                sql.Addparam(b)
                sql.execquery("Insert into DescuentosNeumaticos (IDCotizacionNeumaticos, Descuento) Values (@IDPedido, @Descuento) ")


            Else

                Dim b = {{"@IDPedido", IDPEdidoBox.Text}, {"@Descuento", CDbl(DescuentoBox.Text)}}
                sql.Addparam(b)
                sql.execquery("Update DescuentosNeumaticos Set IDCotizacionNeumaticos = @IDPedido, Descuento = @Descuento")

            End If



        End If

        guardado = "OK"
        MsgBox("El pedido fue guardado", Title:="Neumáticos")


    End Sub



    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellValueChanged
        guardado = "NotOK"
    End Sub

    Private Sub IngresarBtn_Click(sender As Object, e As EventArgs) Handles IngresarBtn.Click
        If guardado = "NotOK" Then
            MsgBox("Debe guardar todos sus cambio antes de proceder", Title:="Neumáticos")
        Else
            Close()

        End If
    End Sub

    Private Sub DetalleBox_TextChanged(sender As Object, e As EventArgs) Handles DetalleBox.TextChanged
        guardado = "NotOK"
    End Sub

    Private Sub DescuentoBox_TextChanged(sender As Object, e As EventArgs) Handles DescuentoBox.TextChanged
        guardado = "NotOK"
    End Sub

    Private Sub TotalBox_TextChanged(sender As Object, e As EventArgs) Handles TotalBox.TextChanged
        guardado = "NotOK"
    End Sub
End Class