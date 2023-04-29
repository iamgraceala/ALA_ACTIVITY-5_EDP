<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoldCars
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
        Me.TextSaleDate = New System.Windows.Forms.TextBox()
        Me.LabelSaleDate = New System.Windows.Forms.Label()
        Me.TextSalePrice = New System.Windows.Forms.TextBox()
        Me.LabelSoldPrice = New System.Windows.Forms.Label()
        Me.DataGridViewSoldCars = New System.Windows.Forms.DataGridView()
        Me.DeleteSoldCars = New System.Windows.Forms.Button()
        Me.UpdateSoldCars = New System.Windows.Forms.Button()
        Me.TextSoldCustomerID = New System.Windows.Forms.TextBox()
        Me.LabelCustomerIDStaff = New System.Windows.Forms.Label()
        Me.TextSoldCarUnit = New System.Windows.Forms.TextBox()
        Me.TextSoldID = New System.Windows.Forms.TextBox()
        Me.LabellSoldCarUnit = New System.Windows.Forms.Label()
        Me.LabelSoldID = New System.Windows.Forms.Label()
        Me.btnAddSoldCars = New System.Windows.Forms.Button()
        Me.BackSoldCars = New System.Windows.Forms.Button()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.PrintSoldCars = New System.Windows.Forms.Button()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridViewSoldCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextSaleDate
        '
        Me.TextSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSaleDate.Location = New System.Drawing.Point(179, 284)
        Me.TextSaleDate.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSaleDate.Name = "TextSaleDate"
        Me.TextSaleDate.Size = New System.Drawing.Size(217, 24)
        Me.TextSaleDate.TabIndex = 60
        '
        'LabelSaleDate
        '
        Me.LabelSaleDate.AutoSize = True
        Me.LabelSaleDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelSaleDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaleDate.Location = New System.Drawing.Point(54, 284)
        Me.LabelSaleDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSaleDate.Name = "LabelSaleDate"
        Me.LabelSaleDate.Size = New System.Drawing.Size(67, 18)
        Me.LabelSaleDate.TabIndex = 59
        Me.LabelSaleDate.Text = "Date Sold"
        '
        'TextSalePrice
        '
        Me.TextSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSalePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSalePrice.Location = New System.Drawing.Point(179, 250)
        Me.TextSalePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSalePrice.Name = "TextSalePrice"
        Me.TextSalePrice.Size = New System.Drawing.Size(217, 24)
        Me.TextSalePrice.TabIndex = 58
        '
        'LabelSoldPrice
        '
        Me.LabelSoldPrice.AutoSize = True
        Me.LabelSoldPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelSoldPrice.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSoldPrice.Location = New System.Drawing.Point(54, 255)
        Me.LabelSoldPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSoldPrice.Name = "LabelSoldPrice"
        Me.LabelSoldPrice.Size = New System.Drawing.Size(39, 18)
        Me.LabelSoldPrice.TabIndex = 57
        Me.LabelSoldPrice.Text = "Price"
        '
        'DataGridViewSoldCars
        '
        Me.DataGridViewSoldCars.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewSoldCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSoldCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSoldCars.GridColor = System.Drawing.Color.RosyBrown
        Me.DataGridViewSoldCars.Location = New System.Drawing.Point(436, 143)
        Me.DataGridViewSoldCars.Name = "DataGridViewSoldCars"
        Me.DataGridViewSoldCars.Size = New System.Drawing.Size(543, 271)
        Me.DataGridViewSoldCars.TabIndex = 56
        '
        'DeleteSoldCars
        '
        Me.DeleteSoldCars.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.DeleteSoldCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteSoldCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSoldCars.ForeColor = System.Drawing.Color.Snow
        Me.DeleteSoldCars.Location = New System.Drawing.Point(81, 447)
        Me.DeleteSoldCars.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteSoldCars.Name = "DeleteSoldCars"
        Me.DeleteSoldCars.Size = New System.Drawing.Size(130, 33)
        Me.DeleteSoldCars.TabIndex = 55
        Me.DeleteSoldCars.Text = "Delete Record"
        Me.DeleteSoldCars.UseVisualStyleBackColor = False
        '
        'UpdateSoldCars
        '
        Me.UpdateSoldCars.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.UpdateSoldCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateSoldCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSoldCars.ForeColor = System.Drawing.Color.Snow
        Me.UpdateSoldCars.Location = New System.Drawing.Point(266, 398)
        Me.UpdateSoldCars.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateSoldCars.Name = "UpdateSoldCars"
        Me.UpdateSoldCars.Size = New System.Drawing.Size(130, 33)
        Me.UpdateSoldCars.TabIndex = 54
        Me.UpdateSoldCars.Text = "Update Record"
        Me.UpdateSoldCars.UseVisualStyleBackColor = False
        '
        'TextSoldCustomerID
        '
        Me.TextSoldCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSoldCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSoldCustomerID.Location = New System.Drawing.Point(179, 219)
        Me.TextSoldCustomerID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSoldCustomerID.Name = "TextSoldCustomerID"
        Me.TextSoldCustomerID.Size = New System.Drawing.Size(217, 24)
        Me.TextSoldCustomerID.TabIndex = 53
        '
        'LabelCustomerIDStaff
        '
        Me.LabelCustomerIDStaff.AutoSize = True
        Me.LabelCustomerIDStaff.BackColor = System.Drawing.Color.Transparent
        Me.LabelCustomerIDStaff.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCustomerIDStaff.Location = New System.Drawing.Point(54, 219)
        Me.LabelCustomerIDStaff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCustomerIDStaff.Name = "LabelCustomerIDStaff"
        Me.LabelCustomerIDStaff.Size = New System.Drawing.Size(84, 18)
        Me.LabelCustomerIDStaff.TabIndex = 52
        Me.LabelCustomerIDStaff.Text = "Customer ID"
        '
        'TextSoldCarUnit
        '
        Me.TextSoldCarUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSoldCarUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSoldCarUnit.Location = New System.Drawing.Point(179, 184)
        Me.TextSoldCarUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSoldCarUnit.Name = "TextSoldCarUnit"
        Me.TextSoldCarUnit.Size = New System.Drawing.Size(217, 24)
        Me.TextSoldCarUnit.TabIndex = 51
        '
        'TextSoldID
        '
        Me.TextSoldID.BackColor = System.Drawing.SystemColors.Window
        Me.TextSoldID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSoldID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSoldID.Location = New System.Drawing.Point(179, 153)
        Me.TextSoldID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSoldID.Name = "TextSoldID"
        Me.TextSoldID.Size = New System.Drawing.Size(217, 24)
        Me.TextSoldID.TabIndex = 50
        '
        'LabellSoldCarUnit
        '
        Me.LabellSoldCarUnit.AutoSize = True
        Me.LabellSoldCarUnit.BackColor = System.Drawing.Color.Transparent
        Me.LabellSoldCarUnit.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabellSoldCarUnit.Location = New System.Drawing.Point(54, 184)
        Me.LabellSoldCarUnit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabellSoldCarUnit.Name = "LabellSoldCarUnit"
        Me.LabellSoldCarUnit.Size = New System.Drawing.Size(58, 18)
        Me.LabellSoldCarUnit.TabIndex = 49
        Me.LabellSoldCarUnit.Text = "Car Unit"
        '
        'LabelSoldID
        '
        Me.LabelSoldID.AutoSize = True
        Me.LabelSoldID.BackColor = System.Drawing.Color.Transparent
        Me.LabelSoldID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSoldID.Location = New System.Drawing.Point(54, 155)
        Me.LabelSoldID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSoldID.Name = "LabelSoldID"
        Me.LabelSoldID.Size = New System.Drawing.Size(118, 18)
        Me.LabelSoldID.TabIndex = 48
        Me.LabelSoldID.Text = "Purchase Number"
        '
        'btnAddSoldCars
        '
        Me.btnAddSoldCars.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddSoldCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddSoldCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSoldCars.ForeColor = System.Drawing.Color.Snow
        Me.btnAddSoldCars.Location = New System.Drawing.Point(81, 398)
        Me.btnAddSoldCars.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddSoldCars.Name = "btnAddSoldCars"
        Me.btnAddSoldCars.Size = New System.Drawing.Size(130, 33)
        Me.btnAddSoldCars.TabIndex = 47
        Me.btnAddSoldCars.Text = "Add Record"
        Me.btnAddSoldCars.UseVisualStyleBackColor = False
        '
        'BackSoldCars
        '
        Me.BackSoldCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackSoldCars.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BackSoldCars.Location = New System.Drawing.Point(667, 448)
        Me.BackSoldCars.Name = "BackSoldCars"
        Me.BackSoldCars.Size = New System.Drawing.Size(112, 30)
        Me.BackSoldCars.TabIndex = 73
        Me.BackSoldCars.Text = "Back"
        Me.BackSoldCars.UseVisualStyleBackColor = True
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginLabel.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.LoginLabel.Location = New System.Drawing.Point(602, 63)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(210, 36)
        Me.LoginLabel.TabIndex = 75
        Me.LoginLabel.Text = "SOLD CARS"
        '
        'PrintSoldCars
        '
        Me.PrintSoldCars.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.PrintSoldCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintSoldCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintSoldCars.ForeColor = System.Drawing.Color.Snow
        Me.PrintSoldCars.Location = New System.Drawing.Point(266, 447)
        Me.PrintSoldCars.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintSoldCars.Name = "PrintSoldCars"
        Me.PrintSoldCars.Size = New System.Drawing.Size(130, 33)
        Me.PrintSoldCars.TabIndex = 76
        Me.PrintSoldCars.Text = "Print Record"
        Me.PrintSoldCars.UseVisualStyleBackColor = False
        '
        'SoldCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.PrintSoldCars)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.BackSoldCars)
        Me.Controls.Add(Me.TextSaleDate)
        Me.Controls.Add(Me.LabelSaleDate)
        Me.Controls.Add(Me.TextSalePrice)
        Me.Controls.Add(Me.LabelSoldPrice)
        Me.Controls.Add(Me.DataGridViewSoldCars)
        Me.Controls.Add(Me.DeleteSoldCars)
        Me.Controls.Add(Me.UpdateSoldCars)
        Me.Controls.Add(Me.TextSoldCustomerID)
        Me.Controls.Add(Me.LabelCustomerIDStaff)
        Me.Controls.Add(Me.TextSoldCarUnit)
        Me.Controls.Add(Me.TextSoldID)
        Me.Controls.Add(Me.LabellSoldCarUnit)
        Me.Controls.Add(Me.LabelSoldID)
        Me.Controls.Add(Me.btnAddSoldCars)
        Me.DoubleBuffered = True
        Me.Name = "SoldCars"
        Me.Text = "SoldCars"
        CType(Me.DataGridViewSoldCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextSaleDate As TextBox
    Friend WithEvents LabelSaleDate As Label
    Friend WithEvents TextSalePrice As TextBox
    Friend WithEvents LabelSoldPrice As Label
    Friend WithEvents DataGridViewSoldCars As DataGridView
    Friend WithEvents DeleteSoldCars As Button
    Friend WithEvents UpdateSoldCars As Button
    Friend WithEvents TextSoldCustomerID As TextBox
    Friend WithEvents LabelCustomerIDStaff As Label
    Friend WithEvents TextSoldCarUnit As TextBox
    Friend WithEvents TextSoldID As TextBox
    Friend WithEvents LabellSoldCarUnit As Label
    Friend WithEvents LabelSoldID As Label
    Friend WithEvents btnAddSoldCars As Button
    Friend WithEvents BackSoldCars As Button
    Friend WithEvents LoginLabel As Label
    Friend WithEvents PrintSoldCars As Button
    Friend WithEvents saveFileDialog As SaveFileDialog
End Class
