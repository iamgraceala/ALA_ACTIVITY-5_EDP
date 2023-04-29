<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.TextVehicleSold = New System.Windows.Forms.TextBox()
        Me.LabelVehicleSold = New System.Windows.Forms.Label()
        Me.TextStaffNumber = New System.Windows.Forms.TextBox()
        Me.LabelStaffNumber = New System.Windows.Forms.Label()
        Me.TextStaffEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.DataGridViewStaff = New System.Windows.Forms.DataGridView()
        Me.DeleteStaff = New System.Windows.Forms.Button()
        Me.UpdateStaff = New System.Windows.Forms.Button()
        Me.TextLastName = New System.Windows.Forms.TextBox()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.TextFname = New System.Windows.Forms.TextBox()
        Me.TextStaffID = New System.Windows.Forms.TextBox()
        Me.LabelFname = New System.Windows.Forms.Label()
        Me.LabelStaff = New System.Windows.Forms.Label()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.BackStaff = New System.Windows.Forms.Button()
        Me.LoginStaffs = New System.Windows.Forms.Label()
        Me.PrintStaff = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextVehicleSold
        '
        Me.TextVehicleSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextVehicleSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextVehicleSold.Location = New System.Drawing.Point(136, 326)
        Me.TextVehicleSold.Margin = New System.Windows.Forms.Padding(2)
        Me.TextVehicleSold.Name = "TextVehicleSold"
        Me.TextVehicleSold.Size = New System.Drawing.Size(234, 24)
        Me.TextVehicleSold.TabIndex = 62
        '
        'LabelVehicleSold
        '
        Me.LabelVehicleSold.AutoSize = True
        Me.LabelVehicleSold.BackColor = System.Drawing.Color.Transparent
        Me.LabelVehicleSold.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVehicleSold.Location = New System.Drawing.Point(42, 333)
        Me.LabelVehicleSold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVehicleSold.Name = "LabelVehicleSold"
        Me.LabelVehicleSold.Size = New System.Drawing.Size(66, 14)
        Me.LabelVehicleSold.TabIndex = 61
        Me.LabelVehicleSold.Text = "Vehicle Sold"
        '
        'TextStaffNumber
        '
        Me.TextStaffNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextStaffNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStaffNumber.Location = New System.Drawing.Point(136, 295)
        Me.TextStaffNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TextStaffNumber.Name = "TextStaffNumber"
        Me.TextStaffNumber.Size = New System.Drawing.Size(234, 24)
        Me.TextStaffNumber.TabIndex = 60
        '
        'LabelStaffNumber
        '
        Me.LabelStaffNumber.AutoSize = True
        Me.LabelStaffNumber.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaffNumber.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaffNumber.Location = New System.Drawing.Point(42, 302)
        Me.LabelStaffNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelStaffNumber.Name = "LabelStaffNumber"
        Me.LabelStaffNumber.Size = New System.Drawing.Size(87, 14)
        Me.LabelStaffNumber.TabIndex = 59
        Me.LabelStaffNumber.Text = "Contact Number"
        '
        'TextStaffEmail
        '
        Me.TextStaffEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextStaffEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStaffEmail.Location = New System.Drawing.Point(136, 262)
        Me.TextStaffEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TextStaffEmail.Name = "TextStaffEmail"
        Me.TextStaffEmail.Size = New System.Drawing.Size(234, 24)
        Me.TextStaffEmail.TabIndex = 58
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(42, 272)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(35, 14)
        Me.LabelEmail.TabIndex = 57
        Me.LabelEmail.Text = "Email"
        '
        'DataGridViewStaff
        '
        Me.DataGridViewStaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStaff.GridColor = System.Drawing.Color.RosyBrown
        Me.DataGridViewStaff.Location = New System.Drawing.Point(412, 164)
        Me.DataGridViewStaff.Name = "DataGridViewStaff"
        Me.DataGridViewStaff.Size = New System.Drawing.Size(639, 298)
        Me.DataGridViewStaff.TabIndex = 56
        '
        'DeleteStaff
        '
        Me.DeleteStaff.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.DeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteStaff.ForeColor = System.Drawing.Color.Snow
        Me.DeleteStaff.Location = New System.Drawing.Point(72, 485)
        Me.DeleteStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteStaff.Name = "DeleteStaff"
        Me.DeleteStaff.Size = New System.Drawing.Size(130, 33)
        Me.DeleteStaff.TabIndex = 55
        Me.DeleteStaff.Text = "Delete Record"
        Me.DeleteStaff.UseVisualStyleBackColor = False
        '
        'UpdateStaff
        '
        Me.UpdateStaff.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.UpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateStaff.ForeColor = System.Drawing.Color.Snow
        Me.UpdateStaff.Location = New System.Drawing.Point(240, 438)
        Me.UpdateStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateStaff.Name = "UpdateStaff"
        Me.UpdateStaff.Size = New System.Drawing.Size(130, 33)
        Me.UpdateStaff.TabIndex = 54
        Me.UpdateStaff.Text = "Update Record"
        Me.UpdateStaff.UseVisualStyleBackColor = False
        '
        'TextLastName
        '
        Me.TextLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLastName.Location = New System.Drawing.Point(136, 231)
        Me.TextLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextLastName.Name = "TextLastName"
        Me.TextLastName.Size = New System.Drawing.Size(234, 24)
        Me.TextLastName.TabIndex = 53
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.BackColor = System.Drawing.Color.Transparent
        Me.LabelLastName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLastName.Location = New System.Drawing.Point(42, 236)
        Me.LabelLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(60, 14)
        Me.LabelLastName.TabIndex = 52
        Me.LabelLastName.Text = "Last Name"
        '
        'TextFname
        '
        Me.TextFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFname.Location = New System.Drawing.Point(136, 199)
        Me.TextFname.Margin = New System.Windows.Forms.Padding(2)
        Me.TextFname.Name = "TextFname"
        Me.TextFname.Size = New System.Drawing.Size(234, 24)
        Me.TextFname.TabIndex = 51
        '
        'TextStaffID
        '
        Me.TextStaffID.BackColor = System.Drawing.SystemColors.Window
        Me.TextStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStaffID.Location = New System.Drawing.Point(136, 168)
        Me.TextStaffID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextStaffID.Name = "TextStaffID"
        Me.TextStaffID.Size = New System.Drawing.Size(234, 24)
        Me.TextStaffID.TabIndex = 50
        '
        'LabelFname
        '
        Me.LabelFname.AutoSize = True
        Me.LabelFname.BackColor = System.Drawing.Color.Transparent
        Me.LabelFname.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFname.Location = New System.Drawing.Point(42, 206)
        Me.LabelFname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFname.Name = "LabelFname"
        Me.LabelFname.Size = New System.Drawing.Size(62, 14)
        Me.LabelFname.TabIndex = 49
        Me.LabelFname.Text = "First Name"
        '
        'LabelStaff
        '
        Me.LabelStaff.AutoSize = True
        Me.LabelStaff.BackColor = System.Drawing.Color.Transparent
        Me.LabelStaff.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStaff.Location = New System.Drawing.Point(42, 175)
        Me.LabelStaff.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelStaff.Name = "LabelStaff"
        Me.LabelStaff.Size = New System.Drawing.Size(44, 14)
        Me.LabelStaff.TabIndex = 48
        Me.LabelStaff.Text = "Staff ID"
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.ForeColor = System.Drawing.Color.Snow
        Me.btnAddStaff.Location = New System.Drawing.Point(72, 438)
        Me.btnAddStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(130, 33)
        Me.btnAddStaff.TabIndex = 47
        Me.btnAddStaff.Text = "Add Record"
        Me.btnAddStaff.UseVisualStyleBackColor = False
        '
        'BackStaff
        '
        Me.BackStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackStaff.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BackStaff.Location = New System.Drawing.Point(694, 487)
        Me.BackStaff.Name = "BackStaff"
        Me.BackStaff.Size = New System.Drawing.Size(107, 31)
        Me.BackStaff.TabIndex = 73
        Me.BackStaff.Text = "Back"
        Me.BackStaff.UseVisualStyleBackColor = True
        '
        'LoginStaffs
        '
        Me.LoginStaffs.AutoSize = True
        Me.LoginStaffs.BackColor = System.Drawing.Color.Transparent
        Me.LoginStaffs.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginStaffs.ForeColor = System.Drawing.Color.DarkGreen
        Me.LoginStaffs.Location = New System.Drawing.Point(607, 78)
        Me.LoginStaffs.Name = "LoginStaffs"
        Me.LoginStaffs.Size = New System.Drawing.Size(265, 36)
        Me.LoginStaffs.TabIndex = 75
        Me.LoginStaffs.Text = "SALES STAFFS"
        '
        'PrintStaff
        '
        Me.PrintStaff.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.PrintStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintStaff.ForeColor = System.Drawing.Color.Snow
        Me.PrintStaff.Location = New System.Drawing.Point(240, 485)
        Me.PrintStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintStaff.Name = "PrintStaff"
        Me.PrintStaff.Size = New System.Drawing.Size(130, 33)
        Me.PrintStaff.TabIndex = 76
        Me.PrintStaff.Text = "Print Record"
        Me.PrintStaff.UseVisualStyleBackColor = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.PrintStaff)
        Me.Controls.Add(Me.LoginStaffs)
        Me.Controls.Add(Me.BackStaff)
        Me.Controls.Add(Me.TextVehicleSold)
        Me.Controls.Add(Me.LabelVehicleSold)
        Me.Controls.Add(Me.TextStaffNumber)
        Me.Controls.Add(Me.LabelStaffNumber)
        Me.Controls.Add(Me.TextStaffEmail)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.DataGridViewStaff)
        Me.Controls.Add(Me.DeleteStaff)
        Me.Controls.Add(Me.UpdateStaff)
        Me.Controls.Add(Me.TextLastName)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.TextFname)
        Me.Controls.Add(Me.TextStaffID)
        Me.Controls.Add(Me.LabelFname)
        Me.Controls.Add(Me.LabelStaff)
        Me.Controls.Add(Me.btnAddStaff)
        Me.DoubleBuffered = True
        Me.Name = "Staff"
        Me.Text = "Staff"
        CType(Me.DataGridViewStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextVehicleSold As TextBox
    Friend WithEvents LabelVehicleSold As Label
    Friend WithEvents TextStaffNumber As TextBox
    Friend WithEvents LabelStaffNumber As Label
    Friend WithEvents TextStaffEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents DataGridViewStaff As DataGridView
    Friend WithEvents DeleteStaff As Button
    Friend WithEvents UpdateStaff As Button
    Friend WithEvents TextLastName As TextBox
    Friend WithEvents LabelLastName As Label
    Friend WithEvents TextFname As TextBox
    Friend WithEvents TextStaffID As TextBox
    Friend WithEvents LabelFname As Label
    Friend WithEvents LabelStaff As Label
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents BackStaff As Button
    Friend WithEvents LoginStaffs As Label
    Friend WithEvents PrintStaff As Button
End Class
