Public Class DetalleCompras
    Private Sub DetalleCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Dim subt, iva, total As Double

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            subt = subt + DataGridView1.Rows(i).Cells(6).Value
            iva = iva + DataGridView1.Rows(i).Cells(7).Value

            total = total + DataGridView1.Rows(i).Cells(8).Value


        Next

        TextBox1.Text = subt.ToString("$#,##0")
        TextBox3.Text = iva.ToString("$#,##0")
        TextBox4.Text = total.ToString("$#,##0")







        DataGridView1.Columns(6).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "$#,##0"
    End Sub
End Class