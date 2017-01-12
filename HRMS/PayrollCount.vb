Public Class PayrollCount

    Dim connectionString As String = "Server=localhost; User Id=root; Password=; Database=db_hris"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()

    Dim datapayroll As NewSalary

    Public Sub updatechange()
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlcommand As New MySqlCommand
        Try
            sqlcommand.CommandText = "UPDATE db_payroll SET" +
                    " CompanyCode = @CompanyCode" +
                    ", FullName = @FullName" +
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
            sqlcommand.Connection = SQLConnection
            sqlcommand.Parameters.AddWithValue("@EmployeeCode", datapayroll.txtempcode.Text)
            sqlcommand.Parameters.AddWithValue("@CompanyCode", datapayroll.txtcompcode.Text)
            sqlcommand.Parameters.AddWithValue("@FullName", datapayroll.txtnames.Text)
            sqlcommand.Parameters.AddWithValue("@PaymentDate", datapayroll.txtpayment.Text)
            sqlcommand.Parameters.AddWithValue("@BasicRate", datapayroll.txtbasicrate.Text)
            sqlcommand.Parameters.AddWithValue("@Allowance", datapayroll.txtallowance.Text)
            sqlcommand.Parameters.AddWithValue("@Incentives", datapayroll.txtincentives.Text)
            sqlcommand.Parameters.AddWithValue("@TableMoney", datapayroll.txtmeal.Text)
            sqlcommand.Parameters.AddWithValue("@Transport", datapayroll.txttransport.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance1", datapayroll.txtdesc1.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance2", datapayroll.txtdesc2.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance3", datapayroll.txtdesc3.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance4", datapayroll.txtdesc4.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalAllowance5", datapayroll.txtdesc5.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance1", datapayroll.txtadd1.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance2", datapayroll.txtadd2.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance3", datapayroll.txtadd3.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance4", datapayroll.txtadd4.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalAllowance5", datapayroll.txtadd5.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeHours", datapayroll.txtothours.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeType", datapayroll.txtottype.Text)
            sqlcommand.Parameters.AddWithValue("@BpjsPercentage", datapayroll.txtbpjs.Text)
            sqlcommand.Parameters.AddWithValue("@Taxes", datapayroll.txttaxes.Text)
            sqlcommand.Parameters.AddWithValue("@Loan", datapayroll.txtloan.Text)
            sqlcommand.Parameters.AddWithValue("@Lates", datapayroll.txtlates.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction1", datapayroll.txtdesc11.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction2", datapayroll.txtdesc22.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction3", datapayroll.txtdesc33.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction4", datapayroll.txtdesc44.Text)
            sqlcommand.Parameters.AddWithValue("@OtherAdditionalDeduction5", datapayroll.txtdesc55.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction1", datapayroll.txtded1.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction2", datapayroll.txtded2.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction3", datapayroll.txtded3.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction4", datapayroll.txtded4.Text)
            sqlcommand.Parameters.AddWithValue("@AdditionalDeduction5", datapayroll.txtded5.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanKecelakaanKerja", datapayroll.txtjkk.Text)
            sqlcommand.Parameters.AddWithValue("@ResPremiJaminanKematian", datapayroll.txtpjk.Text)
            sqlcommand.Parameters.AddWithValue("@ResJaminanHariTua", datapayroll.txtjht.Text)
            sqlcommand.Parameters.AddWithValue("@ResBiayajabatan", datapayroll.txtbj.Text)
            sqlcommand.Parameters.AddWithValue("@ResIuranPensiun", datapayroll.txtip.Text)
            sqlcommand.Parameters.AddWithValue("@PersenKk", datapayroll.txtpkk.Text)
            sqlcommand.Parameters.AddWithValue("@PersenJk", datapayroll.txtppjk.Text)
            sqlcommand.Parameters.AddWithValue("@PersenJht", datapayroll.txtpjht.Text)
            sqlcommand.Parameters.AddWithValue("@PersenBj", datapayroll.txtpbj.Text)
            sqlcommand.Parameters.AddWithValue("@PersenIp", datapayroll.txtpip.Text)
            sqlcommand.Parameters.AddWithValue("@MemilikiNpwp", datapayroll.txtwp.Text)
            sqlcommand.Parameters.AddWithValue("@Gross", txtgross.Text)
            sqlcommand.Parameters.AddWithValue("@Bpjs", txtbpjs.Text)
            sqlcommand.Parameters.AddWithValue("@OvertimeSalary", txtots.Text)
            sqlcommand.Parameters.AddWithValue("@TotalDeductions", txtded.Text)
            sqlcommand.Parameters.AddWithValue("@Netincome", txtnetincome.Text)
            sqlcommand.Parameters.AddWithValue("@PenghasilanKenaPajak", txtpkp.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", txtjkk.Text)
            sqlcommand.Parameters.AddWithValue("@PremiJaminanKematian", txtpremi.Text)
            sqlcommand.Parameters.AddWithValue("@JaminanHariTua", txtjht.Text)
            sqlcommand.Parameters.AddWithValue("@PphTerhutang", txtpph.Text)
            sqlcommand.Parameters.AddWithValue("@BiayaJabatan", txtbj.Text)
            sqlcommand.Parameters.AddWithValue("@IuranPensiun", txtip.Text)
            sqlcommand.Parameters.AddWithValue("@NettoSetahun", txtnetto.Text)
            sqlcommand.Parameters.AddWithValue("@StatusWajibPajak", datapayroll.txtwp.Text)
            sqlcommand.Parameters.AddWithValue("@RapelFromMonth", datapayroll.frommonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelToMonth", datapayroll.tomonth.Text)
            sqlcommand.Parameters.AddWithValue("@RapelRate", datapayroll.txtrapel.Text)
            sqlcommand.Parameters.AddWithValue("@Rapel", txtrapel.Text)
            sqlcommand.Parameters.AddWithValue("@PajakPphPerTahun", txtpajak.Text)
            sqlcommand.Connection = SQLConnection
            sqlcommand.ExecuteNonQuery()
            MessageBox.Show("Data Successfully Changed!")
            SQLConnection.Close()
        Catch ex As Exception
            SQLConnection.Close()
            MsgBox("Error Occured: Could Not Change Records")
        End Try
    End Sub

    Public Function Insertpay() As Boolean
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Try
            str_carSql = "INSERT INTO db_payroll " +
                            "(EmployeeCode, CompanyCode, FullName, PaymentDate, BasicRate, Allowance, Incentives, TableMoney, Transport, OtherAdditionalAllowance1, OtherAdditionalAllowance2, OtherAdditionalAllowance3, OtherAdditionalAllowance4, OtherAdditionalAllowance5, AdditionalAllowance1, AdditionalAllowance2, AdditionalAllowance3, AdditionalAllowance4, AdditionalAllowance5, OvertimeHours, OvertimeType, BpjsPercentage, Taxes, Loan, Lates, OtherAdditionalDeduction1, OtherAdditionalDeduction2, OtherAdditionalDeduction3, OtherAdditionalDeduction4, OtherAdditionalDeduction5, AdditionalDeduction1, AdditionalDeduction2, AdditionalDeduction3, AdditionalDeduction4, AdditionalDeduction5, ResJaminanKecelakaanKerja, ResPremiJaminanKematian, ResJaminanHariTua, ResBiayaJabatan, ResIuranPensiun, PersenKk, PersenJk, PersenJht, PersenBj, PersenIp, MemilikiNpwp, Gross, Bpjs, OvertimeSalary, TotalDeductions, NetIncome, PenghasilanKenaPajak, JaminanKecelakaanKerja, PremiJaminanKematian, JaminanHariTua, PphTerhutang, BiayaJabatan, IuranPensiun, NettoSetahun, StatusWajibPajak, RapelFromMonth, RapelToMonth, RapelRate, Rapel, PajakPphPerTahun) " +
                            "values (@EmployeeCode, @CompanyCode, @FullName, @PaymentDate, @BasicRate, @Allowance, @Incentives, @TableMoney, @Transport, @OtherAdditionalAllowance1, @OtherAdditionalAllowance2, @OtherAdditionalAllowance3, @OtherAdditionalAllowance4, @OtherAdditionalAllowance5, @AdditionalAllowance1, @AdditionalAllowance2, @AdditionalAllowance3, @AdditionalAllowance4, @AdditionalAllowance5, @OvertimeHours, @OvertimeType, @BpjsPercentage, @Taxes, @Loan, @Lates, @OtherAdditionalDeduction1, @OtherAdditionalDeduction2, @OtherAdditionalDeduction3, @OtherAdditionalDeduction4, @OtherAdditionalDeduction5, @AdditionalDeduction1, @AdditionalDeduction2, @AdditionalDeduction3, @AdditionalDeduction4, @AdditionalDeduction5, @ResJaminanKecelakaanKerja, @ResPremiJaminanKematian, @ResJaminanHariTua, @ResBiayaJabatan, @ResIuranPensiun, @PersenKk, @PersenJk, @PersenJht, @PersenBj, @PersenIp, @MemilikiNpwp, @Gross, @Bpjs, @OvertimeSalary, @TotalDeductions, @NetIncome, @PenghasilanKenaPajak, @JaminanKecelakaanKerja, @PremiJaminanKematian, @JaminanHariTua, @PphTerhutang, @BiayaJabatan, @IuranPensiun, @NettoSetahun, @StatusWajibPajak, @RapelFromMonth, @RapelToMonth, @RapelRate, @Rapel, @PajakPphPerTahun)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", datapayroll.txtempcode.Text)
            sqlCommand.Parameters.AddWithValue("@CompanyCode", datapayroll.txtcompcode.Text)
            sqlCommand.Parameters.AddWithValue("@FullName", datapayroll.txtnames.Text)
            sqlCommand.Parameters.AddWithValue("@PaymentDate", datapayroll.txtpayment.Text)
            sqlCommand.Parameters.AddWithValue("@BasicRate", datapayroll.txtbasicrate.Text)
            sqlCommand.Parameters.AddWithValue("@Allowance", datapayroll.txtallowance.Text)
            sqlCommand.Parameters.AddWithValue("@Incentives", datapayroll.txtincentives.Text)
            sqlCommand.Parameters.AddWithValue("@TableMoney", datapayroll.txtmeal.Text)
            sqlCommand.Parameters.AddWithValue("@Transport", datapayroll.txttransport.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalAllowance1", datapayroll.txtdesc1.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalAllowance2", datapayroll.txtdesc2.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalAllowance3", datapayroll.txtdesc3.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalAllowance4", datapayroll.txtdesc4.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalAllowance5", datapayroll.txtdesc5.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalAllowance1", datapayroll.txtadd1.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalAllowance2", datapayroll.txtadd2.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalAllowance3", datapayroll.txtadd3.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalAllowance4", datapayroll.txtadd4.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalAllowance5", datapayroll.txtadd5.Text)
            sqlCommand.Parameters.AddWithValue("@OvertimeHours", datapayroll.txtothours.Text)
            sqlCommand.Parameters.AddWithValue("@OvertimeType", datapayroll.txtottype.Text)
            sqlCommand.Parameters.AddWithValue("@BpjsPercentage", datapayroll.txtbpjs.Text)
            sqlCommand.Parameters.AddWithValue("@Taxes", datapayroll.txttaxes.Text)
            sqlCommand.Parameters.AddWithValue("@Loan", datapayroll.txtloan.Text)
            sqlCommand.Parameters.AddWithValue("@Lates", datapayroll.txtlates.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalDeduction1", datapayroll.txtdesc11.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalDeduction2", datapayroll.txtdesc22.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalDeduction3", datapayroll.txtdesc33.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalDeduction4", datapayroll.txtdesc44.Text)
            sqlCommand.Parameters.AddWithValue("@OtherAdditionalDeduction5", datapayroll.txtdesc55.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalDeduction1", datapayroll.txtded1.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalDeduction2", datapayroll.txtded2.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalDeduction3", datapayroll.txtded3.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalDeduction4", datapayroll.txtded4.Text)
            sqlCommand.Parameters.AddWithValue("@AdditionalDeduction5", datapayroll.txtded5.Text)
            sqlCommand.Parameters.AddWithValue("@ResJaminanKecelakaanKerja", datapayroll.txtjkk.Text)
            sqlCommand.Parameters.AddWithValue("@ResPremiJaminanKematian", datapayroll.txtpjk.Text)
            sqlCommand.Parameters.AddWithValue("@ResJaminanHariTua", datapayroll.txtjht.Text)
            sqlCommand.Parameters.AddWithValue("@ResBiayajabatan", datapayroll.txtbj.Text)
            sqlCommand.Parameters.AddWithValue("@ResIuranPensiun", datapayroll.txtip.Text)
            sqlCommand.Parameters.AddWithValue("@PersenKk", datapayroll.txtpkk.Text)
            sqlCommand.Parameters.AddWithValue("@PersenJk", datapayroll.txtppjk.Text)
            sqlCommand.Parameters.AddWithValue("@PersenJht", datapayroll.txtpjht.Text)
            sqlCommand.Parameters.AddWithValue("@PersenBj", datapayroll.txtpbj.Text)
            sqlCommand.Parameters.AddWithValue("@PersenIp", datapayroll.txtpip.Text)
            sqlCommand.Parameters.AddWithValue("@MemilikiNpwp", datapayroll.txtwp.Text)
            sqlCommand.Parameters.AddWithValue("@Gross", txtgross.Text)
            sqlCommand.Parameters.AddWithValue("@Bpjs", txtbpjs.Text)
            sqlCommand.Parameters.AddWithValue("@OvertimeSalary", txtots.Text)
            sqlCommand.Parameters.AddWithValue("@TotalDeductions", txtded.Text)
            sqlCommand.Parameters.AddWithValue("@Netincome", txtnetincome.Text)
            sqlCommand.Parameters.AddWithValue("@PenghasilanKenaPajak", txtpkp.Text)
            sqlCommand.Parameters.AddWithValue("@JaminanKecelakaanKerja", txtjkk.Text)
            sqlCommand.Parameters.AddWithValue("@PremiJaminanKematian", txtpremi.Text)
            sqlCommand.Parameters.AddWithValue("@JaminanHariTua", txtjht.Text)
            sqlCommand.Parameters.AddWithValue("@PphTerhutang", txtpph.Text)
            sqlCommand.Parameters.AddWithValue("@BiayaJabatan", txtbj.Text)
            sqlCommand.Parameters.AddWithValue("@IuranPensiun", txtip.Text)
            sqlCommand.Parameters.AddWithValue("@NettoSetahun", txtnetto.Text)
            sqlCommand.Parameters.AddWithValue("@StatusWajibPajak", datapayroll.txtwp.Text)
            sqlCommand.Parameters.AddWithValue("@RapelFromMonth", datapayroll.frommonth.Text)
            sqlCommand.Parameters.AddWithValue("@RapelToMonth", datapayroll.tomonth.Text)
            sqlCommand.Parameters.AddWithValue("@RapelRate", datapayroll.txtrapel.Text)
            sqlCommand.Parameters.AddWithValue("@Rapel", txtrapel.Text)
            sqlCommand.Parameters.AddWithValue("@PajakPphPerTahun", txtpajak.Text)
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("Data Succesfully Added!")
            Return True
        Catch ex As Exception
            Return False
            MsgBox("Error Occured: Could Not Insert Records")
        End Try
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If datapayroll.barJudul.Caption = "Add Payroll Data" Then
            Insertpay()
        Else
            updatechange()
        End If
    End Sub
    Private Sub PayrollCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class