Public Class ActualizarMecanico
    Private Sub ActualizarMecanico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trabajos.sqla.execquery("Select Nombre + ' ' + Apellido Nombre, ID, 1 Orden from Personal where Especialidad = 'MECÁNICO AUTOMOTRIZ'
                        union
                        Select '-Seleccionar-','Seleccionar', 0 Orden
                        order by Orden")

        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"
        ComboBox1.DataSource = Trabajos.sqla.DBDT
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Trabajos.sqla.Addparam("@OT", otbox.Text)
        Trabajos.sqla.Addparam("@Texto", ComboBox1.Text)
        Trabajos.sqla.execquery("Update Registro set Mecanico = @Texto where OT = @OT")
        Me.Close()
    End Sub
End Class