Public Class CostoServicios
    Public sqla As New Sqlcontrol
    Private Sub CostoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MdiParent = Principal
        sqla.execquery("Select distinct OT from ventas inner join inventario on ventas.CodItem = Inventario.ID where ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID = '20201'")
        For Each fila As DataRow In sqla.DBDT.Rows
            OTComboBox.Items.Add(fila.Item(0))
        Next

        sqla.execquery("Select Nombre + ' ' + Apellido Nombre, ID from Personal")
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"

        ComboBox1.DataSource = sqla.DBDT





        With DataGridView1
            .Columns.Add("IDRecurso", "Rut")
            .Columns.Add("Servicio", "Servicio")
            .Columns.Add("Horas", "Horas")
            .Columns.Add("IDVenta", "ID Venta")
        End With

    End Sub

    Private Sub OTComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OTComboBox.SelectedIndexChanged
        ItemComboBox.Items.Clear()
        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select distinct Ventas.Item from Ventas inner join inventario on ventas.CodItem = Inventario.ID where Ventas.OT = @OT and ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID = '20201'")
        For Each fila As DataRow In sqla.DBDT.Rows
            ItemComboBox.Items.Add(fila.Item(0))
        Next

        sqla.Addparam("@Ot", OTComboBox.Text)
        sqla.execquery("Select Vehiculo, Patente, Detalles from Registro where OT = @OT")

        If sqla.DBDT.Rows.Count = 0 Then Exit Sub

        If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
            TextBox3.Text = sqla.DBDT.Rows(0).Item(0)
        End If
        If Not IsDBNull(sqla.DBDT.Rows(0).Item(1)) Then
            TextBox4.Text = sqla.DBDT.Rows(0).Item(1)
        End If
        If Not IsDBNull(sqla.DBDT.Rows(0).Item(2)) Then
            TextBox5.Text = sqla.DBDT.Rows(0).Item(2)
        End If

        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select Personal.ID, Registro.Mecanico Nombre from Personal inner join Registro on Personal.Nombre + ' ' + Personal.Apellido = Registro.Mecanico where OT = @OT")

        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"

        ComboBox1.DataSource = sqla.DBDT



    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged
        sqla.Addparam("@Item", ItemComboBox.Text)
        sqla.Addparam("@OT", OTComboBox.Text)
        sqla.execquery("Select IDVenta from Ventas where OT = @OT and Item = @Item")
        IDVentabox.Text = sqla.DBDT.Rows(0).Item(0)
        HHBox.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With DataGridView1
            .Rows.Add({ComboBox1.SelectedValue, ItemComboBox.Text, HHBox.Text, IDVentabox.Text})

        End With

        'ItemComboBox.Items.RemoveAt(ItemComboBox.SelectedIndex)
        ItemComboBox.ResetText()
        IDVentabox.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valorhh As Double
        Dim ot As String
        Dim mpago As String
        Dim totalmixto As Double
        Dim porcentaje As Decimal
        Dim horas As Double
        Dim totalot As Double
        Dim otropago As String
        For Each fila As DataGridViewRow In DataGridView1.Rows
            sqla.Addparam("@IDVenta", fila.Cells(3).Value)
            sqla.execquery("Select Pago, MedioPago, OT from Ventas where IDVenta = @IDVenta")
            ot = sqla.DBDT.Rows(0).Item(2)

            If IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                otropago = "NORMAL"
            ElseIf sqla.DBDT.Rows(0).Item(0) = "MIXTO" Then
                otropago = "MIXTO"
            Else
                otropago = "NORMAL"
            End If

            If otropago = "MIXTO" Then

                sqla.Addparam("@OT", ot)
                sqla.execquery("Select IDVenta, MedioPago from ventas where OT = @OT and Pago = 'MIXTO' AND CodItem =  '20201'")
                For Each item As DataRow In sqla.DBDT.Rows

                    mpago = item.Item(1)
                    sqla.Addparam("@OT", ot)
                    sqla.Addparam("@mpago", mpago)
                    sqla.execquery("Select sum(total) from ventas where OT = @OT and MedioPago = @mpago")
                    totalmixto = sqla.DBDT.Rows(0).Item(0)
                    sqla.Addparam("@OT", ot)
                    sqla.execquery("Select sum(total) from ventas where OT= @OT")
                    totalot = sqla.DBDT.Rows(0).Item(0)
                    porcentaje = totalmixto / totalot
                    horas = porcentaje * fila.Cells(2).Value
                    sqla.Addparam("@Rut", fila.Cells(0).Value)
                    sqla.execquery("Select CostoHH from Personal where ID = @Rut")
                    valorhh = sqla.DBDT.Rows(0).Item(0)


                    sqla.Addparam("@Rut", fila.Cells(0).Value)
                    sqla.Addparam("@IDVenta", item.Item(0))
                    sqla.Addparam("@Horas", CDec(horas))
                    sqla.Addparam("@ValorHH", valorhh)
                    sqla.execquery("Insert into HH (IDRecurso,IDVenta,Horas,ValorHH) Values (@Rut, @IDVenta, @Horas, @ValorHH)")
                    If sqla.Masexception(True) Then Exit Sub




                Next


            Else
                sqla.Addparam("@Rut", fila.Cells(0).Value)
                sqla.execquery("Select CostoHH from Personal where ID = @Rut")
                valorhh = sqla.DBDT.Rows(0).Item(0)
                sqla.Addparam("@Rut", fila.Cells(0).Value)
                sqla.Addparam("@IDVenta", fila.Cells(3).Value)
                sqla.Addparam("@Horas", CDec(fila.Cells(2).Value))
                sqla.Addparam("@ValorHH", valorhh)

                sqla.execquery("Insert into HH (IDRecurso,IDVenta,Horas,ValorHH) Values (@Rut, @IDVenta, @Horas, @ValorHH)")
                If sqla.Masexception(True) Then Exit Sub
            End If
        Next


        If MsgBox("Horas Hombre ingresadas, ¿Desea continuar?", MsgBoxStyle.YesNo, Title:="Horas Hombre") = "7" Then
            Me.Close()
        Else
            ComboBox1.ResetText()

            OTComboBox.ResetText()
            ItemComboBox.ResetText()
            IDVentabox.Clear()
            HHBox.Clear()
            DataGridView1.Rows.Clear()
            OTComboBox.Items.Clear()
            sqla.execquery("Select distinct OT from ventas inner join inventario on ventas.CodItem = Inventario.ID where ([dbo].[Costo]([IDVenta])) is Null and Inventario.ID = '20201'")
            For Each fila As DataRow In sqla.DBDT.Rows
                OTComboBox.Items.Add(fila.Item(0))
            Next
        End If


    End Sub



End Class