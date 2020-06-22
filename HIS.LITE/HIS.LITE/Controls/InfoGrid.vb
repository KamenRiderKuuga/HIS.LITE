Imports HZH_Controls.Controls
Imports HIS.LITE.Enums
Imports HZH_Controls
Imports HZH_Controls.Forms

Public Class InfoGrid
    Private ReadOnly _tableType As TableType
    Private ReadOnly _bolOnlyPatientInfo As Boolean
    Private _datatable_source As DataTable

    Public Sub New(ByVal tableType As TableType, Optional ByVal bolOnlyPatientInfo As Boolean = False)

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me._tableType = tableType
        Me._bolOnlyPatientInfo = bolOnlyPatientInfo
        Dim strSearchField As String = ""

        Select Case Me._tableType
            Case TableType.UserInfo
                strSearchField = "用户姓名"
            Case TableType.MedicineInfo
                strSearchField = "药品名称"
        End Select

        Me.textbox_Search.PromptText += strSearchField

        If Me._bolOnlyPatientInfo Then
            Me.panel_button.Hide()
            Me.ucDataGridView1.Size = New Size(739, 472)
        End If

    End Sub

    Private Sub InfoGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstCulumns As List(Of DataGridViewColumnEntity) = New List(Of DataGridViewColumnEntity)()

        Select Case Me._tableType
            Case TableType.UserInfo
                With lstCulumns
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
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Role",
                            .HeadText = "角色",
                            .Width = 100,
                            .WidthType = SizeType.Absolute,
                            .Format = Function(a)
                                          Select Case DirectCast(a, Integer)
                                              Case Role.Admin
                                                  Return "管理员"

                                              Case Role.Doctor
                                                  Return "医生"

                                              Case Role.Medicine
                                                  Return "药房"

                                              Case Role.Reception
                                                  Return "挂号处"

                                              Case Role.Patient
                                                  Return "患者信息"

                                              Case Else
                                                  Return ""

                                          End Select
                                      End Function})
                End With

            Case TableType.MedicineInfo
                With lstCulumns
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Name",
                            .HeadText = "药品名称",
                            .Width = 450,
                            .WidthType = SizeType.Absolute})
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Remaining",
                            .HeadText = "余量",
                            .Width = 100,
                            .WidthType = SizeType.Absolute})
                    .Add(New DataGridViewColumnEntity() With {
                            .DataField = "Price",
                            .HeadText = "价格",
                            .Width = 100,
                            .WidthType = SizeType.Absolute})
                End With
        End Select

        Me.ucDataGridView1.Columns = lstCulumns
        Me.ucDataGridView1.IsShowCheckBox = True
        Me.RefreshData()

    End Sub

    Private Sub RefreshData(Optional ByVal strFilter As String = "")
        Dim strSQL As String = "select * from " + DataHelper.EnumName(Me._tableType) + " Where 1=1"

        If strFilter <> "" Then
            strSQL += " and " + strFilter
        End If

        If _bolOnlyPatientInfo Then
            strSQL += " and Role=4"
        End If

        Me._datatable_source = DBHelper.GetDataFromSQL(strSQL)
        Me.ucDataGridView1.DataSource = _datatable_source
    End Sub

    Private Sub btnAdd_BtnClick(sender As Object, e As EventArgs) Handles btnAdd.BtnClick
        If _datatable_source Is Nothing Then
            Exit Sub
        End If

        Dim objRow As DataRow = DataHelper.GetNewRow(_datatable_source)

        Dim result As DialogResult
        Select Case _tableType
            Case TableType.UserInfo
                Dim userInfoDetailForm As UserInfoDetailForm = New UserInfoDetailForm(objRow, Me._tableType, Me.GetTitle(HandleType.Add), HandleType.Add)
                result = userInfoDetailForm.ShowDialog()
            Case TableType.MedicineInfo
                Dim medicineInfoDetailForm As MedicineDetailForm = New MedicineDetailForm(objRow, Me._tableType, Me.GetTitle(HandleType.Add), HandleType.Add)
                result = medicineInfoDetailForm.ShowDialog()
        End Select

        If result = DialogResult.OK Then
            Me.RefreshData()
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

    Private Sub btnModify_BtnClick(sender As Object, e As EventArgs) Handles btnModify.BtnClick
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

    Private Sub btnSearch_BtnClick(sender As Object, e As EventArgs) Handles btnSearch.BtnClick
        Dim strFilter As String = ""

        If Me.textbox_Search.InputText.Trim <> "" Then
            Select Case Me._tableType
                Case TableType.UserInfo
                    strFilter = "Name like'%" + Me.textbox_Search.InputText.Trim + "%'"
                Case TableType.MedicineInfo
                    strFilter = "Name like'%" + Me.textbox_Search.InputText.Trim + "%'"
            End Select
        End If

        Me.RefreshData(strFilter)

    End Sub
End Class
