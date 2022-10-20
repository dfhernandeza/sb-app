Public Class Informe
    Public sql As New Sqlcontrol
    Private Sub Informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("select distinct datepart(month, fecha) from Ventas order by datepart(month, fecha) asc")
        For Each fila As DataRow In Sql.DBDT.Rows
            ComboBox1.Items.Add(fila.Item(0))

        Next

        Sql.execquery("select distinct datepart(year, fecha) from ventas")
        For Each fila As DataRow In Sql.DBDT.Rows
            ComboBox2.Items.Add(fila.Item(0))

        Next











    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Impresion.Show()
    End Sub



End Class