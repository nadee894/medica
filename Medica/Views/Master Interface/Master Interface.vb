Public Class Master_Interface

    Private Sub Master_Interface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientData.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter1.Fill(Me.PatientData.PATIENT)
       
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim docForm = New Doctor_Registration
        docForm.MdiParent = Me
        docForm.Show()
      



        
    End Sub
    Private Sub DoctorDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorDetailsToolStripMenuItem.Click
        Doctor_Registration.Show()
    End Sub
End Class