Public Class Report

    Private Sub txtdate_CheckedChanged(sender As Object, e As EventArgs) Handles txtdate.CheckedChanged
        If txtdate.Checked = True Then
            txtfrom.Enabled = True
            txtto.Enabled = True
        ElseIf txtdate.Checked = False Then
            txtfrom.Enabled = False
            txtto.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton4_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton4_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Dim form As New ReportsForm

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If form Is Nothing OrElse form.IsDisposed Then
            form = New ReportsForm
        End If
        form.Show()
    End Sub
End Class