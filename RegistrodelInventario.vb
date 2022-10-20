Public Class RegistrodelInventario
    Public sqla As New Sqlcontrol
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registro_Inventario.Show()
    End Sub

    Private Sub RegistrodelInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        sqla.execquery("Select * from RegistroInventario")
        DataGridView1.DataSource = sqla.DBDT
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        sqla.Addparam("@fecha", DateTimePicker1.Value.DayOfYear)
        sqla.Addparam("@ano", DateTimePicker1.Value.Year)

        sqla.execquery("select * from RegistroInventario Where DATEPART (y,Fecha) = @fecha AND datepart(year,Fecha) = @ano ")
        If Inventario.sqla.Masexception(True) Then Exit Sub

        DataGridView1.DataSource = sqla.DBDT


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqla.execquery("Select * from RegistroInventario")
        DataGridView1.DataSource = sqla.DBDT
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class