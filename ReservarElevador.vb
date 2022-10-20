Public Class ReservarElevador
    Public sql As New Sqlcontrol

    Private Sub ReservarElevador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.execquery("Select Ot from Registro where Salida is Null")
        For Each fila As DataRow In sql.DBDT.Rows
            OTbox.Items.Add(fila.Item(0))
        Next


    End Sub

    Private Sub OTbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OTbox.SelectedIndexChanged
        sql.Addparam("@OT", OTbox.Text)
        sql.execquery("Select Vehiculo, Patente, Detalles from Registro where OT = @OT")
        marcabox.Text = sql.DBDT.Rows(0).Item(0)
        patentebox.Text = sql.DBDT.Rows(0).Item(1)
        detallesbox.Text = sql.DBDT.Rows(0).Item(2)

    End Sub
End Class