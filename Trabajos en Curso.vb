Imports ClasesLibreria
Public Class Trabajos
    Public metodos As New ClasesLibreria.Funciones
    Public sqla As New Sqlcontrol
    Private Sub Trabajos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Dim Check As New DataGridViewCheckBoxColumn
        With DataGridView1
            .Columns.Add("Ingreso", "N° Ing")
            .Columns.Add("OT", "OT")
            .Columns.Add("Cot", "Cot")
            .Columns.Add("Cliente", "Cliente")
            .Columns.Add("Patente", "Patente")
            .Columns.Add("Vehiculo", "Vehiculo")
            .Columns.Add("KM", "KM")
            .Columns.Add("Entrada", "Entrada")
            .Columns.Add("Salida", "Salida")
            .Columns.Add("Detalles", "Detalles")
            .Columns.Add("Mecanico", "Mecanico")
            .Columns.Add("Observaciones", "Observaciones")
            .Columns.Add(Check)


        End With

        DataGridView1.Columns(12).Name = "Check"

        DataGridView1.Columns(6).DefaultCellStyle.Format = "#,##0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "dd-MM-yyyy HH:mm"

        Llenar()

        With ComboBox1.Items
            .Add("Patente")
            .Add("Cliente")
            .Add("OT")
            .Add("Modelo")
            ComboBox1.Sorted = True
        End With
        DataGridView1.Columns(0).Width = 40
        DataGridView1.Columns(1).Width = 40
        DataGridView1.Columns(2).Width = 40
        DataGridView1.Columns(3).Width = 80
        DataGridView1.Columns(5).Width = 60
        DataGridView1.Columns(4).Width = 40
        DataGridView1.Columns(6).Width = 50
        DataGridView1.Columns(7).Width = 60
        DataGridView1.Columns(8).Width = 60
        DataGridView1.Columns(9).Width = 120
        DataGridView1.Columns(11).Width = 120
        DataGridView1.Columns(10).Width = 50
        DataGridView1.Columns(12).Width = 30

    End Sub
    Public Sub Llenar()
        sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Registro.Salida is null")
        DataGridView1.Rows.Clear()

        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)


            End With

        Next
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)

    End Sub



    Private Sub EnCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnCursoToolStripMenuItem.Click
        Llenar()

    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID")
        DataGridView1.Rows.Clear()

        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next
    End Sub

    Private Sub TerminadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminadosToolStripMenuItem.Click


        sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Registro.Salida is not null")
        DataGridView1.Rows.Clear()

        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next







    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Llenar()
    End Sub

    Private Sub abrircotbtn_Click(sender As Object, e As EventArgs) Handles abrircotbtn.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then

                For Each form In My.Application.OpenForms
                    If (form.name = Cotizacion.Name) Then

                        Cotizacion.Close()
                        Exit Sub
                    End If
                Next

                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Select estado from CotGeneral where Cotizacion = @Cot")
                If sqla.DBDT.Rows(0).Item(0) <> "Abierta" Then
                    With Cotizacion


                        .DGVInventario.Enabled = False
                        .DGVDetalle.Enabled = False
                        .DGVInventario.Enabled = False
                        .DGVDetalle.Enabled = False
                        .Button1.Enabled = False
                        .Button8.Enabled = False
                        .Button4.Enabled = False
                        .Button7.Enabled = False
                        .Button6.Enabled = False


                    End With


                End If


                If sqla.DBDT.Rows(0).Item(0) <> "Abierta" And IsDBNull(fila.Cells(8).Value) Then

                    Button3.Enabled = False
                End If





                Cotizacion.TextBox2.Text = fila.Cells(2).Value
                Cotizacion.TextBox3.Text = fila.Cells(3).Value
                Cotizacion.TextBox6.Text = fila.Cells(9).Value
                Cotizacion.Show()

                sqla.Addparam("@Num", fila.Cells(2).Value)
                sqla.execquery("select CodItem, Item, Cantidad, Precio, Total from Cotizaciones where Cotizacion = @Num ")
                For Each row As DataRow In sqla.DBDT.Rows
                    With Cotizacion.DGVDetalle
                        .Rows.Add(row.ItemArray)


                    End With

                Next
                ''sumar descuentos
                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Select sum(Total) from Cotizaciones where Cotizacion = @Cot and CodItem = '20201010'")
                If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                    Dim descuentos As Double = sqla.DBDT.Rows(0).Item(0)
                    Cotizacion.TextBox9.Text = descuentos.ToString("$#,##0")
                Else
                    Cotizacion.TextBox9.Text = "$0"

                End If


                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Select Clientes.IdCliente, Registro.IDCLiente From Clientes INNER Join Registro On Registro.IDCliente = Clientes.ID Where Registro.OT = @OT")

                Cotizacion.TextBox7.Text = metodos.FormatRutView(sqla.DBDT.Rows(0).Item(0))
                Cotizacion.TextBox8.Text = sqla.DBDT.Rows(0).Item(1)
                Cotizacion.DGVClientes.Enabled = False

                Cotizacion.Sumar()
                Me.Close()
                onoff = "on"
                ing = "NO"
                Exit For
            End If

        Next

    End Sub

    Private Sub Pagarbtn_Click(sender As Object, e As EventArgs) Handles Pagarbtn.Click

        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                For Each form In My.Application.OpenForms
                    If (form.name = PuntoVenta.Name) Then
                        If MsgBox("Tiene una venta abierta, ¿Desea cerrarla antes de comenzar una nueva? ", vbYesNo, Title:="Cotizar") = "6" Then
                            PuntoVenta.BringToFront()
                            Exit Sub
                        Else
                            PuntoVenta.Close()
                            Exit For
                        End If
                    End If
                Next




                sqla.Addparam("@COT", fila.Cells(2).Value)
                sqla.execquery("Select Estado from CotGeneral where Cotizacion = @COT")
                If sqla.DBDT.Rows(0).Item(0) <> "Aprobada" Then
                    MsgBox("Debe aprobar esta cotización antes de pasar a pago", Title:="Trabajos en curso")
                    Exit Sub
                End If

                Dim sum As Double
                PuntoVenta.DataGridView1.Columns(0).ValueType = GetType(String)
                PuntoVenta.DataGridView1.Columns(1).ValueType = GetType(Decimal)
                PuntoVenta.DataGridView1.Columns(2).ValueType = GetType(Decimal)
                PuntoVenta.DataGridView1.Columns(3).ValueType = GetType(Decimal)
                PuntoVenta.DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
                PuntoVenta.DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
                PuntoVenta.OrdTextBox.Text = fila.Cells(1).Value
                PuntoVenta.ClienteTextBox.Text = fila.Cells(3).Value
                PuntoVenta.CotTextBox2.Text = fila.Cells(2).Value
                PuntoVenta.VehiculoTextBox.Text = fila.Cells(4).Value
                PuntoVenta.kilometrajetxt.Text = fila.Cells(6).FormattedValue
                sqla.Addparam("@Num", fila.Cells(2).Value)
                sqla.execquery("select Item, Cantidad, Precio, Total from Cotizaciones where Cotizacion = @Num ")

                For Each row As DataRow In sqla.DBDT.Rows
                    PuntoVenta.DataGridView1.Rows.Add(row.ItemArray)
                Next

                sqla.Addparam("@COT", fila.Cells(2).Value)
                sqla.execquery("Select sum(Total) from Cotizaciones where Cotizacion = @COT and CodItem = '20201010'")
                If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                    Dim descuento As Double = sqla.DBDT.Rows(0).Item(0)
                    PuntoVenta.TextBox1.Text = descuento.ToString("$#,##0")
                Else
                    Dim descuento As Double = "0$"
                    PuntoVenta.TextBox1.Text = descuento.ToString("$#,##0")

                End If





                For Each row As DataGridViewRow In PuntoVenta.DataGridView1.Rows
                    sum = sum + row.Cells(3).Value

                Next
                PuntoVenta.TextBox8.Text = sum.ToString("$#,##0")

                Me.Close()
                PuntoVenta.Show()
            End If

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Select Ano, Motor from Registro where Cotizacion = @Cot")
                With fila
                    If IsDBNull(.Cells(2).Value) = True Then
                        Ingreso.TextBox6.Text = " "
                    Else
                        Ingreso.TextBox6.Text = .Cells(2).Value
                    End If

                    If IsDBNull(.Cells(1).Value) = True Then
                        Ingreso.TextBox2.Text = " "
                    Else
                        Ingreso.TextBox2.Text = .Cells(1).Value
                    End If

                    If IsDBNull(.Cells(0).Value) = True Then
                        Ingreso.TextBox8.Text = " "
                    Else
                        Ingreso.TextBox8.Text = .Cells(0).Value
                    End If

                    If IsDBNull(.Cells(3).Value) = True Then
                        Ingreso.TextBox1.Text = " "
                    Else
                        Ingreso.TextBox1.Text = .Cells(3).Value
                    End If

                    If IsDBNull(.Cells(4).Value) = True Then
                        Ingreso.ComboBox2.Text = " "
                    Else
                        Ingreso.ComboBox2.Text = .Cells(4).Value
                    End If

                    If IsDBNull(.Cells(5).Value) = True Then
                        Ingreso.TextBox4.Text = " "
                    Else
                        Ingreso.TextBox4.Text = .Cells(5).Value
                    End If

                    If IsDBNull(.Cells(6).Value) = True Then
                        Ingreso.TextBox5.Text = " "
                    Else
                        Ingreso.TextBox5.Text = .Cells(6).Value
                    End If
                    If IsDBNull(.Cells(10).Value) = True Then
                        Ingreso.ComboBox1.Text = " "
                    Else
                        Ingreso.ComboBox1.Text = .Cells(10).Value
                    End If

                    If IsDBNull(.Cells(9).Value) = True Then
                        Ingreso.TextBox7.Text = " "
                    Else
                        Ingreso.TextBox7.Text = .Cells(9).Value
                    End If
                    If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
                        Ingreso.TextBox3.Text = " "
                    Else
                        Ingreso.TextBox3.Text = sqla.DBDT.Rows(0).Item(0)
                    End If
                    If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = True Then
                        Ingreso.TextBox11.Text = " "
                    Else
                        Ingreso.TextBox11.Text = sqla.DBDT.Rows(0).Item(1)
                    End If

                    Ingreso.Show()
                    Ingreso.Button2.Visible = False
                End With

            End If

        Next

    End Sub

    Private Sub filtrofecha_ValueChanged(sender As Object, e As EventArgs) Handles filtrofecha.ValueChanged
        Dim a = {{"@Dia", filtrofecha.Value.Date.DayOfYear}, {"@Ano", filtrofecha.Value.Date.Year}}
        sqla.Addparam(a)

        sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, registro.observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where datepart(DAYOFYEAR,Entrada) = @Dia and datepart(YEAR,Entrada) = @Ano")

        DataGridView1.Rows.Clear()

        For Each fila As DataRow In sqla.DBDT.Rows
            With DataGridView1
                .Rows.Add(fila.ItemArray)

            End With

        Next
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ID As String
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                VerCliente.Show()
                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Select IDCliente from Registro Where OT=@OT")
                ID = sqla.DBDT.Rows(0).Item(0)
                sqla.Addparam("@ID", ID.ToString)
                sqla.execquery("Select * from Clientes where ID = @ID")
                If IsDBNull(sqla.DBDT.Rows(0).Item(1)) Then
                    VerCliente.IDTextBox.Text = " "
                Else
                    VerCliente.IDTextBox.Text = metodos.FormatRutView(sqla.DBDT.Rows(0).Item(1))
                End If

                If IsDBNull(sqla.DBDT.Rows(0).Item(2)) Then
                    VerCliente.NomTextBox.Text = " "
                Else
                    VerCliente.NomTextBox.Text = sqla.DBDT.Rows(0).Item(2)
                End If

                If IsDBNull(sqla.DBDT.Rows(0).Item(3)) Then
                    VerCliente.ApellidoTextBox.Text = " "
                Else
                    VerCliente.ApellidoTextBox.Text = sqla.DBDT.Rows(0).Item(3)
                End If

                If IsDBNull(sqla.DBDT.Rows(0).Item(4)) Then
                    VerCliente.MailTextBox.Text = " "
                Else
                    VerCliente.MailTextBox.Text = sqla.DBDT.Rows(0).Item(4)
                End If

                If IsDBNull(sqla.DBDT.Rows(0).Item(5)) Then
                    VerCliente.FonoTextBox.Text = " "
                Else
                    VerCliente.FonoTextBox.Text = sqla.DBDT.Rows(0).Item(5)
                End If


            End If
        Next


    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                    Exit Sub
                End If
                Dim letras As String
                letras = TextBox1.Text
                If ComboBox1.Text = "OT" Then
                    sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID  where OT like '" & letras + "%" & "'")

                    DataGridView1.Rows.Clear()

                    For Each fila As DataRow In sqla.DBDT.Rows
                        With DataGridView1
                            .Rows.Add(fila.ItemArray)

                        End With

                    Next


                End If

                If ComboBox1.Text = "Patente" Then
                    sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Patente like '" & letras + "%" & "'")
                    DataGridView1.Rows.Clear()

                    For Each fila As DataRow In sqla.DBDT.Rows
                        With DataGridView1
                            .Rows.Add(fila.ItemArray)

                        End With

                    Next
                End If



                If ComboBox1.Text = "Cliente" Then
                    sqla.Addparam("@Texto", letras)
                    sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Cliente like '%' + @Texto + '%' or Clientes.Nombre like '%' + @Texto + '%' OR Clientes.Apellido LIKE '%' + @Texto + '%'")
                    DataGridView1.Rows.Clear()

                    For Each fila As DataRow In sqla.DBDT.Rows
                        With DataGridView1
                            .Rows.Add(fila.ItemArray)

                        End With

                    Next
                End If

                If ComboBox1.Text = "Modelo" Then
                    sqla.execquery("Select Registro.NIngreso, Registro.OT, Registro.Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Registro.Patente, Registro.Vehiculo, Registro.Kilometraje, Registro.Entrada, Registro.Salida, Registro.Detalles, Registro.Mecanico, Registro.Observaciones from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Vehiculo like '" & "%" + letras + "%" & "'")
                    DataGridView1.Rows.Clear()

                    For Each fila As DataRow In sqla.DBDT.Rows
                        With DataGridView1
                            .Rows.Add(fila.ItemArray)

                        End With

                    Next
                End If




        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                If MsgBox("Se cambiará el estado de la orden de trabajo y se borrará del registro de ventas, ¿Desea continuar?", vbYesNo, Title:="Aprobar") = "7" Then Exit Sub

                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Update Registro set Salida = Null where OT = @OT")
                If sqla.Masexception(True) Then Exit Sub
                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Select IDVenta from Ventas where OT = @OT")
                For Each idventa As DataRow In sqla.DBDT.Rows
                    sqla.Addparam("@IDVenta", idventa.Item(0))
                    sqla.execquery("Delete from Costos where IDVenta = @IDVenta")
                Next
                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Delete from Ventas where OT = @OT")
                If MsgBox("¿Desea abrir la cotización asociada?", vbYesNo, Title:="Aprobar") = "7" Then Exit Sub
                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Update CotGeneral Set Estado = 'Abierta' where Cotizacion = @Cot")
                If sqla.Masexception(True) Then Exit Sub
                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Delete from Caja where Responsable = @OT")

                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Select CodItem, Cantidad from Cotizaciones where Cotizacion = @Cot")
                Dim dt As DataTable = sqla.DBDT
                For Each row As DataRow In dt.Rows
                    sqla.Addparam("@IDItem", row.Item(0))
                    sqla.Addparam("@Cantidad", row.Item(1))
                    sqla.execquery("Update Inventario set Stock = Stock + @Cantidad where ID = @IDItem")
                Next
                sqla.Addparam("@Cot", fila.Cells(2).Value)
                sqla.execquery("Update Cotizaciones Set Inventariado = 'No' where Cotizacion = @Cot ")


                Exit For
            End If
        Next

    End Sub

    Private Sub ImprimirTrabajosEnCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirTrabajosEnCursoToolStripMenuItem.Click

        imprimir = "Trabajos"
        Impresion.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                Observaciones.Show()
                Observaciones.otbox.Text = fila.Cells(1).Value
                sqla.Addparam("@OT", fila.Cells(1).Value)
                sqla.execquery("Select Observaciones from Registro where OT = @OT")
                If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                    Observaciones.Observacionesbox.Text = " "
                Else

                    Observaciones.Observacionesbox.Text = sqla.DBDT.Rows(0).Item(0)

                End If
            End If
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Tareas.Show()
        Tareas.BringToFront()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 Then

            For Each fila As DataGridViewRow In DataGridView1.Rows
                fila.Cells(e.ColumnIndex).Value = False

            Next
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True



        End If
    End Sub

    Private Sub VerVehiculobtn_Click(sender As Object, e As EventArgs) Handles VerVehiculobtn.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                sqla.Addparam("@Patente", fila.Cells(4).Value)
                sqla.execquery("Select distinct Patente, Vehiculo, Case When Kilometraje is null then ' ' else Kilometraje END, case when Ano is null then ' ' else Ano end, case when Motor is null then ' ' else Motor end from Registro where Patente = @Patente ")
                With VerVehiculoForm
                    .Show()
                    .patentebox.Text = fila.Cells(4).Value
                    .marcamodelobox.Text = fila.Cells(5).Value
                    .kilometrajebox.Text = fila.Cells(6).Value
                    .anobox.Text = sqla.DBDT.Rows(0).Item(3)
                    .motorbox.Text = sqla.DBDT.Rows(0).Item(4)
                End With
            End If
        Next
    End Sub

    Private Sub EditarMecanicoBtn_Click(sender As Object, e As EventArgs) Handles EditarMecanicoBtn.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(12).Value = True Then
                ActualizarMecanico.Show()
                ActualizarMecanico.otbox.Text = fila.Cells(1).Value

            End If
        Next
    End Sub


End Class