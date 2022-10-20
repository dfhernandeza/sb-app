Public Class Semana
    Public sqla As New Sqlcontrol
    Public vsemana As Date
    Public filtro As String
    Private Sub Semana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("SELECT format( (DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, fecha), DATEDIFF(dd, 0, fecha))) +1), 'dd-MM-yyyy') Semana from Ventas group by DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, fecha), DATEDIFF(dd, 0, fecha))) order by DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, fecha), DATEDIFF(dd, 0, fecha))) desc ")
        For Each r As DataRow In sqla.DBDT.Rows
            ComboBox1.Items.Add(r.Item(0))
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If filtro = "Filtro" Then

            vsemana = ComboBox1.Text
            sqla.Addparam("@Semana", vsemana)
            sqla.Addparam("Ano", vsemana.Year)

            sqla.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas where  DATEPART (WEEK , [Fecha]) = DATEPART (WEEK , @semana) and DATEPART (YEAR , [Fecha]) = @Ano  group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura ")

            Ventas.DataGridView1.DataSource = sqla.DBDT
            Ventas.sumar()
        Else
            imprimir = "InformeS"

            vsemana = ComboBox1.Text
            Impresion.Show()
        End If

    End Sub
End Class