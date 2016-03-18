

Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Medica.DBControl



Public Class DataAccess

    Dim mydao As New DBControl
    Dim connectionString As String = mydao.hasConnection()
    Dim connection As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand


    'Public Sub insertDoctor()
    '    Dim reader As SqlDataReader
    '    mysqlConn = New SqlConnection


    '    command.CommandText = "INSERT INTO Doctor VALUES (‘jQuery’)"
    '    command.Connection = mysqlConn
    '    mysqlConn.Open()
    '    'here execute scalar will get firsr row first column value
    '    Dim retValue As Integer = command.ExecuteNonQuery()
    '    If retValue > 0 Then
    '        lblReturnValue.Text = retValue & " record(s) inserted!"
    '        'record(s) inserted so rebind fresh data
    '        BindGridviewFileData()
    '    Else
    '        lblReturnValue.Text = "No record(s) inserted!"
    '    End If
    '    sqlConn.Close()

    'End Sub
    Public Function insertDoctor(ByVal DOCTOR_NO As Integer, ByVal DOCTOR_NAME As String, ByVal DOCTOR_ADDRESS As String, ByVal DOC_REG_DATE As Date, ByVal DOC_GENDER As String, ByVal DOC_CONTACT As Integer, ByVal DOC_BDAY As Date) As Integer

        Dim mydao As New SqlConnection

        Using connection As New SqlConnection(mydao.ConnectionString())

            Using command As New SqlCommand()
                ' Set the connection
                command.Connection = connection

                ' Not necessary, but good practice
                command.CommandType = CommandType.Text

                ' Example query using parameters
                command.CommandText = "INSERT INTO [dbo].[DOCTOR] ([DOCTOR_NO],[DOCTOR_NAME],[DOCTOR_ADDRESS],[DOC_REG_DATE],[DOC_GENDER] ,[DOC_CONTACT],[DOC_BDAY]) VALUES (@DOCTOR_NO,@DOCTOR_NAME,@DOCTOR_ADDRESS,@DOC_REG_DATE,@DOC_GENDER,@DOC_CONTACT,@DOC_BDAY)"

                ' Adding the parameters to the command
                command.Parameters.AddWithValue("@DOCTOR_NO", DOCTOR_NO)
                command.Parameters.AddWithValue("@DOCTOR_NAME", DOCTOR_NAME)
                command.Parameters.AddWithValue("@DOCTOR_ADDRESS", DOCTOR_ADDRESS)
                command.Parameters.AddWithValue("@DOC_REG_DATE", DOC_REG_DATE)
                command.Parameters.AddWithValue("@DOC_GENDER", DOC_GENDER)
                command.Parameters.AddWithValue("@DOC_CONTACT", DOC_CONTACT)
                command.Parameters.AddWithValue("@DOC_BDAY", DOC_BDAY)

                connection.Open()

                Return command.ExecuteNonQuery()

            End Using ' Dispose Command

        End Using ' Dispose (and hence Close) Connection

    End Function



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
