Imports ClasesLibreria
Public Class NuevoEmpleado
    Public metodos As New ClasesLibreria.Funciones
    Public sqla As New Sqlcontrol
    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click
        If Text = "Actualizar Empleado" Then
            Dim a = {{"@ID", metodos.GetRut(idbox.Text)}, {"@Nombre", nombrebox.Text}, {"@Apellido", apellidobox.Text}, {"@Especialidad", especialidadbox.Text}, {"@CostoHH", costohhbox.Text}}
            sqla.Addparam(a)
            sqla.execquery("Update Personal Set ID = @ID, Nombre = @Nombre, Apellido = @Apellido, Especialidad = @Especialidad, CostoHH = @CostoHH where ID = @ID")
            sqla.Masexception(True)

            MsgBox("Empleado Actualizado", Title:="Personal")
        ElseIf Text = "Detalle Empleado" Then

            Close()
            Exit Sub
        Else
            Dim a = {{"@ID", metodos.GetRut(idbox.Text)}, {"@Nombre", nombrebox.Text}, {"@Apellido", apellidobox.Text}, {"@Especialidad", especialidadbox.Text}, {"@CostoHH", costohhbox.Text}}
            sqla.Addparam(a)
            sqla.execquery("Insert into Personal (ID, Nombre, Apellido, Especialidad, CostoHH) Values (@ID, @Nombre, @Apellido, @Especialidad, @CostoHH)")
            sqla.Masexception(True)

            MsgBox("Empleado Ingresado", Title:="Personal")


        End If
        Personalform.DGVPersonal.Rows.Clear()
        Personalform.Llenar()
        Close()
    End Sub



    Private Sub idbox_KeyUp(sender As Object, e As KeyEventArgs) Handles idbox.KeyUp
        metodos.FormateaRutTextBox(sender, e)
    End Sub


    Private Sub idbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idbox.KeyPress

        If Char.IsLetter(e.KeyChar) Then

            e.KeyChar = Char.ToUpper(e.KeyChar)

        End If
    End Sub
End Class