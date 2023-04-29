Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Cars.Show()
    End Sub

    Private Sub SupplierButton_Click(sender As Object, e As EventArgs) Handles SupplierButton.Click
        Hide()
        Supplier.Show()
    End Sub

    Private Sub StaffButton_Click(sender As Object, e As EventArgs) Handles StaffButton.Click
        Hide()
        Staff.Show
    End Sub

    Private Sub SoldButton_Click(sender As Object, e As EventArgs) Handles SoldButton.Click
        Hide()
        SoldCars.Show
    End Sub

    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        Hide()
        Buyer.Show
    End Sub
End Class
