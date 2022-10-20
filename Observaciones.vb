Public Class Observaciones
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Trabajos.sqla.Addparam("@OT", otbox.Text)
        Trabajos.sqla.Addparam("@Texto", Observacionesbox.Text)
        Trabajos.sqla.execquery("Update Registro set Observaciones = @Texto where OT = @OT")
        Me.Close()
    End Sub
End Class