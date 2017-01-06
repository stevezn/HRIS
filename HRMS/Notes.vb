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
        sqlCommand.CommandText = "SELECT EmployeeCode, FullName, Position, CompanyCode, PlaceOfBirth, DateOfBirth, Gender, Religion, Address, Email, IdNumber, OfficeLocation, WorkDate, PhoneNumber, Photo, Status, TrainingSampai FROM db_pegawai WHERE Status!='Fired'"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Dim tbl_par2 As New DataTable

    Sub loadrotasi()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT FullName, Rotasi, RotasiDate from db_rotasi"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
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
        sqlcommand.CommandText = "Select FullName, Demosi, DemosiDate from db_demosi"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par3)
        For index As Integer = 0 To tbl_par3.Rows.Count - 1
            txtnames.Properties.Items.Add(tbl_par3.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadD()
        loadrotasi()
        loaddemosi()
    End Sub

    Private Sub LabelControl10_Click(sender As Object, e As EventArgs) Handles LabelControl10.Click

    End Sub

    Private Sub LabelControl8_Click(sender As Object, e As EventArgs) Handles LabelControl8.Click

    End Sub

    Private Sub txtnames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtnames.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtnames.SelectedItem = tbl_par.Rows(indexing).Item(1).ToString() Then
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
        For indexing As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtnames.SelectedItem = tbl_par2.Rows(indexing).Item(0).ToString Then
                lcrotasi.Text = tbl_par2.Rows(indexing).Item(1).ToString()
                lcrotasidate.Text = tbl_par2.Rows(indexing).Item(2).ToString()
            End If
        Next
        For indexing As Integer = 0 To tbl_par3.Rows.Count - 1
            If txtnames.SelectedItem = tbl_par3.Rows(indexing).Item(0).ToString Then
                lcdemosi.Text = tbl_par3.Rows(indexing).Item(1).ToString()
                lcdemosidate.Text = tbl_par3.Rows(indexing).Item(2).ToString()
            End If
        Next
    End Sub

    Private Sub LabelControl47_Click(sender As Object, e As EventArgs) Handles LabelControl47.Click

    End Sub
End Class