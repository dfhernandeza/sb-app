Public Class Inventariar
    Public sqla As New Sqlcontrol
    Public ii As Integer


    Private Sub Inventariar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        DataGridView1.Columns.Add("Cod", "Cod")
        DataGridView1.Columns.Add("Item", "Item")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        DataGridView1.Columns.Add("Sistema", "Sistema")
        fechatxtb.Text = DateTime.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each fila As DataGridViewRow In DataGridView1.Rows
            sqla.Addparam("@Cod", fila.Cells(0).Value)
            sqla.Addparam("@Stock", fila.Cells(2).Value)
            sqla.execquery("Update Inventario set StockFinal = StockFinal + @Stock  where ID = @Cod")

        Next
        MsgBox("Guardado", Title:="Inventario")
    End Sub



    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        CodTextBox.Select()
    End Sub



    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        CodTextBox.Select()
    End Sub

    Private Sub Inventariar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        '   If Me.CodTextBox.Focused = False Then
        '       CodTextBox.Focus()
        '       CodTextBox.Text = e.KeyChar.ToString
        '       CodTextBox.SelectionStart = CodTextBox.Text.Length
        '       e.Handled = True
        '   End If
    End Sub


    Private Sub CodTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CodTextBox.KeyDown
        Select Case e.KeyData
            Case Keys.Enter


                Dim contador As Integer = 0
                sqla.Addparam("@Cod", CodTextBox.Text)
                sqla.execquery("Select ID, Item, Stock from Inventario where ID = @Cod")
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
                        DataGridView1.Rows(ii).Cells(3).Value = sqla.DBDT.Rows(0).Item(2)
                        ii = ii + 1
                    End If



                    CodTextBox.Clear()

                End If
        End Select
    End Sub
End Class