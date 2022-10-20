
Public Class DetalleVentas
    Public metodos As New ClasesLibreria.Funciones
    Public sqla As New Sqlcontrol
    Private Sub DetalleVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MdiParent = Principal
        DataGridView1.Columns(5).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(7).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(8).DefaultCellStyle.Format = "$#,##0"
        DataGridView1.Columns(9).DefaultCellStyle.Format = "$#,##0"

        sqla.Addparam("@OT", DataGridView1.Rows(0).Cells(0).Value)
        sqla.execquery("Select Tipo from Ventas where OT= @OT")

        If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
            sqla.Addparam("@OT", DataGridView1.Rows(0).Cells(0).Value)
            sqla.execquery("Select Kilometraje, Detalles, Vehiculo from Registro where OT = @OT")

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = False Then
                TextBox2.Text = sqla.DBDT.Rows(0).Item(0)
                TextBox5.Text = sqla.DBDT.Rows(0).Item(1)
                TextBox6.Text = sqla.DBDT.Rows(0).Item(2)

            End If

            sqla.Addparam("@OT", DataGridView1.Rows(0).Cells(0).Value)
            sqla.execquery(" Select Clientes.IdCliente, Registro.Cliente From Clientes INNER Join Registro On Registro.IDCLiente = Clientes.ID Where Registro.OT = @OT ")
            If Not sqla.DBDT.Rows.Count = 0 Then
                TextBox7.Text = metodos.FormatRutView(sqla.DBDT.Rows(0).Item(0))
            End If
        End If
        SUMAR()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imprimir = "Detalle"
        Impresion.Show()
    End Sub
    Public Sub SUMAR()
        Dim sumart, sumari, sumarn As Long
        Dim x As Integer = DataGridView1.Rows.Count
        For i As Integer = 0 To x - 1
            sumart = sumart + DataGridView1.Rows(i).Cells(6).Value
            sumari = sumari + DataGridView1.Rows(i).Cells(7).Value
            sumarn = sumarn + DataGridView1.Rows(i).Cells(8).Value
        Next

        TextBox4.Text = sumart.ToString("$#,##0")
        TextBox3.Text = sumari.ToString("$#,##0")
        TextBox1.Text = sumarn.ToString("$#,##0")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim factura As Integer = InputBox("Ingrese N° de Factura", Title:="Factura")
        sqla.Addparam("@OT", DataGridView1.Rows(0).Cells(0).Value)
        sqla.Addparam("@factura", factura)
        sqla.execquery("update ventas set factura = @factura where OT = @OT")
    End Sub
End Class