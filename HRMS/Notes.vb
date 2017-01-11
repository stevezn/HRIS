Public Class Notes

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Dim tbl_par As New DataTable
    Sub loadD()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = "SELECT EmployeeCode, FullName, Position, CompanyCode, PlaceOfBirth, DateOfBirth, Gender, Religion, Address, Email, IdNumber, OfficeLocation, WorkDate, PhoneNumber, Photo, Status, TrainingSampai FROM db_pegawai WHERE Status != 'Fired'"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par4 As New DataTable

    Sub loadsp()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT EmployeeCode, CompanyCode, FullName, Sp1, Sp1Date, Sp2, Sp2Date, Sp3, Sp3Date FROM db_sp"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par4)
        For index As Integer = 0 To tbl_par4.Rows.Count - 1
            txtemp.Properties.Items.Add(tbl_par4.Rows(index).Item(2).ToString)
        Next
    End Sub

    Dim tbl_par2 As New DataTable

    Sub loadrotasi()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, Rotasi, RotasiDate, EmployeeCode FROM db_rotasi"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            txtnamakaryawan.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par3 As New DataTable

    Function ImageToByte(ByVal pbImg As PictureBox) As Byte()
        If pbImg Is Nothing Then
            Return Nothing
        End If
        Dim ms As New IO.MemoryStream()
        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function ByteToImage(ByVal filefoto As Byte()) As Image
        Dim pictureBytes As New IO.MemoryStream(filefoto)
        Return Image.FromStream(pictureBytes)
    End Function

    Sub loaddemosi()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "Select FullName, Demosi, DemosiDate, EmployeeCode FROM db_demosi"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par3)
        For index As Integer = 0 To tbl_par3.Rows.Count - 1
            txtdemosinames.Properties.Items.Add(tbl_par3.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadD()
        loadrotasi()
        loaddemosi()
        loadsp()
    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnames_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelControl47_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupControl1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtnamakaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtnamakaryawan.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtnamakaryawan.SelectedItem Is tbl_par2.Rows(indexing).Item(0).ToString Then
                lcrotasis.Text = tbl_par2.Rows(indexing).Item(1).ToString()
                lcrotasidates.Text = tbl_par2.Rows(indexing).Item(2).ToString()
                lcrotasiec.Text = tbl_par2.Rows(indexing).Item(3).ToString()
            End If
        Next
    End Sub

    Private Sub txtnames_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtnames.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtnames.SelectedItem Is tbl_par.Rows(indexing).Item(1).ToString() Then
                lcempcode.Text = tbl_par.Rows(indexing).Item(0).ToString()
                lcpos.Text = tbl_par.Rows(indexing).Item(2).ToString()
                lccompcode.Text = tbl_par.Rows(indexing).Item(3).ToString
                lcpob.Text = tbl_par.Rows(indexing).Item(4).ToString
                lcdob.Text = tbl_par.Rows(indexing).Item(5).ToString
                lcgender.Text = tbl_par.Rows(indexing).Item(6).ToString
                lcreligion.Text = tbl_par.Rows(indexing).Item(7).ToString
                lcaddress.Text = tbl_par.Rows(indexing).Item(8).ToString
                lcemail.Text = tbl_par.Rows(indexing).Item(9).ToString
                lcid.Text = tbl_par.Rows(indexing).Item(10).ToString
                lcol.Text = tbl_par.Rows(indexing).Item(11).ToString
                lcwd.Text = tbl_par.Rows(indexing).Item(12).ToString
                lcphone.Text = tbl_par.Rows(indexing).Item(13).ToString
                lcstat.Text = tbl_par.Rows(indexing).Item(15).ToString
                lctrain.Text = tbl_par.Rows(indexing).Item(16).ToString
                Dim filefoto As Byte() = CType(tbl_par.Rows(indexing).Item(14), Byte())
                If filefoto.Length > 0 Then
                    PictureEdit1.Image = ByteToImage(filefoto)
                Else
                    PictureEdit1.Image = Nothing
                    PictureEdit1.Refresh()
                End If
            End If
        Next
    End Sub

    Private Sub txtdemosinames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtdemosinames.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par3.Rows.Count - 1
            If txtdemosinames.SelectedItem Is tbl_par3.Rows(indexing).Item(0).ToString Then
                txtdemosi.Text = tbl_par3.Rows(indexing).Item(1).ToString()
                txtdemosidates.Text = tbl_par3.Rows(indexing).Item(2).ToString()
                lcdemosiec.Text = tbl_par3.Rows(indexing).Item(3).ToString()
            End If
        Next
    End Sub

    Private Sub txtdemosidates_Click(sender As Object, e As EventArgs) Handles txtdemosidates.Click

    End Sub

    Private Sub XtraTabPage2_Paint(sender As Object, e As PaintEventArgs) Handles XtraTabPage2.Paint

    End Sub

    Private Sub txtemp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtemp.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par4.Rows.Count - 1
            If txtemp.SelectedItem Is tbl_par4.Rows(indexing).Item(2).ToString Then
                lccode.Text = tbl_par4.Rows(indexing).Item(0).ToString
                lccocode.Text = tbl_par4.Rows(indexing).Item(1).ToString
                lcsp1.Text = tbl_par4.Rows(indexing).Item(3).ToString
                lcsp1date.Text = tbl_par4.Rows(indexing).Item(4).ToString
                lcsp2.Text = tbl_par4.Rows(indexing).Item(5).ToString
                lcsp2date.Text = tbl_par4.Rows(indexing).Item(6).ToString()
                lcsp3.Text = tbl_par4.Rows(indexing).Item(7).ToString()
                lcsp3date.Text = tbl_par4.Rows(indexing).Item(8).ToString()
            End If
        Next
    End Sub
End Class