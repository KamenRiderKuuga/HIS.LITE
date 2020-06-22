Imports System.Text

Public Class DataHelper
    ''' <summary>
    ''' 根据字符串获取MD5加密后的字符串
    ''' </summary>
    ''' <param name="input"></param>
    ''' <returns></returns>
    Public Shared Function CreateMD5(ByVal input As String) As String
        Using md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Dim sb As StringBuilder = New StringBuilder()

            For i As Integer = 0 To hashBytes.Length - 1
                sb.Append(hashBytes(i).ToString("X2"))
            Next

            Return sb.ToString()
        End Using
    End Function

    ''' <summary>
    ''' 获取枚举类型的字符互名称
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Shared Function EnumName(Of T)(ByVal value As T) As String
        Return [Enum].GetName(GetType(T), value)
    End Function

    Public Shared Function GetNewRow(ByVal datatable_source As DataTable) As DataRow
        Dim objRowResult As DataRow = Nothing
        If datatable_source IsNot Nothing Then
            Dim dataTable As DataTable = datatable_source.Clone
            objRowResult = dataTable.NewRow
            dataTable.Rows.Add(objRowResult)
        End If

        Return objRowResult

    End Function
End Class
