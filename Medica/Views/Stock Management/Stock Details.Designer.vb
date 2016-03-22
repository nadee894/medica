<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Details
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock_Details))
        Me.gbStockDetails = New System.Windows.Forms.GroupBox()
        Me.gbAddStockUnits = New System.Windows.Forms.GroupBox()
        Me.txtStockUnit = New System.Windows.Forms.TextBox()
        Me.lblStockUnit1 = New System.Windows.Forms.Label()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.btnSearch1 = New System.Windows.Forms.Button()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.btnUpdate1 = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.lblSotckId1 = New System.Windows.Forms.Label()
        Me.txtStockId1 = New System.Windows.Forms.TextBox()
        Me.cmbStockUnit = New System.Windows.Forms.ComboBox()
        Me.lblStockUnit = New System.Windows.Forms.Label()
        Me.cmbMedicineNo = New System.Windows.Forms.ComboBox()
        Me.lblMedicineNo = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtpStockDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStockDate = New System.Windows.Forms.Label()
        Me.lblStockId = New System.Windows.Forms.Label()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.dgvStockDetails = New System.Windows.Forms.DataGridView()
        Me.dgvStockUnitDetails = New System.Windows.Forms.DataGridView()
        Me.STOCKUNITIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKUNITNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKUNITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STOCK_UNITDataSet1 = New Medica.STOCK_UNITDataSet1()
        Me.STOCK_UNITTableAdapter = New Medica.STOCK_UNITDataSet1TableAdapters.STOCK_UNITTableAdapter()
        Me.STOCK_UNIT_NAMEToolStrip = New System.Windows.Forms.ToolStrip()
        Me.STOCK_UNIT_NAMEToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.STOCK_UNIT_NAMEToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.STOCK_UNIT_NAMEToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.gbStockDetails.SuspendLayout()
        Me.gbAddStockUnits.SuspendLayout()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStockUnitDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKUNITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCK_UNITDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STOCK_UNIT_NAMEToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbStockDetails
        '
        Me.gbStockDetails.Controls.Add(Me.gbAddStockUnits)
        Me.gbStockDetails.Controls.Add(Me.cmbStockUnit)
        Me.gbStockDetails.Controls.Add(Me.lblStockUnit)
        Me.gbStockDetails.Controls.Add(Me.cmbMedicineNo)
        Me.gbStockDetails.Controls.Add(Me.lblMedicineNo)
        Me.gbStockDetails.Controls.Add(Me.btnClear)
        Me.gbStockDetails.Controls.Add(Me.btnSearch)
        Me.gbStockDetails.Controls.Add(Me.btnDelete)
        Me.gbStockDetails.Controls.Add(Me.btnUpdate)
        Me.gbStockDetails.Controls.Add(Me.btnAdd)
        Me.gbStockDetails.Controls.Add(Me.dtpStockDate)
        Me.gbStockDetails.Controls.Add(Me.lblStockDate)
        Me.gbStockDetails.Controls.Add(Me.lblStockId)
        Me.gbStockDetails.Controls.Add(Me.txtStockID)
        Me.gbStockDetails.Location = New System.Drawing.Point(12, 17)
        Me.gbStockDetails.Name = "gbStockDetails"
        Me.gbStockDetails.Size = New System.Drawing.Size(580, 437)
        Me.gbStockDetails.TabIndex = 2
        Me.gbStockDetails.TabStop = False
        Me.gbStockDetails.Text = "Stock Details"
        '
        'gbAddStockUnits
        '
        Me.gbAddStockUnits.Controls.Add(Me.STOCK_UNIT_NAMEToolStrip)
        Me.gbAddStockUnits.Controls.Add(Me.txtStockUnit)
        Me.gbAddStockUnits.Controls.Add(Me.lblStockUnit1)
        Me.gbAddStockUnits.Controls.Add(Me.btnClear1)
        Me.gbAddStockUnits.Controls.Add(Me.btnSearch1)
        Me.gbAddStockUnits.Controls.Add(Me.btnDelete1)
        Me.gbAddStockUnits.Controls.Add(Me.btnUpdate1)
        Me.gbAddStockUnits.Controls.Add(Me.btnAdd1)
        Me.gbAddStockUnits.Controls.Add(Me.lblSotckId1)
        Me.gbAddStockUnits.Controls.Add(Me.txtStockId1)
        Me.gbAddStockUnits.Location = New System.Drawing.Point(21, 182)
        Me.gbAddStockUnits.Name = "gbAddStockUnits"
        Me.gbAddStockUnits.Size = New System.Drawing.Size(542, 235)
        Me.gbAddStockUnits.TabIndex = 51
        Me.gbAddStockUnits.TabStop = False
        Me.gbAddStockUnits.Text = "Add Stock Unit"
        '
        'txtStockUnit
        '
        Me.txtStockUnit.Location = New System.Drawing.Point(111, 99)
        Me.txtStockUnit.Name = "txtStockUnit"
        Me.txtStockUnit.Size = New System.Drawing.Size(144, 20)
        Me.txtStockUnit.TabIndex = 63
        '
        'lblStockUnit1
        '
        Me.lblStockUnit1.AutoSize = True
        Me.lblStockUnit1.Location = New System.Drawing.Point(16, 102)
        Me.lblStockUnit1.Name = "lblStockUnit1"
        Me.lblStockUnit1.Size = New System.Drawing.Size(57, 13)
        Me.lblStockUnit1.TabIndex = 62
        Me.lblStockUnit1.Text = "Stock Unit"
        '
        'btnClear1
        '
        Me.btnClear1.Location = New System.Drawing.Point(449, 158)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(75, 23)
        Me.btnClear1.TabIndex = 59
        Me.btnClear1.Text = "Clear"
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnSearch1
        '
        Me.btnSearch1.Location = New System.Drawing.Point(338, 158)
        Me.btnSearch1.Name = "btnSearch1"
        Me.btnSearch1.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch1.TabIndex = 58
        Me.btnSearch1.Text = "Search"
        Me.btnSearch1.UseVisualStyleBackColor = True
        '
        'btnDelete1
        '
        Me.btnDelete1.Location = New System.Drawing.Point(231, 158)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete1.TabIndex = 57
        Me.btnDelete1.Text = "Delete"
        Me.btnDelete1.UseVisualStyleBackColor = True
        '
        'btnUpdate1
        '
        Me.btnUpdate1.Location = New System.Drawing.Point(123, 158)
        Me.btnUpdate1.Name = "btnUpdate1"
        Me.btnUpdate1.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate1.TabIndex = 56
        Me.btnUpdate1.Text = "Update"
        Me.btnUpdate1.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(18, 158)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1.TabIndex = 55
        Me.btnAdd1.Text = "Add"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'lblSotckId1
        '
        Me.lblSotckId1.AutoSize = True
        Me.lblSotckId1.Location = New System.Drawing.Point(15, 57)
        Me.lblSotckId1.Name = "lblSotckId1"
        Me.lblSotckId1.Size = New System.Drawing.Size(49, 13)
        Me.lblSotckId1.TabIndex = 51
        Me.lblSotckId1.Text = "Stock ID"
        '
        'txtStockId1
        '
        Me.txtStockId1.Location = New System.Drawing.Point(111, 57)
        Me.txtStockId1.Name = "txtStockId1"
        Me.txtStockId1.Size = New System.Drawing.Size(144, 20)
        Me.txtStockId1.TabIndex = 52
        '
        'cmbStockUnit
        '
        Me.cmbStockUnit.FormattingEnabled = True
        Me.cmbStockUnit.Location = New System.Drawing.Point(383, 34)
        Me.cmbStockUnit.Name = "cmbStockUnit"
        Me.cmbStockUnit.Size = New System.Drawing.Size(144, 21)
        Me.cmbStockUnit.TabIndex = 50
        '
        'lblStockUnit
        '
        Me.lblStockUnit.AutoSize = True
        Me.lblStockUnit.Location = New System.Drawing.Point(288, 37)
        Me.lblStockUnit.Name = "lblStockUnit"
        Me.lblStockUnit.Size = New System.Drawing.Size(57, 13)
        Me.lblStockUnit.TabIndex = 49
        Me.lblStockUnit.Text = "Stock Unit"
        '
        'cmbMedicineNo
        '
        Me.cmbMedicineNo.FormattingEnabled = True
        Me.cmbMedicineNo.Location = New System.Drawing.Point(114, 73)
        Me.cmbMedicineNo.Name = "cmbMedicineNo"
        Me.cmbMedicineNo.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicineNo.TabIndex = 43
        '
        'lblMedicineNo
        '
        Me.lblMedicineNo.AutoSize = True
        Me.lblMedicineNo.Location = New System.Drawing.Point(18, 73)
        Me.lblMedicineNo.Name = "lblMedicineNo"
        Me.lblMedicineNo.Size = New System.Drawing.Size(67, 13)
        Me.lblMedicineNo.TabIndex = 42
        Me.lblMedicineNo.Text = "Medicine No"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(488, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(368, 135)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(239, 135)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(128, 135)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 38
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(19, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtpStockDate
        '
        Me.dtpStockDate.Location = New System.Drawing.Point(383, 76)
        Me.dtpStockDate.Name = "dtpStockDate"
        Me.dtpStockDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpStockDate.TabIndex = 35
        '
        'lblStockDate
        '
        Me.lblStockDate.AutoSize = True
        Me.lblStockDate.Location = New System.Drawing.Point(284, 76)
        Me.lblStockDate.Name = "lblStockDate"
        Me.lblStockDate.Size = New System.Drawing.Size(61, 13)
        Me.lblStockDate.TabIndex = 34
        Me.lblStockDate.Text = "Stock Date"
        '
        'lblStockId
        '
        Me.lblStockId.AutoSize = True
        Me.lblStockId.Location = New System.Drawing.Point(18, 30)
        Me.lblStockId.Name = "lblStockId"
        Me.lblStockId.Size = New System.Drawing.Size(49, 13)
        Me.lblStockId.TabIndex = 21
        Me.lblStockId.Text = "Stock ID"
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(114, 30)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(144, 20)
        Me.txtStockID.TabIndex = 23
        '
        'dgvStockDetails
        '
        Me.dgvStockDetails.AllowUserToOrderColumns = True
        Me.dgvStockDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockDetails.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvStockDetails.Location = New System.Drawing.Point(616, 17)
        Me.dgvStockDetails.Name = "dgvStockDetails"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvStockDetails.Size = New System.Drawing.Size(702, 219)
        Me.dgvStockDetails.TabIndex = 3
        '
        'dgvStockUnitDetails
        '
        Me.dgvStockUnitDetails.AllowUserToDeleteRows = False
        Me.dgvStockUnitDetails.AllowUserToOrderColumns = True
        Me.dgvStockUnitDetails.AutoGenerateColumns = False
        Me.dgvStockUnitDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStockUnitDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockUnitDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvStockUnitDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStockUnitDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STOCKUNITIDDataGridViewTextBoxColumn, Me.STOCKUNITNAMEDataGridViewTextBoxColumn})
        Me.dgvStockUnitDetails.DataSource = Me.STOCKUNITBindingSource
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockUnitDetails.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvStockUnitDetails.Location = New System.Drawing.Point(616, 256)
        Me.dgvStockUnitDetails.Name = "dgvStockUnitDetails"
        Me.dgvStockUnitDetails.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockUnitDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvStockUnitDetails.Size = New System.Drawing.Size(702, 189)
        Me.dgvStockUnitDetails.TabIndex = 4
        '
        'STOCKUNITIDDataGridViewTextBoxColumn
        '
        Me.STOCKUNITIDDataGridViewTextBoxColumn.DataPropertyName = "STOCK_UNIT_ID"
        Me.STOCKUNITIDDataGridViewTextBoxColumn.HeaderText = "STOCK UNIT ID"
        Me.STOCKUNITIDDataGridViewTextBoxColumn.Name = "STOCKUNITIDDataGridViewTextBoxColumn"
        Me.STOCKUNITIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STOCKUNITNAMEDataGridViewTextBoxColumn
        '
        Me.STOCKUNITNAMEDataGridViewTextBoxColumn.DataPropertyName = "STOCK_UNIT_NAME"
        Me.STOCKUNITNAMEDataGridViewTextBoxColumn.HeaderText = "STOCK UNIT NAME"
        Me.STOCKUNITNAMEDataGridViewTextBoxColumn.Name = "STOCKUNITNAMEDataGridViewTextBoxColumn"
        Me.STOCKUNITNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STOCKUNITBindingSource
        '
        Me.STOCKUNITBindingSource.DataMember = "STOCK_UNIT"
        Me.STOCKUNITBindingSource.DataSource = Me.STOCK_UNITDataSet1
        '
        'STOCK_UNITDataSet1
        '
        Me.STOCK_UNITDataSet1.DataSetName = "STOCK_UNITDataSet1"
        Me.STOCK_UNITDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STOCK_UNITTableAdapter
        '
        Me.STOCK_UNITTableAdapter.ClearBeforeFill = True
        '
        'STOCK_UNIT_NAMEToolStrip
        '
        Me.STOCK_UNIT_NAMEToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STOCK_UNIT_NAMEToolStripLabel, Me.STOCK_UNIT_NAMEToolStripTextBox, Me.STOCK_UNIT_NAMEToolStripButton, Me.ToolStripButton1})
        Me.STOCK_UNIT_NAMEToolStrip.Location = New System.Drawing.Point(3, 16)
        Me.STOCK_UNIT_NAMEToolStrip.Name = "STOCK_UNIT_NAMEToolStrip"
        Me.STOCK_UNIT_NAMEToolStrip.Size = New System.Drawing.Size(536, 25)
        Me.STOCK_UNIT_NAMEToolStrip.TabIndex = 64
        Me.STOCK_UNIT_NAMEToolStrip.Text = "STOCK_UNIT_NAMEToolStrip"
        '
        'STOCK_UNIT_NAMEToolStripLabel
        '
        Me.STOCK_UNIT_NAMEToolStripLabel.Name = "STOCK_UNIT_NAMEToolStripLabel"
        Me.STOCK_UNIT_NAMEToolStripLabel.Size = New System.Drawing.Size(61, 22)
        Me.STOCK_UNIT_NAMEToolStripLabel.Text = "Stock Unit"
        '
        'STOCK_UNIT_NAMEToolStripTextBox
        '
        Me.STOCK_UNIT_NAMEToolStripTextBox.Name = "STOCK_UNIT_NAMEToolStripTextBox"
        Me.STOCK_UNIT_NAMEToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'STOCK_UNIT_NAMEToolStripButton
        '
        Me.STOCK_UNIT_NAMEToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.STOCK_UNIT_NAMEToolStripButton.Name = "STOCK_UNIT_NAMEToolStripButton"
        Me.STOCK_UNIT_NAMEToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.STOCK_UNIT_NAMEToolStripButton.Text = "Search"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Stock_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 474)
        Me.Controls.Add(Me.dgvStockUnitDetails)
        Me.Controls.Add(Me.gbStockDetails)
        Me.Controls.Add(Me.dgvStockDetails)
        Me.Name = "Stock_Details"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Details"
        Me.gbStockDetails.ResumeLayout(False)
        Me.gbStockDetails.PerformLayout()
        Me.gbAddStockUnits.ResumeLayout(False)
        Me.gbAddStockUnits.PerformLayout()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStockUnitDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKUNITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCK_UNITDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STOCK_UNIT_NAMEToolStrip.ResumeLayout(False)
        Me.STOCK_UNIT_NAMEToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbStockDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpStockDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStockDate As System.Windows.Forms.Label
    Friend WithEvents lblStockId As System.Windows.Forms.Label
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents dgvStockDetails As System.Windows.Forms.DataGridView
    Friend WithEvents lblMedicineNo As System.Windows.Forms.Label
    Friend WithEvents cmbMedicineNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStockUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblStockUnit As System.Windows.Forms.Label
    Friend WithEvents gbAddStockUnits As System.Windows.Forms.GroupBox
    Friend WithEvents lblStockUnit1 As System.Windows.Forms.Label
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents btnSearch1 As System.Windows.Forms.Button
    Friend WithEvents btnDelete1 As System.Windows.Forms.Button
    Friend WithEvents btnUpdate1 As System.Windows.Forms.Button
    Friend WithEvents btnAdd1 As System.Windows.Forms.Button
    Friend WithEvents lblSotckId1 As System.Windows.Forms.Label
    Friend WithEvents txtStockId1 As System.Windows.Forms.TextBox
    Friend WithEvents txtStockUnit As System.Windows.Forms.TextBox
    Friend WithEvents dgvStockUnitDetails As System.Windows.Forms.DataGridView
    Friend WithEvents STOCK_UNITDataSet1 As Medica.STOCK_UNITDataSet1
    Friend WithEvents STOCKUNITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STOCK_UNITTableAdapter As Medica.STOCK_UNITDataSet1TableAdapters.STOCK_UNITTableAdapter
    Friend WithEvents STOCKUNITIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOCKUNITNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOCK_UNIT_NAMEToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents STOCK_UNIT_NAMEToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents STOCK_UNIT_NAMEToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents STOCK_UNIT_NAMEToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
