Imports System.Threading
Imports System.Runtime.Serialization

Imports CODERiT.Logger.v._3._5
Imports CODERiT.Logger.v._3._5.Exceptions

Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v3._5.AppConfigurations

Imports DB.v4.MS_SQL.Interfaces


Namespace DBCaching



    ''' <summary>
    ''' Each table in CacheManager
    ''' </summary>
    ''' <remarks></remarks>
    <Serializable()> _
    Public Class CachedTable
        Implements IDisposable, ISerializable, IDataSubscribableObject



#Region "Constructors"

        ''' <summary>
        ''' All tables must have ID (int) and RowVersion (varchar(150)) Column
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New(pTable As IDBTableDefinitionPlugIn)
            Me._tableName = pTable.getTableName()
            Me._fillSQLQuery = pTable.getFillSQL()
            Me._____ForeignKeys = pTable.getForeignKeys()

            Me._cacheBlobColumns = False
            Me._blobColumns = String.Empty
            Me._TableVersion = New VersionControlSystem(String.Empty, TABLE_VERSION_EACH_COMP_LENGTH, True)


            REM Non serialized initializers
            Me.TableChangedSubcribers = New List(Of DBCaching.CachedObjectSubscriber)()
            Me.LockTableChangedNotifierUpdate = New Object()

        End Sub

        '' ''' <summary>
        '' ''' All tables must have ID (int) and RowVersion (varchar(150)) Column
        '' ''' </summary>
        '' ''' <param name="_tableName"></param>
        '' ''' <param name="_fillSQLQuery"></param>
        '' ''' <param name="_cacheBlobColumns"></param>
        '' ''' <param name="_blobColumns"></param>
        '' ''' <remarks></remarks>
        ''Public Sub New(ByVal _tableName As String,
        ''        Optional ByVal _fillSQLQuery As String = "",
        ''        Optional ByVal _cacheBlobColumns As Boolean = False,
        ''        Optional ByVal _blobColumns As String = ""
        ''        )
        ''    Me._tableName = _tableName
        ''    Me._fillSQLQuery = If(_fillSQLQuery Is Nothing, String.Empty, _fillSQLQuery).ToString()
        ''    Me._cacheBlobColumns = _cacheBlobColumns
        ''    Me._blobColumns = If(_blobColumns Is Nothing, String.Empty, _blobColumns).ToString()
        ''    Me._TableVersion = New VersionControlSystem(String.Empty, TABLE_VERSION_EACH_COMP_LENGTH, True)


        ''    REM Non serialized initializers
        ''    Me.TableChangedSubcribers = New List(Of DBCaching.Interfaces.INotifyTableChanged)()
        ''    Me.LockTableChangedNotifierUpdate = New Object()

        ''End Sub


#Region "ISerializable Implementation"

        Protected Sub New(info As SerializationInfo, context As StreamingContext)

            Me._tableName = info.GetString("_tableName")
            Me._fillSQLQuery = info.GetString("_fillSQLQuery")
            Me._cacheBlobColumns = info.GetBoolean("_cacheBlobColumns")
            Me._blobColumns = info.GetString("_blobColumns")
            Me._TableVersion = CType(info.GetValue("_TableVersion", GetType(VersionControlSystem)), VersionControlSystem)
            Me.___GivingOutDataTable = CType(info.GetValue("___GivingOutDataTable", GetType(DataTable)), DataTable)
            If Me.___GivingOutDataTable IsNot Nothing Then Me.___GivingOutDataTable.TableName = Me.TableName

            Me.TableChangedSubcribers = New List(Of DBCaching.CachedObjectSubscriber)()
            Me.LockTableChangedNotifierUpdate = New Object()
        End Sub

        Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
            info.AddValue("_tableName", Me._tableName)
            info.AddValue("_fillSQLQuery", Me._fillSQLQuery)
            info.AddValue("_cacheBlobColumns", _cacheBlobColumns)
            info.AddValue("_blobColumns", Me._blobColumns)
            info.AddValue("_TableVersion", Me._TableVersion)
            info.AddValue("___GivingOutDataTable", Me.___GivingOutDataTable)

        End Sub

#End Region



#End Region

#Region "Properties"

        Private ________Parent As DBCacheManager

        ''' <summary>
        ''' Indicate if table has been called at from giving table
        ''' </summary>
        ''' <remarks></remarks>
        Private ________hasTableBeenCalled As Boolean

        Private _tableName As String
        Private _fillSQLQuery As String
        Private _cacheBlobColumns As Boolean
        Private _blobColumns As String
        Private _TableVersion As VersionControlSystem
        REM <NonSerialized()> _
        Private _RawTable As DataTable REM only used temporary after a process just fetch new data from database
        Private ___GivingOutDataTable As DataTable
        REM <NonSerialized()> _
        Private TableChangedSubcribers As List(Of DBCaching.CachedObjectSubscriber)

        Private _____ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)


        Public ReadOnly Property TableVersion As VersionControlSystem
            Get
                Return Me._TableVersion
            End Get
        End Property

        Public ReadOnly Property BlobColumns As String
            Get
                Return Me._blobColumns
            End Get
        End Property

        Public ReadOnly Property TableFillQuery As String
            Get
                Return Me._fillSQLQuery
            End Get
        End Property

        Public ReadOnly Property CacheBlobColumns As Boolean
            Get
                Return Me._cacheBlobColumns
            End Get
        End Property

        Public ReadOnly Property TableName As String
            Get
                Return Me._tableName
            End Get
        End Property


        Private __IsLocked As Boolean
        Public ReadOnly Property IsLocked As Boolean
            Get
                Return Me.__IsLocked
            End Get
        End Property

        ''' <summary>
        ''' Gets the DataTable Copy we are giving out to user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend ReadOnly Property GivingOutDataTable As DataTable
            Get
                If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
                If Not Me.________hasTableBeenCalled AndAlso Me.___GivingOutDataTable Is Nothing Then
                    Me.________Parent.CheckTable(Me, Me.TableVersion)
                End If

                Me.________hasTableBeenCalled = True
                Return Me.___GivingOutDataTable
            End Get
        End Property



#End Region

#Region "Consts and Structures"
        Public Const ROW_VERSION_FIXED_LENGTH As Byte = 15
        Public Const ROW_VERSION_EACH_COMP_LENGTH As Byte = 3
        Public Const ROW_VERSION_COLUMN_NAME As String = "RowVersion"
        Public Const TABLE_VERSION_FIXED_LENGTH As Byte = 35
        Public Const TABLE_VERSION_EACH_COMP_LENGTH As Byte = 8



        ''' <summary>
        ''' Use for keeping the copy you read last for reference purpose
        ''' </summary>
        ''' <remarks></remarks>
        Public Structure CollectedTableCopy
            'Friend Sub New(ByVal __Table As DataTable,
            '                ByVal __TableVersion As VersionControlSystem)

            '    If __Table Is Nothing Then Throw New Exception("You can not pass in null table")

            '    Me._____Table = __Table
            '    Me._____TableVersion = __TableVersion

            'End Sub

            Friend Sub New(ByVal __Table As DataTable)

                REM If __Table Is Nothing Then Throw New EException("You can not pass in null table", New Exception(Environment.StackTrace))

                Me._____Table = __Table
                ' Me._____TableVersion = __TableVersion

            End Sub

            Private _____Table As DataTable REM, _____TableVersion As VersionControlSystem


            Public ReadOnly Property Table As DataTable
                Get
                    Return Me._____Table
                End Get
            End Property


            Public ReadOnly Property TableName As String
                Get
                    If Me.Table Is Nothing Then Return String.Empty
                    Return Me.Table.TableName
                End Get
            End Property


            'Public ReadOnly Property TableVersion As VersionControlSystem
            '    Get
            '        Return Me._____TableVersion
            '    End Get
            'End Property


            ''' <summary>
            ''' Get the version of this RowID
            ''' </summary>
            ''' <param name="ID"></param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Friend Function getDataRowVersion(ID As UInt32) As VersionControlSystem
                Return getDataRowVersion(Me.Table, ID)
            End Function

            ''' <summary>
            ''' Get the version of this RowID
            ''' </summary>
            ''' <param name="ID"></param>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Friend Shared Function getDataRowVersion(dTable As DataTable,
                                                     ID As UInt32) As VersionControlSystem
                Try
                    If dTable Is Nothing Then Return New VersionControlSystem(String.Empty)

                    Dim drs As IEnumerable(Of DataRow) = From dr As DataRow In dTable.Rows.Cast(Of DataRow)()
                                                         Where dr("ID").ToString().toInt32() = ID
                                                         Select dr


                    Return New VersionControlSystem(drs(0)(ROW_VERSION_COLUMN_NAME).ToString(), ROW_VERSION_EACH_COMP_LENGTH, True)

                Catch ex As Exception
                    DBCacheManager.Logger.Print(ex)
                End Try

                Return Nothing
            End Function




        End Structure


#End Region




        REM We need cached Blob Columns here
        REM Delete All Blob Rows Not available on Table

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
                    SyncLock Me.LockTableChangedNotifierUpdate
                        ' TODO: dispose managed state (managed objects).
                        If Me.TableChangedSubcribers IsNot Nothing Then Me.TableChangedSubcribers.Clear()
                        Me.TableChangedSubcribers = Nothing
                    End SyncLock
                    Me.___GivingOutDataTable = Nothing

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
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region


#Region "Methods"

        Friend Function IsReferencingOnCascadeDELETE(ByVal pTableName As String) As Boolean
            If Me._____ForeignKeys Is Nothing OrElse Me._____ForeignKeys.Count = 0 Then Return False
            Dim dRef As IEnumerable(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition) =
                From d As IDBTableDefinitionPlugIn.ForeignKeyDefinition In Me._____ForeignKeys
                Where d.ReferencedParentName.equalsIgnoreCase(pTableName) AndAlso
                Not d.is_disabled AndAlso d.delete_referential_action_desc = IDBTableDefinitionPlugIn.ReferentialAction.CASCADE
                Select d

            Return dRef IsNot Nothing AndAlso dRef.Count() > 0
        End Function

        ''' <summary>
        ''' This will force checker thread to reload this table from database. 
        ''' NOTE: INVALIDATION Does not really alter the table version.
        ''' It just makes it invalid temporarily for checker thread to reload and assume the version on database
        ''' </summary>
        ''' <remarks>It simply makes the version available locally different from the one dbcachemanager has</remarks>
        Friend Sub InvalidateTable()
            Try
                Me._TableVersion.Increase()
            Catch ex As Exception
                DBCacheManager.Logger.Print("Error Invalidating Table: " & Me.TableName, ex)
            End Try
        End Sub

        Friend Sub SetIsLock(pVal As Boolean)
            Me.__IsLocked = pVal
        End Sub

        Friend Sub SetVersion(vcs As VersionControlSystem)

            Me._TableVersion = New VersionControlSystem(vcs.ToString(), TABLE_VERSION_EACH_COMP_LENGTH, True)


        End Sub

        Friend Sub SetRawTable(rw As DataTable)
            Me._RawTable = rw
        End Sub

        Friend Sub setParent(pParent As DBCacheManager)
            Me.________Parent = pParent
        End Sub

        Friend Function getFillSQL() As String
            If Me.TableFillQuery IsNot Nothing AndAlso Me.TableFillQuery.Trim() <> String.Empty Then Return Me.TableFillQuery
            Return "SELECT * FROM " & Me.TableName
        End Function


        ''' <summary>
        ''' Get DataRows with invalid VersionControls
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function getRowsToNormalize() As List(Of DataRow)
            If Me._RawTable Is Nothing Then Return Nothing
            Try

                Dim drs As IEnumerable(Of DataRow) = From dr As DataRow In Me._RawTable.Rows.Cast(Of DataRow)()
                                                     Where dr(ROW_VERSION_COLUMN_NAME).ToString().Length > ROW_VERSION_FIXED_LENGTH
                                                     Select dr


                Return drs.ToList()
            Catch ex As Exception
                DBCacheManager.Logger.Print(ex)
            End Try

            Return Nothing
        End Function


        ''' <summary>
        ''' Get the version of this RowID
        ''' </summary>
        ''' <param name="ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function getDataRowVersion(ID As UInt32) As VersionControlSystem
            Return CollectedTableCopy.getDataRowVersion(Me.___GivingOutDataTable, ID)
        End Function


        ''' <summary>
        ''' Transfer the Temporary Table to the Table giving to the user
        ''' </summary>
        ''' <remarks></remarks>
        Friend Sub CopyTemporaryTableToRealTable()
            Me.___GivingOutDataTable = Me._RawTable
            Me.___GivingOutDataTable.TableName = Me.TableName
            REM Me._RawTable = New DataTable("FakeIT")
        End Sub


        Friend Sub DeleteInvalidBlobs()
            REM Delete All Blob Rows Not available on Table
        End Sub


#Region "Subscription"

        REM <NonSerialized()> _
        Private LockTableChangedNotifierUpdate As Object
        Friend Sub NotifyDataChangedSubscriber(pSubscriber As DBCaching.Interfaces.INotifyTableChanged) Implements IDataSubscribableObject.NotifyDataChangedSubscriber
            REM SyncLock Removing and adding subscription ASYNC or SYNC DEFAULT ASYNC
            REM Remove all subscribers on Notified
            If Me.IsDisposed Then Return

            REM If Me.TableChangedSubcribers Is Nothing Then Me.TableChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)() REM Incase this was deserialized
            Dim tcs As DBCaching.Interfaces.INotifyTableChanged = pSubscriber
            Try
                REM Async
                Dim thrNotify As New Thread(Sub() tcs.TableChangedEventOccurred(Me.TableName))
                thrNotify.IsBackground = True
                thrNotify.SetApartmentState(ApartmentState.MTA)
                thrNotify.Start()

            Catch ex As Exception
                Program.Logger.Print(ex)
            End Try


        End Sub


        Friend Sub NotifyAllDataChangedSubscribers() Implements IDataSubscribableObject.NotifyAllDataChangedSubscribers
            REM SyncLock Removing and adding subscription ASYNC or SYNC DEFAULT ASYNC
            REM Remove all subscribers on Notified
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            SyncLock Me.LockTableChangedNotifierUpdate
                REM If Me.TableChangedSubcribers Is Nothing Then Me.TableChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)() REM Incase this was deserialized
                For Each tcs In Me.TableChangedSubcribers
                    RemoveHandler CType(tcs.Subscriber, Interfaces.INotifyTableChanged).Disposed, AddressOf Me.NotifyComponentDisposed
                    tcs.InitiateNotification()
                Next

                Me.TableChangedSubcribers.Clear()

            End SyncLock

        End Sub

        Friend Sub subcribeUserForDataChanged(pNotifyReceiver As DBCaching.Interfaces.INotifyTableChanged,
                                               pIntervalInMillisecs As Int32) Implements IDataSubscribableObject.subcribeUserForDataChanged
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            SyncLock Me.LockTableChangedNotifierUpdate
                REM If Me.TableChangedSubcribers Is Nothing Then Me.TableChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)() REM Incase this was deserialized
                If DBCaching.CachedObjectSubscriber.Contains(
                    Me.TableChangedSubcribers, pNotifyReceiver) Is Nothing Then


                    Me.TableChangedSubcribers.Add(
                        New DBCaching.CachedObjectSubscriber(
                                                   pNotifyReceiver,
                                                   AddressOf Me.NotifyDataChangedSubscriber,
                                                   pIntervalInMillisecs
                                                   )
                                               )
                    AddHandler pNotifyReceiver.Disposed, AddressOf Me.NotifyComponentDisposed
                End If
            End SyncLock
        End Sub

        Friend Sub unsubcribeUserFromDataChanged(pNotifier As DBCaching.Interfaces.INotifyTableChanged) Implements IDataSubscribableObject.unsubcribeUserFromDataChanged
            If Me.IsDisposed Then Return ' Since you are trying to unsubscribe and this table is disposed Throw New ObjectDisposedException(Me.GetType().FullName)
            SyncLock Me.LockTableChangedNotifierUpdate
                REM If Me.TableChangedSubcribers Is Nothing Then Me.TableChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)() REM Incase this was deserialized
                Dim p = CachedObjectSubscriber.Contains(Me.TableChangedSubcribers, pNotifier)

                If p IsNot Nothing Then

                    Me.TableChangedSubcribers.Remove(p)
                    p.Dispose()
               
                End If
              

                p = Nothing

            End SyncLock
        End Sub


        Private Sub NotifyComponentDisposed(sender As Object, e As EventArgs)
            Me.unsubcribeUserFromDataChanged(CType(sender, Interfaces.INotifyTableChanged))
            RemoveHandler CType(sender, Interfaces.INotifyTableChanged).Disposed, AddressOf Me.NotifyComponentDisposed
        End Sub


#End Region



        ''' <summary>
        ''' Only increment this table and save on database. IT DOES NOT INCREMENT THE REAL VERSION OF THIS TABLE. that should be done under check table
        ''' </summary>
        ''' <param name="transMgr">ReadCommitted Class to use for the transaction</param>
        ''' <param name="dcmTableName">DBCaching Manger TableName</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function IncrementVersion(ByVal transMgr As DBConcurrency.ReadCommittedTransactionManager,
                                    ByVal dcmTableName As String) As VersionControlSystem
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            Try


                Dim newExpectingVersion As VersionControlSystem = Me.TableVersion.Clone()
                newExpectingVersion.Increase()

                If transMgr.dbExec(5000, New DBConcurrency.DBExecTrans(
                                String.Format(
                                    "UPDATE {0} SET {1}='{2}' WHERE {3}='{4}'",
                                    dcmTableName, DBCacheManagerTable.dcmTableColumns.TableVersion.ToString(),
                                    newExpectingVersion.ToString(),
                                    DBCacheManagerTable.dcmTableColumns.TableName.ToString(),
                                    Me.TableName
                                 )
                             )
                         ) Then Return newExpectingVersion

            Catch ex As Exception
                Throw ex
            End Try


            Return Nothing

        End Function

        ''' <summary>
        ''' Returns empty row version
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getNewRowVersion() As VersionControlSystem
            Return New VersionControlSystem(ROW_VERSION_EACH_COMP_LENGTH, True)
        End Function

#End Region

      
     











    End Class


End Namespace