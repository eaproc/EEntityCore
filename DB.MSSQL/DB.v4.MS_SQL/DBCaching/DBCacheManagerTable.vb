Imports EPRO.Library.v3._5.Objects
Imports DB.Abstracts.All__DBs
Imports DB.Abstracts
Imports EPRO.Library.v3._5.AppConfigurations


Namespace DBCaching

    Friend Class DBCacheManagerTable
        Inherits DB.Abstracts.Sample__Table

#Region "Constructors"


        Public Sub New(TableName As String)
            MyBase.New(TableName)
        End Sub



#Region "Full Access"

        '   Full Access means initial data is loaded directly from database, so DBConn MUST be provided

        ''' <summary>
        ''' FULL ACCESS. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByRef DBConn As All__DBs,
                      ByVal TableName As String
                     )
            MyBase.New(DBConn, TableName)
        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID">Only works if the table contains a column named ID</param>
        ''' <remarks></remarks>
        Sub New(ByRef DBConn As All__DBs,
                ByVal pTableName As String,
                      ByVal pTargettedRowID As Int32)

            MyBase.New(DBConn, pTableName, pTargettedRowID:=pTargettedRowID)

        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByRef pDBConn As All__DBs,
                ByVal pTableName As String,
                ByVal pSQL As String)
            MyBase.New(pDBConn, pTableName, pSQL)
        End Sub


        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Sub New(ByRef pDBConn As All__DBs,
                ByVal pTableName As String,
                ByVal pSQL As String,
                     ByVal pTargettedRowID As Int32)
            MyBase.New(pDBConn, pTableName, pSQL, pTargettedRowID)

        End Sub

#End Region


#Region "Partial Access"

        ' Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Sub New(
                ByVal pTableRows As DataRowCollection,
                      ByVal pTargettedRowID As Int32,
                     pTableName As String,
                     ByRef pDBConn As All__DBs)
            MyBase.New(pTableRows, pTargettedRowID, pTableName, pDBConn)
        End Sub


        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Sub New(
                ByVal pTableRows As IEnumerable(Of DataRow),
                      ByVal pTargettedRowID As Int32,
                      ByVal pTableName As String,
                     ByRef pDBConn As All__DBs)

            MyBase.New(pTableRows, pTargettedRowID, pTableName, pDBConn)
        End Sub

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="FullTable"></param>
        ''' <param name="TargettedRowID"></param>
        ''' <remarks></remarks>
        Sub New(
                ByVal FullTable As DataTable,
                      ByVal TargettedRowID As Int32,
                      ByVal TableName As String,
                      ByRef DBConn As All__DBs)

            MyBase.New(FullTable, TargettedRowID, TableName, DBConn)
        End Sub


#End Region


#Region "Shallow Access"
        '   In the real definition, shallow reference partial. Just that it means partial with no DBConn

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="TargettedRow"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Sub New(ByVal TargettedRow As DataRow)
            MyBase.New(TargettedRow)
        End Sub

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow))
            MyBase.New(pTableRows)
        End Sub

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),
                ByVal pTargettedRowID As Int32
                )
            MyBase.New(pTableRows, pTargettedRowID)
        End Sub

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),
                ByVal pTargettedRowID As Int32,
                ByVal pTableName As String
                )
            MyBase.New(pTableRows, pTargettedRowID, pTableName)
        End Sub


        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <remarks></remarks>
        Sub New(
                ByVal FullTable As DataTable,
                ByVal pTableName As String)

            MyBase.New(FullTable, pTableName)
        End Sub


        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <remarks></remarks>
        Sub New(
                ByVal FullTable As DataTable,
                ByVal pTableName As String,
                  ByVal pTargettedRowID As Int32)
            MyBase.New(FullTable, pTableName, pTargettedRowID)
        End Sub


        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New(
                ByVal pDataRows As DataRowCollection,
                ByVal pTableName As String)

            MyBase.New(pDataRows, pTableName)

        End Sub

        ''' <summary>
        ''' Shallow Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),
                ByVal pTableName As String
                )
            MyBase.New(pTableRows, pTableName)
        End Sub

        ''' <summary>
        ''' Shallow Access. Should always target this passed in
        ''' </summary>
        ''' <param name="pTargettedRow"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal pTargettedRow As DataRow, ByVal pTableName As String)
            MyBase.New(pTargettedRow, pTableName)
        End Sub


#End Region


#End Region


#Region "Enums"
        Public Enum dcmTableColumns
            ID
            TableName
            TableVersion
            TableFillQuery
            CacheBlobColumns
            BlobColumns
        End Enum
#End Region

#Region "Properties"


        Public ReadOnly Property RowTableName As String
            Get
                Return EStrings.valueOf(Me.TargettedRow("TableName"))
            End Get
        End Property

        Public ReadOnly Property TableVersion As VersionControlSystem
            Get
                Return New VersionControlSystem(EStrings.valueOf(Me.TargettedRow("TableVersion")), DBCaching.CachedTable.TABLE_VERSION_EACH_COMP_LENGTH, True)
            End Get
        End Property

        Public ReadOnly Property TableFillQuery As String
            Get
                Return EStrings.valueOf(Me.TargettedRow("TableFillQuery"))
            End Get
        End Property


        Public ReadOnly Property BlobColumns As String
            Get
                Return EStrings.valueOf(Me.TargettedRow("BlobColumns"))
            End Get
        End Property


        Public ReadOnly Property CacheBlobColumns As Boolean
            Get
                Return EBoolean.valueOf(Me.TargettedRow("CacheBlobColumns"))
            End Get
        End Property

#End Region



#Region "Methods"

        Public Function getRowTable(ByVal vTableName As String) As DBCacheManagerTable
            Dim drs As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows
                                                  Where New DBCacheManagerTable(dr).RowTableName = vTableName
                                                  Select dr

            If IsDataSetValid(drs) Then Return New DBCacheManagerTable(drs(0), Me.TableName)
            Return Nothing

        End Function

#End Region

    End Class


End Namespace