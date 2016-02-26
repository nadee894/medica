Public Class Master_Interface

    Private Sub Master_Interface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientData.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter1.Fill(Me.PatientData.PATIENT)
        Me.TabPage1.Text = "Doctor"
        Me.TabPage2.Text = "Patient"
    End Sub
End Class