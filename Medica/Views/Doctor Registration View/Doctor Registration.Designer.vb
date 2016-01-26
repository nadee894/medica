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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDocRegistration = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDoctorID = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.lblSpecialization = New System.Windows.Forms.Label()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.txtDoctorName = New System.Windows.Forms.TextBox()
        Me.txtSpecialization = New System.Windows.Forms.TextBox()
        Me.gbDoctorReg = New System.Windows.Forms.GroupBox()
        CType(Me.dgvDocRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDoctorReg.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDocRegistration
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocRegistration.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocRegistration.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDocRegistration.Location = New System.Drawing.Point(416, 12)
        Me.dgvDocRegistration.Name = "dgvDocRegistration"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocRegistration.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDocRegistration.Size = New System.Drawing.Size(356, 437)
        Me.dgvDocRegistration.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 321)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(109, 321)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(211, 321)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(311, 321)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 362)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDoctorID
        '
        Me.lblDoctorID.AutoSize = True
        Me.lblDoctorID.Location = New System.Drawing.Point(32, 55)
        Me.lblDoctorID.Name = "lblDoctorID"
        Me.lblDoctorID.Size = New System.Drawing.Size(53, 13)
        Me.lblDoctorID.TabIndex = 0
        Me.lblDoctorID.Text = "Doctor ID"
        '
        'lblDoctorName
        '
        Me.lblDoctorName.AutoSize = True
        Me.lblDoctorName.Location = New System.Drawing.Point(32, 130)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(70, 13)
        Me.lblDoctorName.TabIndex = 1
        Me.lblDoctorName.Text = "Doctor Name"
        '
        'lblSpecialization
        '
        Me.lblSpecialization.AutoSize = True
        Me.lblSpecialization.Location = New System.Drawing.Point(32, 200)
        Me.lblSpecialization.Name = "lblSpecialization"
        Me.lblSpecialization.Size = New System.Drawing.Size(72, 13)
        Me.lblSpecialization.TabIndex = 2
        Me.lblSpecialization.Text = "Specialization"
        '
        'txtDoctorID
        '
        Me.txtDoctorID.Location = New System.Drawing.Point(159, 52)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.Size = New System.Drawing.Size(172, 20)
        Me.txtDoctorID.TabIndex = 3
        '
        'txtDoctorName
        '
        Me.txtDoctorName.Location = New System.Drawing.Point(159, 127)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(172, 20)
        Me.txtDoctorName.TabIndex = 4
        '
        'txtSpecialization
        '
        Me.txtSpecialization.Location = New System.Drawing.Point(159, 197)
        Me.txtSpecialization.Name = "txtSpecialization"
        Me.txtSpecialization.Size = New System.Drawing.Size(172, 20)
        Me.txtSpecialization.TabIndex = 5
        '
        'gbDoctorReg
        '
        Me.gbDoctorReg.Controls.Add(Me.txtSpecialization)
        Me.gbDoctorReg.Controls.Add(Me.lblDoctorID)
        Me.gbDoctorReg.Controls.Add(Me.txtDoctorName)
        Me.gbDoctorReg.Controls.Add(Me.lblDoctorName)
        Me.gbDoctorReg.Controls.Add(Me.txtDoctorID)
        Me.gbDoctorReg.Controls.Add(Me.lblSpecialization)
        Me.gbDoctorReg.Location = New System.Drawing.Point(12, 12)
        Me.gbDoctorReg.Name = "gbDoctorReg"
        Me.gbDoctorReg.Size = New System.Drawing.Size(374, 275)
        Me.gbDoctorReg.TabIndex = 7
        Me.gbDoctorReg.TabStop = False
        Me.gbDoctorReg.Text = "Doctor Details"
        '
        'Patient_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.gbDoctorReg)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvDocRegistration)
        Me.Name = "Patient_Registration"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDocRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDoctorReg.ResumeLayout(False)
        Me.gbDoctorReg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDocRegistration As System.Windows.Forms.DataGridView
    Friend WithEvents lblSpecialization As System.Windows.Forms.Label
    Friend WithEvents lblDoctorName As System.Windows.Forms.Label
    Friend WithEvents lblDoctorID As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSpecialization As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorName As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctorID As System.Windows.Forms.TextBox
    Friend WithEvents gbDoctorReg As System.Windows.Forms.GroupBox
End Class
