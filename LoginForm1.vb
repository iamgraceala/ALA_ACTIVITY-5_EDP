Imports MySql.Data.MySqlClient
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from loginform where username = '" _
                & .UsernameTextBox.Text & "' and password = ('" _
                & .PasswordTextBox.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Form1.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Hide()
        Register_Form.Show()
    End Sub

    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        Hide()
        Form1.Show()
    End Sub

End Class
