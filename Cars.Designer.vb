<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Me.TextType = New System.Windows.Forms.TextBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.TextFuel = New System.Windows.Forms.TextBox()
        Me.LabelFuel = New System.Windows.Forms.Label()
        Me.TextColor = New System.Windows.Forms.TextBox()
        Me.LabelColor = New System.Windows.Forms.Label()
        Me.TextYear = New System.Windows.Forms.TextBox()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.TextModel1 = New System.Windows.Forms.TextBox()
        Me.modelLabel1 = New System.Windows.Forms.Label()
        Me.TextCarUnit = New System.Windows.Forms.TextBox()
        Me.TextSerial = New System.Windows.Forms.TextBox()
        Me.CarName = New System.Windows.Forms.Label()
        Me.serialNo = New System.Windows.Forms.Label()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.TextEngineSize = New System.Windows.Forms.TextBox()
        Me.LabelEngine = New System.Windows.Forms.Label()
        Me.dgreport0 = New System.Windows.Forms.DataGridView()
        Me.BackButton2 = New System.Windows.Forms.Button()
        Me.TextTransmission = New System.Windows.Forms.TextBox()
        Me.LabelTransmission = New System.Windows.Forms.Label()
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.OpenFileDialog()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.BackUpButton = New System.Windows.Forms.Button()
        Me.folderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnPrintCars = New System.Windows.Forms.Button()
        CType(Me.dgreport0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextType
        '
        Me.TextType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextType.Location = New System.Drawing.Point(811, 48)
        Me.TextType.Margin = New System.Windows.Forms.Padding(2)
        Me.TextType.Name = "TextType"
        Me.TextType.Size = New System.Drawing.Size(177, 20)
        Me.TextType.TabIndex = 66
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.BackColor = System.Drawing.Color.Transparent
        Me.LabelType.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelType.Location = New System.Drawing.Point(740, 48)
        Me.LabelType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(31, 14)
        Me.LabelType.TabIndex = 65
        Me.LabelType.Text = "Type"
        '
        'TextFuel
        '
        Me.TextFuel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextFuel.Location = New System.Drawing.Point(552, 103)
        Me.TextFuel.Margin = New System.Windows.Forms.Padding(2)
        Me.TextFuel.Name = "TextFuel"
        Me.TextFuel.Size = New System.Drawing.Size(177, 20)
        Me.TextFuel.TabIndex = 64
        '
        'LabelFuel
        '
        Me.LabelFuel.AutoSize = True
        Me.LabelFuel.BackColor = System.Drawing.Color.Transparent
        Me.LabelFuel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFuel.Location = New System.Drawing.Point(481, 103)
        Me.LabelFuel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFuel.Name = "LabelFuel"
        Me.LabelFuel.Size = New System.Drawing.Size(55, 14)
        Me.LabelFuel.TabIndex = 63
        Me.LabelFuel.Text = "Fuel Type"
        '
        'TextColor
        '
        Me.TextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextColor.Location = New System.Drawing.Point(552, 77)
        Me.TextColor.Margin = New System.Windows.Forms.Padding(2)
        Me.TextColor.Name = "TextColor"
        Me.TextColor.Size = New System.Drawing.Size(177, 20)
        Me.TextColor.TabIndex = 62
        '
        'LabelColor
        '
        Me.LabelColor.AutoSize = True
        Me.LabelColor.BackColor = System.Drawing.Color.Transparent
        Me.LabelColor.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColor.Location = New System.Drawing.Point(481, 77)
        Me.LabelColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelColor.Name = "LabelColor"
        Me.LabelColor.Size = New System.Drawing.Size(32, 14)
        Me.LabelColor.TabIndex = 61
        Me.LabelColor.Text = "Color"
        '
        'TextYear
        '
        Me.TextYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextYear.Location = New System.Drawing.Point(552, 48)
        Me.TextYear.Margin = New System.Windows.Forms.Padding(2)
        Me.TextYear.Name = "TextYear"
        Me.TextYear.Size = New System.Drawing.Size(177, 20)
        Me.TextYear.TabIndex = 60
        '
        'LabelYear
        '
        Me.LabelYear.AutoSize = True
        Me.LabelYear.BackColor = System.Drawing.Color.Transparent
        Me.LabelYear.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYear.Location = New System.Drawing.Point(481, 52)
        Me.LabelYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(28, 14)
        Me.LabelYear.TabIndex = 59
        Me.LabelYear.Text = "Year"
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRecord.ForeColor = System.Drawing.Color.Snow
        Me.btnDeleteRecord.Location = New System.Drawing.Point(505, 485)
        Me.btnDeleteRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(127, 36)
        Me.btnDeleteRecord.TabIndex = 58
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRecord.ForeColor = System.Drawing.Color.Snow
        Me.btnUpdateRecord.Location = New System.Drawing.Point(350, 485)
        Me.btnUpdateRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(127, 36)
        Me.btnUpdateRecord.TabIndex = 57
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.UseVisualStyleBackColor = False
        '
        'TextModel1
        '
        Me.TextModel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextModel1.Location = New System.Drawing.Point(291, 102)
        Me.TextModel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextModel1.Name = "TextModel1"
        Me.TextModel1.Size = New System.Drawing.Size(177, 20)
        Me.TextModel1.TabIndex = 56
        '
        'modelLabel1
        '
        Me.modelLabel1.AutoSize = True
        Me.modelLabel1.BackColor = System.Drawing.Color.Transparent
        Me.modelLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelLabel1.Location = New System.Drawing.Point(220, 105)
        Me.modelLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.modelLabel1.Name = "modelLabel1"
        Me.modelLabel1.Size = New System.Drawing.Size(38, 14)
        Me.modelLabel1.TabIndex = 55
        Me.modelLabel1.Text = "Model"
        '
        'TextCarUnit
        '
        Me.TextCarUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCarUnit.Location = New System.Drawing.Point(291, 77)
        Me.TextCarUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.TextCarUnit.Name = "TextCarUnit"
        Me.TextCarUnit.Size = New System.Drawing.Size(177, 20)
        Me.TextCarUnit.TabIndex = 54
        '
        'TextSerial
        '
        Me.TextSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextSerial.Location = New System.Drawing.Point(291, 53)
        Me.TextSerial.Margin = New System.Windows.Forms.Padding(2)
        Me.TextSerial.Name = "TextSerial"
        Me.TextSerial.Size = New System.Drawing.Size(177, 20)
        Me.TextSerial.TabIndex = 53
        '
        'CarName
        '
        Me.CarName.AutoSize = True
        Me.CarName.BackColor = System.Drawing.Color.Transparent
        Me.CarName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarName.Location = New System.Drawing.Point(220, 77)
        Me.CarName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CarName.Name = "CarName"
        Me.CarName.Size = New System.Drawing.Size(47, 14)
        Me.CarName.TabIndex = 52
        Me.CarName.Text = "Car Unit"
        '
        'serialNo
        '
        Me.serialNo.AutoSize = True
        Me.serialNo.BackColor = System.Drawing.Color.Transparent
        Me.serialNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serialNo.Location = New System.Drawing.Point(220, 52)
        Me.serialNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.serialNo.Name = "serialNo"
        Me.serialNo.Size = New System.Drawing.Size(55, 14)
        Me.serialNo.TabIndex = 51
        Me.serialNo.Text = "Serial No."
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRecord.ForeColor = System.Drawing.Color.Snow
        Me.btnAddRecord.Location = New System.Drawing.Point(186, 485)
        Me.btnAddRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(127, 36)
        Me.btnAddRecord.TabIndex = 50
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'TextEngineSize
        '
        Me.TextEngineSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextEngineSize.Location = New System.Drawing.Point(811, 77)
        Me.TextEngineSize.Margin = New System.Windows.Forms.Padding(2)
        Me.TextEngineSize.Name = "TextEngineSize"
        Me.TextEngineSize.Size = New System.Drawing.Size(177, 20)
        Me.TextEngineSize.TabIndex = 68
        '
        'LabelEngine
        '
        Me.LabelEngine.AutoSize = True
        Me.LabelEngine.BackColor = System.Drawing.Color.Transparent
        Me.LabelEngine.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEngine.Location = New System.Drawing.Point(740, 77)
        Me.LabelEngine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEngine.Name = "LabelEngine"
        Me.LabelEngine.Size = New System.Drawing.Size(63, 14)
        Me.LabelEngine.TabIndex = 67
        Me.LabelEngine.Text = "Engine Size"
        '
        'dgreport0
        '
        Me.dgreport0.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgreport0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgreport0.GridColor = System.Drawing.Color.DarkOliveGreen
        Me.dgreport0.Location = New System.Drawing.Point(168, 169)
        Me.dgreport0.Name = "dgreport0"
        Me.dgreport0.Size = New System.Drawing.Size(796, 281)
        Me.dgreport0.TabIndex = 69
        '
        'BackButton2
        '
        Me.BackButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.BackButton2.Location = New System.Drawing.Point(485, 543)
        Me.BackButton2.Name = "BackButton2"
        Me.BackButton2.Size = New System.Drawing.Size(106, 30)
        Me.BackButton2.TabIndex = 70
        Me.BackButton2.Text = "Back"
        Me.BackButton2.UseVisualStyleBackColor = True
        '
        'TextTransmission
        '
        Me.TextTransmission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTransmission.Location = New System.Drawing.Point(811, 105)
        Me.TextTransmission.Margin = New System.Windows.Forms.Padding(2)
        Me.TextTransmission.Name = "TextTransmission"
        Me.TextTransmission.Size = New System.Drawing.Size(177, 20)
        Me.TextTransmission.TabIndex = 72
        '
        'LabelTransmission
        '
        Me.LabelTransmission.AutoSize = True
        Me.LabelTransmission.BackColor = System.Drawing.Color.Transparent
        Me.LabelTransmission.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransmission.Location = New System.Drawing.Point(740, 105)
        Me.LabelTransmission.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTransmission.Name = "LabelTransmission"
        Me.LabelTransmission.Size = New System.Drawing.Size(71, 14)
        Me.LabelTransmission.TabIndex = 71
        Me.LabelTransmission.Text = "Transmission"
        '
        'TextPrice
        '
        Me.TextPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPrice.Location = New System.Drawing.Point(552, 127)
        Me.TextPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(177, 20)
        Me.TextPrice.TabIndex = 74
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelPrice.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(485, 129)
        Me.LabelPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(31, 14)
        Me.LabelPrice.TabIndex = 73
        Me.LabelPrice.Text = "Price"
        '
        'btnImport
        '
        Me.btnImport.FileName = "OpenFileDialog1"
        '
        'LoadButton
        '
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.LoadButton.Location = New System.Drawing.Point(597, 543)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(106, 30)
        Me.LoadButton.TabIndex = 76
        Me.LoadButton.Text = "Import"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'BackUpButton
        '
        Me.BackUpButton.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BackUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackUpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackUpButton.ForeColor = System.Drawing.Color.Snow
        Me.BackUpButton.Location = New System.Drawing.Point(655, 485)
        Me.BackUpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackUpButton.Name = "BackUpButton"
        Me.BackUpButton.Size = New System.Drawing.Size(127, 36)
        Me.BackUpButton.TabIndex = 77
        Me.BackUpButton.Text = "Back Up"
        Me.BackUpButton.UseVisualStyleBackColor = False
        '
        'btnPrintCars
        '
        Me.btnPrintCars.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnPrintCars.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrintCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCars.ForeColor = System.Drawing.Color.Snow
        Me.btnPrintCars.Location = New System.Drawing.Point(798, 485)
        Me.btnPrintCars.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrintCars.Name = "btnPrintCars"
        Me.btnPrintCars.Size = New System.Drawing.Size(127, 36)
        Me.btnPrintCars.TabIndex = 78
        Me.btnPrintCars.Text = "Print Record"
        Me.btnPrintCars.UseVisualStyleBackColor = False
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StartHereDemo2.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1115, 585)
        Me.Controls.Add(Me.btnPrintCars)
        Me.Controls.Add(Me.BackUpButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.TextPrice)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.TextTransmission)
        Me.Controls.Add(Me.LabelTransmission)
        Me.Controls.Add(Me.BackButton2)
        Me.Controls.Add(Me.dgreport0)
        Me.Controls.Add(Me.TextEngineSize)
        Me.Controls.Add(Me.LabelEngine)
        Me.Controls.Add(Me.TextType)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.TextFuel)
        Me.Controls.Add(Me.LabelFuel)
        Me.Controls.Add(Me.TextColor)
        Me.Controls.Add(Me.LabelColor)
        Me.Controls.Add(Me.TextYear)
        Me.Controls.Add(Me.LabelYear)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnUpdateRecord)
        Me.Controls.Add(Me.TextModel1)
        Me.Controls.Add(Me.modelLabel1)
        Me.Controls.Add(Me.TextCarUnit)
        Me.Controls.Add(Me.TextSerial)
        Me.Controls.Add(Me.CarName)
        Me.Controls.Add(Me.serialNo)
        Me.Controls.Add(Me.btnAddRecord)
        Me.DoubleBuffered = True
        Me.Name = "Cars"
        Me.Text = "CarsForSale"
        CType(Me.dgreport0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextType As TextBox
    Friend WithEvents LabelType As Label
    Friend WithEvents TextFuel As TextBox
    Friend WithEvents LabelFuel As Label
    Friend WithEvents TextColor As TextBox
    Friend WithEvents LabelColor As Label
    Friend WithEvents TextYear As TextBox
    Friend WithEvents LabelYear As Label
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents TextModel1 As TextBox
    Friend WithEvents modelLabel1 As Label
    Friend WithEvents TextCarUnit As TextBox
    Friend WithEvents TextSerial As TextBox
    Friend WithEvents CarName As Label
    Friend WithEvents serialNo As Label
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents TextEngineSize As TextBox
    Friend WithEvents LabelEngine As Label
    Friend WithEvents dgreport0 As DataGridView
    Friend WithEvents BackButton2 As Button
    Friend WithEvents TextTransmission As TextBox
    Friend WithEvents LabelTransmission As Label
    Friend WithEvents TextPrice As TextBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents btnImport As OpenFileDialog
    Friend WithEvents LoadButton As Button
    Friend WithEvents BackUpButton As Button
    Friend WithEvents folderDialog As FolderBrowserDialog
    Friend WithEvents folderBrowserDialog As FolderBrowserDialog
    Friend WithEvents btnPrintCars As Button
End Class
