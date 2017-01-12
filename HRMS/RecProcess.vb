Imports System.IO
Imports DevExpress.XtraGrid

Public Class RecProcess

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()


    Sub reset()
        lcreason.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfullname.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcpob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcdob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcCv.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbtncv.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbrowse.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcgender.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcreligion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcidcard.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcaddress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcphone.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcstats.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbtnsave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbtnreset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
        txtpob.Text = ""
        txtdob.Text = ""
        txtaddress.Text = ""
        txtgender.Text = ""
        txtreligion.Text = ""
        txtphone.Text = ""
        txtidcard.Text = ""
        txtstatus.Text = ""
        pictureEdit.Controls.Clear()
        txtinterviewdate.Text = ""
        txtcv.Text = ""
    End Sub

    Public Function InsertReq() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_recruitment " +
                   "(IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, Status, InterviewDate, Cv, Reason) " +
                   "values (@IdRec,@InterviewTimes,@FullName,@PlaceOfBirth,@DateOfBirth,@Address,@Gender,@Religion, @PhoneNumber, @IdNumber,@Photo,@Status,@InterviewDate,@Cv,@Reason)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@IdRec", txtid.Text)
            sqlCommand.Parameters.AddWithValue("@InterviewTimes", txtinterview.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", txtfullname.Text)
            sqlCommand.Parameters.AddWithValue("@PlaceOfBirth", txtpob.Text)
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtdob.Text)
            sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text)
            sqlCommand.Parameters.AddWithValue("@Gender", txtgender.Text)
            sqlCommand.Parameters.AddWithValue("@Religion", txtreligion.Text)
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
            sqlCommand.Parameters.AddWithValue("@IdNumber", txtidcard.Text)
            If Not txtbrowse.Text Is Nothing Then
                Dim param As New MySqlParameter("@Photo", ImageToByte(pictureEdit))
                sqlCommand.Parameters.Add(param)
            Else
                sqlCommand.Parameters.AddWithValue("@Photo", "")
            End If
            sqlCommand.Parameters.AddWithValue("@Status", txtstatus.Text)
            sqlCommand.Parameters.AddWithValue("@InterviewDate", txtinterviewdate.Text)
            sqlCommand.Parameters.AddWithValue("@Cv", txtcv.Text)
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
        sqlCommand.CommandText = "SELECT IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, status, InterviewDate, Cv, Reason FROM db_recruitment"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtfullname.Properties.Items.Add(tbl_par.Rows(index).Item(2).ToString())
        Next
        SQLConnection.Close()
    End Sub
    Private Sub pictureEdit_Click(sender As Object, e As EventArgs) Handles pictureEdit.Click

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            txtbrowse.Image = Image.FromFile(dialog.FileName)
            pictureEdit.Image = Image.FromFile(dialog.FileName)
        End Using
    End Sub

    Private Sub txtfullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtfullname.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtfullname.SelectedItem Is tbl_par.Rows(indexing).Item(2).ToString() Then
                txtid.Text = tbl_par.Rows(indexing).Item(0).ToString()
                txtinterview.Text = tbl_par.Rows(indexing).Item(1).ToString()
                txtpob.Text = tbl_par.Rows(indexing).Item(3).ToString()
                txtdob.Text = tbl_par.Rows(indexing).Item(4).ToString()
                txtaddress.Text = tbl_par.Rows(indexing).Item(5).ToString()
                txtgender.Text = tbl_par.Rows(indexing).Item(6).ToString()
                txtreligion.Text = tbl_par.Rows(indexing).Item(7).ToString()
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
                txtcv.Text = tbl_par.Rows(indexing).Item(13).ToString
                txtreason.Text = tbl_par.Rows(indexing).Item(14).ToString
            End If
        Next
    End Sub

    'Private Sub loadDataReq()
    '    GridControl2.RefreshDataSource()
    '    Dim table As New DataTable

    '    SQLConnection = New MySqlConnection()
    '    SQLConnection.ConnectionString = connectionString
    '    SQLConnection.Open()
    '    Dim sqlCommand As New MySqlCommand
    '    Try
    '        If barJudul.Caption = "Recruitment Process" Then
    '            sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, FullName, Position, PlaceOfBirth, DateOfBirth, Gender, Religion, Address, Email, IdNumber, OfficeLocation, WorkDate, PhoneNumber, status, TrainingSampai FROM db_pegawai"
    '        End If
    '        sqlCommand.Connection = SQLConnection
    '        Dim tbl_par As New DataTable
    '        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
    '        Dim cb As New MySqlCommandBuilder(adapter)
    '        adapter.Fill(table)
    '        GridControl2.DataSource = table
    '        SQLConnection.Close()
    '    Catch ex As Exception
    '        SQLConnection.Close()
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub RecProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataKaryawan()
        'loadDataReq()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "Recruitment Process"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cleartxt()
    End Sub
End Class