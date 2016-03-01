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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbStockDetails = New System.Windows.Forms.GroupBox()
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
        Me.lblMedicineNo = New System.Windows.Forms.Label()
        Me.cmbMedicineNo = New System.Windows.Forms.ComboBox()
        Me.cmbStockUnit = New System.Windows.Forms.ComboBox()
        Me.lblStockUnit = New System.Windows.Forms.Label()
        Me.gbStockDetails.SuspendLayout()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbStockDetails
        '
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
        'dtpStockDate
        '
        Me.dtpStockDate.Location = New System.Drawing.Point(114, 155)
        Me.dtpStockDate.Name = "dtpStockDate"
        Me.dtpStockDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpStockDate.TabIndex = 35
        '
        'lblStockDate
        '
        Me.lblStockDate.AutoSize = True
        Me.lblStockDate.Location = New System.Drawing.Point(15, 155)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStockDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStockDetails.Location = New System.Drawing.Point(616, 17)
        Me.dgvStockDetails.Name = "dgvStockDetails"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStockDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStockDetails.Size = New System.Drawing.Size(702, 437)
        Me.dgvStockDetails.TabIndex = 3
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
        'cmbMedicineNo
        '
        Me.cmbMedicineNo.FormattingEnabled = True
        Me.cmbMedicineNo.Location = New System.Drawing.Point(114, 73)
        Me.cmbMedicineNo.Name = "cmbMedicineNo"
        Me.cmbMedicineNo.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicineNo.TabIndex = 43
        '
        'cmbStockUnit
        '
        Me.cmbStockUnit.FormattingEnabled = True
        Me.cmbStockUnit.Location = New System.Drawing.Point(114, 113)
        Me.cmbStockUnit.Name = "cmbStockUnit"
        Me.cmbStockUnit.Size = New System.Drawing.Size(144, 21)
        Me.cmbStockUnit.TabIndex = 50
        '
        'lblStockUnit
        '
        Me.lblStockUnit.AutoSize = True
        Me.lblStockUnit.Location = New System.Drawing.Point(19, 116)
        Me.lblStockUnit.Name = "lblStockUnit"
        Me.lblStockUnit.Size = New System.Drawing.Size(57, 13)
        Me.lblStockUnit.TabIndex = 49
        Me.lblStockUnit.Text = "Stock Unit"
        '
        'Stock_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 471)
        Me.Controls.Add(Me.gbStockDetails)
        Me.Controls.Add(Me.dgvStockDetails)
        Me.Name = "Stock_Details"
        Me.ShowIcon = False
        Me.Text = "Stock Details"
        Me.gbStockDetails.ResumeLayout(False)
        Me.gbStockDetails.PerformLayout()
        CType(Me.dgvStockDetails, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
