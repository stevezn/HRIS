Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu

Public Class RecProcess

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database = db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Sub reset()
        lcreason.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfullname.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcidcard.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcaddress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcphone.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcstats.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Function ImageToByte(ByVal pbImg As PictureBox) As Byte()
        If pbImg Is Nothing Then
            Return Nothing
        End If
        Dim ms As New MemoryStream()
        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function ByteToImage(ByVal filefoto As Byte()) As Image
        Dim pictureBytes As New MemoryStream(filefoto)
        Return Image.FromStream(pictureBytes)
    End Function

    Sub cleartxt()
        txtid.Text = ""
        txtinterview.Text = ""
        txtaddress.Text = ""
        txtphone.Text = ""
        txtidcard.Text = ""
        txtstatus.Text = ""
        pictureEdit.Controls.Clear()
        txtinterviewdate.Text = ""
    End Sub

    Public Function InsertReq() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_recruit " +
                   "(IdRec, InterviewTimes, FullName,PhoneNumber, IdNumber, Status, InterviewDate, Reason) " +
                   "values (@IdRec,@InterviewTimes,@FullName,@PhoneNumber,@IdNumber,@Status,@InterviewDate,@Reason)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@IdRec", txtid.Text)
            sqlCommand.Parameters.AddWithValue("@InterviewTimes", txtinterview.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", txtfullname.Text)
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
            sqlCommand.Parameters.AddWithValue("@IdNumber", txtidcard.Text)
            sqlCommand.Parameters.AddWithValue("@Status", txtstatus.Text)
            sqlCommand.Parameters.AddWithValue("@InterviewDate", txtinterviewdate.Text)
            sqlCommand.Parameters.AddWithValue("@Reason", txtreason.Text)
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error Occured: Could Not Insert Records")
        End Try
    End Function

    Dim tbl_par As New DataTable

    Sub loadDataKaryawan()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = "SELECT IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, status, InterviewDate, Cv, Reason FROM db_recruitment where status = 'Pending'"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtfullname.Properties.Items.Add(tbl_par.Rows(index).Item(2).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub txtfullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtfullname.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtfullname.SelectedItem Is tbl_par.Rows(indexing).Item(2).ToString() Then
                txtid.Text = tbl_par.Rows(indexing).Item(0).ToString()
                txtinterview.Text = tbl_par.Rows(indexing).Item(1).ToString()
                txtaddress.Text = tbl_par.Rows(indexing).Item(5).ToString()
                txtphone.Text = tbl_par.Rows(indexing).Item(8).ToString()
                txtidcard.Text = tbl_par.Rows(indexing).Item(9).ToString()
                Dim filefoto As Byte() = CType(tbl_par.Rows(indexing).Item(10), Byte())
                If filefoto.Length > 0 Then
                    pictureEdit.Image = ByteToImage(filefoto)
                Else
                    pictureEdit.Image = Nothing
                    pictureEdit.Refresh()
                End If
                txtstatus.Text = tbl_par.Rows(indexing).Item(11).ToString
                txtinterviewdate.Text = tbl_par.Rows(indexing).Item(12).ToString
                txtreason.Text = tbl_par.Rows(indexing).Item(14).ToString
            End If
        Next
    End Sub

    Private Sub loadDataReq()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable

        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If barJudul.Caption = "Recruitment Process" Then
                sqlCommand.CommandText = "SELECT IdRec, InterviewTimes, FullName, PhoneNumber, IdNumber, Status, InterviewDate, Reason FROM db_recruitment where status = 'Pending'"
            End If
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

    Private Sub RecProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataKaryawan()
        BarButtonItem1.PerformClick()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "Recruitment Process"
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadDataReq()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)
        cleartxt()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) 
        cleartxt()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtfullname.Text = "" OrElse txtid.Text = "" Then
            MsgBox("Please insert an employee name or employee code")
        Else
            InsertReq()
        End If
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim item As DXMenuItem = CreateMergingEnabledMenuItem(view, rowHandle)
            item.BeginGroup = True
            e.Menu.Items.Add(item)
        End If
    End Sub

    Dim view As New pdfviewer

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If view Is Nothing OrElse view.IsDisposed Then
            view = New pdfviewer
        End If
        view.Show()
    End Sub

    Private Sub txtidcard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidcard.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) = True Then
            e.Handled = True
        End If
    End Sub
End Class