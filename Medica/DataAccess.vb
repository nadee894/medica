

Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class DataAccess

    Private connectionString As String

    Public Sub New()

        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String = "Provider=Microsoft.ace.oledb.12.0;"
        Dim dbSource = "Data Source=d:\DB\Database11.accdb"

        connectionString = dbProvider & dbSource

    End Sub

    Public Function GetPatientDetails() As DataSet

        Dim query As String = "SELECT * FROM PATIENT"
        Dim cmd As New OleDbCommand(query)
        Return FillDataSet(cmd, "PATIENT")

    End Function

    ' Public SubUpdateCategories(ByVal name As String)
    '    Dim query As String = "update Categories set name = 'new2' where name = ?"
    '    Dim cmd As New OleDbCommand(query)
    'cmd.Parameters.AddWithValue("Name", name)
    '  Return FillDataSet(cmd, "Categories")

    'End Sub

    Public Function GetItems() As DataSet

        Dim query As String = "SELECT * FROM Items"
        Dim cmd As New OleDbCommand(query)
        Return FillDataSet(cmd, "Items")

    End Function

    Public Function GetItems(ByVal categoryID As Integer) As DataSet

        'Create the command.
        Dim query As String = "SELECT * FROM Items WHERE Category_ID=?"
        Dim cmd As New OleDbCommand(query)
        cmd.Parameters.AddWithValue("category_ID", categoryID)

        'Fill the dataset.
        Return FillDataSet(cmd, "Items")

    End Function

    Public Sub AddCategory(ByVal name As String)

        Dim con As New OleDbConnection(connectionString)

        'Create the command.
        Dim insertSQL As String = "INSERT INTO Categories "
        insertSQL &= "VALUES(?)"
        Dim cmd As New OleDbCommand(insertSQL, con)
        cmd.Parameters.AddWithValue("Name", name)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try

    End Sub

    Public Sub addPatient(ByVal title As String, ByVal description As String, _
       ByVal price As Decimal, ByVal categoryID As Integer)

        Dim con As New OleDbConnection(connectionString)

        'Create the command.
        Dim insertSQL As String = "INSERT INTO Items "
        insertSQL &= "(Title, Description, Price, Category_ID)"
        insertSQL &= "VALUES (?, ?, ?, ?)"
        Dim cmd As New OleDb.OleDbCommand(insertSQL, con)
        cmd.Parameters.AddWithValue("Title", title)
        cmd.Parameters.AddWithValue("Description", description)
        cmd.Parameters.AddWithValue("Price", price)
        cmd.Parameters.AddWithValue("CategoryID", categoryID)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Finally
            con.Close()
        End Try

    End Sub

    Private Function FillDataSet(ByVal cmd As OleDbCommand, ByVal tableName As String) As DataSet

        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String = "Provider=Microsoft.ace.oledb.12.0;"
        Dim dbSource = "Data Source=D:\DB\Database11.accdb"

        connectionString = dbProvider & dbSource
        con.ConnectionString = connectionString
        cmd.Connection = con
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet()

        Try
            con.Open()
            adapter.Fill(ds, tableName)
        Finally
            con.Close()
        End Try
        Return ds

    End Function

End Class
