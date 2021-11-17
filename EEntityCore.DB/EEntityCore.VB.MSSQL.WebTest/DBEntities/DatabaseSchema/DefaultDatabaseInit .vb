Namespace DBEntities.DatabaseSchema

    ''' <summary>
    ''' Make sure you initialize this in your app as DatabaseInit.DBConnectInterface = new DatabaseInit(mode)
    ''' </summary>
    ''' <remarks></remarks>
    Public Class DefaultDatabaseInit
        Implements IDatabaseInit











#Region "Constructors"

        ''' <summary>
        ''' Create Default. NOTE: Server name is not required for FULL_SERVER MODE.
        ''' </summary>
        ''' <param name="pServerName">with intance name if any like PC\sqlexpress for client modes but for server mode [ Just the SQL Server InstanceName like sqlserver2014 ]</param>
        ''' <param name="pDatabaseName">This is very important. the name of the database you are connecting to like [Master]</param>
        ''' <param name="pUserName">this is not needed for server mode if server is not allowing clients connection</param>
        ''' <param name="pUserPassword">this is not needed for server mode if server is not allowing clients connection</param>
        ''' <param name="pPort">this is not needed for server mode if server is not allowing clients connection</param>
        ''' <remarks></remarks>
        Sub New(
                ByVal pDatabaseName As String,
                Optional ByVal pUserName As String = "",
                Optional ByVal pUserPassword As String = "",
                Optional ByVal pPort As Int32 = 1433,
                Optional ByVal pServerName As String = ""
                                                       )

            Me.ServerName = pServerName
            Me.UserName = pUserName
            Me.UserPassword = pUserPassword
            Me.DatabaseName = pDatabaseName
            Me.Port = pPort


            Me.___DBInit = New DatabaseInit(Me)

        End Sub


#End Region






#Region "Properties"

        Private ___DBInit As DatabaseInit
        Public ReadOnly Property DBInit As DatabaseInit
            Get
                Return Me.___DBInit
            End Get
        End Property


        Private ServerName As String, DatabaseName As String, UserName As String, UserPassword As String,
            Port As Int32



#End Region



#Region "Methods"




#End Region






        Public Function DBName() As String Implements IDatabaseInit.DBName
            Return Me.DatabaseName
        End Function

        Public Function DBUserName() As String Implements IDatabaseInit.DBUserName
            Return Me.UserName
        End Function

        Public Function DBUserPassword() As String Implements IDatabaseInit.DBUserPassword
            Return Me.UserPassword
        End Function

        Public Function ServerIPAddressOrName() As String Implements IDatabaseInit.ServerIPAddressOrName
            Return Me.ServerName
        End Function

        Public Function ServerPort() As Integer Implements IDatabaseInit.ServerPort
            Return Me.Port
        End Function

    End Class

End Namespace