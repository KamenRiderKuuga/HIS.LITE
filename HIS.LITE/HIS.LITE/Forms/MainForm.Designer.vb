<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tvMenu = New HZH_Controls.Controls.TreeViewEx()
        Me.panControl = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'tvMenu
        '
        Me.tvMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll
        Me.tvMenu.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.tvMenu.FullRowSelect = True
        Me.tvMenu.HideSelection = False
        Me.tvMenu.IsShowByCustomModel = True
        Me.tvMenu.IsShowTip = False
        Me.tvMenu.ItemHeight = 50
        Me.tvMenu.Location = New System.Drawing.Point(0, 61)
        Me.tvMenu.LstTips = CType(resources.GetObject("tvMenu.LstTips"), System.Collections.Generic.Dictionary(Of String, String))
        Me.tvMenu.Name = "tvMenu"
        Me.tvMenu.NodeBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tvMenu.NodeDownPic = CType(resources.GetObject("tvMenu.NodeDownPic"), System.Drawing.Image)
        Me.tvMenu.NodeForeColor = System.Drawing.Color.White
        Me.tvMenu.NodeHeight = 50
        Me.tvMenu.NodeIsShowSplitLine = True
        Me.tvMenu.NodeSelectedColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tvMenu.NodeSelectedForeColor = System.Drawing.Color.White
        Me.tvMenu.NodeSplitLineColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tvMenu.NodeUpPic = CType(resources.GetObject("tvMenu.NodeUpPic"), System.Drawing.Image)
        Me.tvMenu.ParentNodeCanSelect = True
        Me.tvMenu.ShowLines = False
        Me.tvMenu.ShowPlusMinus = False
        Me.tvMenu.ShowRootLines = False
        Me.tvMenu.Size = New System.Drawing.Size(208, 562)
        Me.tvMenu.TabIndex = 8
        Me.tvMenu.TipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tvMenu.TipImage = CType(resources.GetObject("tvMenu.TipImage"), System.Drawing.Image)
        '
        'panControl
        '
        Me.panControl.AutoScroll = True
        Me.panControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panControl.Location = New System.Drawing.Point(208, 61)
        Me.panControl.Name = "panControl"
        Me.panControl.Size = New System.Drawing.Size(739, 562)
        Me.panControl.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 623)
        Me.Controls.Add(Me.panControl)
        Me.Controls.Add(Me.tvMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.ShowInTaskbar = True
        Me.Text = "MainForm"
        Me.Controls.SetChildIndex(Me.tvMenu, 0)
        Me.Controls.SetChildIndex(Me.panControl, 0)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tvMenu As HZH_Controls.Controls.TreeViewEx
    Private WithEvents panControl As Panel
End Class
