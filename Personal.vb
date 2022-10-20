
Public Class Personalform
    Public metodos As New ClasesLibreria.Funciones
    Public sqla As New Sqlcontrol
    Private Sub Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Llenar()

    End Sub
    Public Sub Llenar()
        sqla.execquery("Select ID, Nombre, Apellido, Especialidad from Personal")
        For Each fila As DataRow In sqla.DBDT.Rows
            DGVPersonal.Rows.Add({metodos.FormatRutView(fila.Item(0)), fila.Item(1), fila.Item(2), fila.Item(3)})
        Next


    End Sub




    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        NuevoEmpleado.Show()
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        For Each fila As DataGridViewRow In DGVPersonal.Rows
            If fila.Cells(4).Value = True Then
                If MsgBox("¿Confirma que desea eliminar a " + fila.Cells(1).Value + " " + fila.Cells(2).Value + "?", MsgBoxStyle.YesNo, Title:="Personal") = "6" Then

                    sqla.Addparam("@ID", fila.Cells(0).Value)
                    sqla.execquery("Delete from Personal where ID = @ID")
                    sqla.Masexception(True)
                    MsgBox("Empleado eliminado satisfactoriamente", Title:="Personal")
                    DGVPersonal.Rows.Remove(fila)

                End If
                Exit For
            End If



        Next
    End Sub

    Private Sub DGVPersonal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPersonal.CellContentClick
        If e.ColumnIndex = DGVPersonal.Columns.Count - 1 Then

            For Each fila As DataGridViewRow In DGVPersonal.Rows
                fila.Cells(e.ColumnIndex).Value = False

            Next
            DGVPersonal.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True



        End If
    End Sub

    Private Sub EditarBtn_Click(sender As Object, e As EventArgs) Handles EditarBtn.Click
        For Each fila As DataGridViewRow In DGVPersonal.Rows
            If fila.Cells(4).Value = True Then

                sqla.Addparam("@ID", fila.Cells(0).Value)
                sqla.execquery("Select * from Personal where ID = @ID")
                With NuevoEmpleado
                    .Show()
                    .Text = "Actualizar Empleado"
                    .aceptarbtn.Text = "Actualizar"
                    .idbox.Text = sqla.DBDT.Rows(0).Item(0)
                    .nombrebox.Text = sqla.DBDT.Rows(0).Item(1)
                    .apellidobox.Text = sqla.DBDT.Rows(0).Item(2)
                    .especialidadbox.Text = sqla.DBDT.Rows(0).Item(3)
                    .costohhbox.Text = sqla.DBDT.Rows(0).Item(4)

                End With
                Exit For
            End If

        Next
    End Sub

    Private Sub VerEmpleado_Click(sender As Object, e As EventArgs) Handles VerEmpleado.Click
        For Each fila As DataGridViewRow In DGVPersonal.Rows
            If fila.Cells(4).Value = True Then

                sqla.Addparam("@ID", fila.Cells(0).Value)
                sqla.execquery("Select * from Personal where ID = @ID")
                With NuevoEmpleado
                    .Show()
                    .Text = "Detalle Empleado"
                    .aceptarbtn.Text = "Aceptar"
                    .idbox.Text = sqla.DBDT.Rows(0).Item(0)
                    .nombrebox.Text = sqla.DBDT.Rows(0).Item(1)
                    .apellidobox.Text = sqla.DBDT.Rows(0).Item(2)
                    .especialidadbox.Text = sqla.DBDT.Rows(0).Item(3)
                    .costohhbox.Text = sqla.DBDT.Rows(0).Item(4)

                End With
                Exit For
            End If

        Next




    End Sub
End Class