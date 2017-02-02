Public Class Holiday
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable


    Public Function Process() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim dtb, dtr As DateTime
        date1.Format = DateTimePickerFormat.Custom
        date1.CustomFormat = "yyyy-MM-dd"
        dtb = date1.Value
        date2.Format = DateTimePickerFormat.Custom
        date2.CustomFormat = "yyyy-MM-dd"
        dtr = date2.Value
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            str_carsql = "INSERT INTO db_holiday " +
                            "(StartDate, EndDate, Reason) " +
                            " Values (@StartDate, @EndDate, @Reason)"
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@StartDate", dtb.ToString("yyyy-MM-dd"))
            sqlcommand.Parameters.AddWithValue("@EndDate", dtr.ToString("yyyy-MM-dd"))
            sqlcommand.Parameters.AddWithValue("@Reason", txtreason.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            SQLConnection.Close()
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub holiday()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()

        date2.CustomFormat = "yyyy-MM-dd"
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "Select StartDate, EndDate, Reason from db_holiday"
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl1.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Holiday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        holiday()
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If date1.Text = "" Then
            MsgBox("Please Input The Start Date")
        Else
            Process()
            holiday()
        End If
    End Sub
End Class