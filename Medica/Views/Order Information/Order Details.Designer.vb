<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Details
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbMedicineUnit = New System.Windows.Forms.ComboBox()
        Me.lblMedicineUnit = New System.Windows.Forms.Label()
        Me.gbOrderDetails = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbManufaturer = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.lblOrderdate = New System.Windows.Forms.Label()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.lblMedicineName = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.txtPricePerUnit = New System.Windows.Forms.TextBox()
        Me.lblPriceperUnit = New System.Windows.Forms.Label()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.gbOrderDetails.SuspendLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'gbOrderDetails
        '
        Me.gbOrderDetails.Controls.Add(Me.txtTotalAmt)
        Me.gbOrderDetails.Controls.Add(Me.lblTotalAmt)
        Me.gbOrderDetails.Controls.Add(Me.txtPricePerUnit)
        Me.gbOrderDetails.Controls.Add(Me.lblPriceperUnit)
        Me.gbOrderDetails.Controls.Add(Me.cmbMedicineUnit)
        Me.gbOrderDetails.Controls.Add(Me.lblMedicineUnit)
        Me.gbOrderDetails.Controls.Add(Me.cmbCategory)
        Me.gbOrderDetails.Controls.Add(Me.cmbManufaturer)
        Me.gbOrderDetails.Controls.Add(Me.btnClear)
        Me.gbOrderDetails.Controls.Add(Me.btnSearch)
        Me.gbOrderDetails.Controls.Add(Me.btnDelete)
        Me.gbOrderDetails.Controls.Add(Me.btnUpdate)
        Me.gbOrderDetails.Controls.Add(Me.btnAdd)
        Me.gbOrderDetails.Controls.Add(Me.dtpOrderDate)
        Me.gbOrderDetails.Controls.Add(Me.lblOrderdate)
        Me.gbOrderDetails.Controls.Add(Me.txtMedicineName)
        Me.gbOrderDetails.Controls.Add(Me.lblMedicineName)
        Me.gbOrderDetails.Controls.Add(Me.lblManufacturer)
        Me.gbOrderDetails.Controls.Add(Me.lblOrderID)
        Me.gbOrderDetails.Controls.Add(Me.lblcategory)
        Me.gbOrderDetails.Controls.Add(Me.txtOrderID)
        Me.gbOrderDetails.Location = New System.Drawing.Point(12, 17)
        Me.gbOrderDetails.Name = "gbOrderDetails"
        Me.gbOrderDetails.Size = New System.Drawing.Size(580, 437)
        Me.gbOrderDetails.TabIndex = 2
        Me.gbOrderDetails.TabStop = False
        Me.gbOrderDetails.Text = "Order Details"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(114, 72)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(144, 21)
        Me.cmbCategory.TabIndex = 43
        '
        'cmbManufaturer
        '
        Me.cmbManufaturer.FormattingEnabled = True
        Me.cmbManufaturer.Location = New System.Drawing.Point(408, 29)
        Me.cmbManufaturer.Name = "cmbManufaturer"
        Me.cmbManufaturer.Size = New System.Drawing.Size(144, 21)
        Me.cmbManufaturer.TabIndex = 42
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
        'dtpOrderDate
        '
        Me.dtpOrderDate.Location = New System.Drawing.Point(408, 72)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpOrderDate.TabIndex = 35
        '
        'lblOrderdate
        '
        Me.lblOrderdate.AutoSize = True
        Me.lblOrderdate.Location = New System.Drawing.Point(292, 78)
        Me.lblOrderdate.Name = "lblOrderdate"
        Me.lblOrderdate.Size = New System.Drawing.Size(59, 13)
        Me.lblOrderdate.TabIndex = 34
        Me.lblOrderdate.Text = "Order Date"
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
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(18, 30)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderID.TabIndex = 21
        Me.lblOrderID.Text = "Order ID"
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
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(114, 30)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(144, 20)
        Me.txtOrderID.TabIndex = 23
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToOrderColumns = True
        Me.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrderDetails.Location = New System.Drawing.Point(616, 17)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvOrderDetails.TabIndex = 3
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Location = New System.Drawing.Point(292, 152)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(70, 13)
        Me.lblTotalAmt.TabIndex = 51
        Me.lblTotalAmt.Text = "Total Amount"
        '
        'txtPricePerUnit
        '
        Me.txtPricePerUnit.Location = New System.Drawing.Point(114, 149)
        Me.txtPricePerUnit.Name = "txtPricePerUnit"
        Me.txtPricePerUnit.Size = New System.Drawing.Size(144, 20)
        Me.txtPricePerUnit.TabIndex = 50
        '
        'lblPriceperUnit
        '
        Me.lblPriceperUnit.AutoSize = True
        Me.lblPriceperUnit.Location = New System.Drawing.Point(18, 149)
        Me.lblPriceperUnit.Name = "lblPriceperUnit"
        Me.lblPriceperUnit.Size = New System.Drawing.Size(72, 13)
        Me.lblPriceperUnit.TabIndex = 49
        Me.lblPriceperUnit.Text = "Price Per Unit"
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Location = New System.Drawing.Point(408, 152)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(144, 20)
        Me.txtTotalAmt.TabIndex = 52
        '
        'Order_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 471)
        Me.Controls.Add(Me.gbOrderDetails)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Name = "Order_Details"
        Me.ShowIcon = False
        Me.Text = "Order Details"
        Me.gbOrderDetails.ResumeLayout(False)
        Me.gbOrderDetails.PerformLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbMedicineUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblMedicineUnit As System.Windows.Forms.Label
    Friend WithEvents gbOrderDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbManufaturer As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOrderdate As System.Windows.Forms.Label
    Friend WithEvents txtMedicineName As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicineName As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents txtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents dgvOrderDetails As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAmt As System.Windows.Forms.Label
    Friend WithEvents txtPricePerUnit As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceperUnit As System.Windows.Forms.Label
End Class
