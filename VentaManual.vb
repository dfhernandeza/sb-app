Public Class VentaManual
    Private Sub VentaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As New DataTable
        a.Columns.Add("Nombre")
        a.Columns.Add("Codigo")
        a.Rows.Add({"SERVICIOS", "20201"})
        a.Rows.Add({"REPUESTOS", "20202"})
        a.Rows.Add({"FILTROS DE AIRE", "20203"})
        a.Rows.Add({"FILTROS DE ACEITE", "20204"})
        a.Rows.Add({"FILTROS DE COMBUSTIBLE", "20205"})
        a.Rows.Add({"FILTROS DE POLEN", "20206"})
        a.Rows.Add({"OTROS", "20207"})
        a.Rows.Add({"LUBRICANTES", "20208"})
        a.Rows.Add({"NEUMÁTICOS", "20209"})
        ComboBox1.ValueMember = "Codigo"
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.DataSource = a
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Double
        With VentaRapida.DGVDetalle
            VentaRapida.DGVDetalle.Rows.Add({ComboBox1.SelectedValue, TextBox1.Text, TextBox2.Text, CDbl(TextBox3.Text), TextBox3.Text * TextBox2.Text})
        End With

        For Each dr As DataGridViewRow In VentaRapida.DGVDetalle.Rows
            sum = sum + dr.Cells(4).Value
        Next
        VentaRapida.TextBox4.Text = sum.ToString("$#,##0")
        Me.Close()
    End Sub
End Class