Imports MySql.Data.MySqlClient

Public Class RotasiMutasi
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub clear()
        lccurpos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfullnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcRotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbutton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Dim tbl_par As New DataTable

    Sub loadDataKaryawan()
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
            txtNamaKaryawan.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "Rotasi"
        GroupControl1.Text = "Rotasi"
        lccurpos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcfullnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcRotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcRotasi.Text = "Promote To"
        lcbutton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        loadDataKaryawan()
        loadData()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        barJudul.Caption = "Demosi"
        GroupControl1.Text = "Demosi"
        lccurpos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcfullnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcRotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcRotasi.Text = "Demote To"
        lcbutton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        loadDataKaryawan()
        loadData()
    End Sub

    Private Sub loadData()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable

        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If barJudul.Caption = "Rotasi" Then
                sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, FullName, Position, Rotasi FROM db_sp"
            ElseIf barJudul.Caption = "Demosi" Then
                sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, FullName, Position, Demosi FROM db_sp"
            End If
            sqlCommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            'If barJudul.Caption = "Module Payroll" Then
            '    'loadPajak(table)
            '    loadDataReq()
            'Else
            GridControl1.DataSource = table
            'End If
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RotasiMutasi_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub RotasiMutasi_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtnamakaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtnamakaryawan.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtnamakaryawan.SelectedItem = tbl_par.Rows(indexing).Item(1).ToString() Then
                txtEmpCode.Text = tbl_par.Rows(indexing).Item(0).ToString()
                txtPosition.Text = tbl_par.Rows(indexing).Item(2).ToString()
                txtCompcode.Text = tbl_par.Rows(indexing).Item(3).ToString()
            End If
        Next
    End Sub

    Dim act As String = ""

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim datatabl As New DataTable
        Dim sqlCommand As New MySqlCommand
        datatabl.Clear()
        If barJudul.Caption = "Rotasi" Then
            Dim param As String = ""
            Try
                param = "and EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
            End Try
            If param > "" Then
                act = "edit"
            Else
                act = "input"
            End If
            Try
                sqlCommand.CommandText = "SELECT * FROM db_sp WHERE 1 = 1 " + param.ToString()
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
                txtnamakaryawan.Text = datatabl.Rows(0).Item(0).ToString()
                txtEmpCode.Text = datatabl.Rows(0).Item(1).ToString()
                txtCompcode.Text = datatabl.Rows(0).Item(2).ToString()
                txtPosition.Text = datatabl.Rows(0).Item(3).ToString()
                txtChange.Text = datatabl.Rows(0).Item(4).ToString()
            End If
        ElseIf barJudul.Caption = "Demosi" Then
            Dim param As String = ""
            Try
                param = "and EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
            End Try
            If param > "" Then
                act = "edit"
            Else
                act = "input"
            End If
            Try
                sqlCommand.CommandText = "Select * FROM db_sp WHERE 1 = 1 " + param.ToString
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
                txtnamakaryawan.Text = datatabl.Rows(0).Item(0).ToString
                txtEmpCode.Text = datatabl.Rows(0).Item(1).ToString
                txtCompcode.Text = datatabl.Rows(0).Item(2).ToString
                txtPosition.Text = datatabl.Rows(0).Item(3).ToString
                txtChange.Text = datatabl.Rows(0).Item(4).ToString
            End If
        End If
    End Sub
End Class