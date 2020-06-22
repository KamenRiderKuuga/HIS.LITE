Imports System.Linq
Imports HZH_Controls
Imports HZH_Controls.Forms

Public Class LoginForm
    Inherits HZH_Controls.Forms.FrmWithTitle
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        ' 设置文本框为密码框
        Me.textbox_Password.txtInput.PasswordChar = "*"
        Me.IsShowCloseBtn = True
    End Sub

    Private Sub btnLogin_BtnClick(sender As Object, e As EventArgs) Handles btnLogin.BtnClick
        Dim strAccount As String = Me.textbox_Accout.txtInput.Text.Trim
        Dim strPassword As String = Me.textbox_Password.txtInput.Text.Trim
        Dim row_result As DataRow = CheckPassword(strAccount, strPassword)


        If row_result IsNot Nothing Then
            Dim mainForm As MainForm = New MainForm(row_result)
            Me.Hide()
            mainForm.ShowDialog()
            Me.Show()
        End If
    End Sub

    ''' <summary>
    ''' 检查账号密码是否正确
    ''' </summary>
    ''' <param name="strAccount"></param>
    ''' <param name="strPassword"></param>
    ''' <returns></returns>
    Private Function CheckPassword(ByVal strAccount As String, ByVal strPassword As String) As DataRow
        If Not (strAccount.Length > 0 AndAlso strPassword.Length > 0) Then
            FrmDialog.ShowDialog(Me, "请输入账号密码！")
        End If


        Dim datatable_result As DataTable = DBHelper.GetDataFromSQL("select * from UserInfo where Account='" + Me.textbox_Accout.txtInput.Text + "' and Role<>4")

        Dim row_result As DataRow = Nothing

        If datatable_result IsNot Nothing AndAlso datatable_result.Rows.Count > 0 Then
            row_result = datatable_result.AsEnumerable().Where(Function(tx) tx.Item("Password").ToString() = DataHelper.CreateMD5(strPassword)).FirstOrDefault
            If row_result Is Nothing Then
                FrmDialog.ShowDialog(Me, "密码错误，请检查！")
            End If
        Else
            FrmDialog.ShowDialog(Me, "不存在的账号，请检查！")
        End If

        Return row_result

    End Function

    Private Sub btnExit_BtnClick(sender As Object, e As EventArgs) Handles btnExit.BtnClick
        Application.Exit()
    End Sub
End Class
