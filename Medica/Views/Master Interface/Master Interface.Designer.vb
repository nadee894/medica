<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Interface
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabPatient = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbPatientReg = New System.Windows.Forms.GroupBox()
        Me.gbMedicineInformation = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.lblCurrentProblem = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPatientNo = New System.Windows.Forms.TextBox()
        Me.lblPatientNo = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.dgvPatientDetails = New System.Windows.Forms.DataGridView()
        Me.PATIENTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATREGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATGENDERDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PATCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATBDAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientData = New Medica.patientData()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorDetails1 = New Medica.DoctorDetails()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorDetails = New Medica.DoctorDetails()
        Me.DOCTORTableAdapter = New Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter()
        Me.PATIENTTableAdapter = New Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICADataSet = New Medica.MEDICADataSet()
        Me.DoctorTableAdapter1 = New Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter()
        Me.PATIENTTableAdapter1 = New Medica.patientDataTableAdapters.PATIENTTableAdapter()
        Me.tabPatient.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbPatientReg.SuspendLayout()
        Me.gbMedicineInformation.SuspendLayout()
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.gbDoctorReg.SuspendLayout()
        Me.gbQualifications.SuspendLayout()
        CType(Me.dgvDoctorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDetails1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPatient
        '
        Me.tabPatient.Controls.Add(Me.TabPage2)
        Me.tabPatient.Controls.Add(Me.TabPage1)
        Me.tabPatient.Controls.Add(Me.TabPage3)
        Me.tabPatient.Location = New System.Drawing.Point(3, 2)
        Me.tabPatient.Name = "tabPatient"
        Me.tabPatient.SelectedIndex = 0
        Me.tabPatient.Size = New System.Drawing.Size(1330, 514)
        Me.tabPatient.TabIndex = 0
        Me.tabPatient.Tag = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbPatientReg)
        Me.TabPage2.Controls.Add(Me.dgvPatientDetails)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1322, 488)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbPatientReg
        '
        Me.gbPatientReg.Controls.Add(Me.gbMedicineInformation)
        Me.gbPatientReg.Controls.Add(Me.Button1)
        Me.gbPatientReg.Controls.Add(Me.Button2)
        Me.gbPatientReg.Controls.Add(Me.Button3)
        Me.gbPatientReg.Controls.Add(Me.Button4)
        Me.gbPatientReg.Controls.Add(Me.Button5)
        Me.gbPatientReg.Controls.Add(Me.DateTimePicker1)
        Me.gbPatientReg.Controls.Add(Me.Label1)
        Me.gbPatientReg.Controls.Add(Me.RadioButton1)
        Me.gbPatientReg.Controls.Add(Me.RadioButton2)
        Me.gbPatientReg.Controls.Add(Me.Label2)
        Me.gbPatientReg.Controls.Add(Me.DateTimePicker2)
        Me.gbPatientReg.Controls.Add(Me.Label3)
        Me.gbPatientReg.Controls.Add(Me.TextBox1)
        Me.gbPatientReg.Controls.Add(Me.Label4)
        Me.gbPatientReg.Controls.Add(Me.txtPatientNo)
        Me.gbPatientReg.Controls.Add(Me.lblPatientNo)
        Me.gbPatientReg.Controls.Add(Me.lblPatientName)
        Me.gbPatientReg.Controls.Add(Me.RichTextBox3)
        Me.gbPatientReg.Controls.Add(Me.Label5)
        Me.gbPatientReg.Controls.Add(Me.txtPatientName)
        Me.gbPatientReg.Location = New System.Drawing.Point(8, 26)
        Me.gbPatientReg.Name = "gbPatientReg"
        Me.gbPatientReg.Size = New System.Drawing.Size(580, 437)
        Me.gbPatientReg.TabIndex = 6
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(485, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(365, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 379)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(125, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 379)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(410, 144)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date Of Birth"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(495, 104)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Female"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(410, 104)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Male"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Gender"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(410, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date Of Registration"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact No"
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
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(116, 68)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(144, 52)
        Me.RichTextBox3.TabIndex = 3
        Me.RichTextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Address"
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(116, 26)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(144, 20)
        Me.txtPatientName.TabIndex = 2
        '
        'dgvPatientDetails
        '
        Me.dgvPatientDetails.AllowUserToOrderColumns = True
        Me.dgvPatientDetails.AutoGenerateColumns = False
        Me.dgvPatientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPatientDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatientDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PATIENTNODataGridViewTextBoxColumn, Me.PATIENTNAMEDataGridViewTextBoxColumn, Me.PATIENTADDRESSDataGridViewTextBoxColumn, Me.PATREGDATEDataGridViewTextBoxColumn, Me.PATGENDERDataGridViewCheckBoxColumn, Me.PATCONTACTDataGridViewTextBoxColumn, Me.PATBDAYDataGridViewTextBoxColumn})
        Me.dgvPatientDetails.DataSource = Me.PATIENTBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatientDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatientDetails.Location = New System.Drawing.Point(612, 26)
        Me.dgvPatientDetails.Name = "dgvPatientDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatientDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPatientDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvPatientDetails.TabIndex = 5
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
        'PATIENTBindingSource1
        '
        Me.PATIENTBindingSource1.DataMember = "PATIENT"
        Me.PATIENTBindingSource1.DataSource = Me.PatientData
        '
        'PatientData
        '
        Me.PatientData.DataSetName = "patientData"
        Me.PatientData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbDoctorReg)
        Me.TabPage1.Controls.Add(Me.dgvDoctorDetails)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1322, 488)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.gbDoctorReg.Location = New System.Drawing.Point(8, 26)
        Me.gbDoctorReg.Name = "gbDoctorReg"
        Me.gbDoctorReg.Size = New System.Drawing.Size(580, 437)
        Me.gbDoctorReg.TabIndex = 8
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
        Me.dgvDoctorDetails.AllowUserToOrderColumns = True
        Me.dgvDoctorDetails.AutoGenerateColumns = False
        Me.dgvDoctorDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDoctorDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDoctorDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDoctorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctorDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCTORNODataGridViewTextBoxColumn, Me.DOCTORNAMEDataGridViewTextBoxColumn, Me.DOCTORADDRESSDataGridViewTextBoxColumn, Me.DOCREGDATEDataGridViewTextBoxColumn, Me.DOCGENDERDataGridViewCheckBoxColumn, Me.DOCCONTACTDataGridViewTextBoxColumn, Me.DOCBDAYDataGridViewTextBoxColumn})
        Me.dgvDoctorDetails.DataSource = Me.BindingSource1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDoctorDetails.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDoctorDetails.Location = New System.Drawing.Point(612, 26)
        Me.dgvDoctorDetails.Name = "dgvDoctorDetails"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDoctorDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDoctorDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvDoctorDetails.TabIndex = 7
        '
        'DOCTORNODataGridViewTextBoxColumn
        '
        Me.DOCTORNODataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NO"
        Me.DOCTORNODataGridViewTextBoxColumn.HeaderText = "DOCTOR_NO"
        Me.DOCTORNODataGridViewTextBoxColumn.Name = "DOCTORNODataGridViewTextBoxColumn"
        '
        'DOCTORNAMEDataGridViewTextBoxColumn
        '
        Me.DOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME"
        Me.DOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_NAME"
        Me.DOCTORNAMEDataGridViewTextBoxColumn.Name = "DOCTORNAMEDataGridViewTextBoxColumn"
        '
        'DOCTORADDRESSDataGridViewTextBoxColumn
        '
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_ADDRESS"
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.HeaderText = "DOCTOR_ADDRESS"
        Me.DOCTORADDRESSDataGridViewTextBoxColumn.Name = "DOCTORADDRESSDataGridViewTextBoxColumn"
        '
        'DOCREGDATEDataGridViewTextBoxColumn
        '
        Me.DOCREGDATEDataGridViewTextBoxColumn.DataPropertyName = "DOC_REG_DATE"
        Me.DOCREGDATEDataGridViewTextBoxColumn.HeaderText = "DOC_REG_DATE"
        Me.DOCREGDATEDataGridViewTextBoxColumn.Name = "DOCREGDATEDataGridViewTextBoxColumn"
        '
        'DOCGENDERDataGridViewCheckBoxColumn
        '
        Me.DOCGENDERDataGridViewCheckBoxColumn.DataPropertyName = "DOC_GENDER"
        Me.DOCGENDERDataGridViewCheckBoxColumn.HeaderText = "DOC_GENDER"
        Me.DOCGENDERDataGridViewCheckBoxColumn.Name = "DOCGENDERDataGridViewCheckBoxColumn"
        '
        'DOCCONTACTDataGridViewTextBoxColumn
        '
        Me.DOCCONTACTDataGridViewTextBoxColumn.DataPropertyName = "DOC_CONTACT"
        Me.DOCCONTACTDataGridViewTextBoxColumn.HeaderText = "DOC_CONTACT"
        Me.DOCCONTACTDataGridViewTextBoxColumn.Name = "DOCCONTACTDataGridViewTextBoxColumn"
        '
        'DOCBDAYDataGridViewTextBoxColumn
        '
        Me.DOCBDAYDataGridViewTextBoxColumn.DataPropertyName = "DOC_BDAY"
        Me.DOCBDAYDataGridViewTextBoxColumn.HeaderText = "DOC_BDAY"
        Me.DOCBDAYDataGridViewTextBoxColumn.Name = "DOCBDAYDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "DOCTOR"
        Me.BindingSource1.DataSource = Me.DoctorDetails1
        '
        'DoctorDetails1
        '
        Me.DoctorDetails1.DataSetName = "DoctorDetails"
        Me.DoctorDetails1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1322, 488)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
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
        'DoctorTableAdapter1
        '
        Me.DoctorTableAdapter1.ClearBeforeFill = True
        '
        'PATIENTTableAdapter1
        '
        Me.PATIENTTableAdapter1.ClearBeforeFill = True
        '
        'Master_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 515)
        Me.Controls.Add(Me.tabPatient)
        Me.Name = "Master_Interface"
        Me.ShowIcon = False
        Me.Text = "Suwasetha Clinic"
        Me.tabPatient.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gbPatientReg.ResumeLayout(False)
        Me.gbPatientReg.PerformLayout()
        Me.gbMedicineInformation.ResumeLayout(False)
        Me.gbMedicineInformation.PerformLayout()
        CType(Me.dgvPatientDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.gbDoctorReg.ResumeLayout(False)
        Me.gbDoctorReg.PerformLayout()
        Me.gbQualifications.ResumeLayout(False)
        Me.gbQualifications.PerformLayout()
        CType(Me.dgvDoctorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDetails1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPatient As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DOCTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorDetails As Medica.DoctorDetails
    Friend WithEvents DOCTORTableAdapter As Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter
    Friend WithEvents gbPatientReg As System.Windows.Forms.GroupBox
    Friend WithEvents gbMedicineInformation As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCurrentProblem As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblHistory As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPatientNo As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents dgvPatientDetails As System.Windows.Forms.DataGridView
    Friend WithEvents PATIENTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATREGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATGENDERDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PATCONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATBDAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICADataSet As Medica.MEDICADataSet
    Friend WithEvents PATIENTTableAdapter As Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gbDoctorReg As System.Windows.Forms.GroupBox
    Friend WithEvents gbQualifications As System.Windows.Forms.GroupBox
    Friend WithEvents txtSpecialization As System.Windows.Forms.TextBox
    Friend WithEvents lblSpecialization As System.Windows.Forms.Label
    Friend WithEvents txtUniversity As System.Windows.Forms.TextBox
    Friend WithEvents txtDegree As System.Windows.Forms.TextBox
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
    Friend WithEvents DOCTORNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCTORNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCTORADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCREGDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCGENDERDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DOCCONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCBDAYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorDetails1 As Medica.DoctorDetails
    Friend WithEvents DoctorTableAdapter1 As Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PatientData As Medica.patientData
    Friend WithEvents PATIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PATIENTTableAdapter1 As Medica.patientDataTableAdapters.PATIENTTableAdapter
End Class
