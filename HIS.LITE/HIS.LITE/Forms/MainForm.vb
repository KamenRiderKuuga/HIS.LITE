Imports HZH_Controls.Controls
Imports HIS.LITE.Enums
Imports HZH_Controls

Public Class MainForm
    Inherits HZH_Controls.Forms.FrmWithTitle

    Private ReadOnly _userInfo As DataRow

    Public Sub New(ByVal userInfo As DataRow)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Title = "欢迎您," + userInfo.Field(Of String)("Name") + "!"
        Me._userInfo = userInfo
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objMenuList As List(Of String) = New List(Of String)
        Select Case Me._userInfo.Item("Role").ToString.ToInt
            Case Enums.Role.Admin
                objMenuList = New List(Of String)({"人员管理", "药品管理", "退出登录"})
            Case Enums.Role.Doctor
                objMenuList = New List(Of String)({"患者信息", "开具处方", "退出登录"})
            Case Enums.Role.Medicine
                objMenuList = New List(Of String)({"费用结算", "退出登录"})
        End Select

        For Each strMenu As String In objMenuList
            Me.tvMenu.Nodes.Add("      " + strMenu)
        Next
    End Sub

    Private Sub tvMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvMenu.AfterSelect
        panControl.Controls.Clear()
        Dim strName As String = e.Node.Text.Trim()

        Select Case strName
            Case "人员管理"
                AddControl(New InfoGrid(TableType.UserInfo))
            Case "药品管理"
                AddControl(New InfoGrid(TableType.MedicineInfo))
            Case "患者信息"
                AddControl(New InfoGrid(TableType.UserInfo, True))
            Case "开具处方"
                AddControl(New MedicitonInfo(TableType.MedicitonDoc))
            Case "费用结算"
                AddControl(New MedicitonInfo(TableType.MedicitonDoc, Role.Medicine))
            Case "退出登录"
                Me.Close()

        End Select
    End Sub

    Private Sub AddControl(ByVal control As Control)
        Me.panControl.Controls.Add(control)
    End Sub


End Class