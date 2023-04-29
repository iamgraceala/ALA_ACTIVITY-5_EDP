Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Staff

    Public sqlColumns As String = "StaffID as Staff_ID, FirstName as First_Name, LastName as Last_Name, Email as Email, PhoneNumber as Contact, VehiclesSold as Vehicle_Sold"
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
                DataGridViewStaff.AutoSize = True
                .DataGridViewStaff.Refresh()
                .DataGridViewStaff.EndEdit()
                .DataGridViewStaff.DataSource = mydatatable
                .DataGridViewStaff.ReadOnly = True
                .DataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from salesstaff"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from salesstaff")
    End Sub


    Private Sub PrintStaff_Click(sender As Object, e As EventArgs) Handles PrintStaff.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.DataGridViewStaff, "samplereport.xlsx")
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "INSERT INTO salesstaff VALUES('" _
                & .TextStaffID.Text & "', '" _
                & .TextFname.Text & "','" _
                & .TextLastName.Text & "','" _
                & .TextStaffEmail.Text & "','" _
                & .TextStaffNumber.Text & "','" _
                & .TextVehicleSold.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")
                Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub Clear_Boxes()
        TextStaffID.Text = ""
        TextFname.Text = ""
        TextLastName.Text = ""
        TextStaffEmail.Text = ""
        TextStaffNumber.Text = ""
        TextVehicleSold.Text = ""
    End Sub

    Private Sub UpdateStaff_Click(sender As Object, e As EventArgs) Handles UpdateStaff.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE salesstaff SET FirstName =  '" _
            & .TextFname.Text & "', PhoneNumber = '" _
            & .TextStaffNumber.Text & "' WHERE StaffID = '" _
            & .TextStaffID.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated")
                Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub DeleteStaff_Click(sender As Object, e As EventArgs) Handles DeleteStaff.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "DELETE FROM salesstaff WHERE StaffID = '" _
            & .TextStaffID.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Deleted")
                Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With

    End Sub

    Private Sub LoadStaff_Click(sender As Object, e As EventArgs)
        Me.DataGridViewStaff.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM salesstaff"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridViewStaff.Rows.Add(New Object() {myreader.Item("StaffID"), myreader.Item("FirstName"), myreader.Item("LastName"), myreader.Item("Email"), myreader.Item("PhoneNumber"), myreader.Item("VehiclesSold")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub BackStaff_Click(sender As Object, e As EventArgs) Handles BackStaff.Click
        Hide()
        Form1.Show()
    End Sub

End Class