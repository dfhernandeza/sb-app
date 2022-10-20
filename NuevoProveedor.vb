Public Class NuevoProveedor
    Public sqla As New Sqlcontrol
    Public metodos As New ClasesLibreria.Funciones
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Text = "Editar Proveedor" Then
            Editar()
        Else
            Insertar()
        End If
    End Sub
    Public Sub Insertar()
        Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nombre", NomTextBox.Text}, {"@Email", EmailTextBox.Text}, {"@Fono", FonoTextBox.Text}, {"@Direccion", DireccionTextBox.Text}, {"@Comentarios", Comentariostxt.Text}}


        sqla.Addparam(a)
        sqla.execquery("Insert into Proveedores (ID, Nombre, Email, Fono, Direccion, Comentarios) values (@ID, @Nombre, @Email, @Fono, @Direccion, @Comentarios); ")
        If sqla.Masexception(True) Then Exit Sub
        MsgBox("Proveedor Ingresado", Title:="Nuevo Proveedor")
        sqla.execquery("Select ID, Nombre, 1 Posicion from Proveedores union Select '-Seleccionar-', '-Seleccionar-', 0 Posicion order by Posicion, Nombre")
        NuevoItemRendicion.proveedorcbox.DataSource = sqla.DBDT
        NuevoItemRendicion.proveedorcbox.SelectedValue = IDTextBox.Text
        Me.Close()
    End Sub
    Public Sub Editar()
        Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nombre", NomTextBox.Text}, {"@Email", EmailTextBox.Text}, {"@Fono", FonoTextBox.Text}, {"@Direccion", DireccionTextBox.Text}, {"@Comentarios", Comentariostxt.Text}}
        sqla.Addparam(a)
        sqla.execquery("Update Proveedores Set ID = @ID, Nombre = @Nombre, Email = @Email, Fono = @Fono, Direccion = @Direccion, Comentarios = @Comentarios where ID = @ID; ")
        If sqla.Masexception(True) Then Exit Sub
        MsgBox("Proveedor Actualizado", Title:="Proveedores")
        Proveedores.DetalleDGV.Rows.Clear()
        Proveedores.Llenar()
        Me.Close()
    End Sub



    Private Sub IDTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles IDTextBox.KeyUp
        metodos.FormateaRutTextBox(sender, e)
    End Sub


    Private Sub IDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.KeyChar = Char.ToUpper(e.KeyChar)

        End If
    End Sub
End Class