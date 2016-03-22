Imports Medica.DataAccess
Imports Medica.IdAutoGeneration

Public Class Stock_Details

    Dim da As DataAccess
    Dim newId As IdAutoGeneration

    Private Sub stockUnitClear()
        txtStockId1.Text = newId.GenerateID("STOCK_UNIT", "STOCK_UNIT_ID")
        txtStockID.Text = newId.GenerateID("STOCK_UNIT", "STOCK_UNIT_ID")
        txtStockUnit.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Stock_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STOCK_UNITDataSet1.STOCK_UNIT' table. You can move, or remove it, as needed.
        Me.STOCK_UNITTableAdapter.Fill(Me.STOCK_UNITDataSet1.STOCK_UNIT)
        'ID Auto Generation
        da = New DataAccess
        Me.txtStockId1.Enabled = False
        newId = New IdAutoGeneration
        Dim ID As Integer = newId.GenerateID("STOCK_UNIT", "STOCK_UNIT_ID")
        Me.txtStockId1.Text = ID.ToString

    End Sub

    Private Sub btnAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd1.Click
        da = New DataAccess
        Dim result As Integer = da.insertStockUnit(Int32.Parse(txtStockId1.Text), txtStockUnit.Text)
        If (result = 1) Then
            MessageBox.Show("Stock Unit Successfully Added")
            Me.STOCK_UNITTableAdapter.Fill(Me.STOCK_UNITDataSet1.STOCK_UNIT)
            stockUnitClear()
        Else
            MessageBox.Show("Error in Insertion", "Invalid")
        End If

    End Sub

    Private Sub btnDelete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete1.Click
        da = New DataAccess
        Dim result As Integer = da.deleteStockUnit(Int32.Parse(txtStockId1.Text))
        If (result = 1) Then
            MessageBox.Show("Stock Unit Successfully Deleted")
            Me.STOCK_UNITTableAdapter.Fill(Me.STOCK_UNITDataSet1.STOCK_UNIT)
            stockUnitClear()
        Else
            MessageBox.Show("Error in deletion", "Invalid")
        End If
    End Sub

    Private Sub dgvStockUnitDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStockUnitDetails.CellContentClick
        Dim row As DataGridViewRow = dgvStockUnitDetails.CurrentRow
        txtStockId1.Text = row.Cells(0).Value.ToString
        txtStockUnit.Text = row.Cells(1).Value.ToString
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        stockUnitClear()
    End Sub

    Private Sub btnUpdate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate1.Click
        da = New DataAccess
        Dim result = da.updateStockUnit(Int32.Parse(txtStockId1.Text), txtStockUnit.Text)
        If (result = 1) Then
            MessageBox.Show("Stock Unit Successfully Updated")
            Me.STOCK_UNITTableAdapter.Fill(Me.STOCK_UNITDataSet1.STOCK_UNIT)
            stockUnitClear()
        Else
            MessageBox.Show("Error in Updating.", "Invalid")
        End If
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        txtStockId1.Enabled = True

        'Try
        '    Me.STOCK_UNITTableAdapter.STOCK_UNIT_NAME(Me.STOCK_UNITDataSet1.STOCK_UNIT, txtStockUnit.Text & "%")
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)

        'End Try
    End Sub

    Private Sub STOCK_UNIT_NAMEToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.STOCK_UNITTableAdapter.STOCK_UNIT_NAME(Me.STOCK_UNITDataSet1.STOCK_UNIT, STOCK_UNIT_NAMEToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub STOCK_UNIT_NAMEToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class