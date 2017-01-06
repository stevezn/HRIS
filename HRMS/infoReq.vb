Imports System.IO

Public Class infoReq

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Dim tbl_par As New DataTable

    Sub loadD()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = "SELECT id_rec, InterviewKe, FullName, PlaceOfBirth, DateOfBirth, Gender, Religion, IdNumber, Photo, status, InterviewDate FROM db_recruitment"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtidrec.Properties.Items.Add(tbl_par.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub infoReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadD()
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

    Private Sub txtidrec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtidrec.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtidrec.SelectedItem = tbl_par.Rows(indexing).Item(0).ToString() Then
                lcNama.Text = tbl_par.Rows(indexing).Item(2).ToString()
                lctgl.Text = tbl_par.Rows(indexing).Item(10).ToString()
                lcinterviewke.Text = tbl_par.Rows(indexing).Item(1).ToString()
                lcpob.Text = tbl_par.Rows(indexing).Item(3).ToString()
                lcdob.Text = tbl_par.Rows(indexing).Item(4).ToString()
                lcgender.Text = tbl_par.Rows(indexing).Item(5).ToString()
                lcreligion.Text = tbl_par.Rows(indexing).Item(6).ToString()
                lcid.Text = tbl_par.Rows(indexing).Item(7).ToString()
                lcHasil.Text = tbl_par.Rows(indexing).Item(9).ToString()

                Dim filefoto As Byte() = CType(tbl_par.Rows(indexing).Item(8), Byte())
                If filefoto.Length > 0 Then
                    PictureEdit1.Image = ByteToImage(filefoto)
                Else
                    PictureEdit1.Image = Nothing
                    PictureEdit1.Refresh()
                End If
            End If
        Next
    End Sub

End Class