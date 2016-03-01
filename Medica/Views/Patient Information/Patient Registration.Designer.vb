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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPatientDetails = New System.Windows.Forms.DataGridView()
        Me.PATIENTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATREGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATGENDERDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PATCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATBDAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICADataSet = New Medica.MEDICADataSet()
        Me.gbPatientReg = New System.Windows.Forms.GroupBox()
        Me.gbMedicineInformation = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lblCurrentProblem = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.dtpDateOfReg = New System.Windows.Forms.DateTimePicker()
        Me.lblDateOfReg = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.txtPatientNo = New System.Windows.Forms.TextBox()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.PATIENTTableAdapter = New Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter()
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPatientReg.SuspendLayout()
        Me.gbMedicineInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPatientDetails
        '
        Me.dgvPatientDetails.AllowUserToOrderColumns = True
        Me.dgvPatientDetails.AutoGenerateColumns = False
        Me.dgvPatientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatientDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PATIENTNODataGridViewTextBoxColumn, Me.PATIENTNAMEDataGridViewTextBoxColumn, Me.PATIENTADDRESSDataGridViewTextBoxColumn, Me.PATREGDATEDataGridViewTextBoxColumn, Me.PATGENDERDataGridViewCheckBoxColumn, Me.PATCONTACTDataGridViewTextBoxColumn, Me.PATBDAYDataGridViewTextBoxColumn})
        Me.dgvPatientDetails.DataSource = Me.PATIENTBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientDetails.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPatientDetails.Location = New System.Drawing.Point(616, 12)
        Me.dgvPatientDetails.Name = "dgvPatientDetails"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPatientDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvPatientDetails.TabIndex = 0
        '
        'PATIENTNODataGridViewTextBoxColumn
        '
        Me.PATIENTNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATIENTNODataGridViewTextBoxColumn.DataPropertyName = "PATIENT_NO"
        Me.PATIENTNODataGridViewTextBoxColumn.HeaderText = "PATIENT_NO"
        Me.PATIENTNODataGridViewTextBoxColumn.Name = "PATIENTNODataGridViewTextBoxColumn"
        '
        'PATIENTNAMEDataGridViewTextBoxColumn
        '
        Me.PATIENTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_NAME"
        Me.PATIENTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_NAME"
        Me.PATIENTNAMEDataGridViewTextBoxColumn.Name = "PATIENTNAMEDataGridViewTextBoxColumn"
        '
        'PATIENTADDRESSDataGridViewTextBoxColumn
        '
        Me.PATIENTADDRESSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATIENTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_ADDRESS"
        Me.PATIENTADDRESSDataGridViewTextBoxColumn.HeaderText = "PATIENT_ADDRESS"
        Me.PATIENTADDRESSDataGridViewTextBoxColumn.Name = "PATIENTADDRESSDataGridViewTextBoxColumn"
        '
        'PATREGDATEDataGridViewTextBoxColumn
        '
        Me.PATREGDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATREGDATEDataGridViewTextBoxColumn.DataPropertyName = "PAT_REG_DATE"
        Me.PATREGDATEDataGridViewTextBoxColumn.HeaderText = "PAT_REG_DATE"
        Me.PATREGDATEDataGridViewTextBoxColumn.Name = "PATREGDATEDataGridViewTextBoxColumn"
        '
        'PATGENDERDataGridViewCheckBoxColumn
        '
        Me.PATGENDERDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATGENDERDataGridViewCheckBoxColumn.DataPropertyName = "PAT_GENDER"
        Me.PATGENDERDataGridViewCheckBoxColumn.HeaderText = "PAT_GENDER"
        Me.PATGENDERDataGridViewCheckBoxColumn.Name = "PATGENDERDataGridViewCheckBoxColumn"
        '
        'PATCONTACTDataGridViewTextBoxColumn
        '
        Me.PATCONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATCONTACTDataGridViewTextBoxColumn.DataPropertyName = "PAT_CONTACT"
        Me.PATCONTACTDataGridViewTextBoxColumn.HeaderText = "PAT_CONTACT"
        Me.PATCONTACTDataGridViewTextBoxColumn.Name = "PATCONTACTDataGridViewTextBoxColumn"
        '
        'PATBDAYDataGridViewTextBoxColumn
        '
        Me.PATBDAYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PATBDAYDataGridViewTextBoxColumn.DataPropertyName = "PAT_BDAY"
        Me.PATBDAYDataGridViewTextBoxColumn.HeaderText = "PAT_BDAY"
        Me.PATBDAYDataGridViewTextBoxColumn.Name = "PATBDAYDataGridViewTextBoxColumn"
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.MEDICADataSet
        '
        'MEDICADataSet
        '
        Me.MEDICADataSet.DataSetName = "MEDICADataSet"
        Me.MEDICADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(384, 32)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(144, 96)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = ""
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(90, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(144, 96)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
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
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(410, 144)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(144, 20)
        Me.dtpDateOfBirth.TabIndex = 14
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
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(297, 106)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'dtpDateOfReg
        '
        Me.dtpDateOfReg.Location = New System.Drawing.Point(410, 60)
        Me.dtpDateOfReg.Name = "dtpDateOfReg"
        Me.dtpDateOfReg.Size = New System.Drawing.Size(144, 20)
        Me.dtpDateOfReg.TabIndex = 9
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
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(116, 144)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(144, 20)
        Me.txtContactNo.TabIndex = 7
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
        'txtPatientNo
        '
        Me.txtPatientNo.Location = New System.Drawing.Point(410, 26)
        Me.txtPatientNo.Name = "txtPatientNo"
        Me.txtPatientNo.Size = New System.Drawing.Size(144, 20)
        Me.txtPatientNo.TabIndex = 5
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
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(20, 26)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(71, 13)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Patient Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(116, 68)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(144, 52)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = ""
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
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(116, 26)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(144, 20)
        Me.txtPatientName.TabIndex = 2
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'Patient_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1330, 471)
        Me.Controls.Add(Me.gbPatientReg)
        Me.Controls.Add(Me.dgvPatientDetails)
        Me.Name = "Patient_Registration"
        Me.ShowIcon = False
        Me.Text = "Patient Registration"
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MEDICADataSet As Medica.MEDICADataSet
    Friend WithEvents PATIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PATIENTTableAdapter As Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents PATIENTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATREGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATGENDERDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PATCONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATBDAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
