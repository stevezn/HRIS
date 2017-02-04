<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtdate = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.txtdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(6, 37)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Properties.Caption = "Date"
        Me.txtdate.Size = New System.Drawing.Size(58, 19)
        Me.txtdate.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "To"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(171, 92)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(83, 23)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Process Now"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Range date to be shown of :"
        '
        'date1
        '
        Me.date1.Enabled = False
        Me.date1.Location = New System.Drawing.Point(54, 36)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(200, 20)
        Me.date1.TabIndex = 12
        '
        'date2
        '
        Me.date2.Enabled = False
        Me.date2.Location = New System.Drawing.Point(54, 62)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(200, 20)
        Me.date2.TabIndex = 13
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 127)
        Me.Controls.Add(Me.date2)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtdate)
        Me.MinimizeBox = False
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsForm"
        CType(Me.txtdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdate As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
End Class
