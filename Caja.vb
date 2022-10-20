Public Class Caja
    Public sqla As New Sqlcontrol
    Public acumulado As Double
    Private Sub Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        responsabletxt.Items.Add("Rodrigo Hernández")
        responsabletxt.Items.Add("Marisela Monsalve")
        responsabletxt.Items.Add("David Hernández")
        responsabletxt.Sorted = True

        sqla.execquery("select ID, Fecha, Responsable, Cantidad, Motivo, Sum(cantidad) over (order by ID) Acumulado from Caja order by ID desc")
        DataGridView2.DataSource = sqla.DBDT
        acumulado = sqla.DBDT.Rows(0).Item(5)
        sqla.execquery("select max (ID) from Caja")
        numerotxt.Text = sqla.DBDT.Rows(0).Item(0) + 1

        Acumuladobox.Text = acumulado.ToString("$#,##0")
        DataGridView2.Sort(DataGridView2.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        DataGridView2.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView2.Columns(5).DefaultCellStyle.Format = "$#,##0"





    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim nuevoacumulado As Double
        Dim monto As Double

        If deposito.Checked = True Then
            nuevoacumulado = acumulado + CDbl(montotxt.Text)
            monto = CDbl(montotxt.Text)
        Else
            nuevoacumulado = acumulado - CDbl(montotxt.Text)
            monto = CDbl(montotxt.Text) * -1
        End If

        ' Dim a = {{"@Numero", numerotxt.Text}, {"@Fecha", Now.Date + Now.TimeOfDay}, {"@Responsable", responsabletxt.Text}, {"@Monto", monto}, {"@Motivo", motivotxt.Text}}

        sqla.Addparam("@Numero", numerotxt.Text)
        sqla.Addparam("@Fecha", Now)
        sqla.Addparam("@Responsable", responsabletxt.Text)
        sqla.Addparam("@Monto", monto)
        sqla.Addparam("@Motivo", motivotxt.Text)


        'sqla.Addparam(a)


        sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, @Motivo); ")
        If sqla.Masexception(True) Then Exit Sub

        MsgBox("Ingresado", Title:="Caja")




        sqla.execquery("select ID, Fecha, Responsable, Cantidad, Motivo, Sum(cantidad) over (order by ID) Acumulado from Caja order by ID desc")
        DataGridView2.DataSource = sqla.DBDT
        acumulado = sqla.DBDT.Rows(0).Item(5)
        Acumuladobox.Text = acumulado.ToString("$#,##0")

        DataGridView2.Sort(DataGridView2.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        sqla.execquery("select max (ID) from Caja")
        numerotxt.Text = sqla.DBDT.Rows(0).Item(0) + 1
        responsabletxt.ResetText()
        montotxt.Clear()
        motivotxt.Clear()


    End Sub
End Class