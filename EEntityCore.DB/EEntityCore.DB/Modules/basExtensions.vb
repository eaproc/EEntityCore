

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
                    Let p = New T()
                    Select p.LoadGeneric(Of T)(pObj.TableName, dr, p)
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
        Public Function getFirstRowIDASC(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            Dim drst As List(Of T)
            If pObj Is Nothing OrElse Not pObj.hasRows() Then Return New T()

            drst = (From dr As DataRow In pObj.AllRows
                    Let p = New T()
                    Order By p.ID Ascending
                    Select p.LoadGeneric(Of T)(pObj.TableName, dr, p)
                   ).ToList()

            Return drst.First()
        End Function


        ''' <summary>
        ''' This return last row according to ID Asc
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="pObj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension()>
        Public Function getLastRowIDASC(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            Dim drst As List(Of T)
            If pObj Is Nothing OrElse Not pObj.hasRows() Then Return New T()

            drst = (From dr As DataRow In pObj.AllRows
                    Let p = New T()
                    Order By p.ID Ascending
                    Select p.LoadGeneric(Of T)(pObj.TableName, dr, p)
                   ).ToList()

            Return drst.Last()
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
        Public Function ExtractFirstRow(Of T As {DB.Abstracts.SimpleTablePlugIn, New})(ByVal pObj As T) As T
            If pObj Is Nothing OrElse Not pObj.hasRows() Then Return New T()
            Return pObj.AsEnumerableDBTable().First()

        End Function



    End Module


End Namespace