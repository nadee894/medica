<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine_Details
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbMedicineDetails = New System.Windows.Forms.GroupBox()
        Me.dtpManufactureDate = New System.Windows.Forms.DateTimePicker()
        Me.lblManufacturedate = New System.Windows.Forms.Label()
        Me.lblMedicinePower = New System.Windows.Forms.Label()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.lblMedicineName = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblMedicineNo = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.txtMedicineNo = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvMedicineDetails = New System.Windows.Forms.DataGridView()
        Me.cmbManufaturer = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbMedicnePower = New System.Windows.Forms.ComboBox()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.cmbMedicineUnit = New System.Windows.Forms.ComboBox()
        Me.lblMedicineUnit = New System.Windows.Forms.Label()
        Me.gbMedicineDetails.SuspendLayout()
        CType(Me.dgvMedicineDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMedicineDetails
        '
        Me.gbMedicineDetails.Controls.Add(Me.cmbMedicineUnit)
        Me.gbMedicineDetails.Controls.Add(Me.lblMedicineUnit)
        Me.gbMedicineDetails.Controls.Add(Me.dtpExpiryDate)
        Me.gbMedicineDetails.Controls.Add(Me.lblExpiryDate)
        Me.gbMedicineDetails.Controls.Add(Me.cmbMedicnePower)
        Me.gbMedicineDetails.Controls.Add(Me.cmbCategory)
        Me.gbMedicineDetails.Controls.Add(Me.cmbManufaturer)
        Me.gbMedicineDetails.Controls.Add(Me.btnClear)
        Me.gbMedicineDetails.Controls.Add(Me.btnSearch)
        Me.gbMedicineDetails.Controls.Add(Me.btnDelete)
        Me.gbMedicineDetails.Controls.Add(Me.btnUpdate)
        Me.gbMedicineDetails.Controls.Add(Me.btnAdd)
        Me.gbMedicineDetails.Controls.Add(Me.dtpManufactureDate)
        Me.gbMedicineDetails.Controls.Add(Me.lblManufacturedate)
        Me.gbMedicineDetails.Controls.Add(Me.lblMedicinePower)
        Me.gbMedicineDetails.Controls.Add(Me.txtMedicineName)
        Me.gbMedicineDetails.Controls.Add(Me.lblMedicineName)
        Me.gbMedicineDetails.Controls.Add(Me.lblManufacturer)
        Me.gbMedicineDetails.Controls.Add(Me.lblMedicineNo)
        Me.gbMedicineDetails.Controls.Add(Me.lblcategory)
        Me.gbMedicineDetails.Controls.Add(Me.txtMedicineNo)
        Me.gbMedicineDetails.Location = New System.Drawing.Point(12, 12)
        Me.gbMedicineDetails.Name = "gbMedicineDetails"
        Me.gbMedicineDetails.Size = New System.Drawing.Size(580, 437)
        Me.gbMedicineDetails.TabIndex = 0
        Me.gbMedicineDetails.TabStop = False
        Me.gbMedicineDetails.Text = "Medicine Details"
        '
        'dtpManufactureDate
        '
        Me.dtpManufactureDate.Location = New System.Drawing.Point(114, 155)
        Me.dtpManufactureDate.Name = "dtpManufactureDate"
        Me.dtpManufactureDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpManufactureDate.TabIndex = 35
        '
        'lblManufacturedate
        '
        Me.lblManufacturedate.AutoSize = True
        Me.lblManufacturedate.Location = New System.Drawing.Point(15, 155)
        Me.lblManufacturedate.Name = "lblManufacturedate"
        Me.lblManufacturedate.Size = New System.Drawing.Size(93, 13)
        Me.lblManufacturedate.TabIndex = 34
        Me.lblManufacturedate.Text = "Manufacture Date"
        '
        'lblMedicinePower
        '
        Me.lblMedicinePower.AutoSize = True
        Me.lblMedicinePower.Location = New System.Drawing.Point(292, 72)
        Me.lblMedicinePower.Name = "lblMedicinePower"
        Me.lblMedicinePower.Size = New System.Drawing.Size(83, 13)
        Me.lblMedicinePower.TabIndex = 29
        Me.lblMedicinePower.Text = "Medicine Power"
        '
        'txtMedicineName
        '
        Me.txtMedicineName.Location = New System.Drawing.Point(114, 112)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.Size = New System.Drawing.Size(144, 20)
        Me.txtMedicineName.TabIndex = 28
        '
        'lblMedicineName
        '
        Me.lblMedicineName.AutoSize = True
        Me.lblMedicineName.Location = New System.Drawing.Point(18, 112)
        Me.lblMedicineName.Name = "lblMedicineName"
        Me.lblMedicineName.Size = New System.Drawing.Size(81, 13)
        Me.lblMedicineName.TabIndex = 27
        Me.lblMedicineName.Text = "Medicine Name"
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(292, 37)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 25
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'lblMedicineNo
        '
        Me.lblMedicineNo.AutoSize = True
        Me.lblMedicineNo.Location = New System.Drawing.Point(18, 30)
        Me.lblMedicineNo.Name = "lblMedicineNo"
        Me.lblMedicineNo.Size = New System.Drawing.Size(67, 13)
        Me.lblMedicineNo.TabIndex = 21
        Me.lblMedicineNo.Text = "Medicine No"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Location = New System.Drawing.Point(21, 72)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(49, 13)
        Me.lblcategory.TabIndex = 22
        Me.lblcategory.Text = "Category"
        '
        'txtMedicineNo
        '
        Me.txtMedicineNo.Location = New System.Drawing.Point(114, 30)
        Me.txtMedicineNo.Name = "txtMedicineNo"
        Me.txtMedicineNo.Size = New System.Drawing.Size(144, 20)
        Me.txtMedicineNo.TabIndex = 23
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(490, 213)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(370, 213)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(241, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(130, 213)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 38
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 213)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvMedicineDetails
        '
        Me.dgvMedicineDetails.AllowUserToOrderColumns = True
        Me.dgvMedicineDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMedicineDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicineDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvMedicineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicineDetails.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvMedicineDetails.Location = New System.Drawing.Point(616, 12)
        Me.dgvMedicineDetails.Name = "dgvMedicineDetails"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMedicineDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvMedicineDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvMedicineDetails.TabIndex = 1
        '
        'cmbManufaturer
        '
        Me.cmbManufaturer.FormattingEnabled = True
        Me.cmbManufaturer.Location = New System.Drawing.Point(408, 29)
        Me.cmbManufaturer.Name = "cmbManufaturer"
        Me.cmbManufaturer.Size = New System.Drawing.Size(144, 21)
        Me.cmbManufaturer.TabIndex = 42
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(114, 72)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(144, 21)
        Me.cmbCategory.TabIndex = 43
        '
        'cmbMedicnePower
        '
        Me.cmbMedicnePower.FormattingEnabled = True
        Me.cmbMedicnePower.Location = New System.Drawing.Point(408, 72)
        Me.cmbMedicnePower.Name = "cmbMedicnePower"
        Me.cmbMedicnePower.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicnePower.TabIndex = 44
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.Location = New System.Drawing.Point(408, 155)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpExpiryDate.TabIndex = 46
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Location = New System.Drawing.Point(292, 155)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(62, 13)
        Me.lblExpiryDate.TabIndex = 45
        Me.lblExpiryDate.Text = "Expire Date"
        '
        'cmbMedicineUnit
        '
        Me.cmbMedicineUnit.FormattingEnabled = True
        Me.cmbMedicineUnit.Location = New System.Drawing.Point(408, 109)
        Me.cmbMedicineUnit.Name = "cmbMedicineUnit"
        Me.cmbMedicineUnit.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicineUnit.TabIndex = 48
        '
        'lblMedicineUnit
        '
        Me.lblMedicineUnit.AutoSize = True
        Me.lblMedicineUnit.Location = New System.Drawing.Point(292, 115)
        Me.lblMedicineUnit.Name = "lblMedicineUnit"
        Me.lblMedicineUnit.Size = New System.Drawing.Size(72, 13)
        Me.lblMedicineUnit.TabIndex = 47
        Me.lblMedicineUnit.Text = "Medicine Unit"
        '
        'Medicine_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 471)
        Me.Controls.Add(Me.dgvMedicineDetails)
        Me.Controls.Add(Me.gbMedicineDetails)
        Me.Name = "Medicine_Details"
        Me.ShowIcon = False
        Me.Text = "Medicine Details"
        Me.gbMedicineDetails.ResumeLayout(False)
        Me.gbMedicineDetails.PerformLayout()
        CType(Me.dgvMedicineDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMedicineDetails As System.Windows.Forms.GroupBox
    Friend WithEvents dtpManufactureDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblManufacturedate As System.Windows.Forms.Label
    Friend WithEvents lblMedicinePower As System.Windows.Forms.Label
    Friend WithEvents txtMedicineName As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicineName As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblMedicineNo As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents txtMedicineNo As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dgvMedicineDetails As System.Windows.Forms.DataGridView
    Friend WithEvents cmbManufaturer As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMedicnePower As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMedicineUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedicineUnit As System.Windows.Forms.Label
    Friend WithEvents dtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpiryDate As System.Windows.Forms.Label
End Class
