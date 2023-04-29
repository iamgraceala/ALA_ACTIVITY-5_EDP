<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RegisterLabel = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RegisterLabel
        '
        Me.RegisterLabel.AutoSize = True
        Me.RegisterLabel.BackColor = System.Drawing.Color.Transparent
        Me.RegisterLabel.Location = New System.Drawing.Point(777, 398)
        Me.RegisterLabel.Name = "RegisterLabel"
        Me.RegisterLabel.Size = New System.Drawing.Size(192, 13)
        Me.RegisterLabel.TabIndex = 17
        Me.RegisterLabel.Text = "Don't Have an Account? Register Now"
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RegisterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(841, 433)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 29)
        Me.RegisterButton.TabIndex = 15
        Me.RegisterButton.Text = "&Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(875, 352)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 28)
        Me.Cancel.TabIndex = 14
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(789, 352)
        Me.OK.Margin = New System.Windows.Forms.Padding(2)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 28)
        Me.OK.TabIndex = 13
        Me.OK.Text = "&Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(789, 296)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(184, 22)
        Me.PasswordTextBox.TabIndex = 12
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(789, 251)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(184, 22)
        Me.UsernameTextBox.TabIndex = 10
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(696, 294)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(89, 24)
        Me.PasswordLabel.TabIndex = 11
        Me.PasswordLabel.Text = "&PASSWORD"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(696, 251)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(89, 27)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "&USERNAME"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.LoginLabel.BackColor = System.Drawing.Color.Transparent
        Me.LoginLabel.Font = New System.Drawing.Font("Cambria Math", 20.25!, System.Drawing.FontStyle.Bold)
        Me.LoginLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.LoginLabel.Location = New System.Drawing.Point(763, 98)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(224, 151)
        Me.LoginLabel.TabIndex = 16
        Me.LoginLabel.Text = "LOGIN HERE"
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.RegisterLabel)
        Me.Controls.Add(Me.LoginLabel)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterLabel As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LoginLabel As Label
End Class
