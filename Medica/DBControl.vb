Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class DBControl

    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=ADEA\SQLEXPRESS;Database=MEDICA;User=sa;Pwd=1234;"}
    Public SQLCmd As SqlCommand

    Public Function hasConnection() As Boolean
        Try
            SQLCon.Open()
            'SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
