Imports Excel = Microsoft.Office.Interop.Excel
Public Class PuntoVenta
    Public tabla As New DataTable
    Public sqla As New Sqlcontrol
    Public acumulado As Double
    Public numero As Integer

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim codigo As String
        Dim precio As Double
        Dim idventa As Integer
        For Each fila As DataGridViewRow In DataGridView1.Rows


            sqla.Addparam("@Cot", CotTextBox2.Text)
            sqla.Addparam("@Item", fila.Cells(0).Value)
            sqla.execquery("Select Cotizaciones.CodItem, Inventario.PCompra from Cotizaciones inner Join Inventario on Cotizaciones.CodItem = Inventario.ID Where Cotizaciones.Item = @Item and Cotizaciones.Cotizacion = @Cot")
            codigo = sqla.DBDT.Rows(0).Item(0)

            sqla.Addparam("@OT", OrdTextBox.Text)
            sqla.Addparam("@MPago", MediodepagoTextBox.Text)
            sqla.Addparam("@Recibo", ReciboTextBox.Text)
            sqla.Addparam("@Cliente", ClienteTextBox.Text)
            sqla.Addparam("@Automovil", VehiculoTextBox.Text)
            sqla.Addparam("@Factura", facturaTextBox.Text)
            sqla.Addparam("@fecha", Date.Today)
            sqla.Addparam("@Cod", codigo)
            sqla.Addparam("@Cantidad", CDec(fila.Cells(1).Value))
            sqla.Addparam("@Preciov", fila.Cells(2).Value)
            sqla.Addparam("@Item", fila.Cells(0).Value)

            sqla.execquery("Insert into Ventas (OT, Fecha, CodItem, Item, Cantidad, PVenta, MedioPago, Voucher, Cliente, Automovil, Factura, Pago) Values (@OT, @fecha,@Cod, @Item,@Cantidad, @Preciov, @MPAgo, @Recibo, @Cliente, @Automovil, @Factura, 'NORMAL'); ")

            If sqla.Masexception(True) Then Exit Sub

            'Costos
            '==============================================================================================================

            sqla.Addparam("@Cot", CotTextBox2.Text)
            sqla.Addparam("@Item", fila.Cells(0).Value)
            sqla.execquery("Select CodItem from Cotizaciones Where Item = @Item and Cotizacion = @Cot")

            If codigo <> "20201" And codigo <> "20202" And codigo <> "20203" And codigo <> "20204" And codigo <> "20205" And codigo <> "20206" And codigo <> "20207" And codigo <> "20208" Then
                sqla.Addparam("@Cot", CotTextBox2.Text)
                sqla.Addparam("@Item", fila.Cells(0).Value)
                sqla.execquery("Select Cotizaciones.CodItem, Inventario.PCompra from Cotizaciones inner Join Inventario on Cotizaciones.CodItem = Inventario.ID Where Cotizaciones.Item = @Item and Cotizaciones.Cotizacion = @Cot")
                precio = sqla.DBDT.Rows(0).Item(1)
                sqla.Addparam("@OT", OrdTextBox.Text)
                sqla.Addparam("@Item", fila.Cells(0).Value)
                sqla.execquery("Select IDVenta from ventas where OT = @OT and Item = @Item")
                idventa = sqla.DBDT.Rows(0).Item(0)
                With sqla
                    .Addparam("@Nombre", fila.Cells(0).Value)
                    .Addparam("@Cod", codigo)
                    .Addparam("@Cantidad", CDec(fila.Cells(1).Value))
                    .Addparam("@Precio", precio)
                    .Addparam("@IDVenta", idventa)
                End With

                sqla.execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                If sqla.Masexception(True) Then Exit Sub


            End If



        Next



        'actualización caja
        '==============================================================================================================
        If MediodepagoTextBox.Text = "EFECTIVO" Then

            sqla.execquery("Select    * FROM    Caja  WHERE ID = (SELECT  MAX(ID)  FROM  Caja)")

            'acumulado = CDbl(sqla.DBDT.Rows(0).Item(5))
            numero = CDbl(sqla.DBDT.Rows(0).Item(0)) + 1
            'Dim nuevoacumulado As Double = acumulado + TextBox8.Text

            sqla.Addparam("@Numero", numero)
            sqla.Addparam("@Fecha", DateTime.Now)
            sqla.Addparam("@Responsable", OrdTextBox.Text)
            sqla.Addparam("@Monto", CDbl(TextBox8.Text))
            'sqla.Addparam("@Acumulado", nuevoacumulado)
            sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, 'Venta'); ")
            If sqla.Masexception(True) Then Exit Sub
        End If

        'Ingresa salida al registro
        '==============================================================================================================
        sqla.Addparam("@OT", OrdTextBox.Text)
        sqla.Addparam("@Fecha", DateTime.Now)
        sqla.execquery("Update Registro Set Salida = @Fecha where OT = @OT")

        'Cierra la cotización
        '==============================================================================================================
        sqla.Addparam("@Cot", CotTextBox2.Text)
        sqla.execquery("Update CotGeneral Set Estado = 'Cerrada' where Cotizacion = @Cot")


        MsgBox("Venta Realizada", Title:="Punto de Venta")


        Indicadores.Indicadorventa()
        Indicadores.IndicadorItems()
        Indicadores.Totales()

        Me.Close()

    End Sub

    Private Sub PuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Me.StartPosition = FormStartPosition.WindowsDefaultBounds
        DataGridView1.Columns(0).Width = 350
        DataGridView1.Columns(1).Width = 50
        Button7.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imprimir = "Pventa"
        Impresion.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FactoBoleta.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Descuento.Show()





        '
        '    Dim total As Double
        '    For x As Integer = 0 To DataGridView1.Rows.Count - 1
        '        total = total + DataGridView1.Rows(x).Cells(3).Value
        '    Next
        '
        '    Dim vd As Double = CDbl(InputBox("Ingrese valor deseado", Title:="Descuento"))
        '    Dim factor As Double = vd / (CDbl(total))
        '    Dim np As Double
        '    Dim sumar As Double
        '
        '
        '    For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '        np = CDbl(DataGridView1.Rows(i).Cells(3).Value * factor) / CDbl(DataGridView1.Rows(i).Cells(1).Value)
        '
        '        DataGridView1.Rows(i).Cells(2).Value = np
        '        DataGridView1.Rows(i).Cells(3).Value = CDbl(DataGridView1.Rows(i).Cells(2).Value) * CDbl(DataGridView1.Rows(i).Cells(1).Value)
        '        sumar = sumar + CDbl(DataGridView1.Rows(i).Cells(3).Value)
        '    Next
        '    TextBox8.Text = sumar.ToString("$#,##0")
    End Sub
End Class