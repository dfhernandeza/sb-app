Public Class NuevoItemRendicion
    Public sqla As New Sqlcontrol
    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click
        Rendicion.DetalleDGV.Rows.Add({documentobox.Text, IDItembox.Text, itembox.Text, cantidadbox.Text, CDec(preciobox.Text), otcombobox.Text, CDbl(preciobox.Text) * CDec(cantidadbox.Text), Categoriacbox.Text, proveedorcbox.SelectedValue})
        Dim sum As Double

        For Each fila As DataGridViewRow In Rendicion.DetalleDGV.Rows
            sum = sum + fila.Cells(6).Value

        Next

        Rendicion.totalrendidobox.Text = (sum * 1.19).ToString("$#,##0")

        Dim diferencia As Double = CDbl(Rendicion.montototalbox.Text) - Rendicion.totalrendidobox.Text
        Rendicion.diferenciabox.Text = diferencia.ToString("$#,##0")
        Close()
    End Sub

    Private Sub NuevoItemRendicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("Select OT from Registro where salida is null Union Select 'Sin OT'")

        For Each fila As DataRow In sqla.DBDT.Rows
            otcombobox.Items.Add(fila.Item(0))

        Next

        proveedorcbox.ValueMember = "ID"
        proveedorcbox.DisplayMember = "Nombre"
        sqla.execquery("Select ID, Nombre, 1 Posicion from Proveedores union Select '-Seleccionar-', '-Seleccionar-', 0 Posicion order by Posicion, Nombre")
        proveedorcbox.DataSource = sqla.DBDT

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevoProveedor.Show()
    End Sub





    Private Sub otcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles otcombobox.SelectedIndexChanged
        sqla.Addparam("@OT", otcombobox.Text)
        sqla.execquery("Select Vehiculo, Patente, Detalles from Registro where OT = @OT")
        If sqla.DBDT.Rows.Count > 0 Then
            ToolTip1.SetToolTip(otcombobox, sqla.DBDT.Rows(0).Item(0) + " / " + sqla.DBDT.Rows(0).Item(1) + " / " + sqla.DBDT.Rows(0).Item(2))
        End If




    End Sub

    Private Sub otcombobox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles otcombobox.MouseDoubleClick
        Dim cursorPosition As Point = Me.otcombobox.PointToClient(Cursor.Position)


        otcombobox.Items(e.X).ToString()
    End Sub
End Class