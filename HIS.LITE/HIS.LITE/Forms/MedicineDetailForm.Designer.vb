<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicineDetailForm
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
        Me.textbox_Name = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Remaining = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Price = New HZH_Controls.Controls.UCTextBoxEx()
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
        Me.btnOK.Location = New System.Drawing.Point(98, 206)
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
        Me.btnCancel.Location = New System.Drawing.Point(329, 206)
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
        Me.textbox_Name.Location = New System.Drawing.Point(98, 90)
        Me.textbox_Name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Name.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Name.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Name.Name = "textbox_Name"
        Me.textbox_Name.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Name.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Name.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Name.PromptText = "药品名称"
        Me.textbox_Name.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Name.RectWidth = 1
        Me.textbox_Name.RegexPattern = ""
        Me.textbox_Name.Size = New System.Drawing.Size(415, 42)
        Me.textbox_Name.TabIndex = 10
        '
        'textbox_Remaining
        '
        Me.textbox_Remaining.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Remaining.ConerRadius = 5
        Me.textbox_Remaining.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Remaining.DecLength = 2
        Me.textbox_Remaining.FillColor = System.Drawing.Color.Empty
        Me.textbox_Remaining.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Remaining.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Remaining.InputText = ""
        Me.textbox_Remaining.InputType = HZH_Controls.TextInputType.PositiveInteger
        Me.textbox_Remaining.IsFocusColor = True
        Me.textbox_Remaining.IsRadius = True
        Me.textbox_Remaining.IsShowClearBtn = True
        Me.textbox_Remaining.IsShowKeyboard = True
        Me.textbox_Remaining.IsShowRect = True
        Me.textbox_Remaining.IsShowSearchBtn = False
        Me.textbox_Remaining.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Remaining.Location = New System.Drawing.Point(98, 142)
        Me.textbox_Remaining.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Remaining.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.textbox_Remaining.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Remaining.Name = "textbox_Remaining"
        Me.textbox_Remaining.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Remaining.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Remaining.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Remaining.PromptText = "余量"
        Me.textbox_Remaining.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Remaining.RectWidth = 1
        Me.textbox_Remaining.RegexPattern = ""
        Me.textbox_Remaining.Size = New System.Drawing.Size(194, 42)
        Me.textbox_Remaining.TabIndex = 13
        '
        'textbox_Price
        '
        Me.textbox_Price.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Price.ConerRadius = 5
        Me.textbox_Price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Price.DecLength = 2
        Me.textbox_Price.FillColor = System.Drawing.Color.Empty
        Me.textbox_Price.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Price.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Price.InputText = ""
        Me.textbox_Price.InputType = HZH_Controls.TextInputType.PositiveNumber
        Me.textbox_Price.IsFocusColor = True
        Me.textbox_Price.IsRadius = True
        Me.textbox_Price.IsShowClearBtn = True
        Me.textbox_Price.IsShowKeyboard = True
        Me.textbox_Price.IsShowRect = True
        Me.textbox_Price.IsShowSearchBtn = False
        Me.textbox_Price.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Price.Location = New System.Drawing.Point(321, 142)
        Me.textbox_Price.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Price.MaxValue = New Decimal(New Integer() {600, 0, 0, 0})
        Me.textbox_Price.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Price.Name = "textbox_Price"
        Me.textbox_Price.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Price.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Price.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Price.PromptText = "价格"
        Me.textbox_Price.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Price.RectWidth = 1
        Me.textbox_Price.RegexPattern = ""
        Me.textbox_Price.Size = New System.Drawing.Size(194, 42)
        Me.textbox_Price.TabIndex = 14
        '
        'MedicineDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 304)
        Me.Controls.Add(Me.textbox_Price)
        Me.Controls.Add(Me.textbox_Remaining)
        Me.Controls.Add(Me.textbox_Name)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "MedicineDetailForm"
        Me.Text = "登录窗体"
        Me.Title = "医院信息管理系统"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.textbox_Name, 0)
        Me.Controls.SetChildIndex(Me.textbox_Remaining, 0)
        Me.Controls.SetChildIndex(Me.textbox_Price, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnCancel As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Name As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Remaining As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Price As HZH_Controls.Controls.UCTextBoxEx
End Class
