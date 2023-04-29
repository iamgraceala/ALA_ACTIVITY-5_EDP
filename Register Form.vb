Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Register_Form
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into loginform values('" _
                & .TextBoxUserID.Text & "', '" _
                & .TextUsername.Text & "','" _
                & .TextPassword.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("You Are Successfully Registered")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .TextBoxUserID.Text = ""
            .TextUsername.Text = ""
            .TextPassword.Text = ""

        End With
    End Sub

    Private Sub LinkLabelLB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Hide()
        LoginForm1.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Hide()
        LoginForm1.Show()
    End Sub

End Class