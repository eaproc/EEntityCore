

Imports System.Data

Namespace Modules

    Public Module basExtensions

        '   You must implement New() which you will use to pass in the table name. Anyways we will pass it for you


        ''' <summary>
        ''' This will split this table rows into classes containing 1 row each. AT most
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function AsEnumerableDBTable(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As IEnumerable(Of T)
            Dim drst As List(Of T) = New List(Of T)()
            If pObj Is Nothing OrElse Not pObj.hasRows() Then Return drst

            drst = (From dr As DataRow In pObj.AllRows
                    Select New T().LoadGeneric(Of T)(dr)
                   ).ToList()

            Return drst
        End Function


        ''' <summary>
        ''' This return first row according to ID Asc
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function SortedRows(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As List(Of T)
            Dim drst As List(Of T)
            If pObj Is Nothing OrElse Not pObj.HasRows() Then Return New List(Of T)

            drst = (From dr As DataRow In pObj.AllRows
                    Select New T().LoadGeneric(Of T)(dr)
                   ).OrderBy(Function(x) x.ID).ToList()

            Return drst
        End Function

        ''' <summary>
        ''' This return first row according to ID Asc
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function GetFirstRowIDASC(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            Return SortedRows(pObj).First()
        End Function


        ''' <summary>
        ''' This return last row according to ID Asc
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function GetLastRowIDASC(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            Return SortedRows(pObj).Last()
        End Function


        ''' <summary>
        ''' This return last row if any row is availble
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()> _
        Public Function ExtractLastRow(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            If pObj Is Nothing OrElse Not pObj.hasRows() Then Return New T()
            Return pObj.AsEnumerableDBTable().Last()

        End Function


        ''' <summary>
        ''' returns first row if any
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function ExtractFirstRow(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            If pObj Is Nothing OrElse Not pObj.HasRows() Then Return New T()
            Return pObj.AsEnumerableDBTable().First()

        End Function


        ''' <summary>
        ''' gets net ID from the rows loaded using linq
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function GetNextID(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As Int64
            If Not pObj.HasRows() Then Return 1 ' Might be empty table

            If Not pObj.HasNumericPrimaryKeyColumn Then Throw New Exception("This table doesnt contain a numeric primary key")

            Return pObj.GetLastRowIDASC().ID + 1

        End Function


    End Module


End Namespace