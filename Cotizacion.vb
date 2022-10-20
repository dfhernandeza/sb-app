Imports System.ComponentModel
Imports ClasesLibreria
Public Class Cotizacion
    Public sqla As New Sqlcontrol
    Public tabla As New DataTable
    Public z, t As Integer
    Public table As New DataTable
    Public metodos As New ClasesLibreria.Funciones
    Private Sub Cotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Loadgrid()

        DGVInventario.Columns(1).Width = 250
        '================================================================================================================
        'Cliente
        sqla.execquery("Select ID, IdCLiente, Nombre, Apellido from Clientes")
        For Each fila As DataRow In sqla.DBDT.Rows
            DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
        Next



        '================================================================================================================
        'Si fue ingresada entonces se puede pagar
        sqla.Addparam("@COT", TextBox2.Text)
        sqla.execquery("Select * from Registro where Cotizacion = @COT ")
        If Not sqla.DBDT.Rows.Count = 0 Then
            Button3.Text = "Pagar"
            sqla.Addparam("@COT", TextBox2.Text)
            sqla.execquery("Select Estado from CotGeneral where Cotizacion = @COT")
            If sqla.DBDT.Rows(0).Item(0) = "Aprobada" Then

                pagar = "Pago"
                Button7.Enabled = False
                Button4.Enabled = False
                Button1.Enabled = False
            End If
        End If
        '================================================================================================================
        'Si fue aprobada entonces es sólo lectura
        sqla.Addparam("@COT", TextBox2.Text)
        sqla.execquery("Select Estado from CotGeneral where Cotizacion = @COT")
        If sqla.DBDT.Rows.Count > 0 Then
            If sqla.DBDT.Rows(0).Item(0) = "Aprobada" Then
                Button7.Enabled = False
                Button1.Enabled = False
                Button4.Enabled = False
            End If
        End If
        '================================================================================================================
        'Inventario

        DGVDetalle.Columns(3).ValueType = GetType(System.Double)
        DGVDetalle.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DGVDetalle.Columns(4).DefaultCellStyle.Format = "$#,##0"

    End Sub
    Public Sub Loadgrid()
        sqla.execquery("SELECT ID, Item, PVenta, Stock FROM Inventario WHERE ID <> '20203' and ID <> '20204' and ID <> '20205' and ID <> '20206' and ID <> '20207' and ID <> '20208' ;")
        If sqla.Masexception(True) Then Exit Sub
        DGVInventario.DataSource = sqla.DBDT
        DGVInventario.Columns(2).DefaultCellStyle.Format = "$#,##0"
        DGVInventario.Sort(DGVInventario.Columns(1), ListSortDirection.Ascending)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim letras As String
        letras = TextBox1.Text
        sqla.Addparam("@texto", letras)
        sqla.execquery("SELECT ID, Item, PVenta, Stock FROM Inventario where Item like '%' + @texto + '%' or ID like  @texto + '%' and (ID <> '20203' and ID <> '20204' and ID <> '20205' and ID <> '20206' and ID <> '20207' and ID <> '20208')    ")
        DGVInventario.DataSource = sqla.DBDT

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInventario.CellDoubleClick

        If e.RowIndex >= 0 Then
            'If DGVInventario.Rows(e.RowIndex).Cells(3).Value = 0 Then
            '    MsgBox("Stock insuficiente", Title:="Stock")
            '    Exit Sub

            'End If
            'Nuevo

            sqla.Addparam("@Item", DGVInventario.Rows(e.RowIndex).Cells(1).Value)
            sqla.execquery("Select * from Cotizaciones where Item = @Item and Inventariado = 'NO'")
            If sqla.DBDT.Rows.Count >= 1 Then
                sqla.Addparam("@Item", DGVInventario.Rows(e.RowIndex).Cells(1).Value)
                sqla.execquery("Select sum(cantidad) from Cotizaciones where Item = @Item and Inventariado = 'NO'")
                Dim cantidad As Integer = sqla.DBDT.Rows(0).Item(0)
                sqla.Addparam("@Item", DGVInventario.Rows(e.RowIndex).Cells(1).Value)
                sqla.execquery("Select Item, Stock from Inventario where Item = @Item")
                Dim stock As Integer = sqla.DBDT.Rows(0).Item(1)
                If stock - cantidad <= 1 Then
                    Dim resta As Integer = stock - cantidad
                    If MsgBox("Otras cotizaciones abiertas han inscrito este Ítem, stock actual de " & resta & ". ¿Desea continuar? ", vbYesNo, Title:="Stock insuficiente") = "7" Then Exit Sub
                End If

            End If
            'Nuevo


        End If

        If e.RowIndex >= 0 Then
            Dim j As Integer
            Dim x As Integer = DGVDetalle.Rows.Count()
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

                With DGVInventario
                    DGVDetalle.Rows.Add({ .Rows(e.RowIndex).Cells(0).Value, .Rows(e.RowIndex).Cells(1).Value, 1, .Rows(e.RowIndex).Cells(2).Value, .Rows(e.RowIndex).Cells(2).Value})

                End With


            End If
            Sumar()
        End If
        If e.RowIndex >= 0 Then
            DGVInventario.Rows(e.RowIndex).Cells(3).Value = DGVInventario.Rows(e.RowIndex).Cells(3).Value - 1
        End If
        ing = "No"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CotManual.Show()
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
    Private Sub DataGridView2_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DGVDetalle.UserDeletedRow
        Sumar()
        ing = "No"
    End Sub

    Private Sub DataGridView2_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVDetalle.CellValidating
        If String.IsNullOrEmpty(DGVDetalle.Rows(e.RowIndex).Cells(2).EditedFormattedValue) Then
            MsgBox("Ingresar valor mayor que cero", Title:="Advertencia")
            e.Cancel = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim precio As Double
        Dim item As String
        Dim c As Integer
        Dim contador As Integer


        If String.IsNullOrEmpty(TextBox3.Text) Then
            MsgBox("Debe ingresar un Cliente antes de guardar su cotización", Title:="Cotización")

            Exit Sub

        End If

        'Inserta cotización general
        sqla.Addparam("@Cot", TextBox2.Text)
        sqla.execquery("Select * from CotGeneral where Cotizacion = @Cot")
        If sqla.DBDT.Rows.Count = 0 Then

            'If onoff <> "on" Then
            sqla.Addparam("@Num", TextBox2.Text)
            sqla.Addparam("@Cliente", TextBox8.Text)
            sqla.Addparam("@fecha", DateTime.Today)
            sqla.Addparam("@Detalles", TextBox6.Text)
            sqla.Addparam("@Total", TextBox4.Text)

            sqla.execquery("Insert into CotGeneral (Cotizacion, fecha, Estado, Detalles, IDCliente) VALUES(@Num,@fecha,'Abierta', @Detalles, @Cliente )")
            If sqla.Masexception(True) Then Exit Sub
        Else
            sqla.Addparam("@Detalle", TextBox6.Text)
            sqla.Addparam("@Num", TextBox2.Text)
            sqla.execquery("Update CotGeneral Set Detalles = @Detalle where Cotizacion = @Num")


        End If


        ' actualiza cotizaciones


        For Each fil As DataGridViewRow In DGVDetalle.Rows

            sqla.Addparam("@Cot", TextBox2.Text)
            sqla.execquery("Select Item, Cantidad, Precio, Costo from Cotizaciones where Cotizacion = @Cot")
            For Each filo As DataRow In sqla.DBDT.Rows
                If fil.Cells(1).Value = filo.Item(0) Then
                    'compara cantidad
                    If fil.Cells(2).Value <> filo.Item(1) Then
                        Dim a = {{"@Cot", TextBox2.Text}, {"@Item", fil.Cells(1).Value}, {"@Cant", CDec(fil.Cells(2).Value)}}
                        sqla.Addparam(a)
                        sqla.execquery("Update Cotizaciones set Cantidad = @Cant where Cotizacion = @Cot and Item = @Item")
                    End If
                    'compara precio
                    If fil.Cells(3).Value <> filo.Item(2) Then
                        Dim arreglo = {{"@Cot", TextBox2.Text}, {"@Item", fil.Cells(1).Value}, {"@Precio", fil.Cells(3).Value}}
                        sqla.Addparam(arreglo)
                        sqla.execquery("Update Cotizaciones set Precio = @Precio where Cotizacion = @Cot and Item = @Item")
                    End If
                    contador = contador + 1
                End If
            Next

            If contador = 0 Then

                precio = fil.Cells(3).Value
                item = fil.Cells(1).Value.ToString
                c = fil.Cells(2).Value
                If sqla.DBDT.Rows.Count = 0 Then
                    Dim arreglo = {{"@Num", TextBox2.Text}, {"@Cliente", TextBox8.Text}, {"@Item", fil.Cells(1).Value}, {"@Cant", CDec(fil.Cells(2).Value)}, {"@Cod", fil.Cells(0).Value}, {"@fecha", DateTime.Today}}
                    sqla.Addparam(arreglo)
                    sqla.execquery("Insert into Cotizaciones (Cotizacion, fecha, Item, Cantidad, Precio, CodItem, Inventariado, IDCliente) VALUES(@Num,@fecha,@Item,@Cant,'" & precio & "', @Cod, 'No', @Cliente)")
                    If sqla.Masexception(True) Then Exit Sub
                Else
                    Dim arreglo = {{"@Num", TextBox2.Text}, {"@Cliente", TextBox8.Text}, {"@Item", fil.Cells(1).Value}, {"@Cant", CDec(fil.Cells(2).Value)}, {"@Cod", fil.Cells(0).Value}, {"@fecha", DateTime.Today}}
                    sqla.Addparam(arreglo)
                    sqla.execquery("Insert into Cotizaciones (Cotizacion, fecha, Item, Cantidad, Precio, CodItem, Inventariado, IDCliente) VALUES(@Num,@fecha,@Item,@Cant,'" & precio & "', @Cod, 'No', @Cliente)")
                    If sqla.Masexception(True) Then Exit Sub
                End If
            End If
            contador = 0
        Next

        Dim cont As Integer
        sqla.Addparam("@Cot", TextBox2.Text)
        sqla.execquery("Select Cotizacion, Item, CodItem, Cantidad, Inventariado from Cotizaciones where Cotizacion = @Cot")
        For Each fila As DataRow In sqla.DBDT.Rows

            For Each filo As DataGridViewRow In DGVDetalle.Rows
                If fila.Item(1) = filo.Cells(1).Value Then
                    cont = cont + 1
                End If
            Next
            If cont = 0 Then
                Dim arreglo = {{"@Cot", TextBox2.Text}, {"@Item", fila.Item(1)}}
                sqla.Addparam(arreglo)
                sqla.execquery("Delete from Cotizaciones where Cotizacion = @Cot and Item = @Item")

                If fila.Item(4) = "Si" Then
                    Dim arregloa = {{"@Cod", fila.Item(2)}, {"@Cantidad", CDec(fila.Item(3))}}
                    sqla.Addparam(arregloa)
                    sqla.execquery("Update Inventario set Stock = Stock + @Cantidad where ID = @Cod")
                End If


            End If
            cont = 0
        Next
        'onoff = "on"
        If MsgBox("Cotización guardada, ¿Desea continuar?", MsgBoxStyle.YesNo, Title:="Cotización") = "7" Then
            zeta = 0
            Me.Close()
        End If

        ing = "Guardada"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sumar As Integer
        sqla.Addparam("@COT", TextBox2.Text)
        sqla.execquery("Select * from Registro where Cotizacion = @COT ")
        If Not sqla.DBDT.Rows.Count = 0 Then
            sqla.Addparam("@COT", TextBox2.Text)
            sqla.execquery("Select Estado from CotGeneral where Cotizacion = @COT")
            If sqla.DBDT.Rows(0).Item(0) = "Aprobada" Then
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
                pagar = "Pago"


                Dim sum As Double

                sqla.Addparam("@COT", TextBox2.Text)
                sqla.execquery("Select * from Registro where Cotizacion = @Cot")

                PuntoVenta.OrdTextBox.Text = sqla.DBDT.Rows(0).Item(1)
                PuntoVenta.ClienteTextBox.Text = TextBox3.Text
                PuntoVenta.CotTextBox2.Text = TextBox2.Text
                PuntoVenta.VehiculoTextBox.Text = sqla.DBDT.Rows(0).Item(4)
                PuntoVenta.kilometrajetxt.Text = sqla.DBDT.Rows(0).Item(6)
                sqla.Addparam("@Num", TextBox2.Text)
                sqla.execquery("select Item, Cantidad, Precio, Total from Cotizaciones where Cotizacion = @Num ")
                PuntoVenta.DataGridView1.Columns(0).ValueType = GetType(String)
                PuntoVenta.DataGridView1.Columns(1).ValueType = GetType(Decimal)
                PuntoVenta.DataGridView1.Columns(2).ValueType = GetType(Decimal)
                PuntoVenta.DataGridView1.Columns(3).ValueType = GetType(Decimal)
                For Each row As DataRow In sqla.DBDT.Rows
                    PuntoVenta.DataGridView1.Rows.Add(row.ItemArray)

                Next

                PuntoVenta.DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
                PuntoVenta.DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"



                For Each fila As DataGridViewRow In DGVDetalle.Rows
                    sum = sum + fila.Cells(4).Value
                Next

                PuntoVenta.TextBox8.Text = sum.ToString("$#,##0")
                PuntoVenta.TextBox1.Text = TextBox9.Text
                Me.Close()
                PuntoVenta.Show()
            Else
                MsgBox("Debe aprobar su cotización antes de pasar a pago", Title:="Cotización")
                Exit Sub

            End If

        Else

            sqla.Addparam("@COT", TextBox2.Text)
            sqla.execquery("Select Estado from CotGeneral where Cotizacion = @COT")
            If sqla.DBDT.Rows.Count > 0 Then
                If sqla.DBDT.Rows(0).Item(0) = "Aprobada" Then
                    Ingreso.TextBox6.Text = TextBox2.Text
                    Ingreso.TextBox1.Text = TextBox3.Text
                    Ingreso.TextBox7.Text = TextBox6.Text
                    Ingreso.TextBox9.Text = TextBox8.Text




                    Me.Close()
                    Ingreso.Show()
                    Ingreso.ComboBox2.Select()

                    Exit Sub

                End If
            End If

            If ing <> "Guardada" Then
                MsgBox("Debe guardar su cotización antes de ingresar el vehículo", Title:="Ingreso")
                Exit Sub
            End If

            Ingreso.TextBox6.Text = TextBox2.Text
            Ingreso.TextBox1.Text = TextBox3.Text
            Ingreso.TextBox7.Text = TextBox6.Text
            Ingreso.TextBox9.Text = TextBox8.Text

            For Each row As DataGridViewRow In DGVDetalle.Rows
                If row.Cells(0).Value <> "20201" And row.Cells(0).Value <> "20202" And row.Cells(0).Value <> "20203" And row.Cells(0).Value <> "20204" And row.Cells(0).Value <> "20205" And row.Cells(0).Value <> "20206" And row.Cells(0).Value <> "20207" And row.Cells(0).Value <> "20208" Then
                    sqla.Addparam("@ID", row.Cells(0).Value)
                    sqla.execquery("select tiempo from inventario where ID = @ID")
                    If sqla.DBDT.Rows.Count = 0 Then
                        sumar = sumar + 0
                    Else

                        If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                            sumar = sumar + 0
                        Else

                            sumar = sumar + sqla.DBDT.Rows(0).Item(0)
                        End If
                    End If


                End If

            Next
            Ingreso.tiempobox.Text = sumar




            Me.Close()
            Ingreso.Show()



            Ingreso.ComboBox2.Select()
        End If

    End Sub


    Private Sub DataGridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            TextBox3.Text = DGVClientes.Rows(e.RowIndex).Cells(2).Value + " " + DGVClientes.Rows(e.RowIndex).Cells(3).Value
            TextBox7.Text = DGVClientes.Rows(e.RowIndex).Cells(1).Value
            TextBox8.Text = DGVClientes.Rows(e.RowIndex).Cells(0).Value
        End If
        ing = "No"
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        DGVClientes.Rows.Clear()
        sqla.Addparam("@Buscado", TextBox5.Text)
        sqla.execquery("SELECT ID, IdCLiente, Nombre, Apellido FROM Clientes where Apellido like '%' + @Buscado + '%' or IDCLiente like '%' + @Buscado + '%' or Nombre like '%' + @Buscado + '%' or Nombre + ' ' + Apellido like '%' + @Buscado + '%'")
        For Each fila As DataRow In sqla.DBDT.Rows
            DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NuevoCliente.Show()
        cotineumatico = "Coti"
    End Sub
    Private Sub DataGridView2_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellValidated
        Dim mult As Double
        mult = DGVDetalle.Rows(e.RowIndex).Cells(2).Value * DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Rows(e.RowIndex).Cells(3).Value = DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Rows(e.RowIndex).Cells(4).Value = mult
        Sumar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        imprimir = "Cotizar"
        Impresion.origen = "Coti"
        Impresion.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ing <> "Guardada" Then
            MsgBox("Debe guardar todos los cambios de su cotización antes de inventariar", Title:="Cotización")
            Exit Sub
        Else
            If MsgBox("El Inventario será actualizado. ¿Desea continuar?", vbYesNo, Title:="Aprobar") = "7" Then Exit Sub

            '=======================================================================================
            Dim cant As Decimal
            For Each fil As DataGridViewRow In DGVDetalle.Rows
                'For k As Integer = 0 To DataGridView2.Rows.Count - 1
                sqla.Addparam("@Cot", TextBox2.Text)
                sqla.execquery("Select Item, Cantidad, Precio, Costo from Cotizaciones where Cotizacion = @Cot and Inventariado = 'Si'")
                For Each filo As DataRow In sqla.DBDT.Rows
                    'For i As Integer = 0 To sqla.DBDT.Rows.Count - 1

                    If fil.Cells(1).Value = filo.Item(0) Then
                        If fil.Cells(2).Value <> filo.Item(1) Then
                            cant = CDec(fil.Cells(2).Value) - CDec(filo.Item(1))
                            sqla.Addparam("@Cod", fil.Cells(0).Value)
                            sqla.Addparam("@Cant", cant)
                            sqla.execquery("Update Inventario set Stock = Stock - @Cant where ID = @Cod")
                        End If

                    End If
                Next

            Next



            '=======================================================================================


            sqla.Addparam("@Cot", TextBox2.Text)
            sqla.execquery("Select CodItem, Cantidad from Cotizaciones where Cotizacion = @Cot and Inventariado = 'No'")
            For Each fila As DataRow In sqla.DBDT.Rows
                sqla.Addparam("@Cod", fila.Item(0))
                sqla.Addparam("@Cantidad", CDec(fila.Item(1)))
                sqla.execquery("Update Inventario Set Stock = Stock - @Cantidad where ID = @Cod")


            Next

            sqla.Addparam("@Cot", TextBox2.Text)
            sqla.execquery("Update Cotizaciones set Inventariado = 'Si' where Cotizacion = @Cot")
            If sqla.Masexception(True) Then Exit Sub


            sqla.Addparam("@Cot", TextBox2.Text)
            sqla.execquery("Select Cotizaciones.CodItem, Cotizaciones.Item, Cotizaciones.Cantidad from Cotizaciones inner Join Inventario on Cotizaciones.CodItem = Inventario.ID where Cotizacion = @Cot and Inventariado = 'No' and Inventario.Categoria <> 'SERVICIOS'")

            For Each fila As DataRow In sqla.DBDT.Rows
                sqla.Addparam("@Fecha", DateTime.Now)
                sqla.Addparam("@IdItem", fila.Item(0).Value)
                sqla.Addparam("@Item", fila.Item(1).Value)
                sqla.Addparam("@Cantidad", CDec(fila.Item(2).Value))
                sqla.Addparam("@Responsable", "Cot " + TextBox2.Text)

                sqla.execquery("Insert into RegistroInventario (Fecha, IdItem, Item, Cantidad, Responsable) Values(@Fecha, @IdItem, @Item, @Cantidad, @Responsable)     ")
                If sqla.Masexception(True) Then Exit Sub

            Next

        End If
        sqla.Addparam("@COT", TextBox2.Text)
        sqla.execquery("Select * from Registro where Cotizacion = @COT ")
        If Not sqla.DBDT.Rows.Count = 0 Then
            Button3.Text = "Pagar"
            pagar = "Pago"
        End If

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        'Button4.Enabled = True
    End Sub

    Private Sub DataGridView2_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DGVDetalle.UserDeletingRow
        If onoff = "on" Then
            For Each fila As DataGridViewRow In DGVInventario.Rows
                If fila.Cells(1).Value = DGVDetalle.Rows(e.Row.Index).Cells(1).Value Then
                    fila.Cells(3).Value = fila.Cells(3).Value + DGVDetalle.Rows(e.Row.Index).Cells(2).Value
                End If
            Next
        End If
        ing = "No"
    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVDetalle.CellFormatting
        DGVDetalle.Rows(e.RowIndex).Cells(3).Value = DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ing <> "Guardada" Then
            MsgBox("Debe guardar todos los cambios de su cotización antes de inventariar", Title:="Cotización")
            Exit Sub
        End If

        sqla.Addparam("@Cot", TextBox2.Text)
        sqla.execquery("Select Item, Inventariado from Cotizaciones where Cotizacion = @Cot ")
        For Each fila As DataRow In sqla.DBDT.Rows

            If fila.Item(1) = "No" Then

                MsgBox("Debe inventariar " & fila.Item(0) & " antes de aprobar su cotización", Title:="Cotización")
                Exit Sub
            End If
        Next




        If MsgBox("La cotización será aprobada. ¿Desea continuar?", vbYesNo, Title:="Aprobar") = "7" Then Exit Sub

        sqla.Addparam("@Cot", TextBox2.Text)
        sqla.execquery("Update CotGeneral set Estado = 'Aprobada' where Cotizacion = @Cot")

        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Descuento.Show()
    End Sub



    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellEndEdit
        DGVDetalle.Rows(e.RowIndex).Cells(3).Value = DGVDetalle.Rows(e.RowIndex).Cells(3).Value
        DGVDetalle.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub
End Class