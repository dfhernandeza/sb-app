
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class Impresion

    
        Public sqla As New Sqlcontrol
    Public origen As String
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Impresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        With dt
            .Columns.Add("Item")
            .Columns.Add("Cantidad")
            .Columns.Add("Precio")
            .Columns.Add("Total")

        End With
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Refresh()

        If imprimir = "Detalle" Then
            dt.Columns(2).DataType = GetType(Double)
            dt.Columns(3).DataType = GetType(Double)
            sqla.Addparam("@OT", DetalleVentas.DataGridView1.Rows(0).Cells(0).Value)
            sqla.execquery("Select Item, Cantidad, Sum(PVenta) PVenta, Sum(Total) Total from Ventas where OT = @OT group by Cantidad, Item")
            For Each dr As DataRow In sqla.DBDT.Rows
                dt.Rows.Add(dr.ItemArray)
            Next

            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReport1
            rptdoc.SetDataSource(dt)

            rptdoc.SetParameterValue("OrdenPar", DetalleVentas.DataGridView1.Rows(0).Cells(0).Value)
            rptdoc.SetParameterValue("ClientePar", DetalleVentas.DataGridView1.Rows(0).Cells(12).Value)
            rptdoc.SetParameterValue("PATENTE", DetalleVentas.DataGridView1.Rows(0).Cells(13).Value)
            rptdoc.SetParameterValue("KILOMETRAJE", DetalleVentas.TextBox2.Text)
            rptdoc.SetParameterValue("TOTALP", DetalleVentas.TextBox4.Text)
            rptdoc.SetParameterValue("detalles", DetalleVentas.TextBox5.Text)
            rptdoc.SetParameterValue("FECHA", DetalleVentas.DataGridView1.Rows(0).Cells(1).Value)
            rptdoc.SetParameterValue("IdCliente", DetalleVentas.TextBox7.Text)
            rptdoc.SetParameterValue("Vehiculo", DetalleVentas.TextBox6.Text)

            Me.CrystalReportViewer1.ReportSource = rptdoc

        End If

        '===============================================================================================================================

        If imprimir = "Pventa" Then

            For Each dr As DataGridViewRow In PuntoVenta.DataGridView1.Rows
                If Not dr.Cells(0).Value = "DESCUENTO" Then
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).FormattedValue, dr.Cells(3).FormattedValue)
                End If

            Next

            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReport1
            rptdoc.SetDataSource(dt)


            rptdoc.SetParameterValue("OrdenPar", PuntoVenta.OrdTextBox.Text)
            rptdoc.SetParameterValue("ClientePar", PuntoVenta.ClienteTextBox.Text)
            rptdoc.SetParameterValue("PATENTE", PuntoVenta.VehiculoTextBox.Text)
            rptdoc.SetParameterValue("KILOMETRAJE", PuntoVenta.kilometrajetxt.Text)
            rptdoc.SetParameterValue("TOTALP", PuntoVenta.TextBox8.Text)
            sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
            sqla.execquery(" Select Clientes.IdCliente From Clientes INNER Join Registro On Registro.IDCliente = Clientes.ID Where Registro.OT = @OT ")
            rptdoc.SetParameterValue("IdCliente", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
            sqla.execquery("Select * from Registro where OT = @OT")
            rptdoc.SetParameterValue("Detalles", sqla.DBDT.Rows(0).Item(9))
            rptdoc.SetParameterValue("Vehiculo", sqla.DBDT.Rows(0).Item(5))
            rptdoc.SetParameterValue("Fecha", DateTime.Today)
            rptdoc.SetParameterValue("Descuento", PuntoVenta.TextBox1.Text)
            sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
            sqla.execquery("Select Observaciones from Registro where OT = @OT")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                rptdoc.SetParameterValue("COMENTARIOS", " ")
            Else
                rptdoc.SetParameterValue("COMENTARIOS", sqla.DBDT.Rows(0).Item(0))
            End If

            Me.CrystalReportViewer1.ReportSource = rptdoc

        End If
        If imprimir = "VentaRapida" Then

            For Each dr As DataGridViewRow In VentaRapida.DGVDetalle.Rows

                dt.Rows.Add(dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).FormattedValue, dr.Cells(4).FormattedValue)


            Next

            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New PuntoVentaRpt
            rptdoc.SetDataSource(dt)

            rptdoc.SetParameterValue("FECHA", Date.Today.ToString("dd-MM-yyyy"))
            rptdoc.SetParameterValue("OrdenPar", VentaRapida.Ordenbox.Text)
            'rptdoc.SetParameterValue("ClientePar", VentaRapida.ClienteTextBox.Text)
            'rptdoc.SetParameterValue("PATENTE", PuntoVenta.VehiculoTextBox.Text)
            'rptdoc.SetParameterValue("KILOMETRAJE", VentaRapida.kilometrajetxt.Text)
            rptdoc.SetParameterValue("TOTALP", VentaRapida.TextBox4.Text)
            'sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
            'sqla.execquery(" Select Clientes.IdCliente From Clientes INNER Join Registro On Registro.IDCliente = Clientes.ID Where Registro.OT = @OT ")
            'rptdoc.SetParameterValue("IdCliente", sqla.DBDT.Rows(0).Item(0))
            'sqla.Addparam("@OT", VentaRapida.Ordenbox.Text)
            'sqla.execquery("Select * from Registro where OT = @OT")
            'rptdoc.SetParameterValue("Detalles", sqla.DBDT.Rows(0).Item(9))
            'rptdoc.SetParameterValue("Vehiculo", sqla.DBDT.Rows(0).Item(5))
            'rptdoc.SetParameterValue("Fecha", DateTime.Today)
            'rptdoc.SetParameterValue("Descuento", PuntoVenta.TextBox1.Text)
            'sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
            'sqla.execquery("Select Observaciones from Registro where OT = @OT")
            'If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
            '    rptdoc.SetParameterValue("COMENTARIOS", " ")
            'Else
            '    rptdoc.SetParameterValue("COMENTARIOS", sqla.DBDT.Rows(0).Item(0))
            'End If

            Me.CrystalReportViewer1.ReportSource = rptdoc

        End If
        '===============================================================================================================================
        If imprimir = "InformeD" Then


            Dim iventas As CrystalDecisions.CrystalReports.Engine.ReportDocument
            iventas = New InformeVentas

            Dim td As New DataTable
            With td

                .Columns.Add("OT")
                .Columns.Add("Neto")
                .Columns.Add("IVA")
                .Columns.Add("Total")
                .Columns.Add("MedioPago")
                .Columns.Add("Costo")
                .Columns.Add("Categoria")
                .Columns.Add("Beneficio")
                .Columns.Add("Margen")
            End With
            td.Columns("OT").DataType = GetType(String)
            td.Columns("Neto").DataType = GetType(Double)
            td.Columns("Costo").DataType = GetType(Double)
            td.Columns("Beneficio").DataType = GetType(Double)
            td.Columns("Margen").DataType = GetType(Double)

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)

            sqla.execquery("select ventas.OT, sum(ventas.Neto) Neto, [dbo].[CostoOT] (Ventas.OT)  Costo, 
                sum(Ventas.Neto)- [dbo].[CostoOT] (Ventas.OT) Beneficio,  sum(Ventas.Neto)-[dbo].[CostoOT] (Ventas.OT)/sum(ventas.Neto)*100 Margen 
                from Ventas where  DATEPART (DAYOFYEAR , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano 
                group by OT")




            For Each dr As DataRow In sqla.DBDT.Rows
                td.Rows.Add(dr.ItemArray)
            Next


            iventas.Database.Tables("Datatable3_1").SetDataSource(td)






            iventas.SetDataSource(sqla.DBDT)


            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select Personal.Nombre + ' ' + Personal.Apellido Mecanico, dbo.VentaMecanicoDia(Personal.Nombre + ' ' + Personal.Apellido,@Dia,@ano) Total
                from Personal where Personal.Especialidad = 'MECÁNICO AUTOMOTRIZ'")

            iventas.Database.Tables(1).SetDataSource(sqla.DBDT)
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)

            sqla.execquery("select sum(total), sum(IVA), sum(Neto), count(distinct ot), SUM([dbo].[Costo]([IDVenta])) from Ventas where  DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Total", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Total", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("IVA", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("IVA", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(2)) = False Then
                iventas.SetParameterValue("Neto", sqla.DBDT.Rows(0).Item(2))
            Else

                iventas.SetParameterValue("Neto", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(3)) = False Then
                iventas.SetParameterValue("Cantidad", sqla.DBDT.Rows(0).Item(3))
            Else

                iventas.SetParameterValue("Cantidad", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(4)) = False Then
                iventas.SetParameterValue("Costo", sqla.DBDT.Rows(0).Item(4))
            Else

                iventas.SetParameterValue("Costo", 0)
            End If

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)

            sqla.execquery("select sum(neto)-sum(([dbo].[Costo]([IDVenta]))) Beneficio, format( (sum(neto)-sum(([dbo].[Costo]([IDVenta]))))/sum(neto), 'p0')  from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano")

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Bene", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Bene", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("Porcbene", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("Porcbene", 0)
            End If





            'resumen ventas
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'Efectivo' and DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano ")
            iventas.SetParameterValue("Efectivo", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'T. Débito' and DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano ")
            iventas.SetParameterValue("debito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'Efectivo' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TEfectivo", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TEfectivo", 0)
            End If

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'T. Débito' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TDebito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TDebito", 0)
            End If
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select count (distinct OT) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'T. Crédito' ")

            iventas.SetParameterValue("Tcredito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'T. Crédito' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TTcredito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TTcredito", 0)
            End If
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select count (distinct OT) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'CRÉDITO' ")
            iventas.SetParameterValue("credito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano and MedioPago = 'CRÉDITO' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("creditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("creditot", 0)
            End If

            'compras
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano AND FPago = 'Efectivo'")
            iventas.SetParameterValue("CEfectivo", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano And FPago = 'Efectivo'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CEfectivoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CEfectivoT", 0)
            End If

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano AND FPago = 'T. Débito'")
            iventas.SetParameterValue("Cdebito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano And FPago = 'T. Débito'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CdebitoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CdebitoT", 0)
            End If


            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano AND FPago = 'T. Crédito'")
            iventas.SetParameterValue("CTCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano And FPago = 'T. Crédito'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CTCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CTCreditoT", 0)
            End If
            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano AND FPago = 'Crédito'")
            iventas.SetParameterValue("CCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano And FPago = 'Crédito'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CCreditoT", 0)
            End If


            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano AND FPago = 'Cheque'")
            iventas.SetParameterValue("CCheque", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (y , [Fecha]) = @Dia AND datepart(year, [Fecha]) = @ano And FPago = 'Cheque'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CChequeT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CChequeT", 0)
            End If

            sqla.Addparam("@Dia", ifechad)
            sqla.Addparam("@ano", ifechay)
            sqla.execquery("select top(1) Sum(cantidad) over (order by ID) Acumulado from Caja order by ID desc ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Caja", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("Caja", 0)
            End If


            iventas.SetParameterValue("Fecha", FormatDateTime(fechita, DateFormat.ShortDate).ToString)




            'Dim dav As Integer = 0
            'Dim jos As Integer = 0
            'Dim vic As Integer = 0
            'Dim ort As Integer = 0
            'For Each fila As DataRow In sqla.DBDT.Rows
            '    If fila.Item(0) = "DAVID NOURDIN ESTAY" Then
            '        iventas.SetParameterValue("David", fila.Item(1))
            '        dav = 1
            '    ElseIf fila.Item(0) = "JOSEPH RODRÍGUEZ" Then
            '        iventas.SetParameterValue("Joseph", fila.Item(1))
            '        jos = 1
            '    ElseIf fila.Item(0) = "VICTOR LAGOS BRIONES" Then
            '        iventas.SetParameterValue("Victor", fila.Item(1))
            '        vic = 1
            '    ElseIf fila.Item(0) = "JOSE SAMUEL ORTEGA MUÑOZ" Then
            '        iventas.SetParameterValue("Ortega", fila.Item(1))
            '        ort = 1
            '    End If
            'Next
            'If dav = 0 Then
            '    iventas.SetParameterValue("David", 0)
            'End If
            'If jos = 0 Then
            '    iventas.SetParameterValue("Joseph", 0)
            'End If
            'If vic = 0 Then
            '    iventas.SetParameterValue("Victor", 0)
            'End If
            'If ort = 0 Then
            '    iventas.SetParameterValue("Ortega", 0)
            'End If

            Me.CrystalReportViewer1.ReportSource = iventas
                'iventas.SetDataSource(sqla.DBDT)



            End If
            '===============================================================================================================================
            If imprimir = "Cotizar" Then

            For Each dr As DataGridViewRow In Cotizacion.DGVDetalle.Rows
                If Not dr.Cells(0).Value = "20201010" Then
                    dt.Rows.Add(dr.Cells(1).Value,
                                                    dr.Cells(2).Value,
                                                    dr.Cells(3).FormattedValue,
                                                    dr.Cells(4).FormattedValue)
                End If

            Next

            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New Cotizacioni
            rptdoc.SetDataSource(dt)

            rptdoc.SetParameterValue("OrdenPar", Cotizacion.TextBox2.Text)
            rptdoc.SetParameterValue("ClientePar", Cotizacion.TextBox3.Text)
            'rptdoc.SetParameterValue("PATENTE", DetalleVentas.DataGridView1.Rows(0).Cells(13).Value)
            'rptdoc.SetParameterValue("KILOMETRAJE", DetalleVentas.TextBox2.Text)
            rptdoc.SetParameterValue("TOTALP", Cotizacion.TextBox4.Text)
            rptdoc.SetParameterValue("detalles", Cotizacion.TextBox6.Text)
            rptdoc.SetParameterValue("FECHA", DateTime.Today)
            rptdoc.SetParameterValue("IdCliente", Cotizacion.TextBox7.Text)
            If origen = "Coti" Then
                If Cotizacion.TextBox9.Text = "$0" Then
                    rptdoc.SetParameterValue("Descuento", "$0")
                Else
                    rptdoc.SetParameterValue("Descuento", Cotizacion.TextBox9.Text)
                End If
            Else
                If Not String.IsNullOrWhiteSpace(DetalleVentas.TextBox6.Text) Then
                    rptdoc.SetParameterValue("Descuento", Cotizacion.TextBox9.Text)
                End If

            End If


            rptdoc.SetParameterValue("Vehiculo", DetalleVentas.TextBox6.Text)



            sqla.Addparam("@OT", Cotizacion.TextBox2.Text)
                sqla.execquery("Select Observaciones from Registro where Cotizacion = @OT")
                If sqla.DBDT.Rows.Count > 0 Then
                    If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                        rptdoc.SetParameterValue("COMENTARIOS", " ")
                    Else
                        rptdoc.SetParameterValue("COMENTARIOS", sqla.DBDT.Rows(0).Item(0))
                    End If
                End If
                Me.CrystalReportViewer1.ReportSource = rptdoc


            End If


            '===============================================================================================================================

            If imprimir = "InformeM" Then


            Dim iventas As CrystalDecisions.CrystalReports.Engine.ReportDocument
            iventas = New InformeMensual

            Dim td As New DataTable
            With td
                .Columns.Add("Mes")
                .Columns.Add("Mes1")
                .Columns.Add("fecha")
                .Columns.Add("OT")
                .Columns.Add("Cantidad")
                .Columns.Add("Precio")
                .Columns.Add("MedioPago")
                .Columns.Add("Costo")
                .Columns.Add("Categoria")
                .Columns.Add("Neto", GetType(Decimal))
                .Columns.Add("IVA", GetType(Decimal))
                .Columns.Add("Total", GetType(Decimal))
                .Columns.Add("Beneficio", GetType(Decimal))
                .Columns.Add("Margen", GetType(Decimal))
            End With
            td.Columns("OT").DataType = GetType(String)
            'td.Columns("Neto").DataType = GetType(Double)
            td.Columns("Costo").DataType = GetType(Decimal)
            'td.Columns("Beneficio").DataType = GetType(Double)
            'td.Columns("Margen").DataType = GetType(Double)
            'td.Columns("Total").DataType = GetType(Double)

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("               
                declare @fechactual date;
                select @fechactual =  DATEFROMPARTS(@Ano,@Mes,1);
                declare @mes1 int;
                declare @año1 int;
                declare @mes2 int;
                declare @año2 int;
                declare @mes3 int;
                declare @año3 int;
                declare @mes4 int;
                declare @año4 int;
                
                select @mes1 = DATEPART(MONTH,DATEADD(MONTH, -1, @fechactual));
                select @año1 = DATEPART(YEAR,DATEADD(MONTH, -1, @fechactual));
                select @mes2 = DATEPART(MONTH,DATEADD(MONTH, -2, @fechactual));
                select @año2 = DATEPART(YEAR,DATEADD(MONTH, -2, @fechactual));
                select @mes3 = DATEPART(MONTH,DATEADD(MONTH, -3, @fechactual));
                select @año3 = DATEPART(YEAR,DATEADD(MONTH, -3, @fechactual));
                select @mes4 = DATEPART(MONTH,DATEADD(MONTH, -4, @fechactual));
                select @año4 = DATEPART(YEAR,DATEADD(MONTH, -4, @fechactual));
                
                
                
                
                SELECT distinct case  when datepart(month,  fecha) = '1' 
                            then 'Enero'
                            when datepart(month,  fecha) = '2' 
                            then 'Febrero'
                            when datepart(month,  fecha) = '3' 
                            then 'Marzo'
                            when datepart(month,  fecha) = '4' 
                            then 'Abril'
                            when datepart(month,  fecha) = '5' 
                            then 'Mayo'
                            when datepart(month,  fecha) = '6' 
                            then 'Junio'
                            when datepart(month,  fecha) = '7' 
                            then 'Julio'
                            when datepart(month,  fecha) = '8' 
                            then 'Agosto'
                            when datepart(month,  fecha) = '9' 
                            then 'Septiembre'
                            when datepart(month,  fecha) = '10' 
                            then 'Octubre'
                            when datepart(month,  fecha) = '11' 
                            then 'Noviembre'
                            when datepart(month,  fecha) = '12' 
                            then 'Diciembre'
                              end as Mes, datepart(month,  fecha) Mes1,fecha,
                             Ventas.OT, CAST(Ventas.Cantidad as Float) Cantidad,  Cast(Ventas.PVenta AS float) Precio, Ventas.MedioPago, ([dbo].[Costo]     ([IDVenta]))     Costo,   Inventario.Categoria
                               FROM Ventas INNER JOIN  Inventario ON Ventas.CodItem = Inventario.ID
                            WHERE Ventas.PVenta > 0 and ( ( DATEPART(MONTH,Fecha) = @Mes AND DATEPART(YEAR,Fecha) = @Ano) or ( DATEPART (MONTH,Fecha) =    @mes1    AND DATEPART(YEAR,Fecha) = @año1)
                			 or ( DATEPART(MONTH,Fecha) = @mes2 AND DATEPART(YEAR,Fecha) = @año2) or ( DATEPART(MONTH,Fecha) = @mes3 AND DATEPART(YEAR,Fecha)   =     @año3)   or   ( DATEPART(MONTH,Fecha) = @mes4 AND DATEPART(YEAR,Fecha) = @año4))
                            order by  fecha asc")




            For Each dr As DataRow In sqla.DBDT.Rows
                td.Rows.Add()
                td.Rows(td.Rows.Count - 1).Item(0) = dr.Item(0)
                td.Rows(td.Rows.Count - 1).Item(1) = dr.Item(1)
                td.Rows(td.Rows.Count - 1).Item(2) = dr.Item(2)
                td.Rows(td.Rows.Count - 1).Item(3) = dr.Item(3)
                td.Rows(td.Rows.Count - 1).Item(4) = dr.Item(4)
                td.Rows(td.Rows.Count - 1).Item(5) = dr.Item(5)
                td.Rows(td.Rows.Count - 1).Item(6) = dr.Item(6)
                If IsDBNull(dr.Item(7)) Then
                    td.Rows(td.Rows.Count - 1).Item(7) = 0
                Else
                    td.Rows(td.Rows.Count - 1).Item(7) = dr.Item(7)
                End If
                td.Rows(td.Rows.Count - 1).Item(8) = dr.Item(8)
                td.Rows(td.Rows.Count - 1).Item(9) = td.Rows(td.Rows.Count - 1).Item(4) * td.Rows(td.Rows.Count - 1).Item(5)
                td.Rows(td.Rows.Count - 1).Item(10) = td.Rows(td.Rows.Count - 1).Item(4) * td.Rows(td.Rows.Count - 1).Item(5) * 0.19
                td.Rows(td.Rows.Count - 1).Item(11) = td.Rows(td.Rows.Count - 1).Item(4) * td.Rows(td.Rows.Count - 1).Item(5) * 1.19
                td.Rows(td.Rows.Count - 1).Item(12) = td.Rows(td.Rows.Count - 1).Item(9) - td.Rows(td.Rows.Count - 1).Item(7)
                td.Rows(td.Rows.Count - 1).Item(9) = (td.Rows(td.Rows.Count - 1).Item(9) - td.Rows(td.Rows.Count - 1).Item(7)) / td.Rows(td.Rows.Count - 1).Item(9)
            Next

            iventas.Database.Tables("Datatable3_1").SetDataSource(td)

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Año", Informe.ComboBox2.Text)
            sqla.execquery("Select Registro.Mecanico ,sum(cantidad*PVenta) + [dbo].[VentaMecanico] (Registro.Mecanico, @Mes, @Año)   Total from ventas inner join Registro on Ventas.OT = Registro.OT where DATEPART(MONTH,Ventas.Fecha) = @Mes and DATEPART(YEAR, Ventas.Fecha) = @Año and Registro.Mecanico <> '-Seleccionar-' group by Registro.Mecanico")
            iventas.Database.Tables(2).SetDataSource(sqla.DBDT)

            'iventas.SetDataSource(sqla.DBDT)
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select sum(total), sum(IVA), sum(Neto), count(distinct ot), sum(([dbo].[Costo]([IDVenta]))) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Total", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Total", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("IVA", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("IVA", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(2)) = False Then
                iventas.SetParameterValue("Neto", sqla.DBDT.Rows(0).Item(2))
            Else

                iventas.SetParameterValue("Neto", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(3)) = False Then
                iventas.SetParameterValue("Cantidad", sqla.DBDT.Rows(0).Item(3))
            Else

                iventas.SetParameterValue("Cantidad", 0)
            End If

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select sum([dbo].[Costo]([IDVenta])) from Ventas INNER Join Inventario On Ventas.CodItem = Inventario.ID  where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and Categoria <> 'Servicios'")
            Dim costo1 As Decimal
            Dim costo2 As Decimal

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                costo1 = sqla.DBDT.Rows(0).Item(0)

                sqla.Addparam("@Mes", Informe.ComboBox1.Text)
                sqla.Addparam("@Ano", Informe.ComboBox2.Text)
                sqla.execquery("select case when Sum(subtotal) is null then 0 else SUM(subtotal)end as Costo from compras where OT = 'Sin OT' and datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano")
                costo2 = sqla.DBDT.Rows(0).Item(0)
                iventas.SetParameterValue("Costo", costo1 + costo2)

            Else

                iventas.SetParameterValue("Costo", 0)
            End If




            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)



            sqla.execquery("declare @costosinot decimal;
                            select @costosinot = case when Sum(subtotal) is null then 0 else SUM(subtotal)end from compras where OT = 'Sin OT' and datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano


                            select sum(neto)-(sum(([dbo].[Costo]([IDVenta]))) + @costosinot) Beneficio, format( (sum(neto)-(sum(([dbo].[Costo]([IDVenta]))))+@costosinot)/sum(neto), 'p0')  from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0")

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Bene", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Bene", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("Porcbene", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("Porcbene", 0)
            End If





            'resumen ventas
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'Efectivo' and datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 ")
            iventas.SetParameterValue("Efectivo", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'T. Débito' and datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 ")
            iventas.SetParameterValue("debito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select SUM(Total) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'Efectivo' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TEfectivo", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TEfectivo", 0)
            End If

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select SUM(Total) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'T. Débito' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TDebito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TDebito", 0)
            End If
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select count (distinct OT) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'T. Crédito' ")

            iventas.SetParameterValue("Tcredito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select SUM(Total) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'T. Crédito' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TTcredito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TTcredito", 0)
            End If
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select count (distinct OT) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'CRÉDITO' ")
            iventas.SetParameterValue("credito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("select SUM(Total) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'CRÉDITO' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("creditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("creditot", 0)
            End If




            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("select count (distinct OT) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'TRANSFERENCIA' ")
            iventas.SetParameterValue("Trans", sqla.DBDT.Rows(0).Item(0))




            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("select SUM(Total) from Ventas where datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and Neto > 0 and MedioPago = 'TRANSFERENCIA' ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TransT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TransT", 0)
            End If

















            'compras
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano AND FPago = 'Efectivo'")
            iventas.SetParameterValue("CEfectivo", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("Select sum(Total) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano And FPago = 'Efectivo'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CEfectivoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CEfectivoT", 0)
            End If
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano AND (FPago = 'T. Débito' or FPago = 'CUENTA CORRIENTE')")
            iventas.SetParameterValue("Cdebito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("Select sum(Total) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and (FPago = 'T. Débito' or FPago = 'CUENTA CORRIENTE')")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CdebitoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CdebitoT", 0)
            End If

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano AND FPago = 'T. Crédito'")
            iventas.SetParameterValue("CTCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("Select sum(Total) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and FPago = 'T. Crédito'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CTCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CTCreditoT", 0)
            End If
            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano AND FPago = 'Crédito'")
            iventas.SetParameterValue("CCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("Select sum(Total) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and  FPago = 'Crédito'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CCreditoT", 0)
            End If















            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)


            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano AND FPago = 'Cheque'")
            iventas.SetParameterValue("CCheque", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)

            sqla.execquery("Select sum(Total) FROM Compras WHERE datepart(mm, Fecha) = @Mes and datepart(yy, Fecha) = @Ano and FPago = 'Cheque'")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CChequeT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CChequeT", 0)
            End If


            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)



            sqla.execquery("select Acumulado from Caja where ID = (select max(id) from Caja) ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Caja", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("Caja", 0)
            End If


            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)
            sqla.Addparam("@finicial", Informe.ComboBox2.Text + "-" + Informe.ComboBox1.Text + "-01")
            sqla.Addparam("@ffinal", Informe.ComboBox2.Text + "-" + Informe.ComboBox1.Text + "-" + System.DateTime.DaysInMonth(Informe.ComboBox2.Text, Informe.ComboBox1.Text).ToString)
            sqla.Addparam("@Feriado", InputBox("Ingrese cantidad de feriados en el mes", "Feriados"))
            Dim final As Date = Informe.ComboBox2.Text + "-" + Informe.ComboBox1.Text + "-" + System.DateTime.DaysInMonth(Informe.ComboBox2.Text, Informe.ComboBox1.Text).ToString
            If DateDiff(DateInterval.Day, DateTime.Today, final) <= 0 Then
                sqla.execquery("declare @startdate datetime2 = @finicial
            declare @enddate datetime2 = @ffinal
            declare @dias float = ( SELECT DATEDIFF(day, @startdate, @enddate))
            declare @findes float = (select DATEDIFF(wk, @startdate, @enddate))
            declare @diast float = @dias - @findes*1.5 - @Feriado

            select COUNT(distinct ot)/@diast from Ventas where DATEPART(MM,Fecha) = @Mes and DATEPART(yy,Fecha) = @Ano")

                iventas.SetParameterValue("Promediodiario", sqla.DBDT.Rows(0).Item(0))

            Else
                sqla.execquery("declare @startdate datetime2 = @finicial
            declare @enddate datetime2 = getdate()
            declare @dias float = ( SELECT DATEDIFF(day, @startdate, @enddate))
            declare @findes float = (select DATEDIFF(wk, @startdate, @enddate))
            declare @diast float = @dias - @findes*1.5 - @Feriado

            select COUNT(distinct ot)/@diast from Ventas where DATEPART(MM,Fecha) = @Mes and DATEPART(yy,Fecha) = @Ano")

                iventas.SetParameterValue("Promediodiario", sqla.DBDT.Rows(0).Item(0))


            End If

            sqla.Addparam("@Mes", Informe.ComboBox1.Text)
            sqla.Addparam("@Ano", Informe.ComboBox2.Text)
            sqla.Addparam("@finicial", Informe.ComboBox2.Text + "-" + Informe.ComboBox1.Text + "-01")
            sqla.Addparam("@ffinal", Informe.ComboBox2.Text + "-" + Informe.ComboBox1.Text + "-" + System.DateTime.DaysInMonth(Informe.ComboBox2.Text, Informe.ComboBox1.Text).ToString)


            sqla.execquery("declare @startdate datetime2 = @finicial
            declare @enddate datetime2 = @ffinal
            declare @dias float = ( SELECT DATEDIFF(day, @startdate, @enddate))
            declare @findes float = (select DATEDIFF(wk, @startdate, @enddate))
            declare @diast float = @dias - @findes-2

            select sum(ventas.neto)/@diast from Ventas where DATEPART(MM,Fecha) = @Mes and DATEPART(yy,Fecha) = @Ano")

            iventas.SetParameterValue("Vendidodia", sqla.DBDT.Rows(0).Item(0))
            iventas.SetParameterValue("Nombre", "Informe Mensual")


            If Informe.ComboBox1.Text = "1" Then
                iventas.SetParameterValue("Fecha", "Enero " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "2" Then
                iventas.SetParameterValue("Fecha", "Febrero " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "3" Then
                iventas.SetParameterValue("Fecha", "Marzo " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "4" Then
                iventas.SetParameterValue("Fecha", "Abril " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "5" Then
                iventas.SetParameterValue("Fecha", "Mayo " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "6" Then
                iventas.SetParameterValue("Fecha", "Junio " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "7" Then
                iventas.SetParameterValue("Fecha", "Julio " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "8" Then
                iventas.SetParameterValue("Fecha", "Agosto  " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "9" Then
                iventas.SetParameterValue("Fecha", "Septiembre " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "10" Then
                iventas.SetParameterValue("Fecha", "Octubre " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "11" Then
                iventas.SetParameterValue("Fecha", "Noviembre " + Informe.ComboBox2.Text)
            ElseIf Informe.ComboBox1.Text = "12" Then
                iventas.SetParameterValue("Fecha", "Diciembre " + Informe.ComboBox2.Text)
            End If


            sqla.execquery("Select Inventario.Categoria, Sum(Inventario.PCompra * Inventario.STOCK) Valor from Inventario 
                            where Categoria <> 'SERVICIOS' and Categoria <> 'DESCUENTOS' AND Categoria <> 'Neumáticos' AND Categoria <>  'LUBRICANTES FUERA DEL INVENTARIO'
                            group By Categoria;")

            iventas.SetParameterValue("Ampolletas", sqla.DBDT.Rows(0).Item(1))
            iventas.SetParameterValue("FiltrosAceite", sqla.DBDT.Rows(1).Item(1))
            iventas.SetParameterValue("FiltrosAire", sqla.DBDT.Rows(2).Item(1))
            iventas.SetParameterValue("FiltrosCombustible", sqla.DBDT.Rows(3).Item(1))
            iventas.SetParameterValue("FiltrosPolen", sqla.DBDT.Rows(4).Item(1))
            iventas.SetParameterValue("Lubricantes", sqla.DBDT.Rows(5).Item(1))
            iventas.SetParameterValue("Neumaticos", sqla.DBDT.Rows(6).Item(1))
            iventas.SetParameterValue("Otros", sqla.DBDT.Rows(7).Item(1))
            iventas.SetParameterValue("Plumillas", sqla.DBDT.Rows(8).Item(1))
            iventas.SetParameterValue("Repuestos", sqla.DBDT.Rows(9).Item(1))
            iventas.SetParameterValue("Vulcanizacion", sqla.DBDT.Rows(10).Item(1))



            'Dim dav As Integer = 0
            'Dim jos As Integer = 0
            'Dim vic As Integer = 0
            'Dim ort As Integer = 0
            'For Each fila As DataRow In sqla.DBDT.Rows
            '    If fila.Item(0) = "DAVID NOURDIN ESTAY" Then
            '        iventas.SetParameterValue("David", fila.Item(1))
            '        dav = 1
            '    ElseIf fila.Item(0) = "JOSEPH RODRÍGUEZ" Then
            '        iventas.SetParameterValue("Joseph", fila.Item(1))
            '        jos = 1
            '    ElseIf fila.Item(0) = "VICTOR LAGOS BRIONES" Then
            '        iventas.SetParameterValue("Victor", fila.Item(1))
            '        vic = 1
            '    ElseIf fila.Item(0) = "JOSE SAMUEL  ORTEGA MUÑOZ" Then
            '        iventas.SetParameterValue("Ortega", fila.Item(1))
            '        ort = 1
            '    End If
            'Next
            'If dav = 0 Then
            '    iventas.SetParameterValue("David", 0)
            'End If
            'If jos = 0 Then
            '    iventas.SetParameterValue("Joseph", 0)
            'End If
            'If vic = 0 Then
            '    iventas.SetParameterValue("Victor", 0)
            'End If
            'If ort = 0 Then
            '    iventas.SetParameterValue("Ortega", 0)
            'End If
            Me.CrystalReportViewer1.ReportSource = iventas



        End If

        '==================================================================================================================================

        If imprimir = "InformeS" Then


            Dim iventas As CrystalDecisions.CrystalReports.Engine.ReportDocument
            iventas = New InformeMensual

            Dim td As New DataTable
            With td
                .Columns.Add("OT")
                .Columns.Add("Neto")
                .Columns.Add("IVA")
                .Columns.Add("Total")
                .Columns.Add("MedioPago")
                .Columns.Add("Costo")
                .Columns.Add("Categoria")
                .Columns.Add("Beneficio")
                .Columns.Add("Margen")
            End With
            td.Columns("OT").DataType = GetType(String)
            td.Columns("Neto").DataType = GetType(Double)
            td.Columns("Costo").DataType = GetType(Double)
            td.Columns("Beneficio").DataType = GetType(Double)
            td.Columns("Margen").DataType = GetType(Double)

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)

            sqla.execquery("select ventas.OT, cast(ventas.Neto as float) Neto, ventas.IVA, ventas.Total,Ventas.MedioPago, ([dbo].[Costo]([IDVenta])),  Inventario.Categoria, Ventas.Neto-([dbo].[Costo]([IDVenta])) Beneficio,  ((Ventas.Neto-([dbo].[Costo]([IDVenta])))/ventas.Neto)*100 Margen from Ventas INNER Join Inventario On Ventas.CodItem = Inventario.ID where  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and DATEPART (YEAR , [Fecha]) = @Ano ")




            For Each dr As DataRow In sqla.DBDT.Rows
                td.Rows.Add(dr.ItemArray)
            Next


            iventas.Database.Tables("Datatable3_1").SetDataSource(td)

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Año", Semana.vsemana.Year)
            sqla.execquery("Select Personal.Nombre + ' ' + Personal.Apellido Mecanico, dbo.VentaMecanicoSemana(Personal.Nombre + ' ' + Personal.Apellido,datepart(week,@Semana),@Año) Total
                from Personal where Personal.Especialidad = 'MECÁNICO AUTOMOTRIZ'")

            iventas.Database.Tables(2).SetDataSource(sqla.DBDT)





            'iventas.SetDataSource(sqla.DBDT)
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select sum(total), sum(IVA), sum(Neto), count(distinct ot), sum(([dbo].[Costo]([IDVenta]))) from Ventas where  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and neto > 0 and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Total", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Total", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("IVA", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("IVA", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(2)) = False Then
                iventas.SetParameterValue("Neto", sqla.DBDT.Rows(0).Item(2))
            Else

                iventas.SetParameterValue("Neto", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(3)) = False Then
                iventas.SetParameterValue("Cantidad", sqla.DBDT.Rows(0).Item(3))
            Else

                iventas.SetParameterValue("Cantidad", 0)
            End If

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select sum(([dbo].[Costo]([IDVenta]))) from Ventas INNER Join Inventario On Ventas.CodItem = Inventario.ID  where  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and Categoria <> 'Servicios' and DATEPART (YEAR , [Fecha]) = @Ano")


            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Costo", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Costo", 0)
            End If




            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)


            sqla.execquery("select sum(neto)-sum(([dbo].[Costo]([IDVenta]))) Beneficio, format( (sum(neto)-sum(([dbo].[Costo]([IDVenta]))))/sum(neto), 'p0')  from Ventas where  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and DATEPART (YEAR , [Fecha]) = @Ano")

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Bene", sqla.DBDT.Rows(0).Item(0))
            Else

                iventas.SetParameterValue("Bene", 0)
            End If

            If IsDBNull(sqla.DBDT.Rows(0).Item(1)) = False Then
                iventas.SetParameterValue("Porcbene", sqla.DBDT.Rows(0).Item(1))
            Else

                iventas.SetParameterValue("Porcbene", 0)
            End If





            'resumen ventas
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'Efectivo' and  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and DATEPART (YEAR , [Fecha]) = @Ano ")
            iventas.SetParameterValue("Efectivo", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select count (distinct OT) from Ventas where ventas.MedioPago = 'T. Débito' and DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and DATEPART (YEAR , [Fecha]) = @Ano ")
            iventas.SetParameterValue("debito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'Efectivo' and DATEPART (YEAR , [Fecha]) = @Ano ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TEfectivo", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TEfectivo", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'T. Débito' and DATEPART (YEAR , [Fecha]) = @Ano ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TDebito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TDebito", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select count (distinct OT) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'T. Crédito' and DATEPART (YEAR , [Fecha]) = @Ano ")

            iventas.SetParameterValue("Tcredito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select SUM(Total) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'T. Crédito' and DATEPART (YEAR , [Fecha]) = @Ano ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TTcredito", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TTcredito", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select count (distinct OT) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'CRÉDITO' and DATEPART (YEAR , [Fecha]) = @Ano ")
            iventas.SetParameterValue("credito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)

            sqla.execquery("select SUM(Total) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'CRÉDITO' and DATEPART (YEAR , [Fecha]) = @Ano ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("creditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("creditot", 0)
            End If

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)
            sqla.execquery("select count (distinct OT) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'TRANSFERENCIA' and DATEPART (YEAR , [Fecha]) = @Ano ")
            iventas.SetParameterValue("Trans", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("Ano", Semana.vsemana.Year)

            sqla.execquery("select SUM(Total) from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and Neto > 0 and MedioPago = 'TRANSFERENCIA' and DATEPART (YEAR , [Fecha]) = @Ano ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("TransT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("TransT", 0)
            End If









            'compras
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) AND FPago = 'Efectivo' and DATEPART (YEAR , [Fecha]) = @Ano")
            iventas.SetParameterValue("CEfectivo", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) And FPago = 'Efectivo' and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CEfectivoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CEfectivoT", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) AND FPago = 'T. Débito' and DATEPART (YEAR , [Fecha]) = @Ano")
            iventas.SetParameterValue("Cdebito", sqla.DBDT.Rows(0).Item(0))
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and FPago = 'T. Débito' and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CdebitoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CdebitoT", 0)
            End If

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) AND FPago = 'T. Crédito' and DATEPART (YEAR , [Fecha]) = @Ano")
            iventas.SetParameterValue("CTCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and FPago = 'T. Crédito' and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CTCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CTCreditoT", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) AND FPago = 'Crédito' and DATEPART (YEAR , [Fecha]) = @Ano")
            iventas.SetParameterValue("CCredito", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and  FPago = 'Crédito' and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CCreditoT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CCreditoT", 0)
            End If

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("SELECT  COUNT(DISTINCT FACTURA) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) AND FPago = 'Cheque' and DATEPART (YEAR , [Fecha]) = @Ano")
            iventas.SetParameterValue("CCheque", sqla.DBDT.Rows(0).Item(0))

            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("Select sum(Total) FROM Compras WHERE DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and FPago = 'Cheque' and DATEPART (YEAR , [Fecha]) = @Ano")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("CChequeT", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("CChequeT", 0)
            End If
            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("select Acumulado from Caja where ID = (select max(id) from Caja) ")
            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                iventas.SetParameterValue("Caja", sqla.DBDT.Rows(0).Item(0))
            Else
                iventas.SetParameterValue("Caja", 0)
            End If


            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@finicial", Semana.vsemana)
            sqla.Addparam("@ffinal", Semana.vsemana.AddDays(6))
            sqla.Addparam("@Ano", Semana.vsemana.Year)

            sqla.execquery("declare @startdate datetime2 = @finicial
            declare @enddate datetime2 = @ffinal
            declare @dias float = ( SELECT DATEDIFF(day, @startdate, @enddate))
            declare @findes float = (select DATEDIFF(wk, @startdate, @enddate))
            declare @diast float = @dias - @findes

            select COUNT(distinct ot)/@dias from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and DATEPART (YEAR , [Fecha]) = @Ano")

            iventas.SetParameterValue("Promediodiario", sqla.DBDT.Rows(0).Item(0))



            sqla.Addparam("@Semana", Semana.vsemana)
            sqla.Addparam("@finicial", Semana.vsemana)
            sqla.Addparam("@ffinal", Semana.vsemana.AddDays(6))
            sqla.Addparam("@Ano", Semana.vsemana.Year)
            sqla.execquery("declare @startdate datetime2 = @finicial
            declare @enddate datetime2 = @ffinal
            declare @dias float = ( SELECT DATEDIFF(day, @startdate, @enddate))
            declare @findes float = (select DATEDIFF(wk, @startdate, @enddate))
            declare @diast float = @dias - @findes

            select sum(ventas.neto)/@diast from Ventas where DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and DATEPART (YEAR , [Fecha]) = @Ano")

            iventas.SetParameterValue("Vendidodia", sqla.DBDT.Rows(0).Item(0))
            iventas.SetParameterValue("Nombre", "Informe Semanal")
            iventas.SetParameterValue("Fecha", Semana.vsemana)



            sqla.execquery("Select Inventario.Categoria, Sum(Inventario.PCompra * Inventario.STOCK) Valor from Inventario 
                            where Categoria <> 'SERVICIOS' and Categoria <> 'DESCUENTOS' AND Categoria <> 'Neumáticos' AND Categoria <>  'LUBRICANTES FUERA DEL INVENTARIO'
                            group By Categoria;")

            iventas.SetParameterValue("Ampolletas", sqla.DBDT.Rows(0).Item(1))
            iventas.SetParameterValue("FiltrosAceite", sqla.DBDT.Rows(1).Item(1))
            iventas.SetParameterValue("FiltrosAire", sqla.DBDT.Rows(2).Item(1))
            iventas.SetParameterValue("FiltrosCombustible", sqla.DBDT.Rows(3).Item(1))
            iventas.SetParameterValue("FiltrosPolen", sqla.DBDT.Rows(4).Item(1))
            iventas.SetParameterValue("Lubricantes", sqla.DBDT.Rows(5).Item(1))
            iventas.SetParameterValue("Neumaticos", sqla.DBDT.Rows(6).Item(1))
            iventas.SetParameterValue("Otros", sqla.DBDT.Rows(7).Item(1))
            iventas.SetParameterValue("Plumillas", sqla.DBDT.Rows(8).Item(1))
            iventas.SetParameterValue("Repuestos", sqla.DBDT.Rows(9).Item(1))
            iventas.SetParameterValue("Vulcanizacion", sqla.DBDT.Rows(10).Item(1))

















            'Dim dav As Integer = 0
            'Dim jos As Integer = 0
            'Dim vic As Integer = 0
            'Dim ort As Integer = 0
            'For Each fila As DataRow In sqla.DBDT.Rows
            '    If fila.Item(0) = "DAVID NOURDIN ESTAY" Then
            '        iventas.SetParameterValue("David", fila.Item(1))
            '        dav = 1
            '    ElseIf fila.Item(0) = "JOSEPH RODRÍGUEZ" Then
            '        iventas.SetParameterValue("Joseph", fila.Item(1))
            '        jos = 1
            '    ElseIf fila.Item(0) = "VICTOR LAGOS BRIONES" Then
            '        iventas.SetParameterValue("Victor", fila.Item(1))
            '        vic = 1
            '    ElseIf fila.Item(0) = "JOSE SAMUEL ORTEGA MUÑOZ" Then
            '        iventas.SetParameterValue("Ortega", fila.Item(1))
            '        ort = 1
            '    End If
            'Next
            'If dav = 0 Then
            '    iventas.SetParameterValue("David", 0)
            'End If
            'If jos = 0 Then
            '    iventas.SetParameterValue("Joseph", 0)
            'End If
            'If vic = 0 Then
            '    iventas.SetParameterValue("Victor", 0)
            'End If
            'If ort = 0 Then
            '    iventas.SetParameterValue("Ortega", 0)
            'End If

            Me.CrystalReportViewer1.ReportSource = iventas

        End If

        If imprimir = "OT" Then

            Dim orden As CrystalDecisions.CrystalReports.Engine.ReportDocument
            orden = New OrdenIngreso

            Dim dtot As New DataTable
            With dtot.Columns
                .Add("Cantidad")
                .Add("Item")
            End With
            dtot.Columns("Cantidad").DataType = GetType(Integer)
            dtot.Columns("Item").DataType = GetType(String)

            sqla.Addparam("@COT", Ingreso.TextBox6.Text)
            sqla.execquery("Select Cantidad, Item from Cotizaciones where Cotizacion = @COT and CodItem <> '20201010'")

            For Each dr As DataRow In sqla.DBDT.Rows
                dtot.Rows.Add(dr.ItemArray)
            Next

            orden.SetDataSource(sqla.DBDT)

            orden.SetParameterValue("OrdenPar", Ingreso.TextBox2.Text)
            orden.SetParameterValue("ClientePar", Ingreso.TextBox1.Text)
            orden.SetParameterValue("PATENTE", Ingreso.ComboBox2.Text)
            orden.SetParameterValue("KILOMETRAJE", Ingreso.TextBox5.Text)

            orden.SetParameterValue("detalles", Ingreso.TextBox7.Text)
            orden.SetParameterValue("FECHA", DateTime.Today)

            orden.SetParameterValue("Vehiculo", Ingreso.TextBox4.Text)


            Me.CrystalReportViewer1.ReportSource = orden


        End If



        If imprimir = "Trabajos" Then

            Dim trabajosencurso As CrystalDecisions.CrystalReports.Engine.ReportDocument
            trabajosencurso = New TrabajosDetalle

            Dim tabla As New DataTable
            With tabla.Columns
                .Add("OT", GetType(Integer))
                .Add("CLIENTE", GetType(String))
                .Add("PATENTE", GetType(String))
                .Add("MARCA/MODELO", GetType(String))
                .Add("ENTRADA", GetType(DateTime))
                .Add("DETALLES", GetType(String))
                .Add("OBSERVACIONES", GetType(String))
            End With

            sqla.execquery("Select  Registro.OT, Clientes.Nombre + ' ' + Clientes.Apellido Cliente, Registro.Patente, Registro.Vehiculo, Registro.Entrada, Registro.Detalles, (case when registro.observaciones is null then '0' else registro.observaciones end) AS OBSERVACIONES from Registro inner join Clientes on Registro.IDCliente = Clientes.ID where Registro.Salida is null")

            For Each dr As DataRow In sqla.DBDT.Rows
                tabla.Rows.Add(dr.ItemArray)
            Next


            trabajosencurso.SetDataSource(sqla.DBDT)
            Me.CrystalReportViewer1.ReportSource = trabajosencurso
        End If
    End Sub

End Class