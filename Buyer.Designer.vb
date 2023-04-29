<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buyer
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
        Me.TextAmountPurchased = New System.Windows.Forms.TextBox()
        Me.LabelAmountPurchased = New System.Windows.Forms.Label()
        Me.TextUnitPurchased = New System.Windows.Forms.TextBox()
        Me.LabelUnitPurchased = New System.Windows.Forms.Label()
        Me.TextBuyerAddress = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.DataGridViewBuyer = New System.Windows.Forms.DataGridView()
        Me.DeleteBuyer = New System.Windows.Forms.Button()
        Me.UpdateBuyer = New System.Windows.Forms.Button()
        Me.TextBuyerContact = New System.Windows.Forms.TextBox()
        Me.LabelContact = New System.Windows.Forms.Label()
        Me.TextBuyerName = New System.Windows.Forms.TextBox()
        Me.TextBuyersId = New System.Windows.Forms.TextBox()
        Me.LabelBuyer = New System.Windows.Forms.Label()
        Me.Label_Buyer = New System.Windows.Forms.Label()
        Me.btnAddBuyer = New System.Windows.Forms.Button()
        Me.BackBuyer = New System.Windows.Forms.Button()
        Me.BuyerLabel = New System.Windows.Forms.Label()
        Me.PrintBuyer = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBuyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextAmountPurchased
        '
        Me.TextAmountPurchased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAmountPurchased.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAmountPurchased.Location = New System.Drawing.Point(158, 354)
        Me.TextAmountPurchased.Margin = New System.Windows.Forms.Padding(2)
        Me.TextAmountPurchased.Name = "TextAmountPurchased"
        Me.TextAmountPurchased.Size = New System.Drawing.Size(243, 27)
        Me.TextAmountPurchased.TabIndex = 46
        '
        'LabelAmountPurchased
        '
        Me.LabelAmountPurchased.AutoSize = True
        Me.LabelAmountPurchased.BackColor = System.Drawing.Color.Transparent
        Me.LabelAmountPurchased.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAmountPurchased.Location = New System.Drawing.Point(33, 361)
        Me.LabelAmountPurchased.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAmountPurchased.Name = "LabelAmountPurchased"
        Me.LabelAmountPurchased.Size = New System.Drawing.Size(125, 18)
        Me.LabelAmountPurchased.TabIndex = 45
        Me.LabelAmountPurchased.Text = "Amount Purchased"
        '
        'TextUnitPurchased
        '
        Me.TextUnitPurchased.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUnitPurchased.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUnitPurchased.Location = New System.Drawing.Point(158, 314)
        Me.TextUnitPurchased.Margin = New System.Windows.Forms.Padding(2)
        Me.TextUnitPurchased.Name = "TextUnitPurchased"
        Me.TextUnitPurchased.Size = New System.Drawing.Size(243, 27)
        Me.TextUnitPurchased.TabIndex = 44
        '
        'LabelUnitPurchased
        '
        Me.LabelUnitPurchased.AutoSize = True
        Me.LabelUnitPurchased.BackColor = System.Drawing.Color.Transparent
        Me.LabelUnitPurchased.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUnitPurchased.Location = New System.Drawing.Point(33, 319)
        Me.LabelUnitPurchased.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUnitPurchased.Name = "LabelUnitPurchased"
        Me.LabelUnitPurchased.Size = New System.Drawing.Size(102, 18)
        Me.LabelUnitPurchased.TabIndex = 43
        Me.LabelUnitPurchased.Text = "Unit Purchased"
        '
        'TextBuyerAddress
        '
        Me.TextBuyerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuyerAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuyerAddress.Location = New System.Drawing.Point(158, 274)
        Me.TextBuyerAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBuyerAddress.Name = "TextBuyerAddress"
        Me.TextBuyerAddress.Size = New System.Drawing.Size(243, 27)
        Me.TextBuyerAddress.TabIndex = 42
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.BackColor = System.Drawing.Color.Transparent
        Me.LabelAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.Location = New System.Drawing.Point(33, 279)
        Me.LabelAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(58, 18)
        Me.LabelAddress.TabIndex = 41
        Me.LabelAddress.Text = "Address"
        '
        'DataGridViewBuyer
        '
        Me.DataGridViewBuyer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewBuyer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewBuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBuyer.GridColor = System.Drawing.Color.RosyBrown
        Me.DataGridViewBuyer.Location = New System.Drawing.Point(423, 137)
        Me.DataGridViewBuyer.Name = "DataGridViewBuyer"
        Me.DataGridViewBuyer.Size = New System.Drawing.Size(639, 298)
        Me.DataGridViewBuyer.TabIndex = 40
        '
        'DeleteBuyer
        '
        Me.DeleteBuyer.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.DeleteBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBuyer.ForeColor = System.Drawing.Color.Snow
        Me.DeleteBuyer.Location = New System.Drawing.Point(72, 471)
        Me.DeleteBuyer.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteBuyer.Name = "DeleteBuyer"
        Me.DeleteBuyer.Size = New System.Drawing.Size(130, 33)
        Me.DeleteBuyer.TabIndex = 39
        Me.DeleteBuyer.Text = "Delete Record"
        Me.DeleteBuyer.UseVisualStyleBackColor = False
        '
        'UpdateBuyer
        '
        Me.UpdateBuyer.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.UpdateBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBuyer.ForeColor = System.Drawing.Color.Snow
        Me.UpdateBuyer.Location = New System.Drawing.Point(227, 425)
        Me.UpdateBuyer.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateBuyer.Name = "UpdateBuyer"
        Me.UpdateBuyer.Size = New System.Drawing.Size(130, 33)
        Me.UpdateBuyer.TabIndex = 38
        Me.UpdateBuyer.Text = "Update Record"
        Me.UpdateBuyer.UseVisualStyleBackColor = False
        '
        'TextBuyerContact
        '
        Me.TextBuyerContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuyerContact.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuyerContact.Location = New System.Drawing.Point(158, 234)
        Me.TextBuyerContact.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBuyerContact.Name = "TextBuyerContact"
        Me.TextBuyerContact.Size = New System.Drawing.Size(243, 27)
        Me.TextBuyerContact.TabIndex = 37
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.BackColor = System.Drawing.Color.Transparent
        Me.LabelContact.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContact.Location = New System.Drawing.Point(33, 237)
        Me.LabelContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(109, 18)
        Me.LabelContact.TabIndex = 36
        Me.LabelContact.Text = "Contact Number"
        '
        'TextBuyerName
        '
        Me.TextBuyerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuyerName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuyerName.Location = New System.Drawing.Point(158, 192)
        Me.TextBuyerName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBuyerName.Name = "TextBuyerName"
        Me.TextBuyerName.Size = New System.Drawing.Size(243, 27)
        Me.TextBuyerName.TabIndex = 35
        '
        'TextBuyersId
        '
        Me.TextBuyersId.BackColor = System.Drawing.SystemColors.Window
        Me.TextBuyersId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBuyersId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBuyersId.Location = New System.Drawing.Point(158, 152)
        Me.TextBuyersId.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBuyersId.Name = "TextBuyersId"
        Me.TextBuyersId.Size = New System.Drawing.Size(243, 27)
        Me.TextBuyersId.TabIndex = 34
        '
        'LabelBuyer
        '
        Me.LabelBuyer.AutoSize = True
        Me.LabelBuyer.BackColor = System.Drawing.Color.Transparent
        Me.LabelBuyer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuyer.Location = New System.Drawing.Point(33, 197)
        Me.LabelBuyer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBuyer.Name = "LabelBuyer"
        Me.LabelBuyer.Size = New System.Drawing.Size(94, 18)
        Me.LabelBuyer.TabIndex = 33
        Me.LabelBuyer.Text = "Buyer's Name"
        '
        'Label_Buyer
        '
        Me.Label_Buyer.AutoSize = True
        Me.Label_Buyer.BackColor = System.Drawing.Color.Transparent
        Me.Label_Buyer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Buyer.Location = New System.Drawing.Point(33, 157)
        Me.Label_Buyer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Buyer.Name = "Label_Buyer"
        Me.Label_Buyer.Size = New System.Drawing.Size(60, 18)
        Me.Label_Buyer.TabIndex = 32
        Me.Label_Buyer.Text = "Buyer ID"
        '
        'btnAddBuyer
        '
        Me.btnAddBuyer.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBuyer.ForeColor = System.Drawing.Color.Snow
        Me.btnAddBuyer.Location = New System.Drawing.Point(72, 425)
        Me.btnAddBuyer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddBuyer.Name = "btnAddBuyer"
        Me.btnAddBuyer.Size = New System.Drawing.Size(130, 33)
        Me.btnAddBuyer.TabIndex = 31
        Me.btnAddBuyer.Text = "Add Record"
        Me.btnAddBuyer.UseVisualStyleBackColor = False
        '
        'BackBuyer
        '
        Me.BackBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBuyer.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BackBuyer.Location = New System.Drawing.Point(705, 484)
        Me.BackBuyer.Name = "BackBuyer"
        Me.BackBuyer.Size = New System.Drawing.Size(99, 29)
        Me.BackBuyer.TabIndex = 71
        Me.BackBuyer.Text = "Back"
        Me.BackBuyer.UseVisualStyleBackColor = True
        '
        'BuyerLabel
        '
        Me.BuyerLabel.AutoSize = True
        Me.BuyerLabel.BackColor = System.Drawing.Color.Transparent
        Me.BuyerLabel.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyerLabel.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BuyerLabel.Location = New System.Drawing.Point(661, 63)
        Me.BuyerLabel.Name = "BuyerLabel"
        Me.BuyerLabel.Size = New System.Drawing.Size(157, 36)
        Me.BuyerLabel.TabIndex = 73
        Me.BuyerLabel.Text = "BUYERS"
        '
        'PrintBuyer
        '
        Me.PrintBuyer.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.PrintBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintBuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBuyer.ForeColor = System.Drawing.Color.Snow
        Me.PrintBuyer.Location = New System.Drawing.Point(227, 471)
        Me.PrintBuyer.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintBuyer.Name = "PrintBuyer"
        Me.PrintBuyer.Size = New System.Drawing.Size(130, 33)
        Me.PrintBuyer.TabIndex = 74
        Me.PrintBuyer.Text = "Print Record"
        Me.PrintBuyer.UseVisualStyleBackColor = False
        '
        'Buyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.PrintBuyer)
        Me.Controls.Add(Me.BuyerLabel)
        Me.Controls.Add(Me.BackBuyer)
        Me.Controls.Add(Me.TextAmountPurchased)
        Me.Controls.Add(Me.LabelAmountPurchased)
        Me.Controls.Add(Me.TextUnitPurchased)
        Me.Controls.Add(Me.LabelUnitPurchased)
        Me.Controls.Add(Me.TextBuyerAddress)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.DataGridViewBuyer)
        Me.Controls.Add(Me.DeleteBuyer)
        Me.Controls.Add(Me.UpdateBuyer)
        Me.Controls.Add(Me.TextBuyerContact)
        Me.Controls.Add(Me.LabelContact)
        Me.Controls.Add(Me.TextBuyerName)
        Me.Controls.Add(Me.TextBuyersId)
        Me.Controls.Add(Me.LabelBuyer)
        Me.Controls.Add(Me.Label_Buyer)
        Me.Controls.Add(Me.btnAddBuyer)
        Me.DoubleBuffered = True
        Me.Name = "Buyer"
        Me.Text = "Buyer"
        CType(Me.DataGridViewBuyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextAmountPurchased As TextBox
    Friend WithEvents LabelAmountPurchased As Label
    Friend WithEvents TextUnitPurchased As TextBox
    Friend WithEvents LabelUnitPurchased As Label
    Friend WithEvents TextBuyerAddress As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents DataGridViewBuyer As DataGridView
    Friend WithEvents DeleteBuyer As Button
    Friend WithEvents UpdateBuyer As Button
    Friend WithEvents TextBuyerContact As TextBox
    Friend WithEvents LabelContact As Label
    Friend WithEvents TextBuyerName As TextBox
    Friend WithEvents TextBuyersId As TextBox
    Friend WithEvents LabelBuyer As Label
    Friend WithEvents Label_Buyer As Label
    Friend WithEvents btnAddBuyer As Button
    Friend WithEvents BackBuyer As Button
    Friend WithEvents BuyerLabel As Label
    Friend WithEvents PrintBuyer As Button
End Class
