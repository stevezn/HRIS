Public Class ReportsForm
    Private Sub txtdate_CheckedChanged(sender As Object, e As EventArgs) Handles txtdate.CheckedChanged
        If txtdate.Checked = True Then
            date1.Enabled = True
            date2.Enabled = True
        ElseIf txtdate.Checked = False Then
            date1.Enabled = False
            date2.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton1_MouseHover(sender As Object, e As EventArgs) Handles SimpleButton1.MouseHover
        'ListBoxControl1.Visible = True
    End Sub


    Private Sub SimpleButton1_MouseLeave(sender As Object, e As EventArgs) Handles SimpleButton1.MouseLeave
        'ListBoxControl1.Visible = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If ListBoxControl1.Visible = True Then
            ListBoxControl1.Visible = False
        ElseIf ListBoxControl1.Visible = False Then
            ListBoxControl1.Visible = True
        End If
    End Sub
End Class