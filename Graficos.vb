
Public Class Graficos
    Public sqla As New Sqlcontrol


    Private Sub Graficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        'sqla.execquery("SELECT format((DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, fecha), DATEDIFF(dd, 0, fecha))) +1),'dd-MM-yyy' ) Semana, sum( total) Total from Ventas group by DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, fecha), DATEDIFF(dd, 0, fecha)))")
        'sqla.execquery("select distinct format(Fecha,'dd-MM-yyyy') Fecha , sum(total) Total from ventas where fecha < GETDATE() and fecha > dateadd(day,-6,getdate()) group by Fecha")
        'Chart1.DataSource = sqla.DBDT

        'Chart1.Series("Ventas").XValueMember = "Fecha"
        'Chart1.Series("Ventas").XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
        'Chart1.Series("Ventas").YValueMembers = "Total"
        'Chart1.Series("Ventas").YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double
        'sqla.Addparam("@hoy", DateTime.Today)
        'sqla.execquery("Select count(distinct Ot) from Registro where datepart(dayofyear,Entrada) = datepart(dayofyear,@hoy)")
        'If sqla.DBDT.Rows.Count = 0 Then
        '    Label1.Text = "0"
        'Else
        '    Label1.Text = sqla.DBDT.Rows(0).Item(0)
        'End If

        'sqla.execquery("SELECT count(OT) FROM Registro WHERE SALIDA IS NULL")
        'Label5.Text = sqla.DBDT.Rows(0).Item(0)

        'sqla.Addparam("@hoy", DateTime.Today)
        'sqla.execquery("Select sum(Total) from ventas where fecha = @hoy")
        'If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
        '    Label3.Text = 0
        'Else
        '    Dim total As Double = sqla.DBDT.Rows(0).Item(0)
        '    Label3.Text = total.ToString("$#,##0")
        'End If


        'sqla.execquery("select top 10 Ventas.Item, sum(ventas.Cantidad) Unidades, Inventario.stock

        '  from Ventas INNER JOIN Inventario 
        '  ON Ventas.Item = Inventario.Item 
        '  where Inventario.Categoria <> 'SERVICIOS' and VENTAS.Item <> 'REPSOL 10W40 1L' and Ventas.Item <> 'MOBIL DELVAC MX 15W40 A GRANEL'
        '  group by ventas.Item, Inventario.Categoria, Inventario.STOCK 
        '  order by SUM(cantidad) desc ;")

        'Chart2.DataSource = sqla.DBDT

        'Chart2.Series("Ventas").XValueMember = "Item"
        'Chart2.Series("Ventas").XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
        'Chart2.Series("Ventas").YValueMembers = "Stock"
        'Chart2.Series("Ventas").YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32

        'Chart2.ChartAreas(0).AxisX.LabelStyle.Interval = 1

        'sqla.execquery("SELECT COUNT(DISTINCT OT) FROM VENTAS WHERE FACTURA = 'PENDIENTE' ")
        'Label9.Text = sqla.DBDT.Rows(0).Item(0)


        'sqla.execquery("SELECT sum(total)/count(distinct ot) from Ventas ")
        'Dim promedio As Double = sqla.DBDT.Rows(0).Item(0)

        'Label7.Text = promedio.ToString("$#,##0")



        ''===============================================================================================================================
        ''sqla.execquery("SELECT sum(Neto) from Ventas")
        ''Dim neto As Double = sqla.DBDT.Rows(0).Item(0)
        ''sqla.execquery("SELECT sum(costo) from Ventas")
        ''Dim costo As Double = sqla.DBDT.Rows(0).Item(0)
        ''sqla.execquery("SELECT count(distinct ot) from Ventas")
        ''Dim cuenta As Double = sqla.DBDT.Rows(0).Item(0)
        '''sqla.execquery("SELECT (sum(Neto)-sum(costo))/count(distinct ot) from Ventas  ")
        ''Dim margen As Double = (neto - costo) / cuenta
        ''Label11.Text = margen.ToString("$#,##0")
        ''===============================================================================================================================

        'sqla.Addparam("@hoy", DateTime.Today)
        'sqla.execquery("SELECT sum(Total) from Compras where fecha =@hoy")

        'If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
        '    Label14.Text = 0

        'Else
        '    Dim compra As Double = sqla.DBDT.Rows(0).Item(0)
        '    Label14.Text = compra.ToString("$#,##0")
        'End If

        'sqla.execquery("declare @startdate datetime2 = ( select min(ventas.Fecha) from Ventas)
        '    declare @enddate datetime2 = ( select max(ventas.Fecha) from Ventas)
        '   declare @dias FLOAT = ( SELECT DATEDIFF(day, @startdate, @enddate))
        '  declare @findes FLOAT = (select DATEDIFF(wk, @startdate, @enddate))
        ' declare @diast FLOAT = @dias - @findes-2

        'SELECT (COUNT(DISTINCT OT))/@diast PROMEDIO   FROM VENTAS")


        'Dim avg As Double = sqla.DBDT.Rows(0).Item(0)
        'Label16.Text = avg.ToString("0.0")


        ''sqla.execquery("select sum(costo)/count(distinct ot) from Ventas ")

        ''Dim cprom As Double = sqla.DBDT.Rows(0).Item(0)
        ''Label18.Text = cprom.ToString("$#,##0")


        'sqla.execquery("select 20000/count(distinct ot) from Ventas where DATEPART(MONTH,Fecha) = 6 ")
        'If sqla.DBDT.Rows.Count = 0 Then Exit Sub
        'Dim cpub As Double = sqla.DBDT.Rows(0).Item(0)
        'Label20.Text = cpub.ToString("$#,##0")





    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class