<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInfoDetailForm
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
        Me.btnOK = New HZH_Controls.Controls.UCBtnExt()
        Me.btnCancel = New HZH_Controls.Controls.UCBtnExt()
        Me.textbox_Accout = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Password = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Name = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Age = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Height = New HZH_Controls.Controls.UCTextBoxEx()
        Me.combox_Sex = New HZH_Controls.Controls.UCCombox()
        Me.combox_Role = New HZH_Controls.Controls.UCCombox()
        Me.textbox_Weight = New HZH_Controls.Controls.UCTextBoxEx()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.White
        Me.btnOK.BtnBackColor = System.Drawing.Color.White
        Me.btnOK.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK.BtnForeColor = System.Drawing.Color.White
        Me.btnOK.BtnText = "确认"
        Me.btnOK.ConerRadius = 5
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.EnabledMouseEffect = False
        Me.btnOK.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnOK.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK.IsRadius = True
        Me.btnOK.IsShowRect = True
        Me.btnOK.IsShowTips = False
        Me.btnOK.Location = New System.Drawing.Point(98, 385)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnOK.RectWidth = 1
        Me.btnOK.Size = New System.Drawing.Size(184, 60)
        Me.btnOK.TabIndex = 7
        Me.btnOK.TabStop = False
        Me.btnOK.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnOK.TipsText = ""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.BtnBackColor = System.Drawing.Color.White
        Me.btnCancel.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.BtnForeColor = System.Drawing.Color.White
        Me.btnCancel.BtnText = "取  消"
        Me.btnCancel.ConerRadius = 5
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.EnabledMouseEffect = False
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCancel.IsRadius = True
        Me.btnCancel.IsShowRect = True
        Me.btnCancel.IsShowTips = False
        Me.btnCancel.Location = New System.Drawing.Point(329, 385)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCancel.RectWidth = 1
        Me.btnCancel.Size = New System.Drawing.Size(184, 60)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.TabStop = False
        Me.btnCancel.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCancel.TipsText = ""
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
        Me.textbox_Password.Location = New System.Drawing.Point(98, 142)
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
        'textbox_Name
        '
        Me.textbox_Name.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Name.ConerRadius = 5
        Me.textbox_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Name.DecLength = 2
        Me.textbox_Name.FillColor = System.Drawing.Color.Empty
        Me.textbox_Name.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Name.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Name.InputText = ""
        Me.textbox_Name.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Name.IsFocusColor = True
        Me.textbox_Name.IsRadius = True
        Me.textbox_Name.IsShowClearBtn = True
        Me.textbox_Name.IsShowKeyboard = True
        Me.textbox_Name.IsShowRect = True
        Me.textbox_Name.IsShowSearchBtn = False
        Me.textbox_Name.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Name.Location = New System.Drawing.Point(98, 194)
        Me.textbox_Name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Name.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Name.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Name.Name = "textbox_Name"
        Me.textbox_Name.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Name.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Name.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Name.PromptText = "姓名"
        Me.textbox_Name.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Name.RectWidth = 1
        Me.textbox_Name.RegexPattern = ""
        Me.textbox_Name.Size = New System.Drawing.Size(194, 42)
        Me.textbox_Name.TabIndex = 12
        '
        'textbox_Age
        '
        Me.textbox_Age.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Age.ConerRadius = 5
        Me.textbox_Age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Age.DecLength = 2
        Me.textbox_Age.FillColor = System.Drawing.Color.Empty
        Me.textbox_Age.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Age.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Age.InputText = ""
        Me.textbox_Age.InputType = HZH_Controls.TextInputType.PositiveInteger
        Me.textbox_Age.IsFocusColor = True
        Me.textbox_Age.IsRadius = True
        Me.textbox_Age.IsShowClearBtn = True
        Me.textbox_Age.IsShowKeyboard = True
        Me.textbox_Age.IsShowRect = True
        Me.textbox_Age.IsShowSearchBtn = False
        Me.textbox_Age.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Age.Location = New System.Drawing.Point(98, 246)
        Me.textbox_Age.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Age.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.textbox_Age.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Age.Name = "textbox_Age"
        Me.textbox_Age.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Age.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Age.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Age.PromptText = "年龄"
        Me.textbox_Age.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Age.RectWidth = 1
        Me.textbox_Age.RegexPattern = ""
        Me.textbox_Age.Size = New System.Drawing.Size(194, 42)
        Me.textbox_Age.TabIndex = 13
        '
        'textbox_Height
        '
        Me.textbox_Height.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Height.ConerRadius = 5
        Me.textbox_Height.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Height.DecLength = 2
        Me.textbox_Height.FillColor = System.Drawing.Color.Empty
        Me.textbox_Height.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Height.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Height.InputText = ""
        Me.textbox_Height.InputType = HZH_Controls.TextInputType.PositiveNumber
        Me.textbox_Height.IsFocusColor = True
        Me.textbox_Height.IsRadius = True
        Me.textbox_Height.IsShowClearBtn = True
        Me.textbox_Height.IsShowKeyboard = True
        Me.textbox_Height.IsShowRect = True
        Me.textbox_Height.IsShowSearchBtn = False
        Me.textbox_Height.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Height.Location = New System.Drawing.Point(98, 298)
        Me.textbox_Height.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Height.MaxValue = New Decimal(New Integer() {600, 0, 0, 0})
        Me.textbox_Height.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Height.Name = "textbox_Height"
        Me.textbox_Height.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Height.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Height.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Height.PromptText = "身高(cm)"
        Me.textbox_Height.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Height.RectWidth = 1
        Me.textbox_Height.RegexPattern = ""
        Me.textbox_Height.Size = New System.Drawing.Size(194, 42)
        Me.textbox_Height.TabIndex = 14
        '
        'combox_Sex
        '
        Me.combox_Sex.BackColor = System.Drawing.Color.Transparent
        Me.combox_Sex.BackColorExt = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Sex.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_Sex.ConerRadius = 5
        Me.combox_Sex.DropPanelHeight = -1
        Me.combox_Sex.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Sex.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.combox_Sex.IsRadius = False
        Me.combox_Sex.IsShowRect = True
        Me.combox_Sex.ItemWidth = 70
        Me.combox_Sex.Location = New System.Drawing.Point(321, 194)
        Me.combox_Sex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combox_Sex.Name = "combox_Sex"
        Me.combox_Sex.RectColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Sex.RectWidth = 1
        Me.combox_Sex.SelectedIndex = -1
        Me.combox_Sex.SelectedValue = ""
        Me.combox_Sex.Size = New System.Drawing.Size(192, 42)
        Me.combox_Sex.Source = Nothing
        Me.combox_Sex.TabIndex = 15
        Me.combox_Sex.TextValue = Nothing
        Me.combox_Sex.TriangleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        '
        'combox_Role
        '
        Me.combox_Role.BackColor = System.Drawing.Color.Transparent
        Me.combox_Role.BackColorExt = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Role.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_Role.ConerRadius = 5
        Me.combox_Role.DropPanelHeight = -1
        Me.combox_Role.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Role.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.combox_Role.IsRadius = False
        Me.combox_Role.IsShowRect = True
        Me.combox_Role.ItemWidth = 70
        Me.combox_Role.Location = New System.Drawing.Point(321, 246)
        Me.combox_Role.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combox_Role.Name = "combox_Role"
        Me.combox_Role.RectColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_Role.RectWidth = 1
        Me.combox_Role.SelectedIndex = -1
        Me.combox_Role.SelectedValue = ""
        Me.combox_Role.Size = New System.Drawing.Size(192, 42)
        Me.combox_Role.Source = Nothing
        Me.combox_Role.TabIndex = 16
        Me.combox_Role.TextValue = Nothing
        Me.combox_Role.TriangleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        '
        'textbox_Weight
        '
        Me.textbox_Weight.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Weight.ConerRadius = 5
        Me.textbox_Weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Weight.DecLength = 2
        Me.textbox_Weight.FillColor = System.Drawing.Color.Empty
        Me.textbox_Weight.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Weight.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Weight.InputText = ""
        Me.textbox_Weight.InputType = HZH_Controls.TextInputType.PositiveNumber
        Me.textbox_Weight.IsFocusColor = True
        Me.textbox_Weight.IsRadius = True
        Me.textbox_Weight.IsShowClearBtn = True
        Me.textbox_Weight.IsShowKeyboard = True
        Me.textbox_Weight.IsShowRect = True
        Me.textbox_Weight.IsShowSearchBtn = False
        Me.textbox_Weight.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Weight.Location = New System.Drawing.Point(321, 298)
        Me.textbox_Weight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Weight.MaxValue = New Decimal(New Integer() {600, 0, 0, 0})
        Me.textbox_Weight.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Weight.Name = "textbox_Weight"
        Me.textbox_Weight.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Weight.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Weight.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Weight.PromptText = "体重(kg)"
        Me.textbox_Weight.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Weight.RectWidth = 1
        Me.textbox_Weight.RegexPattern = ""
        Me.textbox_Weight.Size = New System.Drawing.Size(192, 42)
        Me.textbox_Weight.TabIndex = 17
        '
        'UserInfoDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 498)
        Me.Controls.Add(Me.textbox_Weight)
        Me.Controls.Add(Me.combox_Role)
        Me.Controls.Add(Me.combox_Sex)
        Me.Controls.Add(Me.textbox_Height)
        Me.Controls.Add(Me.textbox_Age)
        Me.Controls.Add(Me.textbox_Name)
        Me.Controls.Add(Me.textbox_Password)
        Me.Controls.Add(Me.textbox_Accout)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "UserInfoDetailForm"
        Me.Text = "登录窗体"
        Me.Title = "医院信息管理系统"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.textbox_Accout, 0)
        Me.Controls.SetChildIndex(Me.textbox_Password, 0)
        Me.Controls.SetChildIndex(Me.textbox_Name, 0)
        Me.Controls.SetChildIndex(Me.textbox_Age, 0)
        Me.Controls.SetChildIndex(Me.textbox_Height, 0)
        Me.Controls.SetChildIndex(Me.combox_Sex, 0)
        Me.Controls.SetChildIndex(Me.combox_Role, 0)
        Me.Controls.SetChildIndex(Me.textbox_Weight, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnCancel As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Accout As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Password As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Name As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Age As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Height As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents combox_Sex As HZH_Controls.Controls.UCCombox
    Private WithEvents combox_Role As HZH_Controls.Controls.UCCombox
    Private WithEvents textbox_Weight As HZH_Controls.Controls.UCTextBoxEx
End Class
