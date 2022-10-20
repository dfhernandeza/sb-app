Imports ClasesLibreria

Public Class NuevoCliente
    Public sqlb As New Sqlcontrol
    Public cliente As New ClientesClase
    Public metodos As New ClasesLibreria.Funciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(IDTextBox.Text) = True Then
            MsgBox("Campo ID no puede dejarse en blanco", Title:="Nuevo Cliente")
            Exit Sub

        End If

        If IDTextBox.Text.Length < 6 Then
            MsgBox("ID Debe tener al menos 6 caracteres")
            Exit Sub
        End If


        If Text = "Editar Cliente" Then
            EditarCliente()
        ElseIf Text = "Actualizar Cliente" Then
            Actualizarcliente()
        Else
            creacliente()
        End If


    End Sub
    Private Sub Actualizarcliente()
        If String.IsNullOrWhiteSpace(ApellidoTextBox.Text) Then
            Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nom", NomTextBox.Text}, {"@Apellido", " "}, {"@Fono", FonoTextBox.Text}, {"@Mail", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        Else
            Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nom", NomTextBox.Text}, {"@Apellido", ApellidoTextBox.Text}, {"@Fono", FonoTextBox.Text}, {"@Mail", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        End If
        sqlb.execquery("INSERT INTO Clientes (IdCliente, Nombre, Apellido, Email, Fono, FechaIngreso, Procedencia) VALUES (@ID,@Nom,@Apellido,@Mail,@Fono,@Fecha,@Proce);")
        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Cliente creado exitosamente", Title:="Nuevo Cliente")
        Cotizacion.DGVClientes.Rows.Clear()
        sqlb.execquery("Select ID, IdCLiente, Nombre, Apellido from Clientes")
        If cotineumatico = "Coti" Then

            For Each fila As DataRow In sqlb.DBDT.Rows
                Cotizacion.DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
            Next
            Cotizacion.TextBox8.Text = idinternabox.Text
            Cotizacion.TextBox7.Text = IDTextBox.Text
            Cotizacion.TextBox3.Text = NomTextBox.Text + " " + ApellidoTextBox.Text
            sqlb.Addparam("@Cot", Cotizacion.TextBox2.Text)
            sqlb.Addparam("@IDCliente", idinternabox.Text)
            sqlb.execquery("UPDATE Cotizaciones SET IDCLiente = @IDCliente WHERE Cotizacion = @Cot; UPDATE CotGeneral SET IDCliente = @IDCliente WHERE Cotizacion = @Cot")
        Else
            For Each fila As DataRow In sqlb.DBDT.Rows
                CotiNeumaticos.DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
            Next
            CotiNeumaticos.IDClienteInternaBox.Text = idinternabox.Text
            CotiNeumaticos.RutClienteBox.Text = IDTextBox.Text
            CotiNeumaticos.ClienteBox.Text = NomTextBox.Text + " " + ApellidoTextBox.Text
            cotineumatico = Nothing
        End If
        Close()
    End Sub




    Private Sub creacliente()
        If String.IsNullOrWhiteSpace(ApellidoTextBox.Text) Then
            Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nom", NomTextBox.Text}, {"@Apellido", " "}, {"@Fono", FonoTextBox.Text}, {"@Mail", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        Else
            Dim a = {{"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nom", NomTextBox.Text}, {"@Apellido", ApellidoTextBox.Text}, {"@Fono", FonoTextBox.Text}, {"@Mail", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        End If
        sqlb.execquery("INSERT INTO Clientes (IdCliente, Nombre, Apellido, Email, Fono, FechaIngreso, Procedencia) VALUES (@ID,@Nom,@Apellido,@Mail,@Fono,@Fecha,@Proce);")
        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Cliente creado exitosamente", Title:="Nuevo Cliente")
        Cotizacion.DGVClientes.Rows.Clear()
        sqlb.execquery("Select ID, IdCLiente, Nombre, Apellido from Clientes")
        If cotineumatico = "Coti" Then

            For Each fila As DataRow In sqlb.DBDT.Rows
                Cotizacion.DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
            Next
            Cotizacion.TextBox8.Text = idinternabox.Text
            Cotizacion.TextBox7.Text = IDTextBox.Text
            Cotizacion.TextBox3.Text = NomTextBox.Text + " " + ApellidoTextBox.Text

        Else
            For Each fila As DataRow In sqlb.DBDT.Rows
                CotiNeumaticos.DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2).ToString(), fila.Item(3).ToString()})
            Next
            CotiNeumaticos.IDClienteInternaBox.Text = idinternabox.Text
            CotiNeumaticos.RutClienteBox.Text = IDTextBox.Text
            CotiNeumaticos.ClienteBox.Text = NomTextBox.Text + " " + ApellidoTextBox.Text
            cotineumatico = Nothing
        End If
        Close()
    End Sub

    Public Sub EditarCliente()
        If String.IsNullOrWhiteSpace(ApellidoTextBox.Text) Then
            Dim a = {{"@IDInterna", idinternabox.Text}, {"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nombre", NomTextBox.Text}, {"@Apellido", " "}, {"@Fono", FonoTextBox.Text}, {"@Email", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        Else
            Dim a = {{"@IDInterna", idinternabox.Text}, {"@ID", metodos.GetRut(IDTextBox.Text)}, {"@Nombre", NomTextBox.Text}, {"@Apellido", ApellidoTextBox.Text}, {"@Fono", FonoTextBox.Text}, {"@Email", MailTextBox.Text}, {"@Fecha", DateTime.Today}, {"@Proce", ComboBox1.Text}}
            sqlb.Addparam(a)
        End If

        sqlb.execquery("Update Clientes Set IdCliente = @ID, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Fono = @Fono, FechaIngreso = @Fecha, Procedencia = @Proce where ID = @IDInterna")
        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Cliente editado exitosamente", Title:="Clientes")
        Close()


    End Sub






    Private Sub NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fechatxt.Text = DateTime.Today

        sqlb.execquery("select * from clientes where ID = (select max(ID) from clientes)")
        idinternabox.Text = sqlb.DBDT.Rows(0).Item(0) + 1
        With ComboBox1.Items
            .Add("Facebook")
            .Add("Conocido")
            .Add("Tránsito")
            .Add("Antiguo Cliente")
            .Add("Google")
        End With
        ComboBox1.Sorted = True



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