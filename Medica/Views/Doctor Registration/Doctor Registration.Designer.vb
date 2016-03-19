<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor_Registration
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor_Registration))
        Me.gbDoctorReg = New System.Windows.Forms.GroupBox()
        Me.gbQualifications = New System.Windows.Forms.GroupBox()
        Me.txtSpecialization = New System.Windows.Forms.TextBox()
        Me.lblSpecialization = New System.Windows.Forms.Label()
        Me.txtUniversity = New System.Windows.Forms.TextBox()
        Me.txtDegree = New System.Windows.Forms.TextBox()
        Me.lbUniversity = New System.Windows.Forms.Label()
        Me.lbDegree = New System.Windows.Forms.Label()
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
        Me.txtDoctorNo = New System.Windows.Forms.TextBox()
        Me.lblDoctorNo = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.dgvDoctorDetails = New System.Windows.Forms.DataGridView()
        Me.DOCTORNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCTORNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCTORADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCREGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCGENDERDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DOCCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCBDAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorDetails = New Medica.DoctorDetails()
        Me.DOCTORTableAdapter = New Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter()
        Me.gbDoctorReg.SuspendLayout()
        Me.gbQualifications.SuspendLayout()
        CType(Me.dgvDoctorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDoctorReg
        '
        Me.gbDoctorReg.Controls.Add(Me.gbQualifications)
        Me.gbDoctorReg.Controls.Add(Me.btnClear)
        Me.gbDoctorReg.Controls.Add(Me.btnSearch)
        Me.gbDoctorReg.Controls.Add(Me.btnDelete)
        Me.gbDoctorReg.Controls.Add(Me.btnUpdate)
        Me.gbDoctorReg.Controls.Add(Me.btnAdd)
        Me.gbDoctorReg.Controls.Add(Me.dtpDateOfBirth)
        Me.gbDoctorReg.Controls.Add(Me.lblDateOfBirth)
        Me.gbDoctorReg.Controls.Add(Me.rbFemale)
        Me.gbDoctorReg.Controls.Add(Me.rbMale)
        Me.gbDoctorReg.Controls.Add(Me.lblGender)
        Me.gbDoctorReg.Controls.Add(Me.dtpDateOfReg)
        Me.gbDoctorReg.Controls.Add(Me.lblDateOfReg)
        Me.gbDoctorReg.Controls.Add(Me.txtContactNo)
        Me.gbDoctorReg.Controls.Add(Me.lblContactNo)
        Me.gbDoctorReg.Controls.Add(Me.txtDoctorNo)
        Me.gbDoctorReg.Controls.Add(Me.lblDoctorNo)
        Me.gbDoctorReg.Controls.Add(Me.lblDoctorName)
        Me.gbDoctorReg.Controls.Add(Me.txtAddress)
        Me.gbDoctorReg.Controls.Add(Me.lblAddress)
        Me.gbDoctorReg.Controls.Add(Me.txtDoctorName)
        Me.gbDoctorReg.Location = New System.Drawing.Point(12, 17)
        Me.gbDoctorReg.Name = "gbDoctorReg"
        Me.gbDoctorReg.Size = New System.Drawing.Size(580, 437)
        Me.gbDoctorReg.TabIndex = 6
        Me.gbDoctorReg.TabStop = False
        Me.gbDoctorReg.Text = "Personal Details"
        '
        'gbQualifications
        '
        Me.gbQualifications.Controls.Add(Me.txtSpecialization)
        Me.gbQualifications.Controls.Add(Me.lblSpecialization)
        Me.gbQualifications.Controls.Add(Me.txtUniversity)
        Me.gbQualifications.Controls.Add(Me.txtDegree)
        Me.gbQualifications.Controls.Add(Me.lbUniversity)
        Me.gbQualifications.Controls.Add(Me.lbDegree)
        Me.gbQualifications.Location = New System.Drawing.Point(16, 194)
        Me.gbQualifications.Name = "gbQualifications"
        Me.gbQualifications.Size = New System.Drawing.Size(544, 157)
        Me.gbQualifications.TabIndex = 20
        Me.gbQualifications.TabStop = False
        Me.gbQualifications.Text = "Educational Qualifications"
        '
        'txtSpecialization
        '
        Me.txtSpecialization.Location = New System.Drawing.Point(100, 120)
        Me.txtSpecialization.Name = "txtSpecialization"
        Me.txtSpecialization.Size = New System.Drawing.Size(144, 20)
        Me.txtSpecialization.TabIndex = 11
        '
        'lblSpecialization
        '
        Me.lblSpecialization.AutoSize = True
        Me.lblSpecialization.Location = New System.Drawing.Point(7, 120)
        Me.lblSpecialization.Name = "lblSpecialization"
        Me.lblSpecialization.Size = New System.Drawing.Size(72, 13)
        Me.lblSpecialization.TabIndex = 10
        Me.lblSpecialization.Text = "Specialization"
        '
        'txtUniversity
        '
        Me.txtUniversity.Location = New System.Drawing.Point(100, 77)
        Me.txtUniversity.Name = "txtUniversity"
        Me.txtUniversity.Size = New System.Drawing.Size(144, 20)
        Me.txtUniversity.TabIndex = 9
        '
        'txtDegree
        '
        Me.txtDegree.Location = New System.Drawing.Point(100, 29)
        Me.txtDegree.Name = "txtDegree"
        Me.txtDegree.Size = New System.Drawing.Size(144, 20)
        Me.txtDegree.TabIndex = 8
        '
        'lbUniversity
        '
        Me.lbUniversity.AutoSize = True
        Me.lbUniversity.Location = New System.Drawing.Point(7, 77)
        Me.lbUniversity.Name = "lbUniversity"
        Me.lbUniversity.Size = New System.Drawing.Size(53, 13)
        Me.lbUniversity.TabIndex = 2
        Me.lbUniversity.Text = "University"
        '
        'lbDegree
        '
        Me.lbDegree.AutoSize = True
        Me.lbDegree.Location = New System.Drawing.Point(7, 32)
        Me.lbDegree.Name = "lbDegree"
        Me.lbDegree.Size = New System.Drawing.Size(42, 13)
        Me.lbDegree.TabIndex = 0
        Me.lbDegree.Text = "Degree"
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
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Checked = True
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
        'txtDoctorNo
        '
        Me.txtDoctorNo.Location = New System.Drawing.Point(410, 26)
        Me.txtDoctorNo.Name = "txtDoctorNo"
        Me.txtDoctorNo.Size = New System.Drawing.Size(144, 20)
        Me.txtDoctorNo.TabIndex = 5
        '
        'lblDoctorNo
        '
        Me.lblDoctorNo.AutoSize = True
        Me.lblDoctorNo.Location = New System.Drawing.Point(294, 33)
        Me.lblDoctorNo.Name = "lblDoctorNo"
        Me.lblDoctorNo.Size = New System.Drawing.Size(56, 13)
        Me.lblDoctorNo.TabIndex = 4
        Me.lblDoctorNo.Text = "Doctor No"
        '
        'lblDoctorName
        '
        Me.lblDoctorName.AutoSize = True
        Me.lblDoctorName.Location = New System.Drawing.Point(20, 26)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(70, 13)
        Me.lblDoctorName.TabIndex = 0
        Me.lblDoctorName.Text = "Doctor Name"
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
        'txtDoctorName
        '
        Me.txtDoctorName.Location = New System.Drawing.Point(116, 26)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(144, 20)
        Me.txtDoctorName.TabIndex = 2
        '
        'dgvDoctorDetails
        '
        Me.dgvDoctorDetails.AllowUserToDeleteRows = False
        Me.dgvDoctorDetails.AllowUserToOrderColumns = True
        Me.dgvDoctorDetails.AutoGenerateColumns = False
        Me.dgvDoctorDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDoctorDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDoctorDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDoctorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctorDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCTORNODataGridViewTextBoxColumn, Me.DOCTORNAMEDataGridViewTextBoxColumn, Me.DOCTORADDRESSDataGridViewTextBoxColumn, Me.DOCREGDATEDataGridViewTextBoxColumn, Me.DOCGENDERDataGridViewCheckBoxColumn, Me.DOCCONTACTDataGridViewTextBoxColumn, Me.DOCBDAYDataGridViewTextBoxColumn})
        Me.dgvDoctorDetails.DataSource = Me.DOCTORBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDoctorDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDoctorDetails.Location = New System.Drawing.Point(616, 17)
        Me.dgvDoctorDetails.Name = "dgvDoctorDetails"
        Me.dgvDoctorDetails.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDoctorDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDoctorDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvDoctorDetails.TabIndex = 5
        '
        'DOCTORNODataGridViewTextBoxColumn
        '
        Me.DOCTORNODataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NO"
        Me.DOCTORNODataGridViewTextBoxColumn.HeaderText = "DOCTOR_NO"
        Me.DOCTORNODataGridViewTextBoxColumn.Name = "DOCTORNODataGridViewTextBoxColumn"
        Me.DOCTORNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCTORNAMEDataGridViewTextBoxColumn
        '
        Me.DOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME"
        Me.DOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_NAME"
        Me.DOCTORNAMEDataGridViewTextBoxColumn.Name = "DOCTORNAMEDataGridViewTextBoxColumn"
        Me.DOCTORNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCTORADDRESSDataGridViewTextBoxColumn
        '
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_ADDRESS"
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.HeaderText = "DOCTOR_ADDRESS"
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.Name = "DOCTORADDRESSDataGridViewTextBoxColumn"
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCREGDATEDataGridViewTextBoxColumn
        '
        Me.DOCREGDATEDataGridViewTextBoxColumn.DataPropertyName = "DOC_REG_DATE"
        Me.DOCREGDATEDataGridViewTextBoxColumn.HeaderText = "DOC_REG_DATE"
        Me.DOCREGDATEDataGridViewTextBoxColumn.Name = "DOCREGDATEDataGridViewTextBoxColumn"
        Me.DOCREGDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCGENDERDataGridViewCheckBoxColumn
        '
        Me.DOCGENDERDataGridViewCheckBoxColumn.DataPropertyName = "DOC_GENDER"
        Me.DOCGENDERDataGridViewCheckBoxColumn.HeaderText = "DOC_GENDER"
        Me.DOCGENDERDataGridViewCheckBoxColumn.Name = "DOCGENDERDataGridViewCheckBoxColumn"
        Me.DOCGENDERDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DOCCONTACTDataGridViewTextBoxColumn
        '
        Me.DOCCONTACTDataGridViewTextBoxColumn.DataPropertyName = "DOC_CONTACT"
        Me.DOCCONTACTDataGridViewTextBoxColumn.HeaderText = "DOC_CONTACT"
        Me.DOCCONTACTDataGridViewTextBoxColumn.Name = "DOCCONTACTDataGridViewTextBoxColumn"
        Me.DOCCONTACTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCBDAYDataGridViewTextBoxColumn
        '
        Me.DOCBDAYDataGridViewTextBoxColumn.DataPropertyName = "DOC_BDAY"
        Me.DOCBDAYDataGridViewTextBoxColumn.HeaderText = "DOC_BDAY"
        Me.DOCBDAYDataGridViewTextBoxColumn.Name = "DOCBDAYDataGridViewTextBoxColumn"
        Me.DOCBDAYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOCTORBindingSource
        '
        Me.DOCTORBindingSource.DataMember = "DOCTOR"
        Me.DOCTORBindingSource.DataSource = Me.DoctorDetails
        '
        'DoctorDetails
        '
        Me.DoctorDetails.DataSetName = "DoctorDetails"
        Me.DoctorDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DOCTORTableAdapter
        '
        Me.DOCTORTableAdapter.ClearBeforeFill = True
        '
        'Doctor_Registration
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 471)
        Me.Controls.Add(Me.gbDoctorReg)
        Me.Controls.Add(Me.dgvDoctorDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Doctor_Registration"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Registration"
        Me.gbDoctorReg.ResumeLayout(False)
        Me.gbDoctorReg.PerformLayout()
        Me.gbQualifications.ResumeLayout(False)
        Me.gbQualifications.PerformLayout()
        CType(Me.dgvDoctorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDoctorReg As System.Windows.Forms.GroupBox
    Friend WithEvents gbQualifications As System.Windows.Forms.GroupBox
    Friend WithEvents lbUniversity As System.Windows.Forms.Label
    Friend WithEvents lbDegree As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDateOfReg As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents txtDoctorNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDoctorNo As System.Windows.Forms.Label
    Friend WithEvents lblDoctorName As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtDoctorName As System.Windows.Forms.TextBox
    Friend WithEvents dgvDoctorDetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtDegree As System.Windows.Forms.TextBox
    Friend WithEvents txtUniversity As System.Windows.Forms.TextBox
    Friend WithEvents txtSpecialization As System.Windows.Forms.TextBox
    Friend WithEvents lblSpecialization As System.Windows.Forms.Label
    Friend WithEvents DoctorDetails As Medica.DoctorDetails
    Friend WithEvents DOCTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DOCTORTableAdapter As Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter
    Friend WithEvents DOCTORNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCTORNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCTORADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCREGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCGENDERDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DOCCONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCBDAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
