Public Class Proveedores
    Public sqla As New Sqlcontrol
    Public metodos As New ClasesLibreria.Funciones
    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        For Each fila As DataGridViewRow In DetalleDGV.Rows
            If fila.Cells(6).Value = True Then
                If MsgBox("¿Confirma que desea eliminar a " + fila.Cells(1).Value + "?", MsgBoxStyle.YesNo, Title:="Proveedores") = "6" Then
                    sqla.Addparam("@ID", fila.Cells(0).Value)
                    sqla.execquery("Delete from Proveedores where ID = @ID")
                    sqla.Masexception(True)
                    MsgBox("Proveedor eliminado satisfactoriamente", Title:="Proveedores")
                    DetalleDGV.Rows.Remove(fila)
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub EditarBtn_Click(sender As Object, e As EventArgs) Handles EditarBtn.Click
        For Each fila As DataGridViewRow In DetalleDGV.Rows
            If fila.Cells(6).Value = True Then
                With NuevoProveedor
                    .Show()
                    .Text = "Editar Proveedor"
                    If fila.Cells(0).Value.ToString().Length() = 8 Then
                        NuevoProveedor.IDTextBox.Mask = "#,###,###-&"

                    End If
                    .IDTextBox.Text = fila.Cells(0).Value
                    .NomTextBox.Text = fila.Cells(1).Value
                    .EmailTextBox.Text = fila.Cells(2).Value
                    .FonoTextBox.Text = fila.Cells(3).Value
                    .DireccionTextBox.Text = fila.Cells(4).Value
                    .Comentariostxt.Text = fila.Cells(5).Value



                End With

                Exit For

            End If


        Next
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        DetalleDGV.Columns(0).ValueType = GetType(Double)
        Llenar()


    End Sub
    Public Sub Llenar()
        sqla.execquery("Select ID, Nombre, Case When Email is null then ' ' else Email end, Case When Fono is null then ' ' else Fono end,  Case When Direccion is null then ' ' else Direccion end,  Case When Comentarios is null then ' ' else Comentarios end from Proveedores order by Nombre")
        For Each fila As DataRow In sqla.DBDT.Rows
            DetalleDGV.Rows.Add({metodos.FormatRutView(fila.Item(0)), fila.Item(1), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5)})
        Next
    End Sub
    Private Sub DetalleDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleDGV.CellContentClick
        If e.ColumnIndex = DetalleDGV.Columns.Count - 1 Then
            For Each fila As DataGridViewRow In DetalleDGV.Rows
                fila.Cells(e.ColumnIndex).Value = False
            Next
            DetalleDGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevoProveedor.Show()
    End Sub
End Class