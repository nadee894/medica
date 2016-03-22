Imports Medica.DataAccess
Imports Medica.IdAutoGeneration

Public Class Doctor_Registration
    Dim da As DataAccess
    Dim newId As IdAutoGeneration

    Private Sub Doctor_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DoctorDetails.DOCTOR' table. You can move, or remove it, as needed.
        Me.DOCTORTableAdapter.Fill(Me.DoctorDetails.DOCTOR)
        'ID Auto Generation
        da = New DataAccess
        Me.txtDoctorNo.Enabled = False
        newId = New IdAutoGeneration
        Dim ID As Integer = newId.GenerateID("DOCTOR", "DOCTOR_NO")
        Me.txtDoctorNo.Text = ID.ToString
    End Sub

    Private Sub gbDoctorReg_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDoctorReg.Enter

    End Sub

    Private Sub dgvDoctorDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDoctorDetails.CellContentClick

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        da = New DataAccess
        Dim gender As Integer = 0
        If rbMale.Checked Then
            gender = 1
        ElseIf rbFemale.Checked Then
            gender = 0

        End If
        Dim result As Integer = da.insertDoctor(Int32.Parse(txtDoctorNo.Text), txtDoctorName.Text, txtAddress.Text, Date.Parse(dtpDateOfReg.Value), gender, txtContactNo.Text, Date.Parse(dtpDateOfBirth.Value))
        If (result = 1) Then
            MessageBox.Show("Doctor Successfully Registered Successfullly")
            Me.DOCTORTableAdapter.Fill(Me.DoctorDetails.DOCTOR)
        Else
            MessageBox.Show("Error in registration", "Invalid")
        End If

    End Sub
End Class