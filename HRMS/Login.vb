Public Class Login
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Dim main As New MainApp

    Private Sub tePassword_TextChanged(sender As Object, e As EventArgs) Handles tePassword.TextChanged
        Try
            SQLConnection = New MySqlConnection()
            SQLConnection.ConnectionString = connectionString
            SQLConnection.Open()
            Dim tbl_par As New DataTable
            Dim sqlCommand As New MySqlCommand
            sqlCommand.CommandText = "SELECT * FROM db_user WHERE username ='" + teUsername.Text + "' and password='" + tePassword.Text + "'"
            sqlCommand.Connection = SQLConnection
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(tbl_par)
            If tbl_par.Rows.Count > 0 Then
                main.Show()
            End If
            'Else
            '    'MessageBox.Show("Username and Password Didn't Match!")
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub countButton_Click(sender As Object, e As EventArgs) Handles countButton.Click
        Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class