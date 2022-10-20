Imports ClasesLibreria.Funciones
Public Class Cotizaciones
    Public metodos As New ClasesLibreria.Funciones
    Public sqla As New Sqlcontrol

    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MdiParent = Principal
        'sqla.execquery("select distinct Cotizacion ,fecha, cliente,  sum(Total) Total , Estado from Cotizaciones group by cotizacion ,fecha , cliente , Estado;")

        Dim Check As New DataGridViewCheckBoxColumn
        With DataGridView1.Columns
            .Add("Cotizacion", "Cotización")
            .Add("Fecha", "Fecha")
            .Add("Cliente", "Cliente")
            .Add("Total", "Total")
            .Add("Estado", "Estado")
            .Add("Detalles", "Detalles")
            .Add("Patente", "Patente")
            .Add(Check)
        End With
        DataGridView1.Columns(7).Name = "Check"

        Llenar()

        With DataGridView1
            .Columns(3).DefaultCellStyle.Format = "$#,##0"
            .Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"
            .Columns(0).Width = 60
            .Columns(1).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 250
        End With



        With ComboBox1
            .Items.Add("CLIENTE")
            .Items.Add("COTIZACION")
        End With





    End Sub

    Public Sub Llenar()


        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Estado = 'Abierta'")
        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)





    End Sub
    Private Sub CotizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizaciónToolStripMenuItem.Click
        For Each form In My.Application.OpenForms
            If (form.name = Cotizacion.Name) Then
                If MsgBox("Tiene una cotización abierta, ¿Desea guardala antes de comenzar una nueva? ", vbYesNo, Title:="Cotizar") = "6" Then
                    Cotizacion.BringToFront()
                    Exit Sub
                Else
                    Cotizacion.Close()
                    Exit For
                End If
            End If
        Next

        sqla.execquery("SELECT MAX(Cotizacion)From CotGeneral;")
        If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
            Cotizacion.TextBox2.Text = 1
        Else
            Cotizacion.TextBox2.Text = sqla.DBDT.Rows(0).Item(0) + 1
        End If
        ing = "NO"
        Cotizacion.Show()
        Cotizacion.Button4.Enabled = True
    End Sub



    Private Sub TodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasToolStripMenuItem.Click
        DataGridView1.Rows.Clear()

        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID")
        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)


            End With

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub DescartarUnaCotizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescartarUnaCotizaciónToolStripMenuItem.Click
        DataGridView1.AllowUserToDeleteRows = True
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        If MsgBox("Está a punto de eliminar Cotización N° " & DataGridView1.Rows(e.Row.Index).Cells(0).Value & ", ¿Desea Continuar?", vbYesNo, Title:="Cotizaciones") = 7 Then
            e.Cancel = True
        Else
            sqla.Addparam("@Cot", DataGridView1.Rows(e.Row.Index).Cells(0).Value)
            sqla.execquery("Update CotGeneral set Estado = 'Descartada' where Cotizacion = @Cot")

        End If

    End Sub

    Private Sub AprobadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprobadasToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Estado = 'Aprobada'")
        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)


            End With

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub


    Private Sub CotizacionesIncompletasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesIncompletasToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Estado = 'Abierta'")
        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub

    Private Sub CotizacionesCompletasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionesCompletasToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Estado = 'Cerrada'")
        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Llenar()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            Exit Sub
        End If
        If ComboBox1.Text = "CLIENTE" Then
            DataGridView1.Rows.Clear()
            sqla.Addparam("@Cliente", TextBox1.Text + "%")
            sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Cliente like @Cliente")
            For Each fila As DataRow In sqla.DBDT.Rows
                With DataGridView1
                    .Rows.Add(fila.ItemArray)

                End With

            Next

            DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        Else
            DataGridView1.Rows.Clear()
            sqla.Addparam("@COT", TextBox1.Text + "%")
            sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where Cotizacion like @COT")
            For Each fila As DataRow In sqla.DBDT.Rows
                With DataGridView1
                    .Rows.Add(fila.ItemArray)

                End With

            Next


        End If
    End Sub

    Private Sub abrircotbtn_Click(sender As Object, e As EventArgs) Handles abrircotbtn.Click
        For Each row As DataGridViewRow In DataGridView1.Rows


            If row.Cells(7).Value = True Then
                For Each form In My.Application.OpenForms
                    If (form.name = Cotizacion.Name) Then
                        If MsgBox("Tiene una cotización abierta, ¿Desea guardala antes de comenzar una nueva? ", vbYesNo, Title:="Cotizar") = "6" Then
                            Cotizacion.BringToFront()
                            Exit Sub
                        Else
                            Cotizacion.Close()
                            Exit For
                        End If
                    End If
                Next

                With row

                    Cotizacion.TextBox2.Text = row.Cells(0).Value
                    Cotizacion.TextBox3.Text = row.Cells(2).Value
                    Cotizacion.TextBox6.Text = row.Cells(5).Value

                    Cotizacion.Show()

                    sqla.Addparam("@COT", row.Cells(0).Value)
                    sqla.execquery("Select Clientes.IdCliente, CotGeneral.IDCliente From Clientes INNER Join CotGeneral On CotGeneral.IDCliente = Clientes.ID Where CotGeneral.Cotizacion = @COT")

                    Cotizacion.TextBox7.Text = metodos.FormatRutView(sqla.DBDT.Rows(0).Item(0))
                    Cotizacion.TextBox8.Text = sqla.DBDT.Rows(0).Item(1)

                    sqla.Addparam("@Num", row.Cells(0).Value)
                    sqla.execquery("select CodItem, Item, Cantidad, Precio, Total from Cotizaciones where Cotizacion = @Num ")


                    For Each fila As DataRow In sqla.DBDT.Rows
                        Cotizacion.DGVDetalle.Rows.Add(fila.ItemArray)
                    Next


                End With

                '          x = sqla.DBDT.Rows.Count

                ing = "NO"

                Cotizacion.DGVClientes.Enabled = False
                Cotizacion.Sumar()



                onoff = "on"


                sqla.Addparam("@Cot", row.Cells(0).Value)
                sqla.execquery("Select estado from CotGeneral where Cotizacion = @Cot")
                If sqla.DBDT.Rows(0).Item(0) <> "Abierta" Then
                    With Cotizacion


                        .DGVInventario.Enabled = False
                        .DGVDetalle.Enabled = False
                        .Button1.Enabled = False
                        .Button8.Enabled = False
                        .Button4.Enabled = False
                        .Button7.Enabled = False
                        .Button6.Enabled = False
                        .Button3.Enabled = False

                    End With
                Else

                    Cotizacion.Button5.Text = "Editar"
                    NuevoCliente.Text = "Actualizar Cliente"

                End If

                sqla.Addparam("@Cot", row.Cells(0).Value)
                sqla.execquery("Select sum(Total) from Cotizaciones where Cotizacion = @Cot and CodItem = '20201010'")

                If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                    Dim descuento As Double = sqla.DBDT.Rows(0).Item(0) * -1
                    Cotizacion.TextBox9.Text = descuento.ToString("$#,##0")
                Else
                    Cotizacion.TextBox9.Text = "$0"
                End If


            End If









        Next




    End Sub

    Private Sub filtrofecha_ValueChanged(sender As Object, e As EventArgs) Handles filtrofecha.ValueChanged
        sqla.Addparam("@Dia", filtrofecha.Value.Date.DayOfYear)
        sqla.Addparam("@Ano", filtrofecha.Value.Date.Year)
        sqla.execquery("select CotGeneral.Cotizacion, CotGeneral.Fecha, Clientes.Nombre + ' ' + Clientes.Apellido, case when CotGeneral.Total is null then 0 else CotGeneral.Total end, CotGeneral.Estado, CotGeneral.Detalles, CotGeneral.Patente from CotGeneral inner join Clientes on CotGeneral.IDCliente = Clientes.ID where datepart(DAYOFYEAR,Fecha) = @Dia and datepart(YEAR,Fecha) = @Ano")

        DataGridView1.Rows.Clear()

        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(7).Value = True Then
                If MsgBox("Se cambiará el estado de la cotización a Abierto, ¿Desea continuar?", vbYesNo, Title:="Aprobar") = "7" Then Exit Sub

                sqla.Addparam("@Cot", row.Cells(0).Value)
                sqla.execquery("Update CotGeneral Set Estado = 'Abierta' where Cotizacion = @Cot")
                If sqla.Masexception(True) Then Exit Sub

                sqla.Addparam("@Cot", row.Cells(0).Value)
                sqla.execquery("Select CodItem, Cantidad from Cotizaciones where Cotizacion = @Cot")
                Dim dt As DataTable = sqla.DBDT
                For Each fila As DataRow In dt.Rows
                    sqla.Addparam("@IDItem", fila.Item(0))
                    sqla.Addparam("@Cantidad", fila.Item(1))
                    sqla.execquery("Update Inventario set Stock = Stock + @Cantidad where ID = @IDItem")
                Next
                sqla.Addparam("@Cot", row.Cells(0).Value)
                sqla.execquery("Update Cotizaciones Set Inventariado = 'No' where Cotizacion = @Cot ")
                Exit For
            End If
        Next



    End Sub

    Private Sub PendienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendienteToolStripMenuItem.Click
        CotizacionesPendientes.Show()
    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Precios.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 Then
            For Each fila As DataGridViewRow In DataGridView1.Rows
                fila.Cells(e.ColumnIndex).Value = False
            Next
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
        End If
    End Sub
End Class