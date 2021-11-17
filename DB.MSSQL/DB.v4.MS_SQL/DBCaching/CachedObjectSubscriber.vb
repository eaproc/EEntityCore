Imports System.Threading
Imports EPRO.Library.v3._5.Objects

Namespace DBCaching


    Friend Class CachedObjectSubscriber
        Implements IDisposable



        Private __________thrTimedNotifier As Thread
        Private __________subscriptionIntervalInMillisecs As Int32
        Private __________subscriber As Interfaces.INotifyTableChanged
        Private __________eventHandler As notifySubscriber
        Private __________subscriptionTime As DateTime
        Private __________threadCreated As Boolean



        Public ReadOnly Property Subscriber As Interfaces.INotifyTableChanged
            Get
                Return Me.__________subscriber
            End Get
        End Property


        Friend Delegate Sub notifySubscriber(pSubscriber As Interfaces.INotifyTableChanged)








        Public Sub New(pSubscriber As Interfaces.INotifyTableChanged,
                       pHandler As notifySubscriber
                       )
            Me.New(pSubscriber, pHandler, 0)
        End Sub

        Public Sub New(pSubscriber As Interfaces.INotifyTableChanged,
                       pHandler As notifySubscriber,
                       pIntervalInMillisecs As Int32)
            Me.__________subscriber = pSubscriber
            Me.__________subscriptionIntervalInMillisecs = pIntervalInMillisecs
            Me.__________eventHandler = pHandler
            Me.__________subscriptionTime = Now
            Me.__________threadCreated = False


        End Sub








        Private Sub run()
            Try
                Dim pTimeSpent = EDateTime.GetTimeDifferenceInMilliseconds(Me.__________subscriptionTime, Now)
                If Me.__________subscriptionIntervalInMillisecs > pTimeSpent Then
                    Thread.Sleep(
                        EInt.valueOf(Me.__________subscriptionIntervalInMillisecs - pTimeSpent)
                     )

                End If
                


                If Me.__________eventHandler IsNot Nothing Then _
                    Me.__________eventHandler(Me.__________subscriber)


            Catch ex As ThreadAbortException

            Catch ex As Exception
                Program.Logger.Print(ex)

            Finally
                Me.__________threadCreated = False
            End Try
            Program.Logger.Print(Thread.CurrentThread.Name & " is quiting ...")
        End Sub





        Public Sub InitiateNotification()

            If Me.__________threadCreated Then Return


            Dim pTimeSpent = EDateTime.GetTimeDifferenceInMilliseconds(Me.__________subscriptionTime, Now)
            If Me.__________subscriptionIntervalInMillisecs > pTimeSpent Then

                Me.__________thrTimedNotifier = New Thread(AddressOf Me.run) With {
                    .Name = "__________thrTimedNotifier",
                    .IsBackground = True
                }
                Me.__________thrTimedNotifier.SetApartmentState(ApartmentState.MTA)
                Me.__________thrTimedNotifier.Start()
                Me.__________threadCreated = True

            Else
                Me.__________eventHandler(Me.__________subscriber)
            End If


        End Sub












        ''' <summary>
        ''' Returns nothing if not found
        ''' </summary>
        ''' <param name="pPool"></param>
        ''' <param name="pCheck"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Contains(pPool As IEnumerable(Of CachedObjectSubscriber),
                                        pCheck As Interfaces.INotifyTableChanged
                                        ) As CachedObjectSubscriber

            If pPool Is Nothing OrElse pCheck Is Nothing Then Return Nothing

            Dim dr = (
                From p In pPool
                    Where p.Subscriber.Equals(pCheck)
                    Select p
                    ).ToList()

            If dr.Count = 0 Then Return Nothing

            Return dr.First()

        End Function









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
                    If Me.__________thrTimedNotifier IsNot Nothing AndAlso Me.__________thrTimedNotifier.IsAlive Then _
                        Me.__________thrTimedNotifier.Abort()
                    Me.__________thrTimedNotifier = Nothing

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

    End Class


End Namespace
