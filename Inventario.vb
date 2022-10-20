

Public Class Inventario
    Public sqla As New Sqlcontrol
    Public Sub Loadgrid()
        DataGridView1.Rows.Clear()
        sqla.execquery("SELECT * FROM Inventario where ID <> '20201' and ID <> '20202' and  ID <> '20203' and ID <> '20204' and ID <> '20205' and  ID <> '20206' and ID <> '20207' and ID <> '20208';")

        For Each row As DataRow In sqla.DBDT.Rows
            DataGridView1.Rows.Add(row.ItemArray)

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Dim Check As New DataGridViewCheckBoxColumn
        With DataGridView1
            .Columns.Add("ID", "ID")
            .Columns.Add("Item", "Item")
            .Columns.Add("Categoria", "Categoria")
            .Columns.Add("PVenta", "PVenta")
            .Columns.Add("PCompra", "PCompra")
            .Columns.Add("Stock", "Stock")
            .Columns.Add("StockInicial", "Stock Inicial")
            .Columns.Add("Adiciones", "Adiciones")
            .Columns.Add("FechaControl", "FechaControl")
            .Columns.Add("StockFinal", "Stock Final")
            .Columns.Add(Check)
            .Columns(10).Name = "Check"
            .Columns(3).ValueType = GetType(System.Double)
            .Columns(4).ValueType = GetType(System.Double)
        End With


        Loadgrid()
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("Item")
        ComboBox1.Items.Add("Tipo")
        ComboBox1.Items.Add("Categoria")
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

        DataGridView1.Columns(3).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(4).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "0.#####"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loadgrid()

        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)


    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim letras As String
        letras = TextBox1.Text
        If ComboBox1.Text = "Item" Then
            sqla.execquery("SELECT * FROM Inventario where Item like'" & "%" + letras + "%" & "' and ID <> '20201' and ID <> '20202' and  ID <> '20203' and ID <> '20204' and ID <> '20205' and  ID <> '20206' and ID <> '20207' and ID <> '20208'")
            DataGridView1.Rows.Clear()

            For Each row As DataRow In sqla.DBDT.Rows
                DataGridView1.Rows.Add(row.ItemArray)




            Next
        End If

        If ComboBox1.Text = "ID" Then
            sqla.execquery("SELECT * FROM Inventario where ID like'" & letras + "%" & "' and ID <> '20201' and ID <> '20202' and  ID <> '20203' and ID <> '20204' and ID <> '20205' and  ID <> '20206' and ID <> '20207' and ID <> '20208'")
            DataGridView1.Rows.Clear()

            For Each row As DataRow In sqla.DBDT.Rows
                DataGridView1.Rows.Add(row.ItemArray)

            Next
        End If



        If ComboBox1.Text = "Categoria" Then
            sqla.execquery("SELECT * FROM Inventario where Categoria like'" & letras + "%" & "' and ID <> '20201' and ID <> '20202' and  ID <> '20203' and ID <> '20204' and ID <> '20205' and  ID <> '20206' and ID <> '20207' and ID <> '20208'")
            DataGridView1.Rows.Clear()

            For Each row As DataRow In sqla.DBDT.Rows
                DataGridView1.Rows.Add(row.ItemArray)

            Next
        End If


    End Sub

    Private Sub NuevoItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoItemToolStripMenuItem.Click
        NuevoItem.Show()

    End Sub

    Private Sub BorrarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarItemToolStripMenuItem.Click
        EliminarItem.Show()
    End Sub

    Private Sub ActualizarStoclToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarStoclToolStripMenuItem.Click
        NuevoStock.Show()

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub InventariarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariarToolStripMenuItem.Click
        Inventariar.Show()

    End Sub

    Private Sub RegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroToolStripMenuItem.Click
        RegistrodelInventario.Show()
    End Sub

    Private Sub abrircotbtn_Click(sender As Object, e As EventArgs) Handles abrircotbtn.Click
        EditarItem.Show()


        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells(10).Value = True Then
                EditarItem.IDTextBox.Text = fila.Cells(0).Value
                EditarItem.ItemTextBox.Text = fila.Cells(1).Value
                EditarItem.CategoriaTextBox.Text = fila.Cells(2).Value
                EditarItem.VentaTextBox.Text = Decimal.Parse(fila.Cells(3).Value).ToString("0.#####")
                EditarItem.CompraTextBox.Text = Decimal.Parse(fila.Cells(4).Value).ToString("0.#####")
                EditarItem.StockTextBox.Text = Decimal.Parse(fila.Cells(5).Value).ToString("0.#####")
                Exit For
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns.Count - 1 Then

            For Each fila As DataGridViewRow In DataGridView1.Rows
                fila.Cells(e.ColumnIndex).Value = False

            Next
            DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True



        End If
    End Sub
End Class
