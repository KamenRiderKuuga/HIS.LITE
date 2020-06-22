Imports System.Data.SqlClient

Public Class DBHelper

    ''' <summary>
    ''' 根据SQL语句获取数据表
    ''' </summary>
    ''' <param name="strSQL"></param>
    ''' <returns></returns>
    Public Shared Function GetDataFromSQL(ByVal strSQL As String) As DataTable
        ' 连接数据库
        Dim connection As SqlConnection = New SqlConnection(PulicConfig.ConnectString)
        connection.Open()
        ' 获取数据
        Dim adp As SqlDataAdapter = New SqlDataAdapter(strSQL, connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)

        ' 关闭连接
        connection.Close()
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        End If

        Return Nothing

    End Function

    ''' <summary>
    ''' 执行SQL语句，并返回是否执行成功
    ''' </summary>
    ''' <param name="strSQL"></param>
    ''' <returns></returns>
    Public Shared Function ExecuteSQL(ByVal strSQL As String) As Boolean
        ' 连接数据库
        Dim connection As SqlConnection = New SqlConnection(PulicConfig.ConnectString)
        connection.Open()
        ' 执行SQL
        Dim command As SqlCommand
        command = connection.CreateCommand()
        command.CommandText = strSQL
        Dim intCount As Integer = command.ExecuteNonQuery()
        ' 关闭连接
        connection.Close()

        ' 如果影响的行数大于0，返回True，否则返回False
        Return intCount > 0
    End Function

    Public Shared Function InsertRowToDB(ByVal strTableName As String, ByVal objNewRow As DataRow) As Boolean
        ' 连接数据库
        Dim connection As SqlConnection = New SqlConnection(PulicConfig.ConnectString)
        connection.Open()
        ' 获取数据
        Dim strSQL As String = "select * from " + strTableName + " where 0 = 1"
        Dim adp As SqlDataAdapter = New SqlDataAdapter(strSQL, connection)
        Dim dataSet As New DataSet()
        adp.Fill(dataSet)

        dataSet.Tables(0).ImportRow(objNewRow)
        Dim sqlCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(adp)
        Dim intCount As Integer = adp.Update(dataSet)

        ' 关闭连接
        connection.Close()

        ' 如果影响的行数大于0，返回True，否则返回False
        Return intCount > 0
    End Function


End Class
