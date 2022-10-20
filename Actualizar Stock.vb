Public Class NuevoStock
    Public sqla As New Sqlcontrol
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox4.Text = 1 Then
            If MsgBox("¿Añadir " & TextBox4.Text & " unidad de " & TextBox2.Text & " al Inventario?", MsgBoxStyle.YesNoCancel, Title:="Actualizar Stock") = "6" Then

                Dim a = {{"@ID", TextBox1.Text}, {"@Stock", TextBox4.Text}}
                sqla.Addparam(a)

                sqla.execquery("Update Inventario Set Stock = Stock + @Stock where ID = @ID  ")

            End If
        Else

            If MsgBox("¿Añadir " & TextBox4.Text & " unidades de " & TextBox2.Text & " al Inventario?", MsgBoxStyle.YesNoCancel, Title:="Actualizar Stock") = "6" Then
                Dim a = {{"@ID", TextBox1.Text}, {"@Stock", TextBox4.Text}}
                sqla.Addparam(a)
                sqla.execquery("Update Inventario Set Stock = Stock + @Stock where ID = @ID  ")

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a = {{"@ID", TextBox1.Text}}
        sqla.Addparam(a)
        sqla.execquery("SELECT * FROM Inventario WHERE ID = @ID;")
        TextBox2.Text = sqla.DBDT.Rows(0).Item(1)
        TextBox3.Text = sqla.DBDT.Rows(0).Item(5)

    End Sub

    Private Sub NuevoStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class