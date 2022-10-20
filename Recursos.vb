Public Class Recursos
    Public sql As New Sqlcontrol
    Private Sub Recursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("Select ID, Nombre, Apellido from Personal")
        For Each fila As DataRow In sql.DBDT.Rows
            With DGVRecursos
                .Rows.Add(fila.ItemArray)

            End With
        Next
        sql.execquery("Select distinct(Especialidad) from Personal")
        For Each fila As DataRow In sql.DBDT.Rows
            categoriabox.Items.Add(fila.Item(0))
        Next


    End Sub

    Private Sub DGVRecursos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecursos.CellContentDoubleClick

        With Tareas.DGVTareas
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells(0).Value = DGVRecursos.Rows(e.RowIndex).Cells(0).Value
        End With
        Tareas.Borrar()
        Tareas.Llenar()
        Tareas.EncabezadoFila()
    End Sub

    Private Sub añadirbtn_Click(sender As Object, e As EventArgs) Handles añadirbtn.Click
        With sql
            .Addparam("@Especialidad", categoriabox.Text)
            .execquery("Select ID from Personal where Especialidad = @Especialidad")
        End With

        For Each fila As DataRow In sql.DBDT.Rows
            With Tareas.DGVTareas
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells(0).Value = fila.Item(0)
            End With
        Next
        Tareas.Borrar()
        Tareas.Llenar()
        Tareas.EncabezadoFila()

    End Sub

    Private Sub DGVRecursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecursos.CellContentClick

    End Sub
End Class