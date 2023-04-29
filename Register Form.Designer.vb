<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_Form
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.User_ID = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.DarkKhaki
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(836, 401)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 13)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Go Back To Login?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria Math", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(727, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 151)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "REGISTER HERE"
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBoxUserID.Location = New System.Drawing.Point(771, 238)
        Me.TextBoxUserID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(203, 26)
        Me.TextBoxUserID.TabIndex = 23
        '
        'User_ID
        '
        Me.User_ID.AutoSize = True
        Me.User_ID.BackColor = System.Drawing.Color.Transparent
        Me.User_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_ID.Location = New System.Drawing.Point(673, 243)
        Me.User_ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.User_ID.Name = "User_ID"
        Me.User_ID.Size = New System.Drawing.Size(52, 16)
        Me.User_ID.TabIndex = 22
        Me.User_ID.Text = "User ID"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Location = New System.Drawing.Point(783, 352)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(191, 32)
        Me.btnRegister.TabIndex = 21
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'TextPassword
        '
        Me.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassword.Location = New System.Drawing.Point(771, 297)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(203, 26)
        Me.TextPassword.TabIndex = 20
        '
        'TextUsername
        '
        Me.TextUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsername.Location = New System.Drawing.Point(771, 267)
        Me.TextUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(203, 26)
        Me.TextUsername.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(673, 302)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Password"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(673, 272)
        Me.Email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(70, 16)
        Me.Email.TabIndex = 17
        Me.Email.Text = "Username"
        '
        'Register_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.User_ID)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Email)
        Me.DoubleBuffered = True
        Me.Name = "Register_Form"
        Me.Text = "Register_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUserID As TextBox
    Friend WithEvents User_ID As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Email As Label
End Class
