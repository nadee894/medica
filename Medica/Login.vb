Public Class Login
    Dim SQL As New DBControl

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If SQL.hasConnection = True Then
            MsgBox("Successsfully Connected to the database")

        End If

    End Sub
End Class
