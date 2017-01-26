Imports System.Globalization

Public Class ClosePayroll
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Sub loaddata()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, EmployeeCode From db_payrolldata"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtname.Properties.Items.Add(tbl_par.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Sub loadcounts()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.CommandText = "test"
        Dim p1 As New MySqlParameter
        p1.ParameterName = "@empcode"
        p1.Value = txtempcode.Text
        sqlcommand.Parameters.Add(p1)
        sqlcommand.Connection = SQLConnection
        Dim dt As New DataTable
        dt.Load(sqlcommand.ExecuteReader())
        list.GridControl1.DataSource = dt
        SQLConnection.Close()
    End Sub

    Sub compute()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.CommandText = "bpjs"
        Dim p1 As New MySqlParameter
        p1.ParameterName = "@empcode"
        p1.Value = txtempcode.Text
        sqlcommand.Parameters.Add(p1)
        sqlcommand.Connection = SQLConnection
        Dim dt As New DataTable
        dt.Load(sqlcommand.ExecuteReader)
        list.GridControl1.DataSource = dt
        SQLConnection.Close()
    End Sub

    Dim list As New Lists

    Private Sub ClosePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadgrid()
    End Sub

    Private Sub radiochoose_CheckedChanged(sender As Object, e As EventArgs) Handles radiochoose.CheckedChanged
        If radiochoose.Checked = True Then
            txtname.Enabled = True
        Else
            txtname.Enabled = False
        End If
    End Sub

    Private Sub txtname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtname.SelectedItem Is tbl_par.Rows(index).Item(0).ToString Then
                txtempcode.Text = tbl_par.Rows(index).Item(1).ToString
            End If
        Next
    End Sub

    Sub loadgrid()

    End Sub

    Sub loadbonus()

    End Sub

    Sub loademployee()
    End Sub

    Sub loadall()
    End Sub

    Private Sub processpayroll()
        If payrollcheck.Checked = True Then
            loaddata()
        ElseIf thrcheck.Checked = True Then
            'loadthr()
        ElseIf bonuscheck.Checked = True Then
            loadbonus()
        End If
    End Sub

    Private Sub payrollcheck_CheckedChanged(sender As Object, e As EventArgs) Handles payrollcheck.CheckedChanged

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If list Is Nothing OrElse list.IsDisposed Then
            list = New Lists
        End If
        loadcounts()
        list.Show()
    End Sub

    Private Sub txtempcode_EditValueChanged(sender As Object, e As EventArgs) Handles txtempcode.EditValueChanged

    End Sub

    Private Sub radioloadall_CheckedChanged(sender As Object, e As EventArgs) Handles radioloadall.CheckedChanged
        If radioloadall.Checked = True Then
            txtname.Text = ""
            txtempcode.Text = ""
        End If
    End Sub
End Class