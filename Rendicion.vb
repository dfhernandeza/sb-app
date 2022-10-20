Imports ClasesLibreria

Public Class Rendicion
    Public sqla As New Sqlcontrol
    Private Sub Rendicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("Select '-Seleccionar-' Nombre, 'Seleccionar' Rut, 1 posicion union
Select distinct Personal.Nombre + ' ' + Personal.Apellido Nombre, Traspasos.IDEmpleado Rut, 2 posicion from Personal inner Join Traspasos on Personal.ID = Traspasos.IDEmpleado where Traspasos.Estado = 'Abierta'
order by posicion asc")



        Dim list As List(Of Personal) = New List(Of Personal)()

        For Each row As DataRow In sqla.DBDT.Rows
            Dim persona As Personal = New Personal()
            persona.Nombre = row.Item(0)
            persona.Rut = row.Item(1)

            list.Add(persona)
        Next

        Persona.DisplayMember = "Nombre"
        Persona.ValueMember = "Rut"
        Persona.DataSource = list
        DetalleDGV.Columns(4).ValueType = GetType(System.Decimal)
        DetalleDGV.Columns(6).ValueType = GetType(System.Double)

        DetalleDGV.Columns(4).DefaultCellStyle.Format = "$#,##0"
        DetalleDGV.Columns(6).DefaultCellStyle.Format = "$#,##0"
    End Sub

    Private Sub Persona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Persona.SelectedIndexChanged
        sqla.Addparam("@ID", Persona.SelectedValue)
        sqla.execquery("Select cast(format(Fecha,'dd/MM/yyyy') as nvarchar) + ' / '+ cast(format(Monto,'C0') as nvarchar) Transferencia, ID from Traspasos where IDEmpleado = @ID and Estado = 'Abierta'  ")

        Traspaso.DisplayMember = "Transferencia"
        Traspaso.ValueMember = "ID"

        Traspaso.DataSource = sqla.DBDT

    End Sub

    Private Sub Traspaso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Traspaso.SelectedIndexChanged
        sqla.Addparam("@ID", Traspaso.SelectedValue)
        sqla.execquery("Select Monto, Origen from Traspasos where ID = @ID")
        Dim monto As Double = sqla.DBDT.Rows(0).Item(0)
        origenbox.Text = sqla.DBDT.Rows(0).Item(1)
        montototalbox.Text = monto.ToString("$#,##0")
    End Sub

    Private Sub NuevoItemBtn_Click(sender As Object, e As EventArgs) Handles NuevoItemBtn.Click
        NuevoItemRendicion.Show()
    End Sub

    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click
        If DetalleDGV.Rows.Count = 0 Then
            Exit Sub
        End If
        For Each fila As DataGridViewRow In DetalleDGV.Rows
            sqla.Addparam("@IDTraspaso", Traspaso.SelectedValue)
            sqla.Addparam("@Documento", fila.Cells(0).Value)
            sqla.Addparam("@COD", fila.Cells(1).Value)

            sqla.Addparam("@Fecha", DateTime.Now)
            sqla.Addparam("@Item", fila.Cells(2).Value)
            sqla.Addparam("@Cantidad", fila.Cells(3).Value)
            sqla.Addparam("@Precio", fila.Cells(4).Value)
            sqla.Addparam("@Categoria", fila.Cells(7).Value)
            If origenbox.Text = "CAJA" Then
                sqla.Addparam("@MPago", "EFECTIVO")
            Else
                sqla.Addparam("@MPago", origenbox.Text)
            End If

            sqla.Addparam("@Proveedor", fila.Cells(8).Value)
            sqla.Addparam("@OT", fila.Cells(5).Value)

            sqla.execquery("Insert into Compras (IDTraspaso, Factura, Fecha, COD,  Nombre, Cantidad, Precio, FPago, Proveedor, Categoria, OT) Values (@IDTraspaso, @Documento, @Fecha, @COD, @Item, @Cantidad, @Precio, @MPago, @Proveedor, @Categoria, @OT)")
            sqla.Masexception(True)


            sqla.Addparam("@IDItem", fila.Cells(1).Value)
            sqla.execquery("Select Item from Inventario where ID = @IDItem")

            If Not sqla.DBDT.Rows.Count = 0 Then
                Dim pregunta As String = MsgBox("Se ha detectado " & sqla.DBDT.Rows(0).Item(0).ToString & " en el Inventario, ¿Desea actualizar stock? ", MsgBoxStyle.YesNo, Title:="Compra")
                If pregunta = "6" Then
                    sqla.Addparam("@IDItem", fila.Cells(1).Value)
                    sqla.Addparam("@Cantidad", fila.Cells(3).Value)
                    sqla.execquery("Update Inventario Set Stock= Stock + @Cantidad, Adiciones = Adiciones + @Cantidad  Where ID = @IDItem")
                    sqla.Masexception(True)

                End If

            End If

        Next



        sqla.execquery("select max (ID) from Caja")
            Dim numero As Double = sqla.DBDT.Rows(0).Item(0) + 1
            sqla.Addparam("@ID", numero)
            sqla.Addparam("@Fecha", DateTime.Now)
            sqla.Addparam("@Responsable", Persona.Text)
            sqla.Addparam("@Monto", CDbl(diferenciabox.Text))
            sqla.Addparam("@Motivo", "DIFERENCIA TRASPASO")
            sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@ID, @Fecha, @Responsable, @Monto, @Motivo); ")
            sqla.Masexception(True)


            sqla.Addparam("@IDTraspaso", Traspaso.SelectedValue)
        sqla.execquery("Update Traspasos Set Estado = 'Cerrada' where ID = @IDTraspaso")


        MsgBox("Rendición completada", Title:="Rendición")
        Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqla.Addparam("@IDTraspaso", Traspaso.SelectedValue)
        sqla.execquery("Update Traspasos Set Estado = 'Cerrada' where ID = @IDTraspaso")
        sqla.execquery("select max (ID) from Caja")
        Dim numero As Double = sqla.DBDT.Rows(0).Item(0) + 1
        sqla.Addparam("@ID", numero)
        sqla.Addparam("@Fecha", DateTime.Now)
        sqla.Addparam("@Responsable", Persona.Text)
        sqla.Addparam("@Monto", CDbl(montototalbox.Text))
        sqla.Addparam("@Motivo", "DEVOLUCIÓN")
        sqla.execquery("Insert into Caja (ID, Fecha, Responsable, Cantidad, Motivo) values (@ID, @Fecha, @Responsable, @Monto, @Motivo); ")
        sqla.Masexception(True)
        MsgBox("Rendición completada", Title:="Rendición")
        Close()
    End Sub
End Class