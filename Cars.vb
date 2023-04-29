Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Cars
    Private dt As DataTable

    Public sqlColumns As String = "serial_no as Serial_No, car_unit as Unit, car_model as Model, car_year as Year, car_color as Color, car_type as Type, engine_size as Engine_Size, transmission as Transmission, fuel_type as Fuel_Type, price as Price"
    Private Sub Load_Data_to_Grid(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        Connect_to_DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable

                myreader.Close()
                mydataAdapter.SelectCommand = mycommand

                mydataAdapter.Fill(mydatatable)
                dgreport0.AutoSize = True
                .dgreport0.Refresh()
                .dgreport0.EndEdit()
                .dgreport0.DataSource = mydatatable
                .dgreport0.ReadOnly = True
                .dgreport0.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                '.dgreport.Columns("cost_price").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("dname").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.dgreport.Columns("username").DefaultCellStyle.Format = "#,##0.00"
                '.dgreport.Columns("dnumber").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from cars"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from carsforsale")
    End Sub

    Private Sub BtnPrintCars_Click(sender As Object, e As EventArgs) Handles btnPrintCars.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.dgreport0, "samplereport.xlsx")
    End Sub

    Private Sub BackButton2_Click(sender As Object, e As EventArgs) Handles BackButton2.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim filePath As String = ""

        ' Show the OpenFileDialog box
        If btnImport.ShowDialog() = DialogResult.OK Then
            filePath = btnImport.FileName
        End If

        ' Load the CSV file into a DataTable
        Dim dt As New DataTable()
        Using sr As New StreamReader(filePath)
            Dim headers() As String = sr.ReadLine().Split(","c)
            For i As Integer = 0 To headers.Length - 1
                Select Case i
                    Case 0
                        dt.Columns.Add("Serial No.")
                    Case 1
                        dt.Columns.Add("Unit")
                    Case 2
                        dt.Columns.Add("Model")
                    Case 3
                        dt.Columns.Add("Year")
                    Case 4
                        dt.Columns.Add("Color")
                    Case 5
                        dt.Columns.Add("Fuel Type")
                    Case 6
                        dt.Columns.Add("Type")
                    Case 7
                        dt.Columns.Add("Engine Size")
                    Case 8
                        dt.Columns.Add("Transmission Size")
                    Case 9
                        dt.Columns.Add("Price")
                End Select
            Next
            While Not sr.EndOfStream
                Dim rows() As String = sr.ReadLine().Split(","c)
                If rows.Length <= 10 Then
                    Dim newRow As DataRow = dt.NewRow()
                    For i As Integer = 0 To rows.Length - 1
                        newRow(i) = rows(i)
                    Next
                    dt.Rows.Add(newRow)
                End If
            End While
        End Using

        ' Bind the DataTable to the DataGridView
        dgreport0.DataSource = dt
    End Sub



    Private Sub BackupButton_Click(sender As Object, e As EventArgs) Handles BackUpButton.Click
        ' Select the folder to save the backup file
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            ' Construct the full path for the backup file
            Dim filePath As String = Path.Combine(folderBrowserDialog.SelectedPath, "backup.sql")

            ' Write the MySQL dump file
            Using sw As New StreamWriter(filePath)
                Dim connectionString As String = "Server=localhost;Port=3306;Database=automotivedb;Uid=root;Pwd=mgra;"
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Using cmd As New MySqlCommand()
                        cmd.Connection = conn
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "SELECT @@VERSION;"
                        Dim version As String = cmd.ExecuteScalar()
                        sw.WriteLine("-- MySQL dump " & version)
                        sw.WriteLine("-- Created on " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        sw.WriteLine("")
                        sw.WriteLine("USE automotivedb;")
                        sw.WriteLine("")
                        sw.WriteLine("DROP TABLE IF EXISTS `carsforsale`;")
                        sw.WriteLine("")
                        sw.WriteLine("CREATE TABLE `carsforsale` (")
                        sw.WriteLine("`Serial No.` int(11) NOT NULL AUTO_INCREMENT,")
                        sw.WriteLine("`Unit` varchar(50) NOT NULL,")
                        sw.WriteLine("`Model` varchar(50) NOT NULL,")
                        sw.WriteLine("`Year` int(11) NOT NULL,")
                        sw.WriteLine("`Color` varchar(50) NOT NULL,")
                        sw.WriteLine("`Fuel Type` varchar(50) NOT NULL,")
                        sw.WriteLine("`Type` varchar(50) NOT NULL,")
                        sw.WriteLine("PRIMARY KEY (`Serial No.`)")
                        sw.WriteLine(") ENGINE=InnoDB DEFAULT CHARSET=utf8;")
                        sw.WriteLine("")
                        Dim dt As DataTable = GetDataTable("SELECT * FROM `carsforsale`;", conn)
                        If dt IsNot Nothing Then
                            For Each row As DataRow In dt.Rows
                                Dim values As New List(Of String)()
                                For Each col As DataColumn In dt.Columns
                                    values.Add("'" & row(col.ColumnName).ToString().Replace("'", "''") & "'")
                                Next
                                sw.WriteLine("INSERT INTO `carsforsale` (" & String.Join(", ", dt.Columns.Cast(Of DataColumn).Select(Function(c) "`" & c.ColumnName & "`")) & ") VALUES (" & String.Join(", ", values) & ");")
                            Next
                        End If
                    End Using
                End Using
            End Using
            MessageBox.Show("Backup completed successfully.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function GetDataTable(ByVal query As String, ByVal conn As MySqlConnection) As DataTable
        Dim dt As New DataTable()
        Using da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function
End Class