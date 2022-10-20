Public Class Compras
    Public sqla As New Sqlcontrol
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        sqla.execquery("SELECT DISTINCT FACTURA, FECHA, SUM(SUBTOTAL) SUBT, SUM(IVA) IVA, SUM(TOTAL) TOTAL, Proveedores.Nombre  FROM COMPRAS inner join Proveedores on Compras.Proveedor = Proveedores.ID where DATEPART(MM,Fecha) = DATEPART(MM,GETDATE()) GROUP BY FACTURA, FECHA, Proveedores.Nombre")

        DataGridView1.DataSource = sqla.DBDT

        DataGridView1.Columns(2).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "$#,##0"
        Sumar()
        With ComboBox1.Items
            .Add("Factura")
            .Add("Proveedor")
        End With






        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        sqla.Addparam("@fecha", DateTimePicker1.Value.DayOfYear)
        sqla.Addparam("@ano", DateTimePicker1.Value.Year)




        sqla.execquery("SELECT DISTINCT FACTURA, FECHA, SUM(SUBTOTAL) SUBT, SUM(IVA) IVA, SUM(TOTAL) TOTAL, PROVEEDOR  FROM COMPRAS Where DatePart(y, Fecha) = @fecha And datepart(year, Fecha) = @ano GROUP BY FACTURA, FECHA, PROVEEDOR")
        DataGridView1.DataSource = sqla.DBDT
        Sumar()
    End Sub
    Public Sub Sumar()
        Dim total, iva, neto As Double

        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + DataGridView1.Rows(x).Cells(2).Value
            iva = iva + DataGridView1.Rows(x).Cells(3).Value
            neto = neto + DataGridView1.Rows(x).Cells(4).Value

        Next
        TextBox4.Text = total.ToString("$#,##0")
        TextBox3.Text = iva.ToString("$#,##0")
        TextBox1.Text = neto.ToString("$#,##0")

    End Sub


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim orden As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            sqla.Addparam("@Factura", DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            sqla.execquery("select* from Compras where Factura = @Factura")

            DetalleCompras.DataGridView1.DataSource = sqla.DBDT

            DetalleCompras.Show()
        End If
    End Sub

    Private Sub RendirGastoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendirGastoToolStripMenuItem.Click
        Compra.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim letras As String
        letras = TextBox2.Text
        If ComboBox1.Text = "Factura" Then

            sqla.execquery("SELECT DISTINCT FACTURA, FECHA, SUM(SUBTOTAL) SUBT, SUM(IVA) IVA, SUM(TOTAL) TOTAL, PROVEEDOR  FROM COMPRAS where Factura like '" & letras + "%" & "' group BY FACTURA, FECHA, PROVEEDOR ;")
            DataGridView1.DataSource = sqla.DBDT
        End If

        If ComboBox1.Text = "Proveedor" Then

            sqla.execquery("SELECT DISTINCT FACTURA, FECHA, SUM(SUBTOTAL) SUBT, SUM(IVA) IVA, SUM(TOTAL) TOTAL, PROVEEDOR  FROM COMPRAS where Proveedor like '" & letras + "%" & "' group BY FACTURA, FECHA, PROVEEDOR ;")
            DataGridView1.DataSource = sqla.DBDT
        End If
        Sumar()
    End Sub

    Private Sub RegistrarHHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarHHToolStripMenuItem.Click
        CostoServicios.Show()

    End Sub

    Private Sub TraspasoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspasoToolStripMenuItem.Click
        Traspasos.Show()
    End Sub

    Private Sub RendiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendiciónToolStripMenuItem.Click
        Rendicion.Show()
    End Sub
End Class