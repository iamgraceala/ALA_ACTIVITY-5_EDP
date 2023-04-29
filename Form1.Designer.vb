<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.SupplierButton = New System.Windows.Forms.Button()
        Me.StaffButton = New System.Windows.Forms.Button()
        Me.SoldButton = New System.Windows.Forms.Button()
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.Location = New System.Drawing.Point(449, 271)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "List of For Sale Cars"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Location = New System.Drawing.Point(519, 539)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(119, 34)
        Me.ButtonLogout.TabIndex = 7
        Me.ButtonLogout.Text = "LOGOUT"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'SupplierButton
        '
        Me.SupplierButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SupplierButton.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.SupplierButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.SupplierButton.Location = New System.Drawing.Point(449, 317)
        Me.SupplierButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierButton.Name = "SupplierButton"
        Me.SupplierButton.Size = New System.Drawing.Size(227, 42)
        Me.SupplierButton.TabIndex = 8
        Me.SupplierButton.Text = "Supplier"
        Me.SupplierButton.UseVisualStyleBackColor = False
        '
        'StaffButton
        '
        Me.StaffButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StaffButton.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.StaffButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.StaffButton.Location = New System.Drawing.Point(449, 363)
        Me.StaffButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffButton.Name = "StaffButton"
        Me.StaffButton.Size = New System.Drawing.Size(227, 42)
        Me.StaffButton.TabIndex = 9
        Me.StaffButton.Text = "Staffs"
        Me.StaffButton.UseVisualStyleBackColor = False
        '
        'SoldButton
        '
        Me.SoldButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SoldButton.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.SoldButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.SoldButton.Location = New System.Drawing.Point(449, 409)
        Me.SoldButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SoldButton.Name = "SoldButton"
        Me.SoldButton.Size = New System.Drawing.Size(227, 42)
        Me.SoldButton.TabIndex = 10
        Me.SoldButton.Text = "Sold Cars"
        Me.SoldButton.UseVisualStyleBackColor = False
        '
        'CustomerButton
        '
        Me.CustomerButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CustomerButton.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.CustomerButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.CustomerButton.Location = New System.Drawing.Point(449, 455)
        Me.CustomerButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(227, 42)
        Me.CustomerButton.TabIndex = 11
        Me.CustomerButton.Text = "Buyers"
        Me.CustomerButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.CustomerButton)
        Me.Controls.Add(Me.SoldButton)
        Me.Controls.Add(Me.StaffButton)
        Me.Controls.Add(Me.SupplierButton)
        Me.Controls.Add(Me.ButtonLogout)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents SupplierButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents SoldButton As Button
    Friend WithEvents CustomerButton As Button
End Class
