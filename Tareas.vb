Imports System.Drawing.Text

Public Class Tareas
    Public sql As New Sqlcontrol
    Public sqlA As New Sqlcontrol1
    Public contador As Integer
    Public ultima As Integer
    Public primera As Integer
    Public entrar As Integer
    Public modoedicion As String
    Public origen, copiarcortar As String
    Public columnainicial, filainicial As Integer
    Public algo As Integer
    Public hoyinicial As Date


    Private Sub Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Principal
        'DGVTareas.AutoGenerateColumns = False
        DGVTareas.AllowDrop = True

        Label1.Text = DateTime.Today.ToLongDateString
        ' DGVTareas.Rows.Add()
        'DGVTareas.Rows.Add()
        'DGVTareas.Rows.Add()
        'Llenar()

        'DGVTareas.ClearSelection()
        'EncabezadoFila()

        sql.execquery("Select ID from Personal where Especialidad = 'ELEVADOR'")
        For Each fila As DataRow In sql.DBDT.Rows
            elevadorbox.Items.Add(fila.Item(0))
        Next


        entrar = 1
    End Sub
    Public Sub EncabezadoFila()

        For Each fila As DataGridViewRow In DGVTareas.Rows
            sqlA.Addparam("@ID", fila.Cells(0).Value)
            sqlA.execquery("Select Nombre from Personal where ID = @ID")
            fila.Cells(1).Value = sqlA.DBDT.Rows(0).Item(0)
            fila.Cells(1).Style.Font = New Font("Microsoft Sans Serif", 18)
            fila.Cells(1).Style.BackColor = Color.Blue
            fila.Cells(1).Style.ForeColor = Color.White

            fila.MinimumHeight = 175
            sqlA.Addparam("@ID", fila.Cells(0).Value)
            sqlA.execquery("Select Especialidad from Personal where ID = @ID")



        Next

        'DGVTareas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DGVTareas.ClearSelection()






    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fecha As Date = Label1.Text

        Label1.Text = fecha.AddDays(-1).ToLongDateString

        Borrar()
        Llenar()
        EncabezadoFila()
        Elevador()



    End Sub
    Public Sub Llenar()
        Dim hoy As Date = Label1.Text
        Dim inicio, fin, final As System.DateTime
        Dim texto As String
        Dim diff As Integer

        For Each fila As DataGridViewRow In DGVTareas.Rows
            For i As Integer = 2 To DGVTareas.Columns.Count - 1

                inicio = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(i).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                fin = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(i).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

                diff = DateDiff(DateInterval.Second, inicio, fin)
                final = DateAdd(DateInterval.Second, diff / 2, inicio)
                sqlA.Addparam("@IDRecurso", fila.Cells(0).Value)
                sqlA.execquery("Select Especialidad from Personal where ID = @IDRecurso")

                If sqlA.DBDT.Rows(0).Item(0) = "MECÁNICO AUTOMOTRIZ" Then
                    sqlA.Addparam("@FechaInicio", inicio)
                    sqlA.Addparam("@FechaTermino", fin)
                    sqlA.Addparam("Fecha", final)
                    sqlA.Addparam("@IDRecurso", fila.Cells(0).Value)
                    sqlA.execquery("Select Programa.OT, Servicio, Patente, Elevador from Programa inner Join Registro on Programa.OT = Registro.OT where Inicio < = @Fecha and Fin > = @Fecha and IDRecurso = @IDRecurso")
                    If sqlA.DBDT.Rows.Count > 0 Then
                        texto = "OT:" + " " + sqlA.DBDT.Rows(0).Item(0).ToString & vbCrLf & "PATENTE:" + " " + sqlA.DBDT.Rows(0).Item(2) & vbCrLf + vbCrLf & sqlA.DBDT.Rows(0).Item(1).ToString & vbCrLf & sqlA.DBDT.Rows(0).Item(3).ToString
                        fila.Cells(i).Value = texto

                    Else
                        fila.Cells(i).Value = " "
                    End If
                ElseIf sqlA.DBDT.Rows(0).Item(0) = "ELEVADOR" Then
                    sqlA.Addparam("@FechaInicio", inicio)
                    sqlA.Addparam("@FechaTermino", fin)
                    sqlA.Addparam("Fecha", final)
                    sqlA.Addparam("@IDRecurso", fila.Cells(0).Value)
                    sqlA.execquery("Select Programa.OT, Servicio, Patente, Personal.Nombre from Programa inner Join Registro on Programa.OT = Registro.OT inner join Personal on Programa.IDRecurso = Personal.ID where Inicio < = @Fecha and Fin > = @Fecha and ELEVADOR = @IDRecurso")
                    If sqlA.DBDT.Rows.Count > 0 Then
                        texto = "OT:" + " " + sqlA.DBDT.Rows(0).Item(0).ToString & vbCrLf & "PATENTE:" + " " + sqlA.DBDT.Rows(0).Item(2) & vbCrLf + vbCrLf & sqlA.DBDT.Rows(0).Item(1).ToString & vbCrLf & sqlA.DBDT.Rows(0).Item(3).ToString
                        fila.Cells(i).Value = texto

                    Else
                        fila.Cells(i).Value = " "
                    End If



                End If

            Next
        Next

    End Sub
    Public Sub Borrar()
        For Each fila As DataGridViewRow In DGVTareas.Rows
            For i As Integer = 2 To DGVTareas.Columns.Count - 1
                fila.Cells(i).Value = " "
            Next
        Next




    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As Date = Label1.Text
        Label1.Text = fecha.AddDays(1).ToLongDateString
        Borrar()

        Llenar()
        EncabezadoFila()
        Elevador()

    End Sub

    Private Sub DGVTareas_DragEnter(sender As Object, e As DragEventArgs) Handles DGVTareas.DragEnter
        If origen = "Programar" Then
            If e.Data.GetDataPresent(DataFormats.Text) Then

                e.Effect = DragDropEffects.Copy
            End If
        End If
        If origen = "DGV" Then
            Dim cursorPosition As Point = Me.DGVTareas.PointToClient(Cursor.Position)
            Dim info As DataGridView.HitTestInfo = DGVTareas.HitTest(cursorPosition.X, cursorPosition.Y)
            If info.ColumnIndex <= 0 Or info.RowIndex < 0 Then
                e.Effect = DragDropEffects.None

                Exit Sub
            End If





            If e.Data.GetDataPresent(DataFormats.Text) Then




                e.Effect = DragDropEffects.Copy
                If copiarcortar = "Mover" Then
                    DGVTareas(info.ColumnIndex, info.RowIndex).Value = " "
                    'SendKeys.Send("{ENTER}")
                End If

            End If
            End If


    End Sub

    Private Sub DGVTareas_DragDrop(sender As Object, e As DragEventArgs) Handles DGVTareas.DragDrop
        Dim hoy As DateTime = Label1.Text
        Dim cursorPosition As Point = Me.DGVTareas.PointToClient(Cursor.Position)

        Dim info As DataGridView.HitTestInfo = DGVTareas.HitTest(cursorPosition.X, cursorPosition.Y)
        If info.ColumnIndex <= 0 Then
            Borrar()
            Llenar()

            Exit Sub
        End If

        If info.RowIndex = filainicial And info.ColumnIndex = columnainicial Then

            Borrar()
            Llenar()
            Exit Sub
        End If
        'Programar.tareasbox.Items.RemoveAt(Programar.tareasbox.SelectedIndex)
        Dim finicio As Date = hoy + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
        Dim ftermino As Date = hoy + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

        If origen = "Programar" Then
            If String.IsNullOrEmpty(Programar.ComboBox1.Text) Or String.IsNullOrWhiteSpace(Programar.ComboBox1.Text) Then
                MsgBox("Debe elegir un Elevador", Title:="Tareas")
                Borrar()
                Llenar()
                Exit Sub
            End If
            sqlA.Addparam("@OT", Programar.OTbox.Text)
            sqlA.Addparam("@Servicio", Programar.tareasbox.SelectedItem.ToString)
            sqlA.Addparam("@Inicio", finicio)
            sqlA.Addparam("@Fin", ftermino)
            sqlA.Addparam("@Rut", Programar.idmecanicobox.Text)
            sqlA.Addparam("@Elevador", Programar.ComboBox1.Text)
            sqlA.execquery("Insert into Programa (OT, Servicio, Inicio, Fin, IDRecurso, Elevador) Values (@OT, @Servicio, @Inicio, @Fin, @Rut,@Elevador)")
            If sqlA.Masexception(True) Then Exit Sub
            Borrar()
                Llenar()
            End If
            If origen = "DGV" Then

            sqlA.Addparam("@ID", DGVTareas.Rows(filainicial).Cells(0).Value)
            sqlA.execquery("Select Especialidad from Personal where ID = @ID")
            If sqlA.DBDT.Rows(0).Item(0) = "MECÁNICO AUTOMOTRIZ" Then
                If String.IsNullOrEmpty(elevadorbox.Text) Or String.IsNullOrWhiteSpace(elevadorbox.Text) Then
                    MsgBox("Debe elegir un Elevador", Title:="Tareas")
                    Borrar()
                    Llenar()
                    Exit Sub
                End If
                'sql.Addparam("@Elevador", elevadorbox.Text)
                'sql.execquery("Select ID from Personal where Nombre = @Elevador")
                'Dim Elevador As String = sql.DBDT.Rows(0).Item(0)


                DGVTareas(info.ColumnIndex, info.RowIndex).Value = e.Data.GetData(DataFormats.Text).ToString()
                Dim inicioinicial As Date = hoyinicial + Convert.ToDateTime(DGVTareas.Columns(columnainicial).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                Dim finalinicial As Date = hoyinicial + Convert.ToDateTime(DGVTareas.Columns(columnainicial).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay




                Dim inicio, fin, final As System.DateTime
                Dim diff As Integer



                inicio = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                fin = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

                diff = DateDiff(DateInterval.Second, inicioinicial, finalinicial)
                final = DateAdd(DateInterval.Second, diff / 2, inicioinicial)

                If copiarcortar = "Mover" Then
                    sqlA.Addparam("@FechaInicio", inicio)
                    sqlA.Addparam("@FechaTermino", fin)
                    sqlA.Addparam("@Fecha", final)
                    sqlA.Addparam("@InicioInicial", inicioinicial)
                    sqlA.Addparam("@FinalInicial", finalinicial)
                    sqlA.Addparam("@Rut", DGVTareas.Rows(filainicial).Cells(0).Value)
                    sqlA.Addparam("@ID", DGVTareas.Rows(info.RowIndex).Cells(0).Value)
                    sqlA.Addparam("@Elevador", elevadorbox.Text)
                    sqlA.execquery("Update Programa Set Inicio = @FechaInicio, Fin = @FechaTermino , IDRecurso = @ID, Elevador = @Elevador where Inicio < = @Fecha and Fin > = @Fecha and IDRecurso = @Rut")
                    sqlA.Masexception(True)
                ElseIf copiarcortar = "Copiar" Then
                    Dim OT As Double
                    Dim Servicio As String




                    sqlA.Addparam("@Fecha", final)
                    sqlA.Addparam("@Rut", DGVTareas.Rows(filainicial).Cells(0).Value)
                    sqlA.execquery("Select OT, Servicio from Programa where Inicio < = @Fecha and Fin > = @Fecha and IDRecurso = @Rut ")
                    sqlA.Masexception(True)
                    OT = sqlA.DBDT.Rows(0).Item(0)
                    Servicio = sqlA.DBDT.Rows(0).Item(1)

                    sqlA.Addparam("@OT", OT)
                    sqlA.Addparam("@Servicio", Servicio)
                    sqlA.Addparam("@Inicio", inicio)
                    sqlA.Addparam("@Fin", fin)
                    sqlA.Addparam("@Elevador", elevadorbox.Text)
                    sqlA.Addparam("@ID", DGVTareas.Rows(info.RowIndex).Cells(0).Value)
                    sqlA.execquery("Insert into Programa (OT, Servicio, Inicio, Fin, IDRecurso, Elevador) Values (@OT, @Servicio, @Inicio, @Fin,@ID , @Elevador)")
                    sqlA.Masexception(True)

                End If

            Else
                sqlA.Addparam("@ID", DGVTareas.Rows(filainicial).Cells(0).Value)
                sqlA.execquery("Select Especialidad from Personal where ID = @ID")

                If sqlA.DBDT.Rows(0).Item(0) = "ELEVADOR" Then




                    DGVTareas(info.ColumnIndex, info.RowIndex).Value = e.Data.GetData(DataFormats.Text).ToString()
                    Dim inicioinicial As Date = hoyinicial + Convert.ToDateTime(DGVTareas.Columns(columnainicial).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                    Dim finalinicial As Date = hoyinicial + Convert.ToDateTime(DGVTareas.Columns(columnainicial).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay




                    Dim inicio, fin, final As System.DateTime
                    Dim diff As Integer



                    inicio = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                    fin = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(info.ColumnIndex).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

                    diff = DateDiff(DateInterval.Second, inicioinicial, finalinicial)
                    final = DateAdd(DateInterval.Second, diff / 2, inicioinicial)

                    If copiarcortar = "Mover" Then
                        sqlA.Addparam("@FechaInicio", inicio)
                        sqlA.Addparam("@FechaTermino", fin)
                        sqlA.Addparam("@Fecha", final)
                        sqlA.Addparam("@InicioInicial", inicioinicial)
                        sqlA.Addparam("@FinalInicial", finalinicial)
                        sqlA.Addparam("@Rut", DGVTareas.Rows(filainicial).Cells(0).Value)
                        sqlA.Addparam("@ID", DGVTareas.Rows(info.RowIndex).Cells(0).Value)

                        sqlA.execquery("Update Programa Set Inicio = @FechaInicio, Fin = @FechaTermino , Elevador = @ID where Inicio < = @Fecha and Fin > = @Fecha and Elevador = @Rut")
                        sqlA.Masexception(True)
                    ElseIf copiarcortar = "Copiar" Then
                        Dim OT As Double
                        Dim Servicio, Rut As String

                        sqlA.Addparam("@Fecha", final)
                        sqlA.Addparam("@Rut", DGVTareas.Rows(filainicial).Cells(0).Value)
                        sqlA.execquery("Select OT, Servicio, IDRecurso from Programa where Inicio < = @Fecha and Fin > = @Fecha and Elevador = @Rut ")
                        sqlA.Masexception(True)
                        OT = sqlA.DBDT.Rows(0).Item(0)
                        Servicio = sqlA.DBDT.Rows(0).Item(1)
                        Rut = sqlA.DBDT.Rows(0).Item(2)
                        sqlA.Addparam("@OT", OT)
                        sqlA.Addparam("@Servicio", Servicio)
                        sqlA.Addparam("@Inicio", inicio)
                        sqlA.Addparam("@Fin", fin)
                        sqlA.Addparam("@IDRecurso", Rut)
                        sqlA.Addparam("@Elevador", DGVTareas.Rows(info.RowIndex).Cells(0).Value)
                        sqlA.execquery("Insert into Programa (OT, Servicio, Inicio, Fin, IDRecurso, Elevador) Values (@OT, @Servicio, @Inicio, @Fin,@IDRecurso , @Elevador)")
                        sqlA.Masexception(True)

                    End If












                End If





            End If


        End If

        Borrar()
        Llenar()
        Elevador()









    End Sub

    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click

        With DGVTareas
            .Columns(2).HeaderText = "09:00-09:30"
            .Columns(3).HeaderText = "09:30-10:00"
            .Columns(4).HeaderText = "10:00-10:30"
            .Columns(5).HeaderText = "10:30-11:00"
            .Columns(6).HeaderText = "11:00-11:30"
            .Columns(7).HeaderText = "11:30-12:00"
            .Columns(8).HeaderText = "12:00-12:30"
            .Columns(9).HeaderText = "12:30-13:00"
        End With
        Borrar()
        Llenar()
        Elevador()
        amfmbox.Visible = True
    End Sub

    Private Sub MinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem1.Click


        With DGVTareas
            .Columns(2).HeaderText = "09:00-10:00"
            .Columns(3).HeaderText = "10:00-11:00"
            .Columns(4).HeaderText = "11:00-12:00"
            .Columns(5).HeaderText = "12:00-13:00"
            .Columns(6).HeaderText = "14:00-15:00"
            .Columns(7).HeaderText = "15:00-16:00"
            .Columns(8).HeaderText = "16:00-17:00"
            .Columns(9).HeaderText = "17:00-18:00"

        End With
        Borrar()
        Llenar()
        Elevador()


        amfmbox.Visible = False
    End Sub

    Private Sub amfmbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles amfmbox.SelectedIndexChanged
        entrar = 1


        If amfmbox.SelectedItem.ToString = "Mañana" Then
            With DGVTareas

                With DGVTareas
                    .Columns(2).HeaderText = "09:00-09:30"
                    .Columns(3).HeaderText = "09:30-10:00"
                    .Columns(4).HeaderText = "10:00-10:30"
                    .Columns(5).HeaderText = "10:30-11:00"
                    .Columns(6).HeaderText = "11:00-11:30"
                    .Columns(7).HeaderText = "11:30-12:00"
                    .Columns(8).HeaderText = "12:00-12:30"
                    .Columns(9).HeaderText = "12:30-13:00"
                End With

            End With
            Borrar()
            EncabezadoFila()
            Llenar()

        End If
        If amfmbox.SelectedItem.ToString = "Tarde" Then
            With DGVTareas

                With DGVTareas
                    .Columns(2).HeaderText = "14:00-14:30"
                    .Columns(3).HeaderText = "14:30-15:00"
                    .Columns(4).HeaderText = "15:00-15:30"
                    .Columns(5).HeaderText = "15:30-16:00"
                    .Columns(6).HeaderText = "16:00-16:30"
                    .Columns(7).HeaderText = "16:30-17:00"
                    .Columns(8).HeaderText = "17:00-17:30"
                    .Columns(9).HeaderText = "17:30-18:00"
                End With
            End With
            Borrar()
            Llenar()
            EncabezadoFila()
        End If

    End Sub
    Public Sub Elevador()
        If elevadorbox.SelectedItem = Nothing Then Exit Sub
        If elevadorbox.SelectedItem = "T" Then
            For Each row As DataGridViewRow In DGVTareas.Rows
                For i As Integer = 2 To Me.DGVTareas.Columns.Count - 1
                    row.Cells(i).Style.BackColor = Color.Lime
                Next
            Next
            Exit Sub

        End If
        Dim hoy As Date = Me.Label1.Text
        Dim inicio, fin, final As System.DateTime
        Dim diff As Integer




        For Each fila As DataGridViewRow In DGVTareas.Rows
            For i As Integer = 2 To Me.DGVTareas.Columns.Count - 1

                inicio = hoy.Date + Convert.ToDateTime(Me.DGVTareas.Columns(i).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
                fin = hoy.Date + Convert.ToDateTime(Me.DGVTareas.Columns(i).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

                diff = DateDiff(DateInterval.Second, inicio, fin)
                final = DateAdd(DateInterval.Second, diff / 2, inicio)

                sqlA.Addparam("@FechaInicio", inicio)
                sqlA.Addparam("@FechaTermino", fin)
                sqlA.Addparam("Fecha", final)
                sqlA.Addparam("@ID", elevadorbox.SelectedItem.ToString)
                sqlA.execquery("Select OT from Programa where Inicio < = @Fecha and Fin > = @Fecha and Elevador = @ID")
                sqlA.Masexception(True)
                If sqlA.DBDT.Rows.Count > 0 Then

                    fila.Cells(i).Style.BackColor = Color.Red
                Else
                    fila.Cells(i).Style.BackColor = Color.Lime

                End If



            Next




        Next


    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles elevadorbox.SelectedIndexChanged
        Elevador()

    End Sub


    Private Sub DGVTareas_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DGVTareas.CellPainting
        Dim inicial, final As Integer
        If modoedicion = "Encendido" Then Exit Sub

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 1 Then Exit Sub



        'Última columna
        If String.IsNullOrWhiteSpace(e.Value) Or IsNothing(e.Value) Or IsDBNull(e.Value) Then Exit Sub

        If e.ColumnIndex = 1 Then
            If e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
                For i As Integer = e.ColumnIndex To DGVTareas.Columns.Count - 2

                    If DGVTareas.Rows(e.RowIndex).Cells(i).Value = DGVTareas.Rows(e.RowIndex).Cells(i + 1).Value Then
                        final = i + 1
                    Else
                        If final - e.ColumnIndex > 0 Then
                            If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
                                e.PaintBackground(e.ClipBounds, True)
                                Dim r As Rectangle = e.CellBounds

                                For j As Integer = e.ColumnIndex To final - 1
                                    r.Width += DGVTareas.GetCellDisplayRectangle(j, 0, True).Width
                                Next

                                r.Width -= 1
                                r.Height -= 1


                                Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                                    Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                                        e.Graphics.FillRectangle(brBk, r)
                                        Dim sf As StringFormat = New StringFormat()
                                        sf.Alignment = StringAlignment.Center
                                        sf.LineAlignment = StringAlignment.Center
                                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                                    End Using
                                End Using

                                e.Handled = True
                                Exit Sub
                            End If
                        End If


                    End If



                Next

                If final = 9 Then
                    If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
                        e.PaintBackground(e.ClipBounds, True)
                        Dim r As Rectangle = e.CellBounds

                        For j As Integer = e.ColumnIndex To final - 1
                            r.Width += DGVTareas.GetCellDisplayRectangle(j, 0, True).Width
                        Next

                        r.Width -= 1
                        r.Height -= 1


                        Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                            Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                                e.Graphics.FillRectangle(brBk, r)
                                Dim sf As StringFormat = New StringFormat()
                                sf.Alignment = StringAlignment.Center
                                sf.LineAlignment = StringAlignment.Center
                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                                e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                            End Using
                        End Using

                        e.Handled = True
                    End If
                End If

                Exit Sub

            End If






        End If


        If e.ColumnIndex = DGVTareas.Columns.Count - 1 Then
            If e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then


                Using p As Pen = New Pen((TryCast(sender, DataGridView)).GridColor)
                    e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)
                    e.Graphics.DrawLine(p, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
                End Using

                e.Handled = True
                Exit Sub
            Else

                Exit Sub



            End If
        End If

        'si está rodeado de nada. hacer nada
        If (DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value = Nothing Or IsDBNull(DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)) And (DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = Nothing Or IsDBNull(DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)) Then Exit Sub

        'si es igual al anterior y diferente al siguiente es último
        If DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then


            Using p As Pen = New Pen((TryCast(sender, DataGridView)).GridColor)
                e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)
                e.Graphics.DrawLine(p, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
            End Using

            e.Handled = True

            Exit Sub
        End If
        'si es el penúltimo y el siguiente es igual 
        If e.ColumnIndex = 8 And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value And e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then


            e.PaintBackground(e.ClipBounds, True)
            Dim r As Rectangle = e.CellBounds


            r.Width += DGVTareas.GetCellDisplayRectangle(8, 0, True).Width


            r.Width -= 1
            r.Height -= 1


            Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                    e.Graphics.FillRectangle(brBk, r)
                    Dim sf As StringFormat = New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center
                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                End Using
            End Using

            e.Handled = True

            Exit Sub

        End If
















        If e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then

            Using p As Pen = New Pen((TryCast(sender, DataGridView)).GridColor)
                e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)

            End Using

            e.Handled = True

            Exit Sub


        End If

        If e.ColumnIndex = 7 Then
            If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value Then


                e.PaintBackground(e.ClipBounds, True)
                Dim r As Rectangle = e.CellBounds


                For j As Integer = 0 To 1
                    r.Width += DGVTareas.GetCellDisplayRectangle(7, 0, True).Width
                Next


                r.Width -= 1
                r.Height -= 1


                Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                    Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                        e.Graphics.FillRectangle(brBk, r)
                        Dim sf As StringFormat = New StringFormat()
                        sf.Alignment = StringAlignment.Center
                        sf.LineAlignment = StringAlignment.Center
                        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                    End Using
                End Using

                e.Handled = True

                Exit Sub




            End If

        End If





        'If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
        For i As Integer = e.ColumnIndex To DGVTareas.Columns.Count - 2

            If DGVTareas.Rows(e.RowIndex).Cells(i).Value = DGVTareas.Rows(e.RowIndex).Cells(i + 1).Value Then
                final = i + 1

                If final = 9 Then
                    If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
                        e.PaintBackground(e.ClipBounds, True)
                        Dim r As Rectangle = e.CellBounds

                        For j As Integer = e.ColumnIndex To final - 1
                            r.Width += DGVTareas.GetCellDisplayRectangle(j, 0, True).Width
                        Next

                        r.Width -= 1
                        r.Height -= 1


                        Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                            Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                                e.Graphics.FillRectangle(brBk, r)
                                Dim sf As StringFormat = New StringFormat()
                                sf.Alignment = StringAlignment.Center
                                sf.LineAlignment = StringAlignment.Center
                                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                                e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                            End Using
                        End Using

                        e.Handled = True
                    End If
                End If



            Else

                    If final - e.ColumnIndex > 0 Then
                        If e.Value <> DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value And e.Value = DGVTareas.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value Then
                            e.PaintBackground(e.ClipBounds, True)
                            Dim r As Rectangle = e.CellBounds

                            For j As Integer = e.ColumnIndex To final - 1
                                r.Width += DGVTareas.GetCellDisplayRectangle(j, 0, True).Width
                            Next

                            r.Width -= 1
                            r.Height -= 1


                            Using brBk As SolidBrush = New SolidBrush(e.CellStyle.BackColor)

                                Using brFr As SolidBrush = New SolidBrush(e.CellStyle.ForeColor)
                                    e.Graphics.FillRectangle(brBk, r)
                                    Dim sf As StringFormat = New StringFormat()
                                    sf.Alignment = StringAlignment.Center
                                    sf.LineAlignment = StringAlignment.Center
                                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit
                                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, brFr, r, sf)
                                End Using
                            End Using

                            e.Handled = True
                            Exit Sub
                        End If
                    End If


                End If




        Next

        'End If



    End Sub



    Private Sub Tareas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim bHandled As Boolean = False
        Select Case e.KeyCode

            Case Keys.Right

                Me.Button1.PerformClick()

                e.Handled = True
            Case Keys.Left
                Me.Button2.PerformClick()

                e.Handled = True

            Case Keys.Up

                MinToolStripMenuItem1_Click(sender, e)

            Case Keys.Down

                MinToolStripMenuItem_Click(sender, e)

            Case Keys.Delete
                Borrado()
        End Select






    End Sub



    Private Sub ModoEdiciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModoEdiciónToolStripMenuItem.Click



        If ModoEdiciónToolStripMenuItem.Text = "Activar Modo Edición" Then
            ModoEdiciónToolStripMenuItem.Text = "Desactivar Modo Edición"
            modoedicion = "Encendido"
            DGVTareas.ReadOnly = False
            Borrar()
            Llenar()

        Else
            ModoEdiciónToolStripMenuItem.Text = "Activar Modo Edición"

            modoedicion = "Apagado"
            Borrar()
            Llenar()

            DGVTareas.ReadOnly = True
        End If



    End Sub

    Private Sub DGVTareas_MouseDown(sender As Object, e As MouseEventArgs) Handles DGVTareas.MouseDown

        If modoedicion <> "Encendido" Then Exit Sub
            Dim cursorPosition As Point = Me.DGVTareas.PointToClient(Cursor.Position)

            Dim info As DataGridView.HitTestInfo = DGVTareas.HitTest(cursorPosition.X, cursorPosition.Y)
        If info.RowIndex < 0 Then Exit Sub
        If String.IsNullOrEmpty(DGVTareas.Rows(info.RowIndex).Cells(info.ColumnIndex).Value) Or String.IsNullOrWhiteSpace(DGVTareas.Rows(info.RowIndex).Cells(info.ColumnIndex).Value) Then Exit Sub
        Dim texto As String = DGVTareas.Rows(info.RowIndex).Cells(info.ColumnIndex).Value.ToString
            origen = "DGV"
        columnainicial = info.ColumnIndex
        filainicial = info.RowIndex
        hoyinicial = Label1.Text
        DGVTareas.DoDragDrop(texto.ToString, DragDropEffects.Copy)







    End Sub

    Public Sub Borrado()
        If MsgBox("Esta a punto de borrar esta asignación. ¿Desea continuar? ", vbYesNo, Title:="Cotizar") = "6" Then

            Dim hoy As Date = Label1.Text
            Dim inicio, fin, final As System.DateTime
            Dim diff As Integer


            inicio = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(DGVTareas.CurrentCell.ColumnIndex).HeaderText.ToString.Substring(0, 5).ToString).TimeOfDay
            fin = hoy.Date + Convert.ToDateTime(DGVTareas.Columns(DGVTareas.CurrentCell.ColumnIndex).HeaderText.ToString.Substring(6, 5).ToString).TimeOfDay

            diff = DateDiff(DateInterval.Second, inicio, fin)
            final = DateAdd(DateInterval.Second, diff / 2, inicio)
            sqlA.Addparam("@Rut", DGVTareas.Rows(DGVTareas.CurrentCell.RowIndex).Cells(0).Value)
            sqlA.Addparam("@FechaInicio", inicio)
            sqlA.Addparam("@FechaTermino", fin)
            sqlA.Addparam("Fecha", final)
            sqlA.execquery("Delete from Programa where Inicio < = @Fecha and Fin > = @Fecha and IDRecurso = @Rut")




            DGVTareas.CurrentCell.Value = " "
            SendKeys.Send("{ENTER}")


        End If




    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        copiarcortar = "Copiar"
    End Sub

    Private Sub ProgramadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramadorToolStripMenuItem.Click
        Programar.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Recursos.Show()
    End Sub

    Private Sub Limpiarbtn_Click(sender As Object, e As EventArgs) Handles Limpiarbtn.Click
        DGVTareas.Rows.Clear()
    End Sub

    Private Sub ReservarElevadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservarElevadorToolStripMenuItem.Click
        ReservarElevador.Show()
    End Sub

    Private Sub MoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverToolStripMenuItem.Click
        copiarcortar = "Mover"
    End Sub

    Private Sub DGVTareas_DragOver(sender As Object, e As DragEventArgs) Handles DGVTareas.DragOver
        Dim ClientPoint As Point = DGVTareas.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = DGVTareas.HitTest(ClientPoint.X, ClientPoint.Y)
        Dim hoy As DateTime = Label1.Text




        If hit.RowIndex < 0 Or hit.ColumnIndex <= 0 Then

            e.Effect = DragDropEffects.None
            Exit Sub

        End If


        If hit.RowIndex = filainicial And hit.ColumnIndex = columnainicial Then
            e.Effect = DragDropEffects.Copy
            Exit Sub
        End If


        'Sólo si es la misma especialidad
        sqlA.Addparam("@ID", DGVTareas.Rows(filainicial).Cells(0).Value)
        sqlA.execquery("Select Especialidad from Personal where ID = @ID")
        Dim especialidad As String = sqlA.DBDT.Rows(0).Item(0)
        sqlA.Addparam("@ID", DGVTareas.Rows(hit.RowIndex).Cells(0).Value)
        sqlA.execquery("Select Especialidad from Personal where ID = @ID")
        If especialidad <> sqlA.DBDT.Rows(0).Item(0) Then
            e.Effect = DragDropEffects.None
            Exit Sub
        End If


        ' si está en blanco 


        If String.IsNullOrWhiteSpace(DGVTareas.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Value) Or String.IsNullOrEmpty(DGVTareas.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Value) Then
            'If we're at the first column (or no column) display a "stop" cursor.

            If DGVTareas.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Style.BackColor = Color.Red Then
                If copiarcortar = "Mover" And hit.ColumnIndex = columnainicial Then

                    e.Effect = DragDropEffects.Copy


                Else
                    If copiarcortar = "Copiar" And hit.ColumnIndex = columnainicial Then

                        e.Effect = DragDropEffects.Copy


                    Else

                        e.Effect = DragDropEffects.None

                    End If


                End If
            Else

                e.Effect = DragDropEffects.Copy

            End If
        Else

            'For all other columns display a "move" cursor.
            e.Effect = DragDropEffects.None

        End If

        '========================================================================================
        '===========================================================================================




    End Sub


    Private Sub Button3_DragOver(sender As Object, e As DragEventArgs) Handles Button3.DragOver
        If algo >= 1 Then Exit Sub
        Button3.BackColor = Color.CornflowerBlue
        Button1.PerformClick()
        algo = algo + 1
    End Sub

    Private Sub Button3_DragLeave(sender As Object, e As EventArgs) Handles Button3.DragLeave
        algo = 0
    End Sub

    Private Sub Button4_DragOver(sender As Object, e As DragEventArgs) Handles Button4.DragOver
        If algo >= 1 Then Exit Sub

        Button2.PerformClick()
        algo = algo + 1
        Button4.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Button4_DragLeave(sender As Object, e As EventArgs) Handles Button4.DragLeave
        algo = 0
    End Sub
End Class



