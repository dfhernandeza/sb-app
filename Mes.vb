Public Class Mes
    Public sql As New Sqlcontrol
    Private Sub Mes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("select distinct datepart(month, fecha) from Ventas")
        For Each fila As DataRow In sql.DBDT.Rows
            mesbox.Items.Add(fila.Item(0))

        Next

        sql.execquery("select distinct datepart(year, fecha) from ventas")
        For Each fila As DataRow In sql.DBDT.Rows
            anobox.Items.Add(fila.Item(0))

        Next



    End Sub

    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click
        sql.Addparam("@Mes", mesbox.Text)
        sql.Addparam("@Ano", anobox.Text)
        sql.execquery("select distinct OT ,Fecha, sum(Total) Total, sum(IVA) IVA, sum(Neto) Neto, sum(([dbo].[Costo]([IDVenta]))) Costo, MedioPago, Voucher, Cliente, Automovil, Factura  from Ventas where datepart(month,fecha) = @mes and datepart(year,fecha) = @Ano group by OT ,fecha , MedioPago, Voucher, Cliente, Automovil, Factura ")
        Ventas.DataGridView1.DataSource = sql.DBDT
        Ventas.sumar()
    End Sub
End Class