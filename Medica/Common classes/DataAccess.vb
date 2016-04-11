

Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Medica.DBControl



Public Class DataAccess

    Dim mydao As New DBControl
    'Dim connectionString As String = mydao.hasConnection(True)
    'Dim connection = New SqlConnection("Data Source=ADEA\SQLEXPRESS;Initial Catalog=MEDICA;User ID=sa;Password=1234")
    Dim cmd As New SqlCommand

    Dim strQuery As String = ""
    Dim DR As SqlDataReader

    Dim SQLCon As New SqlConnection("Data Source=ADEA\SQLEXPRESS;Initial Catalog=MEDICA;User ID=sa;Password=1234")

    Public Function hasConnection(ByVal CloseConnection As Boolean)

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

    Public Function insertDoctor(ByVal DOCTOR_NO As Integer, ByVal DOCTOR_NAME As String, ByVal DOCTOR_ADDRESS As String, ByVal DOC_REG_DATE As String, ByVal DOC_GENDER As String, ByVal DOC_CONTACT As String, ByVal DOC_BDAY As String) As Integer
        Dim result As Integer
        Try
            SQLCon.Open()
            strQuery = "INSERT INTO [dbo].[DOCTOR] ([DOCTOR_NO],[DOCTOR_NAME],[DOCTOR_ADDRESS],[DOC_REG_DATE],[DOC_GENDER] ,[DOC_CONTACT],[DOC_BDAY]) VALUES ('" & DOCTOR_NO & "','" & DOCTOR_NAME & "','" & DOCTOR_ADDRESS & "','" & DOC_REG_DATE & "','" & DOC_GENDER & "','" & DOC_CONTACT & "','" & DOC_BDAY & "')"
            Dim SqlCmd As New SqlCommand(strQuery, SQLCon)
            result = SqlCmd.ExecuteNonQuery()
            SQLCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function


    'STOCK MANAGEMENT FUNCTIONS

    'INSERT STOCK UNIT

    Public Function insertStockUnit(ByVal STOCK_UNIT_ID As Integer, ByVal STOCK_UNIT_NAME As String) As Integer
        Dim result As Integer
        Try
            SQLCon.Open()
            strQuery = "INSERT INTO [dbo].[STOCK_UNIT] ([STOCK_UNIT_ID],[STOCK_UNIT_NAME]) VALUES ('" & STOCK_UNIT_ID & "','" & STOCK_UNIT_NAME & "')"
            Dim SqlCmd As New SqlCommand(strQuery, SQLCon)
            result = SqlCmd.ExecuteNonQuery()

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    'DELETE STOCK UNIT
    Public Function deleteStockUnit(ByVal STOCK_UNIT_ID) As Integer
        Dim result As Integer
        Try
            SQLCon.Open()
            strQuery = "DELETE FROM [dbo].[STOCK_UNIT] WHERE STOCK_UNIT_ID = '" & STOCK_UNIT_ID & "'"
            Dim SqlCmd As New SqlCommand(strQuery, SQLCon)
            result = SqlCmd.ExecuteNonQuery()

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    'UPDATE STOCK UNIT
    Public Function updateStockUnit(ByVal STOCK_UNIT_ID As Integer, ByVal STOCK_UNIT_NAME As String) As Integer
        Dim result As Integer
        Try
            SQLCon.Open()
            strQuery = "UPDATE [dbo].[STOCK_UNIT] SET STOCK_UNIT_NAME = '" & STOCK_UNIT_NAME & "' WHERE STOCK_UNIT_ID = '" & STOCK_UNIT_ID & "'"
            Dim SqlCmd As New SqlCommand(strQuery, SQLCon)
            result = SqlCmd.ExecuteNonQuery()

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    'SEARCH STOCK UNIT
    Public Function updateStockUnit(ByVal STOCK_UNIT_ID, ByVal STOCK_UNIT_NAME) As Integer
        Dim result As Integer
        Try
            SQLCon.Open()
            strQuery = "SELECT * FROM [dbo].[STOCK_UNIT] WHERE STOCK_UNIT_ID = '" & STOCK_UNIT_ID & "' OR "
            Dim SqlCmd As New SqlCommand(strQuery, SQLCon)
            result = SqlCmd.ExecuteNonQuery()

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

   

End Class
