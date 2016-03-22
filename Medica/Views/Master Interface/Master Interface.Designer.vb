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
        Me.PATIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientData = New Medica.patientData()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorDetails1 = New Medica.DoctorDetails()
        Me.DOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorDetails = New Medica.DoctorDetails()
        Me.DOCTORTableAdapter = New Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter()
        Me.PATIENTTableAdapter = New Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEDICADataSet = New Medica.MEDICADataSet()
        Me.DoctorTableAdapter1 = New Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter()
        Me.PATIENTTableAdapter1 = New Medica.patientDataTableAdapters.PATIENTTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockManagemenrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PATIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDetails1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.PatientToolStripMenuItem, Me.StockManagemenrToolStripMenuItem, Me.SupplierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1330, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorDetailsToolStripMenuItem, Me.StaffDetailsToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'DoctorDetailsToolStripMenuItem
        '
        Me.DoctorDetailsToolStripMenuItem.Name = "DoctorDetailsToolStripMenuItem"
        Me.DoctorDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DoctorDetailsToolStripMenuItem.Text = "Doctor Details"
        '
        'StaffDetailsToolStripMenuItem
        '
        Me.StaffDetailsToolStripMenuItem.Name = "StaffDetailsToolStripMenuItem"
        Me.StaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StaffDetailsToolStripMenuItem.Text = "Staff Details"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientDetailsToolStripMenuItem, Me.PatientEntryToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'PatientDetailsToolStripMenuItem
        '
        Me.PatientDetailsToolStripMenuItem.Name = "PatientDetailsToolStripMenuItem"
        Me.PatientDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PatientDetailsToolStripMenuItem.Text = "Patient Details"
        '
        'PatientEntryToolStripMenuItem
        '
        Me.PatientEntryToolStripMenuItem.Name = "PatientEntryToolStripMenuItem"
        Me.PatientEntryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PatientEntryToolStripMenuItem.Text = "Patient Entry"
        '
        'StockManagemenrToolStripMenuItem
        '
        Me.StockManagemenrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderDetailsToolStripMenuItem, Me.MedicineDetailsToolStripMenuItem})
        Me.StockManagemenrToolStripMenuItem.Name = "StockManagemenrToolStripMenuItem"
        Me.StockManagemenrToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.StockManagemenrToolStripMenuItem.Text = "Stock Management"
        '
        'OrderDetailsToolStripMenuItem
        '
        Me.OrderDetailsToolStripMenuItem.Name = "OrderDetailsToolStripMenuItem"
        Me.OrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierDetailsToolStripMenuItem, Me.OrderDetailsToolStripMenuItem1})
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'SupplierDetailsToolStripMenuItem
        '
        Me.SupplierDetailsToolStripMenuItem.Name = "SupplierDetailsToolStripMenuItem"
        Me.SupplierDetailsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SupplierDetailsToolStripMenuItem.Text = "Supplier Details"
        '
        'OrderDetailsToolStripMenuItem1
        '
        Me.OrderDetailsToolStripMenuItem1.Name = "OrderDetailsToolStripMenuItem1"
        Me.OrderDetailsToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.OrderDetailsToolStripMenuItem1.Text = "Order Details"
        '
        'MedicineDetailsToolStripMenuItem
        '
        Me.MedicineDetailsToolStripMenuItem.Name = "MedicineDetailsToolStripMenuItem"
        Me.MedicineDetailsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MedicineDetailsToolStripMenuItem.Text = "Medicine Details"
        '
        'Master_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 515)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Master_Interface"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suwasetha Clinic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PATIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDetails1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDICADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DOCTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorDetails As Medica.DoctorDetails
    Friend WithEvents DOCTORTableAdapter As Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter
    Friend WithEvents PATIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEDICADataSet As Medica.MEDICADataSet
    Friend WithEvents PATIENTTableAdapter As Medica.MEDICADataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorDetails1 As Medica.DoctorDetails
    Friend WithEvents DoctorTableAdapter1 As Medica.DoctorDetailsTableAdapters.DOCTORTableAdapter
    Friend WithEvents PatientData As Medica.patientData
    Friend WithEvents PATIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PATIENTTableAdapter1 As Medica.patientDataTableAdapters.PATIENTTableAdapter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoctorDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockManagemenrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
