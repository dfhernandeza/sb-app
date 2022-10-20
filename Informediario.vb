Public Class Informediario

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        fechita = Me.MonthCalendar1.SelectionRange.Start.Date
        ifechad = Me.MonthCalendar1.SelectionRange.Start.Date.DayOfYear
        ifechay = Me.MonthCalendar1.SelectionRange.Start.Date.Year
        imprimir = "InformeD"
        Impresion.Show()
    End Sub
End Class