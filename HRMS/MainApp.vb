Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu

Public Class MainApp
    'recruitment
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

#Region "koneksi "
    ''koneksi ke mysql

    Private Sub koneksi()
        Dim koneksi As MySqlConnection
        Dim str As String

        str = "Server=localhost; user id=root; password=; Database=db_hris"
        Try
            koneksi = New MySqlConnection(str)
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
                'MsgBox("Settings Connection Succesfully!")
                BarButtonItem1.PerformClick()
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

    Private Sub MainApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        act = "input"
        If barJudul.Caption = "Module Employee" Then
            GridView1.Focus()
            GridView1.MoveLast()
        End If
    End Sub

    Sub resetclear()
        txtposition.Text = ""
        txtBar1.Text = ""
        txtBar2.Text = ""
        txtBar3.Text = ""
        txtBar4.Text = ""
        txtBar5.Text = ""
        txtbar6.Text = ""
        txtbar7.Text = ""
        txtBar8.Text = ""
        txtBar9.Text = ""
        txtText.Text = ""
        txtstart.Text = ""
        txtfinish.Text = ""
        txtlocation.Text = ""
        txtphone.Text = ""
        txtadddc1.Text = ""
        txtadddc2.Text = ""
        txtadddc3.Text = ""
        txtadddc4.Text = ""
        txtadddc5.Text = ""
        compacode.Text = ""
        txt1add.Text = ""
        txt2add.Text = ""
        txt3add.Text = ""
        txt4add.Text = ""
        txt5add.Text = ""
        txtgross.Text = ""
        txtbpjs.Text = ""
        txtotsalary.Text = ""
        txtdeduction.Text = ""
        txtnetincome.Text = ""
        txtpkp.Text = ""
        txtTransport.Text = ""
        txtMeal.Text = ""
        txtothours.Text = ""
        txtaddress.Text = ""
        txtemail.Text = ""
        txtworkdate.Text = ""
        txtbpjspercentage.Text = ""
        txttaxes.Text = ""
        txtloan.Text = ""
        txtlates.Text = ""
        txtdeddc1.Text = ""
        txtdeddc2.Text = ""
        txtdeddc3.Text = ""
        txtdeddc4.Text = ""
        txtdeddc5.Text = ""
        txt1ded.Text = ""
        txt2ded.Text = ""
        txt3ded.Text = ""
        txt4ded.Text = ""
        txt5ded.Text = ""
        cmboxjkk.Text = ""
        cmboxjk.Text = ""
        cmboxnpwp.Text = ""
        cmboxjht.Text = ""
        txtottype.Text = ""
        rapel.Text = ""
        txtjkk.Text = ""
        txtjk.Text = ""
        txtjht.Text = ""
        lcnettosetahun.Text = ""
        txthasilbjabatan.Text = ""
        txthasiliuranpensiun.Text = ""
        pictureEdit.Controls.Clear()
        txtFoto.Text = ""
        txtTanggal.Text = ""
        txtStatEmp.Text = ""
        txtTglInterview.Text = ""
        'txtTrainingSampai.Text = ""
        pictureEdit.Refresh()
        txtGaji.Text = ""
        txtAllowance.Text = ""
        txtIncentives.Text = ""
        txtMeal.Text = ""
        txtStatWp.Text = ""
        txtpphterutang.Text = ""
        cmboxbj.Text = ""
        cmboxiuranpensiun.Text = ""
        'txtpkk.Text = ""
        'txtpjk.Text = ""
        'txtpjht.Text = ""
        'txtpbj.Text = ""
        'txtpip.Text = ""
        txtpajakpph.Text = ""
        txtrapel.Text = ""
        frommonth.Text = ""
        txtNamaKaryawan.Text = ""
        txtpayment.Text = ""
        tomonth.Text = ""
        txtworkdate.Text = ""
        txtJnsShift.Text = ""
        'pictureEdit.Controls.Remove()
    End Sub

    Sub reset()
        txtBar1.Text = ""
        txtBar2.Text = ""
        txtBar3.Text = ""
        txtBar4.Text = ""
        txtBar5.Text = ""
        txtbar6.Text = ""
        txtbar7.Text = ""
        txtBar8.Text = ""
        txtBar9.Text = ""
        txtText.Text = ""
        pictureEdit.Controls.Clear()
        txtFoto.Text = ""
        txtTanggal.Text = ""
        txtStatEmp.Text = ""
        txtTglInterview.Text = ""
        ';txtTrainingSampai.Text = ""
        txtworkdate.Text = ""
        txtposition.Text = ""
        txtstart.Text = ""
        txtfinish.Text = ""
        lcproc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcprogress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcchange.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbtnnew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcnumber.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcstart.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcsearch.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcrotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcnotes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcsp1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcpayment.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcrc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcpphtahun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcrapel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcfm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lctm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lchasilrapel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcworkdate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcaddress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcemail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcpphutang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lcpersenkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lcpersenjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lcpersenjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbiayajabatan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        ' lcbiayajabatan1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lciuranpensiun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtbiayajabatan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtiuranpensiun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lciuranpensiun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        netosetaun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcphone.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lclocation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbutton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcotc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcded.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcoad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcoda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbutton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcgross.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbpjs.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lctotalovertime.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcdeductions.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcnetincome.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcpkp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lcpajak.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        compcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lccode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcjkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcTglInt.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcStatEmp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcStatReq.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcFoto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'lcTrainSmp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcJnsShif.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcGaji.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        loadDataKaryawan()
        lcKaryawan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcTunjangan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBiayaJab.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcIuranPen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcStatWp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        overtimehours.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        overtimetype.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        bpjspercentage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lctaxes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcloan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lclates.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        jkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        pjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        jht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        npwp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        countButton.Enabled = False
        txtadddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

#Region "menu bar"
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        btnLihat.Enabled = True
        clearForm()
        reset()
        resetclear()
        lcprogress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcForm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnSimpan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnHapus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbtnnew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcchange.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        btnImport.Enabled = False
        barJudul.Caption = "Module Recruitment"
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadDataReq()
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        btnLihat.Enabled = False
        btnImport.Enabled = True
        'clearForm()
        reset()
        resetclear()
        lcrotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcsp1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcnotes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcForm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnSimpan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnHapus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcbtnnew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcchange.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcprogress.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        barJudul.Caption = "Module Employee"
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadDataReq()
        GridView1.Focus()
        GridView1.MoveLast()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        clearForm()
        resetclear()
        reset()
        lcproc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcbtnnew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcchange.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        barJudul.Caption = "Module Payroll"
        'GridControl1.DataSource = DBNull.Value
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        btnLihat.Enabled = False
        btnImport.Enabled = False
        'lcpersenkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpayment.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpersenjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpersenjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcbiayajabatan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcbiayajabatan1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lciuranpensiun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lciuranpensiun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtbiayajabatan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtiuranpensiun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpphtahun.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpphutang.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcrc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcrapel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcfm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lctm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lchasilrapel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ''lccode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ''lccode.Text = "Employee Code"        
        loadDataKaryawan()
        'lcKaryawan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lc2.Text = "Employee Code"
        'lcoad.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcded.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcotc.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcoda.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lctotalovertime.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcGaji.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ''lcTipePenggajian.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcStatWp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcTunjangan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcBiayaJab.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcIuranPen.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcgross.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcbpjs.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcdeductions.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcnetincome.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcpkp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ''lcpajak.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcjkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'countButton.Enabled = True
        ''lcTrainSmp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'overtimehours.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'overtimetype.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'bpjspercentage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lctaxes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lcloan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lclates.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'jkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'pjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'jht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'npwp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'Transport.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadd1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadd2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadd3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadd4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtadd5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtdeddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtdeddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtdeddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtdeddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtdeddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtded1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtded2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtded3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtded4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'txtded5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        btnLihat.Enabled = False
        btnImport.Enabled = False
        loadDataReq()
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        clearForm()
        reset()
        resetclear()
        lcForm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcForm.Text = "Attendance Form"
        lcBtnSimpan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcBtnHapus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcBtnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        barJudul.Caption = "Module Attendance"
        'GridControl1.DataSource = DBNull.Value
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        btnLihat.Enabled = False
        btnImport.Enabled = False
        lc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        loadDataKaryawan()
        lcKaryawan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lc2.Text = "Employee Code"
        lcTanggal.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcTanggal.Text = "Attendance Date"
        lcJnsShif.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcstart.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcstart.Text = "Sign In Time"
        lcfinish.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcfinish.Text = "Sign Out Time"
        'lc8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lc8.Text = "Overtime Hours"
        btnLihat.Enabled = False
        btnImport.Enabled = False
        loadDataReq()
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim pesan As String
        pesan = CType(MsgBox("Log Off Application?", MsgBoxStyle.YesNo, "Warning"), String)
        If CType(pesan, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            Close()
            setting.Close()
            rotasi.Close()
            employeenotes.Close()
        End If
        'Dim pesan As String
        'pesan = CType(MsgBox("Log Off Application?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning"), String)
        'If CType(pesan, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
        '    Close()
        '    'spform.Close()
        'End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'load data ke grid
        'GridControl1.DataSource = DBNull.Value
        GridControl1.RefreshDataSource()
        Dim table As New DataTable

        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If barJudul.Caption = "Module Recruitment" Then
                sqlCommand.CommandText = "Select IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Gender, Religion, IdNumber, Status FROM db_recruitment" +
                                         " WHERE InterviewTimes Like '%" + tePencarian.Text + "%' or " +
                                         " FullName like'%" + tePencarian.Text + "%' or " +
                                         " PlaceOfBirth like'%" + tePencarian.Text + "%' or " +
                                         " DateOfBirth like'%" + tePencarian.Text + "%' or " +
                                         " Gender like'%" + tePencarian.Text + "%' or " +
                                         " Religion like'%" + tePencarian.Text + "%' or " +
                                         " IdNumber like'%" + tePencarian.Text + "%' or " +
                                         " Status like'%" + tePencarian.Text + "%'"
            ElseIf barJudul.Caption = "Module Employee" Then
                Dim param As Double
                If tePencarian.Text = "" Then
                    param = 0
                End If
                sqlCommand.CommandText = "SELECT EmployeeCode, CompanyCode, FullName, PlaceOfBirth, DateOfBirth, Gender, Religion, IdNumber, Status, TrainingSampai, JenisPegawai, StatusWajibPajak from db_pegawai" +
                                         " WHERE CompanyCode like '%" + tePencarian.Text + "%' or " +
                                         " FullName like '%" + tePencarian.Text + "%' or " +
                                         " PlaceOfBirth like '%" + tePencarian.Text + "%' or " +
                                         " DateOfBirth like '%" + tePencarian.Text + "%' or " +
                                         " Gender like '%" + tePencarian.Text + "%' or " +
                                         " Religion like '%" + tePencarian.Text + "%' or " +
                                         " IdNumber like '%" + tePencarian.Text + "%' or " +
                                         " Status like '%" + tePencarian.Text + "%' or " +
                                         " TrainingSampai like '%" + tePencarian.Text + "%' or " +
                                         " JenisPegawai like '%" + tePencarian.Text + "%' or " +
                                         " BasicRate =" + param.ToString() + " or " +
                                         " Allowance =" + param.ToString() + " or " +
                                         " BiayaJabatan = " + param.ToString() + " or " +
                                         " iuran_pensiun = " + param.ToString() + " or " +
                                         " StatusWajibPajak like '%" + tePencarian.Text + "%'  "
            ElseIf barJudul.Caption = "Module Payroll" Then
                sqlCommand.CommandText = "SELECT EmployeeCode, FullName, BasicRate, Allowance, Incentives, MealRate, BiayaJabatan, JaminanKematian from db_payroll" +
                                            " WHERE EmployeeCode like '%" + tePencarian.Text + "%' or " +
                                            " FullName like '%" + tePencarian.Text + "%' or " +
                                            " BasicRate like '%" + tePencarian.Text + "%' or " +
                                            " Allowance like '%" + tePencarian.Text + "%' or " +
                                            " Incentives like '%" + tePencarian.Text + "%' or " +
                                            " MealRate like '%" + tePencarian.Text + "%' or " +
                                            " BiayaJabatan like '%" + tePencarian.Text + "%' or " +
                                            " IuranPensiun like '%" + tePencarian.Text + "%'    "
                Dim param As Double
                If tePencarian.Text = "" Then
                    param = 0
                End If
                sqlCommand.CommandText = "SELECT a.EmployeeCode, a.FullName , count(b.FullName) as jml_masuk, a.JenisPegawai, a.BasicRate, IF(a.JenisPegawai ='Full Time', a.BasicRate, (a.BasicRate * count(b.BasicRate))) as jml_gaji, b.tanggal, IF(sum(b.lama_lembur) > 0, ((1.5 *(1/173)) * a.BasicRate * sum(b.lama_lembur)), 0) as jml_lembur, a.Allowance, a.StatusWajibPajak, BiayaJabatan,Iuran_pensiun" +
                                             " from" +
                                             " db_pegawai a, db_absensi b" +
                                             " WHERE a.EmployeeCode = b.EmployeeCode " +
                                             " group by SUBSTRING(b.tanggal, 1,2), SUBSTRING(b.tanggal, 7,10)" +
                                             " having " +
                                             " a.EmployeeCode like'%" + tePencarian.Text + "%' or " +
                                             " a.FullName like'%" + tePencarian.Text + "%' or " +
                                             " count(b.EmployeeCode) =" + param.ToString() + " or " +
                                             " a.JenisPegawai like'%" + tePencarian.Text + "%' or " +
                                             " a.BasicRate like'%" + tePencarian.Text + "%' or " +
                                             " IF(a.JenisPegawai like 'Full Time', a.BasicRate, (a.BasicRate * count(b.EmployeeCode))) =" + param.ToString() + " or " +
                                             " IF(sum(b.lama_lembur) > 0, ((1.5 *(1/173)) * a.BasicRate * sum(b.lama_lembur)), 0) =" + param.ToString() + " or " +
                                             " b.tanggal like'%" + tePencarian.Text + "%'"
            ElseIf barJudul.Caption = "Module Attendance" Then
                sqlCommand.CommandText = "SELECT a.id_absensi, a.EmployeeCode, b.FullName, a.tanggal, a.shift, a.jam_mulai, a.jam_selesai from db_absensi a, db_pegawai b WHERE a.EmployeeCode=b.EmployeeCode"
            End If
            sqlCommand.Connection = SQLConnection
            Dim tbl_par As New DataTable
            Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
            Dim cb As New MySqlCommandBuilder(adapter)
            adapter.Fill(table)
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message)
        End Try
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

#End Region

#Region "button fungsional"
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        resetclear()
        act = "input"
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            txtFoto.Image = Image.FromFile(dialog.FileName)
            pictureEdit.Image = Image.FromFile(dialog.FileName)
        End Using
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        lcProgbar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        marqueBar.Visible = True
        If barJudul.Caption = "Module Recruitment" Then
            If txtBar3.Text = "" Then
                MsgBox("Please Insert ID Rec")
            Else
                InsertReq()
            End If
        ElseIf barJudul.Caption = "Module Employee" Then
            If lc8.Text = "" Then
                MsgBox("Please Insert ID Number")
            Else
                InsertEmp()
            End If
        ElseIf barJudul.Caption = "Module Payroll" Then
            If txtNamaKaryawan.Text = "" Or lc2.Text = "" Then
                MsgBox("Insert Employee Code and Name")
            Else
                InsertPayroll()
                loaddatapayroll()
            End If
        ElseIf barJudul.Caption = "Module Attendance" Then
            If txtNamaKaryawan.Text = "" Then
                MsgBox("Insert Employee Code and Name")
            Else
                InsertAtt()
            End If
        ElseIf barJudul.Caption = "Employee Menus" Then
            insertSP()
        End If
        loadDataReq()
        marqueBar.Visible = False
        lcProgbar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub btnSegarkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSegarkan.Click
        loadDataReq()
        GridView1.Focus()
        GridView1.MoveLast()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        lcProgbar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        marqueBar.Visible = True
        If barJudul.Caption = "Module Recruitment" Then
            DeleteReq()
        ElseIf barJudul.Caption = "Module Employee" Then
            DeleteEmp()
        ElseIf barJudul.Caption = "Module Payroll" Then
            DeletePay()
        ElseIf barJudul.Caption = "Module Attendance" Then
            DeleteAtt()
        End If
        loadDataReq()
        marqueBar.Visible = False
        lcProgbar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        importData()
        updatestats()
        GridView1.Focus()
        GridView1.MoveLast()
    End Sub

    Dim infoForm As New infoReq

    Public Sub btnLihat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLihat.Click
        If infoForm Is Nothing OrElse infoForm.IsDisposed Then
            infoForm = New infoReq
        End If
        infoForm.Show()
    End Sub


#End Region

#Region "CRUD database"
    'import to employee
    Dim table As DataTable


    Private Sub importData()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim maxid As Integer
        Dim newid As Integer = maxid + 1
        Dim ynow As String = Format(Now, "yy").ToString
        Dim mnow As String = Month(Now).ToString
        Dim lastn As Integer
        Try
            Dim cmd = SQLConnection.CreateCommand()
            cmd.CommandText = "SELECT last_num FROM view_emp_last_code"

            lastn = DirectCast(cmd.ExecuteScalar(), Integer) + 1
        Catch ex As Exception
            MsgBox("error")
        End Try
        Dim rescode As String = ynow & "-" & mnow & "-" & Strings.Right("0000" & lastn, 4)
        Dim sqlCommand As New MySqlCommand
        Try

            sqlCommand.CommandText = "INSERT INTO db_pegawai (FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, IdNumber, Photo, status, CompanyCode, EmployeeCode, OfficeLocation, PhoneNumber, TrainingSampai)" +
                                             "SELECT FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, IdNumber, Photo, @status, @CompanyCode, @EmployeeCode, @OfficeLocation, @PhoneNumber, @TrainingSampai FROM db_recruitment WHERE Status='Accepted'"
            sqlCommand.Parameters.AddWithValue("@Status", "Active")
            sqlCommand.Parameters.AddWithValue("@CompanyCode", "Fill This")
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", rescode)
            sqlCommand.Parameters.AddWithValue("@OfficeLocation", "Fill This")
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", employees.txtphone.Text)
            sqlCommand.Parameters.AddWithValue("@TrainingSampai", "No Trains")
            sqlCommand.Connection = SQLConnection
            sqlCommand.ExecuteNonQuery()
            SQLConnection.Close()
            MessageBox.Show("Import Data Succesfully!! Please Refresh The Data")
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox("There's Already an Exist Employee With The Same ID Number, Please Check Again.", MsgBoxStyle.Information)
        End Try
    End Sub

    'SELECT CONCAT(DATE_FORMAT(Now(),'%y-%m'),"-", LPAD((RIGHT(MAX(EmployeeCode),4)+1),4,'0')) FROM db_pegawai 

    Public Sub updatestats()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_recruitment SET" +
                                    " Status = @Status" +
                                    " WHERE Status = 'Accepted'"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@Status", "Processed")
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
        End Try
    End Sub

    Private Sub loaddatapayroll()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "INSERT INTO db_payrolldetails " +
                            "(EmployeeCode, PaymentDate, FullName, BasicRate, Allowance, Incentives, TableMoney, Transport, OtherAdditionalAllowance1, OtherAdditionalAllowance2, OtherAdditionalAllowance3, OtherAdditionalAllowance4, OtherAdditionalAllowance5, AdditionalAllowance1, AdditionalAllowance2, AdditionalAllowance3, AdditionalAllowance4, AdditionalAllowance5, OvertimeHours, OvertimeType, BpjsPercentage, Taxes, Loan, Lates, OtherAdditionalDeduction1, OtherAdditionalDeduction2, OtherAdditionalDeduction3, OtherAdditionalDeduction4, OtherAdditionalDeduction5, AdditionalDeduction1, AdditionalDeduction2, AdditionalDeduction3, AdditionalDeduction4, AdditionalDeduction5, ResJaminanKecelakaanKerja, ResPremiJaminanKematian, ResJaminanHariTua, ResBiayaJabatan, ResIuranPensiun, PersenKk, PersenJk, PersenJht, PersenBj, PersenIp, MemilikiNpwp, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, PenghasilanKenaPajak, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, PphTerhutang, BiayaJabatan, IuranPensiun, NettoSetahun, StatusWajibPajak, RapelFromMonth, RapelToMonth, RapelRate, Rapel, PajakPphPerTahun) " +
                            "values (@EmployeeCode, @PaymentDate, @FullName, @BasicRate, @Allowance, @Incentives, @TableMoney, @Transport, @OtherAdditionalAllowance1, @OtherAdditionalAllowance2, @OtherAdditionalAllowance3, @OtherAdditionalAllowance4, @OtherAdditionalAllowance5, @AdditionalAllowance1, @AdditionalAllowance2, @AdditionalAllowance3, @AdditionalAllowance4, @AdditionalAllowance5, @OvertimeHours, @OvertimeType, @BpjsPercentage, @Taxes, @Loan, @Lates, @OtherAdditionalDeduction1, @OtherAdditionalDeduction2, @OtherAdditionalDeduction3, @OtherAdditionalDeduction4, @OtherAdditionalDeduction5, @AdditionalDeduction1, @AdditionalDeduction2, @AdditionalDeduction3, @AdditionalDeduction4, @AdditionalDeduction5, @ResJaminanKecelakaanKerja, @ResPremiJaminanKematian, @ResJaminanHariTua, @ResBiayaJabatan, @ResIuranPensiun, @PersenKk, @PersenJk, @PersenJht, @PersenBj, @PersenIp, @MemilikiNpwp, @Gross, @Bpjs, @OvertimeSalary, @TotalDeductions, @NetIncome, @PenghasilanKenaPajak, @JaminanKecelakaanKerja, @PremiJaminanKematian, @JaminanHariTua, @PphTerhutang, @BiayaJabatan, @IuranPensiun, @NettoSetahun, @StatusWajibPajak, @RapelFromMonth, @RapelToMonth, @RapelRate, @Rapel, @PajakPphPerTahun)"
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtBar2.Text)
            sqlcommand.Parameters.AddWithValue("@PaymentDate", txtpayment.Text)
            sqlcommand.Parameters.AddWithValue("@FullName", txtNamaKaryawan.Text)
            sqlcommand.Parameters.AddWithValue("@BasicRate", txtGaji.Text)
            sqlcommand.Parameters.AddWithValue("@Allowance", txtAllowance.Text)
            sqlcommand.Parameters.AddWithValue("@Incentives", txtIncentives.Text)
            sqlcommand.Parameters.AddWithValue("@TableMoney", txtMeal.Text)
            sqlcommand.Parameters.AddWithValue("@Transport", txtTransport.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance1", txtadddc1.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance2", txtadddc2.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance3", txtadddc3.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance4", txtadddc4.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance5", txtadddc5.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance1", txt1add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance2", txt2add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance3", txt3add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance4", txt4add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance5", txt5add.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeHours", txtothours.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeType", txtottype.Text)
            sqlcommand.Parameters.AddWithValue("@BpjsPercentage", txtbpjspercentage.Text)
            sqlcommand.Parameters.AddWithValue("@Taxes", txttaxes.Text)
            sqlcommand.Parameters.AddWithValue("@Loan", txtloan.Text)
            sqlcommand.Parameters.AddWithValue("@Lates", txtlates.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction1", txtdeddc1.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction2", txtdeddc2.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction3", txtdeddc3.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction4", txtdeddc4.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction5", txtdeddc5.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction1", txt1ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction2", txt2ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction3", txt3ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction4", txt4ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction5", txt5ded.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanKecelakaanKerja", cmboxjkk.Text)
            sqlcommand.Parameters.AddWithValue("@ResPremiJaminanKematian", cmboxjk.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanHariTua", cmboxjht.Text)
            sqlcommand.Parameters.AddWithValue("@ResBiayajabatan", cmboxbj.Text)
            sqlcommand.Parameters.AddWithValue("@ResIuranPensiun", cmboxiuranpensiun.Text)
            sqlcommand.Parameters.AddWithValue("@MemilikiNpwp", cmboxnpwp.Text)
            sqlcommand.Parameters.AddWithValue("@Gross", txtgross.Text)
            sqlcommand.Parameters.AddWithValue("@Bpjs", txtbpjs.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeSalary", txtotsalary.Text)
            sqlcommand.Parameters.AddWithValue("@TotalDeductions", txtdeduction.Text)
            sqlcommand.Parameters.AddWithValue("@Netincome", txtnetincome.Text)
            sqlcommand.Parameters.AddWithValue("@PenghasilanKenaPajak", txtpkp.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", txtjkk.Text)
            sqlcommand.Parameters.AddWithValue("@PremiJaminanKematian", txtjk.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanHariTua", txtjht.Text)
            sqlcommand.Parameters.AddWithValue("@PphTerhutang", txtpphterutang.Text)
            sqlcommand.Parameters.AddWithValue("@BiayaJabatan", txthasilbjabatan.Text)
            sqlcommand.Parameters.AddWithValue("@IuranPensiun", txthasiliuranpensiun.Text)
            sqlcommand.Parameters.AddWithValue("@NettoSetahun", lcnettosetahun.Text)
            sqlcommand.Parameters.AddWithValue("@StatusWajibPajak", txtStatWp.Text)
            sqlcommand.Parameters.AddWithValue("@RapelFromMonth", frommonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelToMonth", tomonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelRate", txtrapel.Text)
            sqlcommand.Parameters.AddWithValue("@Rapel", rapel.Text)
            sqlcommand.Parameters.AddWithValue("@PajakPphPerTahun", txtpajakpph.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
        End Try
    End Sub

    ''load data modul

    Private Sub loadDataReq()
        'load data ke grid
        ' GridControl1.DataSource = DBNull.Value
        GridControl1.RefreshDataSource()
        Dim table As New DataTable

        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Try
            If barJudul.Caption = "Module Recruitment" Then
                sqlCommand.CommandText = "Select IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, InterviewDate, Status, Reason from db_recruitment"
            ElseIf barJudul.Caption = "Module Employee" Then
                sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, FullName, Position, PlaceOfBirth, DateOfBirth, Gender, Religion, Address, Email, IdNumber, OfficeLocation, WorkDate, PhoneNumber, Status, TrainingSampai FROM db_pegawai"
            ElseIf barJudul.Caption = "Module Payroll" Then
                sqlCommand.CommandText = "Select EmployeeCode, CompanyCode, PaymentDate, FullName, BasicRate, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, BiayaJabatan, IuranPensiun, PphTerhutang, PajakPphPerTahun, PenghasilanKenaPajak, NettoSetahun, StatusWajibPajak, Rapel FROM db_payroll"
                ' sqlCommand.CommandText = "Select a.EmployeeCode, a.FullName, count(b.EmployeeCode) As jml_masuk, a.jenis_pegawai, a.BasicRate, If(a.jenis_pegawai ='Full Time', a.BasicRate, (a.BasicRate * count(b.EmployeeCode))) as jml_gaji, b.tanggal, IF(sum(b.lama_lembur) > 0, ((1.5 *(1/173)) * a.BasicRate * sum(b.lama_lembur)), 0) as jml_lembur , a.Allowance, JaminanKecelakaanKerja, a.StatusWajibPajak, BiayaJabatan,Iuran_pensiun" +
                '                            " FROM" +
                '                           " db_pegawai a, db_absensi b" +
                '                          " WHERE a.EmployeeCode = b.EmployeeCode" +
                '                         " GROUP BY SUBSTRING(b.tanggal, 1,2), SUBSTRING(b.tanggal, 7,10)"
            ElseIf barJudul.Caption = "Module Attendance" Then
                sqlCommand.CommandText = "SELECT EmployeeCode, FullName, Tanggal, Shift, JamMulai, JamSelesai FROM db_absensi"
            ElseIf barJudul.Caption = "Module Payment Details" Then
                sqlCommand.CommandText = "SELECT EmployeeCode, PaymentDate, FullName, BasicRate, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, BiayaJabatan, IuranPensiun, PphTerhutang, PajakPphPerTahun, PenghasilanKenaPajak, NettoSetahun, StatusWajibPajak, Rapel FROM db_payrolldetails"
            ElseIf barJudul.Caption = "Employee Menus" Then
                sqlCommand.CommandText = "SELECT EmployeeCode, FullName, Position, SuratPeringatan1, SuratPeringatan2, SuratPeringatan3, Rotasi, Demosi FROM db_sp"
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

    '''hitung ptkp, pph21, tunjangan
'Sub loadPajak(ByVal tbl As DataTable)
    '    GridControl1.DataSource = DBNull.Value
    '    GridControl1.RefreshDataSource()
    '    Dim tbl_baru As New DataTable
    '    tbl_baru.Columns.Add("EmployeeCode")
    '    tbl_baru.Columns.Add("FullName")
    '    tbl_baru.Columns.Add("jml_masuk")
    '    tbl_baru.Columns.Add("jenis_pegawai")
    '    tbl_baru.Columns.Add("BasicRate")
    '    tbl_baru.Columns.Add("jml_gaji")
    '    tbl_baru.Columns.Add("tanggal")
    '    tbl_baru.Columns.Add("jml_lembur")
    '    tbl_baru.Columns.Add("tunjangan")
    '    tbl_baru.Columns.Add("pajak_pph21")
    '    tbl_baru.Columns.Add("bpjs")
    '    tbl_baru.Columns.Add("JaminanKecelakaanKerja")
    '    tbl_baru.Columns.Add("JaminanKematian")
    '    tbl_baru.Columns.Add("OvertimeSalary")
    '    tbl_baru.Columns.Add("Fixed Salary")
    '    Dim customCurrencyInfo As CultureInfo = CultureInfo.CreateSpecificCulture("id-ID")
    '    customCurrencyInfo.NumberFormat.CurrencyNegativePattern = 8
    '    For index As Integer = 0 To tbl.Rows.Count - 1
    '        'hitung bruto
    '        Dim gajipkok As Double = 12 * Convert.ToDouble(tbl.Rows(index).Item(4))
    '        Dim Allowance As Double = 12 * Convert.ToDouble(tbl.Rows(index).Item(8))
    '        Dim bruto As Double = gajipkok + Allowance
    '        'Dim gross As Double = Convert.ToDouble(txtGaji.Text) + Convert.ToDouble(txtAllowance.Text) + Convert.ToDouble(txtIncentives.Text) + Convert.ToDouble(txtMeal.Text) + Convert.ToDouble(txtTransport.Text) + Convert.ToDouble(txt1add.Text) + Convert.ToDouble(txt2add.Text) + Convert.ToDouble(txt3add.Text) + Convert.ToDouble(txt4add.Text) + Convert.ToDouble(txt5add.Text)

    '        'hitung ptkp
    '        Dim ptkp As Double = 0
    '        If tbl.Rows(index).Item(9).ToString() = "Tidak Kawin, Tanpa Tanggungan" Then
    '            ptkp = 54000000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Tidak Kawin, Tanggungan 1" Then
    '            ptkp = 58500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Tidak Kawin, Tanggungan 2" Then
    '            ptkp = 63000000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Tidak Kawin, Tanggungan 3" Then
    '            ptkp = 67500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Tanpa Tanggungan" Then
    '            ptkp = 58500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Tanggungan 1" Then
    '            ptkp = 63000000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Tanggungan 2" Then
    '            ptkp = 67500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Tanggungan 3" Then
    '            ptkp = 72000000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Penghasilan Istri Dan Suami Digabung" Then
    '            ptkp = 112500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Penghasilan Digabung Tanggungan 1" Then
    '            ptkp = 117000000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Penghasilan Digabung Tanggungan 2" Then
    '            ptkp = 121500000
    '        ElseIf tbl.Rows(index).Item(9).ToString() = "Kawin, Penghasilan Digabung Tanggungan 3" Then
    '            ptkp = 126000000
    '        End If
    '        'Dim gross As Double = Convert.ToDouble(tbl.Rows(index).Item(1))
    '        Dim biaya_jab As Double = Convert.ToDouble(tbl.Rows(index).Item(10))
    '        Dim iuran_pensiun As Double = Convert.ToDouble(tbl.Rows(index).Item(11))
    '        Dim total_ptkp As Double = ptkp + biaya_jab + iuran_pensiun
    '        'penghasilan kena pajak - netto
    '        Dim pkp_netto As Double = bruto - total_ptkp
    '        ''pph 21
    '        Dim pajak_pph As Double = (5 / 100) * pkp_netto

    '        ''nilai bpjs
    '        Dim bpjs As Double = gajipkok * 3 / 100
    '        ''gaji akhir
    '        Dim gaji_akhir = gajipkok + Allowance - pajak_pph - bpjs + Convert.ToDouble(tbl.Rows(index).Item(8))

    '        Dim jaminankk As Double = gajipkok * 0.24 / 100

    '        Dim jaminank As Double = gajipkok * 0.3 / 100

    '        Dim overtimesalary As Double
    '        Try
    '            If cmboxottype.Text = "Regular Day" Then
    '                Dim hours, pay, salary, temp, totot, tempo, value1, value2, pay2 As Double
    '                hours = Convert.ToDouble(txtothours.Text)
    '                salary = Convert.ToDouble(txtmonthlysalary.Text)
    '                pay = salary / 173
    '                pay2 = pay * 1.5
    '                If (hours = 1) Then
    '                    tempo = pay * 1.5
    '                    value1 = tempo
    '                    totot = value1
    '                ElseIf (hours > 1) Then
    '                    temp = pay * 2
    '                    tempo = temp * hours - pay * 2
    '                    value2 = tempo
    '                    totot = value2 + pay2
    '                End If
    '                txtotsalary.Text = totot.ToString()
    '                overtimesalary = CDbl(totot.ToString())

    '            ElseIf cmboxottype.Text = "Holiday / Sunday" Then
    '                Dim hours, pay, salary, temp, totot2, tempo, value1, value2, pay2, value3 As Double
    '                hours = Convert.ToDouble(txtothours.Text)
    '                salary = Convert.ToDouble(txtmonthlysalary.Text)
    '                pay = salary / 173
    '                pay2 = pay * 3
    '                If (hours > 0) And (hours < 8) Then
    '                    tempo = pay * hours * 2
    '                    value1 = tempo
    '                    totot2 = value1
    '                ElseIf (hours = 8) Then
    '                    temp = pay * 3
    '                    tempo = temp * hours - pay * 3
    '                    value2 = tempo
    '                    totot2 = value2 - pay2 - pay
    '                ElseIf (hours > 8) Then
    '                    temp = pay * 4
    '                    tempo = temp * hours - pay * 4
    '                    value3 = tempo
    '                    totot2 = value3 - value2 - value1
    '                End If
    '                txtotsalary.Text = totot2.ToString()
    '                overtimesalary = CDbl(totot2.ToString())
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        End Try

    '        tbl_baru.Rows.Add(tbl.Rows(index).Item(0),
    '                          tbl.Rows(index).Item(1),
    '                          tbl.Rows(index).Item(2),
    '                          tbl.Rows(index).Item(3),
    '                          Convert.ToDouble(tbl.Rows(index).Item(4)).ToString("C", customCurrencyInfo),
    '                          Convert.ToDouble(tbl.Rows(index).Item(5)).ToString("C", customCurrencyInfo),
    '                          tbl.Rows(index).Item(6),
    '                          Convert.ToDouble(tbl.Rows(index).Item(7)).ToString("C", customCurrencyInfo),
    '                          pajak_pph.ToString("C", customCurrencyInfo),
    '                          Allowance.ToString("C", customCurrencyInfo),
    '                          bpjs.ToString("C", customCurrencyInfo),
    '                          jaminankk.ToString("C", customCurrencyInfo),
    '                          jaminank.ToString("C", customCurrencyInfo),
    '                          overtimesalary.ToString("C", customCurrencyInfo),
    '                          gaji_akhir.ToString("C", customCurrencyInfo))
    '    Next
    '    GridControl1.DataSource = tbl_baru
    'End Sub

    ''insert

    Public Function InsertReq() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            If act = "edit" Then
                str_carSql = "UPDATE db_recruitment SET" +
                       " InterviewTimes = @InterviewTimes" +
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
                       " WHERE IdRec = @IdRec"
                sqlCommand.Connection = SQLConnection
                sqlCommand.CommandText = str_carSql
                sqlCommand.Parameters.AddWithValue("@IdRec", txtBar1.Text)
                sqlCommand.Parameters.AddWithValue("@InterviewTimes", txtBar2.Text)
                sqlCommand.Parameters.AddWithValue("@FullName", txtBar3.Text)
                sqlCommand.Parameters.AddWithValue("@PlaceOfBirth", txtBar4.Text)
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtTanggal.Text)
                sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text)
                sqlCommand.Parameters.AddWithValue("@Gender", txtbar6.Text)
                sqlCommand.Parameters.AddWithValue("@Religion", txtbar7.Text)
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
                sqlCommand.Parameters.AddWithValue("@IdNumber", txtBar8.Text)
                If Not txtFoto.Text Is Nothing Then 'Jika ada file yang akan disimpan
                    Dim param As New MySqlParameter("@Photo", ImageToByte(pictureEdit))
                    sqlCommand.Parameters.Add(param)
                Else
                    sqlCommand.Parameters.AddWithValue("@Photo", "")
                End If
                sqlCommand.Parameters.AddWithValue("@Status", txtText.Text)
                sqlCommand.Parameters.AddWithValue("@InterviewDate", txtTglInterview.Text)
            ElseIf act = "input" Then
                str_carSql = "INSERT INTO db_recruitment " +
                       "(IdRec, InterviewTimes, FullName, PlaceOfBirth, DateOfBirth, Address, Gender, Religion, PhoneNumber, IdNumber, Photo, Status, InterviewDate) " +
                       "values (@IdRec,@InterviewTimes,@FullName,@PlaceOfBirth,@DateOfBirth,@Address,@Gender,@Religion, @PhoneNumber, @IdNumber,@Photo,@Status,@InterviewDate)"
                sqlCommand.Connection = SQLConnection
                sqlCommand.CommandText = str_carSql
                sqlCommand.Parameters.AddWithValue("@IdRec", txtBar1.Text)
                sqlCommand.Parameters.AddWithValue("@InterviewTimes", txtBar2.Text)
                sqlCommand.Parameters.AddWithValue("@FullName", txtBar3.Text)
                sqlCommand.Parameters.AddWithValue("@PlaceOfBirth", txtBar4.Text)
                sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtTanggal.Text)
                sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text)
                sqlCommand.Parameters.AddWithValue("@Gender", txtbar6.Text)
                sqlCommand.Parameters.AddWithValue("@Religion", txtbar7.Text)
                sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
                sqlCommand.Parameters.AddWithValue("@IdNumber", txtBar8.Text)
                If Not txtFoto.Text Is Nothing Then 'Jika ada file yang akan disimpan
                    Dim param As New MySqlParameter("@Photo", ImageToByte(pictureEdit))
                    sqlCommand.Parameters.Add(param)
                Else
                    sqlCommand.Parameters.AddWithValue("@Photo", "")
                End If
                sqlCommand.Parameters.AddWithValue("@Status", txtText.Text)
                sqlCommand.Parameters.AddWithValue("@InterviewDate", txtTglInterview.Text)
            Else
                str_carSql = "DELETE FROM db_recruitment WHERE IdRec = @IdRec"
                sqlCommand.Connection = SQLConnection
                sqlCommand.CommandText = str_carSql
                sqlCommand.Parameters.AddWithValue("@IdRec", txtBar1.Text)
            End If
            sqlCommand.ExecuteNonQuery()
            If act = "input" Then
                MessageBox.Show("Data Succesfully Added!")
            ElseIf act = "edit" Then
                MessageBox.Show("Data Succesfully Changed!")
            End If
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error Occured: Could Not Insert Records")
        End Try
    End Function

    Private Function insertSP() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            If act = "edit" Then
                str_carsql = "UPDATE db_sp SET" +
                    " CompanyCode = @CompanyCode" +
                    ", FullName = @FullName" +
                    ", Position = @Position" +
                    ", SuratPeringatan1 = @SuratPeringatan1" +
                    ", SuratPeringatan2 = @SuratPeringatan2" +
                    ", SuratPeringatan3 = @SuratPeringatan3" +
                    ", Rotasi = @Rotasi" +
                    ", Demosi = @Demosi" +
                    " WHERE EmployeeCode = @EmployeeCode"
            ElseIf act = "input" Then
                str_carsql = "INSERT INTO db_sp " +
                            "(EmployeeCode, CompanyCode, FullName, Position, SuratPeringatan1, SuratPeringatan2, SuratPeringatan3, Rotasi, Demosi) " +
                            "values (@EmployeeCode, @CompanyCode, @FullName, @Position, @SuratPeringatan1, @SuratPeringatan2, @SuratPeringatan3, @Rotasi, @Demosi)"
            Else
                str_carsql = "DELETE FROM db_sp WHERE EmployeeCode = @EmployeeCode"
            End If
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtBar2.Text)
            sqlcommand.Parameters.AddWithValue("@CompanyCode", compacode.Text)
            sqlcommand.Parameters.AddWithValue("@FullName", txtNamaKaryawan.Text)
            sqlcommand.Parameters.AddWithValue("@Position", txtposition.Text)
            sqlcommand.Parameters.AddWithValue("@SuratPeringatan1", "sp1")
            sqlcommand.Parameters.AddWithValue("@SuratPeringatan2", "sp2")
            sqlcommand.Parameters.AddWithValue("@SuratPeringatan3", "sp3")
            sqlcommand.Parameters.AddWithValue("@Rotasi", "sp3")
            sqlcommand.Parameters.AddWithValue("@Demosi", "sp4")
            sqlcommand.ExecuteNonQuery()
            If act = "input" Then
                MessageBox.Show("Data Succesfully Added!")
            ElseIf act = "edit" Then
                MessageBox.Show("Data Succesfully Changed!")
            End If
            Return True

        Catch ex As Exception
            Return False
            MsgBox("Error Occured, Could Not Insert Records")
        End Try
    End Function

    Public Function InsertPayroll() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim str_carsql As String
        Try
            If act = "edit" Then
                str_carsql = "UPDATE db_payroll SET" +
                    " FullName = @FullName" +
                    ", PaymentDate = @PaymentDate" +
                    ", BasicRate = @BasicRate" +
                    ", Allowance = @Allowance" +
                    ", Incentives = @Incentives" +
                    ", TableMoney = @TableMoney" +
                    ", Transport = @Transport" +
                    ", OtherAdditionalAllowance1 = @OtherAdditionalAllowance1" +
                    ", OtherAdditionalAllowance2 = @OtherAdditionalAllowance2" +
                    ", OtherAdditionalAllowance3 = @OtherAdditionalAllowance3" +
                    ", OtherAdditionalAllowance4 = @OtherAdditionalAllowance4" +
                    ", OtherAdditionalAllowance5 = @OtherAdditionalAllowance5" +
                    ", AdditionalAllowance1 = @AdditionalAllowance1" +
                    ", AdditionalAllowance2 = @AdditionalAllowance2" +
                    ", AdditionalAllowance3 = @AdditionalAllowance3" +
                    ", AdditionalAllowance4 = @AdditionalAllowance4" +
                    ", AdditionalAllowance5 = @AdditionalAllowance5" +
                    ", OvertimeHours = @OvertimeHours" +
                    ", OvertimeType = @OvertimeType" +
                    ", BpjsPercentage = @BpjsPercentage" +
                    ", Taxes = @Taxes" +
                    ", Loan = @Loan" +
                    ", Lates = @Lates" +
                    ", OtherAdditionalDeduction1 = @OtherAdditionalDeduction1" +
                    ", OtherAdditionalDeduction2 = @OtherAdditionalDeduction2" +
                    ", OtherAdditionalDeduction3 = @OtherAdditionalDeduction3" +
                    ", OtherAdditionalDeduction4 = @OtherAdditionalDeduction4" +
                    ", OtherAdditionalDeduction5 = @OtherAdditionalDeduction5" +
                    ", AdditionalDeduction1 = @AdditionalDeduction1" +
                    ", AdditionalDeduction2 = @AdditionalDeduction2" +
                    ", AdditionalDeduction3 = @AdditionalDeduction3" +
                    ", AdditionalDeduction4 = @AdditionalDeduction4" +
                    ", AdditionalDeduction5 = @AdditionalDeduction5" +
                    ", ResJaminanKecelakaanKerja = @ResJaminanKecelakaanKerja" +
                    ", ResPremiJaminanKematian = @ResPremiJaminanKematian" +
                    ", ResJaminanHariTua = @ResJaminanHariTua" +
                    ", ResBiayaJabatan = @ResBiayaJabatan" +
                    ", ResIuranPensiun = @ResIuranPensiun" +
                    ", PersenKk = @PersenKk" +
                    ", PersenJk = @PersenJk" +
                    ", PersenJht = @PersenJht" +
                    ", PersenBj = @PersenBj" +
                    ", PersenIp = @PersenIp" +
                    ", MemilikiNpwp = @MemilikiNpwp" +
                    ", Gross = @Gross" +
                    ", Bpjs = @Bpjs" +
                    ", OvertimeSalary = @OvertimeSalary" +
                    ", TotalDeductions = @TotalDeductions" +
                    ", NetIncome = @NetIncome" +
                    ", PenghasilanKenaPajak = @PenghasilanKenaPajak" +
                    ", JaminanKecelakaanKerja = @JaminanKecelakaanKerja" +
                    ", PremiJaminanKematian = @PremiJaminanKematian" +
                    ", JaminanHariTua = @JaminanHariTua" +
                    ", PphTerhutang = @PphTerhutang" +
                    ", BiayaJabatan = @BiayaJabatan" +
                    ", IuranPensiun = @IuranPensiun" +
                    ", NettoSetahun = @NettoSetahun" +
                    ", StatusWajibPajak = @StatusWajibPajak" +
                    ", RapelFromMonth = @RapelFromMonth" +
                    ", RapelToMonth = @RapelToMonth" +
                    ", RapelRate = @RapelRate" +
                    ", Rapel = @Rapel" +
                    ", PajakPphPerTahun = @PajakPphPerTahun" +
                    " WHERE EmployeeCode = @EmployeeCode"
            ElseIf act = "input" Then
                str_carsql = "INSERT INTO db_payroll " +
                            "(EmployeeCode, FullName, PaymentDate, BasicRate, Allowance, Incentives, TableMoney, Transport, OtherAdditionalAllowance1, OtherAdditionalAllowance2, OtherAdditionalAllowance3, OtherAdditionalAllowance4, OtherAdditionalAllowance5, AdditionalAllowance1, AdditionalAllowance2, AdditionalAllowance3, AdditionalAllowance4, AdditionalAllowance5, OvertimeHours, OvertimeType, BpjsPercentage, Taxes, Loan, Lates, OtherAdditionalDeduction1, OtherAdditionalDeduction2, OtherAdditionalDeduction3, OtherAdditionalDeduction4, OtherAdditionalDeduction5, AdditionalDeduction1, AdditionalDeduction2, AdditionalDeduction3, AdditionalDeduction4, AdditionalDeduction5, ResJaminanKecelakaanKerja, ResPremiJaminanKematian, ResJaminanHariTua, ResBiayaJabatan, ResIuranPensiun, PersenKk, PersenJk, PersenJht, PersenBj, PersenIp, MemilikiNpwp, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, PenghasilanKenaPajak, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, PphTerhutang, BiayaJabatan, IuranPensiun, NettoSetahun, StatusWajibPajak, RapelFromMonth, RapelToMonth, RapelRate, Rapel, PajakPphPerTahun) " +
                            "values (@EmployeeCode, @FullName, @PaymentDate, @BasicRate, @Allowance, @Incentives, @TableMoney, @Transport, @OtherAdditionalAllowance1, @OtherAdditionalAllowance2, @OtherAdditionalAllowance3, @OtherAdditionalAllowance4, @OtherAdditionalAllowance5, @AdditionalAllowance1, @AdditionalAllowance2, @AdditionalAllowance3, @AdditionalAllowance4, @AdditionalAllowance5, @OvertimeHours, @OvertimeType, @BpjsPercentage, @Taxes, @Loan, @Lates, @OtherAdditionalDeduction1, @OtherAdditionalDeduction2, @OtherAdditionalDeduction3, @OtherAdditionalDeduction4, @OtherAdditionalDeduction5, @AdditionalDeduction1, @AdditionalDeduction2, @AdditionalDeduction3, @AdditionalDeduction4, @AdditionalDeduction5, @ResJaminanKecelakaanKerja, @ResPremiJaminanKematian, @ResJaminanHariTua, @ResBiayaJabatan, @ResIuranPensiun, @PersenKk, @PersenJk, @PersenJht, @PersenBj, @PersenIp, @MemilikiNpwp, @Gross, @Bpjs, @OvertimeSalary, @TotalDeductions, @NetIncome, @PenghasilanKenaPajak, @JaminanKecelakaanKerja, @PremiJaminanKematian, @JaminanHariTua, @PphTerhutang, @BiayaJabatan, @IuranPensiun, @NettoSetahun, @StatusWajibPajak, @RapelFromMonth, @RapelToMonth, @RapelRate, @Rapel, @PajakPphPerTahun)"
            Else
                str_carsql = "DELETE FROM db_payroll WHERE EmployeeCode = @EmployeeCode"
            End If
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandText = str_carsql
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", txtBar2.Text)
            sqlcommand.Parameters.AddWithValue("@FullName", txtNamaKaryawan.Text)
            sqlcommand.Parameters.AddWithValue("@PaymentDate", txtpayment.Text)
            sqlcommand.Parameters.AddWithValue("@BasicRate", txtGaji.Text)
            sqlcommand.Parameters.AddWithValue("@Allowance", txtAllowance.Text)
            sqlcommand.Parameters.AddWithValue("@Incentives", txtIncentives.Text)
            sqlcommand.Parameters.AddWithValue("@TableMoney", txtMeal.Text)
            sqlcommand.Parameters.AddWithValue("@Transport", txtTransport.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance1", txtadddc1.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance2", txtadddc2.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance3", txtadddc3.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance4", txtadddc4.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance5", txtadddc5.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance1", txt1add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance2", txt2add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance3", txt3add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance4", txt4add.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance5", txt5add.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeHours", txtothours.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeType", txtottype.Text)
            sqlcommand.Parameters.AddWithValue("@BpjsPercentage", txtbpjspercentage.Text)
            sqlcommand.Parameters.AddWithValue("@Taxes", txttaxes.Text)
            sqlcommand.Parameters.AddWithValue("@Loan", txtloan.Text)
            sqlcommand.Parameters.AddWithValue("@Lates", txtlates.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction1", txtdeddc1.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction2", txtdeddc2.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction3", txtdeddc3.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction4", txtdeddc4.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction5", txtdeddc5.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction1", txt1ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction2", txt2ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction3", txt3ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction4", txt4ded.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction5", txt5ded.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanKecelakaanKerja", cmboxjkk.Text)
            sqlcommand.Parameters.AddWithValue("@ResPremiJaminanKematian", cmboxjk.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanHariTua", cmboxjht.Text)
            sqlcommand.Parameters.AddWithValue("@ResBiayajabatan", cmboxbj.Text)
            sqlcommand.Parameters.AddWithValue("@ResIuranPensiun", cmboxiuranpensiun.Text)
            'sqlcommand.Parameters.AddWithValue("@PersenKk", txtpkk.Text)
            'sqlcommand.Parameters.AddWithValue("@PersenJk", txtpjk.Text)
            'sqlcommand.Parameters.AddWithValue("@PersenJht", txtpjht.Text)
            'sqlcommand.Parameters.AddWithValue("@PersenBj", txtpbj.Text)
            'sqlcommand.Parameters.AddWithValue("@PersenIp", txtpip.Text)
            sqlcommand.Parameters.AddWithValue("@MemilikiNpwp", cmboxnpwp.Text)
            sqlcommand.Parameters.AddWithValue("@Gross", txtgross.Text)
            sqlcommand.Parameters.AddWithValue("@Bpjs", txtbpjs.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeSalary", txtotsalary.Text)
            sqlcommand.Parameters.AddWithValue("@TotalDeductions", txtdeduction.Text)
            sqlcommand.Parameters.AddWithValue("@Netincome", txtnetincome.Text)
            sqlcommand.Parameters.AddWithValue("@PenghasilanKenaPajak", txtpkp.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", txtjkk.Text)
            sqlcommand.Parameters.AddWithValue("@PremiJaminanKematian", txtjk.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanHariTua", txtjht.Text)
            sqlcommand.Parameters.AddWithValue("@PphTerhutang", txtpphterutang.Text)
            sqlcommand.Parameters.AddWithValue("@BiayaJabatan", txthasilbjabatan.Text)
            sqlcommand.Parameters.AddWithValue("@IuranPensiun", txthasiliuranpensiun.Text)
            sqlcommand.Parameters.AddWithValue("@NettoSetahun", lcnettosetahun.Text)
            sqlcommand.Parameters.AddWithValue("@StatusWajibPajak", txtStatWp.Text)
            sqlcommand.Parameters.AddWithValue("@RapelFromMonth", frommonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelToMonth", tomonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelRate", txtrapel.Text)
            sqlcommand.Parameters.AddWithValue("@Rapel", rapel.Text)
            sqlcommand.Parameters.AddWithValue("@PajakPphPerTahun", txtpajakpph.Text)
            sqlcommand.ExecuteNonQuery()
            If act = "input" Then
                MessageBox.Show("Data Succesfully Added!")
            ElseIf act = "edit" Then
                MessageBox.Show("Data Succesfully Changed!")
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show("Process Failed!")
        End Try
    End Function

    Public Function InsertEmp() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            If act = "edit" Then
                str_carSql = "UPDATE db_pegawai SET" +
                       " CompanyCode = @CompanyCode" +
                       ", FullName = @FullName" +
                       ", Position = @Position" +
                       ", PlaceOfBirth = @PlaceOfBirth" +
                       ", DateOfBirth = @DateOfBirth" +
                       ", Gender = @Gender" +
                       ", Religion = @Religion" +
                       ", Address = @Address" +
                       ", Email = @Email" +
                       ", OfficeLocation = @OfficeLocation" +
                       ", WorkDate = @WorkDate" +
                       ", PhoneNumber = @PhoneNumber" +
                       ", Photo = @Photo" +
                       ", Status = @Status" +
                       ", TrainingSampai = @TrainingSampai" +
                       " WHERE EmployeeCode = @EmployeeCode"
            ElseIf act = "input" Then
                str_carSql = "INSERT INTO db_pegawai " +
                            "(EmployeeCode, CompanyCode, FullName, Position, PlaceOfBirth, DateOfBirth, Gender, Religion, Address, Email, OfficeLocation, WorkDate, PhoneNumber, Photo, Status, TrainingSampai) " +
                            "values (@EmployeeCode,@CompanyCode,@FullName,@Position,@PlaceOfBirth,@DateOfBirth,@Gender,@Religion,@Address,@Email,@OfficeLocation,@WorkDate,@PhoneNumber, @Photo, @Status, @TrainingSampai)"
            Else
                str_carSql = "DELETE FROM db_pegawai WHERE EmployeeCode = @EmployeeCode"
            End If
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", txtBar2.Text)
            sqlCommand.Parameters.AddWithValue("@CompanyCode", compacode.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", txtBar3.Text)
            sqlCommand.Parameters.AddWithValue("@Position", txtposition.Text)
            sqlCommand.Parameters.AddWithValue("@PlaceOfBirth", txtBar4.Text)
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtTanggal.Text)
            sqlCommand.Parameters.AddWithValue("@Gender", txtbar6.Text)
            sqlCommand.Parameters.AddWithValue("@Religion", txtbar7.Text)
            sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text)
            sqlCommand.Parameters.AddWithValue("@Email", txtemail.Text)
            sqlCommand.Parameters.AddWithValue("@IdNumber", txtBar8.Text)
            sqlCommand.Parameters.AddWithValue("@OfficeLocation", txtlocation.Text)
            sqlCommand.Parameters.AddWithValue("@WorkDate", txtworkdate.Text)
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", txtphone.Text)
            If Not txtFoto.Text Is Nothing Then 'Jika ada file yang akan disimpan
                Dim param As New MySqlParameter("@Photo", ImageToByte(pictureEdit))
                sqlCommand.Parameters.Add(param)
            Else
                sqlCommand.Parameters.AddWithValue("@Photo", "")
            End If
            sqlCommand.Parameters.AddWithValue("@Status", txtStatEmp.Text)
            'sqlCommand.Parameters.AddWithValue("@TrainingSampai", txtTrainingSampai.Text)
            sqlCommand.ExecuteNonQuery()
            If act = "input" Then
                MessageBox.Show("Data Succesfully Added!")
            ElseIf act = "edit" Then
                MessageBox.Show("Data Succesfully Changed!")
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show("Process Failed!")
        End Try
        GridView1.Focus()
        GridView1.MoveLast()
    End Function

    Public Function InsertAtt() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            If act = "edit" Then
                str_carSql = "UPDATE db_absensi SET" +
                        " FullName = @FullName" +
                       ", Tanggal = @Tanggal" +
                       ", Shift = @Shift" +
                       ", JamMulai = @JamMulai" +
                       ", JamSelesai = @JamSelesai" +
                       " WHERE EmployeeCode = @EmployeeCode"
            Else
                str_carSql = "INSERT INTO db_absensi " +
                            "(EmployeeCode, FullName, Tanggal, Shift, JamMulai, JamSelesai) " +
                            "values (@EmployeeCode,@FullName,@Tanggal,@Shift,@JamMulai,@JamSelesai)"
            End If
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", txtBar2.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", txtNamaKaryawan.Text)
            sqlCommand.Parameters.AddWithValue("@Tanggal", txtTanggal.Text)
            sqlCommand.Parameters.AddWithValue("@Shift", txtJnsShift.Text)
            sqlCommand.Parameters.AddWithValue("@JamMulai", txtstart.Text)
            sqlCommand.Parameters.AddWithValue("@JamSelesai", txtfinish.Text)
            sqlCommand.ExecuteNonQuery()
            If act = "input" Then
                MessageBox.Show("Data Successfully Added!")
            ElseIf act = "edit" Then
                MessageBox.Show("Data Successfully Changed!")
            End If
            Return True
        Catch ex As Exception
            Return False
            MessageBox.Show("Process Failed!")
        End Try
    End Function
    ''delete

    Public Function deletesp() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Dim mess As String
        mess = CType(MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo, "Warning"), String)
        If CType(mess, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandType = CommandType.Text
            sqlcommand.CommandText = "DELETE FROM db_sp WHERE EmployeeCode = " + txtBar2.Text
            sqlcommand.ExecuteNonQuery()
            MsgBox("Data Succesfully Removed!", MsgBoxStyle.Information, "Success")
            GridControl1.RefreshDataSource()
            loadDataReq()
            SQLConnection.Close()
        End If
        Return Nothing
    End Function

    Private movelast As Boolean = True


    Public Function DeleteReq() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        'Dim str_carSql As String
        Dim pesan As String
        pesan = CType(MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo, "Warning"), String)
        If CType(pesan, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.CommandText = "DELETE FROM db_recruitment WHERE IdRec = " + txtBar1.Text
            sqlCommand.ExecuteNonQuery()
            MsgBox("Data Successfully Removed", MsgBoxStyle.Information, "Success")
            GridControl1.RefreshDataSource()
            loadDataReq()
            SQLConnection.Close()
        End If
        Return Nothing
    End Function

    Private needMoveLastRow As Boolean = True

    Public Function DeleteEmp() As Boolean
        Try
            SQLConnection = New MySqlConnection()
            SQLConnection.ConnectionString = connectionString
            SQLConnection.Open()
            Dim sqlCommand As New MySqlCommand
            'Dim str_carSql As String
            Dim pesan As String
            pesan = CType(MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo, "Warning"), String)
            If CType(pesan, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
                sqlCommand.Connection = SQLConnection
                sqlCommand.CommandType = CommandType.Text
                sqlCommand.CommandText = "DELETE FROM db_pegawai WHERE EmployeeCode = " + txtBar2.Text
                sqlCommand.ExecuteNonQuery()
                MsgBox("Data Succesfully Removed !", MsgBoxStyle.Information, "Success")
                GridControl1.RefreshDataSource()
                loadDataReq()
                SQLConnection.Close()
            End If
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return Nothing
    End Function

    Public Function DeletePay() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand

        Dim messages As String
        messages = CType(MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo, "Warning"), String)
        If CType(messages, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandType = CommandType.Text
            sqlcommand.CommandText = "DELETE FROM db_payroll WHERE EmployeeCode = " + txtBar2.Text
            sqlcommand.ExecuteNonQuery()
            MsgBox("Data Succesfully Removed!", MsgBoxStyle.Information, "Success")
            GridControl1.RefreshDataSource()
            loadDataReq()
            SQLConnection.Close()
        End If
        Return Nothing
    End Function

    Public Function DeleteAtt() As Boolean
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand

        Dim pesan As String
        pesan = CType(MsgBox("Sure To Delete ?", MsgBoxStyle.YesNo, "Warning"), String)
        If CType(pesan, Global.Microsoft.VisualBasic.MsgBoxResult) = vbYes Then
            sqlcommand.Connection = SQLConnection
            sqlcommand.CommandType = CommandType.Text
            sqlcommand.CommandText = "DELETE FROM db_absensi WHERE EmployeeCode = " + txtBar2.Text
            sqlcommand.ExecuteNonQuery()
            MsgBox("Data Successfully Removed!", MsgBoxStyle.Information, "Success")
            GridControl1.RefreshDataSource()
            loadDataReq()
            SQLConnection.CloseAsync()
        End If
        Return Nothing
    End Function
#End Region

#Region "Fungsi extras"
    ''fungsi extras
    Sub clearForm()
        lc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lc9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcTglInt.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcStatReq.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnBrowse.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcFotoView.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcFoto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        overtimehours.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        overtimetype.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        bpjspercentage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Transport.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lctaxes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcloan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lclates.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        jkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        pjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        jht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        npwp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtadd5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtdeddesc5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtded5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        txtBar1.Text = ""
        txtBar2.Text = ""
        txtBar3.Text = ""
        txtBar4.Text = ""
        txtBar5.Text = ""
        txtbar6.Text = ""
        txtbar7.Text = ""
        txtBar8.Text = ""
        txtBar9.Text = ""
        txtText.Text = ""
        pictureEdit.Controls.Clear()
        txtFoto.Text = ""
        txtTanggal.Text = ""
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

    Dim act As String = ""
    Dim spform As New SPForms

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim datatabl As New DataTable
        Dim sqlCommand As New MySqlCommand
        datatabl.Clear()
        If barJudul.Caption = "Module Recruitment" Then
            Dim param As String = ""
            Try
                param = "and IdRec='" + GridView1.GetFocusedRowCellValue("IdRec").ToString() + "'"
            Catch ex As Exception
            End Try
            If param > "" Then
                act = "edit"
            Else
                act = "input"
            End If
            Try
                sqlCommand.CommandText = "SELECT IdRec,InterviewTimes FROM db_recruitment WHERE 1 = 1 " + param.ToString()
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
                txtBar1.Text = datatabl.Rows(0).Item(0).ToString()
                txtBar2.Text = datatabl.Rows(0).Item(1).ToString()
                'txtBar3.Text = datatabl.Rows(0).Item(2).ToString()
                'txtBar4.Text = datatabl.Rows(0).Item(3).ToString()
                'txtTanggal.Text = datatabl.Rows(0).Item(4).ToString()
                'txtaddress.Text = datatabl.Rows(0).Item(5).ToString()
                'txtbar6.Text = datatabl.Rows(0).Item(6).ToString()
                'txtbar7.Text = datatabl.Rows(0).Item(7).ToString()
                'txtphone.Text = datatabl.Rows(0).Item(8).ToString()
                'txtBar8.Text = datatabl.Rows(0).Item(9).ToString()
                'Dim filefoto As Byte() = CType(datatabl.Rows(0).Item(10), Byte())
                'If filefoto.Length > 0 Then
                '    pictureEdit.Image = ByteToImage(filefoto)
                'Else
                '    pictureEdit.Image = Nothing
                '    pictureEdit.Refresh()
                'End If
                ''tampilkan foto nya belum
                ''
                'txtText.Text = datatabl.Rows(0).Item(11).ToString()
                'txtTglInterview.Text = datatabl(0).Item(12).ToString()
            End If
        ElseIf barJudul.Caption = "Module Employee" Then
            Dim param2 As String = ""
            Try
                param2 = "and EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            If param2 = "" Then
                act = "input"
            Else
                act = "edit"
            End If
            Try
                sqlCommand.CommandText = "SELECT * FROM db_pegawai WHERE 1 = 1 " + param2.ToString()
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
                txtBar2.Text = datatabl.Rows(0).Item(0).ToString()
                compacode.Text = datatabl.Rows(0).Item(1).ToString()
                txtBar3.Text = datatabl.Rows(0).Item(2).ToString()
                txtposition.Text = datatabl.Rows(0).Item(3).ToString()
                txtBar4.Text = datatabl.Rows(0).Item(4).ToString()
                txtTanggal.Text = datatabl.Rows(0).Item(5).ToString()
                txtbar6.Text = datatabl.Rows(0).Item(6).ToString()
                txtbar7.Text = datatabl.Rows(0).Item(7).ToString()
                txtaddress.Text = datatabl.Rows(0).Item(8).ToString()
                txtemail.Text = datatabl.Rows(0).Item(9).ToString()
                txtBar8.Text = datatabl.Rows(0).Item(10).ToString()
                txtlocation.Text = datatabl.Rows(0).Item(11).ToString()
                txtworkdate.Text = datatabl.Rows(0).Item(12).ToString()
                txtphone.Text = datatabl.Rows(0).Item(13).ToString()
                Dim filefoto As Byte() = CType(datatabl.Rows(0).Item(14), Byte())
                If filefoto.Length > 0 Then
                    pictureEdit.Image = ByteToImage(filefoto)
                Else
                    pictureEdit.Image = Nothing
                    pictureEdit.Refresh()
                End If
                txtStatEmp.Text = datatabl.Rows(0).Item(15).ToString()
                'txtTrainingSampai.Text = datatabl.Rows(0).Item(16).ToString()
            End If
        ElseIf barJudul.Caption = "Module Payroll" Then
            Dim param2 As String = ""
            Try
                param2 = "and EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
            End Try
            If param2 = "" Then
                act = "input"
            Else
                act = "edit"
            End If
            Try
                sqlCommand.CommandText = "SELECT * FROM db_payroll WHERE 1 = 1 " + param2.ToString()
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
                txtBar2.Text = datatabl.Rows(0).Item(0).ToString()
                txtNamaKaryawan.Text = datatabl.Rows(0).Item(1).ToString()
                txtpayment.Text = datatabl.Rows(0).Item(2).ToString()
                txtGaji.Text = datatabl.Rows(0).Item(3).ToString()
                txtAllowance.Text = datatabl.Rows(0).Item(4).ToString()
                txtIncentives.Text = datatabl.Rows(0).Item(5).ToString()
                txtMeal.Text = datatabl.Rows(0).Item(6).ToString()
                txtTransport.Text = datatabl.Rows(0).Item(7).ToString()
                txtadddc1.Text = datatabl.Rows(0).Item(8).ToString()
                txtadddc2.Text = datatabl.Rows(0).Item(9).ToString()
                txtadddc3.Text = datatabl.Rows(0).Item(10).ToString()
                txtadddc4.Text = datatabl.Rows(0).Item(11).ToString()
                txtadddc5.Text = datatabl.Rows(0).Item(12).ToString()
                txt1add.Text = datatabl.Rows(0).Item(13).ToString()
                txt2add.Text = datatabl.Rows(0).Item(14).ToString()
                txt3add.Text = datatabl.Rows(0).Item(15).ToString()
                txt4add.Text = datatabl.Rows(0).Item(16).ToString()
                txt5add.Text = datatabl.Rows(0).Item(17).ToString()
                txtothours.Text = datatabl.Rows(0).Item(18).ToString()
                txtottype.Text = datatabl.Rows(0).Item(19).ToString()
                txtbpjspercentage.Text = datatabl.Rows(0).Item(20).ToString()
                txttaxes.Text = datatabl.Rows(0).Item(21).ToString()
                txtloan.Text = datatabl.Rows(0).Item(22).ToString()
                txtlates.Text = datatabl.Rows(0).Item(23).ToString()
                txtdeddc1.Text = datatabl.Rows(0).Item(24).ToString()
                txtdeddc2.Text = datatabl.Rows(0).Item(25).ToString()
                txtdeddc3.Text = datatabl.Rows(0).Item(26).ToString()
                txtdeddc4.Text = datatabl.Rows(0).Item(27).ToString()
                txtdeddc5.Text = datatabl.Rows(0).Item(28).ToString()
                txt1ded.Text = datatabl.Rows(0).Item(29).ToString()
                txt2ded.Text = datatabl.Rows(0).Item(30).ToString()
                txt3ded.Text = datatabl.Rows(0).Item(31).ToString()
                txt4ded.Text = datatabl.Rows(0).Item(32).ToString()
                txt5ded.Text = datatabl.Rows(0).Item(33).ToString()
                cmboxjkk.Text = datatabl.Rows(0).Item(34).ToString()
                cmboxjk.Text = datatabl.Rows(0).Item(35).ToString()
                cmboxjht.Text = datatabl.Rows(0).Item(36).ToString()
                cmboxbj.Text = datatabl.Rows(0).Item(37).ToString()
                cmboxiuranpensiun.Text = datatabl.Rows(0).Item(38).ToString()
                'txtpkk.Text = datatabl.Rows(0).Item(39).ToString()
                'txtpjk.Text = datatabl.Rows(0).Item(40).ToString()
                'txtpjht.Text = datatabl.Rows(0).Item(41).ToString()
                'txtpbj.Text = datatabl.Rows(0).Item(42).ToString()
                'txtpip.Text = datatabl.Rows(0).Item(43).ToString()
                cmboxnpwp.Text = datatabl.Rows(0).Item(44).ToString()
                txtgross.Text = datatabl.Rows(0).Item(45).ToString()
                txtbpjs.Text = datatabl.Rows(0).Item(46).ToString()
                txtotsalary.Text = datatabl.Rows(0).Item(47).ToString()
                txtdeduction.Text = datatabl.Rows(0).Item(48).ToString()
                txtnetincome.Text = datatabl.Rows(0).Item(49).ToString()
                txtpkp.Text = datatabl.Rows(0).Item(50).ToString()
                txtjkk.Text = datatabl.Rows(0).Item(51).ToString()
                txtjk.Text = datatabl.Rows(0).Item(52).ToString()
                txtjht.Text = datatabl.Rows(0).Item(53).ToString()
                txtpphterutang.Text = datatabl.Rows(0).Item(54).ToString()
                txthasilbjabatan.Text = datatabl.Rows(0).Item(55).ToString()
                txthasiliuranpensiun.Text = datatabl.Rows(0).Item(56).ToString()
                lcnettosetahun.Text = datatabl.Rows(0).Item(57).ToString()
                txtStatWp.Text = datatabl.Rows(0).Item(58).ToString()
                frommonth.Text = datatabl.Rows(0).Item(59).ToString()
                tomonth.Text = datatabl.Rows(0).Item(60).ToString()
                txtrapel.Text = datatabl.Rows(0).Item(61).ToString()
                rapel.Text = datatabl.Rows(0).Item(62).ToString()
                txtpajakpph.Text = datatabl.Rows(0).Item(63).ToString()
            End If
        ElseIf barJudul.Caption = "Module Attendance" Then
            Dim param2 As String = ""
            Try
                param2 = "and EmployeeCode ='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            If param2 = "" Then
                act = "input"
            Else
                act = "edit"
            End If
            Try
                sqlCommand.CommandText = "SELECT * FROM db_absensi WHERE 1 = 1 " + param2.ToString()
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
                txtBar2.Text = datatabl.Rows(0).Item(0).ToString()
                txtNamaKaryawan.Text = datatabl.Rows(0).Item(1).ToString()
                txtTanggal.Text = datatabl.Rows(0).Item(2).ToString
                txtJnsShift.Text = datatabl.Rows(0).Item(3).ToString
                txtstart.Text = datatabl.Rows(0).Item(4).ToString
                txtfinish.Text = datatabl.Rows(0).Item(5).ToString
            End If
        ElseIf barJudul.Caption = "Employee Menus" Then
            Dim param2 As String = ""
            Try
                param2 = "and EmployeeCode='" + GridView1.GetFocusedRowCellValue("EmployeeCode").ToString() + "'"
            Catch ex As Exception
            End Try
            If param2 = "" Then
                act = "input"
            Else
                act = "edit"
            End If
            Try
                sqlCommand.CommandText = "SELECT EmployeeCode, CompanyCode, FullName, Position, SuratPeringatan1, SuratPeringatan2, SuratPeringatan3, Rotasi, Demosi from db_sp" + param2.ToString()
                sqlCommand.Connection = SQLConnection
                Dim adapter As New MySqlDataAdapter(sqlCommand.CommandText, SQLConnection)
                Dim cb As New MySqlCommandBuilder(adapter)
                adapter.Fill(datatabl)
                SQLConnection.Close()
            Catch ex As Exception
                SQLConnection.Close()
                MsgBox(ex.Message)
            End Try
            If datatabl.Rows.Count > 0 Then
                txtBar2.Text = datatabl.Rows(0).Item(0).ToString()
                compcode.Text = datatabl.Rows(0).Item(1).ToString()
                txtNamaKaryawan.Text = datatabl.Rows(0).Item(2).ToString()
                txtposition.Text = datatabl.Rows(0).Item(3).ToString()
            End If
        End If
    End Sub

#End Region
    Private Sub txtStatEmp_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtText.SelectedIndex = 0 Then
            txtText.SelectedItem = "Pending"
        ElseIf txtText.SelectedIndex = 1 Then
            txtText.SelectedItem = "Accepted"
        ElseIf txtText.SelectedIndex = 2 Then
            txtText.SelectedItem = "Rejected"
        ElseIf txtText.SelectedIndex = 3 Then
            txtText.SelectedItem = "Blocked"
        End If
    End Sub

    Private Sub txtStatEmp_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatEmp.SelectedValueChanged
    End Sub

    Private Sub txtJnsShift_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJnsShift.SelectedValueChanged
        If txtJnsShift.SelectedIndex = 0 Then
            txtJnsShift.SelectedItem = "Shift 1(08.00-16.00)"
        ElseIf txtJnsShift.SelectedIndex = 1 Then
            txtJnsShift.SelectedItem = "Shift 2(16.00-00.00)"
        ElseIf txtJnsShift.SelectedIndex = 2 Then
            txtJnsShift.SelectedItem = "Shift 4(00.00-08.00)"
        ElseIf txtJnsShift.SelectedIndex = 3 Then
            txtJnsShift.SelectedItem = "Full Time (08.00-17.00)"
        ElseIf txtJnsShift.SelectedIndex = 4 Then
            txtJnsShift.SelectedItem = "Overtime"
        End If
    End Sub

    Private Sub txtNamaKaryawan_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaKaryawan.SelectedValueChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtNamaKaryawan.SelectedItem Is tbl_par.Rows(indexing).Item(1).ToString() Then
                txtBar2.Text = tbl_par.Rows(indexing).Item(0).ToString()
                txtposition.Text = tbl_par.Rows(indexing).Item(2).ToString
                compacode.Text = tbl_par.Rows(indexing).Item(3).ToString
            End If
        Next
    End Sub

    Dim setting As New setting

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If setting Is Nothing OrElse setting.IsDisposed Then
            setting = New setting
        End If
        setting.Show()
    End Sub

    Sub ShowGridPreview(ByVal grid As GridControl)
        ' Check whether the GridControl can be previewed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If
        ' Opens the Preview window.
        grid.ShowPrintPreview()
    End Sub


    Sub PrintGrid(ByVal grid As GridControl)
        ' Check whether the GridControl can be printed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If
        ' Print.
        grid.Print()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ShowGridPreview(GridControl1)
    End Sub

    Private Sub txtStatWp_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatWp.SelectedValueChanged
        If txtStatWp.SelectedIndex = 0 Then
            txtStatWp.SelectedItem = "Tidak Kawin, Tanpa Tanggungan"
        ElseIf txtStatWp.SelectedIndex = 1 Then
            txtStatWp.SelectedItem = "Tidak Kawin, Tanggungan 1"
        ElseIf txtStatWp.SelectedIndex = 2 Then
            txtStatWp.SelectedItem = "Tidak Kawin, Tanggungan 2"
        ElseIf txtStatWp.SelectedIndex = 3 Then
            txtStatWp.SelectedItem = "Tidak Kawin, Tanggungan 3"
        ElseIf txtStatWp.SelectedIndex = 4 Then
            txtStatWp.SelectedItem = "Kawin, Tanpa Tanggungan"
        ElseIf txtStatWp.SelectedIndex = 5 Then
            txtStatWp.SelectedItem = "Kawin, Tanggungan 1"
        ElseIf txtStatWp.SelectedIndex = 6 Then
            txtStatWp.SelectedItem = "Kawin, Tanggungan 2"
        ElseIf txtStatWp.SelectedIndex = 7 Then
            txtStatWp.SelectedItem = "Kawin, Tanggungan 3"
        ElseIf txtStatWp.SelectedIndex = 8 Then
            txtStatWp.SelectedItem = "Kawin, Penghasilan Istri Dan Suami Digabung"
        ElseIf txtStatWp.SelectedIndex = 9 Then
            txtStatWp.SelectedItem = "Kawin, Penghasilan Digabung Tanggungan 1"
        ElseIf txtStatWp.SelectedIndex = 10 Then
            txtStatWp.SelectedItem = "Kawin, Penghasilan Digabung Tanggungan 2"
        ElseIf txtStatWp.SelectedIndex = 11 Then
            txtStatWp.SelectedItem = "Kawin, Penghasilan Digabung Tanggungan 3"
        End If
    End Sub

    Private Sub txtBar1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBar1.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub biayajabatan()
        Try
            Dim a, b, res As Double
            a = Convert.ToDouble(txtGaji.Text)
            'b = Convert.ToDouble(txtpbj.Text)
            res = a * b / 100
            txthasilbjabatan.Text = res.ToString()
            txthasilbjabatan.Text = Format(res, "##,##0")
            txthasilbjabatan.SelectionStart = Len(txthasilbjabatan.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub pkpn()
        Try
            Dim a, b, res As Double
            a = Convert.ToDouble(lcnettosetahun.Text)
            b = Convert.ToDouble(nilai)
            res = a - b
            txtpkp.Text = res.ToString()
            txtpkp.Text = Format(res, "##,##0")
            txtpkp.SelectionStart = Len(txtpkp.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub pphtahun()
        Try
            Dim a, res As Double
            a = Convert.ToDouble(txtpkp.Text)
            If (a < 25000000) Then
                res = a * 5 / 100
            ElseIf (a > 250000000) Then
                res = a * 10 / 100
            ElseIf (a > 500000000) Then
                res = a * 15 / 10
            ElseIf (a > 1000000000) Then
                res = a * 25 / 100
            End If
            txtpajakpph.Text = res.ToString()
            txtpajakpph.Text = Format(res, "##,##0")
            txtpajakpph.SelectionStart = Len(txtpajakpph.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub pphterutang()
        Try
            Dim a, b, c As Double
            a = Convert.ToDouble(lcnettosetahun.Text)
            b = Convert.ToDouble(nilai)
            c = a - b
            Dim hasil1, hasil2, nilai1, nilai2 As Double
            hasil1 = Convert.ToDouble(c)
            hasil2 = Convert.ToDouble(CInt(txtGaji.Text) * 12)
            If cmboxnpwp.SelectedIndex = 0 Then
                If hasil2 < 5000000 Then
                    nilai1 = c * 5 / 100
                ElseIf hasil2 > 50000000 Then
                    nilai1 = c * 15 / 100
                ElseIf hasil2 > 250000000 Then
                    nilai1 = c * 25 / 100
                Else
                    nilai1 = c * 30 / 100
                End If
                txtpphterutang.Text = nilai1.ToString()
                txtpphterutang.Text = Format(nilai, "##,##0")
                txtpphterutang.SelectionStart = Len(txtpphterutang.Text)
            ElseIf cmboxnpwp.SelectedIndex = 1 Then
                If hasil2 < 50000000 Then
                    nilai1 = c * 5 / 100
                    nilai2 = nilai1 * 120 / 100
                ElseIf hasil2 > 50000000 Then
                    nilai1 = c * 15 / 100
                    nilai2 = nilai1 * 120 / 100
                ElseIf hasil2 > 250000000 Then
                    nilai1 = c * 25 / 100
                    nilai2 = nilai1 * 120 / 100
                Else
                    nilai1 = c * 30 / 100
                    nilai2 = nilai1 * 120 / 100
                End If
                txtpphterutang.Text = nilai1.ToString()
                txtpphterutang.Text = Format(nilai1, "##,##0")
                txtpphterutang.SelectionStart = Len(txtpphterutang.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub gross()
        Try
            Dim a, b, c, d, e, f, g, h, i, j, k, l, res As Long
            a = CLng(Convert.ToDouble(txtGaji.Text))
            b = CLng(Convert.ToDouble(txtAllowance.Text))
            c = CLng(Convert.ToDouble(txtIncentives.Text))
            d = CLng(Convert.ToDouble(txtMeal.Text))
            e = CLng(Convert.ToDouble(txtTransport.Text))
            f = CLng(Convert.ToDouble(txt1add.Text))
            g = CLng(Convert.ToDouble(txt2add.Text))
            h = CLng(Convert.ToDouble(txt3add.Text))
            i = CLng(Convert.ToDouble(txt4add.Text))
            j = CLng(Convert.ToDouble(txt5add.Text))
            res = a + b + c + d + e + f + g + h + i + j + k + l
            txtgross.Text = res.ToString()
            txtgross.Text = Format(res, "##,##0")
            txtgross.SelectionStart = Len(txtgross.Text)
        Catch ex As Exception
            If txtGaji.Text = "" Or txtAllowance.Text = "" Or txtIncentives.Text = "" Or txtMeal.Text = "" Or txtTransport.Text = "" Or txt1add.Text = "" Or txt2add.Text = "" Or txt3add.Text = "" Or txt4add.Text = "" Or txt5add.Text = "" Then ' Or txtotsalary.Text = "" Or rapel.Text = "" Then
                MsgBox("Allowances Fields Can't Be Empty, Please Input 0 if There Is No Any Additional Allowances")
            End If
        End Try
    End Sub

    Private Sub deductions()
        Try
            Dim a, b, c, d, e, f, g, h, res As Long
            a = CLng(Convert.ToDouble(txttaxes.Text))
            b = CLng(Convert.ToDouble(txtloan.Text))
            c = CLng(Convert.ToDouble(txtlates.Text))
            d = CLng(Convert.ToDouble(txt1ded.Text))
            e = CLng(Convert.ToDouble(txt2ded.Text))
            f = CLng(Convert.ToDouble(txt3ded.Text))
            g = CLng(Convert.ToDouble(txt4ded.Text))
            h = CLng(Convert.ToDouble(txt5ded.Text))
            res = a + b + c + d + e + f + g + h
            txtdeduction.Text = res.ToString()
            txtdeduction.Text = Format(res, "##,##0")
            txtdeduction.SelectionStart = Len(txtdeduction.Text)
        Catch ex As Exception
            If txttaxes.Text = "" Or txtloan.Text = "" Or txtlates.Text = "" Or txt1ded.Text = "" Or txt2ded.Text = "" Or txt3ded.Text = "" Or txt5ded.Text = "" Then ' Or txtbpjs.Text = "" Or txtjkk.Text = "" Or txtjk.Text = "" Or txthasilbjabatan.Text = "" Or txthasiliuranpensiun.Text = "" Then
                MsgBox("Deductions Fields Can't Be Empty, Please Input 0 If There Is No Any Additional Deductions")
            End If
        End Try
    End Sub

    Private Sub jaminanharitua()
        Try
            Dim a, b, res As Double
            If cmboxjht.Text = "Yes" Then
                a = Convert.ToDouble(txtGaji.Text)
                'b = Convert.ToDouble(txtpjht.Text)
                res = a * b / 100
                txtjht.Text = res.ToString()
                txtjht.Text = Format(res, "##,##0")
                txtjht.SelectionStart = Len(txtjht.Text)
            Else
                res = 0
                txtjht.Text = res.ToString()
                txtjht.Text = Format(res, "##,##0")
                txtjht.SelectionStart = Len(txtjht.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub iuranpensiun()
        Try
            Dim a, b, res As Double
            If cmboxiuranpensiun.Text = "Yes" Then
                a = Convert.ToDouble(txtGaji.Text)
                ' b = Convert.ToDouble(txtpip.Text)
                res = a * b / 100
                txthasiliuranpensiun.Text = res.ToString()
                txthasiliuranpensiun.Text = Format(res, "##,##0")
                txthasiliuranpensiun.SelectionStart = Len(txthasiliuranpensiun.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub overtime()
        Try
            If txtottype.Text = "Regular Day" Then
                Dim hours, pay, salary, temp, totot, tempo, value1, value2, pay2 As Double
                hours = CInt(Convert.ToInt64(txtothours.Text))
                salary = CInt(Convert.ToInt64(txtGaji.Text))
                pay = CInt(salary / 173)
                pay2 = CInt(pay * 1.5)
                If (hours = 1) Then
                    tempo = CInt(pay * 1.5)
                    value1 = tempo
                    totot = value1
                ElseIf (hours > 1) Then
                    temp = pay * 2
                    tempo = temp * hours - pay * 2
                    value2 = tempo
                    totot = value2 + pay2
                End If
                txtotsalary.Text = totot.ToString()
                txtotsalary.Text = Format(totot, "##,##0")
                txtotsalary.SelectionStart = Len(txtotsalary.Text)
            ElseIf txtottype.Text = "Holiday / Sunday" Then
                Dim hours, pay, salary, temp, totot2, tempo, value1, value2, pay2, value3 As Double
                hours = CInt(Convert.ToInt64(txtothours.Text))
                salary = CInt(Convert.ToInt64(txtGaji.Text))
                pay = CInt(salary / 173)
                pay2 = pay * 3
                If (hours > 0) And (hours < 8) Then
                    tempo = pay * hours * 2
                    value1 = tempo
                    totot2 = value1
                ElseIf (hours = 8) Then
                    temp = pay * 3
                    tempo = temp * hours - pay * 3
                    value2 = tempo
                    totot2 = value2 - pay2 - pay
                ElseIf (hours > 8) Then
                    temp = pay * 4
                    tempo = temp * hours - pay * 4
                    value3 = tempo
                    totot2 = value3 - value2 - value1
                End If
                txtotsalary.Text = totot2.ToString()
                txtotsalary.Text = Format(totot2, "##,##0")
                txtotsalary.SelectionStart = Len(txtotsalary.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub jaminankecelakaankerja()
        Try
            Dim a, b, res As Double
            If cmboxjkk.Text = "Yes" Then
                a = Convert.ToDouble(txtGaji.Text)
                ' b = Convert.ToDouble(txtpkk.Text)
                res = a * b / 100
                txtjkk.Text = res.ToString()
                txtjkk.Text = Format(res, "##,##0")
                txtjkk.SelectionStart = Len(txtjkk.Text)
            Else
                res = 0
                txtjkk.Text = res.ToString()
                txtjkk.Text = Format(res, "##,##0")
                txtjkk.SelectionStart = Len(txtjkk.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub jaminankematian()
        Try
            Dim a, b, res As Double
            If cmboxjk.Text = "Yes" Then
                a = Convert.ToDouble(txtGaji.Text)
                'b = Convert.ToDouble(txtpjk.Text)
                res = a * b / 100
                txtjk.Text = res.ToString()
                txtjk.Text = Format(res, "##,##0")
                txtjk.SelectionStart = Len(txtjk.Text)
            Else
                res = 0
                txtjk.Text = res.ToString()
                txtjk.Text = Format(res, "##,##0")
                txtjk.SelectionStart = Len(txtjk.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub nettosetahun()
        Try
            Dim a, res As Double
            a = Convert.ToDouble(txtnetincome.Text)
            res = a * 12
            lcnettosetahun.Text = res.ToString()
            lcnettosetahun.Text = Format(res, "##,##0")
            lcnettosetahun.SelectionStart = Len(lcnettosetahun.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub netincome()
        Try
            Dim a, b, res As Double
            a = Convert.ToDouble(txtgross.Text)
            b = Convert.ToDouble(txtdeduction.Text)
            res = a - b
            txtnetincome.Text = res.ToString()
            txtnetincome.Text = Format(res, "##,##0")
            txtnetincome.SelectionStart = Len(txtnetincome.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub bpjs()
        Try
            Dim a, b, res As Double
            a = Convert.ToDouble(txtbpjspercentage.Text)
            b = Convert.ToDouble(txtGaji.Text)
            res = b * a / 100
            txtbpjs.Text = res.ToString()
            txtbpjs.Text = Format(res, "##,##0")
            txtbpjs.SelectionStart = Len(txtbpjs.Text)
        Catch ex As Exception
            If txtbpjspercentage.Text = "" Then
                MsgBox("Please Input BPJS Percentage First")
            End If
        End Try
    End Sub

    Private Sub txtText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtText.SelectedIndexChanged

    End Sub

    Private Sub marqueBar_EditValueChanged(sender As Object, e As EventArgs) Handles marqueBar.EditValueChanged

    End Sub

    'Private Sub txtemployeecode_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    For indexing As Integer = 0 To tbl_par.Rows.Count - 1
    '        If txtemployeecode.SelectedItem = tbl_par.Rows(indexing).Item(1).ToString() Then
    '            txtBar2.Text = tbl_par.Rows(indexing).Item(0).ToString()
    '        End If
    '    Next
    'End Sub

    Private Sub txtTransport_EditValueChanged(sender As Object, e As EventArgs) Handles txtTransport.EditValueChanged

    End Sub

    Private Sub txtgross_Enter(sender As Object, e As EventArgs) Handles txtgross.Enter
    End Sub

    Private Sub countButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub countButton_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub countButton_Click_1(sender As Object, e As EventArgs) Handles countButton.Click
        Call gross()
        Call bpjs()
        Call overtime()
        Call deductions()
        Call netincome()
        Call nettosetahun()
        Call jaminanharitua()
        Call jaminankecelakaankerja()
        Call jaminankematian()
        Call biayajabatan()
        Call iuranpensiun()
        Call pkpn()
        Call pphterutang()
        Call hitungrapel()
        Call pphtahun()
    End Sub

    Private Sub txtdeduction_Enter(sender As Object, e As EventArgs) Handles txtdeduction.Enter

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGaji_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGaji.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAllowance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAllowance.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIncentives_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIncentives.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMeal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeal.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTransport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransport.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt2add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2add.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt3add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3add.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt4add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4add.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt5add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5add.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtothours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtothours.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmonthlysalary_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbpjspercentage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbpjspercentage.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttaxes_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtloan_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlates_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt1ded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1ded.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt2ded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2ded.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt3ded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3ded.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt4ded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4ded.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt5ded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5ded.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtotsalary_Enter(sender As Object, e As EventArgs) Handles txtotsalary.Enter

    End Sub

    Private Sub cmboxjkk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxjkk.SelectedIndexChanged
        If cmboxjkk.SelectedIndex = 0 Then
            cmboxjkk.SelectedItem = "Yes"
            'lcpersenkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ElseIf cmboxjkk.SelectedIndex = 1 Then
            cmboxjkk.SelectedItem = "No"
            'lcpersenkk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'txtpkk.Text = "0"
        End If
    End Sub

    Private Sub cmboxjk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxjk.SelectedIndexChanged
        If cmboxjk.SelectedIndex = 0 Then
            cmboxjk.SelectedItem = "Yes"
            'lcpersenjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ElseIf cmboxjk.SelectedIndex = 1 Then
            cmboxjk.SelectedItem = "No"
            'lcpersenjk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' txtpjk.Text = "0"
        End If
    End Sub

    Private Sub cmboxjht_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxjht.SelectedIndexChanged
        If cmboxjht.SelectedIndex = 0 Then
            cmboxjht.SelectedItem = "Yes"
            'lcpersenjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ElseIf cmboxjht.SelectedIndex = 1 Then
            cmboxjht.SelectedItem = "No"
            'lcpersenjht.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'txtpjht.Text = "0"
        End If
    End Sub


    Dim nilai As Double

    Public Sub txtStatWp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtStatWp.SelectedIndexChanged
        If txtStatWp.Text = "" Then
            nilai = 0
        ElseIf txtStatWp.SelectedIndex = 0 Then
            nilai = 54000000
        ElseIf txtStatWp.SelectedIndex = 1 Then
            nilai = 58500000
        ElseIf txtStatWp.SelectedIndex = 2 Then
            nilai = 63000000
        ElseIf txtStatWp.SelectedIndex = 3 Then
            nilai = 67500000
        ElseIf txtStatWp.SelectedIndex = 4 Then
            nilai = 11250000
        ElseIf txtStatWp.SelectedIndex = 5 Then
            nilai = 11700000
        ElseIf txtStatWp.SelectedIndex = 6 Then
            nilai = 12150000
        Else
            nilai = 126000000
        End If
    End Sub

    Private Sub cmboxiuranpensiun_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmboxiuranpensiun.SelectedIndexChanged
        If cmboxiuranpensiun.SelectedIndex = 0 Then
            cmboxiuranpensiun.SelectedItem = "Yes"
            ' lciuranpensiun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ElseIf cmboxiuranpensiun.SelectedIndex = 1 Then
            cmboxiuranpensiun.SelectedItem = "No"
            ' lciuranpensiun1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' txtpip.Text = "0"
        End If
    End Sub

    Private Sub cmboxbj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxbj.SelectedIndexChanged
        If cmboxbj.SelectedIndex = 0 Then
            cmboxbj.SelectedItem = "Yes"
            ' lcbiayajabatan1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        ElseIf cmboxbj.SelectedIndex = 1 Then
            cmboxbj.SelectedItem = "No"
            'lcbiayajabatan1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            'txtpbj.Text = "0"
        End If
    End Sub

    Private Sub cmboxottype_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Dim value As Long
    Dim value2 As Long

    Private Sub hitungrapel()
        Dim a, totalvalue, res As Long
        a = CLng(Convert.ToDouble(txtrapel.Text))
        totalvalue = value2 - value
        res = a * totalvalue - a
        rapel.Text = res.ToString
        rapel.Text = Format(res, "##,##0")
        rapel.SelectionStart = Len(rapel.Text)
    End Sub

    Private Sub tomonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tomonth.SelectedIndexChanged
        If tomonth.Text = "January" Then
            value2 = 1
        ElseIf tomonth.Text = "February" Then
            value2 = 2
        ElseIf tomonth.Text = "March" Then
            value2 = 3
        ElseIf tomonth.Text = "April" Then
            value2 = 4
        ElseIf tomonth.Text = "May" Then
            value2 = 5
        ElseIf tomonth.Text = "June" Then
            value2 = 6
        ElseIf tomonth.Text = "July" Then
            value2 = 7
        ElseIf tomonth.Text = "August" Then
            value2 = 8
        ElseIf tomonth.Text = "September" Then
            value2 = 9
        ElseIf tomonth.Text = "October" Then
            value2 = 10
        ElseIf tomonth.Text = "November" Then
            value2 = 11
        Else
            value2 = 12
        End If
    End Sub

    Private Sub frommonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles frommonth.SelectedIndexChanged
        If frommonth.Text = "January" Then
            value = 0
        ElseIf frommonth.Text = "February" Then
            value = 1
        ElseIf frommonth.Text = "March" Then
            value = 2
        ElseIf frommonth.Text = "April" Then
            value = 3
        ElseIf frommonth.Text = "May" Then
            value = 4
        ElseIf frommonth.Text = "June" Then
            value = 5
        ElseIf frommonth.Text = "July" Then
            value = 6
        ElseIf frommonth.Text = "August" Then
            value = 7
        ElseIf frommonth.Text = "September" Then
            value = 8
        ElseIf frommonth.Text = "October" Then
            value = 9
        ElseIf frommonth.Text = "November" Then
            value = 10
        Else
            value = 11
        End If
    End Sub

    Private Sub rapel_EditValueChanged(sender As Object, e As EventArgs) Handles rapel.EditValueChanged

    End Sub

    Private Sub rapel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rapel.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        clearForm()
        reset()
        resetclear()
        lcForm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnSimpan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnHapus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcBtnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        btnImport.Enabled = False
        'lcKaryawan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'lc2.Text = "Employee Code"
        barJudul.Caption = "Module Payment Details"
        'lcpayment.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'GridControl1.DataSource = DBNull.Value
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadDataReq()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        clearForm()
        reset()
        resetclear()
        lcForm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcBtnSimpan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcBtnHapus.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcBtnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcKaryawan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lc2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lc2.Text = "Employee Code"
        compcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        compcode.Text = "Company Code"
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcsp1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcrotasi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        barJudul.Caption = "Employee Menus"
        GridControl1.RefreshDataSource()
        GridView1.Columns.Clear()
        loadDataReq()
        'spform.Show()
    End Sub

    Dim employeenotes As New Notes
    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        If employeenotes Is Nothing OrElse employeenotes.IsDisposed Then
            employeenotes = New Notes
        End If
        employeenotes.Show()
        'employeenotes.Activate()
    End Sub

    Dim spforms As New SPForms

    Private Sub sp1_Click(sender As Object, e As EventArgs) Handles sp1.Click
        If spforms Is Nothing OrElse spforms.IsDisposed Then
            spforms = New SPForms
        End If
        spforms.Show()
    End Sub

    Dim rotasi As New RotasiMutasi

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If rotasi Is Nothing OrElse rotasi.IsDisposed Then
            rotasi = New RotasiMutasi
        End If
        rotasi.Show()
    End Sub

    Private Sub txtBar8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBar8.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub GridView1_RowLoaded(sender As Object, e As Views.Base.RowEventArgs)
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If needMoveLastRow = False Then
            view.MoveLast()
        End If
    End Sub

    Private Sub txt1add_EditValueChanged(sender As Object, e As EventArgs) Handles txt1add.EditValueChanged

    End Sub

    Private Sub txt1add_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1add.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttaxes_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txttaxes.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtloan_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtloan.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlates_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtlates.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpkk_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpjk_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpjht_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpbj_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpip_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrapel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrapel.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Dim employees As New NewRec
    Dim newemps As New NewEmp
    Dim salary As New NewSalary

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If barJudul.Caption = "Module Recruitment" Then
            If employees Is Nothing OrElse employees.IsDisposed Then
                employees = New NewRec
            End If
            employees.Show()
            employees.BarButtonItem1.PerformClick()
        ElseIf barJudul.Caption = "Module Employee" Then
            If newemps Is Nothing OrElse newemps.IsDisposed Then
                newemps = New NewEmp
            End If
            newemps.Show()
            newemps.BarButtonItem1.PerformClick()
        ElseIf barJudul.Caption = "Module Payroll" Then
            If salary Is Nothing OrElse salary.IsDisposed Then
                salary = New NewSalary
            End If
            salary.Show()
            salary.BarButtonItem1.PerformClick()
        End If
    End Sub

    Dim proses As New RecProcess

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If barJudul.Caption = "Module Recruitment" Then
            If employees Is Nothing OrElse employees.IsDisposed Then
                employees = New NewRec
            End If
            employees.Show()
            employees.BarButtonItem2.PerformClick()
        ElseIf barJudul.Caption = "Module Employee" Then
            If newemps Is Nothing OrElse newemps.IsDisposed Then
                newemps = New NewEmp
            End If
            newemps.Show()
            newemps.BarButtonItem2.PerformClick()
        ElseIf barJudul.Caption = "Module Payroll" Then
            If salary Is Nothing OrElse salary.IsDisposed Then
                salary = New NewSalary
            End If
            salary.Show()
            salary.BarButtonItem2.PerformClick()
        End If
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As Views.Grid.PopupMenuShowingEventArgs)

    End Sub

    Private Sub btnProg_Click(sender As Object, e As EventArgs) Handles btnProg.Click
        If proses Is Nothing OrElse proses.IsDisposed Then
            proses = New RecProcess
        End If
        proses.Show()
    End Sub

    Private Sub txtTrainingSampai_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtStatEmp_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Dim proc As New Rapel
    Dim loan As New Payments

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btnProc.Click
        If loan Is Nothing OrElse loan.IsDisposed Then
            loan = New Payments
        End If
        loan.Show()
        loan.BarButtonItem1.PerformClick()
        loan.XtraTabPage5.Show()
    End Sub

    Private Sub GridView1_PopupMenuShowing_1(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
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