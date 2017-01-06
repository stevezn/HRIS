Public Class Notes

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Dim tbl_par As New DataTable

    Sub loadD()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = "SELECT EmployeeCode, FullName, Position, CompanyCode FROM db_pegawai WHERE Status!='Fired'"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par2 As New DataTable

    Sub loadsp()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, Rotasi, RotasiDate from db_rotasi"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadD()
        loadsp()
    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles LabelControl10.Click

    End Sub

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs) Handles LabelControl8.Click

    End Sub

    Private Sub txtnames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtnames.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtnames.SelectedItem = tbl_par.Rows(indexing).Item(1).ToString() Then
                lcempcode.Text = tbl_par.Rows(indexing).Item(0).ToString()
                lcpos.Text = tbl_par.Rows(indexing).Item(2).ToString()
                lccompcode.Text = tbl_par.Rows(indexing).Item(3).ToString()
                lcsp1.Text = tbl_par2.Rows(indexing).Item(1).ToString()
                lcsp2.Text = tbl_par2.Rows(indexing).Item(2).ToString()
            End If
        Next
    End Sub
End Class