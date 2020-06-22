<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicitonInfo
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
        Me.panControl = New System.Windows.Forms.Panel()
        Me.LPatientName = New System.Windows.Forms.Label()
        Me.LPatientInfo = New System.Windows.Forms.Label()
        Me.combox_patient = New HZH_Controls.Controls.UCComboxGrid()
        Me.panel_button = New System.Windows.Forms.Panel()
        Me.btnDelete = New HZH_Controls.Controls.UCBtnExt()
        Me.btnDetail = New HZH_Controls.Controls.UCBtnExt()
        Me.ucDataGridView1 = New HZH_Controls.Controls.UCDataGridView()
        Me.btnAddNew = New HZH_Controls.Controls.UCBtnExt()
        Me.panControl.SuspendLayout()
        Me.panel_button.SuspendLayout()
        Me.SuspendLayout()
        '
        'panControl
        '
        Me.panControl.AutoScroll = True
        Me.panControl.BackColor = System.Drawing.Color.White
        Me.panControl.Controls.Add(Me.LPatientName)
        Me.panControl.Controls.Add(Me.LPatientInfo)
        Me.panControl.Controls.Add(Me.combox_patient)
        Me.panControl.Controls.Add(Me.panel_button)
        Me.panControl.Controls.Add(Me.ucDataGridView1)
        Me.panControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panControl.Location = New System.Drawing.Point(0, 0)
        Me.panControl.Name = "panControl"
        Me.panControl.Size = New System.Drawing.Size(739, 562)
        Me.panControl.TabIndex = 11
        '
        'LPatientName
        '
        Me.LPatientName.AutoSize = True
        Me.LPatientName.BackColor = System.Drawing.Color.Transparent
        Me.LPatientName.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.LPatientName.Location = New System.Drawing.Point(66, 51)
        Me.LPatientName.Name = "LPatientName"
        Me.LPatientName.Size = New System.Drawing.Size(116, 31)
        Me.LPatientName.TabIndex = 16
        Me.LPatientName.Text = "患者姓名:"
        '
        'LPatientInfo
        '
        Me.LPatientInfo.AutoSize = True
        Me.LPatientInfo.BackColor = System.Drawing.Color.Transparent
        Me.LPatientInfo.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.LPatientInfo.Location = New System.Drawing.Point(356, 51)
        Me.LPatientInfo.Name = "LPatientInfo"
        Me.LPatientInfo.Size = New System.Drawing.Size(88, 31)
        Me.LPatientInfo.TabIndex = 15
        Me.LPatientInfo.Text = "Label1"
        '
        'combox_patient
        '
        Me.combox_patient.BackColor = System.Drawing.Color.Transparent
        Me.combox_patient.BackColorExt = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_patient.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combox_patient.ConerRadius = 5
        Me.combox_patient.DropPanelHeight = -1
        Me.combox_patient.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_patient.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.combox_patient.GridColumns = Nothing
        Me.combox_patient.GridDataSource = Nothing
        Me.combox_patient.GridRowType = GetType(HZH_Controls.Controls.UCDataGridViewRow)
        Me.combox_patient.IsRadius = False
        Me.combox_patient.IsShowRect = True
        Me.combox_patient.ItemWidth = 70
        Me.combox_patient.Location = New System.Drawing.Point(189, 51)
        Me.combox_patient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.combox_patient.Name = "combox_patient"
        Me.combox_patient.RectColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.combox_patient.RectWidth = 1
        Me.combox_patient.SelectedIndex = -1
        Me.combox_patient.SelectedValue = ""
        Me.combox_patient.SelectSource = Nothing
        Me.combox_patient.Size = New System.Drawing.Size(149, 32)
        Me.combox_patient.Source = Nothing
        Me.combox_patient.TabIndex = 14
        Me.combox_patient.TextField = "Name"
        Me.combox_patient.TextValue = Nothing
        Me.combox_patient.TriangleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        '
        'panel_button
        '
        Me.panel_button.AutoScroll = True
        Me.panel_button.BackColor = System.Drawing.Color.White
        Me.panel_button.Controls.Add(Me.btnAddNew)
        Me.panel_button.Controls.Add(Me.btnDelete)
        Me.panel_button.Controls.Add(Me.btnDetail)
        Me.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_button.Location = New System.Drawing.Point(0, 433)
        Me.panel_button.Name = "panel_button"
        Me.panel_button.Size = New System.Drawing.Size(739, 129)
        Me.panel_button.TabIndex = 11
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
        Me.btnDelete.Location = New System.Drawing.Point(521, 36)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDelete.RectWidth = 1
        Me.btnDelete.Size = New System.Drawing.Size(126, 53)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.TabStop = False
        Me.btnDelete.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDelete.TipsText = ""
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.White
        Me.btnDetail.BtnBackColor = System.Drawing.Color.White
        Me.btnDetail.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDetail.BtnForeColor = System.Drawing.Color.White
        Me.btnDetail.BtnText = "详 情"
        Me.btnDetail.ConerRadius = 5
        Me.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetail.EnabledMouseEffect = False
        Me.btnDetail.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnDetail.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDetail.IsRadius = True
        Me.btnDetail.IsShowRect = True
        Me.btnDetail.IsShowTips = False
        Me.btnDetail.Location = New System.Drawing.Point(56, 36)
        Me.btnDetail.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDetail.RectWidth = 1
        Me.btnDetail.Size = New System.Drawing.Size(126, 53)
        Me.btnDetail.TabIndex = 8
        Me.btnDetail.TabStop = False
        Me.btnDetail.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDetail.TipsText = ""
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
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.White
        Me.btnAddNew.BtnBackColor = System.Drawing.Color.White
        Me.btnAddNew.BtnFont = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAddNew.BtnForeColor = System.Drawing.Color.White
        Me.btnAddNew.BtnText = "新 增"
        Me.btnAddNew.ConerRadius = 5
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.EnabledMouseEffect = False
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnAddNew.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAddNew.IsRadius = True
        Me.btnAddNew.IsShowRect = True
        Me.btnAddNew.IsShowTips = False
        Me.btnAddNew.Location = New System.Drawing.Point(291, 36)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAddNew.RectWidth = 1
        Me.btnAddNew.Size = New System.Drawing.Size(126, 53)
        Me.btnAddNew.TabIndex = 10
        Me.btnAddNew.TabStop = False
        Me.btnAddNew.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddNew.TipsText = ""
        '
        'MedicitonInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.panControl)
        Me.Name = "MedicitonInfo"
        Me.Size = New System.Drawing.Size(739, 562)
        Me.panControl.ResumeLayout(False)
        Me.panControl.PerformLayout()
        Me.panel_button.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panControl As Panel
    Private WithEvents panel_button As Panel
    Friend WithEvents btnDelete As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents btnDetail As HZH_Controls.Controls.UCBtnExt
    Private WithEvents ucDataGridView1 As HZH_Controls.Controls.UCDataGridView
    Private WithEvents combox_patient As HZH_Controls.Controls.UCComboxGrid
    Friend WithEvents LPatientInfo As Label
    Friend WithEvents LPatientName As Label
    Friend WithEvents btnAddNew As HZH_Controls.Controls.UCBtnExt
End Class
