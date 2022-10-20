Imports ClasesLibreria
Public Class Clientes
    Public sqla As New Sqlcontrol
    Public metodos As New ClasesLibreria.Funciones
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        Llenar()
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("Apellido")
        ComboBox1.Items.Add("Nombre")

    End Sub
    Public Sub Llenar()

        sqla.execquery("Select ID, IdCliente,Nombre, 
                        case 
                        when Apellido is null then ' ' 
                        else Apellido
                        end as Apellido,
                        case 
                        when Email is null then 'No registrado' 
                        else Email
                        end as Email,
                        case 
                        when Fono is null then 'No registrado' 
                        else Fono
                        end as Fono,
                        case 
                        when FechaIngreso is null then '' 
                        else FechaIngreso
                        end as FechaIngreso,
                        case
                        when Procedencia is null then 'No registrado' 
                        else Procedencia
                        end as Procedencia
                        from Clientes")
        For Each fila As DataRow In sqla.DBDT.Rows
            DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5), fila.Item(6), fila.Item(7)})
        Next
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = UCase(TextBox2.Text)
        DGVClientes.Rows.Clear()
        Dim letras As String
        letras = TextBox2.Text
        If ComboBox1.Text = "Nombre" Then
            sqla.execquery("Select ID, IdCliente,Nombre, 
                        case 
                        when Apellido is null then ' ' 
                        else Apellido
                        end as Apellido,
                        case 
                        when Email is null then 'No registrado' 
                        else Email
                        end as Email,
                        case 
                        when Fono is null then 'No registrado' 
                        else Fono
                        end as Fono,
                        case 
                        when FechaIngreso is null then '' 
                        else FechaIngreso
                        end as FechaIngreso,
                        case
                        when Procedencia is null then 'No registrado' 
                        else Procedencia
                        end as Procedencia
                        from Clientes where Nombre like'" & letras + "%" & "'")
            For Each fila As DataRow In sqla.DBDT.Rows
                DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5), fila.Item(6), fila.Item(7)})
            Next

        End If

        If ComboBox1.Text = "ID" Then
            sqla.execquery("Select ID, IdCliente,Nombre, 
                        case 
                        when Apellido is null then ' ' 
                        else Apellido
                        end as Apellido,
                        case 
                        when Email is null then 'No registrado' 
                        else Email
                        end as Email,
                        case 
                        when Fono is null then 'No registrado' 
                        else Fono
                        end as Fono,
                        case 
                        when FechaIngreso is null then '' 
                        else FechaIngreso
                        end as FechaIngreso,
                        case
                        when Procedencia is null then 'No registrado' 
                        else Procedencia
                        end as Procedencia
                        from Clientes where IdCliente like'" & letras + "%" & "'")
            For Each fila As DataRow In sqla.DBDT.Rows
                DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5), fila.Item(6), fila.Item(7)})
            Next
        End If



        If ComboBox1.Text = "Apellido" Then
            sqla.execquery("Select ID, IdCliente,Nombre, 
                        case 
                        when Apellido is null then ' ' 
                        else Apellido
                        end as Apellido,
                        case 
                        when Email is null then 'No registrado' 
                        else Email
                        end as Email,
                        case 
                        when Fono is null then 'No registrado' 
                        else Fono
                        end as Fono,
                        case 
                        when FechaIngreso is null then '' 
                        else FechaIngreso
                        end as FechaIngreso,
                        case
                        when Procedencia is null then 'No registrado' 
                        else Procedencia
                        end as Procedencia
                        from Clientes where Apellido like'" & letras + "%" & "'")
            For Each fila As DataRow In sqla.DBDT.Rows
                DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5), fila.Item(6), fila.Item(7)})
            Next
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DGVClientes.Rows.Clear()
        sqla.execquery("Select ID, IdCliente,Nombre, 
                        case 
                        when Apellido is null then ' ' 
                        else Apellido
                        end as Apellido,
                        case 
                        when Email is null then 'No registrado' 
                        else Email
                        end as Email,
                        case 
                        when Fono is null then 'No registrado' 
                        else Fono
                        end as Fono,
                        case 
                        when FechaIngreso is null then '' 
                        else FechaIngreso
                        end as FechaIngreso,
                        case
                        when Procedencia is null then 'No registrado' 
                        else Procedencia
                        end as Procedencia
                        from Clientes")
        For Each fila As DataRow In sqla.DBDT.Rows
            DGVClientes.Rows.Add({fila.Item(0), metodos.FormatRutView(fila.Item(1).ToString()), fila.Item(2), fila.Item(3), fila.Item(4), fila.Item(5), fila.Item(6), fila.Item(7)})
        Next
        DGVClientes.Sort(DGVClientes.Columns(2), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub EliminarBtn_Click(sender As Object, e As EventArgs) Handles EliminarBtn.Click
        For Each fila As DataGridViewRow In DGVClientes.Rows
            If fila.Cells(8).Value = True Then
                If MsgBox("¿Confirma que desea eliminar a " + fila.Cells(2).Value + " " + fila.Cells(3).Value + "?", MsgBoxStyle.YesNo, Title:="Clientes") = "6" Then

                    sqla.Addparam("@ID", fila.Cells(0).Value)
                    sqla.execquery("Delete from Clientes where ID = @ID")
                    sqla.Masexception(True)
                    MsgBox("Cliente eliminado satisfactoriamente", Title:="Clientes")
                    DGVClientes.Rows.Remove(fila)

                End If
                Exit For
            End If

        Next
    End Sub

    Private Sub EditarBtn_Click(sender As Object, e As EventArgs) Handles EditarBtn.Click

        For Each fila As DataGridViewRow In DGVClientes.Rows
            If fila.Cells(8).Value = True Then
                With NuevoCliente
                    .Show()
                    .Text = "Editar Cliente"

                    .idinternabox.Text = fila.Cells(0).Value
                    .IDTextBox.Text = fila.Cells(1).Value

                    .NomTextBox.Text = fila.Cells(2).Value

                    .ApellidoTextBox.Text = fila.Cells(3).Value
                    .MailTextBox.Text = fila.Cells(4).Value
                    .FonoTextBox.Text = fila.Cells(5).Value
                    .fechatxt.Text = fila.Cells(6).Value
                    .ComboBox1.Text = fila.Cells(7).Value

                End With


                Exit For
            End If



        Next
    End Sub

    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoClienteToolStripMenuItem.Click
        NuevoCliente.Show()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        If e.ColumnIndex = DGVClientes.Columns.Count - 1 Then
            For Each fila As DataGridViewRow In DGVClientes.Rows
                fila.Cells(e.ColumnIndex).Value = False
            Next
            DGVClientes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
        End If
    End Sub
End Class