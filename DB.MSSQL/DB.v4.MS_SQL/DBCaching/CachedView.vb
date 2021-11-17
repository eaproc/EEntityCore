Imports System.Threading
Imports System.Runtime.Serialization

Imports CODERiT.Logger.v._3._5

Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v3._5.AppConfigurations

Imports DB.v4.MS_SQL.Interfaces


Namespace DBCaching



    ''' <summary>
    ''' Each View in CacheManager. Depends on tables and views
    ''' </summary>
    ''' <remarks></remarks>
    Public Class CachedView
        Implements IDisposable, Interfaces.INotifyTableChanged, IDataSubscribableObject






#Region "Constructors"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="pView"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pView As IDBViewDefinitionPlugIn)
            Me._viewName = pView.getViewName()
            Me.dependsOnTables = pView.getReferencedTableNames().ToArray()

            REM Non serialized initializers
            Me.LockviewChangedNotifierUpdate = New Object()
            Me.LockGivingOutDataView = New Object()
            Me.ViewChangedSubcribers = New List(Of CachedObjectSubscriber)()

        End Sub

        '' ''' <summary>
        '' ''' 
        '' ''' </summary>
        '' ''' <param name="_viewName"></param>
        '' ''' <param name="__dependsOnTables">The tables it depends on to populate</param>
        '' ''' <remarks></remarks>
        ''Public Sub New(ByVal _viewName As String,
        ''               ParamArray __dependsOnTables() As String
        ''        )
        ''    Me._viewName = _viewName
        ''    Me.dependsOnTables = __dependsOnTables

        ''    REM Non serialized initializers
        ''    Me.LockviewChangedNotifierUpdate = New Object()
        ''    Me.LockGivingOutDataView = New Object()
        ''    Me.ViewChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)()

        ''End Sub


#End Region

#Region "Properties"

        Private ________Parent As DBCacheManager
        Private ________hasViewBeenCalled As Boolean

        Private dependsOnTables As String()

        Friend ReadOnly Property DependentOnTables() As String()
            Get
                Return Me.dependsOnTables
            End Get
        End Property


        Private _viewName As String

        REM <NonSerialized()> _
        Private _Rawview As DataTable  REM only used temporary after a process just fetch new data from database
        Private ___GivingOutDataView As DataTable
        REM <NonSerialized()> _
        Private ViewChangedSubcribers As List(Of DBCaching.CachedObjectSubscriber)

        'Public ReadOnly Property viewFillQuery As String
        '    Get
        '        Return Me._fillSQLQuery
        '    End Get
        'End Property


        Public ReadOnly Property ViewName As String
            Get
                Return Me._viewName
            End Get
        End Property


        ''' <summary>
        ''' Locks giving out table for update while giving it out to user
        ''' </summary>
        ''' <remarks></remarks>
        Private LockGivingOutDataView As Object
        ''' <summary>
        ''' Gets the Dataview Copy we are giving out to user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend ReadOnly Property GivingOutDataview As DataTable
            Get
                If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
                If Not Me.________hasViewBeenCalled AndAlso Me.___GivingOutDataView Is Nothing Then
                    Me.LoadView()
                End If

                Me.________hasViewBeenCalled = True

                SyncLock LockGivingOutDataView
                    Return Me.___GivingOutDataView
                End SyncLock

            End Get
        End Property


        Private SnapShotDBReader As DBConcurrency.SQLDatabaseTransactionManager

        Private Property Logger As Log1


#End Region

#Region "Consts and Structures"

#End Region




        REM We need cached Blob Columns here
        REM Delete All Blob Rows Not available on view



#Region "Methods"

        Private Sub SubscribeTo(pTableOrViewName As String)
            REM Since this a view, there is possibility it depends on other view
            If Me.________Parent.hasTable(pTableOrViewName) Then
                Me.________Parent.subscribeToTableChange(pTableOrViewName, Me)
            ElseIf Me.________Parent.hasView(pTableOrViewName) Then
                Me.________Parent.subscribeToViewChange(pTableOrViewName, Me)
            Else
                Throw New Exception(String.Format("{0} view can not subscribe to this item {1}. It is not available in the cache.",
                                                   Me.ViewName, pTableOrViewName
                                                   )
                                               )
            End If
        End Sub

        ''' <summary>
        ''' Do this on constructor before subscription. It tries to load view and notify subscribers
        ''' </summary>
        ''' <param name="s"></param>
        ''' <remarks></remarks>
        Friend Sub setSnapshotReader(s As DBConcurrency.SQLDatabaseTransactionManager,
                                     _parent As DBCacheManager,
                                     pLoadView As Boolean
                                     )
            Me.SnapShotDBReader = s
            Me.________Parent = _parent
            Me.Logger = DBCacheManager.Logger

            If Me.DependentOnTables IsNot Nothing Then
                For Each dot As String In Me.DependentOnTables

                    Me.SubscribeTo(dot)
                Next
            End If

            If pLoadView Then Me.LoadView()

        End Sub

        Friend Sub LoadView()

            Dim TryAgainCount As Byte = 0

START_ALL_OVER:
            Try
                REM To avoid deadlock
                REM Load tables first before notifying
                SyncLock Me.LockviewChangedNotifierUpdate

                    SyncLock Me.LockGivingOutDataView
                        Dim rs As DataSet = Me.SnapShotDBReader.getRS(New DBConcurrency.GetRSTrans(Me.getFillSQL(), True))
                        If rs IsNot Nothing Then Me._Rawview = rs.Tables(0) : Me.CopyTemporaryviewToRealview()

                    End SyncLock
                End SyncLock

                Me.NotifyAllviewChangedSubscribers()

            Catch ex As Exception
                Me.Logger.Print("Error Loading View: " & Me.ViewName, ex)

                If ex.Message.StartsWith("A transport-level error has occurred when sending the request to the server") AndAlso
                    TryAgainCount < 2 Then
                    Me.Logger.Print("Perhaps due to your RAM or CPU usage, SQL Server is not responding well. We are trying again to load this view.")
                    TryAgainCount += CByte(1)
                    GoTo START_ALL_OVER
                End If

            End Try
        End Sub

        Friend Function getFillSQL() As String
            REM  If Me.viewFillQuery IsNot Nothing AndAlso Me.viewFillQuery.Trim() <> String.Empty Then Return Me.viewFillQuery
            Return "SELECT * FROM " & Me.ViewName
        End Function



        ''' <summary>
        ''' Transfer the Temporary view to the view giving to the user
        ''' </summary>
        ''' <remarks></remarks>
        Friend Sub CopyTemporaryviewToRealview()

            Me.___GivingOutDataView = Me._Rawview
            Me.___GivingOutDataView.TableName = Me.ViewName
            REM Me._Rawview = New Dataview("FakeIT")
        End Sub



#Region "Subscription"

        REM <NonSerialized()> _
        ''' <summary>
        ''' For monitoring subscribing and unsubscribing during notfication
        ''' </summary>
        ''' <remarks></remarks>
        Private LockviewChangedNotifierUpdate As Object
        Friend Sub NotifyDataChangedSubscriber(pSubscriber As DBCaching.Interfaces.INotifyTableChanged) Implements IDataSubscribableObject.NotifyDataChangedSubscriber
            REM SyncLock Removing and adding subscription ASYNC or SYNC DEFAULT ASYNC
            REM Remove all subscribers on Notified
            If Me.IsDisposed Then Return

            REM If Me.TableChangedSubcribers Is Nothing Then Me.TableChangedSubcribers = New List(Of Interfaces.INotifyTableChanged)() REM Incase this was deserialized
            Dim tcs As DBCaching.Interfaces.INotifyTableChanged = pSubscriber
            Try
                REM Async
                Dim thrNotify As New Thread(Sub() tcs.TableChangedEventOccurred(Me.ViewName))
                thrNotify.IsBackground = True
                thrNotify.SetApartmentState(ApartmentState.MTA)
                thrNotify.Start()

            Catch ex As Exception
                Program.Logger.Print(ex)
            End Try


        End Sub

        Friend Sub NotifyAllviewChangedSubscribers() Implements IDataSubscribableObject.NotifyAllDataChangedSubscribers
            REM SyncLock Removing and adding subscription ASYNC or SYNC DEFAULT ASYNC
            REM Remove all subscribers on Notified
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)

            SyncLock Me.LockviewChangedNotifierUpdate
                REM If Me.viewChangedSubcribers Is Nothing Then Me.viewChangedSubcribers = New List(Of Interfaces.INotifyviewChanged)() REM Incase this was deserialized
                For Each tcs In Me.ViewChangedSubcribers
                    RemoveHandler CType(tcs.Subscriber, Interfaces.INotifyTableChanged).Disposed, AddressOf Me.NotifyComponentDisposed
                    tcs.InitiateNotification()
                Next

                Me.ViewChangedSubcribers.Clear()

            End SyncLock

        End Sub

        Friend Sub subcribeUserForviewChanged(pNotifyReceiver As DBCaching.Interfaces.INotifyTableChanged,
                                               pIntervalInMillisecs As Int32) Implements IDataSubscribableObject.subcribeUserForDataChanged
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            SyncLock Me.LockviewChangedNotifierUpdate
                REM If Me.viewChangedSubcribers Is Nothing Then Me.viewChangedSubcribers = New List(Of Interfaces.INotifyviewChanged)() REM Incase this was deserialized
                If DBCaching.CachedObjectSubscriber.Contains(
                   Me.ViewChangedSubcribers, pNotifyReceiver) Is Nothing Then
                    Me.ViewChangedSubcribers.Add(
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

        Friend Sub unsubcribeUserFromviewChanged(pNotifier As DBCaching.Interfaces.INotifyTableChanged) Implements IDataSubscribableObject.unsubcribeUserFromDataChanged
            If Me.IsDisposed Then Throw New ObjectDisposedException(Me.GetType().FullName)
            SyncLock Me.LockviewChangedNotifierUpdate
                REM If Me.viewChangedSubcribers Is Nothing Then Me.viewChangedSubcribers = New List(Of Interfaces.INotifyviewChanged)() REM Incase this was deserialized
                Dim p = CachedObjectSubscriber.Contains(Me.ViewChangedSubcribers, pNotifier)

                If p IsNot Nothing Then
                    Me.ViewChangedSubcribers.Remove(p)

                    p.Dispose()

                    ''Else
                    ''    Program.Logger.Print("Me.ViewChangedSubcribers.Count: " & Me.ViewChangedSubcribers.Count)
                    ''    If Me.ViewChangedSubcribers.Count > 0 Then
                    ''        Dim d = Me.ViewChangedSubcribers.First().Subscriber
                    ''        If TypeOf d Is System.Windows.Forms.Control Then _
                    ''        Program.Logger.Print("Me.ViewChangedSubcribers.Name: " &
                    ''            CType(Me.ViewChangedSubcribers.First().Subscriber, System.Windows.Forms.Control).Name
                    ''            )

                    ''    End If
                End If
              

                p = Nothing
            End SyncLock
        End Sub


        Private Sub NotifyComponentDisposed(sender As Object, e As EventArgs)
            Me.unsubcribeUserFromviewChanged(CType(sender, Interfaces.INotifyTableChanged))
            RemoveHandler CType(sender, Interfaces.INotifyTableChanged).Disposed, AddressOf Me.NotifyComponentDisposed
        End Sub


#End Region


#Region "Interfaces.INotifyTableChanged Implementations"

        Public Sub TableChangedEventOccurred(TableName As String) Implements Interfaces.INotifyTableChanged.TableChangedEventOccurred
            If Me.DependentOnTables IsNot Nothing AndAlso Me.DependentOnTables.Contains(TableName) Then
                Me.LoadView()
                REM Resubscribe
                Me.SubscribeTo(TableName)

            End If
        End Sub

        Public Event Disposed(sender As Object, e As EventArgs) Implements ComponentModel.IComponent.Disposed

        Public Property Site As ComponentModel.ISite Implements ComponentModel.IComponent.Site


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
                    SyncLock Me.LockviewChangedNotifierUpdate
                        ' TODO: dispose managed state (managed objects).
                        If Me.ViewChangedSubcribers IsNot Nothing Then Me.ViewChangedSubcribers.Clear()
                        Me.ViewChangedSubcribers = Nothing
                    End SyncLock
                    Me.___GivingOutDataView = Nothing

                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
                RaiseEvent Disposed(Me, New System.EventArgs())
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


#End Region

       






     
    End Class


End Namespace