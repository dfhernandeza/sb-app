Public Class Ventas
    Public sqla As New Sqlcontrol

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        sqla.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas where datepart(MM,Fecha)=DATEPART(MM,GETDATE()) group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura ;")

        If sqla.Masexception(True) Then Exit Sub

        DataGridView1.DataSource = sqla.DBDT
        DateTimePicker1.Value = DateTime.Today
        DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "$#,##0"
        sumar()
        ComboBox1.Items.Add("OT")
        ComboBox1.Items.Add("Cliente")
        ComboBox1.Items.Add("Automóvil")

        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        sqla.Addparam("@fecha", DateTimePicker1.Value.DayOfYear)
        sqla.Addparam("@ano", DateTimePicker1.Value.Year)

        sqla.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas Where DATEPART (y , [Fecha]) = @fecha AND datepart(year, [Fecha]) = @ano  group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura")
        If Inventario.sqla.Masexception(True) Then Exit Sub

        DataGridView1.DataSource = sqla.DBDT

        sumar()

    End Sub
    Public Sub sumar()
        Dim total, iva, neto, costo As Double
        Dim x As Integer
        For x = 0 To DataGridView1.Rows.Count - 1
            total = total + DataGridView1.Rows(x).Cells(2).Value
            iva = iva + DataGridView1.Rows(x).Cells(3).Value
            neto = neto + DataGridView1.Rows(x).Cells(4).Value
            costo = costo + DataGridView1.Rows(x).Cells(4).Value
        Next
        totalTextBox2.Text = total.ToString("$#,##0")
        IvaTextBox.Text = iva.ToString("$#,##0")
        netoTextBox.Text = neto.ToString("$#,##0")

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim contador As Integer
        If e.RowIndex >= 0 Then

            For Each form In My.Application.OpenForms
                If (form.name = DetalleVentas.Name) Then

                    DetalleVentas.Close()


                    sqla.Addparam("@OT", DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                    sqla.execquery("select* from Ventas where OT= @OT")

                    DetalleVentas.DataGridView1.DataSource = sqla.DBDT

                    DetalleVentas.Show()
                    DetalleVentas.BringToFront()
                    contador = contador + 1

                    Exit Sub
                End If
            Next

            If contador = 0 Then
                sqla.Addparam("@OT", DataGridView1.Rows(e.RowIndex).Cells(0).Value)


                sqla.execquery("select* from Ventas where OT= @OT   ")

                DetalleVentas.DataGridView1.DataSource = sqla.DBDT

                DetalleVentas.Show()




            End If




        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiarioToolStripMenuItem.Click
        Informediario.Show()
    End Sub

    Private Sub MensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MensualToolStripMenuItem.Click
        Informe.Show()


        imprimir = "InformeM"

    End Sub

    Private Sub TodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasToolStripMenuItem.Click
        MdiParent = Principal
        sqla.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, ([dbo].[Costo]([IDVenta])) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura ;")
        If sqla.Masexception(True) Then Exit Sub
        DataGridView1.DataSource = sqla.DBDT

        DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "$#,##0"
        sumar()
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub SemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanalToolStripMenuItem.Click
        Semana.Show()
        Semana.filtro = "Nada"
    End Sub

    Private Sub MesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesToolStripMenuItem.Click
        Mes.Show()
    End Sub

    Private Sub SemanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SemanaToolStripMenuItem.Click
        Semana.filtro = "Filtro"
        Semana.Show()
    End Sub

    Private Sub IntervaloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntervaloToolStripMenuItem.Click
        Intervalo.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim letras As String
            letras = TextBox1.Text
            If ComboBox1.Text = "OT" Then

                sqla.execquery("select distinct OT, Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, ([dbo].[Costo]([IDVenta])) Costo, Mediopago, Voucher, Cliente, Automovil, factura  from Ventas where OT like '" & letras + "%" & "' group by OT , fecha, Mediopago, Voucher, Cliente, Automovil, factura, ([dbo].[Costo]([IDVenta])) ;")
                DataGridView1.DataSource = sqla.DBDT
            End If

            If ComboBox1.Text = "Cliente" Then
                sqla.Addparam("@palabra", TextBox1.Text)
                sqla.execquery("select distinct OT, Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, ([dbo].[Costo]([IDVenta])) Costo, Mediopago, Voucher, Cliente, Automovil, factura  from Ventas where Cliente like '" & letras + "%" & "' group by OT , fecha, Mediopago, Voucher, Cliente, Automovil, factura, ([dbo].[Costo]([IDVenta])) ;")
                DataGridView1.DataSource = sqla.DBDT
            End If



            If ComboBox1.Text = "Automóvil" Then
                sqla.Addparam("@palabra", TextBox1.Text)
                sqla.execquery("select distinct OT, Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, ([dbo].[Costo]([IDVenta])) Costo, Mediopago, Voucher, Cliente, Automovil, factura  from Ventas where Automovil like '" & letras + "%" & "' group by OT , fecha, Mediopago, Voucher, Cliente, Automovil, factura, ([dbo].[Costo]([IDVenta])) ;")
                DataGridView1.DataSource = sqla.DBDT
            End If
        Else
            Exit Sub
        End If

    End Sub
End Class