Imports DB.Abstracts.SimpleTablePlugIn
Imports DB.Abstracts.All__DBs

Imports EPRO.Library.v3._5
Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v3._5.AppConfigurations
Imports EPRO.Library.v3._5.Objects

Imports System.Transactions
Imports System.Threading

Imports CODERiT.Logger.v._3._5

Imports DB.v4.MS_SQL.Interfaces

Namespace DBCaching

    ''' <summary>
    ''' NB: You don't have to Cache all your tables. Caching is meant for data that are used heavily on a slow access route
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DBCacheManager
        Implements IDisposable


#Region "Constructors"


        ''' <summary>
        ''' Initialize Cache Manger with all objects except dbcachmanager table and dbinfo.  
        ''' NB: You don't have to Cache all your tables. Caching is meant for data that are used heavily on a slow access route
        ''' </summary>
        ''' <param name="svrConn"></param>
        ''' <param name="pTablesToCache"></param>
        ''' <param name="pViewsToCache">You can subscribe to view change as well which occurs if any of the table used in the view changes</param>
        ''' <param name="CacheVersion">You can use your DBVersion as well</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal svrConn As ISQLServerDBPointer,
                      ByVal pTablesToCache As IDBTableDefinitionPlugIn(),
                      ByVal pViewsToCache As IDBViewDefinitionPlugIn(),
                      Optional ByVal CacheVersion As UInt16 = CUShort(1),
                    Optional ByVal pCachedTablesChecker__TimeIntervalMillisecs As Int32 = 500,
                    Optional ByVal pLoadObjectsOnFirstRetrievalCall As Boolean = False
                                                              )
            If pTablesToCache Is Nothing OrElse pTablesToCache.Count() = 0 Then Throw New Exception("You have to pass in atleast 1 table")

            Dim vTablesToCache As IEnumerable(Of CachedTable) = From d As IDBTableDefinitionPlugIn In pTablesToCache
                                                              Select New CachedTable(d)

            Dim vViewsToCache As IEnumerable(Of CachedView) = New List(Of CachedView)()

            If pViewsToCache IsNot Nothing AndAlso pViewsToCache.Count() > 0 Then
                vViewsToCache = From v As IDBViewDefinitionPlugIn In pViewsToCache
                                Select New CachedView(v)
            End If

            Me.LoadConfiguration(svrConn, EForm.get_guid_from_ObjectType(pTablesToCache(0).GetType()), vTablesToCache.ToArray(), vViewsToCache.ToArray(),
                                 CacheVersion, pCachedTablesChecker__TimeIntervalMillisecs, pLoadObjectsOnFirstRetrievalCall)
        End Sub


        ''' <summary>
        ''' Initialize Cache Manger.  NB: You don't have to Cache all your tables. Caching is meant for data that are used heavily on a slow access route
        ''' </summary>
        ''' <param name="svrConn"></param>
        ''' <param name="AppUniqueIdentifier"></param>
        ''' <param name="TablesToCache"></param>
        ''' <param name="ViewsToCache">You can subscribe to view change as well which occurs if any of the table used in the view changes</param>
        ''' <param name="CacheVersion">You can use your DBVersion as well</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal svrConn As ISQLServerDBPointer,
                ByVal AppUniqueIdentifier As System.Type,
                      ByVal TablesToCache As CachedTable(),
                      ByVal ViewsToCache As CachedView(),
                      Optional ByVal CacheVersion As UInt16 = CUShort(1),
                    Optional ByVal pCachedTablesChecker__TimeIntervalMillisecs As Int32 = 500,
                    Optional ByVal pLoadObjectsOnFirstRetrievalCall As Boolean = False
                                                              )
            Me.New(svrConn, EForm.get_guid_from_ObjectType(AppUniqueIdentifier), TablesToCache, ViewsToCache, CacheVersion, pCachedTablesChecker__TimeIntervalMillisecs, pLoadObjectsOnFirstRetrievalCall)
        End Sub

        ''' <summary>
        ''' Initialize Cache Manger.  NB: You don't have to Cache all your tables. Caching is meant for data that are used heavily on a slow access route
        ''' </summary>
        ''' <param name="svrConn"></param>
        ''' <param name="AppUniqueIdentifier"></param>
        ''' <param name="TablesToCache"></param>
        ''' <param name="ViewsToCache">You can subscribe to view change as well which occurs if any of the table used in the view changes</param>
        ''' <param name="CacheVersion">You can use your DBVersion as well</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal svrConn As ISQLServerDBPointer,
                ByVal AppUniqueIdentifier As String,
                      ByVal TablesToCache As CachedTable(),
                      ByVal ViewsToCache As CachedView(),
                      Optional ByVal CacheVersion As UInt16 = CUShort(1),
                    Optional ByVal pCachedTablesChecker__TimeIntervalMillisecs As Int32 = 500,
                    Optional ByVal pLoadObjectsOnFirstRetrievalCall As Boolean = False
                                                              )
            Me.LoadConfiguration(svrConn, AppUniqueIdentifier, TablesToCache, ViewsToCache, CacheVersion, pCachedTablesChecker__TimeIntervalMillisecs, pLoadObjectsOnFirstRetrievalCall)
        End Sub





        Private Sub LoadConfiguration(ByVal svrConn As ISQLServerDBPointer,
              ByVal AppUniqueIdentifier As String,
                    ByVal TablesToCache As CachedTable(),
                    ByVal ViewsToCache As CachedView(),
                    Optional ByVal CacheVersion As UInt16 = CUShort(1),
                    Optional ByVal pCachedTablesChecker__TimeIntervalMillisecs As Int32 = 500,
                    Optional ByVal pLoadObjectsOnFirstRetrievalCall As Boolean = False
                                                            )
            Me.DirectConn = svrConn
            Me.____DatabaseName = Me.DirectConn.getDBConn().DatabaseName

            Me.thrCachedTablesChecker__TimeInterval = pCachedTablesChecker__TimeIntervalMillisecs

            Me.LockGivingOutTables = New Object()

            Me.__Version = CacheVersion
            Me.__AppUniqueIdentifier = AppUniqueIdentifier
            __Logger = New Log1(Me.GetType()).Load(Log1.Modes.FILE, True)
            Me.CachedTables = New Dictionary(Of String, CachedTable)()
            Me.CachedViews = New Dictionary(Of String, CachedView)()


            Me.SnapshotDBTransaction2Secs = New DBConcurrency.SQLDatabaseTransactionManager(Logger, Me.DirectConn, IsolationLevel.Snapshot)
            Me.ReadCommittedDBTransaction2Secs = New DBConcurrency.ReadCommittedTransactionManager(Logger, Me.DirectConn)



            Me.CacheManagerTableSQL = String.Format(
                                                "CREATE TABLE {0}( " &
                                                "       ID INT NOT NULL IDENTITY(1,1), " &
                                                "       TableName varchar(50) NOT NULL, " &
                                                "       TableVersion varchar(150) NOT NULL DEFAULT '', " &
                                                "       TableFillQuery varchar(max) NULL, " &
                                                "       CacheBlobColumns bit NOT NULL DEFAULT 0, " &
                                                "       BlobColumns varchar(250) NULL, " &
                                                "       CONSTRAINT pkDBCacheManager PRIMARY KEY(ID), " &
                                                "       CONSTRAINT uqDBManagerTableName UNIQUE(TableName) " &
                                                " ) ", Me.CacheManagerTableName
                                                )


            If Not Me.DirectConn.getDBConn().IsTableCreatedOnDatabase(Me.CacheManagerTableName) Then

                REM Since this is deleted all files must have been wiped off
                REM Better Load all
                EIO.DeleteAndRecreateDirectory(Me.CacheStoreFolder)

                REM ------------------------ Here must be atomic --------------------------------------------------------------------
                Try


                    REM -----------------------------------Delete Old Cache Tables
                    REM --Read here to avoid multiple connections within a transaction scope
                    Dim OldCacheTableDataset As DataSet = Me.SnapshotDBTransaction2Secs.getRS(
                        New DBConcurrency.GetRSTrans("SELECT name from sys.tables where name like 'DBCacheManager%'")
                        )






                    Using TScope As New TransactionScope(TransactionScopeOption.Required,
                                                         New TransactionOptions() With {.IsolationLevel = IsolationLevel.ReadCommitted,
                                                                                        .Timeout = TimeSpan.FromSeconds(15)
                                                                                       }
                                                         )

                        Using Conn As SqlClient.SqlConnection = Me.DirectConn.getDBConn().getSQLConnection()

                            Using cmd As SqlClient.SqlCommand = Conn.CreateCommand()

                                REM Delete Old cache tables
                                If IsDataSetValid(OldCacheTableDataset) Then
                                    For Each dr As DataRow In OldCacheTableDataset.Tables(0).Rows
                                        cmd.CommandText = "DROP TABLE " & dr("name").ToString()
                                        cmd.ExecuteNonQuery()
                                    Next
                                End If



                                cmd.CommandText = CacheManagerTableSQL
                                cmd.ExecuteNonQuery()

                                REM If Not Me.DirectConn.getDBConn().IsTableCreatedOnDatabase(Me.CacheTableName) Then Throw New Exception("Error Creating Cache Table on Database. Please Ensure your Database is Ok.")
                                REM INSERT TABLES
                                For Each t As CachedTable In TablesToCache
                                    cmd.CommandText = String.Format("INSERT INTO {0} (TableName,TableFillQuery,CacheBlobColumns,BlobColumns) " &
                                                                    " VALUES('{1}','{2}',{3},'{4}') ",
                                                                    Me.CacheManagerTableName, t.TableName, t.TableFillQuery, t.CacheBlobColumns.toInt32(),
                                                                    t.BlobColumns
                                                                    )
                                    cmd.ExecuteNonQuery()
                                Next

                            End Using
                        End Using

                        TScope.Complete()
                    End Using
                Catch ex As Exception

                    Throw New Exception("Error Creating Cache Table on Database. Please Ensure your Database is Ok.", ex)

                End Try

                REM -----------------------------------------------------------------------------------------------------------------


            End If


            REM Instead of doing this on Load. Serialize this part
            If IO.File.Exists(Me.CacheManagerTableFileFullPath) Then
                Try
                    Me.CachedTables = CacheTablesWriter.Read(Me.CacheManagerTableFileFullPath)
                Catch ex As Exception
                    Logger.Print("Reading Cache File", ex)
                End Try
            Else

                Me.CachedTables = New Dictionary(Of String, CachedTable)()
                REM Just Re-Create Diretory to avoid errors of directory not found
                EIO.DeleteAndRecreateDirectory(Me.CacheStoreFolder)

            End If

            REM Only Load Fresh if it does not exist
            If (Me.CachedTables IsNot Nothing AndAlso Me.CachedTables.Values.Count = 0) OrElse Me.CachedTables.Count <> TablesToCache.Count Then

                Me.CachedTables = New Dictionary(Of String, CachedTable)()
                For Each t As CachedTable In TablesToCache
                    Me.CachedTables.Add(t.TableName, t)
                Next

            End If

            '   Assign the parent
            If CachedTables IsNot Nothing Then
                For Each p In CachedTables.Values
                    p.setParent(Me)
                Next
            End If



            REM Run Checker
            If Not pLoadObjectsOnFirstRetrievalCall Then Me.CheckTables()

            Me.thrCachedTablesChecker = New Thread(AddressOf Me.runCheckTables)
            Me.thrCachedTablesChecker.SetApartmentState(ApartmentState.MTA)
            Me.thrCachedTablesChecker.IsBackground = True
            Me.thrCachedTablesChecker.Start()



            REM Set Views Before setting the snapshot, incase a view depends on another view that is after it ordinally in list.
            If ViewsToCache IsNot Nothing Then
                For Each vc As CachedView In ViewsToCache
                    Me.CachedViews.Add(vc.ViewName, vc)
                Next
                For Each vc As CachedView In Me.CachedViews.Values
                    vc.setSnapshotReader(Me.SnapshotDBTransaction2Secs, Me, Not pLoadObjectsOnFirstRetrievalCall)
                Next
            End If


        End Sub


#End Region


#Region "Properties"


        Private SnapshotDBTransaction2Secs As DBConcurrency.SQLDatabaseTransactionManager
        Private ReadCommittedDBTransaction2Secs As DBConcurrency.ReadCommittedTransactionManager



        Private Shared __Logger As Log1
        ''' <summary>
        ''' Use for logging via Cache Manager
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Shared ReadOnly Property Logger As Log1
            Get
                Return __Logger
            End Get
        End Property


        ''' <summary>
        ''' CacheTables Indexed with Table Names
        ''' </summary>
        ''' <remarks></remarks>
        Private CachedTables As Dictionary(Of String, CachedTable)

        ''' <summary>
        ''' Cached Views Indexed with names
        ''' </summary>
        ''' <remarks></remarks>
        Private CachedViews As Dictionary(Of String, CachedView)


        Private thrCachedTablesChecker As Thread

        ''' <summary>
        ''' Time to keep checking all tables
        ''' </summary>
        ''' <remarks></remarks>
        Private thrCachedTablesChecker__TimeInterval As Int32


        Private DirectConn As ISQLServerDBPointer

        Private __Version As UInt16
        Public ReadOnly Property Version As UInt16
            Get
                Return Me.__Version
            End Get
        End Property

        Public ReadOnly Property CacheManagerTableName As String
            Get
                Return "DBCacheManager_v" & Me.Version.ToString()
            End Get
        End Property

        ''' <summary>
        ''' Can be used even after the class is disposed.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property CacheManagerTableFileFullPath As String
            Get
                Return String.Format("{0}\{1}.serialized", Me.CacheStoreFolder, Me.CacheManagerTableName)
            End Get
        End Property


        Private CacheManagerTableSQL As String

        Private __AppUniqueIdentifier As String

        Private ____DatabaseName As String


        ''' <summary>
        ''' Storage Folder for Cache for this Process
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private ReadOnly Property CacheStoreFolder As String
            Get
                Return String.Format("{0}\{1}\{2}\Cache", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                                     Me.__AppUniqueIdentifier,
                                     Me.____DatabaseName
                                     )
            End Get
        End Property

#End Region



#Region "Enums and Consts and Structures"

        
#End Region


#Region "Methods"

#Region "Private"



        ''' <summary>
        ''' Construct a Table Blob Save File Full Path
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function getCachedBlobFileFullPath(ByVal TableName As String) As String
            Return String.Format("{0}\Cache_v{1}_{2}.Blobs", Me.CacheStoreFolder, Me.Version, TableName)
        End Function




        Private Sub CheckTables(Optional ByVal DeleteInvalidBlobIDs As Boolean = False)

            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)


            REM -----------Fetch DBCachManager table with ISOLATION LEVEL SNAPSHOT

            Dim CacheMgrTableFromDB As DBCacheManagerTable = Nothing


            Dim rs As DataSet = Nothing
            Try
                rs = Me.SnapshotDBTransaction2Secs.getRS(New DBConcurrency.GetRSTrans("SELECT * FROM " & Me.CacheManagerTableName, True))
            Catch ex As Exception
                Logger.Print(ex)
            End Try


            Try
                If DB.Abstracts.All__DBs.IsDataSetValid(rs) Then _
                                    CacheMgrTableFromDB =
                                    New DBCacheManagerTable(rs.Tables(0).AsEnumerable(), DO__NOT____TARGET__ANY_ROWID,
                                                            Me.CacheManagerTableName
                                                            )


                If CacheMgrTableFromDB Is Nothing Then Return REM No Table Inserted

                For Each t As CachedTable In Me.CachedTables.Values

                    Dim tTable As DBCacheManagerTable = CacheMgrTableFromDB.getRowTable(t.TableName)
                    If tTable IsNot Nothing AndAlso Not tTable.TableVersion.Equals(t.TableVersion) Then
                        Me.CheckTable(t, tTable.TableVersion, DeleteInvalidBlobIDs)
                    ElseIf t.GivingOutDataTable Is Nothing Then
                        REM Force Load
                        Me.CheckTable(t, t.TableVersion, DeleteInvalidBlobIDs)
                    End If
                Next

            Catch ex As Exception
                Logger.Print(ex)
                Throw ex
            End Try

        End Sub

        ''' <summary>
        ''' Running this means the table is updated. New Version. It will also notify users
        ''' </summary>
        ''' <param name="t"></param>
        ''' <param name="tLatestTableValuesVersion">The version on database that this local table will keep so that it is same with on database</param>
        ''' <param name="DeleteInvalidBlobIDs"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function CheckTable(t As CachedTable, tLatestTableValuesVersion As VersionControlSystem,
                                    Optional ByVal DeleteInvalidBlobIDs As Boolean = False) As Boolean

            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            Try
                t.SetIsLock(Me.ReadCommittedDBTransaction2Secs.IsDBTableLocked(t.TableName))

                If t.IsLocked Then Return False
                Dim isAnyRowNormalized As Boolean = False
                REM ---------------------------------------------------------------------------------------------------
START_ROWS_NORMALIZATION:
                Dim rs As DataSet = Nothing
                Try
                    rs = Me.SnapshotDBTransaction2Secs.getRS(5000, New DBConcurrency.GetRSTrans(t.getFillSQL(), True))
                Catch ex As Exception
                    Logger.Print(ex)
                End Try

                If Not rs.Tables(0).Columns.Contains("ID") OrElse Not rs.Tables(0).Columns.Contains(CachedTable.ROW_VERSION_COLUMN_NAME) Then _
                    Throw New Exceptions.InvalidTableStructureException(t.TableName)

                t.SetRawTable(rs.Tables(0))

                Dim RowsToNormalize As List(Of DataRow) = t.getRowsToNormalize()
                If IsDataSetValid(RowsToNormalize) Then
                    Try
                        Dim dr As DataRow = RowsToNormalize(0)
                        Dim NormalizedVersion As VersionControlSystem =
                            VersionControlSystem.NormalizeStringVersion(dr(CachedTable.ROW_VERSION_COLUMN_NAME).ToString(),
                                                                        CachedTable.ROW_VERSION_EACH_COMP_LENGTH, True
                                                                        )
                        NormalizedVersion.Increase()
                        Me.ReadCommittedDBTransaction2Secs.dbExec(New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}='{2}' WHERE ID={3}",
                                                                                                t.TableName, CachedTable.ROW_VERSION_COLUMN_NAME,
                                                                                                NormalizedVersion.ToString(),
                                                                                                dr("ID")
                                                                                                )
                                                                                            )
                                                                                        )
                        isAnyRowNormalized = True
                        GoTo START_ROWS_NORMALIZATION

                    Catch ex As Exception
                        Logger.Print("Failed to Normalize Row", ex)
                    End Try

                End If

                REM --------------------------------------------------------------------------------------------------------------
                SyncLock LockGivingOutTables
                    t.CopyTemporaryTableToRealTable()
                    t.SetVersion(tLatestTableValuesVersion) REM Now update the local version
                End SyncLock




                REM Notify all Subcribed Users table data has changed
                t.NotifyAllDataChangedSubscribers()



                REM If isAnyRowNormalized then update the table version
                If isAnyRowNormalized Then t.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)



                If DeleteInvalidBlobIDs AndAlso t.CacheBlobColumns Then t.DeleteInvalidBlobs()

                Return True


            Catch ex As Exceptions.InvalidTableStructureException
                Throw ex

            Catch ex As Exception

                Logger.Print("CheckTable()", ex)


            End Try

            Return False
        End Function



        Private Sub runCheckTables()
            Try
                While Not Me.IsDisposed

                    Me.CheckTables()
                    With New CacheTablesWriter(Me.CachedTables)
                        .Write(Me.CacheManagerTableFileFullPath)
                    End With
                    Thread.Sleep(thrCachedTablesChecker__TimeInterval)
                End While
            Catch ex As System.IO.IOException
                REM Incase many process are writing to same file at the same time
                Logger.Print("runCheckerThreadExiting", ex)
            Catch ex As ThreadAbortException
                Logger.Print("runCheckerThreadExiting", ex)
            Catch ex As Exception
                Logger.Print("runCheckerThreadExiting", ex)
                Throw ex
            End Try
        End Sub


        ''' <summary>
        ''' Get Cached Table container or Throw exception
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function getCachedTableContainer(ByVal TableName As String) As CachedTable
            If Me.CachedTables.ContainsKey(TableName) Then Return Me.CachedTables(TableName)
            Throw New Exceptions.CachedTableNOTFoundException(TableName)
        End Function

        ''' <summary>
        ''' Get Cached View container or Throw exception
        ''' </summary>
        ''' <param name="ViewName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function getCachedViewContainer(ByVal ViewName As String) As CachedView
            If Me.CachedViews.ContainsKey(ViewName) Then Return Me.CachedViews(ViewName)
            Throw New Exceptions.CachedViewNOTFoundException(ViewName)
        End Function

#End Region


        Public Function hasTable(pTableName As String) As Boolean
            Return Me.CachedTables IsNot Nothing AndAlso Me.CachedTables.ContainsKey(pTableName)
        End Function

        Public Function hasView(pViewName As String) As Boolean
            Return Me.CachedViews IsNot Nothing AndAlso Me.CachedViews.ContainsKey(pViewName)
        End Function


#Region "Invalidating Objects"
        '
        ' Causing Object to Reload
        '
        ''' <summary>
        ''' This will cause the table to reload in cache asychronously. 
        ''' NOTE: INVALIDATION Does not really alter the table version.
        ''' It just makes it invalid temporarily for checker thread to reload and assume the version on database
        ''' </summary>
        ''' <param name="pTable">The name of the table to force</param>
        ''' <remarks></remarks>
        Public Sub ForceInvalidationOfTable(pTable As String)
            Try
                If Me.CachedTables.ContainsKey(pTable) Then
                    Me.CachedTables(pTable).InvalidateTable()
                End If

            Catch ex As Exception
                Logger.Print("Error Forcing Table Invalidation: " & pTable, ex)
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' This will cause the table to reload in cache Sychronously
        ''' </summary>
        ''' <param name="pTable">The name of the table to force</param>
        ''' <remarks></remarks>
        Public Sub ForceInvalidationOfTableSync(pTable As String)
            Try
                Dim t As CachedTable = Me.getCachedTableContainer(pTable)

                Me.CheckTable(t, t.TableVersion)

            Catch ex As Exception
                Logger.Print("Error Forcing Table Invalidation (Sync): " & pTable, ex)
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' This will cause the table to reload in cache Sychronously
        ''' </summary>
        ''' <param name="pView">The name of the table to force</param>
        ''' <remarks></remarks>
        Public Sub ForceInvalidationOfViewSync(pView As String)
            Try
                Dim t As CachedView = Me.getCachedViewContainer(pView)
                t.LoadView()

            Catch ex As Exception
                Logger.Print("Error Forcing View Invalidation (Sync): " & pView, ex)
                Throw ex
            End Try
        End Sub




        ''' <summary>
        ''' This will cause table version to increase on cache table and all subscribers will fetch new version
        ''' globally. Asynchonously
        ''' </summary>
        ''' <param name="pTableName">The name of the table to force</param>
        ''' <remarks></remarks>
        Public Sub ForceTableInvalidationGlobally(pTableName As String)
            Try
                Dim t As CachedTable = Me.getCachedTableContainer(pTableName)
                t.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)
            Catch ex As Exception
                Logger.Print("Error Forcing TableInvalidationGlobally: " & pTableName, ex)
                Throw ex
            End Try
        End Sub


#End Region

      




        Private LockGivingOutTables As Object
        ''' <summary>
        ''' Return a copy of the cached table
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getCachedTable(ByVal TableName As String) As CachedTable.CollectedTableCopy
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            SyncLock Me.LockGivingOutTables
                If Me.CachedTables.ContainsKey(TableName) Then Return New CachedTable.CollectedTableCopy(Me.CachedTables(TableName).GivingOutDataTable)
                Return Nothing
            End SyncLock
        End Function

        ''' <summary>
        ''' Return a copy of the cached view
        ''' </summary>
        ''' <param name="ViewName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getCachedView(ByVal ViewName As String) As CachedTable.CollectedTableCopy
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            If Me.CachedViews.ContainsKey(ViewName) Then Return New CachedTable.CollectedTableCopy(Me.CachedViews(ViewName).GivingOutDataview)
            Return Nothing
        End Function



        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub subscribeToTableChange(ByVal TableName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged,
                                           pIntervalInMillisecs As Int32
                                           )
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            Dim t As CachedTable = Me.getCachedTableContainer(TableName)
            t.subcribeUserForDataChanged(Notifier, pIntervalInMillisecs)
        End Sub
        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub subscribeToTableChange(ByVal TableName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged)
           
            Me.subscribeToTableChange(TableName, Notifier, 0)

        End Sub

        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub unsubscribeFromTableChange(ByVal TableName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged)
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            Dim t As CachedTable = Me.getCachedTableContainer(TableName)
            t.unsubcribeUserFromDataChanged(Notifier)

        End Sub




        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="ViewName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub subscribeToViewChange(ByVal ViewName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged,
                                           pIntervalInMillisecs As Int32
                                           )
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            Dim t As CachedView = Me.getCachedViewContainer(ViewName)
            t.subcribeUserForviewChanged(Notifier, pIntervalInMillisecs)

        End Sub

        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="ViewName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub subscribeToViewChange(ByVal ViewName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged)
          
            Me.subscribeToViewChange(ViewName, Notifier, 0)
        End Sub

        ''' <summary>
        ''' Try not to do multiple subscription
        ''' </summary>
        ''' <param name="ViewName"></param>
        ''' <param name="Notifier"></param>
        ''' <remarks></remarks>
        Public Sub unsubscribeFromViewChange(ByVal ViewName As String, ByVal Notifier As DBCaching.Interfaces.INotifyTableChanged)
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            Dim t As CachedView = Me.getCachedViewContainer(ViewName)
            t.unsubcribeUserFromviewChanged(Notifier)

        End Sub







        ''' <summary>
        ''' Insert using read committed
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <param name="InsertQuery"></param>
        ''' <param name="UseDBInsertIDentity">If this is set to true. The insert query will be appended with the set identity insert command</param>
        ''' <param name="ForceUpdateCachTableImmediately" >This will force the check for this table if the version is still intact in cache.
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' Note: this is Synchronous</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dmlINSERT(ByVal TableName As String, ByVal InsertQuery As String,
                                  Optional ByVal UseDBInsertIDentity As Boolean = False,
                                  Optional ByVal ForceUpdateCachTableImmediately As Boolean = False,
                                  Optional ByVal vHandleApostrophe As Boolean = False) As Boolean
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            Try

                If UseDBInsertIDentity Then InsertQuery = String.Format("SET IDENTITY_INSERT {0} ON {1} SET IDENTITY_INSERT {0} OFF", TableName, InsertQuery)

                Dim t As CachedTable = Me.getCachedTableContainer(TableName)

                Dim Result As Boolean =
                    Me.ReadCommittedDBTransaction2Secs.dbExec(New DBConcurrency.DBExecTrans(InsertQuery, True, vHandleApostrophe))

                Dim newExpectingVersion As VersionControlSystem = t.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)


                If ForceUpdateCachTableImmediately AndAlso newExpectingVersion IsNot Nothing Then Me.CheckTable(t, newExpectingVersion)


                Return True
            Catch ex As Exception
                Logger.Print("dmlINSERT", ex)
                Throw ex

            End Try
            Return False
        End Function

        ''' <summary>
        ''' Delete operation and returns no of rows affected
        ''' </summary>
        ''' <param name="pTableName"></param>
        ''' <param name="deleteQuery"></param>
        ''' <param name="ForceUpdateCachTableImmediately"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dmlDELETE(pTableName As String, deleteQuery As String,
                                   Optional ByVal ForceUpdateCachTableImmediately As Boolean = False
                                                                                               ) As Int32
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            Try

                Dim t As CachedTable = Me.getCachedTableContainer(pTableName)
                Dim dq As New DBConcurrency.DBExecTrans(deleteQuery, True)

                Dim Result As Boolean =
                    Me.ReadCommittedDBTransaction2Secs.dbExec(1000, dq) REM delete in 1secs

                Dim newExpectingVersion As VersionControlSystem = t.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)


                If ForceUpdateCachTableImmediately AndAlso newExpectingVersion IsNot Nothing Then Me.CheckTable(t, newExpectingVersion)


                '   For cascade delete function
                '
                '
                '   Check through the tables in the store if there is anyone with foreign key pointing to this table
                '
                '

                Dim dRefTables As IEnumerable(Of CachedTable) = From d As CachedTable In Me.CachedTables.Values
                                                                Where d.IsReferencingOnCascadeDELETE(pTableName)
                                                                Select d

                If dRefTables IsNot Nothing AndAlso dRefTables.Count() > 0 Then
                    For Each pTable As CachedTable In dRefTables
                        If pTable.IsReferencingOnCascadeDELETE(pTableName) Then pTable.InvalidateTable()
                    Next
                End If




                Return dq.affectedRows

            Catch ex As System.Data.SqlClient.SqlException
                If ex IsNot Nothing And ex.Message.StartsWith("Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.") Then

                    Throw New Exceptions.DataRowLockedException(pTableName)

                Else
                    Logger.Print("dmlDELETE", ex)
                    Throw ex
                End If
            Catch ex As Exception
                REM if timeout exception then Row(s) is Locked try again
                REM Else .. it might be sql query error

                Logger.Print("dmlDELETE", ex)
                Throw ex

            End Try
            Return 0


        End Function


        ''' <summary>
        ''' Update a multi row or single row
        ''' </summary>
        ''' <param name="LastReadTableVersion"></param>
        ''' <param name="updateQuery"></param>
        ''' <param name="WhereClause" >It is important for multi row update statement</param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dmlUPDATE(ByVal LastReadTableVersion As CachedTable.CollectedTableCopy,
                                  updateQuery As String,
                                   WhereClause As String,
                                   Optional ByVal ForceUpdateCachTableImmediately As Boolean = False,
                                   Optional ByVal vHandleApostrophe As Boolean = False) As Integer
            Return Me.dmlUPDATE(LastReadTableVersion, updateQuery, , WhereClause, ForceUpdateCachTableImmediately, vHandleApostrophe)
        End Function

        ''' <summary>
        ''' Update a multi row or single row
        ''' </summary>
        ''' <param name="LastReadTableVersion"></param>
        ''' <param name="updateQuery"></param>
        ''' <param name="RowID">It is important for single row. Since Table might change without the specific row changing</param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dmlUPDATE(ByVal LastReadTableVersion As CachedTable.CollectedTableCopy,
                                  updateQuery As String,
                                   RowID As UInteger,
                                   Optional ByVal ForceUpdateCachTableImmediately As Boolean = False,
                                   Optional ByVal vHandleApostrophe As Boolean = False) As Integer
            Return Me.dmlUPDATE(LastReadTableVersion, updateQuery, RowID, , ForceUpdateCachTableImmediately, vHandleApostrophe)
        End Function

        ''' <summary>
        ''' Update a multi row or single row
        ''' </summary>
        ''' <param name="LastReadTableVersion"></param>
        ''' <param name="updateQuery"></param>
        ''' <param name="RowID">It is important for single row. Since Table might change without the specific row changing</param>
        ''' <param name="WhereClause" >It is important for multi row update statement to increase the RowVersion you used to update your query</param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function dmlUPDATE(ByVal LastReadTableVersion As CachedTable.CollectedTableCopy,
                                  updateQuery As String,
                                  Optional RowID As UInteger = 0,
                                  Optional WhereClause As String = "",
                                   Optional ByVal ForceUpdateCachTableImmediately As Boolean = False,
                                   Optional ByVal vHandleApostrophe As Boolean = False) As Integer

            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            If IsNothing(LastReadTableVersion) Then Throw New InvalidOperationException("You can not pass in empty table copy")

            Try

                Dim tCurrentCached As CachedTable = Me.getCachedTableContainer(LastReadTableVersion.TableName)


                REM Multi Row requires table lock
                REM SingRow requires ID
                Dim IsSingleRow As Boolean = (RowID <> 0)

                REM You can not update multi row with table locked
                If Not IsSingleRow AndAlso tCurrentCached.IsLocked Then Throw New Exceptions.DataRowLockedException(LastReadTableVersion.TableName)

                Dim uq As New DBConcurrency.DBExecTrans(updateQuery, True, vHandleApostrophe), UpdateRowVersionQuery As DBConcurrency.DBExecTrans
                Dim Result As Boolean

                If IsSingleRow Then
                    REM Confirm row versions
                    Dim tOldRowVersion As VersionControlSystem = LastReadTableVersion.getDataRowVersion(RowID)
                    Dim tCurrentRowVersion As VersionControlSystem = tCurrentCached.getDataRowVersion(RowID)

                    If tOldRowVersion Is Nothing Then Throw New Exception(String.Format(
                            "The passed in last cache table doesn't contain the Item with ID: {0}. Please, make sure you have the latest table by forcing update on last query.", RowID
                                                        )
                                                    )

                    If Not tOldRowVersion.Equals(tCurrentRowVersion) Then Throw New Exceptions.PhantomOrDirtyReadException(LastReadTableVersion.TableName)

                    REM Increase Version
                    tOldRowVersion.Increase()

                    If vHandleApostrophe Then
                        UpdateRowVersionQuery = New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}=\'{2}\' WHERE ID={3}",
                                                                                                                  LastReadTableVersion.TableName,
                                                                                                                  CachedTable.ROW_VERSION_COLUMN_NAME,
                                                                                                                  tOldRowVersion.ToString(),
                                                                                                                  RowID), False, vHandleApostrophe
                                                                                                              )
                    Else
                        UpdateRowVersionQuery = New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}='{2}' WHERE ID={3}",
                                                                                                                  LastReadTableVersion.TableName,
                                                                                                                  CachedTable.ROW_VERSION_COLUMN_NAME,
                                                                                                                  tOldRowVersion.ToString(),
                                                                                                                  RowID), False, vHandleApostrophe
                                                                                                              )
                    End If
                    ''Result = Me.ReadCommittedDBTransaction2Secs.dbExec(2000, uq) REM delete in 1secs

                    ''REM if it gets here then it updated successfully
                    ''If uq.affectedRows > 0 Then
                    ''    tOldRowVersion.Increase()
                    ''    Me.ReadCommittedDBTransaction2Secs.dbExec(3000,
                    ''                                              New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}='{2}' WHERE ID={3}",
                    ''                                                                                          LastReadTableVersion.TableName,
                    ''                                                                                          CachedTable.ROW_VERSION_COLUMN_NAME,
                    ''                                                                                          tOldRowVersion.ToString(),
                    ''                                                                                          RowID)
                    ''                                                                                      )
                    ''                                                                                  )

                    ''End If


                Else
                    REM Multi Row Statement
                    If vHandleApostrophe Then
                        UpdateRowVersionQuery = New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}=ISNULL({1},\'\') + \'{2}\' {3}",
                                                                                                                  LastReadTableVersion.TableName,
                                                                                                                  CachedTable.ROW_VERSION_COLUMN_NAME,
                                                                                                                  tCurrentCached.getNewRowVersion().ToString(),
                                                                                                                  WhereClause
                                                                                                                  ), False, vHandleApostrophe
                                                                                                              )
                    Else
                        UpdateRowVersionQuery = New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}=ISNULL({1},'') + '{2}' {3}",
                                                                                                                  LastReadTableVersion.TableName,
                                                                                                                  CachedTable.ROW_VERSION_COLUMN_NAME,
                                                                                                                  tCurrentCached.getNewRowVersion().ToString(),
                                                                                                                  WhereClause
                                                                                                                  ), False, vHandleApostrophe
                                                                                                              )
                    End If

                    ''Result = Me.ReadCommittedDBTransaction2Secs.dbExec(2000, uq) REM delete in 1secs

                    ''REM if it gets here then it updated successfully. That is it didn't timeout or something weird happened
                    ''If uq.affectedRows > 0 Then

                    ''    Me.ReadCommittedDBTransaction2Secs.dbExec(3000,
                    ''                                              New DBConcurrency.DBExecTrans(String.Format("UPDATE {0} SET {1}=ISNULL({1},'') + '{2}' {3}",
                    ''                                                                                          LastReadTableVersion.TableName,
                    ''                                                                                          CachedTable.ROW_VERSION_COLUMN_NAME,
                    ''                                                                                          tCurrentCached.getNewRowVersion().ToString(),
                    ''                                                                                          WhereClause
                    ''                                                                                          )
                    ''                                                                                      )
                    ''                                                                                  )

                    ''End If


                End If

                REM Update RowVersion First and if real query fails then rollback all
                Result = Me.ReadCommittedDBTransaction2Secs.dbExec(3000, UpdateRowVersionQuery, uq) REM delete in 1secs




                If uq.affectedRows > 0 Then
                    REM If updated any row. Reflect On Table Version and show immediately if indicated
                    Dim newExpectingVersion As VersionControlSystem = tCurrentCached.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)
                    If ForceUpdateCachTableImmediately AndAlso newExpectingVersion IsNot Nothing Then Me.CheckTable(tCurrentCached, newExpectingVersion)

                End If



                Return uq.affectedRows
            Catch ex As System.Data.SqlClient.SqlException
                If ex IsNot Nothing And ex.Message.StartsWith("Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.") Then

                    Throw New Exceptions.DataRowLockedException(LastReadTableVersion.TableName)

                Else
                    Logger.Print("dmlUPDATE", ex)
                    Throw ex
                End If
            Catch ex As Exception
                REM if timeout exception then Row(s) is Locked try again
                REM Else .. it might be sql query error

                Logger.Print("dmlUPDATE", ex)
                Throw ex



            End Try





        End Function


        ''' <summary>
        ''' Update a multi row or single row without caring about Dirty Read
        ''' </summary>
        ''' <param name="updateQuery"></param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dmlUPDATE(pTableName As String,
                                  updateQuery As String,
                                   Optional ByVal ForceUpdateCachTableImmediately As Boolean = False,
                                   Optional ByVal vHandleApostrophe As Boolean = False) As Integer

            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            Try


                Dim tCurrentCached As CachedTable = Me.getCachedTableContainer(pTableName)

                Dim uq As New DBConcurrency.DBExecTrans(updateQuery, True, vHandleApostrophe)
                Dim Result As Boolean


                REM Update RowVersion First and if real query fails then rollback all
                Result = Me.ReadCommittedDBTransaction2Secs.dbExec(3000, uq) REM delete in 1secs




                If uq.affectedRows > 0 Then
                    REM If updated any row. Reflect On Table Version and show immediately if indicated
                    Dim newExpectingVersion As VersionControlSystem = tCurrentCached.IncrementVersion(Me.ReadCommittedDBTransaction2Secs, Me.CacheManagerTableName)
                    If ForceUpdateCachTableImmediately AndAlso newExpectingVersion IsNot Nothing Then
                        Me.CheckTable(tCurrentCached, newExpectingVersion)
                    Else
                        Me.ForceInvalidationOfTable(pTableName)
                    End If

                End If



                Return uq.affectedRows
            Catch ex As System.Data.SqlClient.SqlException
                If ex IsNot Nothing And ex.Message.StartsWith("Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.") Then

                    Throw New Exceptions.DataRowLockedException(pTableName)

                Else
                    Logger.Print("dmlUPDATE", ex)
                    Throw ex
                End If
            Catch ex As Exception
                REM if timeout exception then Row(s) is Locked try again
                REM Else .. it might be sql query error

                Logger.Print("dmlUPDATE", ex)
                Throw ex



            End Try

        End Function

#End Region



#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        Public ReadOnly Property IsDisposed As Boolean
            Get
                Return Me.disposedValue
            End Get
        End Property

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                    If Me.thrCachedTablesChecker IsNot Nothing AndAlso Me.thrCachedTablesChecker.IsAlive Then Me.thrCachedTablesChecker.Abort()
                    Me.thrCachedTablesChecker = Nothing

                    Try
                        If Me.CachedTables IsNot Nothing Then
                            For Each cTable As CachedTable In Me.CachedTables.Values
                                If cTable IsNot Nothing Then cTable.Dispose()
                            Next
                        End If
                    Catch ex As Exception
                        Logger.Print("Disposing CachedTables", ex)
                    End Try
                    Me.CachedTables = Nothing


                    Me.DirectConn = Nothing


                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.

        ''' <summary>
        ''' This simply stops the thread from running and set all variables to null
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region




    End Class


End Namespace
