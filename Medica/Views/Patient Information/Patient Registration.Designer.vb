<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvPatientDetails = New System.Windows.Forms.DataGridView()
        Me.gbPatientReg = New System.Windows.Forms.GroupBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.txtPatientNo = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.lblDateOfReg = New System.Windows.Forms.Label()
        Me.dtpDateOfReg = New System.Windows.Forms.DateTimePicker()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbMedicineInformation = New System.Windows.Forms.GroupBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblCurrentProblem = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPatientReg.SuspendLayout()
        Me.gbMedicineInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPatientDetails
        '
        Me.dgvPatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientDetails.Location = New System.Drawing.Point(616, 12)
        Me.dgvPatientDetails.Name = "dgvPatientDetails"
        Me.dgvPatientDetails.Size = New System.Drawing.Size(347, 437)
        Me.dgvPatientDetails.TabIndex = 0
        '
        'gbPatientReg
        '
        Me.gbPatientReg.Controls.Add(Me.gbMedicineInformation)
        Me.gbPatientReg.Controls.Add(Me.btnClear)
        Me.gbPatientReg.Controls.Add(Me.btnSearch)
        Me.gbPatientReg.Controls.Add(Me.btnDelete)
        Me.gbPatientReg.Controls.Add(Me.btnUpdate)
        Me.gbPatientReg.Controls.Add(Me.btnAdd)
        Me.gbPatientReg.Controls.Add(Me.dtpDateOfBirth)
        Me.gbPatientReg.Controls.Add(Me.lblDateOfBirth)
        Me.gbPatientReg.Controls.Add(Me.rbFemale)
        Me.gbPatientReg.Controls.Add(Me.rbMale)
        Me.gbPatientReg.Controls.Add(Me.lblGender)
        Me.gbPatientReg.Controls.Add(Me.dtpDateOfReg)
        Me.gbPatientReg.Controls.Add(Me.lblDateOfReg)
        Me.gbPatientReg.Controls.Add(Me.txtContactNo)
        Me.gbPatientReg.Controls.Add(Me.lblContactNo)
        Me.gbPatientReg.Controls.Add(Me.txtPatientNo)
        Me.gbPatientReg.Controls.Add(Me.lblPatientNo)
        Me.gbPatientReg.Controls.Add(Me.lblPatientName)
        Me.gbPatientReg.Controls.Add(Me.txtAddress)
        Me.gbPatientReg.Controls.Add(Me.lblAddress)
        Me.gbPatientReg.Controls.Add(Me.txtPatientName)
        Me.gbPatientReg.Location = New System.Drawing.Point(12, 12)
        Me.gbPatientReg.Name = "gbPatientReg"
        Me.gbPatientReg.Size = New System.Drawing.Size(580, 437)
        Me.gbPatientReg.TabIndex = 4
        Me.gbPatientReg.TabStop = False
        Me.gbPatientReg.Text = "Personal Details"
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(116, 26)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(144, 20)
        Me.txtPatientName.TabIndex = 2
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(23, 68)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(116, 68)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(144, 52)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = ""
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(20, 26)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(71, 13)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Patient Name"
        '
        'lblPatientNo
        '
        Me.lblPatientNo.AutoSize = True
        Me.lblPatientNo.Location = New System.Drawing.Point(294, 33)
        Me.lblPatientNo.Name = "lblPatientNo"
        Me.lblPatientNo.Size = New System.Drawing.Size(57, 13)
        Me.lblPatientNo.TabIndex = 4
        Me.lblPatientNo.Text = "Patient No"
        '
        'txtPatientNo
        '
        Me.txtPatientNo.Location = New System.Drawing.Point(410, 26)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(144, 20)
        Me.txtPatientNo.TabIndex = 5
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Location = New System.Drawing.Point(23, 144)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(61, 13)
        Me.lblContactNo.TabIndex = 6
        Me.lblContactNo.Text = "Contact No"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(116, 144)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(144, 20)
        Me.txtContactNo.TabIndex = 7
        '
        'lblDateOfReg
        '
        Me.lblDateOfReg.AutoSize = True
        Me.lblDateOfReg.Location = New System.Drawing.Point(294, 68)
        Me.lblDateOfReg.Name = "lblDateOfReg"
        Me.lblDateOfReg.Size = New System.Drawing.Size(103, 13)
        Me.lblDateOfReg.TabIndex = 8
        Me.lblDateOfReg.Text = "Date Of Registration"
        '
        'dtpDateOfReg
        '
        Me.dtpDateOfReg.Location = New System.Drawing.Point(410, 60)
        Me.dtpDateOfReg.Name = "dtpDateOfReg"
        Me.dtpDateOfReg.Size = New System.Drawing.Size(144, 20)
        Me.dtpDateOfReg.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(297, 106)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(410, 104)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 11
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(495, 104)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 12
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(297, 144)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(68, 13)
        Me.lblDateOfBirth.TabIndex = 13
        Me.lblDateOfBirth.Text = "Date Of Birth"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(410, 144)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(144, 20)
        Me.dtpDateOfBirth.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(485, 379)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(365, 379)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(236, 379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(125, 379)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 379)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gbMedicineInformation
        '
        Me.gbMedicineInformation.Controls.Add(Me.RichTextBox2)
        Me.gbMedicineInformation.Controls.Add(Me.lblCurrentProblem)
        Me.gbMedicineInformation.Controls.Add(Me.RichTextBox1)
        Me.gbMedicineInformation.Controls.Add(Me.lblHistory)
        Me.gbMedicineInformation.Location = New System.Drawing.Point(16, 194)
        Me.gbMedicineInformation.Name = "gbMedicineInformation"
        Me.gbMedicineInformation.Size = New System.Drawing.Size(544, 157)
        Me.gbMedicineInformation.TabIndex = 20
        Me.gbMedicineInformation.TabStop = False
        Me.gbMedicineInformation.Text = "Medicine Information"
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Location = New System.Drawing.Point(7, 32)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(39, 13)
        Me.lblHistory.TabIndex = 0
        Me.lblHistory.Text = "History"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(90, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(144, 96)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'lblCurrentProblem
        '
        Me.lblCurrentProblem.AutoSize = True
        Me.lblCurrentProblem.Location = New System.Drawing.Point(271, 32)
        Me.lblCurrentProblem.Name = "lblCurrentProblem"
        Me.lblCurrentProblem.Size = New System.Drawing.Size(82, 13)
        Me.lblCurrentProblem.TabIndex = 2
        Me.lblCurrentProblem.Text = "Current Problem"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(384, 32)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(144, 96)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = ""
        '
        'Patient_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.gbPatientReg)
        Me.Controls.Add(Me.dgvPatientDetails)
        Me.Name = "Patient_Registration"
        Me.Text = "Patient_Registration"
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPatientReg.ResumeLayout(False)
        Me.gbPatientReg.PerformLayout()
        Me.gbMedicineInformation.ResumeLayout(False)
        Me.gbMedicineInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPatientDetails As System.Windows.Forms.DataGridView
    Friend WithEvents gbPatientReg As System.Windows.Forms.GroupBox
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateOfReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateOfReg As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gbMedicineInformation As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCurrentProblem As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblHistory As System.Windows.Forms.Label
End Class
