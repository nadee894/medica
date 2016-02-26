Imports Medica.DataAccess


Public Class Patient_Registration

    Public db As DataAccess

    Private Sub panelPersonalDetails_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub Patient_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MEDICADataSet.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.MEDICADataSet.PATIENT)
        'db.GetPatientDetails()

       

    End Sub
End Class