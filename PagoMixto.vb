Imports System.Data
Public Class PagoMixto
    Public sqla As New Sqlcontrol
    Private Sub PagoMixto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim valor As Double
        If esrapida = "No" Then
            valor = PuntoVenta.TextBox8.Text
        Else
            valor = VentaRapida.TextBox4.Text
        End If
        TextBox1.Text = valor.ToString("$#,##0")
        DataGridView1.Columns(2).ValueType = GetType(System.Double)
        DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
    End Sub
    Private Sub DataGridView1_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValidated
        Dim sum As Double
        For Each fila As DataGridViewRow In DataGridView1.Rows
            sum = sum + fila.Cells(2).Value
        Next
        TextBox2.Text = sum.ToString("$#,##0")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim porcion As Decimal
        Dim codigo As String
        Dim precio As Double
        Dim idventa As Integer
        Dim numero As Integer
        If esrapida = "Rapida" Then
            For Each row In VentaRapida.DGVDetalle.Rows
                sqla.Addparam("@Cod", row.Cells(0).Value)
                sqla.Addparam("@Cantidad", CDec(row.Cells(2).Value))
                sqla.execquery("Update Inventario Set STOCK = STOCK - @Cantidad where ID = @Cod")
            Next
        End If
        For Each fila As DataGridViewRow In DataGridView1.Rows
            porcion = fila.Cells(2).Value / CDbl(TextBox2.Text)

            If esrapida = "Rapida" Then

                With VentaRapida
                    For Each item As DataGridViewRow In .DGVDetalle.Rows

                        codigo = item.Cells(0).Value
                        sqla.Addparam("@OT", .Ordenbox.Text)
                        sqla.Addparam("@MPago", fila.Cells(0).Value)
                        sqla.Addparam("@Recibo", fila.Cells(1).Value)
                        sqla.Addparam("@Factura", .facturaTextBox.Text)
                        sqla.Addparam("@fecha", Date.Today)
                        sqla.Addparam("@Cod", codigo)
                        sqla.Addparam("@Cantidad", CDec(item.Cells(2).Value))
                        precio = item.Cells(3).Value * porcion
                        sqla.Addparam("@Preciov", precio)
                        sqla.Addparam("@Item", item.Cells(1).Value)
                        sqla.Addparam("@Mecanico", VentaRapida.ComboBox1.Text)
                        sqla.execquery("Insert into Ventas (OT, Fecha, CodItem, Item, Cantidad, PVenta, MedioPago, Voucher, Factura, Pago, Mecanico) Values (@OT, @fecha,@Cod, @Item,@Cantidad, @Preciov, @MPAgo, @Recibo, @Factura, 'MIXTO', @Mecanico); ")

                        If sqla.Masexception(True) Then Exit Sub


                        'Costos
                        '==============================================================================================================

                        If codigo <> "20201" And codigo <> "20202" And codigo <> "20203" And codigo <> "20204" And codigo <> "20205" And codigo <> "20206" And codigo <> "20207" And codigo <> "20208" Then

                            sqla.Addparam("@Item", item.Cells(0).Value)
                            sqla.execquery("Select PCompra from Inventario Where ID = @Item ")
                            precio = sqla.DBDT.Rows(0).Item(0) * porcion
                            sqla.execquery("Select IDVenta from ventas where IDVenta = (Select max(idventa) from ventas)")
                            idventa = sqla.DBDT.Rows(0).Item(0)
                            With sqla
                                .Addparam("@Nombre", item.Cells(1).Value)
                                .Addparam("@Cod", codigo)
                                .Addparam("@Cantidad", CDec(item.Cells(2).Value))
                                .Addparam("@Precio", precio)
                                .Addparam("@IDVenta", idventa)
                            End With

                            sqla.execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                            If sqla.Masexception(True) Then Exit Sub
                        End If



                    Next
                End With

                'actualización caja
                '==============================================================================================================
                If fila.Cells(0).Value = "EFECTIVO" Then

                    sqla.execquery("Select    * FROM    Caja  WHERE ID = (SELECT  MAX(ID)  FROM  Caja)")

                    'acumulado = CDbl(sqla.DBDT.Rows(0).Item(5))
                    numero = CDbl(sqla.DBDT.Rows(0).Item(0)) + 1
                    'Dim nuevoacumulado As Double = acumulado + TextBox8.Text

                    sqla.Addparam("@Numero", numero)
                    sqla.Addparam("@Fecha", DateTime.Now)
                    sqla.Addparam("@Responsable", VentaRapida.Ordenbox.Text)
                    sqla.Addparam("@Monto", CDbl(fila.Cells(2).Value))
                    'sqla.Addparam("@Acumulado", nuevoacumulado)
                    sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, 'Venta'); ")
                    If sqla.Masexception(True) Then Exit Sub
                End If




            Else
                With PuntoVenta
                    For Each item As DataGridViewRow In .DataGridView1.Rows

                        sqla.Addparam("@Cot", .CotTextBox2.Text)
                        sqla.Addparam("@Item", item.Cells(0).Value)
                        sqla.execquery("Select Cotizaciones.CodItem, Inventario.PCompra from Cotizaciones inner Join Inventario on Cotizaciones.CodItem = Inventario.ID Where Cotizaciones.Item = @Item and Cotizaciones.Cotizacion = @Cot")
                        codigo = sqla.DBDT.Rows(0).Item(0)

                        sqla.Addparam("@OT", .OrdTextBox.Text)
                        sqla.Addparam("@MPago", fila.Cells(0).Value)
                        sqla.Addparam("@Recibo", fila.Cells(1).Value)
                        sqla.Addparam("@Cliente", .ClienteTextBox.Text)
                        sqla.Addparam("@Automovil", .VehiculoTextBox.Text)
                        sqla.Addparam("@Factura", .facturaTextBox.Text)
                        sqla.Addparam("@fecha", Date.Today)
                        sqla.Addparam("@Cod", codigo)
                        sqla.Addparam("@Cantidad", CDec(item.Cells(1).Value))
                        precio = item.Cells(2).Value * porcion
                        sqla.Addparam("@Preciov", precio)
                        sqla.Addparam("@Item", item.Cells(0).Value)

                        sqla.execquery("Insert into Ventas (OT, Fecha, CodItem, Item, Cantidad, PVenta, MedioPago, Voucher, Cliente, Automovil, Factura, Pago) Values (@OT, @fecha,@Cod, @Item,@Cantidad, @Preciov, @MPAgo, @Recibo, @Cliente, @Automovil, @Factura, 'MIXTO'); ")

                        If sqla.Masexception(True) Then Exit Sub

                        'Costos
                        '==============================================================================================================

                        sqla.Addparam("@Cot", .CotTextBox2.Text)
                        sqla.Addparam("@Item", item.Cells(0).Value)
                        sqla.execquery("Select CodItem from Cotizaciones Where Item = @Item and Cotizacion = @Cot")

                        If codigo <> "20201" And codigo <> "20202" And codigo <> "20203" And codigo <> "20204" And codigo <> "20205" And codigo <> "20206" And codigo <> "20207" And codigo <> "20208" Then
                            sqla.Addparam("@Cot", .CotTextBox2.Text)
                            sqla.Addparam("@Item", item.Cells(0).Value)
                            sqla.execquery("Select Cotizaciones.CodItem, Inventario.PCompra from Cotizaciones inner Join Inventario on Cotizaciones.CodItem = Inventario.ID Where Cotizaciones.Item = @Item and Cotizaciones.Cotizacion = @Cot")
                            precio = sqla.DBDT.Rows(0).Item(1) * porcion
                            sqla.Addparam("@OT", .OrdTextBox.Text)
                            sqla.Addparam("@Item", item.Cells(0).Value)
                            sqla.execquery("Select IDVenta from ventas where IDVenta = (Select max(idventa) from ventas)")
                            idventa = sqla.DBDT.Rows(0).Item(0)
                            With sqla
                                .Addparam("@Nombre", item.Cells(0).Value)
                                .Addparam("@Cod", codigo)
                                .Addparam("@Cantidad", CDec(item.Cells(1).Value))
                                .Addparam("@Precio", precio)
                                .Addparam("@IDVenta", idventa)
                            End With

                            sqla.execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                            If sqla.Masexception(True) Then Exit Sub
                        End If
                    Next
                End With

                'actualización caja
                '==============================================================================================================
                If fila.Cells(0).Value = "EFECTIVO" Then

                    sqla.execquery("Select    * FROM    Caja  WHERE ID = (SELECT  MAX(ID)  FROM  Caja)")

                    'acumulado = CDbl(sqla.DBDT.Rows(0).Item(5))
                    numero = CDbl(sqla.DBDT.Rows(0).Item(0)) + 1
                    'Dim nuevoacumulado As Double = acumulado + TextBox8.Text

                    sqla.Addparam("@Numero", numero)
                    sqla.Addparam("@Fecha", DateTime.Now)
                    sqla.Addparam("@Responsable", PuntoVenta.OrdTextBox.Text)
                    sqla.Addparam("@Monto", CDbl(fila.Cells(2).Value))
                    'sqla.Addparam("@Acumulado", nuevoacumulado)
                    sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, 'Venta'); ")
                    If sqla.Masexception(True) Then Exit Sub
                End If

                'Ingresa salida al registro
                '==============================================================================================================
                sqla.Addparam("@OT", PuntoVenta.OrdTextBox.Text)
                sqla.Addparam("@Fecha", DateTime.Now)
                sqla.execquery("Update Registro Set Salida = @Fecha where OT = @OT")

                'Cierra la cotización
                '==============================================================================================================
                sqla.Addparam("@Cot", PuntoVenta.CotTextBox2.Text)
                sqla.execquery("Update CotGeneral Set Estado = 'Cerrada' where Cotizacion = @Cot")






            End If
        Next




        MsgBox("Venta Realizada", Title:="Punto de Venta")


        Indicadores.Indicadorventa()
        Indicadores.IndicadorItems()
        Indicadores.Totales()

        Me.Close()

        If esrapida = "Rapida" Then
            VentaRapida.Close()
        Else
            PuntoVenta.Close()
        End If








    End Sub
End Class