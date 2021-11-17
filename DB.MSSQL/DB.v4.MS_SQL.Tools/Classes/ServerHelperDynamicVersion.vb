
Imports System.Windows.Forms
Imports System.IO
Imports System.Security


Imports EPRO.WaitAsyncMgr

Imports EPRO.Library.v3._5
Imports EPRO.Library.v3._5.AppConfigurations
Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v3._5.Objects

Imports EPRO.Library.v4.Shell



Imports CODERiT.Logger.v._3._5.Exceptions

Imports DB.v4.MS_SQL.Tools.Exceptions
Imports DB.v4.MS_SQL.Exceptions



''' <summary>
''' Contains Optional Functions. ONLY If you want to use my database structure format else most of the functions will fail.
''' </summary>
''' <remarks>NB: Read about the structure format</remarks>
Public Class ServerHelperDynamicVersion
    Inherits ServerHelper2008

#Region "Constructor"

    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection ONLY (MSSQLSERVER)
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String)
        Me.New(DatabaseName, "MSSQLSERVER", My.Computer.Name, SQLServerConnectionModes.WindowsAuthentication)
    End Sub


    ''' <summary>
    ''' This is only for local connection (or On LAN)
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <param name="pInstanceName">The sql server instance we are going to connect to liek sqlexpress or sqlexress2014 etc</param>
    ''' <param name="pHostName">ComputerName or IP Address</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String, ByVal pInstanceName As String,
                   ByVal pHostName As String,
                   ByVal pConnectionMode As SQLServerConnectionModes,
            Optional ByVal DBLoginUserName As String = vbNullString,
            Optional ByVal DBLoginUserPassword As String = vbNullString,
            Optional ByVal DBTCPPort As Int32 = 0
                   )
        MyBase.New(DatabaseName, pInstanceName, pHostName)


        Me.ConnectionMode = pConnectionMode
        MyBase.__SQLServerUserName = DBLoginUserName
        MyBase.__SQLServerPassword = DBLoginUserPassword
        MyBase.__SQLServerPort = DBTCPPort



        Try

      
            '
            '   Fix Service going offline problem
            '
            If Me.IsLocalServer AndAlso Me.ServiceInstanceName <> String.Empty Then
                ' Check if service is stopped
                If OperatingSystem.getServiceStatus(Me.ServiceInstanceName) = ServiceProcess.ServiceControllerStatus.Stopped Then
                    If OperatingSystem.startService(Me.ServiceInstanceName) Then
                        Me.WakeUpServer__onCurrentDBInUse()
                    End If
                End If

            End If

        Catch ex As Exception
            ' Ignore incase the service is not present on the pc
            Logger.Print(ex)
        End Try

    End Sub


#End Region


#Region "Methods"

#Region "Public"





    ''' <summary>
    ''' get installed SQLSErver Instances on this PC
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getInstalledSQLServerInstances() As IEnumerable(Of String)
        Dim pInstances As Object = Registry.readRegistryObjectValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                            "SOFTWARE\Microsoft\Microsoft SQL Server",
                                             "InstalledInstances"
                                             )
        Return CType(pInstances, Global.System.Collections.Generic.IEnumerable(Of String))
    End Function




    ''' <summary>
    ''' Using SQL Default Path 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getSQLConnection(ByVal InitialCatalog As String) As SqlClient.SqlConnection

        Dim sCon As SqlClient.SqlConnection


        Try
            ''sCon = New SqlClient.SqlConnection(
            ''    "Data Source=" & svrServer & ";Initial Catalog=" & dbName &
            ''    ";Integrated Security=True;User ID=" & strUser & ";Password=" & strPassword)


            sCon = New SqlClient.SqlConnection(Me.getConnectionString(InitialCatalog))


            sCon.Open()

            'sCon.Close()

        Catch ex As Exception
            Logger.Log(New SQLServerConnectionException("Error Connecting to MS SQL Server AS Client", Me.getConnectionString(InitialCatalog), ex))
            Return Nothing
        End Try

        'sCon = Nothing
        Return sCon

    End Function



    Public Overrides Function getConnectionString() As String
        Return Me.getConnectionString(Me.CurrentDBInUse)
    End Function


    ''' <summary>
    ''' get connection string
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function getConnectionString(ByVal pDatabaseName As String) As String

        If Me.ConnectionMode = SQLServerConnectionModes.SQLServerAuthentication Then

            Return String.Format(
                      "Data Source={0},{1};Network Library=DBMSSOCN;" &
                      "Initial Catalog={2};User ID={3};Password={4};",
                      Me.SQLServerAddress, Me.SQLServerPort, Me.CurrentDBInUse,
                      Me.SQLServerUserName, Me.SQLServerPassword
                      )
        Else

            Return "Data Source=" & SQLServerAddress & ";Initial Catalog=" & pDatabaseName &
             ";Integrated Security=True;User ID=;Password="

        End If

    End Function






    Public Function getDatabaseReadyForNetworking() As Boolean
        REM ***************************************************************************************

        If Not Me.IsLocalServer Then Return False


        Dim aWait As New WaitAsync(, "Checking If Clients Can Connect to Your PC")
        Const sFireWallName As String = "Cybersoft SQL Server Remote Connection"
        Logger.Log("Checking If Clients Can Connect to Your PC")

        Try


            'TEST IF Clients Can Connect to this PC
            REM Fix Connection On Port
            If Not Me.CanClientConnectToThisServer(Me.SQLServerPort.ToString(), sFireWallName) Then
                REM Try to Configure Then Test Again
                aWait.setDescription("Configuring your pc so clients can connect...")
                Logger.Log("Configuring your pc so clients can connect...")
                Dim ShouldIRestartServer As Boolean


                Me.AllowNetworkUsersToConnect(Me.SQLServerUserName, Me.SQLServerPassword,
                                              SQLServerPort.ToString(),
                                              sFireWallName,
                                              ShouldIRestartServer
                                              )



                If ShouldIRestartServer Then restartSQLServer()


                If Not Me.CanClientConnectToThisServer(SQLServerPort.ToString(), sFireWallName) Then _
                    Me.restartSQLServer() : Me.WakeUpServer__onCurrentDBInUse()


                aWait.setDescription("Checking If Clients Can Connect to Your PC")
                Logger.Log("Checking If Clients Can Connect to Your PC")

                REM Go back to client to test
                If Not CanClientConnectToThisServer(CStr(SQLServerPort), sFireWallName) Then
                    Return False
                Else
                    GoTo CLientsCanConnectSuccessfully
                End If

            Else
CLientsCanConnectSuccessfully:
                Logger.Log("Clients can connect to this Server on Port: " & SQLServerPort)

                Return True

            End If
        Catch ex As Exception
            Throw ex
        Finally

            If aWait IsNot Nothing Then aWait.endWaiting() : aWait.Dispose()
            [aWait] = Nothing

        End Try
    End Function







    ''' <summary>
    ''' Backs Up Database of the currently connected Database
    ''' </summary>
    ''' <param name="sFilter">Must Start with DatabaseName_____({==5times)</param>
    ''' <param name="OverwriteFile">Indicates if we should overwrite with prompt the file if it exists</param>
    ''' <returns>Returns BackedUp File Full Path Name</returns>
    ''' <remarks></remarks>
    Public Overrides Function BackUpDB(ByVal sFilter As String,
                             ByRef poutFileUsed As String,
                              Optional ByVal OverwriteFile As Boolean = True) As String


        Dim pVersion = Me.SQLServerProductVersion

        Dim svDlg As New SaveFileDialog With {
            .OverwritePrompt = OverwriteFile,
        .Filter = sFilter,
        .AddExtension = True,
        .FilterIndex = 0,
        .FileName = String.Format("{0}___{1}.v{2}_{3}", Me.CurrentDBInUse, Microsoft.VisualBasic.Strings.Format(Now, "dd_MMM_yyyy"),
                                  pVersion.Major, pVersion.Minor
                                  )
        }

        If poutFileUsed IsNot Nothing AndAlso poutFileUsed <> "" AndAlso IO.Directory.Exists(EIO.getDirectoryFullPath(poutFileUsed)) Then _
           svDlg.InitialDirectory = EIO.getDirectoryFullPath(poutFileUsed)

        With svDlg
            If .ShowDialog() = DialogResult.OK Then
                poutFileUsed = .FileName
                Return Me.BackUpDB(False, .FileName, OverwriteFile)

            End If
        End With

        Return String.Empty

    End Function




#End Region

#Region "Private"

    ''' <summary>
    ''' Setup the requirements for other devices on same LAN to connect to this local SQL Server
    ''' </summary>
    ''' <param name="sUserName">User Name to Use for SQL Authentication</param>
    ''' <param name="sUserPassword">User Password to Use for SQL Authentication</param>
    ''' <param name="sPort">TCP/IP Port for connection</param>
    ''' <param name="sFirewallName">Suggested FireWall Name. Also could be kept to delete if uninstalling program</param>
    ''' <param name="sRequireSQLServerRestart">Indicates if the operation requires SQL Server Restart before you can see the changes</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Protected Overrides Function AllowNetworkUsersToConnect(
                                              Optional ByVal sUserName As String = "epro",
                                              Optional ByVal sUserPassword As String = "s123",
                                              Optional ByVal sPort As String = "1433",
                                              Optional ByRef sFirewallName As String = "SQL Server Remote Connection",
                                              Optional ByRef sRequireSQLServerRestart As Boolean = False
                                                                                   ) As Boolean

        REM SET Allow Exception=TRUE



        REM Find a way to display error message
        Dim sFirewallDescription As String = String.Format("Default Port for {0} Remote Connections", Me.InstanceIdentifier)
        Const DB As String = "master"



        '   Check if SQL Server is installed [pingDB function]
        If Not Me.PingDB Then Return False


        '   Check if provide Server Login exists
        '           If [NO] Try to create it
        '   SELECT * FROM sys.server_principals WHERE name='ibk'
        '   SELECT * FROM sys.sql_logins WHERE name='colorBloc'

        REM If yes continue with it believing user already knows the details
        Logger.Log("Creating Login on Database")
        If Not IsDataSetValid(
                                    Me.getRS(
                                            String.Format("SELECT * FROM sys.server_principals WHERE name='{0}'",
                                                          sUserName
                                                          ), DB
                                                      )
                                                  ) Then

            REM Create the Login
            Me.dbExec(
                String.Format(
                "CREATE LOGIN [{0}] WITH PASSWORD = N'{1}' , " & _
                "DEFAULT_DATABASE = [{2}], " & _
                "DEFAULT_LANGUAGE = [English], " & _
                    "CHECK_EXPIRATION = OFF",
                    sUserName, sUserPassword, DB
                                    )
                                )

            REM Assign Role
            Me.dbExec(
                String.Format(
            "EXEC sp_addsrvrolemember N'{0}', N'sysadmin'",
            sUserName
                    ), DB
                )

            Logger.Log("Login CREATED on Database")
            REM Run DCL 
            ''Me.dbExec(
            ''    String.Format(
            ''"GRANT CONNECT SQL TO [{0}]",
            ''sUserName
            ''        )
            ''    )



        End If




        Logger.Log(String.Format("Configuring {0} Registry", Me.InstanceIdentifier))
        '
        ''   Configure registry

        REM If any change occur in this environment, you have to indicate restart
        '' ''   
        '' ''   SQL Server RegLoc
        ' '' ''           HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                       String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer", Me.InstanceIdentifier)
                                                        ) Is Nothing Then

            REM No SQL Server 2014 Express Edition on this machine
            Logger.Log("The registry settings was NOT Found on the PC. AM NOT SURE {0} is installed")
            Return False
        End If



        ' '' ''         Then Restart
        ' '' ''        LoginMode
        ' '' ''1:      WindowsAuthenticationOnly
        ' '' ''2:      Mixed
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer", Me.InstanceIdentifier),
                                           "LoginMode", "2", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Logger.Log("The registry settings FAILED, LoginMode NOT SET to Mix Authentication") : Return False REM return false if I could not set authentication mode






        ' '' ''        TCP(Mode)
        REM         DELETE The TCP/IP Folder and Recreate it
        REM     Incase of all the previous rules that has been auto-generated and also to reduce time to loop through each subkeys
        REM Instead I will delete all other subFolders in the folder that i dont want EXCEPT IPAll
        ' ''Registry.DeleteASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
        ' ''                                    "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib",
        ' ''                                        "Tcp"
        ' ''                                    )

        Registry.CreateASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                             String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib", Me.InstanceIdentifier),
                                                "Tcp"
                                            )


        REM Now Add All It's Default Parameters
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp


        REM DisplayName:TCP/IP
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                            String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier),
                                           "DisplayName", "TCP/IP"
                                           ) Then Return False REM return false if I could not create Parameter


        REM KeepAlive = 30000
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier),
                                           "KeepAlive", "30000", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not create Parameter


        ' '' ''        Enabled = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier),
                                           "Enabled", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not enable tcp


        ' '' ''        ListenOnAllIPs = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier),
                                           "ListenOnAllIPs", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could make tcp listen on all ips




        REM Now Create A Single SubKey
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier)
                                                ) Is Nothing Then
            ''DisplayName=Any IP Address
            ''    TcpDynamicPorts = 1433
            ''    TcpPort = ""
            If Registry.CreateASubKey(
                Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                String.Format(
                                                    "SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier
                                                    ), "IPAll"
                                                   ) IsNot Nothing Then

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                          "DisplayName", "Any IP Address"
                                          ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                          String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                         "TcpDynamicPorts", "1433"
                                         ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                          String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                         "TcpPort", ""
                                         ) Then Return False REM Failed

            End If





            End If

                REM DELETE ALL OTHER SUB FOLDERS UNDER TCP Except IPAll
        Registry.deleteAllSubKeysInThisPathExcept(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                               String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp", Me.InstanceIdentifier),
                                                {"IPAll"}
                                                )


                ' '' ''        TcpDynamicPorts = 1433
                ' '' ''            or which ever port you want
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                         "TcpDynamicPorts"
                                          )

                If tmpPorts = vbNullString Then
                    REM If no port was set initially then set it
                    tmpPorts = sPort
                Else
                    REM If it is not in the ports alread then add it with comma
                    If tmpPorts.IndexOf(sPort) < 0 Then
                        tmpPorts &= "," & sPort
                        REM This is because of Port
                        REM If new port is configured, Database Engine needs to restart to listen on that port
                        sRequireSQLServerRestart = True
                        REM Else it has already being configured

                    End If
                End If


                REM Update Dynamic Port With Ports Requested
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                          String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                         "TcpDynamicPorts", tmpPorts
                                         ) Then Return False REM Failed


        REM Configure Firewall
        REM Incase the name already exist ... retry MAX 10 times with modified Name and return to user to remove during uninstallation
        REM 

        ''Dim successfullyConfiguredFirewall = False
        ''Dim tempFireWallName As String = sFirewallName

        ''For i As Byte = 1 To 10
        ''    REM Currently, if same name exists, it will overwrite it
        ''    If clsFirewall.createInboundPortExceptions(sFirewallName, sFirewallDescription, sPort) Then
        ''        successfullyConfiguredFirewall = True
        ''        Exit For
        ''    Else
        ''        sFirewallName = tempFireWallName & i
        ''    End If
        ''Next

        ''If Not successfullyConfiguredFirewall Then Return False REM Failed
        Logger.Log("The registry settings was FULLY CONFIGURED")
        Logger.Log("Creating Firewall inbound for port: " & sPort)
        If Not Firewall.createInboundPortExceptions(sFirewallName, sFirewallDescription, sPort) Then Logger.Log("Firewall inbound FAILED") : Return False REM Firewall config fail
        Logger.Log("Firewall inbound CREATED")

        REM Successfully configured FireWall
        Return True
    End Function

    ''' <summary>
    ''' Checking if ports needed by SQL Server is enabled in Firewall and if TCP/IP is enabled to make sure client can connect to server. 
    ''' Also check if Login is created
    ''' </summary>
    ''' <param name="sPort"></param>
    ''' <param name="sFirewallName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CanClientConnectToThisServer(Optional ByVal sPort As String = "1433",
                                              Optional ByRef sFirewallName As String = "SQL Server Remote Connection") As Boolean
        REM Check if the firewallname exists on FirewallSettings
        REM Check if the port is enabled on SQL Server
        REM Check if ALLOW Exception is TRUE

        Logger.Log("Checking and Creating firewall for port: " & sPort)
        If Not Firewall.isInboundPortExceptionValid(sFirewallName, sPort) Then Logger.Log("failed firewall") : Return False
        Logger.Log(
            String.Format("passed firewall. Creating {0} registry settings", Me.SQLServerSoftwareVersion.ToString())
            )

        REM Check if the folder[subKey] is even available
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                               String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier)
                                                ) Is Nothing Then Logger.Log(
                                                String.Format("{0} registry settings Failed on 1", Me.InstanceIdentifier)
                                                            ) : Return False


        REM Check if TCP is Enabled too


        REM Check if port is available on sql
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Tcp\IPAll", Me.InstanceIdentifier),
                                         "TcpDynamicPorts"
                                          )
        If tmpPorts = vbNullString Then Logger.Log(
                                                String.Format("{0} registry settings Failed on 2", Me.InstanceIdentifier)
                                                            ) : Return False
        If tmpPorts.IndexOf(sPort) < 0 Then Logger.Log(
                                                String.Format("{0} registry settings Failed on 3", Me.InstanceIdentifier)
                                                            ) : Return False


        Logger.Log(
                                                String.Format("{0} registry settings passed checking state COMPLETED SUCCESSFULLY", Me.InstanceIdentifier)
                                                            )

        REM If this works then all is fine
        Return New Client(Me.SQLServerAddress, Me.SQLServerPort, Me.SQLServerUserName,
                           Me.SQLServerPassword, Me.DatabaseName, False).CanConnect()


    End Function


#End Region



#End Region


#Region "Enums and Consts"

    Public Enum SQLServerSoftwareVersions
        SQL_Server_2000
        SQL_Server_2005
        SQL_Server_2008
        SQL_Server_2008_R2
        SQL_Server_2012
        SQL_Server_2014
        SQL_Server_2016
        UNKNOWN
    End Enum


    Public Enum SQLServerConnectionModes
        WindowsAuthentication
        SQLServerAuthentication
    End Enum


#End Region




#Region "Properties"


    ''' <summary>
    ''' It is like this MSSQL12.SQLEXPRESS2014
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property InstanceIdentifier As String
        Get

            Return Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                             "SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL",
                                             Me.SQLInstanceName
                                             )

        End Get
    End Property


    ''' <summary>
    ''' It is usually like MSSQL$SQLExpress 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides ReadOnly Property ServiceInstanceName As String
        Get
            Try

                Dim pName = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                 String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\SuperSocketNetLib\Np", Me.SQLInstanceName),
                                                 "PipeName"
                                                 )
                If pName Is Nothing OrElse pName = String.Empty Then Return pName
                Return EStrings.ExtractStringFromHtml(pName, "pipe\", "\sql\query")


            Catch ex As Exception
                Logger.Print(ex)
                Return String.Empty
            End Try

        End Get
    End Property



    ''' <summary>
    ''' It is the version of this instance in String like 10.0.5.0
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SQLServerProductVersion As VersionControlSystem
        Get
            Try

                Return New VersionControlSystem(
                    Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                 String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\MSSQLServer\CurrentVersion", Me.SQLInstanceName),
                                                 "CurrentVersion"
                                                 )
                                             )

            Catch ex As Exception
                Logger.Print(ex)
                Return New VersionControlSystem(String.Empty)
            End Try

        End Get
    End Property


    ''' <summary>
    ''' This is the /DATA folder where database hardcopies are stored
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides ReadOnly Property SQLServerDatabaseFolder As String
        Get
            Dim SQLPath As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                             String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\Setup", Me.SQLInstanceName),
                                             "SQLPath"
                                             )
            Return SQLPath & "\DATA"
        End Get
    End Property


    ''' <summary>
    ''' It is the software version of this instance 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SQLServerSoftwareVersion As SQLServerSoftwareVersions
        Get
            Dim pVersion = Me.SQLServerProductVersion
            If pVersion.Major = 10 AndAlso pVersion.Minor = 0 Then Return SQLServerSoftwareVersions.SQL_Server_2008
            If pVersion.Major = 10 AndAlso pVersion.Minor > 0 Then Return SQLServerSoftwareVersions.SQL_Server_2008_R2
            If pVersion.Major = 11 Then Return SQLServerSoftwareVersions.SQL_Server_2012
            If pVersion.Major = 12 Then Return SQLServerSoftwareVersions.SQL_Server_2014
            If pVersion.Major = 13 Then Return SQLServerSoftwareVersions.SQL_Server_2016
            If pVersion.Major = 8 Then Return SQLServerSoftwareVersions.SQL_Server_2000
            If pVersion.Major = 9 Then Return SQLServerSoftwareVersions.SQL_Server_2005

            Return SQLServerSoftwareVersions.UNKNOWN

        End Get
    End Property



    Public ReadOnly Property DatabaseSoftwareDetails As String
        Get
            If Not Me.IsLocalServer Then Return "Details can only be fetched for Local Servers!"

            Dim pOSArchitecture = "x32 bit"
            If OperatingSystem.isThis64BitOS() Then pOSArchitecture = "x64 bit"
            Dim pVersion = Me.SQLServerProductVersion
            Dim pDate = Now.ToString("MMM dd yyyy hh:mm tt")
            Dim pEditon = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                             String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\Setup", Me.InstanceIdentifier),
                                             "Edition"
                                             )
            Dim pOS = Environment.OSVersion.ToString()
            Dim pCollation = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                             String.Format("SOFTWARE\Microsoft\Microsoft SQL Server\{0}\Setup", Me.InstanceIdentifier),
                                             "Collation"
                                             )
            Dim pDataRoot = Me.SQLServerDatabaseFolder



            Return String.Format(
                "Microsoft {0} - {1}    {2}                    " & Environment.NewLine & _
                "Copyright (c) 1988-2008 Microsoft Corporation                    " & Environment.NewLine & _
                "                  " & Environment.NewLine & _
                "{3} on {4} {{{5}}}                  " & Environment.NewLine & _
                "                  " & Environment.NewLine & _
                "COLLATION: {6}                  " & Environment.NewLine & _
                "DATA ROOT: {7}                  ",
                Me.SQLServerSoftwareVersion.ToString().Replace("_", " "),
                pVersion,
                pDate, pEditon, pOS, pOSArchitecture, pCollation, pDataRoot
            )

        End Get
    End Property




    Public Property ConnectionMode As SQLServerConnectionModes


#End Region



End Class
