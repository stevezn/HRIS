Imports System.IO

Public Class NewRec
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()


    Sub reset()
        lcreason.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfullname.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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

    Public Sub updatechange()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_recruitment SET" +
                                     " IdRec = @IdRec" +
                                     ", InterviewTimes = @InterviewTimes" +
                                     ", FullName = @FullName" +
                                     ", PlaceOfBirth = @PlaceOfBirth" +
                                     ", DateOfBirth = @DateOfBirth" +
                                     ", Address = @Address" +
                                     ", Gender  = @Gender" +
                                     ", Religion = @Religion" +
                                     ", PhoneNumber = @PhoneNumber" +
                                     ", IdNumber = @IdNumber" +
                                     ", Photo = @Photo" +
                                     ", Status = @Status" +
                                     ", InterviewDate = @InterviewDate" +
                                     ", Cv = @Cv" +
                                     ", Reason = @Reason " +
                                     " WHERE No = @No"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@No", txtno.Text)
            sqlcommand.Parameters.AddWithValue("@IdRec", txtid.Text)
            sqlcommand.Parameters.AddWithValue("@InterviewTimes", txtinterview.Text)
            sqlcommand.Parameters.AddWithValue("@FullName", txtfullname.Text)
            sqlcommand.Parameters.AddWithValue("@PlaceOfBirth", txtpob.Text)
            sqlcommand.Parameters.AddWithValue("@DateOfBirth", txtdob.Text)
            sqlcommand.Parameters.AddWithValue("@Address", txtaddress.Text)
            sqlcommand.Parameters.AddWithValue("@Gender", txtgender.Text)
            sqlcommand.Parameters.AddWithValue("@Religion", txtreligion.Text)
            sqlcommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
            sqlcommand.Parameters.AddWithValue("@IdNumber", txtidcard.Text)
            If Not txtbrowse.Text Is Nothing Then
                Dim param As New MySqlParameter("@Photo", ImageToByte(pictureEdit))
                sqlcommand.Parameters.Add(param)
            Else
                sqlcommand.Parameters.AddWithValue("@Photo", "")
            End If
            sqlcommand.Parameters.AddWithValue("@Status", txtstatus.Text)
            sqlcommand.Parameters.AddWithValue("@InterviewDate", txtinterviewdate.Text)
            sqlcommand.Parameters.AddWithValue("@Cv", txtcv.Text)
            sqlcommand.Parameters.AddWithValue("@Reason", txtreason.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Changed!")
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox("Error Occured: Could Not Change Records")
        End Try
    End Sub

    Sub cleartxt()
        txtid.Text = ""
        txtinterview.Text = ""
        txtnames.Text = ""
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

    Dim main As MainApp

    Public Function InsertReq() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim ynow As String = Format(Now, "yy").ToString
        Dim mnow As String = Month(Now).ToString
        Dim lastn As Integer
        'Dim n As String = ""
        'Dim interview As Integer = 0
        'Try
        '    Dim cmd = SQLConnection.CreateCommand
        '    cmd.CommandText = " SELECT IdNumber, COUNT(*) FROM db_recruitment Group by IdNumber HAVING ( COUNT(IdNumber) > 1 )"
        '    n = DirectCast(cmd.ExecuteScalar(), String)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'If n > 1 Then
        '    interview = +1
        'End If
        Try
            Dim cmd = SQLConnection.CreateCommand()
            cmd.CommandText = "SELECT IdRec FROM id_last_num"
            lastn = DirectCast(cmd.ExecuteScalar(), Integer) + 1
        Catch ex As Exception
            MsgBox("error")
        End Try
        Dim rescode As String = "REQ" & "-" & ynow & "-" & mnow & "-" & Strings.Right("00000" & lastn, 5)
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_recruitment " +
                   "(IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, Status, InterviewDate, Cv, Reason) " +
                   "values (@IdRec,@InterviewTimes,@FullName,@PlaceOfBirth,@DateOfBirth,@Address,@Gender,@Religion, @PhoneNumber, @IdNumber,@Photo,@Status,@InterviewDate,@Cv,@Reason)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@IdRec", rescode)
            sqlCommand.Parameters.AddWithValue("@InterviewTimes", txtinterview.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", txtnames.Text)
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
            sqlCommand.Parameters.AddWithValue("@Reason", "")
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
        sqlCommand.CommandText = "SELECT No, IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, Status, InterviewDate, Cv, Reason FROM db_recruitment"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtfullname.Properties.Items.Add(tbl_par.Rows(index).Item(3).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub NewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataKaryawan()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        cleartxt()
        reset()
        barJudul.Caption = "Add Recruitment"
        lcName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcpob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcdob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbrowse.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcgender.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcreligion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcidcard.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcaddress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcphone.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcstats.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbtnsave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbtnreset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        RibbonPageGroup2.Visible = False
    End Sub

    Private Sub NewEmployee_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        'Location = New Point(500, 200)
    End Sub


    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub LayoutControl1_Click(sender As Object, e As EventArgs) Handles LayoutControl1.Click

    End Sub

    Private Sub txtstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtstatus.SelectedIndexChanged

    End Sub

    Private Sub txtreligion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtreligion.SelectedIndexChanged

    End Sub

    Private Sub txtgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtgender.SelectedIndexChanged

    End Sub

    Private Sub txtdob_EditValueChanged(sender As Object, e As EventArgs) Handles txtdob.EditValueChanged

    End Sub

    Private Sub txtbrowse_EditValueChanged(sender As Object, e As EventArgs) Handles txtbrowse.EditValueChanged

    End Sub

    Private Sub txtphone_EditValueChanged(sender As Object, e As EventArgs) Handles txtphone.EditValueChanged

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cleartxt()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If barJudul.Caption = "Add Recruitment" Then
            If txtnames.Text = "" Then
                MsgBox("Please Insert The Required Fields")
            Else
                InsertReq()
            End If
        ElseIf barJudul.Caption = "Change Data" Then
            updatechange()
        End If
    End Sub

    Private Sub txtaddress_EditValueChanged(sender As Object, e As EventArgs) Handles txtaddress.EditValueChanged

    End Sub

    Private Sub txtpob_EditValueChanged(sender As Object, e As EventArgs) Handles txtpob.EditValueChanged

    End Sub

    Private Sub txtidcard_EditValueChanged(sender As Object, e As EventArgs) Handles txtidcard.EditValueChanged

    End Sub

    Private Sub txtid_EditValueChanged(sender As Object, e As EventArgs) Handles txtid.EditValueChanged

    End Sub

    Private Sub txtnames_EditValueChanged(sender As Object, e As EventArgs) Handles txtnames.EditValueChanged

    End Sub

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            txtbrowse.Image = Image.FromFile(dialog.FileName)
            pictureEdit.Image = Image.FromFile(dialog.FileName)
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        cleartxt()
        barJudul.Caption = "Change Data"
        reset()
        lcfullname.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcid.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcpob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcdob.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbrowse.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcgender.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcreligion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcidcard.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcaddress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcphone.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcstats.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbtnsave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        btnSave.Text = "Change"
        lcbtnreset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcreason.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        RibbonPageGroup1.Visible = False
    End Sub

    Private Sub txtfullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtfullname.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtfullname.SelectedItem Is tbl_par.Rows(indexing).Item(3).ToString() Then
                txtno.Text = tbl_par.Rows(indexing).Item(0).ToString
                txtid.Text = tbl_par.Rows(indexing).Item(1).ToString()
                txtinterview.Text = tbl_par.Rows(indexing).Item(2).ToString()
                txtpob.Text = tbl_par.Rows(indexing).Item(4).ToString()
                txtdob.Text = tbl_par.Rows(indexing).Item(5).ToString()
                txtaddress.Text = tbl_par.Rows(indexing).Item(6).ToString()
                txtgender.Text = tbl_par.Rows(indexing).Item(7).ToString()
                txtreligion.Text = tbl_par.Rows(indexing).Item(8).ToString()
                txtphone.Text = tbl_par.Rows(indexing).Item(9).ToString()
                txtidcard.Text = tbl_par.Rows(indexing).Item(10).ToString()
                Dim filefoto As Byte() = CType(tbl_par.Rows(indexing).Item(11), Byte())
                If filefoto.Length > 0 Then
                    pictureEdit.Image = ByteToImage(filefoto)
                Else
                    pictureEdit.Image = Nothing
                    pictureEdit.Refresh()
                End If
                txtstatus.Text = tbl_par.Rows(indexing).Item(12).ToString
                txtinterviewdate.Text = tbl_par.Rows(indexing).Item(13).ToString
                txtcv.Text = tbl_par.Rows(indexing).Item(14).ToString
                txtreason.Text = tbl_par.Rows(indexing).Item(15).ToString
            End If
        Next
    End Sub

    Dim openfd As New OpenFileDialog

    Private Sub btnCV_Click(sender As Object, e As EventArgs) Handles btnCV.Click
        openfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        openfd.Title = "Open a CV File"
        openfd.Filter = "Word Files|*.docx|Text Files|*.txt"
        openfd.ShowDialog()
        txtcv.Text = openfd.FileName
    End Sub

    Private Sub RichTextBoxEx1_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class