﻿Public Class Calculate
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Sub loaddata()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, EmployeeCode, StatusWajibPajak, MemilikiNpwp, BasicRate, Allowance, Incentives, MealRate, Transport, JaminanKesehatan, Bpjs, JaminanKecelakaanKerja, JaminanKematian, JaminanHariTua, IuranPensiun, BiayaJabatan, Rapel, Loan, SalaryType, Amount1, As1, Amount2, As2 From db_payrolldata"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtname.Properties.Items.Add(tbl_par.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub txtname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtname.SelectedItem Is tbl_par.Rows(index).Item(0).ToString Then
                txtcode.Text = tbl_par.Rows(index).Item(1).ToString
                txtwp.Text = tbl_par.Rows(index).Item(2).ToString
                txtnpwp.Text = tbl_par.Rows(index).Item(3).ToString
                txtsalary.Text = tbl_par.Rows(index).Item(4).ToString
                txtallowance.Text = tbl_par.Rows(index).Item(5).ToString
                txtincentives.Text = tbl_par.Rows(index).Item(6).ToString
                txtmeal.Text = tbl_par.Rows(index).Item(7).ToString
                txttransport.Text = tbl_par.Rows(index).Item(8).ToString
                cjk.Checked = CBool(tbl_par.Rows(index).Item(9))
                cbpjs.Checked = CBool(tbl_par.Rows(index).Item(10).ToString)
                cjkk.Checked = CBool(tbl_par.Rows(index).Item(11).ToString())
                cjamkem.Checked = CBool(tbl_par.Rows(index).Item(12))
                cjht.Checked = CBool(tbl_par.Rows(index).Item(13))
                ciupe.Checked = CBool(tbl_par.Rows(index).Item(14))
                cbj.Checked = CBool(tbl_par.Rows(index).Item(15))
                crapel.Checked = CBool(tbl_par.Rows(index).Item(16))
                cloan.Checked = CBool(tbl_par.Rows(index).Item(17))
                txttype.Text = tbl_par.Rows(index).Item(18).ToString
                txtamount1.Text = tbl_par.Rows(index).Item(19).ToString
                txtas1.Text = tbl_par.Rows(index).Item(20).ToString
                txtamount2.Text = tbl_par.Rows(index).Item(21).ToString
                txtas2.Text = tbl_par.Rows(index).Item(22).ToString
            End If
        Next
    End Sub

    Private Sub Calculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub
End Class