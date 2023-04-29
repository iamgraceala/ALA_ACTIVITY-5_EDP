Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Supplier

    Public sqlColumns As String = "SupplierID as Supplier_ID, SuppName as Supplier, SupplierAddress as Address, SupplierContact as Contact, SupplierEmail as Email"
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
                    dgreport.AutoSize = True
                    .dgreport.Refresh()
                    .dgreport.EndEdit()
                    .dgreport.DataSource = mydatatable
                    .dgreport.ReadOnly = True
                    .dgreport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
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

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'strSQL = "select " & Me.sqlColumns & " from suppliers"
        'Me.Label1.Text = strSQL
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from suppliers")
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'MsgBox(currentDate.ToString)
        Call importToExcel(Me.dgreport, "samplereport.xlsx")
    End Sub

    Private Sub BtnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "INSERT INTO suppliers VALUES('" _
                & .TextSuppID.Text & "', '" _
                & .TextSuppName.Text & "','" _
                & .TextSuppEmail.Text & "','" _
                & .TextSuppContact.Text & "','" _
                & .TextSuppAddress.Text & "')"
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
        TextSuppID.Text = ""
        TextSuppName.Text = ""
        TextSuppEmail.Text = ""
        TextSuppContact.Text = ""
        TextSuppAddress.Text = ""
    End Sub

    Private Sub UpdateSupplier_Click(sender As Object, e As EventArgs) Handles UpdateSupplier.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "UPDATE suppliers SET SuppName =  '" _
            & .TextSuppName.Text & "', SupplierContact = '" _
            & .TextSuppContact.Text & "' WHERE SupplierID = " _
            & .TextSuppID.Text
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

    Private Sub DeleteSupplier_Click(sender As Object, e As EventArgs) Handles DeleteSupplier.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "DELETE FROM suppliers WHERE SupplierID = '" _
            & .TextSuppID.Text & "'"
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

    Private Sub BackSupplier_Click(sender As Object, e As EventArgs) Handles BackSupplier.Click
        Hide()
        Form1.Show()
    End Sub
End Class
