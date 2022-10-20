Public Class Indicadores
    Public sqla As New Sqlcontrol
    Private Sub Indicadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        IndicadorItems()

        Indicadorventa()
        Totales()


        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
        DataGridView3.EnableHeadersVisualStyles = False


        sqla.execquery("select distinct OT,Fecha, Cliente, sum(Total) Total from Ventas where Factura = 'Pendiente' group by OT, Fecha, Cliente")

        DataGridView3.DataSource = sqla.DBDT
        DataGridView3.Columns(3).DefaultCellStyle.Format = "$#,##0"
    End Sub
    Public Sub Indicadorventa()
        DataGridView2.DataSource = Nothing
        sqla.Addparam("@hoy", DateTime.Today)
        sqla.execquery("select distinct OT , sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura from Ventas where Convert(DATE, Fecha) = Convert(DATE, @hoy) group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura ")
        DataGridView2.DataSource = sqla.DBDT


        DataGridView2.Columns(2).DefaultCellStyle.Format = "$#,##0"
        DataGridView2.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView2.Columns(4).DefaultCellStyle.Format = "$#,##0"
        DataGridView2.Columns(5).DefaultCellStyle.Format = "$#,##0"

    End Sub
    Public Sub IndicadorItems()
        DataGridView1.DataSource = Nothing
        sqla.execquery("declare @startdate datetime2 = ( select min(ventas.Fecha) from Ventas)
                       declare @enddate datetime2 = ( select max(ventas.Fecha) from Ventas)
                        declare @dias int = ( SELECT DATEDIFF(day, @startdate, @enddate))
                        declare @findes int = (select DATEDIFF(wk, @startdate, @enddate))
                        declare @diast int = @dias - @findes-2

                        select top 10 Ventas.Item, 1/sum(ventas.Cantidad/@diast) Rotación, Inventario.STOCK from Ventas INNER JOIN Inventario ON Ventas.Item = Inventario.Item where Inventario.Categoria <> 'SERVICIOS' AND Inventario.Item <> 'REPSOL 10W40 1L' group by ventas.Item, Inventario.Categoria, Inventario.STOCK order by SUM(cantidad) desc ")



        DataGridView1.DataSource = sqla.DBDT

        DataGridView1.Columns(2).ValueType = GetType(Integer)
        DataGridView1.Columns(1).DefaultCellStyle.Format = "#,##0.0"



    End Sub
    Public Sub Totales()
        sqla.Addparam("@hoy", DateTime.Today)

        sqla.execquery("select * from Ventas where Convert(DATE, Fecha) = Convert(DATE, @hoy)")

        If Not sqla.DBDT.Rows.Count = 0 Then
            sqla.Addparam("@hoy", DateTime.Today)

            sqla.execquery("Select count(distinct OT) from Ventas where Convert(DATE, Fecha) = Convert(DATE, @hoy)")

            TextBox1.Text = sqla.DBDT.Rows(0).Item(0)


            sqla.Addparam("@hoy", DateTime.Today)
            sqla.execquery("select sum(total) from Ventas where Convert(DATE, Fecha) = Convert(DATE, @hoy)")

            Dim valor As Double = sqla.DBDT.Rows(0).Item(0)
            TextBox8.Text = valor.ToString("$#,##0")
        End If


    End Sub





    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        'If DataGridView1.Columns(e.ColumnIndex).Name.Equals("STOCK") Then
        'If DataGridView1.Rows(e.RowIndex).Cells(2).Value < 2 Then
        '  DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        '    End If

        ' End If
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        'If DataGridView1.Rows(i).Cells(2).Value < 2 Then

        'DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Red
        'End If
        ' Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Graficos.Show()
    End Sub
End Class