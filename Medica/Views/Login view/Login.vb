Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "admin" Then
            Patient_Registration.Show()
        Else
            MsgBox("Authentication Failed!!", MsgBoxStyle.OkOnly, "Invalid")

        End If
    End Sub
End Class
