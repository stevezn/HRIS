Public Class Payments
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Sub loaddata()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT a.EmployeeCode, a.FullName, b.BasicRate From db_pegawai a, db_payroll b"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtname.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
            ' txtname1.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub
    Dim tbl_par2 As New DataTable

    Sub loaddatapayrol()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT EmployeeCode, FullName, BasicRate from db_payroll"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            txtname1.Properties.Items.Add(tbl_par2.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Public Function InsertAdjust() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_salaryadjustment " +
                            "(FullName, EmployeeCode, ApprovedBy, Reason, Dates, Amount, Months, Year, Current, New) " +
                            "values (@FullName, @EmployeeCode, @ApprovedBy, @Reason, @Dates, @Amount, @Months, @Year, @Current, @New)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@FullName", txtname1.Text)
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", txtempcode1.Text)
            sqlCommand.Parameters.AddWithValue("@ApprovedBy", txtapp1.Text)
            sqlCommand.Parameters.AddWithValue("@Reason", "")
            sqlCommand.Parameters.AddWithValue("@Dates", "")
            sqlCommand.Parameters.AddWithValue("@Amount", "")
            sqlCommand.Parameters.AddWithValue("@Months", "")
            sqlCommand.Parameters.AddWithValue("@Year", "")
            sqlCommand.Parameters.AddWithValue("@Current", "")
            sqlCommand.Parameters.AddWithValue("@New", "")
            sqlCommand.Connection = SQLConnection
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            SQLConnection.Close()
            Return False
            MsgBox("Error Occured: Could Not Insert Records")
        End Try
    End Function

    Private Sub loadDataReq()
        GridControl3.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If XtraTabPage7.Text = "Salary Adjustment History" Then
                sqlCommand.CommandText = "Select FullName, EmployeeCode, ApprovedBy, Amount, Current, New FROM db_salaryadjustment"
            End If
            sqlCommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl3.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub updatestats()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_payroll SET" +
                                    " BasicRate = @BasicRate" +
                                    " WHERE EmployeeCode = @EmployeeCode"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@BasicRate", "")
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "Loan"
        XtraTabPage3.Show()
        XtraTabPage2.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        barJudul.Caption = "Rapel"
        XtraTabPage4.Show()
    End Sub

    Private Sub VScrollBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        loadDataReq()
        loaddatapayrol()
    End Sub

    Private Sub txtname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtname.SelectedItem Is tbl_par.Rows(index).Item(1).ToString Then
                txtempcode.Text = tbl_par.Rows(index).Item(0).ToString
            End If
        Next
    End Sub

    Private Sub txtmonths_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Dim value As Integer = 0

    Private Sub months()
        If txtmonth.Text = "January" Then
            value = 1
        ElseIf txtmonth.Text = "February" Then
            value = 2
        ElseIf txtmonth.Text = "March" Then
            value = 3
        ElseIf txtmonth.Text = "April" Then
            value = 4
        ElseIf txtmonth.Text = "May" Then
            value = 5
        ElseIf txtmonth.Text = "June" Then
            value = 6
        ElseIf txtmonth.Text = "July" Then
            value = 7
        ElseIf txtmonth.Text = "August" Then
            value = 8
        ElseIf txtmonth.Text = "September" Then
            value = 9
        ElseIf txtmonth.Text = "October" Then
            value = 10
        ElseIf txtmonth.Text = "November" Then
            value = 11
        Else
            value = 12
        End If
        Dim a, res As Integer
        a = Convert.ToInt32(txtrangemon.Text)
        res = value + a
        txtcompletedon.Text = res.ToString
    End Sub

    Private Sub txtmon_SelectedIndexChanged(sender As Object, e As EventArgs)
        months()
        txtyears.Text = Year(Now).ToString
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        barJudul.Caption = "Salary Adjustment"
        XtraTabPage5.Show()
    End Sub

    Private Sub ComboBoxEdit5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmonth.SelectedIndexChanged
        months()
        txtyears.Text = Year(Now).ToString
    End Sub

    Private Sub txtname1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname1.SelectedIndexChanged
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtname1.SelectedItem Is tbl_par2.Rows(index).Item(1).ToString Then
                txtempcode1.Text = tbl_par2.Rows(index).Item(0).ToString
                'txtnowvalue.Text = tbl_par2.Rows(index).Item(2).ToString
            End If
        Next
    End Sub

    Private Sub txtmonths_SelectedIndexChanged(sender As Object, e As EventArgs)
        'txtyear.Text = Year(Now).ToString
        'Dim a, b, res As Integer
        'a = Convert.ToInt32(txtaddamount.Text)
        'b = Convert.ToInt32(txtnowvalue.Text)
        'res = a + b
        'txtnewvalue.Text = res.ToString
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub btnapp1_Click(sender As Object, e As EventArgs) Handles btnapp1.Click
        If txtempcode1.Text = "" Then
            MsgBox("Please insert the data properly!")
        Else
            InsertAdjust()
            updatestats()
        End If
        GridControl3.RefreshDataSource()
    End Sub
    Dim proc As New NewSalary
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        barJudul.Caption = "Calculate Salary"
        If proc Is Nothing OrElse proc.IsDisposed Then
            proc = New NewSalary
        End If
        proc.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        barJudul.Caption = "Paid Holiday"
    End Sub
End Class