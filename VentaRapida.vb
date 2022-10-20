Imports System.ComponentModel
Public Class VentaRapida
    Public sql As New Sqlcontrol
    Public acumulado As Double
    Public numero As Integer
    Private Sub VentaRapida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal

        Dim b As Double

        sql.execquery("Select substring(OT,3,5) from ventas where tipo = 'RAPIDA' AND IDVenta = (SELECT MAX(IDVENTA) FROM Ventas WHERE Tipo = 'RAPIDA')")
        b = sql.DBDT.Rows(0).Item(0) + 1

        Ordenbox.Text = "A-" + b.ToString

        sql.execquery("SELECT ID, Item, PVenta, Stock FROM Inventario WHERE ID <> '20203' and ID <> '20204' and ID <> '20205' and ID <> '20206' and ID <> '20207' and ID <> '20208'")
        With DGVInventario

            .DataSource = sql.DBDT
            .Columns(2).DefaultCellStyle.Format = "$#,##0"
            .Sort(.Columns(1), ListSortDirection.Ascending)


        End With



        With DGVDetalle
            .Columns.Add("ID", "ID")
            .Columns.Add("Item", "Item")
            .Columns.Add("Cantidad", "Cantidad")
            .Columns.Add("Precio", "Precio")
            .Columns.Add("Total", "Total")
            .Columns(3).ValueType = GetType(System.Double)
            .Columns(3).DefaultCellStyle.Format = "$#,##0"
            .Columns(4).DefaultCellStyle.Format = "$#,##0"
        End With


        sql.execquery("Select Nombre + ' ' + Apellido Nombre, ID, 1 Orden from Personal where Especialidad = 'MECÁNICO AUTOMOTRIZ'
                        union
                        Select '-Seleccionar-','Seleccionar', 0 Orden
                        order by Orden")

        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"
        ComboBox1.DataSource = sql.DBDT

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sql.Addparam("@texto", "%" + TextBox1.Text + "%")

        sql.execquery("SELECT ID, Item, PVenta, Stock FROM Inventario where Item like @texto and ID <> '20203' and ID <> '20204' and ID <> '20205' and ID <> '20206' and ID <> '20207' and ID <> '20208'")
        sql.Masexception(True)
        DGVInventario.DataSource = sql.DBDT

    End Sub
    Private Sub DGVInventario_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInventario.CellContentDoubleClick
        'If e.RowIndex >= 0 Then
        '    If DGVInventario.Rows(e.RowIndex).Cells(3).Value = 0 Then
        '        MsgBox("Stock insuficiente", Title:="Stock")
        '        Exit Sub

        '    End If
        '    'Nuevo


        'End If

        If e.RowIndex >= 0 Then
            Dim j As Integer
            Dim mult As Double

            For Each fila As DataGridViewRow In DGVDetalle.Rows
                If fila.Cells(1).Value = DGVInventario.Rows(e.RowIndex).Cells(1).Value Then
                    fila.Cells(2).Value = fila.Cells(2).Value + 1
                    mult = fila.Cells(2).Value * fila.Cells(3).Value
                    fila.Cells(4).Value = mult
                    j += 1
                End If

            Next

            If j = 0 Then

                With DGVDetalle
                    .Rows.Add({DGVInventario.Rows(e.RowIndex).Cells(0).Value, DGVInventario.Rows(e.RowIndex).Cells(1).Value, 1, DGVInventario.Rows(e.RowIndex).Cells(2).Value, DGVInventario.Rows(e.RowIndex).Cells(2).Value})

                End With


            End If
            Sumar()
        End If
        If e.RowIndex >= 0 Then
            DGVInventario.Rows(e.RowIndex).Cells(3).Value = DGVInventario.Rows(e.RowIndex).Cells(3).Value - 1
        End If

    End Sub
    Public Sub Sumar()
        Dim sum As Long
        For Each fila As DataGridViewRow In DGVDetalle.Rows
            If String.IsNullOrEmpty(fila.Cells(4).ToString) = True Then
                TextBox4.Text = 0
            Else
                sum = sum + fila.Cells(4).Value
            End If
        Next
        TextBox4.Text = sum.ToString("$#,##0")
    End Sub

    Private Sub DGVDetalle_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DGVDetalle.UserDeletedRow
        Sumar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VentaManual.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim precio As Double
        Dim idventa As Integer
        For Each fila As DataGridViewRow In DGVDetalle.Rows

            With sql
                .Addparam("@OT", Ordenbox.Text)
                .Addparam("@MPago", MediodepagoTextBox.Text)
                .Addparam("@Recibo", ReciboTextBox.Text)
                .Addparam("@Factura", facturaTextBox.Text)
                .Addparam("@fecha", Date.Today)
                .Addparam("@Cod", fila.Cells(0).Value)
                .Addparam("@Cantidad", CDec(fila.Cells(2).Value))
                .Addparam("@Preciov", fila.Cells(3).Value)
                .Addparam("@Item", fila.Cells(1).Value)
                .Addparam("@Mecanico", ComboBox1.Text)
                .execquery("Insert into Ventas (OT, Fecha, CodItem, Item, Cantidad, PVenta, MedioPago, Voucher, Tipo, Pago, Mecanico) Values (@OT, @fecha,@Cod, @Item,@Cantidad, @Preciov, @MPAgo, @Recibo, 'RAPIDA', 'NORMAL', @Mecanico); ")
                If .Masexception(True) Then Exit Sub


                If (fila.Cells(0).Value.ToString <> "20201" And fila.Cells(0).Value.ToString <> "20202" And fila.Cells(0).Value.ToString <> "20203" And fila.Cells(0).Value.ToString <> "20204" And fila.Cells(0).Value.ToString <> "20205" And fila.Cells(0).Value.ToString <> "20206" And fila.Cells(0).Value.ToString <> "20207" And fila.Cells(0).Value.ToString <> "20208") = True Then

                    .Addparam("@Item", fila.Cells(0).Value)
                    .execquery("Select Inventario.PCompra from Inventario Where ID = @Item")
                    precio = .DBDT.Rows(0).Item(0)
                    .Addparam("@OT", Ordenbox.Text)
                    .Addparam("@Item", fila.Cells(1).Value)
                    .execquery("Select IDVenta from ventas where OT = @OT and Item = @Item")
                    idventa = .DBDT.Rows(0).Item(0)

                    .Addparam("@Nombre", fila.Cells(1).Value)
                    .Addparam("@Cod", fila.Cells(0).Value)
                    .Addparam("@Cantidad", CDec(fila.Cells(2).Value))
                    .Addparam("@Precio", precio)
                    .Addparam("@IDVenta", idventa)


                    .execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                    If .Masexception(True) Then Exit Sub



                End If

                .Addparam("@Cod", fila.Cells(0).Value)
                .Addparam("@Cantidad", CDec(fila.Cells(2).Value))

                .execquery("Update Inventario Set STOCK = STOCK - @Cantidad where ID = @Cod")



                'actualización caja






            End With

        Next
        If MediodepagoTextBox.Text = "EFECTIVO" Then
            With sql
                .execquery("Select    * FROM    Caja  WHERE ID = (SELECT  MAX(ID)  FROM  Caja)")

                'acumulado = CDbl(.DBDT.Rows(0).Item(5))
                numero = CDbl(.DBDT.Rows(0).Item(0)) + 1
                'Dim nuevoacumulado As Double = acumulado + TextBox4.Text

                .Addparam("@Numero", numero)
                .Addparam("@Fecha", DateTime.Now)
                .Addparam("@Responsable", Ordenbox.Text)
                .Addparam("@Monto", CDbl(TextBox4.Text))
                '.Addparam("@Acumulado", nuevoacumulado)
                .execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, 'Venta' ); ")
                If .Masexception(True) Then Exit Sub
            End With
        End If


        MsgBox("Venta Realizada", Title:="Punto de Venta")
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.Text = "-Seleccionar-" Then
            MsgBox("Debe escoger un mecánico", Title:="Venta Rápida")
            Exit Sub
        End If
        FacturaoBoleta.Show()
    End Sub



    Private Sub DGVDetalle_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellValidated
        Dim mult As Double
        mult = DGVDetalle.Rows(e.RowIndex).Cells(2).Value * DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Rows(e.RowIndex).Cells(3).Value = DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Rows(e.RowIndex).Cells(4).Value = mult
        Sumar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        imprimir = "VentaRapida"
        Impresion.Show()
    End Sub


End Class