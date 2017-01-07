Imports System.Runtime.InteropServices
Imports word = Microsoft.Office.Interop.Word

Public Class SPForms
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Private Sub reset()
        txtNamaKaryawan.Text = ""
        txtEmpCode.Text = ""
        txtcompcode.Text = ""
        txtPosition.Text = ""
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

    Private Sub clear()
        lcnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lccompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub SPForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "Surat Peringatan 1"
        lcnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lccompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcTitle.Text = "Surat Peringatan 1"
        btnSP.Text = "Give SP1 To This Employee"
        loadDataKaryawan()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        barJudul.Caption = "Surat Peringatan 2"
        lcnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lccompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcTitle.Text = "Surat Peringatan 2"
        btnSP.Text = "Give SP2 To This Employee"
        loadDataKaryawan()
    End Sub

    Private Sub barbuttonitem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barbuttonitem3.ItemClick
        barJudul.Caption = "Surat peringatan 3"
        lcnames.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcempcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lccompcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcposition.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        lcTitle.Text = "Surat Peringatan 3"
        btnSP.Text = "Give SP3 To This Employee"
        loadDataKaryawan()

    End Sub

    Private Sub sp1()
        Dim objword As word.Application = Nothing
        Try
            objword = New word.Application
            'Dim objdoc As word.Document
            objword.Documents.Open("E:\Word\sp1.docx")
            Dim findobject As word.Find = objword.Selection.Find
            With findobject
                .ClearFormatting()
                .Text = "Name"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtNamaKaryawan.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Employee Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtEmpCode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Company Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtcompcode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Position"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtPosition.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With

            'objword.Documents.Item(1).Save()
            'objword.Documents.Close(word.WdSaveOptions.wdDoNotSaveChanges)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            'If Not IsNothing(objword) Then
            '    objword.Quit()
            '    objword = Nothing
            'End If
        End Try
    End Sub

    Private Sub sp2()
        Dim objword As word.Application = Nothing
        Try
            objword = New word.Application
            'Dim objdoc As word.Document
            objword.Documents.Open("E:\Word\sp1.docx")
            Dim findobject As word.Find = objword.Selection.Find
            With findobject
                .ClearFormatting()
                .Text = "Name"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtNamaKaryawan.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Employee Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtEmpCode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Company Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtcompcode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Position"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtPosition.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'If Not IsNothing(objword) Then
            '    objword.Quit()
            '    objword = Nothing
            'End If
        End Try
    End Sub

    Private Sub sp3()
        Dim objword As word.Application = Nothing
        Try
            objword = New word.Application
            'Dim objdoc As word.Document
            objword.Documents.Open("E:\Word\sp1.docx")
            Dim findobject As word.Find = objword.Selection.Find
            With findobject
                .ClearFormatting()
                .Text = "Name"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtNamaKaryawan.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Employee Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtEmpCode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Company Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtcompcode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Position"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtPosition.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'If Not IsNothing(objword) Then
            '    objword.Quit()
            '    objword = Nothing
            'End If
        End Try
    End Sub

    Private Sub btnSP_Click_1(sender As Object, e As EventArgs) Handles btnSP.Click
        If barJudul.Caption = "Surat Peringatan 1" Then
            sp1()
        ElseIf barJudul.Caption = "Surat Peringatan 2" Then
            sp2()
        ElseIf barJudul.Caption = "Surat Peringatan 3" Then
            sp3()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub txtNamaKaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtNamaKaryawan.SelectedIndexChanged
        For indexing As Integer = 0 To tbl_par.Rows.Count - 1
            If txtNamaKaryawan.SelectedItem = tbl_par.Rows(indexing).Item(1).ToString() Then
                txtEmpCode.Text = tbl_par.Rows(indexing).Item(0).ToString()
                txtPosition.Text = tbl_par.Rows(indexing).Item(2).ToString()
                txtcompcode.Text = tbl_par.Rows(indexing).Item(3).ToString()
            End If
        Next
    End Sub
End Class