<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InfoGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Me.ucDataGridView1 = New HZH_Controls.Controls.UCDataGridView()
        Me.panControl = New System.Windows.Forms.Panel()
        Me.btnSearch = New HZH_Controls.Controls.UCBtnExt()
        Me.textbox_Search = New HZH_Controls.Controls.UCTextBoxEx()
        Me.btnAdd = New HZH_Controls.Controls.UCBtnExt()
        Me.btnDelete = New HZH_Controls.Controls.UCBtnExt()
        Me.btnModify = New HZH_Controls.Controls.UCBtnExt()
        Me.panel_button = New System.Windows.Forms.Panel()
        Me.panControl.SuspendLayout()
        Me.panel_button.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucDataGridView1
        '
        Me.ucDataGridView1.BackColor = System.Drawing.Color.White
        Me.ucDataGridView1.Columns = Nothing
        Me.ucDataGridView1.DataSource = Nothing
        Me.ucDataGridView1.HeadFont = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.ucDataGridView1.HeadHeight = 40
        Me.ucDataGridView1.HeadPadingLeft = 0
        Me.ucDataGridView1.HeadTextColor = System.Drawing.Color.Black
        Me.ucDataGridView1.IsShowCheckBox = False
        Me.ucDataGridView1.IsShowHead = True
        Me.ucDataGridView1.Location = New System.Drawing.Point(0, 90)
        Me.ucDataGridView1.Name = "ucDataGridView1"
        Me.ucDataGridView1.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.ucDataGridView1.RowHeight = 41
        Me.ucDataGridView1.RowType = GetType(HZH_Controls.Controls.UCDataGridViewRow)
        Me.ucDataGridView1.Size = New System.Drawing.Size(739, 343)
        Me.ucDataGridView1.TabIndex = 5
        '
        'panControl
        '
        Me.panControl.AutoScroll = True
        Me.panControl.BackColor = System.Drawing.Color.White
        Me.panControl.Controls.Add(Me.btnSearch)
        Me.panControl.Controls.Add(Me.textbox_Search)
        Me.panControl.Controls.Add(Me.panel_button)
        Me.panControl.Controls.Add(Me.ucDataGridView1)
        Me.panControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panControl.Location = New System.Drawing.Point(0, 0)
        Me.panControl.Name = "panControl"
        Me.panControl.Size = New System.Drawing.Size(739, 562)
        Me.panControl.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BtnBackColor = System.Drawing.Color.White
        Me.btnSearch.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.BtnForeColor = System.Drawing.Color.White
        Me.btnSearch.BtnText = "查找"
        Me.btnSearch.ConerRadius = 5
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.EnabledMouseEffect = False
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSearch.IsRadius = True
        Me.btnSearch.IsShowRect = True
        Me.btnSearch.IsShowTips = False
        Me.btnSearch.Location = New System.Drawing.Point(554, 40)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSearch.RectWidth = 1
        Me.btnSearch.Size = New System.Drawing.Size(126, 42)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.TabStop = False
        Me.btnSearch.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnSearch.TipsText = ""
        '
        'textbox_Search
        '
        Me.textbox_Search.BackColor = System.Drawing.Color.Transparent
        Me.textbox_Search.ConerRadius = 5
        Me.textbox_Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox_Search.DecLength = 2
        Me.textbox_Search.FillColor = System.Drawing.Color.Empty
        Me.textbox_Search.FocusBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.textbox_Search.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Search.InputText = ""
        Me.textbox_Search.InputType = HZH_Controls.TextInputType.NotControl
        Me.textbox_Search.IsFocusColor = True
        Me.textbox_Search.IsRadius = True
        Me.textbox_Search.IsShowClearBtn = True
        Me.textbox_Search.IsShowKeyboard = True
        Me.textbox_Search.IsShowRect = True
        Me.textbox_Search.IsShowSearchBtn = False
        Me.textbox_Search.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN
        Me.textbox_Search.Location = New System.Drawing.Point(56, 40)
        Me.textbox_Search.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textbox_Search.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.textbox_Search.MinValue = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.textbox_Search.Name = "textbox_Search"
        Me.textbox_Search.Padding = New System.Windows.Forms.Padding(5)
        Me.textbox_Search.PromptColor = System.Drawing.Color.Gray
        Me.textbox_Search.PromptFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.textbox_Search.PromptText = "请输入要搜索的"
        Me.textbox_Search.RectColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.textbox_Search.RectWidth = 1
        Me.textbox_Search.RegexPattern = ""
        Me.textbox_Search.Size = New System.Drawing.Size(415, 42)
        Me.textbox_Search.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BtnBackColor = System.Drawing.Color.White
        Me.btnAdd.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.BtnForeColor = System.Drawing.Color.White
        Me.btnAdd.BtnText = "新 增"
        Me.btnAdd.ConerRadius = 5
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.EnabledMouseEffect = False
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAdd.IsRadius = True
        Me.btnAdd.IsShowRect = True
        Me.btnAdd.IsShowTips = False
        Me.btnAdd.Location = New System.Drawing.Point(56, 36)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAdd.RectWidth = 1
        Me.btnAdd.Size = New System.Drawing.Size(126, 53)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.TabStop = False
        Me.btnAdd.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAdd.TipsText = ""
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.BtnBackColor = System.Drawing.Color.White
        Me.btnDelete.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.BtnForeColor = System.Drawing.Color.White
        Me.btnDelete.BtnText = "删 除"
        Me.btnDelete.ConerRadius = 5
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.EnabledMouseEffect = False
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.IsRadius = True
        Me.btnDelete.IsShowRect = True
        Me.btnDelete.IsShowTips = False
        Me.btnDelete.Location = New System.Drawing.Point(303, 36)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDelete.RectWidth = 1
        Me.btnDelete.Size = New System.Drawing.Size(128, 53)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.TabStop = False
        Me.btnDelete.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.TipsText = ""
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.White
        Me.btnModify.BtnBackColor = System.Drawing.Color.White
        Me.btnModify.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnModify.BtnForeColor = System.Drawing.Color.White
        Me.btnModify.BtnText = "修改"
        Me.btnModify.ConerRadius = 5
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.EnabledMouseEffect = False
        Me.btnModify.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnModify.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnModify.IsRadius = True
        Me.btnModify.IsShowRect = True
        Me.btnModify.IsShowTips = False
        Me.btnModify.Location = New System.Drawing.Point(554, 36)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(0)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnModify.RectWidth = 1
        Me.btnModify.Size = New System.Drawing.Size(128, 53)
        Me.btnModify.TabIndex = 10
        Me.btnModify.TabStop = False
        Me.btnModify.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnModify.TipsText = ""
        '
        'panel_button
        '
        Me.panel_button.AutoScroll = True
        Me.panel_button.BackColor = System.Drawing.Color.White
        Me.panel_button.Controls.Add(Me.btnModify)
        Me.panel_button.Controls.Add(Me.btnDelete)
        Me.panel_button.Controls.Add(Me.btnAdd)
        Me.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_button.Location = New System.Drawing.Point(0, 433)
        Me.panel_button.Name = "panel_button"
        Me.panel_button.Size = New System.Drawing.Size(739, 129)
        Me.panel_button.TabIndex = 11
        '
        'InfoGrid
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.panControl)
        Me.Name = "InfoGrid"
        Me.Size = New System.Drawing.Size(739, 562)
        Me.panControl.ResumeLayout(False)
        Me.panel_button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ucDataGridView1 As HZH_Controls.Controls.UCDataGridView
    Private WithEvents panControl As Panel
    Friend WithEvents btnSearch As HZH_Controls.Controls.UCBtnExt
    Private WithEvents textbox_Search As HZH_Controls.Controls.UCTextBoxEx
    Private WithEvents panel_button As Panel
    Friend WithEvents btnModify As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnDelete As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnAdd As HZH_Controls.Controls.UCBtnExt
End Class
