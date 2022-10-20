Public Class Programar
    Public sql As New Sqlcontrol
    Private Sub Programar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With sql
            .Addparam("@OT", OTbox.Text)
            .execquery("Select cotizaciones.Item from Cotizaciones 
                        inner join Registro on Cotizaciones.Cotizacion = Registro.Cotizacion
                        inner join Inventario on Cotizaciones.CodItem = Inventario.ID
                        where Registro.OT = @OT and Inventario.Categoria = 'Servicios' ")
            For Each fila As DataRow In .DBDT.Rows
                tareasbox.Items.Add(fila.Item(0))
            Next

            sql.execquery("Select ID from Personal where Especialidad = 'ELEVADOR'")
            For Each fila As DataRow In sql.DBDT.Rows
                ComboBox1.Items.Add(fila.Item(0))
            Next


            sql.execquery("Select Nombre + ' ' + Apellido from Personal where Especialidad = 'MECÁNICO AUTOMOTRIZ'")
            For Each fila As DataRow In sql.DBDT.Rows
                Mecanicobox.Items.Add(fila.Item(0))


            Next


            sql.execquery("Select OT from Registro where Salida is null")
            For Each fila As DataRow In sql.DBDT.Rows
                OTbox.Items.Add(fila.Item(0))
            Next

        End With
    End Sub





    Private Sub tareasbox_MouseDown(sender As Object, e As MouseEventArgs) Handles tareasbox.MouseDown
        Dim algo As String = "OT" + " " + OTbox.Text & vbCrLf & tareasbox.SelectedItem.ToString
        Tareas.origen = "Programar"
        tareasbox.DoDragDrop(algo.ToString, DragDropEffects.Copy)

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Tareas.elevadorbox.Text = ComboBox1.Text


    End Sub

    Private Sub OTbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OTbox.SelectedIndexChanged
        tareasbox.Items.Clear()

        With sql
            .Addparam("@OT", OTbox.Text)
            .execquery("Select cotizaciones.Item from Cotizaciones 
inner join Registro on Cotizaciones.Cotizacion = Registro.Cotizacion
inner join Inventario on Cotizaciones.CodItem = Inventario.ID
where Registro.OT = @OT and Inventario.Categoria = 'Servicios' ")
            For Each fila As DataRow In .DBDT.Rows
                tareasbox.Items.Add(fila.Item(0))
            Next


        End With

    End Sub

    Private Sub Mecanicobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mecanicobox.SelectedIndexChanged
        sql.Addparam("@Mecanico", Mecanicobox.Text)
        sql.execquery("Select ID from Personal where Nombre + ' ' + Apellido = @Mecanico")
        idmecanicobox.Text = sql.DBDT.Rows(0).Item(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Recursos.Show()
    End Sub
End Class