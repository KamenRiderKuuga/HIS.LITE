Imports System.Diagnostics.Eventing.Reader
Imports System.Linq
Imports System.Security.Cryptography
Imports HZH_Controls
Imports HZH_Controls.Controls
Imports HZH_Controls.Forms

Public Class MedictonDetailForm
    Inherits HZH_Controls.Forms.FrmWithTitle

    Private ReadOnly _objRowDoc As DataRow
    Private ReadOnly _roleType As Enums.Role
    Private ReadOnly _tableType As Enums.TableType
    Private _datatable_source As DataTable

    Public Sub New(ByVal objRowDoc As DataRow, ByVal roleType As Enums.Role, ByVal tableType As Enums.TableType, ByVal strTitleName As String)

        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Title = strTitleName
        Me.IsShowCloseBtn = True
        Me._objRowDoc = objRowDoc
        Me._roleType = roleType
        Me._tableType = tableType

        Me.textbox_Dosage.txtInput.MaxLength = 30

        Dim listCombox As List(Of DataGridViewColumnEntity) = New List(Of DataGridViewColumnEntity)()
        Dim lstCulumns As List(Of DataGridViewColumnEntity) = New List(Of DataGridViewColumnEntity)()

        With listCombox
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

        With lstCulumns
            .Add(New DataGridViewColumnEntity() With {
                    .DataField = "Name",
                    .HeadText = "药品名称",
                    .Width = 200,
                    .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                    .DataField = "Number",
                    .HeadText = "数量",
                    .Width = 100,
                    .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                    .DataField = "Dosage",
                    .HeadText = "用法用量",
                    .Width = 150,
                    .WidthType = SizeType.Absolute})
            .Add(New DataGridViewColumnEntity() With {
                    .DataField = "Price",
                    .HeadText = "价格",
                    .Width = 100,
                    .WidthType = SizeType.Absolute})
        End With

        If Me._roleType = Enums.Role.Medicine Then
            btnAdd.Hide()
            btnRemove.Hide()
            Me.btnOK.BtnText = "结算费用"
        End If

        If Me._objRowDoc.Item("Status").ToString.ToInt = Enums.Status.IsCompleted Then
            btnOK.Hide()
        End If

        Me.combox_medicine.GridColumns = listCombox
        Dim lstSourceGrid As List(Of Object) = New List(Of Object)
        lstSourceGrid = DBHelper.GetDataFromSQL("select * from MedicineInfo").AsEnumerable.Select(Function(row) row).Cast(Of Object).ToList()
        Me.combox_medicine.GridDataSource = lstSourceGrid
        Me.combox_medicine.TextField = "Name"

        Me.ucDataGridView1.Columns = lstCulumns
        Me.ucDataGridView1.IsShowCheckBox = True

        Me.FillControlsWithDataRow()
        Me.RefreshData()

    End Sub

    Private Sub RefreshData(Optional ByVal strFilter As String = "")
        Dim strSQL As String = "select MedicineInfo.Name,MedicineInfo.Price,MedicitonList.*" +
                             "from MedicitonList left join MedicineInfo on MedicitonList.MedicineID=MedicineInfo.ID"

        If strFilter <> "" Then
            strSQL += " and " + strFilter
        End If

        Me._datatable_source = DBHelper.GetDataFromSQL(strSQL)
        Me.ucDataGridView1.DataSource = _datatable_source
    End Sub

    Private Sub btnOK_BtnClick(sender As Object, e As EventArgs) Handles btnOK.BtnClick
        Dim bolResult As Boolean = False

        If Me._roleType = Enums.Role.Doctor Then
            If Not CheckMustEnter() Then
                Exit Sub
            End If

            Me.GetValueFromContorls()

            DBHelper.InsertRowToDB(DataHelper.EnumName(Me._tableType), Me._objRowDoc)

            bolResult = Me.UpdateDBFromView()
        Else
            If Me._datatable_source Is Nothing OrElse Me._datatable_source.Rows.Count = 0 Then
                FrmDialog.ShowDialog(Me, "当前处方单没有任何详情需要结算")
                Exit Sub
            End If

            Dim strTotal As String = Me._datatable_source.AsEnumerable.Sum(Function(row) row.Item("Number").ToString.ToDecimal * row.Item("Price").ToString.ToDecimal).ToString

            Dim strMessage As String = "合计金额:" + strTotal + "元,是否确认结算?"

            If FrmDialog.ShowDialog(Me, strMessage, "", True) = DialogResult.OK Then
                Me._objRowDoc.Item("Status") = Enums.Status.IsCompleted
                bolResult = DBHelper.InsertRowToDB(DataHelper.EnumName(Me._tableType), Me._objRowDoc)
            End If
        End If

        If bolResult Then
            Dim strMessage As String = "操作成功"

            FrmDialog.ShowDialog(Me, strMessage)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Function UpdateDBFromView() As Boolean
        Dim strSQL As String = "delete from MedicitonList where DocID = " + _objRowDoc.Item("Id").ToString + vbCrLf

        For Each objRow As DataRow In Me._datatable_source.Rows
            If objRow.RowState = DataRowState.Deleted Then
                Continue For
            End If

            strSQL += "insert into MedicitonList (MedicineId,Number,Dosage,DocID) Values "
            strSQL += "(" + objRow.Item("MedicineId").ToString + ",'" + objRow.Item("Number").ToString + "','" + objRow.Item("Dosage").ToString + "'," + _objRowDoc.Item("ID").ToString + ")" + vbCrLf

        Next

        Return DBHelper.ExecuteSQL(strSQL)

    End Function

    Private Function CheckAccount(ByVal strAccount As String, ByRef intID As Integer) As Boolean
        Dim datatable_Result As DataTable = DBHelper.GetDataFromSQL("select * from " + DataHelper.EnumName(Me._tableType) + " order by Id desc")
        If datatable_Result Is Nothing OrElse datatable_Result.Rows.Count = 0 Then
            intID = 1
            Return True
        Else
            If datatable_Result.AsEnumerable().Where(Function(row) row.Item("Account").ToString() = strAccount).FirstOrDefault() IsNot Nothing Then
                Return False
            Else
                intID = datatable_Result.Rows(0).Item("Id").ToString.ToInt + 1
                Return True
            End If
        End If
    End Function

    Private Sub GetValueFromContorls()
        Me._objRowDoc.Item("Remark") = Me.textbox_Remark.txtInput.Text.Trim
    End Sub

    Private Sub FillControlsWithDataRow()
        Me.textbox_Remark.txtInput.Text = Me._objRowDoc.Item("Remark")
    End Sub

    Private Function CheckMustEnter() As Boolean
        For Each contorl As Control In Me.Controls
            If contorl.GetType() Is GetType(UCTextBoxEx) Then
                If CType(contorl, UCTextBoxEx).txtInput.Text.Trim.Length = 0 Then
                    FrmDialog.ShowDialog(Me, CType(contorl, UCTextBoxEx).PromptText + "尚未输入,请检查!")
                    Return False
                End If
            End If
        Next

        If combox_medicine.TextValue Is Nothing OrElse combox_medicine.TextValue.Trim = "" Then
            FrmDialog.ShowDialog(Me, "请选取药品名称!")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_BtnClick(sender As Object, e As EventArgs) Handles btnCancel.BtnClick
        Me.Close()
    End Sub

    Private Sub combox_medicine_SelectedChangedEvent(sender As Object, e As EventArgs) Handles combox_medicine.SelectedChangedEvent
        Dim objRow As DataRow = CType(combox_medicine.SelectSource, DataRow)
        If objRow IsNot Nothing Then
            Me.combox_medicine.TextValue = objRow.Item("Name").ToString()
        End If
    End Sub

    Private Sub btnAdd_BtnClick(sender As Object, e As EventArgs) Handles btnAdd.BtnClick
        If Not CheckMustEnter() Then
            Exit Sub
        End If

        Dim objRow_Medicine As DataRow = CType(Me.combox_medicine.SelectSource, DataRow)
        Dim objRowExist As DataRow = Me._datatable_source.AsEnumerable.Where(Function(row) row.RowState <> DataRowState.Deleted).OrderByDescending(Function(row) row.Item("Id").ToString.ToInt).FirstOrDefault()
        Dim objRowNew As DataRow = Me._datatable_source.NewRow
        objRowNew.Item("Name") = objRow_Medicine.Item("Name").ToString
        objRowNew.Item("Price") = objRow_Medicine.Item("Price").ToString
        If objRowExist IsNot Nothing Then
            objRowNew.Item("Id") = objRowNew.Item("Id").ToString.ToInt
        Else
            objRowNew.Item("Id") = 1
        End If
        objRowNew.Item("MedicineId") = objRow_Medicine.Item("Id").ToString.ToInt
        objRowNew.Item("Number") = Me.textbox_Num.txtInput.Text.Trim.ToInt
        objRowNew.Item("Dosage") = Me.textbox_Dosage.InputText.Trim
        objRowNew.Item("DocID") = Me._objRowDoc.Item("Id").ToString.ToInt
        Me._datatable_source.Rows.Add(objRowNew)
        Me.ucDataGridView1.DataSource = Me._datatable_source
    End Sub

    Private Sub btnRemove_BtnClick(sender As Object, e As EventArgs) Handles btnRemove.BtnClick
        Dim lstSelectID As List(Of DataRow) = Nothing
        lstSelectID = Me.ucDataGridView1.SelectRows.Select(Function(row) CType(row.DataSource, DataRow)).Where(Function(row) row.RowState <> DataRowState.Deleted).ToList
        Dim objRow As DataRow

        If lstSelectID.Count = 0 Then
            FrmDialog.ShowDialog(Me, "请选取要移除的项!")
        Else
            Dim lstID As List(Of Integer) = lstSelectID.Select(Function(row) row.Item("Id").ToString.ToInt).ToList

            For intCount = Me._datatable_source.Rows.Count - 1 To 0 Step -1
                objRow = Me._datatable_source.Rows(intCount)
                If objRow.RowState = DataRowState.Deleted Then
                    Continue For
                Else
                    objRow.Delete()
                End If
            Next

            Me.ucDataGridView1.DataSource = Me._datatable_source
        End If
    End Sub
End Class
