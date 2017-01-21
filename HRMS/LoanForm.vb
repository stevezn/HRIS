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
        sqlcommand.CommandText = "SELECT EmployeeCode, FullName From db_pegawai"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtname1.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
            txtname.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par3 As New DataTable

    Sub loanlists()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, EmployeeCode from db_loan"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par3)
        For index As Integer = 0 To tbl_par3.Rows.Count - 1
            txtloanname.Properties.Items.Add(tbl_par3.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par2 As New DataTable

    Sub loaddata1()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, EmployeeCode, StatusWajibPajak, MemilikiNpwp, BasicRate, Allowance, Incentives, MealRate, Transport, JaminanKesehatan, Bpjs, JaminanKecelakaanKerja, JaminanKematian, JaminanHariTua, IuranPensiun, BiayaJabatan, Rapel, Loan From db_payrolldata"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            txtname2.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
            txtname3.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Public Sub updatechange()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_payrolldata SET" +
                    " FullName = @FullName" +
                    ", EmployeeCode = @EmployeeCode" +
                    ", StatusWajibPajak = @StatusWajibPajak" +
                    ", MemilikiNpwp = @MemilikiNpwp" +
                    ", BasicRate = @BasicRate" +
                    ", Allowance = @Allowance" +
                    ", Incentives = @Incentives" +
                    ", MealRate = @MealRate" +
                    ", Transport = @Transport" +
                    ", JaminanKesehatan = @JaminanKesehatan" +
                    ", Bpjs = @Bpjs" +
                    ", JaminanKecelakaanKerja = @JaminanKecelakaanKerja" +
                    ", JaminanKematian = @JaminanKematian" +
                    ", JaminanHariTua = @JaminanHariTua" +
                    ", IuranPensiun = @IuranPensiun" +
                    ", BiayaJabatan = @BiayaJabatan" +
                    ", Rapel = @Rapel" +
                    ", Loan = @Loan" +
                    " WHERE EmployeeCode = @EmployeeCode"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@FullName", txtname2.Text)
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtempcode2.Text)
            sqlcommand.Parameters.AddWithValue("@StatusWajibPajak", txtwp1.Text)
            sqlcommand.Parameters.AddWithValue("@MemilikiNpwp", txtnpwp1.Text)
            sqlcommand.Parameters.AddWithValue("@BasicRate", txtbasicrate1.Text)
            sqlcommand.Parameters.AddWithValue("@Allowance", txtallowance1.Text)
            sqlcommand.Parameters.AddWithValue("@Incentives", txtincentives1.Text)
            sqlcommand.Parameters.AddWithValue("@MealRate", txtmealrate1.Text)
            sqlcommand.Parameters.AddWithValue("@Transport", txttransport1.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanKesehatan", cjk1.Checked)
            sqlcommand.Parameters.AddWithValue("@Bpjs", cbpjs1.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", cjkk1.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanKematian", cjamkem1.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanHariTua", cjht1.Checked)
            sqlcommand.Parameters.AddWithValue("@IuranPensiun", ciupe1.Checked)
            sqlcommand.Parameters.AddWithValue("@BiayaJabatan", cbj1.Checked)
            sqlcommand.Parameters.AddWithValue("@Rapel", crapel1.Checked)
            sqlcommand.Parameters.AddWithValue("@Loan", cloan1.Checked)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Changed!")
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function InsertLoan() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            str_carsql = "INSERT INTO db_loan " +
                            "(FullName, EmployeeCode, ApprovedBy, Reason, Dates, AmountOfLoan, Month, Months, SalaryInclude, FromMonths, Year, PaymentPerMonth, CompletedOn ) " +
                            " Values (@FullName, @EmployeeCode, @ApprovedBy, @Reason, @Dates, @AmountOfLoan, @Month, @Months, @SalaryInclude, @FromMonths, @Year, @PaymentPerMonth, @CompletedOn)"
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@FullName", txtname.Text)
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text)
            sqlcommand.Parameters.AddWithValue("@ApprovedBy", txtapproved.Text)
            sqlcommand.Parameters.AddWithValue("@Reason", txtreason.Text)
            sqlcommand.Parameters.AddWithValue("@Dates", txtdates.Text)
            sqlcommand.Parameters.AddWithValue("@AmountOfLoan", txtloan.Text)
            sqlcommand.Parameters.AddWithValue("@Month", "")
            sqlcommand.Parameters.AddWithValue("@Months", txtrangemon.Text)
            sqlcommand.Parameters.AddWithValue("@SalaryInclude", CheckEdit2.Checked)
            sqlcommand.Parameters.AddWithValue("@FromMonths", txtmonth.Text)
            sqlcommand.Parameters.AddWithValue("@Year", txtyears.Text)
            sqlcommand.Parameters.AddWithValue("@PaymentPerMonth", lcpayment.Text)
            sqlcommand.Parameters.AddWithValue("@CompletedOn", txtcompletedon.Text)
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

    Public Function insertrapel2() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            str_carsql = "Insert into db_rapel " +
                        "(FullName, EmployeeCode, RapelRate, EffSince, Until)" +
                        "Values (@FullName, @EmployeeCode, @RapelRate, @EffSince, @Until)"
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@FullName", txtname3.Text)
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtempcode3.Text)
            sqlcommand.Parameters.AddWithValue("@RapelRate", txtrapel.Text)
            sqlcommand.Parameters.AddWithValue("@EffSince", txteffective.Text)
            sqlcommand.Parameters.AddWithValue("@Until", txtuntil.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Added!")
            Return True
        Catch ex As Exception
            SQLConnection.Close()
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function InsertAddPayroll() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            str_carsql = "INSERT INTO db_payrolldata " +
                            "(FullName, EmployeeCode, StatusWajibPajak, MemilikiNpwp, BasicRate, Allowance, Incentives, MealRate, Transport, JaminanKesehatan, Bpjs, JaminanKecelakaanKerja, JaminanKematian, JaminanHariTua, IuranPensiun, BiayaJabatan, Rapel, Loan, Description1, Additional1, Description2, Additional2, Description3, Additional3, Description4, Additional4, Description5, Additional5, Description6, Additional6, Description7, Additional7, Description8, Additional8, DescriptionDeduction1, Deduction1, DescriptionDeduction2, Deduction2, DescriptionDeduction3, Deduction3, DescriptionDeduction4, Deduction4, DescriptionDeduction5, Deduction5, DescriptionDeduction6, Deduction6, DescriptionDeduction7, Deduction7, DescriptionDeduction8, Deduction8) " +
                            "values (@FullName, @EmployeeCode, @StatusWajibPajak, @MemilikiNpwp, @BasicRate, @Allowance, @Incentives, @MealRate, @Transport, @JaminanKesehatan, @Bpjs, @JaminanKecelakaanKerja, @JaminanKematian, @JaminanHariTua, @IuranPensiun, @BiayaJabatan, @Rapel, @Loan, @Description1, @Additional1, @Description2, @Additional2, @Description3, @Additional3, @Description4, @Additional4, @Description5, @Additional5, @Description6, @Additional6, @Description7, @Additional7, @Description8, @Addtional8, @DescriptionDeduction1, @Deduction1, @DescriptionDeduction2, @Deduction2, @DescriptionDeduction3, @Deduction3, @DescriptionDeduction4, @Deduction4, @DescriptionDeduction5, @Deduction5, @DescriptionDeduction6, @Deduction6, @DescriptionDeduction7, @Deduction7, @DescriptionDeduction8, @Deduction8 )"
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@FullName", txtname1.Text)
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtempcode1.Text)
            sqlcommand.Parameters.AddWithValue("@StatusWajibPajak", txtwajibpajak.Text)
            sqlcommand.Parameters.AddWithValue("@MemilikiNpwp", txtnpwp.Text)
            sqlcommand.Parameters.AddWithValue("@BasicRate", txtbasicrate.Text)
            sqlcommand.Parameters.AddWithValue("@Allowance", txtallowance.Text)
            sqlcommand.Parameters.AddWithValue("@Incentives", txtincentives.Text)
            sqlcommand.Parameters.AddWithValue("@MealRate", txtmealrate.Text)
            sqlcommand.Parameters.AddWithValue("@Transport", txttransport.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanKesehatan", cjk.Checked)
            sqlcommand.Parameters.AddWithValue("@Bpjs", cbpjs.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", cjkk.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanKematian", cjamkem.Checked)
            sqlcommand.Parameters.AddWithValue("@JaminanHariTua", cjht.Checked)
            sqlcommand.Parameters.AddWithValue("@IuranPensiun", ciupe.Checked)
            sqlcommand.Parameters.AddWithValue("@BiayaJabatan", cbj.Checked)
            sqlcommand.Parameters.AddWithValue("@Rapel", crapel.Checked)
            sqlcommand.Parameters.AddWithValue("@Loan", cloan.Checked)
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

    Public Function InsertPayroll() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_payrolldata " +
                            "(FullName, EmployeeCode, StatusWajibPajak, MemilikiNpwp, BasicRate, Allowance, Incentives, MealRate, Transport, JaminanKesehatan, Bpjs, JaminanKecelakaanKerja, JaminanKematian, JaminanHariTua, IuranPensiun, BiayaJabatan, Rapel, Loan) " +
                            "values (@FullName, @EmployeeCode, @StatusWajibPajak, @MemilikiNpwp, @BasicRate, @Allowance, @Incentives, @MealRate, @Transport, @JaminanKesehatan, @Bpjs, @JaminanKecelakaanKerja, @JaminanKematian, @JaminanHariTua, @IuranPensiun, @BiayaJabatan, @Rapel, @Loan)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@FullName", txtname1.Text)
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", txtempcode1.Text)
            sqlCommand.Parameters.AddWithValue("@StatusWajibPajak", txtwajibpajak.Text)
            sqlCommand.Parameters.AddWithValue("@MemilikiNpwp", txtnpwp.Text)
            sqlCommand.Parameters.AddWithValue("@BasicRate", txtbasicrate.Text)
            sqlCommand.Parameters.AddWithValue("@Allowance", txtallowance.Text)
            sqlCommand.Parameters.AddWithValue("@Incentives", txtincentives.Text)
            sqlCommand.Parameters.AddWithValue("@MealRate", txtmealrate.Text)
            sqlCommand.Parameters.AddWithValue("@Transport", txttransport.Text)
            sqlCommand.Parameters.AddWithValue("@JaminanKesehatan", cjk.Checked)
            sqlCommand.Parameters.AddWithValue("@Bpjs", cbpjs.Checked)
            sqlCommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", cjkk.Checked)
            sqlCommand.Parameters.AddWithValue("@JaminanKematian", cjamkem.Checked)
            sqlCommand.Parameters.AddWithValue("@JaminanHariTua", cjht.Checked)
            sqlCommand.Parameters.AddWithValue("@IuranPensiun", ciupe.Checked)
            sqlCommand.Parameters.AddWithValue("@BiayaJabatan", cbj.Checked)
            sqlCommand.Parameters.AddWithValue("@Rapel", crapel.Checked)
            sqlCommand.Parameters.AddWithValue("@Loan", cloan.Checked)
            sqlCommand.Connection = SQLConnection
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            SQLConnection.Close()
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub loanpay()
        Try
            Dim a, b, res As Double
            a = Convert.ToDouble(txtloan.Text)
            b = Convert.ToDouble(txtrangemon.Text)
            res = a / b
            lcpayment.Text = res.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadpayroll()
        GridControl2.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            sqlCommand.CommandText = "Select FullName, EmployeeCode, BasicRate FROM db_payrolldata"
            sqlCommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl2.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadrapel()
        GridControl5.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "Select FullName, EmployeeCode, RapelRate, EffSince, Until from db_rapel"
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl5.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadloan()
        GridControl7.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "select FullName, EmployeeCode, AmountOfLoan, FromMonths, PaymentPerMonth, CompletedOn From db_loan "
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl7.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadloanname()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "select FullName, EmployeeCode, AmountOfLoan, Month, Realisasi from db_loan where FullName Like '%" + txtloanname.Text + "%'"
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

    Private Sub loadpayroll1()
        GridControl4.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "Select FullName, EmployeeCode, BasicRate FROM db_payrolldata"
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl4.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
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
        loaddata1()
        loadpayroll()
        loadpayroll1()
        loadloan()
        loanlists()
        loadrapel()
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
        Try
            Dim a, res As Integer
            a = Convert.ToInt32(txtrangemon.Text)
            res = value + a
            txtcompletedon.Text = res.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtname1.SelectedItem Is tbl_par.Rows(index).Item(1).ToString Then
                txtempcode1.Text = tbl_par.Rows(index).Item(0).ToString
            End If
        Next
    End Sub

    Private Sub txtmonths_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub btnapp1_Click(sender As Object, e As EventArgs) Handles btnapp1.Click
        If txtname1.Text = "" OrElse txtempcode1.Text = "" Then
            MsgBox("Please Insert Employee Name Or Employee Code")
        Else
            InsertPayroll()
        End If
        loadpayroll()
        loadpayroll1()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        barJudul.Caption = "Calculate Salary"
        If proc Is Nothing OrElse proc.IsDisposed Then
            proc = New NewSalary
        End If
        proc.Show()
    End Sub

    Private Sub GridControl6_Click(sender As Object, e As EventArgs)

    End Sub

    Dim proc As New NewSalary

    Private Sub ComboBoxEdit6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname2.SelectedIndexChanged
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtname2.SelectedItem Is tbl_par2.Rows(index).Item(0).ToString Then
                txtempcode2.Text = tbl_par2.Rows(index).Item(1).ToString
                txtwp1.Text = tbl_par2.Rows(index).Item(2).ToString
                txtnpwp1.Text = tbl_par2.Rows(index).Item(3).ToString
                txtbasicrate1.Text = tbl_par2.Rows(index).Item(4).ToString
                txtallowance1.Text = tbl_par2.Rows(index).Item(5).ToString
                txtincentives1.Text = tbl_par2.Rows(index).Item(6).ToString
                txtmealrate1.Text = tbl_par2.Rows(index).Item(7).ToString
                txttransport1.Text = tbl_par2.Rows(index).Item(8).ToString
                cjk1.Checked = CBool(tbl_par2.Rows(index).Item(9).ToString)
                cbpjs1.Checked = CBool(tbl_par2.Rows(index).Item(10).ToString)
                cjkk1.Checked = CBool(tbl_par2.Rows(index).Item(11).ToString)
                cjamkem1.Checked = CBool(tbl_par2.Rows(index).Item(12).ToString)
                cjht1.Checked = CBool(tbl_par2.Rows(index).Item(13).ToString)
                ciupe1.Checked = CBool(tbl_par2.Rows(index).Item(14).ToString)
                cbj1.Checked = CBool(tbl_par2.Rows(index).Item(15).ToString)
                crapel1.Checked = CBool(tbl_par2.Rows(index).Item(16).ToString)
                cloan1.Checked = CBool(tbl_par2.Rows(index).Item(17).ToString) '                
            End If
        Next
    End Sub

    Private Sub cjk_CheckedChanged(sender As Object, e As EventArgs) Handles cjk.CheckedChanged

    End Sub

    Dim additional As New Additional

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txtname2.Text = "" OrElse txtempcode2.Text = "" Then
            MsgBox("Please Input Employee Name Or Employee Code!")
        Else
            Dim mess2 As String
            mess2 = CType(MsgBox("Are you sure to change this employee data?", MsgBoxStyle.YesNo, "Warning"), String)
            If CType(mess2, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
                updatechange()
            End If
            Dim mess As String
            mess = CType(MsgBox("Is there any additionals or deductions left?", MsgBoxStyle.YesNo, "Warning"), String)
            If CType(mess, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
                If additional Is Nothing OrElse additional.IsDisposed Then
                    additional = New Additional
                End If
                additional.Show()
            Else
            End If
        End If
        loadpayroll1()
        loadpayroll()
    End Sub

    Private Sub CheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            txtmonth.Enabled = True
            txtyears.Enabled = True
        Else
            txtmonth.Enabled = False
            txtyears.Enabled = False
        End If
    End Sub

    Private Sub btnApp_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        If txtname.Text = "" OrElse txtempcode.Text = "" Then
            MsgBox("Please Insert Employee Name Or Employee Code!")
        Else
            InsertLoan()
        End If
        loadloan()
    End Sub

    Private Sub txtrangemon_EditValueChanged(sender As Object, e As EventArgs) Handles txtrangemon.EditValueChanged
        loanpay()
        months()
    End Sub

    Dim closer As New ClosePayroll

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If closer Is Nothing OrElse closer.IsDisposed Then
            closer = New ClosePayroll
        End If
        closer.Show()
        'XtraTabPage8.Show()
    End Sub

    Dim proses As New PayrollSet

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If proses Is Nothing OrElse proses.IsDisposed Then
            proses = New PayrollSet
        End If
        proses.Show()
    End Sub

    Private Sub txtname3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname3.SelectedIndexChanged
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtname3.SelectedItem Is tbl_par2.Rows(index).Item(0).ToString Then
                txtempcode3.Text = tbl_par2.Rows(index).Item(1).ToString
            End If
        Next
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        XtraTabPage6.Show()
    End Sub

    Sub reset()
        txtname3.Text = ""
        txtempcode3.Text = ""
        txtrapel.Text = ""
        txteffective.Text = ""
        txtuntil.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtname3.Text = "" Or txtempcode3.Text = "" Then
            MsgBox("Please Insert Employee Code Or Employee Name")
        Else
            insertrapel2()
            reset()
        End If
        loadrapel()
    End Sub

    Dim value1, value2 As Integer

    Private Sub txtuntil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtuntil.SelectedIndexChanged
        If txtuntil.Text = "January" Then
            value2 = 1
        ElseIf txtuntil.Text = "February" Then
            value2 = 2
        ElseIf txtuntil.Text = "March" Then
            value2 = 3
        ElseIf txtuntil.Text = "April" Then
            value2 = 4
        ElseIf txtuntil.Text = "May" Then
            value2 = 5
        ElseIf txtuntil.Text = "June" Then
            value2 = 6
        ElseIf txtuntil.Text = "July" Then
            value2 = 7
        ElseIf txtuntil.Text = "August" Then
            value2 = 8
        ElseIf txtuntil.Text = "September" Then
            value2 = 9
        ElseIf txtuntil.Text = "October" Then
            value2 = 10
        ElseIf txtuntil.Text = "November" Then
            value2 = 11
        Else
            value2 = 12
        End If
    End Sub

    Private Sub txtloanname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtloanname.SelectedIndexChanged
        For index As Integer = 0 To tbl_par3.Rows.Count - 1
            If txtloanname.SelectedItem Is tbl_par3.Rows(index).Item(0).ToString Then
            End If
        Next
    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        loadloanname()
    End Sub

    Dim act As String = ""

    Private Sub GridView7_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView7.FocusedRowChanged

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim datatabl As New DataTable
        Dim sqlCommand As New MySqlCommand
        datatabl.Clear()
        Dim param As String = ""
            Try
            param = "And EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
        Catch ex As Exception
            End Try
            If param > "" Then
                act = "edit"
            Else
                act = "input"
            End If
            Try
            sqlCommand.CommandText = "SELECT FullName, EmployeeCode FROM db_loan WHERE 1 = 1 " + param.ToString()
            sqlCommand.Connection = SQLConnection
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
                Dim cb As New MySqlCommandBuilder(adapter)
                adapter.Fill(datatabl)
                SQLConnection.Close()
            Catch ex As Exception
                SQLConnection.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        If datatabl.Rows.Count > 0 Then
            txtloanname.Text = datatabl.Rows(0).Item(0).ToString()
            txtempcode.Text = datatabl.Rows(0).Item(1).ToString()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Dim pay As New Payslip

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If pay Is Nothing OrElse pay.IsDisposed Then
            pay = New Payslip
        End If
        pay.Show()
    End Sub

    Private Sub TextEdit27_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEdit26_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEdit20_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbasicrate_EditValueChanged(sender As Object, e As EventArgs) Handles txtbasicrate.EditValueChanged

    End Sub

    Private Sub txtbasicrate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbasicrate.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtallowance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtallowance.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtincentives_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtincentives.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmealrate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmealrate.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttransport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttransport.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txteffective_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txteffective.SelectedIndexChanged
        If txteffective.Text = "January" Then
            value = 0
        ElseIf txteffective.Text = "February" Then
            value = 1
        ElseIf txteffective.Text = "March" Then
            value = 2
        ElseIf txteffective.Text = "April" Then
            value = 3
        ElseIf txteffective.Text = "May" Then
            value = 4
        ElseIf txteffective.Text = "June" Then
            value = 5
        ElseIf txteffective.Text = "July" Then
            value = 6
        ElseIf txteffective.Text = "August" Then
            value = 7
        ElseIf txteffective.Text = "September" Then
            value = 8
        ElseIf txteffective.Text = "October" Then
            value = 9
        ElseIf txteffective.Text = "November" Then
            value = 10
        Else
            value = 11
        End If
    End Sub
End Class