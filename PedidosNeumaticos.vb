Public Class PedidosNeumaticos
    Public sql As New Sqlcontrol
    Private Sub PedidosNeumaticos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Llenar()


    End Sub

    Private Sub ManualBtn_Click(sender As Object, e As EventArgs) Handles ManualBtn.Click
        For Each fila As DataGridViewRow In DGVDetalle.Rows
            If fila.Cells(DGVDetalle.Columns.Count - 1).Value = True Then
                CambioEstado.Show()
                CambioEstado.EstadoActualBox.Text = fila.Cells(9).Value
                CambioEstado.ID = fila.Cells(0).Value
                If IsDBNull(fila.Cells(8).Value) Then
                    CambioEstado.PrecioActualBox.Text = ""
                Else
                    CambioEstado.PrecioActualBox.Text = fila.Cells(8).Value
                End If
                If IsDBNull(fila.Cells(7).Value) Then
                    CambioEstado.CantidadActualBox.Text = ""
                Else
                    CambioEstado.CantidadActualBox.Text = fila.Cells(7).Value
                End If
                If IsDBNull(fila.Cells(11).Value) Then
                    CambioEstado.DetallesBox.Text = ""
                Else
                    CambioEstado.DetallesBox.Text = fila.Cells(11).Value
                End If

            End If
        Next

    End Sub
    Public Sub Llenar()
        sql.execquery("Select CotNeumaticos.ID, Clientes.Nombre + ' ' + Clientes.Apellido, CotNeumaticos.Ancho, CotNeumaticos.Perfil, CotNeumaticos.Radio, CotNeumaticos.Carga, CotNeumaticos.Velocidad, CotNeumaticos.Cantidad, CotNeumaticos.Precio, EstadoSolicitudesNeumaticos.Estado, CotNeumaticos.FechaRecepcion, CotNeumaticos.FechaInstalacion, CotNeumaticos.Detalles
                        from CotNeumaticos inner join Clientes on CotNeumaticos.Cliente = Clientes.ID 
                        inner join EstadoSolicitudesNeumaticos on CotNeumaticos.Estado = EstadoSolicitudesNeumaticos.ID
                        Order by ID")

        For Each fila As DataRow In sql.DBDT.Rows
            DGVDetalle.Rows.Add(fila.ItemArray)
        Next

        DGVDetalle.Columns(8).DefaultCellStyle.Format = "$#,##0"

    End Sub
    Private Sub NuevoPedidoBtn_Click(sender As Object, e As EventArgs) Handles NuevoPedidoBtn.Click
        CotiNeumaticos.Show()
    End Sub
End Class