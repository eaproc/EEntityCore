
Imports System.Windows.Forms


Imports EPRO.WaitAsyncMgr

Imports EPRO.Library.v3._5
Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v4.Shell
Imports EPRO.Library.v3._5.Objects


Imports CODERiT.Logger.v._3._5.Exceptions

Imports DB.v4.MS_SQL.Tools.Exceptions
Imports DB.v4.MS_SQL.Exceptions
Imports System.IO
Imports System.Security


''' <summary>
''' Contains Optional Functions. ONLY If you want to use my database structure format else most of the functions will fail.
''' </summary>
''' <remarks>NB: Read about the structure format</remarks>
Public Class ServerHelper2014
    Inherits ServerHelper2008

#Region "Constructor"

    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection ONLY
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String)
        Me.New(DatabaseName, "sqlexpress2014")
    End Sub


    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <param name="pInstanceName">The sql server instance we are going to connect to liek sqlexpress or sqlexress2014 etc</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String, ByVal pInstanceName As String)
        MyBase.New(DatabaseName, pInstanceName)
    End Sub

#Region "Proxy Constructors"

  
#End Region

#End Region


#Region "Methods"

#Region "Public"



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
        Const sFirewallDescription As String = "Default Port for SQL Server 2014 Remote Connections"
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




        Logger.Log("Configuring SQL Server 2014 Registry")
        '
        ''   Configure registry

        REM If any change occur in this environment, you have to indicate restart
        '' ''   
        '' ''   SQL Server RegLoc
        ' '' ''           HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                        "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer") Is Nothing Then

            REM No SQL Server 2014 Express Edition on this machine
            Logger.Log("SQL Server 2014 registry settings was NOT Found on the PC. AM NOT SURE [MSSQL10.SQLEXPRESS] is installed")
            Return False
        End If



        ' '' ''         Then Restart
        ' '' ''        LoginMode
        ' '' ''1:      WindowsAuthenticationOnly
        ' '' ''2:      Mixed
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer",
                                           "LoginMode", "2", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Logger.Log("SQL Server 2014 registry settings FAILED, LoginMode NOT SET to Mix Authentication") : Return False REM return false if I could not set authentication mode






        ' '' ''        TCP(Mode)
        REM         DELETE The TCP/IP Folder and Recreate it
        REM     Incase of all the previous rules that has been auto-generated and also to reduce time to loop through each subkeys
        REM Instead I will delete all other subFolders in the folder that i dont want EXCEPT IPAll
        ' ''Registry.DeleteASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
        ' ''                                    "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib",
        ' ''                                        "Tcp"
        ' ''                                    )

        Registry.CreateASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                            "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib",
                                                "Tcp"
                                            )


        REM Now Add All It's Default Parameters
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp


        REM DisplayName:TCP/IP
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "DisplayName", "TCP/IP"
                                           ) Then Return False REM return false if I could not create Parameter


        REM KeepAlive = 30000
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "KeepAlive", "30000", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not create Parameter


        ' '' ''        Enabled = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "Enabled", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not enable tcp


        ' '' ''        ListenOnAllIPs = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "ListenOnAllIPs", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could make tcp listen on all ips




        REM Now Create A Single SubKey
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll") Is Nothing Then
            ''DisplayName=Any IP Address
            ''    TcpDynamicPorts = 1433
            ''    TcpPort = ""
            If Registry.CreateASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp", "IPAll") IsNot Nothing Then

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                          "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                          "DisplayName", "Any IP Address"
                                          ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpDynamicPorts", "1433"
                                         ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpPort", ""
                                         ) Then Return False REM Failed

            End If





        End If

        REM DELETE ALL OTHER SUB FOLDERS UNDER TCP Except IPAll
        Registry.deleteAllSubKeysInThisPathExcept(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp",
                                                {"IPAll"}
                                                )


        ' '' ''        TcpDynamicPorts = 1433
        ' '' ''            or which ever port you want
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
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
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
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
        Logger.Log("SQL Server 2014 registry settings was FULLY CONFIGURED")
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

        Logger.Log("Checking firewall for port: " & sPort)
        If Not Firewall.isInboundPortExceptionValid(sFirewallName, sPort) Then Logger.Log("failed firewall") : Return False
        Logger.Log("passed firewall. Creating SQL Server 2008 registry settings")

        REM Check if the folder[subKey] is even available
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll") Is Nothing Then Logger.Log("SQL Server 2014 registry settings Failed on 1") : Return False


        REM Check if TCP is Enabled too


        REM Check if port is available on sql
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpDynamicPorts"
                                          )
        If tmpPorts = vbNullString Then Logger.Log("SQL Server 2014 registry settings Failed on 2") : Return False
        If tmpPorts.IndexOf(sPort) < 0 Then Logger.Log("SQL Server 2014 registry settings Failed on 3") : Return False



        Logger.Log("SQL Server 2014 registry settings passed checking state COMPLETED SUCCESSFULLY")

        REM If this works then all is fine
        Return New Client(Me.SQLServerAddress, Me.SQLServerPort, Me.SQLServerUserName,
                           Me.SQLServerPassword, Me.DatabaseName, False).CanConnect()


    End Function


#End Region



#End Region


#Region "Properties"

    ''' <summary>
    ''' It is usually MSSQL$ with the instance name
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides ReadOnly Property ServiceInstanceName As String
        Get
            Return "MSSQL$SQLEXPRESS2014"
        End Get
    End Property

    Public Overrides ReadOnly Property SQLServerDatabaseFolder As String
        Get
            Return "C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS2014\MSSQL\DATA"
        End Get
    End Property

#End Region



End Class
