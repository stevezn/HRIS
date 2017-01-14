Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu

Public Class Rapel
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable
    Dim tbl_par2 As New DataTable

    Sub loadDataKaryawan()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = "SELECT EmployeeCode, CompanyCode, FullName, PaymentDate, BasicRate, Allowance, Incentives, TableMoney, Transport, OtherAdditionalAllowance1, OtherAdditionalAllowance2, OtherAdditionalAllowance3, OtherAdditionalAllowance4, OtherAdditionalAllowance5, AdditionalAllowance1, AdditionalAllowance2, AdditionalAllowance3, AdditionalAllowance4, AdditionalAllowance5, OvertimeHours, OvertimeType, BpjsPercentage, Taxes, Loan, Lates, OtherAdditionalDeduction1, OtherAdditionalDeduction2, OtherAdditionalDeduction3, OtherAdditionalDeduction4, OtherAdditionalDeduction5, AdditionalDeduction1, AdditionalDeduction2, AdditionalDeduction3, AdditionalDeduction4, AdditionalDeduction5, ResJaminanKecelakaanKerja, ResPremiJaminanKematian, ResJaminanHariTua, ResBiayaJabatan, ResIuranPensiun, PersenKk, PersenJk, PersenJht PersenBj, PersenIp, MemilikiNpwp, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, PenghasilanKenaPajak, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, PphTerhutang, BiayaJabatan, IuranPensiun, NettoSetahun, StatusWajibPajak, RapelFromMonth, RapelToMonth, RapelRate, Rapel, PajakPphPerTahun FROm db_payroll"
        sqlCommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtfullname1.Properties.Items.Add(tbl_par.Rows(index).Item(2).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Sub loaddatapayroll()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT EmployeeCode, CompanyCode, FullName, PaymentDate, BasicRate, Allowance, Incentives, TableMoney, Transport, OtherAdditionalAllowance1, OtherAdditionalAllowance2, OtherAdditionalAllowance3, OtherAdditionalAllowance4, OtherAdditionalAllowance5, AdditionalAllowance1, AdditionalAllowance2, AdditionalAllowance3, AdditionalAllowance4, AdditionalAllowance5, OvertimeHours, OvertimeType, BpjsPercentage, Taxes, Loan, Lates, OtherAdditionalDeduction1, OtherAdditionalDeduction2, OtherAdditionalDeduction3, OtherAdditionalDeduction4, OtherAdditionalDeduction5, AdditionalDeduction1, AdditionalDeduction2, AdditionalDeduction3, AdditionalDeduction4, AdditionalDeduction5, ResJaminanKecelakaanKerja, ResPremiJaminanKematian, ResJaminanHariTua, ResBiayaJabatan, ResIuranPensiun, PersenKk, PersenJk, PersenJht PersenBj, PersenIp, MemilikiNpwp, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, PenghasilanKenaPajak, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, PphTerhutang, BiayaJabatan, IuranPensiun, NettoSetahun, StatusWajibPajak, RapelFromMonth, RapelToMonth, RapelRate, Rapel, PajakPphPerTahun FROm db_payroll"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par2)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtempcode.Properties.Items.Add(tbl_par2.Rows(index).Item(0).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub Rapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataReq()
        loadDataKaryawan()
        loaddatapayroll()
        loadrapel()
        loadloan()
    End Sub

    Private Sub loadDataReq()
        GridControl1.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If XtraTabPage1.Text = "Profile" Then
                sqlCommand.CommandText = "Select FullName, EmployeeCode FROM db_pegawai"
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

    Public Function InsertLoan() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim lastn As Integer
        Try
            Dim cmd = SQLConnection.CreateCommand
            cmd.CommandText = "SELEcT id FROM no_loan"
            lastn = DirectCast(cmd.ExecuteScalar(), Integer) + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim rescode As String = Strings.Right("00000" & lastn, 5)
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            str_carsql = "INSERT INTO db_loan " +
                "(No, JumlahPinjaman, PotonganPinjaman, FromMonth, ToMonth, Realisasi) " +
                "values (@No, @JumlahPinjaman, @PotonganPinjaman, @FromMonth, @ToMonth, @Realisasi)"
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@No", rescode)
            sqlcommand.Parameters.AddWithValue("@JumlahPinjaman", txtpinjaman.Text)
            sqlcommand.Parameters.AddWithValue("@PotonganPinjaman", txtpot.Text)
            sqlcommand.Parameters.AddWithValue("@FromMonth", txtfrom.Text)
            sqlcommand.Parameters.AddWithValue("@ToMonth", txtto.Text)
            sqlcommand.Parameters.AddWithValue("@Realisasi", txtrealisasi.Text)
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Added !")
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Insertrapel() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim ynow As String = Format(Now, "yy").ToString
        Dim mnow As String = Month(Now).ToString
        Dim lastn As Integer
        Try
            Dim cmd = SQLConnection.CreateCommand()
            cmd.CommandText = "SELECT id_no FROM no"
            lastn = DirectCast(cmd.ExecuteScalar(), Integer) + 1
        Catch ex As Exception
            MsgBox("error")
        End Try
        Dim rescode As String = Strings.Right("00000" & lastn, 5)
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_rapel " +
                   "(No, FullName, EmployeeCode, RapelRate, StartMonth, EndMonth, Rapel) " +
                   "values (@No, @FullName, @EmployeeCode, @RapelRate, @StartMonth, @EndMonth, @Rapel)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("No", rescode)
            sqlCommand.Parameters.AddWithValue("@FullName", txtfullname1.Text)
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", txtec.Text)
            sqlCommand.Parameters.AddWithValue("@RapelRate", txtrapelrate.Text)
            sqlCommand.Parameters.AddWithValue("@StartMonth", txtstart.Text)
            sqlCommand.Parameters.AddWithValue("@EndMonth", txtendmonth.Text)
            sqlCommand.Parameters.AddWithValue("@Rapel", txtrapel.Text)
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error Occured: Could Not Insert Records")
        End Try
    End Function

    Private Sub loadrapel()
        GridControl2.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            If XtraTabPage2.Text = "Rapel" Then
                sqlcommand.CommandText = "SELECT No, FullName, EmployeeCode, RapelRate, StartMonth, EndMonth, Rapel FROM db_rapel"
            End If
            sqlcommand.Connection = SQLConnection
            Dim tbl_par2 As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl2.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadloan()
        GridControl3.RefreshDataSource()
        Dim table As New DataTable
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            If XtraTabPage3.Text = "Loan" Then
                sqlcommand.CommandText = "SELECT No, JumlahPinjaman, PotonganPinjaman, FromMonth, ToMonth, Realisasi from db_loan"
            End If
            sqlcommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            GridControl3.DataSource = table
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim act As String = ""

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

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)

    End Sub

    Private Sub txtempcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempcode.SelectedIndexChanged
        For index As Integer = 0 To tbl_par2.Rows.Count - 1
            If txtempcode.SelectedItem Is tbl_par2.Rows(index).Item(2).ToString() Then
                txtbasicrate.Text = tbl_par2.Rows(index).Item(4).ToString
                txtallowance.Text = tbl_par2.Rows(index).Item(5).ToString
                txtincentive.Text = tbl_par2.Rows(index).Item(6).ToString
                txtmeal.Text = tbl_par2.Rows(index).Item(7).ToString
                txttransport.Text = tbl_par2.Rows(index).Item(8).ToString
                txtwp.Text = tbl_par2.Rows(index).Item(59).ToString
                txtnpwp.Text = tbl_par2.Rows(index).Item(45).ToString
            End If
        Next
    End Sub

    Private Sub txtfullname1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtfullname1.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtfullname1.SelectedItem Is tbl_par.Rows(index).Item(2).ToString Then
                txtec.Text = tbl_par.Rows(index).Item(0).ToString
            End If
        Next
    End Sub

    Private Sub GridView1_FocusedRowChanged_1(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim datatabl As New DataTable
        Dim sqlCommand As New MySqlCommand
        datatabl.Clear()
        If XtraTabPage1.Text = "Profile" Then
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
                sqlCommand.CommandText = "SELECT * FROM db_pegawai WHERE 1 = 1 " + param.ToString()
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
                txtempcode.Text = datatabl.Rows(0).Item(0).ToString()
                txtcompcode.Text = datatabl.Rows(0).Item(1).ToString()
                txtfullname.Text = datatabl.Rows(0).Item(2).ToString
                txtpos.Text = datatabl.Rows(0).Item(3).ToString
                txtid.Text = datatabl.Rows(0).Item(10).ToString
                txtaddress.Text = datatabl.Rows(0).Item(9).ToString
                txtphone.Text = datatabl.Rows(0).Item(13).ToString
                txtstatus.Text = datatabl.Rows(0).Item(15).ToString
                Dim filefoto As Byte() = CType(datatabl.Rows(0).Item(14), Byte())
                If filefoto.Length > 0 Then
                    PictureEdit1.Image = ByteToImage(filefoto)
                Else
                    PictureEdit1.Image = Nothing
                    PictureEdit1.Refresh()
                End If
            End If
        ElseIf XtraTabPage2.Text = "Rapel" Then
            Dim param As String = ""
            Try
                param = " and EmployeeCode = '" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString + "'"
            Catch ex As Exception
            End Try
            If param > "" Then
                act = "edit"
            Else
                act = "input"
            End If
            Try
                sqlCommand.CommandText = "SELECT * FROM db_payroll WHERE 1 = 1" + param.ToString
                sqlCommand.Connection = SQLConnection
                Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
                Dim cb As New MySqlCommandBuilder(adapter)
                adapter.Fill(datatabl)
                SQLConnection.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        hitungrapel()
        Insertrapel()
    End Sub
    Dim value, value2 As Long

    Private Sub hitungrapel()
        Dim a, totalvalue, res As Double
        a = Convert.ToDouble(txtrapelrate.Text)
        totalvalue = value2 - value
        res = a * totalvalue - a
        txtrapel.Text = res.ToString
        txtrapel.Text = Format(res, "##,##0")
        txtrapel.SelectionStart = Len(txtrapel.Text)
    End Sub


    Private Sub txtstart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtstart.SelectedIndexChanged
        If txtstart.Text = "January" Then
            value = 0
        ElseIf txtstart.Text = "February" Then
            value = 1
        ElseIf txtstart.Text = "March" Then
            value = 2
        ElseIf txtstart.Text = "April" Then
            value = 3
        ElseIf txtstart.Text = "May" Then
            value = 4
        ElseIf txtstart.Text = "June" Then
            value = 5
        ElseIf txtstart.Text = "July" Then
            value = 6
        ElseIf txtstart.Text = "August" Then
            value = 7
        ElseIf txtstart.Text = "September" Then
            value = 8
        ElseIf txtstart.Text = "October" Then
            value = 9
        ElseIf txtstart.Text = "November" Then
            value = 10
        Else
            value = 11
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        InsertLoan()
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            ' Delete existing menu items, if any.
            e.Menu.Items.Clear()
            Dim item As DXMenuItem = CreateMergingEnabledMenuItem(view, rowHandle)
            item.BeginGroup = True
            e.Menu.Items.Add(item)
        End If
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            ' Delete existing menu items, if any.
            e.Menu.Items.Clear()
            Dim item As DXMenuItem = CreateMergingEnabledMenuItem(view, rowHandle)
            item.BeginGroup = True
            e.Menu.Items.Add(item)
        End If
    End Sub

    Private Sub txtendmonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtendmonth.SelectedIndexChanged
        If txtendmonth.Text = "January" Then
            value2 = 1
        ElseIf txtendmonth.Text = "February" Then
            value2 = 2
        ElseIf txtendmonth.Text = "March" Then
            value2 = 3
        ElseIf txtendmonth.Text = "April" Then
            value2 = 4
        ElseIf txtendmonth.Text = "May" Then
            value2 = 5
        ElseIf txtendmonth.Text = "June" Then
            value2 = 6
        ElseIf txtendmonth.Text = "July" Then
            value2 = 7
        ElseIf txtendmonth.Text = "August" Then
            value2 = 8
        ElseIf txtendmonth.Text = "September" Then
            value2 = 9
        ElseIf txtendmonth.Text = "October" Then
            value2 = 10
        ElseIf txtendmonth.Text = "November" Then
            value2 = 11
        Else
            value2 = 12
        End If
    End Sub
End Class