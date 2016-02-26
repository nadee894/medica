Public Class Doctor_Registration

    Private Sub Doctor_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DoctorDetails.DOCTOR' table. You can move, or remove it, as needed.
        Me.DOCTORTableAdapter.Fill(Me.DoctorDetails.DOCTOR)

    End Sub

    Private Sub gbDoctorReg_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDoctorReg.Enter

    End Sub

    Private Sub dgvDoctorDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDoctorDetails.CellContentClick

    End Sub
End Class