Public Class Compra
    Public tabla1 As New DataTable
    Public sqla As New Sqlcontrol
    Public z As Integer

    Public Sub SUMAR()
        Dim subt As Long
        Dim iva As Long
        Dim total As Long
        If DataGridView1.Rows.Count > 0 Then

            For Each fila As DataGridViewRow In DataGridView1.Rows
                subt = subt + fila.Cells(4).Value
            Next

            iva = subt * 0.19
            total = subt + iva

            subttxt.Text = FormatCurrency(subt)
            ivatxt.Text = FormatCurrency(iva)
            tottxt.Text = FormatCurrency(total)

        Else

            subttxt.Clear()
            ivatxt.Clear()
            tottxt.Clear()

        End If

    End Sub
    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal

        With DataGridView1

            .Columns(2).ValueType = GetType(Integer)
            .Columns(3).ValueType = GetType(Double)
            .Columns(4).ValueType = GetType(Double)
            .Columns(3).DefaultCellStyle.Format = "$#,##0"
            .Columns(4).DefaultCellStyle.Format = "$#,##0"
        End With

        With rendiciondgv
            .Columns(1).ValueType = GetType(Double)
            .Columns(1).DefaultCellStyle.Format = "$#,##0"

        End With

        With categoria2box.Items
            .Add("REPUESTOS")
            .Add("PUBLICIDAD")
            .Add("SERVICIOS BÁSICOS")
            .Add("SERVICIOS EXTERNOS")
            .Add("LUBRICANTES")
            .Add("FILTROS DE ACEITE")
            .Add("FILTROS DE COMBUSTIBLE")
            .Add("FILTROS DE AIRE")
            .Add("PERSONAL")
            .Add("OTROS")
        End With
        categoria2box.Sorted = True


        sqla.execquery("Select distinct OT from ventas inner join inventario on ventas.CodItem = Inventario.ID where ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID <> '20201' and Inventario.ID <> '20201010'")
        For Each fila As DataRow In sqla.DBDT.Rows
            OTComboBox.Items.Add(fila.Item(0))

        Next



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        NuevoProveedor.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ot As String
        Dim mpago As String
        Dim totalmixto As Double
        Dim porcentaje As Decimal
        Dim costoitem As Double
        Dim totalot As Double
        For Each fila As DataGridViewRow In DataGridView1.Rows


            Dim a = {{"@IDVenta", fila.Cells(6).Value}}
            sqla.Addparam(a)
            sqla.execquery("Select Pago, MedioPago, OT from Ventas where IDVenta = @IDVenta")
                ot = sqla.DBDT.Rows(0).Item(2)

                If sqla.DBDT.Rows(0).Item(0) = "MIXTO" Then
                Dim b = {{"@OT", ot}}
                sqla.Addparam(b)


                sqla.Addparam("@Item", fila.Cells(1).Value)
                sqla.execquery("Select distinct MedioPago, IDVenta from ventas where ( CodItem =  '20203' OR CodItem = '20204' OR CodItem = '20205' OR CodItem = '20206' OR CodItem = '20207' OR CodItem = '20208' OR CodItem = '20201' OR CodItem = '20202' OR CodItem = '20209') and OT = @OT and Pago = 'MIXTO' and Item = @Item ")
                For Each item As DataRow In sqla.DBDT.Rows

                    mpago = item.Item(0)



                    sqla.Addparam("@OT", ot)
                        sqla.Addparam("@mpago", mpago)
                        sqla.execquery("Select sum(total) from ventas where OT = @OT and MedioPago = @mpago")
                        totalmixto = sqla.DBDT.Rows(0).Item(0)
                        sqla.Addparam("@OT", ot)
                        sqla.execquery("Select sum(total) from ventas where OT= @OT")
                        totalot = sqla.DBDT.Rows(0).Item(0)
                        porcentaje = totalmixto / totalot
                        costoitem = porcentaje * fila.Cells(3).Value

                    Dim c = {{"@Nombre", fila.Cells(1).Value}, {"@Cod", fila.Cells(0).Value}, {"@Cantidad", fila.Cells(2).Value}, {"@Precio", costoitem}, {"@IDVenta", item.Item(1)}}
                    With sqla
                        .Addparam(c)

                    End With
                        sqla.execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                        If sqla.Masexception(True) Then Exit Sub




                    Next
                Else

                Dim d = {{"@Nombre", fila.Cells(1).Value}, {"@Cod", fila.Cells(0).Value}, {"@Cantidad", fila.Cells(2).Value}, {"@Precio", fila.Cells(3).Value}, {"@IDVenta", fila.Cells(6).Value}}
                sqla.Addparam(d)

                sqla.execquery("Insert into Costos (Item, CodItem, Cantidad, Costo, IDVenta) Values (@Nombre, @Cod, @Cantidad, @Precio, @IDVenta)")
                If sqla.Masexception(True) Then Exit Sub






                End If








        Next


        If MsgBox("Compra ingresada, ¿Desea continuar?", MsgBoxStyle.YesNo, Title:="Compra") = "7" Then
            Me.Close()

        Else


            subttxt.Clear()
            ivatxt.Clear()
            tottxt.Clear()

            DataGridView1.Rows.Clear()
            OTComboBox.Items.Clear()
            sqla.execquery("Select distinct OT from ventas inner join inventario on ventas.CodItem = Inventario.ID where ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID <> '20201' and Inventario.ID <> '20201010'")
            For Each fila As DataRow In sqla.DBDT.Rows
                OTComboBox.Items.Add(fila.Item(0))

            Next
            rendiciondgv.Rows.Clear()
        End If
    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserDeletedRow
        SUMAR()

    End Sub

    Private Sub OTComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OTComboBox.SelectedIndexChanged
        ItemComboBox.Items.Clear()
        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select Distinct Ventas.Item from Ventas inner join Inventario on Ventas.CodItem = Inventario.ID where OT = @OT and ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID <> '20201' and Inventario.ID <> '20201010'")
        For Each fila As DataRow In sqla.DBDT.Rows
            ItemComboBox.Items.Add(fila.Item(0))

        Next
        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select Nombre, Precio, Categoria from Compras where OT = @OT")

        For Each fila As DataRow In sqla.DBDT.Rows
            rendiciondgv.Rows.Add(fila.ItemArray)

        Next



    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged
        sqla.Addparam("@Item", ItemComboBox.Text)
        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select IDVenta, Cantidad from Ventas where OT = @OT and Item = @Item")
        IDVentabox.Text = sqla.DBDT.Rows(0).Item(0)
        cantidad2box.Text = sqla.DBDT.Rows(0).Item(1)
        preciobox2.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With DataGridView1

            .Rows.Add({"-", ItemComboBox.Text, CDec(cantidad2box.Text), CDbl(preciobox2.Text), cantidad2box.Text * preciobox2.Text, categoria2box.Text, IDVentabox.Text})

        End With

        SUMAR()
        ItemComboBox.Items.RemoveAt(ItemComboBox.SelectedIndex)
        ItemComboBox.ResetText()
        IDVentabox.Clear()
        preciobox2.Clear()
        cantidad2box.Clear()
        categoria2box.ResetText()
    End Sub

    Private Sub rendiciondgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rendiciondgv.CellContentClick
        Dim precio As Double = rendiciondgv.Rows(e.RowIndex).Cells(1).Value
        preciobox2.Text = precio.ToString("$#,##0")
        categoria2box.Text = rendiciondgv.Rows(e.RowIndex).Cells(2).Value
    End Sub


End Class