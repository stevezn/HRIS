<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClosePayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClosePayroll))
        Me.LayoutControl8 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtempcode = New DevExpress.XtraEditors.TextEdit()
        Me.radioloadall = New System.Windows.Forms.RadioButton()
        Me.radiochoose = New System.Windows.Forms.RadioButton()
        Me.txtname = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.bonuscheck = New DevExpress.XtraEditors.CheckEdit()
        Me.thrcheck = New DevExpress.XtraEditors.CheckEdit()
        Me.payrollcheck = New DevExpress.XtraEditors.CheckEdit()
        Me.ComboBoxEdit7 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcpaydate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lcempname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.LayoutControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl8.SuspendLayout()
        CType(Me.txtempcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bonuscheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thrcheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollcheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcpaydate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcempname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl8
        '
        Me.LayoutControl8.Controls.Add(Me.txtempcode)
        Me.LayoutControl8.Controls.Add(Me.radioloadall)
        Me.LayoutControl8.Controls.Add(Me.radiochoose)
        Me.LayoutControl8.Controls.Add(Me.txtname)
        Me.LayoutControl8.Controls.Add(Me.bonuscheck)
        Me.LayoutControl8.Controls.Add(Me.thrcheck)
        Me.LayoutControl8.Controls.Add(Me.payrollcheck)
        Me.LayoutControl8.Controls.Add(Me.ComboBoxEdit7)
        Me.LayoutControl8.Controls.Add(Me.DateEdit1)
        Me.LayoutControl8.Controls.Add(Me.LabelControl3)
        Me.LayoutControl8.Controls.Add(Me.LabelControl2)
        Me.LayoutControl8.Location = New System.Drawing.Point(2, -6)
        Me.LayoutControl8.Name = "LayoutControl8"
        Me.LayoutControl8.Root = Me.LayoutControlGroup8
        Me.LayoutControl8.Size = New System.Drawing.Size(267, 286)
        Me.LayoutControl8.TabIndex = 2
        Me.LayoutControl8.Text = "LayoutControl8"
        '
        'txtempcode
        '
        Me.txtempcode.Location = New System.Drawing.Point(91, 65)
        Me.txtempcode.Name = "txtempcode"
        Me.txtempcode.Size = New System.Drawing.Size(164, 20)
        Me.txtempcode.StyleController = Me.LayoutControl8
        Me.txtempcode.TabIndex = 17
        '
        'radioloadall
        '
        Me.radioloadall.Location = New System.Drawing.Point(12, 89)
        Me.radioloadall.Name = "radioloadall"
        Me.radioloadall.Size = New System.Drawing.Size(243, 25)
        Me.radioloadall.TabIndex = 16
        Me.radioloadall.TabStop = True
        Me.radioloadall.Text = "Load All Employee"
        Me.radioloadall.UseVisualStyleBackColor = True
        '
        'radiochoose
        '
        Me.radiochoose.Location = New System.Drawing.Point(12, 12)
        Me.radiochoose.Name = "radiochoose"
        Me.radiochoose.Size = New System.Drawing.Size(243, 25)
        Me.radiochoose.TabIndex = 15
        Me.radiochoose.TabStop = True
        Me.radiochoose.Text = "Choose Employee"
        Me.radiochoose.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(91, 41)
        Me.txtname.Name = "txtname"
        Me.txtname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtname.Size = New System.Drawing.Size(164, 20)
        Me.txtname.StyleController = Me.LayoutControl8
        Me.txtname.TabIndex = 6
        '
        'bonuscheck
        '
        Me.bonuscheck.Location = New System.Drawing.Point(12, 182)
        Me.bonuscheck.Name = "bonuscheck"
        Me.bonuscheck.Properties.Caption = "Process Bonus"
        Me.bonuscheck.Size = New System.Drawing.Size(243, 19)
        Me.bonuscheck.StyleController = Me.LayoutControl8
        Me.bonuscheck.TabIndex = 14
        '
        'thrcheck
        '
        Me.thrcheck.Location = New System.Drawing.Point(12, 159)
        Me.thrcheck.Name = "thrcheck"
        Me.thrcheck.Properties.Caption = "Process THR"
        Me.thrcheck.Size = New System.Drawing.Size(243, 19)
        Me.thrcheck.StyleController = Me.LayoutControl8
        Me.thrcheck.TabIndex = 13
        '
        'payrollcheck
        '
        Me.payrollcheck.Location = New System.Drawing.Point(12, 136)
        Me.payrollcheck.Name = "payrollcheck"
        Me.payrollcheck.Properties.Caption = "Process Payroll"
        Me.payrollcheck.Size = New System.Drawing.Size(243, 19)
        Me.payrollcheck.StyleController = Me.LayoutControl8
        Me.payrollcheck.TabIndex = 12
        '
        'ComboBoxEdit7
        '
        Me.ComboBoxEdit7.Location = New System.Drawing.Point(91, 249)
        Me.ComboBoxEdit7.Name = "ComboBoxEdit7"
        Me.ComboBoxEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit7.Properties.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBoxEdit7.Size = New System.Drawing.Size(164, 20)
        Me.ComboBoxEdit7.StyleController = Me.LayoutControl8
        Me.ComboBoxEdit7.TabIndex = 11
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(91, 225)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DateEdit1.Size = New System.Drawing.Size(164, 20)
        Me.DateEdit1.StyleController = Me.LayoutControl8
        Me.DateEdit1.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 205)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 16)
        Me.LabelControl3.StyleController = Me.LayoutControl8
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Salary"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 118)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl2.StyleController = Me.LayoutControl8
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Action"
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.CustomizationFormText = "LayoutControlGroup8"
        Me.LayoutControlGroup8.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup8.GroupBordersVisible = False
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18, Me.LayoutControlItem20, Me.lcpaydate, Me.LayoutControlItem56, Me.LayoutControlItem1, Me.LayoutControlItem10, Me.LayoutControlItem16, Me.lcempname, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(267, 286)
        Me.LayoutControlGroup8.Text = "LayoutControlGroup8"
        Me.LayoutControlGroup8.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.LabelControl2
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(247, 18)
        Me.LayoutControlItem18.Text = "LayoutControlItem18"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextToControlDistance = 0
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.LabelControl3
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 193)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(247, 20)
        Me.LayoutControlItem20.Text = "LayoutControlItem20"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextToControlDistance = 0
        Me.LayoutControlItem20.TextVisible = False
        '
        'lcpaydate
        '
        Me.lcpaydate.Control = Me.DateEdit1
        Me.lcpaydate.CustomizationFormText = "Payment Date :"
        Me.lcpaydate.Location = New System.Drawing.Point(0, 213)
        Me.lcpaydate.Name = "lcpaydate"
        Me.lcpaydate.Size = New System.Drawing.Size(247, 24)
        Me.lcpaydate.Text = "Payment Date :"
        Me.lcpaydate.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.ComboBoxEdit7
        Me.LayoutControlItem56.CustomizationFormText = "Salary Period :"
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 237)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(247, 29)
        Me.LayoutControlItem56.Text = "Salary Period :"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.payrollcheck
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(247, 23)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.thrcheck
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(247, 23)
        Me.LayoutControlItem10.Text = "LayoutControlItem10"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.bonuscheck
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(247, 23)
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'lcempname
        '
        Me.lcempname.Control = Me.txtname
        Me.lcempname.CustomizationFormText = "Employee Name"
        Me.lcempname.Location = New System.Drawing.Point(0, 29)
        Me.lcempname.Name = "lcempname"
        Me.lcempname.Size = New System.Drawing.Size(247, 24)
        Me.lcempname.Text = "Employee Name"
        Me.lcempname.TextSize = New System.Drawing.Size(76, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.radiochoose
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(247, 29)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.radioloadall
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 77)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(247, 29)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtempcode
        Me.LayoutControlItem4.CustomizationFormText = "Employee Code"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(247, 24)
        Me.LayoutControlItem4.Text = "Employee Code"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(76, 13)
        '
        'btnProcess
        '
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.Location = New System.Drawing.Point(120, 269)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(137, 33)
        Me.btnProcess.TabIndex = 3
        Me.btnProcess.Text = "Proccess Now"
        '
        'ClosePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 304)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.LayoutControl8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClosePayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClosePayroll"
        CType(Me.LayoutControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl8.ResumeLayout(False)
        CType(Me.txtempcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bonuscheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thrcheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollcheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcpaydate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcempname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl8 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents bonuscheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents thrcheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents payrollcheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ComboBoxEdit7 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lcpaydate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtname As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lcempname As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents radioloadall As RadioButton
    Friend WithEvents radiochoose As RadioButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtempcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
