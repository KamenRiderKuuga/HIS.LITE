<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedictonDetailForm
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
        Me.textbox_Remark = New HZH_Controls.Controls.UCTextBoxEx()
        Me.ucDataGridView1 = New HZH_Controls.Controls.UCDataGridView()
        Me.combox_medicine = New HZH_Controls.Controls.UCComboxGrid()
        Me.btnAdd = New HZH_Controls.Controls.UCBtnExt()
        Me.textbox_Num = New HZH_Controls.Controls.UCTextBoxEx()
        Me.textbox_Dosage = New HZH_Controls.Controls.UCTextBoxEx()
        Me.btnRemove = New HZH_Controls.Controls.UCBtnExt()
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
        Me.btnOK.Location = New System.Drawing.Point(24, 490)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnOK.RectWidth = 1
        Me.btnOK.Size = New System.Drawing.Size(149, 60)
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
        Me.btnCancel.Location = New System.Drawing.Point(424, 490)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnCancel.RectWidth = 1
        Me.btnCancel.Size = New System.Drawing.Size(166, 60)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.TabStop = False
        Me.btnCancel.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCancel.TipsText = ""
        '
        'textbox_Remark
        '
        Me.textbox_Remark.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Remark.ConerRadius = 5
        Me.textbox_Remark.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Remark.DecLength = 2
        Me.textbox_Remark.FillColor = System.Drawing.Color.Empty
        Me.textbox_Remark.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Remark.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Remark.InputText = ""
        Me.textbox_Remark.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Remark.IsFocusColor = True
        Me.textbox_Remark.IsRadius = True
        Me.textbox_Remark.IsShowClearBtn = True
        Me.textbox_Remark.IsShowKeyboard = True
        Me.textbox_Remark.IsShowRect = True
        Me.textbox_Remark.IsShowSearchBtn = False
        Me.textbox_Remark.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Remark.Location = New System.Drawing.Point(24, 374)
        Me.textbox_Remark.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Remark.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Remark.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Remark.Name = "textbox_Remark"
        Me.textbox_Remark.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Remark.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Remark.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Remark.PromptText = "备注"
        Me.textbox_Remark.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Remark.RectWidth = 1
        Me.textbox_Remark.RegexPattern = ""
        Me.textbox_Remark.Size = New System.Drawing.Size(566, 42)
        Me.textbox_Remark.TabIndex = 10
        '
        'ucDataGridView1
        '
        Me.ucDataGridView1.BackColor = System.Drawing.Color.White
        Me.ucDataGridView1.Columns = Nothing
        Me.ucDataGridView1.DataSource = Nothing
        Me.ucDataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ucDataGridView1.HeadFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ucDataGridView1.HeadHeight = 40
        Me.ucDataGridView1.HeadPadingLeft = 0
        Me.ucDataGridView1.HeadTextColor = System.Drawing.Color.Black
        Me.ucDataGridView1.IsShowCheckBox = False
        Me.ucDataGridView1.IsShowHead = True
        Me.ucDataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.ucDataGridView1.Name = "ucDataGridView1"
        Me.ucDataGridView1.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.ucDataGridView1.RowHeight = 41
        Me.ucDataGridView1.RowType = GetType(HZH_Controls.Controls.UCDataGridViewRow)
        Me.ucDataGridView1.Size = New System.Drawing.Size(613, 305)
        Me.ucDataGridView1.TabIndex = 11
        '
        'combox_medicine
        '
        Me.combox_medicine.BackColor = System.Drawing.Color.Transparent
        Me.combox_medicine.BackColorExt = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_medicine.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_medicine.ConerRadius = 5
        Me.combox_medicine.DropPanelHeight = -1
        Me.combox_medicine.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_medicine.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.combox_medicine.GridColumns = Nothing
        Me.combox_medicine.GridDataSource = Nothing
        Me.combox_medicine.GridRowType = GetType(HZH_Controls.Controls.UCDataGridViewRow)
        Me.combox_medicine.IsRadius = False
        Me.combox_medicine.IsShowRect = True
        Me.combox_medicine.ItemWidth = 70
        Me.combox_medicine.Location = New System.Drawing.Point(24, 423)
        Me.combox_medicine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combox_medicine.Name = "combox_medicine"
        Me.combox_medicine.RectColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_medicine.RectWidth = 1
        Me.combox_medicine.SelectedIndex = -1
        Me.combox_medicine.SelectedValue = ""
        Me.combox_medicine.SelectSource = Nothing
        Me.combox_medicine.Size = New System.Drawing.Size(149, 42)
        Me.combox_medicine.Source = Nothing
        Me.combox_medicine.TabIndex = 15
        Me.combox_medicine.TextField = "Name"
        Me.combox_medicine.TextValue = Nothing
        Me.combox_medicine.TriangleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BtnBackColor = System.Drawing.Color.White
        Me.btnAdd.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.BtnForeColor = System.Drawing.Color.White
        Me.btnAdd.BtnText = "增加"
        Me.btnAdd.ConerRadius = 5
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.EnabledMouseEffect = False
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.IsRadius = True
        Me.btnAdd.IsShowRect = True
        Me.btnAdd.IsShowTips = False
        Me.btnAdd.Location = New System.Drawing.Point(218, 490)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAdd.RectWidth = 1
        Me.btnAdd.Size = New System.Drawing.Size(77, 60)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.TabStop = False
        Me.btnAdd.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.TipsText = ""
        '
        'textbox_Num
        '
        Me.textbox_Num.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Num.ConerRadius = 5
        Me.textbox_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Num.DecLength = 2
        Me.textbox_Num.FillColor = System.Drawing.Color.Empty
        Me.textbox_Num.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Num.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Num.InputText = ""
        Me.textbox_Num.InputType = HZH_Controls.TextInputType.PositiveInteger
        Me.textbox_Num.IsFocusColor = True
        Me.textbox_Num.IsRadius = True
        Me.textbox_Num.IsShowClearBtn = True
        Me.textbox_Num.IsShowKeyboard = True
        Me.textbox_Num.IsShowRect = True
        Me.textbox_Num.IsShowSearchBtn = False
        Me.textbox_Num.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Num.Location = New System.Drawing.Point(218, 423)
        Me.textbox_Num.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Num.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.textbox_Num.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Num.Name = "textbox_Num"
        Me.textbox_Num.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Num.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Num.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Num.PromptText = "数量"
        Me.textbox_Num.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Num.RectWidth = 1
        Me.textbox_Num.RegexPattern = ""
        Me.textbox_Num.Size = New System.Drawing.Size(167, 42)
        Me.textbox_Num.TabIndex = 17
        '
        'textbox_Dosage
        '
        Me.textbox_Dosage.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Dosage.ConerRadius = 5
        Me.textbox_Dosage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Dosage.DecLength = 2
        Me.textbox_Dosage.FillColor = System.Drawing.Color.Empty
        Me.textbox_Dosage.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Dosage.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Dosage.InputText = ""
        Me.textbox_Dosage.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Dosage.IsFocusColor = True
        Me.textbox_Dosage.IsRadius = True
        Me.textbox_Dosage.IsShowClearBtn = True
        Me.textbox_Dosage.IsShowKeyboard = True
        Me.textbox_Dosage.IsShowRect = True
        Me.textbox_Dosage.IsShowSearchBtn = False
        Me.textbox_Dosage.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Dosage.Location = New System.Drawing.Point(424, 423)
        Me.textbox_Dosage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Dosage.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Dosage.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Dosage.Name = "textbox_Dosage"
        Me.textbox_Dosage.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Dosage.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Dosage.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Dosage.PromptText = "用法用量"
        Me.textbox_Dosage.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Dosage.RectWidth = 1
        Me.textbox_Dosage.RegexPattern = ""
        Me.textbox_Dosage.Size = New System.Drawing.Size(166, 42)
        Me.textbox_Dosage.TabIndex = 18
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.BtnBackColor = System.Drawing.Color.White
        Me.btnRemove.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRemove.BtnForeColor = System.Drawing.Color.White
        Me.btnRemove.BtnText = "移除"
        Me.btnRemove.ConerRadius = 5
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.EnabledMouseEffect = False
        Me.btnRemove.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRemove.IsRadius = True
        Me.btnRemove.IsShowRect = True
        Me.btnRemove.IsShowTips = False
        Me.btnRemove.Location = New System.Drawing.Point(307, 490)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRemove.RectWidth = 1
        Me.btnRemove.Size = New System.Drawing.Size(78, 60)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.TabStop = False
        Me.btnRemove.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnRemove.TipsText = ""
        '
        'MedictonDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 596)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.textbox_Dosage)
        Me.Controls.Add(Me.textbox_Num)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.combox_medicine)
        Me.Controls.Add(Me.ucDataGridView1)
        Me.Controls.Add(Me.textbox_Remark)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "MedictonDetailForm"
        Me.Text = "登录窗体"
        Me.Title = "医院信息管理系统"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.textbox_Remark, 0)
        Me.Controls.SetChildIndex(Me.ucDataGridView1, 0)
        Me.Controls.SetChildIndex(Me.combox_medicine, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.Controls.SetChildIndex(Me.textbox_Num, 0)
        Me.Controls.SetChildIndex(Me.textbox_Dosage, 0)
        Me.Controls.SetChildIndex(Me.btnRemove, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnCancel As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Remark As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents ucDataGridView1 As HZH_Controls.Controls.UCDataGridView
    Private WithEvents combox_medicine As HZH_Controls.Controls.UCComboxGrid
    Friend WithEvents btnAdd As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Num As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents textbox_Dosage As HZH_Controls.Controls.UCTextBoxEx
    Friend WithEvents btnRemove As HZH_Controls.Controls.UCBtnExt
End Class
