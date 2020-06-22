Imports HZH_Controls.Controls
Imports HIS.LITE.Enums
Imports HZH_Controls
Imports HZH_Controls.Forms

Public Class MedicitonInfo
    Private ReadOnly _tableType As TableType
    Private ReadOnly _roleType As Role
    Private _datatable_source As DataTable

    Public Sub New(ByVal tableType As TableType, Optional ByVal roleType As Role = Role.Doctor)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me._tableType = tableType
        Me._roleType = roleType

        Me.LPatientInfo.Visible = False

        If _roleType = Role.Medicine Then
            Me.btnDetail.Location = Me.btnAddNew.Location
            Me.btnAddNew.Hide()
            Me.btnDelete.Hide()
        End If

    End Sub

    Private Sub InfoGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstCulumns As List(Of DataGridViewColumnEntity) = New List(Of DataGridViewColumnEntity)()
        Dim listCombox As List(Of DataGridViewColumnEntity) = New List(Of DataGridViewColumnEntity)()

        With listCombox
            .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Account",
                            .HeadText = "账号",
                            .Width = 200,
                            .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Name",
                            .HeadText = "姓名",
                            .Width = 100,
                            .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Sex",
                            .HeadText = "性别",
                            .Width = 50,
                            .WidthType = SizeType.Absolute,
                            .Format = Function(a) If((CInt(a)) = 0, "男", "女")})
            .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Height",
                            .HeadText = "身高",
                            .Width = 100,
                            .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Weight",
                            .HeadText = "体重",
                            .Width = 100,
                            .WidthType = SizeType.Absolute})
        End With


        Select Case Me._tableType
            Case TableType.MedicitonDoc
                With lstCulumns
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "PatientName",
                            .HeadText = "患者姓名",
                            .Width = 150,
                            .WidthType = SizeType.Absolute})
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "CreateTime",
                            .HeadText = "创建时间",
                            .Width = 150,
                            .WidthType = SizeType.Absolute,
                            .Format = Function(a) a.ToString.ToDate.ToString("yyyy-MM-dd")})
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Status",
                            .HeadText = "状态",
                            .Width = 100,
                            .WidthType = SizeType.Absolute,
                            .Format = Function(a) If((CInt(a)) = 0, "新建", "已完成")})
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Remark",
                            .HeadText = "备注",
                            .Width = 200,
                            .WidthType = SizeType.Absolute})
                End With
        End Select

        Me.combox_patient.GridColumns = listCombox
        Dim lstSourceGrid As List(Of Object) = New List(Of Object)
        lstSourceGrid = DBHelper.GetDataFromSQL("select * from UserInfo where Role=4").AsEnumerable.Select(Function(row) row).Cast(Of Object).ToList()
        Me.combox_patient.GridDataSource = lstSourceGrid
        Me.combox_patient.TextField = "Name"
        Me.ucDataGridView1.Columns = lstCulumns
        Me.ucDataGridView1.IsShowCheckBox = True
        Me.RefreshData()

    End Sub

    Private Sub RefreshData(Optional ByVal strFilter As String = "")
        Dim strSQL As String = "select MedicitonDoc.*,UserInfo.Name as PatientName " +
                             "from MedicitonDoc inner join UserInfo on MedicitonDoc.PatientID=UserInfo.ID"

        If strFilter <> "" Then
            strSQL += " and " + strFilter
        End If

        Me._datatable_source = DBHelper.GetDataFromSQL(strSQL)
        Me.ucDataGridView1.DataSource = _datatable_source
    End Sub

    Private Sub btnAdd_BtnClick(sender As Object, e As EventArgs) Handles btnDetail.BtnClick
        If _datatable_source Is Nothing Then
            Exit Sub
        End If

        Dim lstSelectID As List(Of DataRow) = Nothing
        lstSelectID = Me.ucDataGridView1.SelectRows.Select(Function(row) CType(row.DataSource, DataRow)).ToList
        Dim result As DialogResult

        If lstSelectID.Count <> 1 Then
            FrmDialog.ShowDialog(Me, "请选中一项要查看的项!")
        Else
            Select Case _tableType
                Case TableType.MedicitonDoc
                    Dim medictonDetailForm As MedictonDetailForm = New MedictonDetailForm(lstSelectID(0), Me._roleType, Me._tableType, Me.GetTitle(HandleType.Modify))
                    result = medictonDetailForm.ShowDialog()
            End Select
            If result = DialogResult.OK Then
                Me.RefreshData()
            End If
        End If
    End Sub

    Private Function GetTitle(ByVal handleType As Enums.HandleType) As String
        Dim strTitle As String = ""

        Select Case Me._tableType
            Case TableType.UserInfo
                If handleType = HandleType.Add Then
                    strTitle = "新增用户信息"
                Else
                    strTitle = "修改用户信息"
                End If
            Case TableType.MedicineInfo
                If handleType = HandleType.Add Then
                    strTitle = "新增药品信息"
                Else
                    strTitle = "修改药品信息"
                End If
            Case TableType.MedicitonDoc
                strTitle = "处方详情"
        End Select

        Return strTitle
    End Function

    Private Sub btnDelete_BtnClick(sender As Object, e As EventArgs) Handles btnDelete.BtnClick
        Dim result As DialogResult = FrmDialog.ShowDialog(Me, "确认删除选中数据吗",, True)

        If result <> DialogResult.OK Then
            Exit Sub
        End If

        Dim lstSelectID As List(Of Integer) = Nothing
        lstSelectID = Me.ucDataGridView1.SelectRows.Select(Function(row) CType(row.DataSource, DataRow).Item("Id").ToString.ToInt).ToList

        If lstSelectID.Count = 0 Then
            FrmDialog.ShowDialog(Me, "请至少选中一项要删除的项!")
        Else
            DBHelper.ExecuteSQL("delete from " + DataHelper.EnumName(_tableType) + " where Id in(" + String.Join(",", lstSelectID) + ")")
            Me.RefreshData()
        End If
    End Sub

    Private Sub btnModify_BtnClick(sender As Object, e As EventArgs)
        Dim lstSelectID As List(Of DataRow) = Nothing
        lstSelectID = Me.ucDataGridView1.SelectRows.Select(Function(row) CType(row.DataSource, DataRow)).ToList
        Dim result As DialogResult

        If lstSelectID.Count <> 1 Then
            FrmDialog.ShowDialog(Me, "请选中一项要修改的项!")
        Else
            Select Case _tableType
                Case TableType.UserInfo
                    Dim userInfoDetailForm As UserInfoDetailForm = New UserInfoDetailForm(lstSelectID(0), Me._tableType, Me.GetTitle(HandleType.Modify), HandleType.Modify)
                    result = userInfoDetailForm.ShowDialog()
                Case TableType.MedicineInfo
                    Dim medicineInfoDetailForm As MedicineDetailForm = New MedicineDetailForm(lstSelectID(0), Me._tableType, Me.GetTitle(HandleType.Modify), HandleType.Modify)
                    result = medicineInfoDetailForm.ShowDialog()
            End Select
            If result = DialogResult.OK Then
                Me.RefreshData()
            End If
        End If
    End Sub

    Private Sub ucComboxGrid1_SelectedChangedEvent(sender As Object, e As EventArgs) Handles combox_patient.SelectedChangedEvent
        Dim objRow As DataRow = CType(combox_patient.SelectSource, DataRow)
        If objRow IsNot Nothing Then
            Me.combox_patient.TextValue = objRow.Item("Name").ToString()
            Me.LPatientInfo.Visible = True
            Me.LPatientInfo.Text = "性别:" + If(objRow.Item("Sex").ToString = "0", "男", "女") + "  年龄:" + objRow.Item("Age").ToString
            Me.RefreshData("UserInfo.Id=" + objRow.Item("id").ToString())
        End If
    End Sub

    Private Sub btnAddNew_BtnClick(sender As Object, e As EventArgs) Handles btnAddNew.BtnClick
        If Me.combox_patient.SelectSource Is Nothing Then
            FrmDialog.ShowDialog(Me, "请先选择患者信息")
            Exit Sub
        End If

        Dim strSQL As String = "insert into MedicitonDoc (PatientID,CreateTime,Remark,Status) Values " +
             "(" + CType(Me.combox_patient.SelectSource, DataRow).Item("Id").ToString + ",'" + Now.ToString("yyyy-MM-dd") + "','',0)"

        If DBHelper.ExecuteSQL(strSQL) Then
            RefreshData()
        Else
            FrmDialog.ShowDialog(Me, "数据未添加成功,请检查!")
        End If

    End Sub
End Class
