
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Buyer
    Public sqlColumns As String = "CustomerID as Customer_ID, CustomerName as Customer, UnitPurchased as Unit_Purchased, CustomerAddress as Address, PhoneNumber as Contact_No, AmountPurchased as Total_Payment"
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
                DataGridViewBuyer.AutoSize = True
                .DataGridViewBuyer.Refresh()
                .DataGridViewBuyer.EndEdit()
                .DataGridViewBuyer.DataSource = mydatatable
                .DataGridViewBuyer.ReadOnly = True
                .DataGridViewBuyer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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

    Private Sub PrintBuyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from customers"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from customers")
    End Sub


    Private Sub PrintBuyer_Click(sender As Object, e As EventArgs) Handles PrintBuyer.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.DataGridViewBuyer, "samplereport.xlsx")
    End Sub
    Private Sub BtnAddBuyer_Click(sender As Object, e As EventArgs) Handles btnAddBuyer.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into customers values('" _
                & .TextBuyersId.Text & "', '" _
                & .TextBuyerName.Text & "','" _
                & .TextBuyerContact.Text & "','" _
                & .TextBuyerAddress.Text & "','" _
                & .TextAmountPurchased.Text & "','" _
                & .TextUnitPurchased.Text & "')"
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
        TextBuyersId.Text = ""
        TextBuyerName.Text = ""
        TextBuyerContact.Text = ""
        TextBuyerAddress.Text = ""
        TextAmountPurchased.Text = ""
        TextUnitPurchased.Text = ""
    End Sub

    Private Sub UpdateBuyer_Click(sender As Object, e As EventArgs) Handles UpdateBuyer.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update customers set CustomerName =  '" _
                & .TextBuyerName.Text & "',PhoneNumber = '" _
                & .TextBuyerContact.Text & "' where CustomerID = '" _
                & .TextBuyersId.Text & "'"
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

    Private Sub DeleteBuyer_Click(sender As Object, e As EventArgs) Handles DeleteBuyer.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Delete from customers where CustomerID = '" _
                & .TextBuyersId.Text & "'"
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

    Private Sub LoadBuyer_Click(sender As Object, e As EventArgs)
        Me.DataGridViewBuyer.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM customers"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridViewBuyer.Rows.Add(New Object() {myreader.Item("CustomerID"), myreader.Item("CustomerName"), myreader.Item("PhoneNumber"), myreader.Item("CustomerAddress"), myreader.Item("UnitPurchased"), myreader.Item("AmountPurchased")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub BackBuyer_Click(sender As Object, e As EventArgs) Handles BackBuyer.Click
        Hide()
        Form1.Show()
    End Sub
End Class

