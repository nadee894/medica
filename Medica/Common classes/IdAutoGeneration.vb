Public Class IdAutoGeneration

    Public Function GenerateID(ByVal tableName As String, ByVal ID As String)

        Dim newId As String
        Dim stringId As String
        Dim intId As Integer
        Dim conn As New System.Data.SqlClient.SqlConnection("Data Source=ADEA\SQLEXPRESS;Initial Catalog=MEDICA;User ID=sa;Password=1234")
        Dim adpt As New System.Data.SqlClient.SqlDataAdapter("Select " & ID & " from [dbo]." & tableName & " Where " & ID & " = (SELECT max(" & ID & ") from [dbo]." & tableName & ")", conn) 'Where tableName is our table
        Dim ds As New DataSet
        adpt.Fill(ds)
        If ds.Tables(0).Rows.Count = 0 Then 'This will check whether any records are there or not
            newId = "1" ' If records are not there then this id will be returned
        Else
            stringId = ds.Tables(0).Rows(0).Item(0).ToString    'This will store your id in string format
            intId = stringId       ' This will store only integer values from that id
            intId += 1      ' Increment id by 1
            newId = intId     ' Creating new Id incremented by 1
        End If
        Return newId
    End Function

End Class
