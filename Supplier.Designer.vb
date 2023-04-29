<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Me.TextSuppEmail = New System.Windows.Forms.TextBox()
        Me.LabelSuppEmail = New System.Windows.Forms.Label()
        Me.TextSuppAddress = New System.Windows.Forms.TextBox()
        Me.LabelSuppAddress = New System.Windows.Forms.Label()
        Me.DeleteSupplier = New System.Windows.Forms.Button()
        Me.UpdateSupplier = New System.Windows.Forms.Button()
        Me.TextSuppContact = New System.Windows.Forms.TextBox()
        Me.LabelSuppContact = New System.Windows.Forms.Label()
        Me.TextSuppName = New System.Windows.Forms.TextBox()
        Me.TextSuppID = New System.Windows.Forms.TextBox()
        Me.LabelSuppName = New System.Windows.Forms.Label()
        Me.LabelSupplierID = New System.Windows.Forms.Label()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.BackSupplier = New System.Windows.Forms.Button()
        Me.LabelSupplier = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgreport = New System.Windows.Forms.DataGridView()
        CType(Me.dgreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextSuppEmail
        '
        Me.TextSuppEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSuppEmail.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSuppEmail.Location = New System.Drawing.Point(170, 324)
        Me.TextSuppEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSuppEmail.Name = "TextSuppEmail"
        Me.TextSuppEmail.Size = New System.Drawing.Size(268, 26)
        Me.TextSuppEmail.TabIndex = 60
        '
        'LabelSuppEmail
        '
        Me.LabelSuppEmail.AutoSize = True
        Me.LabelSuppEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelSuppEmail.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSuppEmail.Location = New System.Drawing.Point(50, 333)
        Me.LabelSuppEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSuppEmail.Name = "LabelSuppEmail"
        Me.LabelSuppEmail.Size = New System.Drawing.Size(39, 17)
        Me.LabelSuppEmail.TabIndex = 59
        Me.LabelSuppEmail.Text = "Email"
        '
        'TextSuppAddress
        '
        Me.TextSuppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSuppAddress.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSuppAddress.Location = New System.Drawing.Point(170, 289)
        Me.TextSuppAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSuppAddress.Name = "TextSuppAddress"
        Me.TextSuppAddress.Size = New System.Drawing.Size(268, 26)
        Me.TextSuppAddress.TabIndex = 58
        '
        'LabelSuppAddress
        '
        Me.LabelSuppAddress.AutoSize = True
        Me.LabelSuppAddress.BackColor = System.Drawing.Color.Transparent
        Me.LabelSuppAddress.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSuppAddress.Location = New System.Drawing.Point(50, 294)
        Me.LabelSuppAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSuppAddress.Name = "LabelSuppAddress"
        Me.LabelSuppAddress.Size = New System.Drawing.Size(56, 17)
        Me.LabelSuppAddress.TabIndex = 57
        Me.LabelSuppAddress.Text = "Address"
        '
        'DeleteSupplier
        '
        Me.DeleteSupplier.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.DeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSupplier.ForeColor = System.Drawing.Color.Snow
        Me.DeleteSupplier.Location = New System.Drawing.Point(128, 459)
        Me.DeleteSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteSupplier.Name = "DeleteSupplier"
        Me.DeleteSupplier.Size = New System.Drawing.Size(130, 33)
        Me.DeleteSupplier.TabIndex = 55
        Me.DeleteSupplier.Text = "Delete Record"
        Me.DeleteSupplier.UseVisualStyleBackColor = False
        '
        'UpdateSupplier
        '
        Me.UpdateSupplier.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.UpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSupplier.ForeColor = System.Drawing.Color.Snow
        Me.UpdateSupplier.Location = New System.Drawing.Point(308, 405)
        Me.UpdateSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateSupplier.Name = "UpdateSupplier"
        Me.UpdateSupplier.Size = New System.Drawing.Size(130, 33)
        Me.UpdateSupplier.TabIndex = 54
        Me.UpdateSupplier.Text = "Update Record"
        Me.UpdateSupplier.UseVisualStyleBackColor = False
        '
        'TextSuppContact
        '
        Me.TextSuppContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSuppContact.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSuppContact.Location = New System.Drawing.Point(170, 258)
        Me.TextSuppContact.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSuppContact.Name = "TextSuppContact"
        Me.TextSuppContact.Size = New System.Drawing.Size(268, 26)
        Me.TextSuppContact.TabIndex = 53
        '
        'LabelSuppContact
        '
        Me.LabelSuppContact.AutoSize = True
        Me.LabelSuppContact.BackColor = System.Drawing.Color.Transparent
        Me.LabelSuppContact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSuppContact.Location = New System.Drawing.Point(50, 262)
        Me.LabelSuppContact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSuppContact.Name = "LabelSuppContact"
        Me.LabelSuppContact.Size = New System.Drawing.Size(98, 15)
        Me.LabelSuppContact.TabIndex = 52
        Me.LabelSuppContact.Text = "Contact Number"
        '
        'TextSuppName
        '
        Me.TextSuppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSuppName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSuppName.Location = New System.Drawing.Point(170, 225)
        Me.TextSuppName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSuppName.Name = "TextSuppName"
        Me.TextSuppName.Size = New System.Drawing.Size(268, 26)
        Me.TextSuppName.TabIndex = 51
        '
        'TextSuppID
        '
        Me.TextSuppID.BackColor = System.Drawing.SystemColors.Window
        Me.TextSuppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSuppID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSuppID.Location = New System.Drawing.Point(170, 190)
        Me.TextSuppID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSuppID.Name = "TextSuppID"
        Me.TextSuppID.Size = New System.Drawing.Size(268, 26)
        Me.TextSuppID.TabIndex = 50
        '
        'LabelSuppName
        '
        Me.LabelSuppName.AutoSize = True
        Me.LabelSuppName.BackColor = System.Drawing.Color.Transparent
        Me.LabelSuppName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSuppName.Location = New System.Drawing.Point(50, 229)
        Me.LabelSuppName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSuppName.Name = "LabelSuppName"
        Me.LabelSuppName.Size = New System.Drawing.Size(96, 15)
        Me.LabelSuppName.TabIndex = 49
        Me.LabelSuppName.Text = "Supplier's Name"
        '
        'LabelSupplierID
        '
        Me.LabelSupplierID.AutoSize = True
        Me.LabelSupplierID.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupplierID.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelSupplierID.Location = New System.Drawing.Point(50, 194)
        Me.LabelSupplierID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSupplierID.Name = "LabelSupplierID"
        Me.LabelSupplierID.Size = New System.Drawing.Size(73, 17)
        Me.LabelSupplierID.TabIndex = 48
        Me.LabelSupplierID.Text = "Supplier ID"
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupplier.ForeColor = System.Drawing.Color.Snow
        Me.btnAddSupplier.Location = New System.Drawing.Point(128, 405)
        Me.btnAddSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(130, 33)
        Me.btnAddSupplier.TabIndex = 47
        Me.btnAddSupplier.Text = "Add Record"
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'BackSupplier
        '
        Me.BackSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackSupplier.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BackSupplier.Location = New System.Drawing.Point(693, 459)
        Me.BackSupplier.Name = "BackSupplier"
        Me.BackSupplier.Size = New System.Drawing.Size(98, 32)
        Me.BackSupplier.TabIndex = 73
        Me.BackSupplier.Text = "Back"
        Me.BackSupplier.UseVisualStyleBackColor = True
        '
        'LabelSupplier
        '
        Me.LabelSupplier.AutoSize = True
        Me.LabelSupplier.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupplier.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupplier.ForeColor = System.Drawing.Color.DarkGreen
        Me.LabelSupplier.Location = New System.Drawing.Point(598, 90)
        Me.LabelSupplier.Name = "LabelSupplier"
        Me.LabelSupplier.Size = New System.Drawing.Size(207, 36)
        Me.LabelSupplier.TabIndex = 75
        Me.LabelSupplier.Text = "SUPPLIERS"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Beige
        Me.btnPrint.Location = New System.Drawing.Point(308, 459)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 33)
        Me.btnPrint.TabIndex = 78
        Me.btnPrint.Text = "Print Record"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dgreport
        '
        Me.dgreport.AllowUserToAddRows = False
        Me.dgreport.AllowUserToDeleteRows = False
        Me.dgreport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgreport.Location = New System.Drawing.Point(490, 141)
        Me.dgreport.Margin = New System.Windows.Forms.Padding(2)
        Me.dgreport.Name = "dgreport"
        Me.dgreport.ReadOnly = True
        Me.dgreport.RowHeadersWidth = 51
        Me.dgreport.RowTemplate.Height = 24
        Me.dgreport.Size = New System.Drawing.Size(461, 245)
        Me.dgreport.TabIndex = 77
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 585)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dgreport)
        Me.Controls.Add(Me.LabelSupplier)
        Me.Controls.Add(Me.BackSupplier)
        Me.Controls.Add(Me.TextSuppEmail)
        Me.Controls.Add(Me.LabelSuppEmail)
        Me.Controls.Add(Me.TextSuppAddress)
        Me.Controls.Add(Me.LabelSuppAddress)
        Me.Controls.Add(Me.DeleteSupplier)
        Me.Controls.Add(Me.UpdateSupplier)
        Me.Controls.Add(Me.TextSuppContact)
        Me.Controls.Add(Me.LabelSuppContact)
        Me.Controls.Add(Me.TextSuppName)
        Me.Controls.Add(Me.TextSuppID)
        Me.Controls.Add(Me.LabelSuppName)
        Me.Controls.Add(Me.LabelSupplierID)
        Me.Controls.Add(Me.btnAddSupplier)
        Me.DoubleBuffered = True
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        CType(Me.dgreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextSuppEmail As TextBox
    Friend WithEvents LabelSuppEmail As Label
    Friend WithEvents TextSuppAddress As TextBox
    Friend WithEvents LabelSuppAddress As Label
    Friend WithEvents DeleteSupplier As Button
    Friend WithEvents UpdateSupplier As Button
    Friend WithEvents TextSuppContact As TextBox
    Friend WithEvents LabelSuppContact As Label
    Friend WithEvents TextSuppName As TextBox
    Friend WithEvents TextSuppID As TextBox
    Friend WithEvents LabelSuppName As Label
    Friend WithEvents LabelSupplierID As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents BackSupplier As Button
    Friend WithEvents LabelSupplier As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgreport As DataGridView
End Class
