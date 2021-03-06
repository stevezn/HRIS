﻿Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class DemosiHistory
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Private Sub loadData()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, FullName, Position, Demosi, DemosiDate FROM db_demotehistory"
            sqlCommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl1.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DemosiHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadData()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            ' Delete existing menu items, if any.
            e.Menu.Items.Clear()
            ' Add a submenu with a single menu item.
            ' e.Menu.Items.Add(CreateRowSubMenu(view, rowHandle))
            ' Add a check menu item.           
            Dim item As DXMenuItem = CreateMergingEnabledMenuItem(view, rowHandle)
            item.BeginGroup = True
            e.Menu.Items.Add(item)
        End If
    End Sub
End Class