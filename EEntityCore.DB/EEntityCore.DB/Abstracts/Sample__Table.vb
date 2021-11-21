

Imports System.Data

Namespace Abstracts


    ''' <summary>
    ''' Copy this Template and adjust as you want. You can remove some of the constructors or add to it
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Sample__Table
        Inherits SimpleTablePlugIn



#Region "Constructors"

        ''' <summary>
        ''' UNKNOWN ACCESS
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New()
            MyBase.New()
        End Sub

#Region "Full Access"

        '   Full Access means initial data is loaded directly from database, so DBConn MUST be provided

        ''' <summary>
        ''' FULL ACCESS. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal DBConn As All__DBs)
            MyBase.New(DBConn)
        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID">Only works if the table contains a column named ID</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal DBConn As All__DBs, ByVal pTargettedRowID As Int64)

            MyBase.New(DBConn, pTargettedRowID:=pTargettedRowID)

        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pDBConn As All__DBs, ByVal pSQL As String)
            MyBase.New(pDBConn, pSQL)
        End Sub


        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pDBConn As All__DBs, ByVal pSQL As String, ByVal pTargettedRowID As Int64)
            MyBase.New(pDBConn, pSQL, pTargettedRowID)
        End Sub

#End Region


#Region "Partial Access"

        ' Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As DataRowCollection, ByVal pTargettedRowID As Int64)
            MyBase.New(pTableRows, pTargettedRowID)
        End Sub

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow))
            MyBase.New(pTableRows, DO__NOT____TARGET__ANY_ROWID)
        End Sub

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow), ByVal pTargettedRowID As Int64)
            MyBase.New(pTableRows, pTargettedRowID)
        End Sub

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="FullTable"></param>
        ''' <param name="TargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal FullTable As DataTable, ByVal pTargettedRowID As Int64)
            MyBase.New(FullTable, pTargettedRowID)
        End Sub


#End Region


#Region "Shallow Access"
        '   In the real definition, shallow reference partial. Just that it means partial with no DBConn

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="TargettedRow"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal TargettedRow As DataRow)
            MyBase.New(TargettedRow)
        End Sub

#End Region


#End Region



#Region "Properties"


        Public Overrides ReadOnly Property TableName As String
            Get
                Throw New NotImplementedException()
            End Get
        End Property

#End Region



#Region "Methods"

        Public Overloads Shared Function DeleteRow(pDBConn As All__DBs, pID As Int64) As Boolean
            Return DeleteRow(pDBConn, pID, pTableName:="SampleTable")
        End Function

#End Region



    End Class

End Namespace