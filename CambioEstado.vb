Public Class CambioEstado
    Public sql As New Sqlcontrol
    Public ID As Integer
    Private Sub CambioEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("Select cast(ID as nvarchar(50)) ID, Estado,1 Orden   from EstadoSolicitudesNeumaticos 
                        union 
                        Select  '-Seleccionar-','-Seleccionar-',0 Orden
                        order by Orden")
        NuevoEstadoBox.ValueMember = "ID"
        NuevoEstadoBox.DisplayMember = "Estado"
        NuevoEstadoBox.DataSource = sql.DBDT
    End Sub

    Private Sub IngresarBtn_Click(sender As Object, e As EventArgs) Handles IngresarBtn.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@Estado", NuevoEstadoBox.SelectedValue.ToString()}})
        sql.execquery("Update CotNeumaticos Set Estado = @Estado where ID = @ID")
        If sql.Masexception(True) Then Exit Sub
        MsgBox("Estado Actualizado", Title:="Neumáticos")
        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
    End Sub

    Private Sub ActualizarFechaRecepcion_Click(sender As Object, e As EventArgs) Handles ActualizarFechaRecepcion.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@FechaRecepcion", Recepcionfecha.Value.Date + recepcionhora.Value.TimeOfDay}})
        sql.execquery("Update CotNeumaticos Set FechaRecepcion = @FechaRecepcion where ID = @ID")
        If sql.Masexception(True) Then Exit Sub

        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
        MsgBox("Fecha de recepción actualizada", Title:="Neumáticos")
    End Sub

    Private Sub ActualizarFechaInstalacion_Click(sender As Object, e As EventArgs) Handles ActualizarFechaInstalacion.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@FechaInstalacion", FechaInstalacion.Value.Date + HoraInstalacion.Value.TimeOfDay}})
        sql.execquery("Update CotNeumaticos Set FechaInstalacion = @FechaInstalacion where ID = @ID")
        If sql.Masexception(True) Then Exit Sub

        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
        MsgBox("Fecha de Instalación actualizada", Title:="Neumáticos")
    End Sub

    Private Sub ActualizarPrecioBtn_Click(sender As Object, e As EventArgs) Handles ActualizarPrecioBtn.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@Precio", NuevoPrecioBox.Text}})
        sql.execquery("Update CotNeumaticos Set Precio = @Precio where ID = @ID")
        If sql.Masexception(True) Then Exit Sub

        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
        MsgBox("Precio Actualizado", Title:="Neumáticos")
    End Sub

    Private Sub ActualizarCantidadBtn_Click(sender As Object, e As EventArgs) Handles ActualizarCantidadBtn.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@Cantidad", NuevaCantidadBox.Text}})
        sql.execquery("Update CotNeumaticos Set Cantidad = @Cantidad where ID = @ID")
        If sql.Masexception(True) Then Exit Sub

        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
        MsgBox("Cantidad Actualizada", Title:="Neumáticos")
    End Sub

    Private Sub ActualizarDetallesBtn_Click(sender As Object, e As EventArgs) Handles ActualizarDetallesBtn.Click
        sql.Addparam({{"@ID", ID.ToString}, {"@Detalles", NuevaCantidadBox.Text}})
        sql.execquery("Update CotNeumaticos Set Detalles = @Detalles where ID = @ID")
        If sql.Masexception(True) Then Exit Sub

        PedidosNeumaticos.DGVDetalle.Rows.Clear()
        PedidosNeumaticos.Llenar()
        MsgBox("Detalles Actualizados", Title:="Neumáticos")
    End Sub


End Class