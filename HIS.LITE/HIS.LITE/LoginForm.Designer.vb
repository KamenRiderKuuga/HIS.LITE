<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits HZH_Controls.Forms.FrmWithTitle

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogin = New HZH_Controls.Controls.UCBtnExt()
        Me.btnExit = New HZH_Controls.Controls.UCBtnExt()
        Me.textbox_Accout = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Password = New HZH_Controls.Controls.UCTextBoxEx()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BtnBackColor = System.Drawing.Color.White
        Me.btnLogin.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.BtnForeColor = System.Drawing.Color.White
        Me.btnLogin.BtnText = "登  录"
        Me.btnLogin.ConerRadius = 5
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.EnabledMouseEffect = False
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.IsRadius = True
        Me.btnLogin.IsShowRect = True
        Me.btnLogin.IsShowTips = False
        Me.btnLogin.Location = New System.Drawing.Point(98, 298)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnLogin.RectWidth = 1
        Me.btnLogin.Size = New System.Drawing.Size(184, 60)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.TabStop = False
        Me.btnLogin.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogin.TipsText = ""
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.BtnBackColor = System.Drawing.Color.White
        Me.btnExit.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.BtnForeColor = System.Drawing.Color.White
        Me.btnExit.BtnText = "退  出"
        Me.btnExit.ConerRadius = 5
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.EnabledMouseEffect = False
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.IsRadius = True
        Me.btnExit.IsShowRect = True
        Me.btnExit.IsShowTips = False
        Me.btnExit.Location = New System.Drawing.Point(329, 298)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnExit.RectWidth = 1
        Me.btnExit.Size = New System.Drawing.Size(184, 60)
        Me.btnExit.TabIndex = 8
        Me.btnExit.TabStop = False
        Me.btnExit.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnExit.TipsText = ""
        '
        'textbox_Accout
        '
        Me.textbox_Accout.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Accout.ConerRadius = 5
        Me.textbox_Accout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Accout.DecLength = 2
        Me.textbox_Accout.FillColor = System.Drawing.Color.Empty
        Me.textbox_Accout.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Accout.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Accout.InputText = ""
        Me.textbox_Accout.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Accout.IsFocusColor = True
        Me.textbox_Accout.IsRadius = True
        Me.textbox_Accout.IsShowClearBtn = True
        Me.textbox_Accout.IsShowKeyboard = True
        Me.textbox_Accout.IsShowRect = True
        Me.textbox_Accout.IsShowSearchBtn = False
        Me.textbox_Accout.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Accout.Location = New System.Drawing.Point(98, 90)
        Me.textbox_Accout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Accout.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Accout.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Accout.Name = "textbox_Accout"
        Me.textbox_Accout.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Accout.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Accout.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Accout.PromptText = "账号"
        Me.textbox_Accout.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Accout.RectWidth = 1
        Me.textbox_Accout.RegexPattern = ""
        Me.textbox_Accout.Size = New System.Drawing.Size(415, 42)
        Me.textbox_Accout.TabIndex = 10
        '
        'textbox_Password
        '
        Me.textbox_Password.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Password.ConerRadius = 5
        Me.textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Password.DecLength = 2
        Me.textbox_Password.FillColor = System.Drawing.Color.Empty
        Me.textbox_Password.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Password.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Password.InputText = ""
        Me.textbox_Password.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Password.IsFocusColor = True
        Me.textbox_Password.IsRadius = True
        Me.textbox_Password.IsShowClearBtn = True
        Me.textbox_Password.IsShowKeyboard = True
        Me.textbox_Password.IsShowRect = True
        Me.textbox_Password.IsShowSearchBtn = False
        Me.textbox_Password.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Password.Location = New System.Drawing.Point(98, 174)
        Me.textbox_Password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Password.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Password.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Password.Name = "textbox_Password"
        Me.textbox_Password.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Password.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Password.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Password.PromptText = "密码"
        Me.textbox_Password.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Password.RectWidth = 1
        Me.textbox_Password.RegexPattern = ""
        Me.textbox_Password.Size = New System.Drawing.Size(415, 42)
        Me.textbox_Password.TabIndex = 11
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 424)
        Me.Controls.Add(Me.textbox_Password)
        Me.Controls.Add(Me.textbox_Accout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "LoginForm"
        Me.Text = "登录窗体"
        Me.Title = "医院信息管理系统"
        Me.Controls.SetChildIndex(Me.btnLogin, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.textbox_Accout, 0)
        Me.Controls.SetChildIndex(Me.textbox_Password, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnExit As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Accout As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Password As HZH_Controls.Controls.UCTextBoxEx
End Class
