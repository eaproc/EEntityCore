Imports CODERiT.Logger.Standard.VB
Imports EEntityCore.DB
Imports EEntityCore.DB.MSSQL
Imports EEntityCore.DB.MSSQL.Interfaces

Namespace DBEntities.DatabaseSchema

    ''' <summary>
    ''' Make sure you initialize this in your app as DatabaseInit.DBConnectInterface = new DatabaseInit(mode). This class only points to your connection. You can override it
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DatabaseInit
        Implements ISQLServerDBPointer, IDisposable




        REM New Discovery
        REM If Initial Catalog is not specified in connection string, it connects as master


#Region "Constructors"


        Sub New(
                pParent As IDatabaseInit)

            Me.Parent = pParent
        End Sub


#End Region




#Region "Enums and Consts"




#End Region


#Region "Properties"

        Private Parent As IDatabaseInit

        ''' <summary>
        ''' You are responsible for initializing this
        ''' </summary>
        ''' <remarks></remarks>
        Public Shared DBConnectInterface As DatabaseInit



        ''' <summary>
        ''' All usage of DBConn must handle exception
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private ReadOnly Property DBConnClientRemote As Abstracts.All__DBs
            Get

                Return New Client(Me.Parent.ServerIPAddressOrName, Me.Parent.ServerPort,
                                    Me.Parent.DBUserName, Me.Parent.DBUserPassword, Me.Parent.DBName
                                    )


            End Get
        End Property


        Public Shared ReadOnly Property Logger As Log1
            Get
                Return Server.Logger
            End Get
        End Property


#End Region



#Region "Methods"

        Public Function getDBConn() As Server Implements ISQLServerDBPointer.getDBConn
            Return CType(DBConnClientRemote, Server)
        End Function

#End Region




#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
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