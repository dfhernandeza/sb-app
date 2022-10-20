Imports System.Data.SqlClient
Imports System.Configuration
Public Class Sqlcontrol

    Private dbcon As New SqlConnection(ConfigurationManager.ConnectionStrings("SB").ConnectionString)
    Private dbcmd As SqlCommand
    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    'Query PARAMETERS
    Public params As New List(Of SqlParameter)
    'query statistics
    Public recordcount As Integer
    Public exception As String
    Public Sub New()

    End Sub
    'allow connction string override
    Public Sub New(connectionstring As String)
        dbcon = New SqlConnection(connectionstring)
    End Sub
    'execute query sub 
    Public Sub execquery(Query As String)
        'reset query stats 
        recordcount = 0
        exception = ""
        Try
            dbcon.Open()
            'create db comman
            dbcmd = New SqlCommand(Query, dbcon)

            'load params into db command 
            params.ForEach(Sub(p) dbcmd.Parameters.Add(p))
            'clear param list 
            params.Clear()
            'execute command & fill dataset
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(dbcmd)
            recordcount = DBDA.Fill(DBDT)

        Catch ex As Exception
            'capture error 
            exception = "Execquery error: " & vbNewLine & ex.Message

        Finally
            'close connection 
            If dbcon.State = ConnectionState.Open Then dbcon.Close()


        End Try
    End Sub
    Public Sub Addparam(a(,) As Object)
        For i As Integer = 0 To a.GetLength(0) - 1
            Dim newparam As New SqlParameter(a(i, 0).ToString(), a(i, 1))
            params.Add(newparam)
        Next

    End Sub
    Public Sub Addparam(name As String, value As Object)
        Dim newparam As New SqlParameter(name, value)
        params.Add(newparam)
    End Sub





    'error checking 
    Public Function Masexception(Optional report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(exception) Then Return False
        If report = True Then MsgBox(exception, MsgBoxStyle.Critical, "exception:")
        Return True
    End Function
End Class
