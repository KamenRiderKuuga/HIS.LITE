Imports System.Linq
Imports System.Security.Cryptography
Imports HZH_Controls
Imports HZH_Controls.Controls
Imports HZH_Controls.Forms

Public Class UserInfoDetailForm
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

        Me.textbox_Accout.txtInput.MaxLength = 20
        Me.textbox_Password.txtInput.MaxLength = 30
        Me.textbox_Name.txtInput.MaxLength = 10
        Dim lstCom As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()

        lstCom.Add(New KeyValuePair(Of String, String)("0", "男"))
        lstCom.Add(New KeyValuePair(Of String, String)("1", "女"))

        Me.combox_Sex.Source = lstCom
        Me.combox_Sex.SelectedIndex = 0

        Dim lstCom_Role As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))()

        lstCom_Role.Add(New KeyValuePair(Of String, String)("0", "管理员"))
        lstCom_Role.Add(New KeyValuePair(Of String, String)("1", "医生"))
        lstCom_Role.Add(New KeyValuePair(Of String, String)("2", "药房"))
        lstCom_Role.Add(New KeyValuePair(Of String, String)("3", "挂号处"))
        lstCom_Role.Add(New KeyValuePair(Of String, String)("4", "患者"))

        Me.combox_Role.Source = lstCom_Role
        Me.combox_Role.SelectedIndex = 0

        Me.textbox_Password.txtInput.PasswordChar = "*"

        If Me._handleType = Enums.HandleType.Modify Then
            Me.FillControlsWithDataRow()
            Me.textbox_Accout.txtInput.ReadOnly = True
        End If

    End Sub

    Private Sub btnOK_BtnClick(sender As Object, e As EventArgs) Handles btnOK.BtnClick
        If Not Me.CheckMustEnter() Then
            Exit Sub
        End If
        Me.GetValueFromContorls()

        Dim intID As Integer

        If Me._handleType = Enums.HandleType.Add Then
            If Not Me.CheckAccount(Me.textbox_Accout.InputText.Trim, intID) Then
                FrmDialog.ShowDialog(Me, "该账户已被使用,请检查!")
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
        Me._objRow.Item("Account") = Me.textbox_Accout.txtInput.Text.Trim
        If Me.textbox_Password.txtInput.Text.Trim <> PulicConfig.PassWordTemp Then
            Me._objRow.Item("Password") = DataHelper.CreateMD5(Me.textbox_Password.txtInput.Text.Trim)
        End If
        Me._objRow.Item("Name") = Me.textbox_Name.txtInput.Text.Trim
        Me._objRow.Item("Age") = Me.textbox_Age.txtInput.Text.ToInt
        Me._objRow.Item("Sex") = Me.combox_Sex.SelectedValue.ToInt
        Me._objRow.Item("Height") = Me.textbox_Height.txtInput.Text.ToDecimal
        Me._objRow.Item("Weight") = Me.textbox_Weight.txtInput.Text.ToDecimal
        Me._objRow.Item("Role") = Me.combox_Role.SelectedValue.ToInt
    End Sub

    Private Sub FillControlsWithDataRow()
        Me.textbox_Accout.txtInput.Text = Me._objRow.Item("Account")
        Me.textbox_Password.txtInput.Text = PulicConfig.PassWordTemp
        Me.textbox_Name.txtInput.Text = Me._objRow.Item("Name")
        Me.textbox_Age.txtInput.Text = Me._objRow.Item("Age")
        Me.combox_Sex.SelectedValue = Me._objRow.Item("Sex")
        Me.textbox_Height.txtInput.Text = Me._objRow.Item("Height")
        Me.textbox_Weight.txtInput.Text = Me._objRow.Item("Weight")
        Me.combox_Role.SelectedValue = Me._objRow.Item("Role")
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
