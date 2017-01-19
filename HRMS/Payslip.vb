Imports System.Runtime.InteropServices
Imports word = Microsoft.Office.Interop.Word

Public Class Payslip
    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Dim tbl_par As New DataTable

    Sub loaddata()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        sqlcommand.CommandText = "SELECT EmployeeCode, FullName From db_payrolldata"
        sqlcommand.Connection = SQLConnection
        Dim adapter As New MySqlDataAdapter(sqlcommand.CommandText, SQLConnection)
        Dim cb As New MySqlCommandBuilder(adapter)
        adapter.Fill(tbl_par)
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            txtname.Properties.Items.Add(tbl_par.Rows(index).Item(1).ToString())
        Next
        SQLConnection.Close()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtname.SelectedIndexChanged
        For index As Integer = 0 To tbl_par.Rows.Count - 1
            If txtname.SelectedItem Is tbl_par.Rows(index).Item(1).ToString Then
                txtempcode.Text = tbl_par.Rows(index).Item(0).ToString
            End If
        Next
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
                .Replacement.Text = ""
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Employee Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = txtempcode.Text
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Company Code"
                .Replacement.ClearFormatting()
                .Replacement.Text = ""
                .Execute(Replace:=word.WdReplace.wdReplaceAll)
            End With
            With findobject
                .ClearFormatting()
                .Text = "Position"
                .Replacement.ClearFormatting()
                .Replacement.Text = ""
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


    Private Sub Payslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class