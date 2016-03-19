Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class DBControl

    'Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source=WPHBSPC001;Initial Catalog=AssetManager;User ID=sa;Password=1234"}



    Public Function hasConnection(ByVal CloseConnection As Boolean)
        Dim SQLCon As New SqlConnection("Data Source=ADEA\SQLEXPRESS;Initial Catalog=MEDICA;User ID=sa;Password=1234")
        Try
            If CloseConnection = False Then
                If SQLCon.State = ConnectionState.Closed Then _
                    SQLCon.Open()
            Else
                SQLCon.Close()
            End If

        Catch ex As Exception
            MsgBox("FAIL")
        End Try
        Return SQLCon
    End Function

End Class
