Public Class CotizacionesPendientes
    Public sql As New Sqlcontrol
    Public header As New CheckBox
    Private Sub CotizacionesPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVP.Columns(0).DefaultCellStyle.Format = "dd-MM-yyyy"


        'header.Size = New Size(15, 15)

        Dim headerCellLocation As Point = Me.DGVP.GetCellDisplayRectangle(5, -1, True).Location
        Dim punto As Integer = Me.DGVP.GetCellDisplayRectangle(5, -1, True).Width
        'Place the Header CheckBox in the Location of the Header Cell.
        header.Location = New Point(headerCellLocation.X + punto / 2 - 9, headerCellLocation.Y + 2)
        header.BackColor = Color.White
        Header.Size = New Size(18, 18)



        AddHandler Header.Click, AddressOf Header_Clicked
        DGVP.Controls.Add(Header)
        AddHandler DGVP.CellContentClick, AddressOf dgvp_CellClick
        Llenar()



    End Sub
    Public Sub Llenar()
        sql.execquery("Select Fecha, Cotizacion, Clientes.Nombre + ' ' + Clientes.Apellido, Item, CodItem from Cotizaciones inner join Clientes on Cotizaciones.IDCLiente = Clientes.ID where Cotizado is null and (CodItem = '20202' or CodItem = '20203' or CodItem = '20204' or CodItem = '20205' or CodItem = '20206' or CodItem = '20207' or CodItem = '20208')")


        For Each fila As DataRow In sql.DBDT.Rows
            With DGVP

                .Rows.Add(fila.ItemArray)

            End With

        Next



    End Sub


    Private Sub Header_Clicked(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary to end the edit mode of the Cell.
        DGVP.EndEdit()

        'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
        If header.Checked = True Then
            For Each row As DataGridViewRow In DGVP.Rows
                row.Cells(5).Value = True




            Next


        Else
            For Each row As DataGridViewRow In DGVP.Rows
                row.Cells(5).Value = False




            Next




        End If






    End Sub


    Private Sub dgvp_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        'Check to ensure that the row CheckBox is clicked.
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then

            'Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In DGVP.Rows
                If Convert.ToBoolean(row.Cells(5).EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If
            Next

            header.Checked = isChecked
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        For Each fila As DataGridViewRow In DGVP.Rows
            If fila.Cells(5).Value = True Then

                sql.Addparam("@COD", fila.Cells(4).Value)
                sql.Addparam("@COT", fila.Cells(1).Value)
                sql.Addparam("@Item", fila.Cells(3).Value)
                sql.execquery("Update Cotizaciones set Cotizado = 'SI' where Cotizacion = @COT and CodItem = @COD and Item = @Item")
                If sql.Masexception(True) Then Exit Sub
            End If

        Next
        MsgBox("Actualizado", Title:="Pendientes")




        DGVP.Rows.Clear()
        Llenar()
    End Sub







End Class