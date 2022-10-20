Public Class EliminarItem
    Public sqlb As New Sqlcontrol
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EliminarItem()
    End Sub

    Private Sub EliminarItem()
        sqlb.Addparam("@ID", IDT.Text)

        sqlb.execquery("DELETE FROM Inventario WHERE ID = @ID;")

        If sqlb.Masexception(True) Then Exit Sub
        MsgBox("Item eliminado exitosamente", Title:="Inventario")

    End Sub
End Class