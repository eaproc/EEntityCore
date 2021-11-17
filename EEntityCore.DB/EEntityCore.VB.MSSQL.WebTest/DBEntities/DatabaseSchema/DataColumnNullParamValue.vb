Imports ELibrary.Standard.VB.Modules

Namespace DBEntities.DatabaseSchema


    Public Class DataColumnNullParamValue

        Sub New()
        End Sub

        ''' <summary>
        ''' Returns Nothing too as null
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overrides Function Equals(obj As Object) As Boolean
            If obj Is Nothing Then Return True
            If TypeOf obj Is String AndAlso obj.ToString().equalsIgnoreCase(NULL_VALUE) Then Return True
            If TypeOf obj Is DataColumnNullParamValue Then Return True
            Return False
        End Function


        Public Const NULL_VALUE As String = "--(*_*)- CODER => You Rock"



        'Public Shared Narrowing Operator CType(ByVal v As DataColumnNullParamValue) As String
        '   REM If v = NULL_VALUE Then Return New DataColumnNullParamValue()
        '    Return Nothing
        'End Operator

        'Public Shared Widening Operator CType(ByVal v As String) As DataColumnNullParamValue
        '    If v = NULL_VALUE Then Return New DataColumnNullParamValue()
        '    Return Nothing
        'End Operator


    End Class



End Namespace