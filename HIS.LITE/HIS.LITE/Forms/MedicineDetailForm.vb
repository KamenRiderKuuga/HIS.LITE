Imports System.Linq
Imports System.Security.Cryptography
Imports HZH_Controls
Imports HZH_Controls.Controls
Imports HZH_Controls.Forms

Public Class MedicineDetailForm
    Inherits HZH_Controls.Forms.FrmWithTitle

    Private ReadOnly _objRow As DataRow
    Private ReadOnly _handleType As Enums.HandleType
    Private ReadOnly _tableType As Enums.TableType

    Public Sub New(ByVal objRow As DataRow, ByVal tableType As Enums.TableType, ByVal strTitleName As String, ByVal handleType As Enums.HandleType)

        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        Me.Title = strTitleName
        Me.IsShowCloseBtn = True
        Me._objRow = objRow
        Me._handleType = handleType
        Me._tableType = tableType

        Me.textbox_Name.txtInput.MaxLength = 200

        If Me._handleType = Enums.HandleType.Modify Then
            Me.FillControlsWithDataRow()
            Me.textbox_Name.txtInput.ReadOnly = True
        End If

    End Sub

    Private Sub btnOK_BtnClick(sender As Object, e As EventArgs) Handles btnOK.BtnClick
        If Not Me.CheckMustEnter() Then
            Exit Sub
        End If

        Me.GetValueFromContorls()

        Dim intID As Integer

        If Me._handleType = Enums.HandleType.Add Then
            If Not Me.CheckName(Me.textbox_Name.InputText.Trim, intID) Then
                FrmDialog.ShowDialog(Me, "该药名已被使用,请检查!")
                Exit Sub
            End If
        End If

        Me._objRow.Item("Id") = intID

        DBHelper.InsertRowToDB(DataHelper.EnumName(Me._tableType), Me._objRow)

        Dim strMessage As String = If(Me._handleType = Enums.HandleType.Add, "添加成功!", "修改成功")

        FrmDialog.ShowDialog(Me, strMessage)

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Function CheckName(ByVal strName As String, ByRef intID As Integer) As Boolean
        Dim datatable_Result As DataTable = DBHelper.GetDataFromSQL("select * from " + DataHelper.EnumName(Me._tableType) + " order by Id desc")
        If datatable_Result Is Nothing OrElse datatable_Result.Rows.Count = 0 Then
            intID = 1
            Return True
        Else
            If datatable_Result.AsEnumerable().Where(Function(row) row.Item("Name").ToString() = strName).FirstOrDefault() IsNot Nothing Then
                Return False
            Else
                intID = datatable_Result.Rows(0).Item("Id").ToString.ToInt + 1
                Return True
            End If
        End If
    End Function

    Private Sub GetValueFromContorls()
        Me._objRow.Item("Name") = Me.textbox_Name.txtInput.Text.Trim
        Me._objRow.Item("Remaining") = Me.textbox_Remaining.txtInput.Text.ToInt
        Me._objRow.Item("Price") = Me.textbox_Price.txtInput.Text.ToDecimal
    End Sub

    Private Sub FillControlsWithDataRow()
        Me.textbox_Name.txtInput.Text = Me._objRow.Item("Name")
        Me.textbox_Remaining.txtInput.Text = Me._objRow.Item("Remaining")
        Me.textbox_Price.txtInput.Text = Me._objRow.Item("Price")
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

        Return True
    End Function

    Private Sub btnCancel_BtnClick(sender As Object, e As EventArgs) Handles btnCancel.BtnClick
        Me.Close()
    End Sub
End Class
