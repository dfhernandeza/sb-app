Imports ClasesLibreria.Funciones

Public Class prueba
    Public algo As New ClasesLibreria.Funciones
    Public f As String


    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        algo.FormateaRutTextBox(sender, e)

    End Sub


End Class