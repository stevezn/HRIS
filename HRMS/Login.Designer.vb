<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.teUsername = New DevExpress.XtraEditors.TextEdit()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.countButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 28)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Username"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 60)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Password"
        '
        'teUsername
        '
        Me.teUsername.Location = New System.Drawing.Point(75, 25)
        Me.teUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.teUsername.Name = "teUsername"
        Me.teUsername.Size = New System.Drawing.Size(187, 20)
        Me.teUsername.TabIndex = 1
        '
        'tePassword
        '
        Me.tePassword.Location = New System.Drawing.Point(75, 57)
        Me.tePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePassword.Size = New System.Drawing.Size(187, 20)
        Me.tePassword.TabIndex = 2
        '
        'countButton
        '
        Me.countButton.Image = CType(resources.GetObject("countButton.Image"), System.Drawing.Image)
        Me.countButton.Location = New System.Drawing.Point(237, 2)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(25, 18)
        Me.countButton.TabIndex = 69
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(75, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(123, 15)
        Me.LabelControl4.TabIndex = 70
        Me.LabelControl4.Text = "Sign In To Enter HRIS"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 84)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.tePassword)
        Me.Controls.Add(Me.teUsername)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.LookAndFeel.UseWindowsXPTheme = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Here"
        CType(Me.teUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents countButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
