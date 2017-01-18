Public Class PayrollSet
    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        barJudul.Caption = "BPJS"
        label.Text = "BPJS"
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        barJudul.Caption = "Jaminan Kecelakaan Kerja"
        label.Text = "Jaminan Kecelakaan Kerja"
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        barJudul.Caption = "Jaminan Kesehatan"
        label.Text = "Jaminan Kesehatan"
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        barJudul.Caption = "Iuran Pensiun"
        label.Text = "Iuran Pensiun"
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        barJudul.Caption = "Jaminan Hari Tua"
        label.Text = "Jaminan Hari Tua"
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        barJudul.Caption = "Biaya Jabatan"
        label.Text = "Biaya Jabatan"
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        barJudul.Caption = "Lates"
        label.Text = "Lates"
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        barJudul.Caption = "Jaminan kematian"
        label.Text = "Jaminan Kematian"
    End Sub

    Private Sub updates()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If barJudul.Caption = "BPJS" Then
            updates()
        ElseIf barJudul.Caption = "Jaminan Kecelakaan Kerja" Then
            updates()
        ElseIf barJudul.Caption = "Jaminan Kesehatan" Then
            updates()
        ElseIf barJudul.Caption = "Iuran Pensiun" Then
            updates()
        ElseIf barJudul.Caption = "Jaminan Hari Tua" Then
            updates()
        ElseIf barJudul.Caption = "Biaya Jabatan" Then
            updates()
        ElseIf barJudul.Caption = "Lates" Then
            updates()
        ElseIf barJudul.Caption = "Jaminan Kematian" Then
            updates()
        End If
    End Sub
End Class