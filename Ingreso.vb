
Imports Excel = Microsoft.Office.Interop.Excel
Imports ClasesLibreria
Public Class Ingreso
    Public sqla As New Sqlcontrol
    Public sqlb As New Sqlcontrol1
    Public Orden As Integer
    Public tabla As New DataTable
    Public z As Integer = 0
    Public metodos As New ClasesLibreria.Funciones

    Private Sub ingresa()

        If String.IsNullOrWhiteSpace(ComboBox2.Text) Then
            MsgBox("Ingresar Patente del Vehículo", Title:="Ingreso")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MsgBox("Ingresar Marca y Modelo del Vehículo", Title:="Ingreso")
            Exit Sub
        End If



        sqla.Addparam("@NIng", TextBox8.Text)
        sqla.Addparam("@OT", TextBox2.Text)
        sqla.Addparam("@Cot", TextBox6.Text)
        sqla.Addparam("@Cliente", TextBox9.Text)
        sqla.Addparam("@Patente", ComboBox2.Text)
        sqla.Addparam("@Vehiculo", TextBox4.Text)
        If String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) Then
            sqla.Addparam("@Kilometraje", TextBox5.Text)
        Else
            sqla.Addparam("@Kilometraje", CInt(TextBox5.Text))
        End If

        sqla.Addparam("@Ano", TextBox3.Text)
        sqla.Addparam("@Motor", TextBox11.Text)
        sqla.Addparam("@Hora", DateTime.Now)
        sqla.Addparam("@Mecanico", ComboBox1.Text)

        sqla.execquery("INSERT INTO Registro (NIngreso, OT, Cotizacion, Patente, Vehiculo, Kilometraje, Entrada, Mecanico, IDCliente, Ano, Motor) VALUES (@NIng,@OT,@Cot,@Patente,@Vehiculo,@Kilometraje,@Hora,@Mecanico, @Cliente, @Ano, @Motor);")





        If sqla.Masexception(True) Then Exit Sub
        MsgBox("Orden Ingresada", Title:="Registro")
        Me.Close()
        Trabajos.Show()
        'Programar.Show()
        'Programar.mecanicobox.Text = ComboBox1.Text
        'Programar.OTbox.Text = TextBox2.Text


        'Tareas.Show()
        'Tareas.BringToFront()
        'Programar.BringToFront()

        '' sqla.Addparam("Nombre", ComboBox1.Text)
        '' sqla.execquery("Select ID from Personal where Nombre + ' ' + Apellido = @Nombre ")
        'Me.Close()
        'Tareas.DGVTareas.Rows.Add({ComboBox1.SelectedValue})


        'Tareas.Borrar()
        'Tareas.Llenar()
        'Tareas.EncabezadoFila()



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ingresa()

    End Sub

    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqla.execquery("select max(OT) from Registro ")
        If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
            TextBox2.Text = 1

        Else
            TextBox2.Text = sqla.DBDT.Rows(0).Item(0) + 1

        End If


        sqla.execquery("select max(NIngreso) from Registro ")
        If IsDBNull(sqla.DBDT.Rows(0).Item(0)) = True Then
            TextBox8.Text = 1
        Else
            TextBox8.Text = sqla.DBDT.Rows(0).Item(0) + 1
        End If

        sqla.execquery("Select Nombre + ' ' + Apellido Nombre, ID, 1 Orden from Personal where Especialidad = 'MECÁNICO AUTOMOTRIZ'
                        union
                        Select '-Seleccionar-','Seleccionar', 0 Orden
                        order by Orden")

        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "ID"
        ComboBox1.DataSource = sqla.DBDT

        sqla.Addparam("@IDCliente", TextBox9.Text)
        sqla.execquery("Select distinct Patente from registro where IDCliente = @IDCliente")

        If Not sqla.DBDT.Rows.Count = 0 Then
            For Each fila As DataRow In sqla.DBDT.Rows
                ComboBox2.Items.Add(fila.Item(0))
            Next
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        imprimir = "OT"

        Impresion.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        sqla.Addparam("@Patente", ComboBox2.Text)
        sqla.execquery("Select distinct Vehiculo from Registro where Patente = @Patente ")
        If sqla.DBDT.Rows.Count = 0 Then Exit Sub

        If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
            TextBox4.Text = sqla.DBDT.Rows(0).Item(0)

            sqla.Addparam("@Patente", ComboBox2.Text)
            sqla.execquery("Select distinct Ano from Registro where Patente = @Patente")
            If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                If sqla.DBDT.Rows(0).Item(0) = 0 Then
                    TextBox3.Text = ""
                Else
                    Dim index As Integer
                    index = sqla.DBDT.Rows.Count
                    TextBox3.Text = sqla.DBDT.Rows(index - 1).Item(0)
                End If



            End If

            sqla.Addparam("@Patente", ComboBox2.Text)
            sqla.execquery("Select distinct Motor from Registro where Patente = @Patente ")
            If Not IsDBNull(sqla.DBDT.Rows(0).Item(0)) Then
                If sqla.DBDT.Rows(0).Item(0) = "" Then
                    TextBox11.Text = ""
                Else
                    Dim index As Integer
                    index = sqla.DBDT.Rows.Count
                    TextBox11.Text = sqla.DBDT.Rows(index - 1).Item(0)
                End If


            End If

        End If







    End Sub



    Private Sub TextBox5_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyUp
        If String.IsNullOrEmpty(TextBox5.Text) Or String.IsNullOrWhiteSpace(TextBox5.Text) Then Exit Sub
        metodos.Miles(sender, e)
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress

        If Char.IsLetter(e.KeyChar) Then

            e.KeyChar = Char.ToUpper(e.KeyChar)

        End If
    End Sub


End Class