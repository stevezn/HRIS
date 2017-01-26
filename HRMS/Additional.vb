﻿Imports DevExpress.XtraBars.Docking

Public Class Additional
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Sub loaddata()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT EmployeeCode, FullName From db_payrolldata"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtempcode.Properties.Items.Add(tbl_par.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Public Sub updatechange()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim dtb, dtr As DateTime
        txtdate1.Format = DateTimePickerFormat.Custom
        txtdate1.CustomFormat = "yyyy-MM-dd"
        dtb = txtdate1.Value
        txtdate2.Format = DateTimePickerFormat.Custom
        txtdate2.CustomFormat = "yyyy-MM-dd"
        dtr = txtdate2.Value
        txtdate2.CustomFormat = "yyyy-MM-dd"
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_payrolldata SET" +
                    " EmployeeCode = @EmployeeCode" +
                    ", SalaryPeriod = @SalaryPeriod" +
                    ", Sampai = @Sampai" +
                    ", Amount1 = @Amount1" +
                    ", Amount2 = @Amount2" +
                    ", As1 = @As1" +
                    ", As2 = @As2" +
                    " WHERE EmployeeCode = @EmployeeCode"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtempcode.Text)
            sqlcommand.Parameters.AddWithValue("@SalaryPeriod", dtb.ToString("yyyy-MM-dd"))
            sqlcommand.Parameters.AddWithValue("@Sampai", dtr.ToString("yyyy-MM-dd"))
            sqlcommand.Parameters.AddWithValue("@Amount1", txtamount1.Text)
            sqlcommand.Parameters.AddWithValue("@Amount2", txtamount2.Text)
            sqlcommand.Parameters.AddWithValue("@As1", txtas1.Text)
            sqlcommand.Parameters.AddWithValue("@As2", txtas2.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Changed!")
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim form As Payments

    Private Sub Additional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        DateEdit1.Text = Format(Now, "MMMM-dd-yy").ToString
    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnapprove.Click
        updatechange()
    End Sub

    Private Sub txtempcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempcode.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtempcode.SelectedItem Is tbl_par.Rows(index).Item(0).ToString Then
            End If
        Next
    End Sub

    Private Sub txtdate1_EditValueChanged(sender As Object, e As EventArgs)
        'txtdate1.Text = Format("yyyy-dd-MM").ToString
    End Sub

    Private Sub txtdate2_EditValueChanged(sender As Object, e As EventArgs)
        'txtdate1.Text = Format("yyyy-dd-MM").ToString
    End Sub
End Class