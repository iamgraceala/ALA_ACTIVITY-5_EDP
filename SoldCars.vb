Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class SoldCars


    Public sqlColumns As String = "SoldID as Purchase_Number, CustomerID as Buyer_ID, Unit as Unit, SalePrice as Price, SaleDate as Date_Purchased"
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
                DataGridViewSoldCars.AutoSize = True
                .DataGridViewSoldCars.Refresh()
                .DataGridViewSoldCars.EndEdit()
                .DataGridViewSoldCars.DataSource = mydatatable
                .DataGridViewSoldCars.ReadOnly = True
                .DataGridViewSoldCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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

    Private Sub SoldCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from sold"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from sold")
    End Sub


    Private Sub PrintSoldCars_Click(sender As Object, e As EventArgs) Handles PrintSoldCars.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.DataGridViewSoldCars, "samplereport.xlsx")
    End Sub

    Private Sub BtnAddSoldCars_Click(sender As Object, e As EventArgs) Handles btnAddSoldCars.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "INSERT INTO sold VALUES('" _
                & .TextSoldID.Text & "', '" _
                & .TextSoldCustomerID.Text & "','" _
                & .TextSoldCarUnit.Text & "','" _
                & .TextSalePrice.Text & "','" _
                & .TextSaleDate.Text & "')"
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
        TextSoldID.Text = ""
        TextSoldCustomerID.Text = ""
        TextSoldCarUnit.Text = ""
        TextSalePrice.Text = ""
        TextSaleDate.Text = ""
    End Sub

    Private Sub UpdateSoldCars_Click(sender As Object, e As EventArgs) Handles UpdateSoldCars.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE sold SET SoldCustomerID =  '" _
            & .TextSoldCustomerID.Text & "', SoldCarUnit = '" _
            & .TextSoldCarUnit.Text & "', SalePrice = '" _
            & .TextSalePrice.Text & "', SaleDate = '" _
            & .TextSaleDate.Text & "' WHERE SoldID = " _
            & .TextSoldID.Text
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

    Private Sub DeleteSolCars_Click(sender As Object, e As EventArgs) Handles DeleteSoldCars.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "DELETE FROM sold WHERE SoldID = '" _
            & .TextSoldID.Text & "'"
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

    Private Sub LoadSoldCars_Click(sender As Object, e As EventArgs)
        Me.DataGridViewSoldCars.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT * FROM sold"
        Connect_to_DB()
        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.DataGridViewSoldCars.Rows.Add(New Object() {myreader.Item("SoldID"), myreader.Item("Unit"), myreader.Item("CustomerID"), myreader.Item("SalePrice"), myreader.Item("SaleDate")})
        End While
        Disconnect_to_DB()

    End Sub

    Private Sub BackSoldCars_Click(sender As Object, e As EventArgs) Handles BackSoldCars.Click
        Hide()
        Form1.Show()
    End Sub
End Class
