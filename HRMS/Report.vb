Public Class Report
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Public Sub Recruitmentreports()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "SELECT RecruitmentReport From reports between StartDate and Until"
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtdate_CheckedChanged(sender As Object, e As EventArgs)
        'If txtdate.Checked = True Then
        '    txtfrom.Enabled = True
        '    txtto.Enabled = True
        'ElseIf txtdate.Checked = False Then
        '    txtfrom.Enabled = False
        '    txtto.Enabled = False
        'End If
    End Sub

    Dim form As New ReportsForm

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If form Is Nothing OrElse form.IsDisposed Then
            form = New ReportsForm
        End If
        form.Show()
    End Sub

    Dim reports As New ReportsForm

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If reports Is Nothing OrElse reports.IsDisposed Then
            reports = New ReportsForm
        End If
        reports.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If reports Is Nothing OrElse reports.IsDisposed Then
            reports = New ReportsForm
        End If
        reports.Show()
    End Sub
End Class