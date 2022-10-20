Public Class Intervalo
    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click
        Ventas.sqla.Addparam("@Fecha1", fecha1.Value.Date)
        Ventas.sqla.Addparam("@Fecha2", fecha2.Value.Date)
        Ventas.sqla.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas where fecha >= @fecha1 and fecha <= @fecha2 group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura")
        Ventas.DataGridView1.DataSource = Ventas.sqla.DBDT
        Ventas.sumar()
    End Sub
End Class