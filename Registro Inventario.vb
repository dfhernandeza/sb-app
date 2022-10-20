Public Class Registro_Inventario
    Public sqla As New Sqlcontrol
    Public ii As Integer
    Private Sub Registro_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("Select ID, Item, Stock from Inventario")
        DataGridView2.DataSource = sqla.DBDT
        DataGridView1.Columns.Add("IdItem", "ID")
        DataGridView1.Columns.Add("Item", "Item")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        TextBox2.Text = DateTime.Now
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim contador As Integer = 0
        sqla.Addparam("@Cod", TextBox1.Text)
        sqla.execquery("Select ID, Item from Inventario where ID = @Cod")
        Dim a As Integer = sqla.DBDT.Rows.Count
        If sqla.DBDT.Rows.Count > 0 Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = sqla.DBDT.Rows(0).Item(0) Then
                    DataGridView1.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value + 1
                    contador = contador + 1
                End If
            Next
            If contador = 0 Then
                DataGridView1.Rows.Add()
                DataGridView1.Rows(ii).Cells(0).Value = sqla.DBDT.Rows(0).Item(0)
                DataGridView1.Rows(ii).Cells(1).Value = sqla.DBDT.Rows(0).Item(1)
                DataGridView1.Rows(ii).Cells(2).Value = 1

                ii = ii + 1
            End If
            TextBox1.Clear()
        End If









    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim letras As String
        letras = TextBox4.Text
        sqla.execquery("SELECT ID, Item, Stock FROM Inventario where Item like'" & "%" + letras + "%" & "'")
        DataGridView2.DataSource = sqla.DBDT
    End Sub


    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim i, j As Integer


            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = DataGridView2.Rows(e.RowIndex).Cells(0).Value Then
                    DataGridView1.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value + 1
                    j = j + 1
                End If
            Next
            If j = 0 Then
                DataGridView1.Rows.Add()
                DataGridView1.Rows(ii).Cells(0).Value = DataGridView2.Rows(e.RowIndex).Cells(0).Value
                DataGridView1.Rows(ii).Cells(1).Value = DataGridView2.Rows(e.RowIndex).Cells(1).Value
                DataGridView1.Rows(ii).Cells(2).Value = 1

                ii = ii + 1

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            sqla.Addparam("@fecha", DateTime.Now)
            sqla.Addparam("@IdItem", DataGridView1.Rows(i).Cells(0).Value)
            sqla.Addparam("@Item", DataGridView1.Rows(i).Cells(1).Value)
            sqla.Addparam("@Cantidad", DataGridView1.Rows(i).Cells(2).Value)
            sqla.Addparam("@Responsable", ComboBox1.Text)
            sqla.Addparam("@OT", TextBox3.Text)
            sqla.execquery("Insert into RegistroInventario (Fecha, IdItem, Item, Cantidad, Responsable, OT) values (@fecha, @IdItem, @Item, @Cantidad, @Responsable, @OT) ")
            If sqla.Masexception(True) Then Exit Sub

            sqla.Addparam("@IdItem", DataGridView1.Rows(i).Cells(0).Value)
            sqla.Addparam("@Cantidad", DataGridView1.Rows(i).Cells(2).Value)
            sqla.execquery("Update inventario set Stock = Stock - @Cantidad where ID = @IdItem ")
            If sqla.Masexception(True) Then Exit Sub

        Next
        MsgBox("Transacción Registrada", Title:="Inventario")
        MsgBox("Inventario Actualizado", Title:="Inventario")

        'sqla.execquery("Select * from RegistroInventario")
        ' RegistrodelInventario.DataGridView1.DataSource = Nothing
        ' RegistrodelInventario.DataGridView1.DataSource = sqla.DBDT
        ' RegistrodelInventario.DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Descending)



    End Sub
End Class