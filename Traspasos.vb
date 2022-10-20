Imports ClasesLibreria

Public Class Traspasos
    Public sqla As New Sqlcontrol
    Private Sub Traspasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("Select 2 posicion, Nombre + ' ' + Apellido Nombre, ID  from Personal where Especialidad <> 'ELEVADOR'
union
Select 1 posicion,'-Seleccionar-', '-Seleccionar-'
order by posicion asc")



        Dim list As List(Of Personal) = New List(Of Personal)()

        For Each row As DataRow In sqla.DBDT.Rows
            Dim persona As Personal = New Personal()
            persona.Nombre = row.Item(1)
            persona.Rut = row.Item(2)

            list.Add(persona)
        Next

        Persona.DisplayMember = "Nombre"
        Persona.ValueMember = "Rut"
        Persona.DataSource = list
    End Sub



    Private Sub finalizarbtn_Click(sender As Object, e As EventArgs) Handles finalizarbtn.Click
        sqla.Addparam("@IDEmpleado", Persona.SelectedValue)
        sqla.Addparam("@Monto", Monto.Text)
        sqla.Addparam("@Origen", Origen.Text)
        sqla.Addparam("@Fecha", DateTime.Now)
        sqla.Addparam("@Estado", "Abierta")
        sqla.Addparam("@Comentarios", Detalles.Text)
        sqla.execquery("Insert into Traspasos (IDEmpleado, Monto, Origen, Fecha, Estado, Comentarios) Values (@IDEmpleado, @Monto, @Origen, @Fecha, @Estado, @Comentarios)")
        If sqla.Masexception(True) Then Exit Sub
        If Origen.Text = "CAJA" Then
            sqla.execquery("select max (ID) from Caja")
            Dim numero As Double = sqla.DBDT.Rows(0).Item(0) + 1

            sqla.Addparam("@Numero", numero)
            sqla.Addparam("@Fecha", DateTime.Now)
            sqla.Addparam("@Responsable", Persona.Text)
            sqla.Addparam("@Monto", CDbl(Monto.Text) * -1)
            sqla.Addparam("@Motivo", Detalles.Text)


            sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@Numero, @Fecha, @Responsable, @Monto, @Motivo); ")

        End If

        MsgBox("Traspaso ingresado", Title:="Traspasos")
        Close()
    End Sub
End Class