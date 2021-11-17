
Imports System.Windows.Forms


Imports EPRO.WaitAsyncMgr

Imports EPRO.Library.v3._5
Imports EPRO.Library.v3._5.Modules
Imports EPRO.Library.v4.Shell
Imports EPRO.Library.v3._5.Objects


Imports CODERiT.Logger.v._3._5.Exceptions
Imports CODERiT.PopUps.v3._5.FixedWindow

Imports DB.v4.MS_SQL.Tools.Exceptions
Imports DB.v4.MS_SQL.Exceptions

Imports System.IO
Imports System.Security


''' <summary>
''' Contains Optional Functions. ONLY If you want to use my database structure format else most of the functions will fail.
''' </summary>
''' <remarks>NB: Read about the structure format</remarks>
Public Class ServerHelper2008
    Inherits Server

#Region "Constructor"

    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection ONLY
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String)
        Me.New(DatabaseName, "sqlexpress")
    End Sub


    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <param name="pInstanceName">The sql server instance we are going to connect to liek sqlexpress or sqlexress2014 etc</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String, ByVal pInstanceName As String)

        Me.New(DatabaseName, pInstanceName, My.Computer.Name)

    End Sub




    ''' <summary>
    ''' Use proxy Constructors [.Load()] for full functionalities. This is only for local connection
    ''' </summary>
    ''' <param name="DatabaseName">The database we are trying to create or connect to</param>
    ''' <param name="pInstanceName">The sql server instance we are going to connect to liek sqlexpress or sqlexress2014 etc</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DatabaseName As String, ByVal pInstanceName As String,
                   ByVal pHostName As String
                   )

        MyBase.New(DatabaseName, String.Format("{0}\{1}", pHostName, pInstanceName))


        Me._______SQLInstanceName = pInstanceName
        Me._______SQLHostName = pHostName


        Try


            FileSystemSecurity.AddAccountToFolder(Application.StartupPath,
                                               MicrosoftOS.PCAccountNames.AccountNames.NETWORK__SERVICE
                                               )
        Catch ex As Exception
            Program.Logger.Print("Application could not add full security access to app startup folder for [NETWORK SERVICE] user name. You can do it manually.")
        End Try
    End Sub



#Region "Proxy Constructors"

    ''' <summary>
    ''' Set Database to use. It will be created if it doesnt exist with version 0.0
    ''' </summary>
    ''' <param name="AllowSnapshot">You need this if you are using DBCaching. Set this to true</param>
    ''' <remarks>Throws Client cant connect to Server Pc error if you implement</remarks>
    Public Function Load(
            Optional ByVal CurrentVersion As Double = 0.0,
            Optional ByVal UseTracker As Boolean = True,
            Optional ByVal DBLoginUserName As String = vbNullString,
            Optional ByVal DBLoginUserPassword As String = vbNullString,
            Optional ByVal DBTCPPort As Int32 = 0,
            Optional ByVal AllowSnapshot As Boolean = False) As ServerHelper2008

        Me.DB_Target_Version = CurrentVersion
        Me.__SQLServerPort = DBTCPPort
        Me.__SQLServerUserName = DBLoginUserName
        Me.__SQLServerPassword = DBLoginUserPassword


        REM If database is first ok locally
        If Me.CheckIfDatabase__Is__Ready_For_Usage() Then

            REM If we have a valid clientConnectionPort
            REM It means we will use it for client connection 
            REM and it is then important to check if clients can connect to it

            If DBTCPPort > 0 AndAlso
                DBLoginUserName <> vbNullString AndAlso
                DBLoginUserPassword <> vbNullString Then

                If Not Me.Is_DB_Ready_For__ClientConnection_On_Network(DBLoginUserName,
                                                                   DBLoginUserPassword,
                                                                   DBTCPPort
                                                                   ) Then

                    Throw New OnNetworkClientConnectionException(DBTCPPort)

                End If

            End If





            If AllowSnapshot Then



                REM --------------Fix transport layer bug
                Dim TryAgainCount As Byte = 0
START_ALL_OVER:
                Try


                    REM Needed
                    If Not Me.setAllowSnapshotOnDatabase(True, DatabaseName) Then Throw New Exception("A transport-level error has occurred when sending the request to the server")
                    REM ACon.dbExec(String.Format("ALTER DATABASE {0} SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE", ACon.DatabaseName))

                Catch ex As Exception
                    Logger.Print("Error Executing force snapshot", ex)

                    If ex.Message.StartsWith("A transport-level error has occurred when sending the request to the server") AndAlso
                        TryAgainCount < 2 Then
                        Logger.Print("Perhaps due to your RAM or CPU usage, SQL Server is not responding well. We are trying again to load this view.")
                        TryAgainCount += CByte(1)
                        GoTo START_ALL_OVER
                    End If

                End Try

                REM -------------------------Move this part into dll







            End If





            REM It means all is ok
            Me.KeepTrackingConnection = UseTracker

        Else
            Throw New SQLServerConnectionException("Error Connecting to MS SQL Server. Check Log file for more details.")
        End If


        Return Me
    End Function

#End Region

#End Region


#Region "Methods"

#Region "Public"





    ''' <summary>
    ''' Upgrade the database file to the suggested version. uses folder "{AppPath}\DBUpgrades\SQL_Upgrade_{No}.sql"
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function UpgradeDatabase(ByVal pIsScriptEncrypted As Boolean
                                           ) As Boolean
        Return Me.UpgradeDatabase(Me.DB_Target_Version, Me.FetchDBVersion(), pIsScriptEncrypted)
    End Function





#Region "Restarting SQL Server"


    ''' <summary>
    ''' Restarts Server
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub restartSQLServer()

        'Dim aWait As New WaitAsync(, "Stopping SQL Server")
        'OperatingSystem.stopService("MSSQL$SQLEXPRESS")
        'aWait.endWaiting()

        ''aWait.startWaiting(, "Starting SQL Server")
        ''clsOperatingSystem.startService("MSSQL$SQLEXPRESS")

        ''REM Incase you want to start using the db immediately it might not respond
        ''Threading.Thread.Sleep(2000)
        ''Me.PingDB()
        ''Threading.Thread.Sleep(1000)
        ''Me.PingDB()
        ''Threading.Thread.Sleep(2000)

        ''aWait.endWaiting()
        stopSQLServer()
        startSQLServer()


        'aWait.Dispose()
        'aWait = Nothing  REM LET GC DO IT'S JOB




    End Sub



    ''' <summary>
    ''' Stop SQL Server
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub stopSQLServer()

        Dim aWait As New WaitAsync(, "Stopping SQL Server")
        OperatingSystem.stopService(Me.ServiceInstanceName)
        aWait.endWaiting()

        aWait.Dispose()
        aWait = Nothing  REM LET GC DO IT'S JOB


    End Sub


    '' ''' <summary>
    '' ''' Start SQL Server
    '' ''' </summary>
    '' ''' <remarks></remarks>
    ''Public Overridable Sub startSQLServer()

    ''    Try
    ''        Dim aWait As New WaitAsync(, "Starting SQL Server")
    ''        OperatingSystem.startService("MSSQL$SQLEXPRESS")

    ''        REM Incase you want to start using the db immediately it might not respond
    ''        '' ''Threading.Thread.Sleep(2000)
    ''        '' ''Me.PingDB()
    ''        '' ''Threading.Thread.Sleep(2000)
    ''        '' ''Me.PingDB()
    ''        '' ''Threading.Thread.Sleep(2000)
    ''        '' ''Me.PingDB()
    ''        '' ''Threading.Thread.Sleep(2000)


    ''        aWait.endWaiting()

    ''        aWait.Dispose()
    ''        aWait = Nothing  REM LET GC DO IT'S JOB
    ''    Catch ex As Exception
    ''        MsgBox("The Error is restrained here for now-- StartSQLServer Mybase")
    ''    End Try


    ''End Sub





    ''' <summary>
    ''' Starts SQL Server and try to connect to default db incase you want to use immediately
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub startSQLServer()
        Try

            Dim aWait As New WaitAsync(, "Starting SQL Server")
            OperatingSystem.startService(Me.ServiceInstanceName)

            '' '' ''Me.FetchDBVersion()

            '' '' ''Threading.Thread.Sleep(7000
            '' '' ''                        )

            ''aWait.setDescription("Fetching DB Version")
            ''Me.FetchDBVersion()

            Me.WakeUpServer__onCurrentDBInUse()

            ''aWait.setDescription("...")
            aWait.endWaiting()
            aWait.Dispose()
            aWait = Nothing
        Catch ex As Exception
            Logger.Log(New EException("The Error is restrained here for now -StartSQLServer Helper", ex))
        End Try


    End Sub



#End Region




#Region "BackUp and Restore"


    ''' <summary>
    ''' Returns the default generated filter for this database
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function getDefaultFilter() As String
        Return Me.getDefaultFilter("Generic Databases")
    End Function

    ''' <summary>
    ''' Returns the default generated filter for this database with Tagged name like Cafe Book Databases
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function getDefaultFilter(ByVal TaggedName As String) As String
        Return String.Format("{1} (*.{0}_____)|*.{0}_____", Me.CurrentDBInUse, TaggedName)
    End Function




#Region "Back Up"

    ''' <summary>
    ''' Backs Up Database of the currently connected Database
    ''' </summary>
    ''' <param name="OverwriteFile">Indicates if we should overwrite with prompt the file if it exists</param>
    ''' <returns>Returns BackedUp File Full Path Name</returns>
    ''' <remarks></remarks>
    Public Function BackUpDB(ByVal OverwriteFile As Boolean) As String
        Return Me.BackUpDB(Me.getDefaultFilter(), Nothing, OverwriteFile)
    End Function

    ''' <summary>
    ''' Backs Up Database of the currently connected Database
    ''' </summary>
    ''' <param name="OverwriteFile">Indicates if we should overwrite with prompt the file if it exists</param>
    ''' <returns>Returns BackedUp File Full Path Name</returns>
    ''' <remarks></remarks>
    Public Function BackUpDB(ByRef poutFileUsed As String,
                              ByVal OverwriteFile As Boolean) As String
        Return Me.BackUpDB(Me.getDefaultFilter(), poutFileUsed, OverwriteFile)
    End Function


    ''' <summary>
    ''' Backs Up Database of the currently connected Database
    ''' </summary>
    ''' <param name="sFilter">Must Start with DatabaseName_____({==5times)</param>
    ''' <param name="OverwriteFile">Indicates if we should overwrite with prompt the file if it exists</param>
    ''' <returns>Returns BackedUp File Full Path Name</returns>
    ''' <remarks></remarks>
    Public Overridable Function BackUpDB(ByVal sFilter As String,
                             ByRef poutFileUsed As String,
                              Optional ByVal OverwriteFile As Boolean = True) As String


        Dim svDlg As New SaveFileDialog With {
            .OverwritePrompt = OverwriteFile,
        .Filter = sFilter,
        .AddExtension = True,
        .FilterIndex = 0,
        .FileName = String.Format("{0}___{1}", Me.CurrentDBInUse, Microsoft.VisualBasic.Strings.Format(Now, "dd_MMM_yyyy"))
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


   

    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections.
    ''' Throws Exception
    ''' </summary>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function BackupDB(ByVal Silent As Boolean,
                             ByVal BackupFileFullPath As String,
                              Optional ByVal OverwriteFile As Boolean = True) As String



        If Not OverwriteFile Then
            BackupFileFullPath = EIO.suggestFileUniqueFullFilePathName(FileIO.FileSystem.GetParentPath(BackupFileFullPath),
                                                                       Path.GetFileName(BackupFileFullPath), " - "
                                                                       )
        End If


        Dim aWait As WaitAsync = Nothing
        If Not Silent Then [aWait] = New WaitAsync(, "Backing Up Database ...")




        Try
        
            REM Set folder security
            If Not Directory.Exists(FileIO.FileSystem.GetParentPath(BackupFileFullPath)) Then Throw New FolderAccessException()
            FileSystemSecurity.AddAccountToFolder(FileIO.FileSystem.GetParentPath(BackupFileFullPath),
                                             MicrosoftOS.PCAccountNames.AccountNames.NETWORK__SERVICE
                                             )

        

            If Me.dbExec(
                String.Format(
                        "BACKUP DATABASE {0} " & _
                        "TO DISK = '{1}' ", Me.CurrentDBInUse, BackupFileFullPath
                    )
                ) Then


                FileSystemSecurity.AddAccountToFile(BackupFileFullPath,
                                            MicrosoftOS.PCAccountNames.AccountNames.NETWORK__SERVICE
                                            )

                If Not Silent Then
                    [aWait].setDescription("Your Database has been backed up successfully!")
                    [aWait].WaitDisplay(2000)
                End If

            Else
                If Not Silent Then
                    aWait.setDescription("Error Occurred Backing Up Database")
                    aWait.WaitDisplay(2000)
                End If
                Throw New BackUpException()
            End If


            REM Terminate Local Wait
            If [aWait] IsNot Nothing Then [aWait].Dispose()
            aWait = Nothing

        Catch ex As Exception
            If [aWait] IsNot Nothing Then [aWait].Dispose()
            [aWait] = Nothing
            Throw ex
        End Try

        Return BackupFileFullPath


    End Function



#End Region


#Region "Restore"

    Public Function RestoreDBFromFile(ByVal FileToRestoreFullPath As String,
                                      Optional DeleteRollBackFile As Boolean = False) As Boolean
        Dim successful As Boolean = False REM , hasRestarted As Boolean = False REM A single option to force restart server once


        Dim aWait As New WaitAsync(, "Restoring Database ...")
        Dim isThreadingAllowed As Boolean = Me.KeepTrackingConnection

        If isThreadingAllowed Then Me.KeepTrackingConnection = False REM Close Tentatively

        '--------------------------------------Keep Rollback ------------------
        Dim RollbackDB As String = String.Format("{0}\RollBackDB for {1}.{1}_____rollback", Application.StartupPath, Me.CurrentDBInUse)



        Try
            If File.Exists(RollbackDB) Then File.Delete(RollbackDB)
        Catch ex As Exception
            REM Ignore error deleting rollback file
            Logger.Write(ex)
        End Try



        [aWait].setDescription("Setting restore point ...")
        Try
            Me.BackUpDB(True, RollbackDB)
            If Not DeleteRollBackFile Then
                aWait.setDescription("Rollback point created. Incase you need it, you can find it in the Application Folder!")
                aWait.WaitDisplay(2000)
            End If
        Catch ex As Exception
            aWait.setDescription("Error Creating Rollback point")
            aWait.WaitDisplay(2000)
            successful = False
            GoTo CONCLUDE
        End Try

        ''If Me.dbExec(
        ''   String.Format(
        ''           "BACKUP DATABASE {0} " & _
        ''           "TO DISK = '{1}' ", Me.CurrentDBInUse, RollbackDB
        ''       ), DEFAULT_DB
        ''   ) Then



        ''    REM Since SQL Server 2008 is running as Network Service we need to add the permission so 
        ''    REM we can restore it from any location
        ''    Dim fi As New FileInfo(RollbackDB)
        ''    Dim fNetwork As New AccessControl.FileSystemAccessRule("NETWORK SERVICE", AccessControl.FileSystemRights.FullControl, AccessControl.AccessControlType.Allow)

        ''    Dim fSecurity As AccessControl.FileSecurity = fi.GetAccessControl()
        ''    'fSecurity.RemoveAccessRule(fNetwork)
        ''    'fi.SetAccessControl(fSecurity)
        ''    fSecurity.AddAccessRule(fNetwork)
        ''    fi.SetAccessControl(fSecurity)


        ''Else
        ''    aWait.setDescription("Error Creating Rollback point")
        ''    aWait.WaitDisplay(2000)
        ''    successful = False
        ''    GoTo CONCLUDE

        ''End If



        '------------------------------------------------------------------------
        Try
            REM Try to force NetWork Service account on the file if it is not available
            REM Since SQL Server 2008 is running as Network Service we need to add the permission so 
            REM we can restore it from any location
            FileSystemSecurity.AddAccountToFile(FileToRestoreFullPath,
                                            MicrosoftOS.PCAccountNames.AccountNames.NETWORK__SERVICE
                                            )


        Catch ex As Exception
            aWait.setDescription("Error Trying to Force Security on Back Up File!!!")
            aWait.WaitDisplay(2000)
            successful = False
            GoTo CONCLUDE
        End Try


        aWait.setDescription("Restoring Database ...")

BEGIN_RESTORE:
        Dim ExtensionDBName As String = Path.GetExtension(FileToRestoreFullPath)
        Try
            ExtensionDBName = Right(ExtensionDBName, ExtensionDBName.Length - 1) REM remove .
            ExtensionDBName = ExtensionDBName.Split(New String() {"_____"}, StringSplitOptions.RemoveEmptyEntries)(0)
        Catch ex As Exception
            aWait.setDescription("INVALID DATABASE FILE NAME!!!")
            aWait.WaitDisplay(2000)
            successful = False
            GoTo CONCLUDE
        End Try


        REM Turn off database
        Me.dbExec(String.Format("alter database {0} set offline with rollback immediate", Me.CurrentDBInUse), MS_SQL.Server.DEFAULT_DB)
        Me.dbExec(String.Format("drop database {0}", Me.CurrentDBInUse), MS_SQL.Server.DEFAULT_DB)
        Try
            REM Try delete files if they exist
            EIO.DeleteFileIfExists(String.Format("{0}\{1}.mdf", SQLServerDatabaseFolder, Me.CurrentDBInUse))
            EIO.DeleteFileIfExists(String.Format("{0}\{1}_Log.ldf", SQLServerDatabaseFolder, Me.CurrentDBInUse))
        Catch ex As Exception
            Logger.Print("Error Deleting Original Database Files ... ", ex)
        End Try


        If Me.dbExec(
            String.Format(
                    "RESTORE DATABASE {0} " & _
                    "FROM DISK = '{1}' " & _
                    "WITH RECOVERY, " & _
                    "MOVE '{2}' TO '{3}\{0}.mdf', " & _
                    "MOVE '{2}_log' TO '{3}\{0}_Log.ldf'",
                    Me.CurrentDBInUse, FileToRestoreFullPath,
                    ExtensionDBName, SQLServerDatabaseFolder
                ), DEFAULT_DB
            ) Then

            REM Turn it on back database
            Me.dbExec(String.Format("alter database {0} set online", Me.CurrentDBInUse), DEFAULT_DB)

            aWait.setDescription("Your Database has been restored successfully!")
            aWait.WaitDisplay(2000)

            REM Upgrade if neccessary
            Me.UpgradeDatabase(Me.DB_Target_Version, Me.FetchDBVersion())

            successful = True
        Else

            REM Turn it on back database
            Me.dbExec(String.Format("alter database {0} set online", Me.CurrentDBInUse))

            ''If Not hasRestarted Then
            ''    'Me.FetchDBVersion()
            ''    Me.restartSQLServer()           REM Disconnect all users
            ''    If (Me.WakeUpServer()) Then     REM if it wakes up drop it and try again
            ''        Me.dbExec("DROP DATABASE " & Me.CurrentDBInUse, DEFAULT_DB)
            ''        hasRestarted = True : GoTo BEGIN_RESTORE
            ''    End If
            ''End If

            aWait.setDescription("Error Occurred while restoring Database. Please, check the security on the back up file.")
            aWait.WaitDisplay(2000)
        End If


        If Not successful Then

            '--------------Try rollback action ------------------------
            aWait.setDescription("Rolling back transactions ...")
            If Me.dbExec(
                  String.Format(
                          "RESTORE DATABASE {0} " & _
                          "FROM DISK = '{1}' ", Me.CurrentDBInUse, RollbackDB
                      ), DEFAULT_DB
                  ) Then

                aWait.setDescription("Your Database has been rolled back to previous state successfully!")
                aWait.WaitDisplay(2000)

            Else
                aWait.setDescription("Roll back action failed!")
                aWait.WaitDisplay(2000)
            End If

            '----------------------------------------------------------

        End If

CONCLUDE:

        REM Restore Previous state
        Me.KeepTrackingConnection = isThreadingAllowed

        If DeleteRollBackFile Then
            Try
                REM Leave Rollback file on disk for fail safe
                If File.Exists(RollbackDB) Then File.Delete(RollbackDB)
            Catch ex As Exception
                REM Ignore error deleting rollback file
                Logger.Write(ex)
            End Try
        End If

        REM Terminate Local Wait
        With aWait
            .endWaiting()
            .Dispose()
        End With
        aWait = Nothing



        Return successful


    End Function



    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections
    ''' </summary>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function RestoreDB(ByRef poutFileUsed As String) As Boolean
        Return Me.RestoreDB(Me.getDefaultFilter(), poutFileUsed:=poutFileUsed)
    End Function

    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections
    ''' </summary>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function RestoreDB(ByVal sFilter As String,
                               DeleteRollBackFile As Boolean) As Boolean
        Return Me.RestoreDB(sFilter:=sFilter, poutFileUsed:=String.Empty, DeleteRollBackFile:=DeleteRollBackFile)
    End Function

    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections
    ''' </summary>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function RestoreDB(DeleteRollBackFile As Boolean) As Boolean
        Return Me.RestoreDB(Me.getDefaultFilter(), DeleteRollBackFile)
    End Function


    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections
    ''' </summary>
    ''' <param name="sFilter">Must Start with DatabaseName_____({==5times)</param>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function RestoreDB(ByVal sFilter As String,
                               ByRef poutFileUsed As String) As Boolean

        Return Me.RestoreDB(sFilter:=sFilter, poutFileUsed:=poutFileUsed, DeleteRollBackFile:=False)
    End Function


    ''' <summary>
    ''' Restore Database of the currently connected Database. Make sure you disconnect all connections
    ''' </summary>
    ''' <param name="sFilter">Must Start with DatabaseName_____({==5times)</param>
    ''' <param name="poutFileUsed">returns the name of the filepath finally used</param>
    ''' <returns>Returns True if successful</returns>
    ''' <remarks></remarks>
    Public Function RestoreDB(ByVal sFilter As String,
                              ByRef poutFileUsed As String,
                              DeleteRollBackFile As Boolean) As Boolean

        Dim openDlg As New OpenFileDialog With {
        .Filter = sFilter,
        .AddExtension = True,
        .FilterIndex = 0,
        .CheckFileExists = True,
        .Multiselect = False
        }
        If poutFileUsed IsNot Nothing AndAlso poutFileUsed <> "" AndAlso IO.Directory.Exists(EIO.getDirectoryFullPath(poutFileUsed)) Then _
            openDlg.InitialDirectory = EIO.getDirectoryFullPath(poutFileUsed)

        With openDlg
            If .ShowDialog() = DialogResult.OK Then
                poutFileUsed = .FileName
                Return Me.RestoreDBFromFile(.FileName, DeleteRollBackFile)
            End If
        End With


        Return False
    End Function


#End Region

    '' ''' <summary>
    '' ''' Backs Up Database of the currently connected Database
    '' ''' </summary>
    '' ''' <param name="sFilter"></param>
    '' ''' <returns>Returns BackedUp File Full Path Name</returns>
    '' ''' <remarks></remarks>
    ''Public Function BackUpDB(Optional ByVal sFilter As String = "Cafe Books Database(*.cfdb)|*.cfdb") As String



    ''    Dim successful As Boolean = False

    ''    Dim svDlg As New SaveFileDialog With {
    ''    .Filter = sFilter,
    ''    .AddExtension = True,
    ''    .FilterIndex = 0
    ''    }

    ''    With svDlg
    ''        .ShowDialog()
    ''        If .FileName = "" Then Return .FileName


    ''        Dim aWait As New WaitAsync(, "Initializing Database ...")


    ''        If BackUpDatabase(.FileName, Me.CurrentDBInUse, aWait) Then

    ''            aWait.setDescription("Your Database has been backed up successfully!")
    ''            aWait.WaitDisplay(2000)
    ''            successful = True
    ''            Application.DoEvents()
    ''        Else
    ''            aWait.setDescription("Error Occurred Backing Up Database")
    ''            aWait.WaitDisplay(2000)
    ''        End If

    ''        REM Terminate Local Wait
    ''        With aWait
    ''            .endWaiting()
    ''            .Dispose()
    ''        End With
    ''        aWait = Nothing


    ''        If successful Then Return .FileName

    ''        Return vbNullString

    ''    End With


    ''End Function

    ''Public Function RestoreDB(Optional ByVal sFilter As String = "Cafe Books Database(*.cfdb)|*.cfdb") As Boolean

    ''    Dim successful As Boolean = False

    ''    Dim openDlg As New OpenFileDialog With {
    ''   .Filter = sFilter,
    ''   .AddExtension = True,
    ''   .FilterIndex = 0
    ''   }

    ''    With openDlg
    ''        .ShowDialog()
    ''        If .FileName = "" Then Return False


    ''        Dim aWait As New WaitAsync(, "Initializing Database ...")

    ''        Try

    ''            If RestoreDatabase(.FileName, "coderit_cafebooks", aWait) Then

    ''                aWait.setDescription("Your Database has been restored successfully!")
    ''                REM Delay this thread for 2secs
    ''                aWait.WaitDisplay(2000)
    ''                successful = True

    ''            Else
    ''                aWait.setDescription("Error Occurred Restoring Database")
    ''                aWait.WaitDisplay(2000)

    ''            End If

    ''        Catch ex As Exception
    ''            aWait.setDescription(ex.Message)
    ''            aWait.WaitDisplay(2000)

    ''        End Try

    ''        ''PlsWaitFrm.CloseForm(3)

    ''        REM Terminate Local Wait
    ''        With aWait
    ''            .endWaiting()
    ''            .Dispose()
    ''        End With
    ''        aWait = Nothing



    ''    End With

    ''    Return successful

    ''End Function




#End Region


#End Region

#Region "Private"

    ''' <summary>
    ''' Turn off database off and on using sql on Master
    ''' </summary>
    ''' <param name="DBName">Database name can not be master</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TurnDatabaseOffAndOn(ByVal DBName As String) As Boolean
        If DBName.ToLower() = DEFAULT_DB Then Return False
        Me.dbExec(String.Format("alter database {0} set offline with rollback immediate", DBName), MS_SQL.Server.DEFAULT_DB)
        REM Turn it on back database
        Return Me.dbExec(String.Format("alter database {0} set online", DBName), DEFAULT_DB)
    End Function


    ''' <summary>
    ''' Create the database using current connection and current database name. It also create dbVersion Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreateDatabase() As Boolean
        Return Me.CreateDatabase(Me.CurrentDBInUse)
    End Function



    Public Function getDatabaseReadyForVersioning() As Boolean
        If Not IsTableCreatedOnDatabase("DBInfo") Then

            If Not Me.createVersionTable_on_DB(Me.DatabaseName) Then Throw New Exception("Error Creating DBVersion Table!")

        End If
        Return True
    End Function

    Public Function getDatabaseReadyForCaching() As Boolean
        If Not Me.setAllowSnapshotOnDatabase(True) Then Throw New Exception("Error setting ALlow_Snapshot On")
        Return True
    End Function




    ''' <summary>
    ''' Create a database with a Version Table. NB: This will drop the database if it exists
    ''' </summary>
    ''' <param name="pDatabaseName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateDatabase(ByVal pDatabaseName As String) As Boolean
        REM NB: This will drop the database if it already exist
        Dim aWait As New WaitAsync("Please Wait While Your Database is being Configured", "Creating Database ...")

        ''If DatabaseName = Me.CurrentDBInUse Then Return False REM You cant drop a database you are using to access the SQL
        ''If Not CanConnect() Then Return False REM There is  not valid connection with the default parameters
        Try


            REM Since I will perform this operation with master
            If Not Me.PingDB() Then Return False REM I cant connect using master

            REM Restart Database before you begin any transaction
            REM By this you can disconnect any user connected to it
            'restartSQLServer()

            REM If this didnt work because it says database in use
            REM Try Delete all tables on it
            REM Else if it didnt because it does not exist then continue
            Me.ForceDropDatabase(pDatabaseName)
            ''If Not dbExec(String.Format("drop database {0}", DatabaseName), "Master") And
            ''    getSQLConnection(DatabaseName) IsNot Nothing Then

            ''    aWait.setDescription("Deleting Previous Tables")
            ''    REM DELETE All Tables ON IT
            ''    Dim rs As DataSet = getRS("SELECT TABLE_NAME FROM information_schema.tables", DatabaseName)
            ''    If IsDataSetValid(rs) Then
            ''        Dim iCount As Long = 0
            ''        aWait.setProgressBar(rs.Tables(0).Rows.Count, iCount)
            ''        For Each dtRow As DataRow In rs.Tables(0).Rows

            ''            dbExec(String.Format("Drop table [{0}]", dtRow("TABLE_NAME")), DatabaseName)
            ''            Threading.Thread.Sleep(500)

            ''            iCount += 1
            ''            aWait.setProgressBar(rs.Tables(0).Rows.Count, iCount)
            ''        Next
            ''    End If

            ''    REM Database exists we just deleted the tables on it
            ''    GoTo DATBASEAlreadyExist
            ''End If


            REM If I cant create database then Not Good
            REM Just create the collation once and for all
            If dbExec(String.Format("create database {0} COLLATE {1}", pDatabaseName,
                                    COLLATION___Latin1_General_CI_AS), DEFAULT_DB) Then

                REM Set current db to the one we created
                ''Me.CurrentDBInUse = DatabaseName
                REM I think App needs rest here after creating database
                Me.CurrentDBInUse = pDatabaseName
                REM Just Check if i can connect to waste time
                If Me.CanConnect() Then
                    Logger.Log("You can connect now to the created Database")
                Else
                    REM 
                    '
                    'Database is created but I couldnt connect to it
                    'This is crazy :)
                    '
                    '
                    '' ''Dim TrackerEnabled As Boolean = Me.KeepTrackingConnection
                    '' ''Me.KeepTrackingConnection = False
                    ' '' ''Me.restartSQLServer()

                    '' ''REM Sleep and try again
                    '' ''Logger.Log("Am  Trying to make the database wake up after creating it")
                    '' ''aWait.startWaiting("Please wait while your Database is being Validated", "Boosting SQL Server ...")
                    ' '' ''Threading.Thread.Sleep(7000)
                    '' ''For i As Int16 = 1 To 3

                    '' ''    'Me.restartSQLServer()
                    '' ''    'Logger.Log("Fetching DB Version to boost the database responsiveness: Version-: " &
                    '' ''    '  Me.FetchDBVersion()
                    '' ''    '  )
                    '' ''    Me.TurnDatabaseOffAndOn(Me.CurrentDBInUse)
                    '' ''    If Me.CanConnect() Then Logger.Log("You can connect now to the created Database: " & i) : Exit For


                    '' ''    Threading.Thread.Sleep(4000)
                    '' ''Next

                    '' ''REM If after sleeping and retrying, I still can connect.
                    '' ''REM It will reflect when am trying to create Version Table
                    '' ''aWait.endWaiting()



                    '' ''Me.KeepTrackingConnection = TrackerEnabled

                    Me.WakeUpServer__onCurrentDBInUse()

                End If

                REM Force the collation to Latin because of different OS Languages
                ''dbExec(
                ''    String.Format("ALTER DATABASE {0} COLLATE Latin1_General_CI_AS ", DatabaseName), "Master"
                ''    )


                If Not Me.CanConnect() Then GoTo CloseFailed


DATBASEAlreadyExist:
                REM Create table on database
                If Not Me.createVersionTable_on_DB(pDatabaseName) Then GoTo CloseFailed

                Return True
            End If


CloseFailed:

        Catch ex As Exception
            Throw ex
        Finally
            If [aWait] IsNot Nothing Then [aWait].Dispose()
            [aWait] = Nothing
        End Try

        Return False

    End Function





    '' ''' <summary>
    '' ''' Allows to force a collation on database. Requires Exclusive Lock of the DB (restart)
    '' ''' </summary>
    '' ''' <param name="CollationName"></param>
    '' ''' <returns></returns>
    '' ''' <remarks></remarks>
    ''Private Function forceCollationOnDatabase(ByVal CollationName As String) As Boolean

    ''    REM Force the Use of a Specific Collation Name
    ''    REM Latin1_General_CI_AS
    ''    Dim rs As DataSet = getRS(
    ''                                String.Format(
    ''                                                "SELECT SD.name , SD.collation_name " & _
    ''                                                "FROM Sys.databases SD " & _
    ''                                                "WHERE SD.name = '{0}'", Me.CurrentDBInUse
    ''                                                ),
    ''                                             Me.CurrentDBInUse
    ''                                            )


    ''    If IsDataSetValid(rs) Then
    ''        REM Becareful, It is possible to get NULL as a result
    ''        If EStrings.valueOf(rs.Tables(0).Rows(0)("collation_name")) <> CollationName Then

    ''            ''Logger.Log("Please wait while the Database Server is being restarted!")
    ''            ''REM First Restart to make sure no other connection is on
    ''            ''Me.restartSQLServer()


    ''            REM Update it
    ''            Return Me.dbExec(
    ''                String.Format(
    ''                                "Alter Database {0} " & _
    ''                                "COLLATE {1}",
    ''                                Me.CurrentDBInUse, CollationName
    ''                                ),
    ''                            Me.CurrentDBInUse
    ''                            )

    ''        Else

    ''            Logger.Log(
    ''                String.Format(
    ''                    "COLLATION {0} has been Successfully set on {1}",
    ''                       CollationName, Me.CurrentDBInUse
    ''                       )
    ''                )
    ''            Return True

    ''        End If

    ''    End If

    ''    REM No way it should get here unless connection is not working
    ''    Logger.Log("Error Fetching Collations from database because connection isnt working.")
    ''    Return False
    ''End Function

    ''' <summary>
    ''' Check if database is created and ready for usage Locally
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckIfDatabase__Is__Ready_For_Usage() As Boolean

        ' ''REM Check to see if we can connect already to database which means the database already exist
        ' ''REM if Yes ... do silent backup to some where
        ' ''REM if back is not successful Warn User before proceeding

        ' ''REM After creating this database then restore the previous version automatically

        REM Do Database Upgrade instead
        REM Skip Next Step

        REM Check If SQL Server is Installed
        If Not Directory.Exists(SQLServerDatabaseFolder) Then _
            Throw New Exception(String.Format("SQL SERVER with this instance name [ {0} ] is not found on this device", Me.SQLServerAddress))

        REM Check if the Appropriate Service is running
        If OperatingSystem.getServiceStatus(Me.ServiceInstanceName) = ServiceProcess.ServiceControllerStatus.Stopped Then
            Me.startSQLServer()
        End If

        If OperatingSystem.getServiceStatus(Me.ServiceInstanceName) <> ServiceProcess.ServiceControllerStatus.Running Then
            Throw New Exception(
                String.Format("SQL SERVER Service ({0}) could not be started!", Me.ServiceInstanceName)
                )
        End If


        If CanConnect() Then

            REM It means database created but first file didnt run
            REM Check if a table exist incase it didnt run the first file

            If Not IsDataSetValid(
                 getRS(
                     "SELECT * " & _
                     "FROM sys.tables " & _
                     "WHERE [name]='DBInfo'"
                     )
                 ) Then

                REM Try recreating it if we can put version table on it
                If Not Me.createVersionTable_on_DB(Me.CurrentDBInUse) Then Return False

                REM ELSE DBInfo Version table already exist.
                REM It is a well functional db
            Else
                Logger.Log("DBInfo table is Alright")
            End If


        Else

            REM we cant connect to the db. Perhaps it is not created
            REM Try creating it else .. there is a different problem
            If questionMsg("Would you like to create new DATABASE NOW?", "CREATE NEW DATABASE?") = DialogResult.Yes Then
                If Not CreateDatabase(Me.CurrentDBInUse) Then Return False
            Else
                Return False
            End If

        End If




        REM If no problem so far, TryToUpgradeDatabase:
        REM RE-CHECK Again Here
        REM IF IT DOESNT EXIST THEN DONT UPGRADE
        REM For now I dont allow DB Collation changeable from outside
        REM Force DB Collation before upgrading. Restart to gain Exclusive lock
        ''If Not Me.forceCollationOnDatabase(COLLATION___Latin1_General_CI_AS) Then
        ''    Me.restartSQLServer()
        ''End If

        ''Dim iCount As Int32 = 0
        ''Do While Not Me.forceCollationOnDatabase(COLLATION___Latin1_General_CI_AS) AndAlso
        ''    iCount < 3

        ''    Threading.Thread.Sleep(1000)

        ''    Logger.Log("Fetching DB Version to boost the database responsiveness: Version-: " &
        ''               Me.FetchDBVersion()
        ''               )

        ''    iCount += 1

        ''Loop

        ''If Not Me.forceCollationOnDatabase(COLLATION___Latin1_General_CI_AS) Then
        ''    Logger.Log("Error Occurred While Forcing Collation : " & COLLATION___Latin1_General_CI_AS)
        ''    Logger.Log("NOT a big deal. just restart the application")
        ''    Return False
        ''End If

        If Not Me.UpgradeDatabase(Me.DB_Target_Version, Me.FetchDBVersion()) Then
            Logger.Log("Error Occurred While Upgrading database")
            Return False
        End If




        REM Means the User-Defined Database is created and ready for use and tracking
        'Me.isDBCreated = True
        Return True

    End Function


    ''' <summary>
    ''' Makes sure a Database is deleted from database Engine
    ''' </summary>
    ''' <param name="DBName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ForceDropDatabase(ByVal DBName As String) As Boolean

        If IsDatabaseRegistred(DBName) Then
            REM Turn off database
            Me.dbExec(String.Format("alter database {0} set offline with rollback immediate", DBName), MS_SQL.Server.DEFAULT_DB)
            Me.dbExec(String.Format("drop database {0}", DBName), MS_SQL.Server.DEFAULT_DB)
        End If

        Try
            REM Try delete files if they exist
            EIO.DeleteFileIfExists(String.Format("{0}\{1}.mdf", SQLServerDatabaseFolder, DBName))
            EIO.DeleteFileIfExists(String.Format("{0}\{1}_Log.ldf", SQLServerDatabaseFolder, DBName))
        Catch ex As Exception
            Logger.Print("Error Deleting Original Database Files ... ", ex)
            Return False
        End Try

        Return True

    End Function

    ''' <summary>
    ''' Checks if the Database Exist on Database Engine Instance
    ''' </summary>
    ''' <param name="DBName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsDatabaseRegistred(ByVal DBName As String) As Boolean

        Return IsDataSetValid(
                        getRS(
                              String.Format(
                                                    "SELECT * " & _
                                                        "FROM Sys.databases SD " & _
                                                        "WHERE SD.name = '{0}'", DBName
                                                        ), DEFAULT_DB
                                )
                            )

    End Function


    Private Function Is_DB_Ready_For__ClientConnection_On_Network(
                                                ByVal DBLoginUserName As String,
                                                ByVal DBLoginUserPassword As String,
                                                ByVal DBTCPPort As Int32) As Boolean
        REM ***************************************************************************************
        Dim aWait As New WaitAsync(, "Checking If Clients Can Connect to Your PC")
        Const sFireWallName As String = "Cybersoft SQL Server Remote Connection"
        Logger.Log("Checking If Clients Can Connect to Your PC")

        Try


            'TEST IF Clients Can Connect to this PC
            REM Fix Connection On Port
            If Not Me.CanClientConnectToThisServer(DBTCPPort.ToString(), sFireWallName) Then
                REM Try to Configure Then Test Again
                aWait.setDescription("Configuring your pc so clients can connect...")
                Logger.Log("Configuring your pc so clients can connect...")
                Dim ShouldIRestartServer As Boolean


                Me.AllowNetworkUsersToConnect(DBLoginUserName, DBLoginUserPassword,
                                              DBTCPPort.ToString(),
                                              sFireWallName,
                                              ShouldIRestartServer
                                              )



                If ShouldIRestartServer Then restartSQLServer()


                If Not Me.CanClientConnectToThisServer(DBTCPPort.ToString(), sFireWallName) Then _
                    Me.restartSQLServer() : Me.WakeUpServer__onCurrentDBInUse()


                aWait.setDescription("Checking If Clients Can Connect to Your PC")
                Logger.Log("Checking If Clients Can Connect to Your PC")

                REM Go back to client to test
                If Not CanClientConnectToThisServer(CStr(DBTCPPort), sFireWallName) Then
                    Return False
                Else
                    GoTo CLientsCanConnectSuccessfully
                End If

            Else
CLientsCanConnectSuccessfully:
                Logger.Log("Clients can connect to this Server on Port: " & DBTCPPort)

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
    ''' Checking if ports needed by SQL Server is enabled in Firewall and if TCP/IP is enabled to make sure client can connect to server. 
    ''' Also check if Login is created
    ''' </summary>
    ''' <param name="sPort"></param>
    ''' <param name="sFirewallName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overridable Function CanClientConnectToThisServer(Optional ByVal sPort As String = "1433",
                                              Optional ByRef sFirewallName As String = "SQL Server Remote Connection") As Boolean
        REM Check if the firewallname exists on FirewallSettings
        REM Check if the port is enabled on SQL Server
        REM Check if ALLOW Exception is TRUE

        Logger.Log("Checking firewall for port: " & sPort)
        If Not Firewall.isInboundPortExceptionValid(sFirewallName, sPort) Then Logger.Log("failed firewall") : Return False
        Logger.Log("passed firewall. Creating SQL Server 2008 registry settings")

        REM Check if the folder[subKey] is even available
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll") Is Nothing Then Logger.Log("SQL Server 2008 registry settings Failed on 1") : Return False


        REM Check if TCP is Enabled too


        REM Check if port is available on sql
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpDynamicPorts"
                                          )
        If tmpPorts = vbNullString Then Logger.Log("SQL Server 2008 registry settings Failed on 2") : Return False
        If tmpPorts.IndexOf(sPort) < 0 Then Logger.Log("SQL Server 2008 registry settings Failed on 3") : Return False



        Logger.Log("SQL Server 2008 registry settings passed checking state COMPLETED SUCCESSFULLY")

        REM If this works then all is fine
        Return New Client(Me.SQLServerAddress, Me.SQLServerPort, Me.SQLServerUserName,
                           Me.SQLServerPassword, Me.DatabaseName, False).CanConnect()


    End Function


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
    Protected Overridable Function AllowNetworkUsersToConnect(
                                              Optional ByVal sUserName As String = "epro",
                                              Optional ByVal sUserPassword As String = "s123",
                                              Optional ByVal sPort As String = "1433",
                                              Optional ByRef sFirewallName As String = "SQL Server Remote Connection",
                                              Optional ByRef sRequireSQLServerRestart As Boolean = False
                                                                                   ) As Boolean

        REM SET Allow Exception=TRUE



        REM Find a way to display error message
        Const sFirewallDescription As String = "Default Port for SQL Server Remote Connections"
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




        Logger.Log("Configuring SQL Server 2008 Registry")
        '
        ''   Configure registry

        REM If any change occur in this environment, you have to indicate restart
        '' ''   
        '' ''   SQL Server RegLoc
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer
        REM Just messing around. It should Exist if SQL Server 2008 Express is Installed :)
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                        "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer") Is Nothing Then

            REM No SQL Server 2008 Express Edition on this machine
            Logger.Log("SQL Server 2008 registry settings was NOT Found on the PC. AM NOT SURE [MSSQL10.SQLEXPRESS] is installed")
            Return False
        End If



        ' '' ''         Then Restart
        ' '' ''        LoginMode
        ' '' ''1:      WindowsAuthenticationOnly
        ' '' ''2:      Mixed
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer",
                                           "LoginMode", "2", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Logger.Log("SQL Server 2008 registry settings FAILED, LoginMode NOT SET to Mix Authentication") : Return False REM return false if I could not set authentication mode






        ' '' ''        TCP(Mode)
        REM         DELETE The TCP/IP Folder and Recreate it
        REM     Incase of all the previous rules that has been auto-generated and also to reduce time to loop through each subkeys
        REM Instead I will delete all other subFolders in the folder that i dont want EXCEPT IPAll
        ' ''Registry.DeleteASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
        ' ''                                    "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib",
        ' ''                                        "Tcp"
        ' ''                                    )

        Registry.CreateASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                            "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib",
                                                "Tcp"
                                            )


        REM Now Add All It's Default Parameters
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp


        REM DisplayName:TCP/IP
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "DisplayName", "TCP/IP"
                                           ) Then Return False REM return false if I could not create Parameter


        REM KeepAlive = 30000
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "KeepAlive", "30000", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not create Parameter


        ' '' ''        Enabled = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "Enabled", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could not enable tcp


        ' '' ''        ListenOnAllIPs = 1
        If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                           "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp",
                                           "ListenOnAllIPs", "1", Microsoft.Win32.RegistryValueKind.DWord
                                           ) Then Return False REM return false if I could make tcp listen on all ips




        REM Now Create A Single SubKey
        ' '' ''            HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll
        If Registry.getRegistrySubKeyFolder(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll") Is Nothing Then
            ''DisplayName=Any IP Address
            ''    TcpDynamicPorts = 1433
            ''    TcpPort = ""
            If Registry.CreateASubKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp", "IPAll") IsNot Nothing Then

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                          "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                          "DisplayName", "Any IP Address"
                                          ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpDynamicPorts", "1433"
                                         ) Then Return False REM Failed

                If Not Registry.CreateAKey(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
                                         "TcpPort", ""
                                         ) Then Return False REM Failed

            End If





        End If

        REM DELETE ALL OTHER SUB FOLDERS UNDER TCP Except IPAll
        Registry.deleteAllSubKeysInThisPathExcept(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                                "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp",
                                                {"IPAll"}
                                                )


        ' '' ''        TcpDynamicPorts = 1433
        ' '' ''            or which ever port you want
        Dim tmpPorts As String = Registry.readRegistryStringValue(Registry.RegEditKeys.HKEY_LOCAL_MACHINE,
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
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
                                         "SOFTWARE\Microsoft\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQLServer\SuperSocketNetLib\Tcp\IPAll",
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
        Logger.Log("SQL Server 2008 registry settings was FULLY CONFIGURED")
        Logger.Log("Creating Firewall inbound for port: " & sPort)
        If Not Firewall.createInboundPortExceptions(sFirewallName, sFirewallDescription, sPort) Then Logger.Log("Firewall inbound FAILED") : Return False REM Firewall config fail
        Logger.Log("Firewall inbound CREATED")

        REM Successfully configured FireWall
        Return True
    End Function


    ''' <summary>
    ''' Dis-allow users from connecting to your local SQL Service.
    ''' </summary>
    ''' <param name="SQLFireWallConfigName">The SQLFireWall Configuration Name You Used When Setting It Up</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DisableNetworkUsersOn(ByVal SQLFireWallConfigName As String) As Boolean


        Throw New NotImplementedException()

    End Function


    ''' <summary>
    ''' Try to make SQL Server respond using master DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function WakeUpServer__onCurrentDBInUse() As Boolean

        Dim aWait As New WaitAsync(, "trying to ping sql server using master")
        ''Dim TrackerEnabled As Boolean = Me.KeepTrackingConnection, Successful As Boolean = False
        ''Me.KeepTrackingConnection = False
        ' ''Me.restartSQLServer()

        ''REM Sleep and try again
        ''Logger.Log("Am  Trying to make the database wake up after creating it")
        ''aWait.startWaiting("Please wait while your Database is being Validated", "Boosting SQL Server ...")
        ' ''Threading.Thread.Sleep(7000)
        ''For i As Int16 = 1 To 5

        ''    'Me.restartSQLServer()
        ''    'Logger.Log("Fetching DB Version to boost the database responsiveness: Version-: " &
        ''    '  Me.FetchDBVersion()
        ''    '  )
        ''    Logger.Log("CanConnect(): " & Me.CanConnect().ToString())

        ''    If Me.getSQLConnection(DEFAULT_DB) IsNot Nothing Then
        ''        Successful = True
        ''        Logger.Log("You can connect now to the created Database: " & i) : Exit For
        ''    End If


        ''    Threading.Thread.Sleep(4000)
        ''Next

        ''REM If after sleeping and retrying, I still can connect.
        ''REM It will reflect when am trying to create Version Table
        ''aWait.endWaiting()



        ''Me.KeepTrackingConnection = TrackerEnabled

        Dim TrackerEnabled As Boolean = Me.KeepTrackingConnection, Successful As Boolean = False
        Me.KeepTrackingConnection = False
        'Me.restartSQLServer()

        REM Sleep and try again
        Logger.Log("Am  Trying to make the database wake up after creating it")
        aWait.startWaiting("Please wait while your Database is being Validated", "Boosting SQL Server ...")
        'Threading.Thread.Sleep(7000)
        For i As Int16 = 1 To 3

            'Me.restartSQLServer()
            'Logger.Log("Fetching DB Version to boost the database responsiveness: Version-: " &
            '  Me.FetchDBVersion()
            '  )
            Me.TurnDatabaseOffAndOn(Me.CurrentDBInUse)
            If Me.CanConnect() Then Logger.Log("You can connect now to the created Database: " & i) : Successful = True : Exit For


            Threading.Thread.Sleep(4000)
        Next

        REM If after sleeping and retrying, I still can connect.
        REM It will reflect when am trying to create Version Table
        aWait.endWaiting()



        Me.KeepTrackingConnection = TrackerEnabled


        Return Successful
    End Function

#Region "BackUp and Recovery"



#Region "Properties"

    ''' <summary>
    ''' Point Where Hard Copies are stored
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable ReadOnly Property SQLServerDatabaseFolder As String
        Get
            Return "C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA"
        End Get
    End Property

    ''' <summary>
    ''' Use to store Hard Copies
    ''' </summary>
    ''' <remarks></remarks>
    Private Const tempFolder As String = "C:\Windows\Temp"


    ''' <summary>
    ''' Keeps the version you wish this database should be
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DB_Target_Version As Double = 0.0

#End Region



    '' ''' <summary>
    '' ''' Run Back Up Database Process [General Functions]
    '' ''' </summary>
    '' ''' <param name="PlsWaitFrm">Displays Process</param>
    '' ''' <returns></returns>
    '' ''' <remarks>Packs the files sent into a folder and zips it and return to the suggested location</remarks>
    ''Private Function BackUpDatabase(ByVal BackUpFileFullPathName As String,
    ''                                      ByRef PlsWaitFrm As WaitAsync,
    ''                                ByVal ParamArray BackFiles() As String
    ''                                ) As Boolean

    ''    'Check if the epbackup folder is created ... delete it
    ''    'Create epBackUp Folder
    ''    'Copy all files sent for backup in it
    ''    '**Zip the Folder and Return the zip File 
    ''    'NB: Copying is like renaming
    ''    'BackUp is Ready


    ''    Try

    ''        REM ***********************************************************************************************
    ''        'Am Just doing this to make sure the files are safe to add to zip
    ''        Dim tmpBackUpFolder As String = String.Format(
    ''                                                    "{0}\{1}",
    ''                                                    tempFolder,
    ''                                                    "epBackup"
    ''                                                        )

    ''        EIO.DeleteAndRecreateDirectory(tmpBackUpFolder)

    ''        PlsWaitFrm.setDescription("Checking Database")
    ''        Application.DoEvents()
    ''        CopyDbFilesInThisLocationToAnother(BackFiles, tmpBackUpFolder, PlsWaitFrm)


    ''        '' ''Copy the files to the backup directory
    ''        ''For Each _file As String In BackFiles
    ''        ''    'Copy both the database file name and the log _log
    ''        ''    System.IO.File.Copy(
    ''        ''                    _file,
    ''        ''                    String.Format("{0}\{1}",
    ''        ''                                   tmpBackUpFolder,
    ''        ''                                   FileIO.FileSystem.GetName(_file)
    ''        ''                                   ),
    ''        ''                               True
    ''        ''                            )


    ''        ''Next

    ''        PlsWaitFrm.setDescription("Packaging Database")

    ''        Application.DoEvents()
    ''        PlsWaitFrm.setProgressBar(2, 1)

    ''        REM Override Files with the one in temp folder
    ''        BackFiles = FileIO.FileSystem.GetFiles(
    ''                                                               tmpBackUpFolder,
    ''                                                               FileIO.SearchOption.SearchTopLevelOnly,
    ''                                                               "*"
    ''                                                           ).ToArray


    ''        REM If Nothing was copied return false
    ''        If BackFiles Is Nothing Then Return False

    ''        If BackFiles.Length = 0 Then Return False

    ''        REM ***********************************************************************************************


    ''        'Zip It
    ''        Dim returnVal As Boolean = Compression.CreateZipFile(BackUpFileFullPathName,
    ''        BackFiles
    ''        )
    ''        PlsWaitFrm.setProgressBar(2, 2)

    ''        Return returnVal
    ''        ''Return clsCompression.CreateZipFile(BackUpFileFullPathName,
    ''        ''                                             tmpBackUpFolder
    ''        ''                                             )

    ''    Catch ex As Exception

    ''        Return False

    ''    End Try


    ''    Return True
    ''End Function



    '' ''' <summary>
    '' ''' Just Provide the Database Name like coderit_cafebooks
    '' ''' </summary>
    '' ''' <param name="BackUpFileFullPathName"></param>
    '' ''' <param name="DatabaseName"></param>
    '' ''' <param name="PlsWaitFrm">Displays Process</param>
    '' ''' <returns></returns>
    '' ''' <remarks></remarks>
    ''Private Function BackUpDatabase(ByVal BackUpFileFullPathName As String,
    ''                            ByVal DatabaseName As String,
    ''                           ByRef PlsWaitFrm As WaitAsync
    ''                            ) As Boolean

    ''    'Check if the epbackup folder is created ... delete it
    ''    'Create epBackUp Folder
    ''    'Copy all files sent for backup in it
    ''    '**Zip the Folder and Return the zip File 
    ''    'NB: Copying is like renaming
    ''    'BackUp is Ready

    ''    PlsWaitFrm.setDescription("Fetching Database Files..")
    ''    Application.DoEvents()

    ''    Try
    ''        Dim BackUpFiles() As String = FileIO.FileSystem.GetFiles(
    ''                                                                SQLServerDatabaseFolder,
    ''                                                                FileIO.SearchOption.SearchTopLevelOnly,
    ''                                                              String.Format(
    ''                                                                "{0}*",
    ''                                                                DatabaseName
    ''                                                                )
    ''                                                            ).ToArray

    ''        Return BackUpDatabase(BackUpFileFullPathName, PlsWaitFrm, BackUpFiles)

    ''    Catch ex As Exception

    ''        Return False

    ''    End Try


    ''    Return True
    ''End Function





    ''    ''' <summary>
    ''    ''' Restore Database file to the Default SQL Server Database. Throws Exceptions if database is in use
    ''    ''' </summary>
    ''    ''' <param name="DatabaseFilesAsZipPathName"></param>
    ''    ''' <param name="DatabaseName"></param>
    ''    ''' <param name="aWait">Display Process</param>
    ''    ''' <returns></returns>
    ''    ''' <remarks></remarks>
    ''    Private Function RestoreDatabase(ByVal DatabaseFilesAsZipPathName As String,
    ''                                           ByVal DatabaseName As String,
    ''                                           ByRef aWait As WaitAsync) As Boolean

    ''        'First Extract the file to a location
    ''        'Get the current version of database
    ''        '
    ''        'If lower than the required ...
    ''        '   Do Upgrade
    ''        'End If
    ''        '
    ''        'If Upgrade successful or the db version is already ok
    ''        '   BackUp the current DB into a SpecialLocation called Last Backup [Incase of rollback operation]
    ''        '   Copy the files to replace the original in Database Main Location


    ''        Dim epRestoreFolder As String = String.Format(
    ''                                                    "{0}\{1}",
    ''                                                    tempFolder,
    ''                                                    "epRestore"
    ''                                                        )

    ''        EIO.DeleteAndRecreateDirectory(epRestoreFolder)


    ''        Dim epRollover As String = String.Format(
    ''                                                       "{0}\{1}",
    ''                                                       tempFolder,
    ''                                                       "epRollover"
    ''                                                           )

    ''        EIO.DeleteAndRecreateDirectory(epRollover)


    ''        aWait.setDescription("Decomposing Database")


    ''        If EBoolean.valueOf(
    ''            Compression.ExtractZipFolder(DatabaseFilesAsZipPathName, epRestoreFolder)
    ''            ) Then
    ''            'Am Changing the algorithm because ... attaching database file of same name aint working

    ''            'First we get the version of the current database ... then we are through with the current
    ''            'database else if we need to do rollover

    ''            'This is the Version Currently Compatible with The Currently Installed Executor
    ''            'This is the version we will be using for comparison .. It has to be the latest
    ''            'So I must always update the version of this one with package ...
    ''            '1++ everytime there is a change
    ''            Dim CurrentDbVersion As Double = FetchDBVersion()

    ''            aWait.setDescription("Creating Rollover")
    ''            Application.DoEvents()
    ''            'Now Create a Rollover Folder for failsafe
    ''            'Transfer the original files there
    ''            If Not CopyDbFilesInThisLocationToAnother(
    ''                                                                SQLServerDatabaseFolder,
    ''                                                                DatabaseName,
    ''                                                                epRollover, aWait
    ''                                                                ) Then Throw New Exception("Database is in Use. Close all applications and try again") 'Could not keep file for failsafe because db is in use

    ''            ''If Not clsDatabaseRecovery.CopyDbFilesInThisLocationToAnother(
    ''            ''                                                    clsDatabaseRecovery.SQLServerDatabaseFolder,
    ''            ''                                                    DatabaseName,
    ''            ''                                                    epRollover
    ''            ''                                                    ) Then Return False 'Could not keep file for failsafe because db is in use



    ''            aWait.setDescription("Restoring Database")
    ''            Application.DoEvents()
    ''            'Now move the restore files to overwrite the current in the default directory
    ''            CopyDbFilesInThisLocationToDefault(epRestoreFolder, DatabaseName, aWait)


    ''            'Now Fetch
    ''            'This is the version of the database we want to restore
    ''            ''Dim RestoreDbVersion As Double = basTestMYSQLServerConnection.FetchDBVersion(
    ''            ''                                            String.Format(
    ''            ''                                                "{0}\{1}.mdf",
    ''            ''                                                epRestoreFolder, DatabaseName
    ''            ''                                                )
    ''            ''                                            )

    ''            aWait.setDescription("Upgrading Database")
    ''            Application.DoEvents()

    ''            'Database that has been restored hasnt been linked with the server
    ''            'needs a persistent double connection to it or atleast some thread time
    ''            'Up to 5 secs
    ''            'Since My First DB Release is 1.0 .. If Version returned is 0 then
    ''            'An error occured while fetching so do rollback
    ''            ''basGeneralFunctions.Sleep(1000) 'Sleep App for 1secs
    ''            ''basDatabaseFunctions.PingDB()
    ''            ''basGeneralFunctions.Sleep(7000) 'Sleep App for 7secs

    ''            'User can try again
    ''TryFetchingTheVersionOfNewDB:
    ''            'Probably too fast
    ''            Dim RestoreDbVersion As Double = FetchDBVersion()
    ''            If RestoreDbVersion = 0 Then
    ''                '' ''If MsgBox("The Version of the New Database Could Not be Fetched!!! " & vbCrLf &
    ''                '' ''    "Would you like to Fetch the Version Again", vbYesNo, "Error Occurred") = vbYes Then _
    ''                '' ''    GoTo TryFetchingTheVersionOfNewDB

    ''                Logger.Log("Error fectching DB Version. Performing rollback action now...")

    ''                GoTo RollBackOperation

    ''            End If


    ''            'Now Perform Upgrade
    ''            If UpgradeDatabase(CurrentDbVersion, RestoreDbVersion) Then
    ''                If CurrentDbVersion > 0 Then
    ''                    UpdateDBVersion(CurrentDbVersion)
    ''                End If

    ''                Return True

    ''            Else

    ''                aWait.setDescription("I could not upgrade the New DB Version.")
    ''                aWait.WaitDisplay(2000)
    ''RollBackOperation:
    ''                aWait.setDescription("Executing Rollback Operation")
    ''                Application.DoEvents()
    ''                'Perform Rollover
    ''                'Transfer back original files there
    ''                CopyDbFilesInThisLocationToAnother(
    ''                                                                    epRollover,
    ''                                                                    DatabaseName,
    ''                                                                    SQLServerDatabaseFolder, aWait
    ''                                                                    )


    ''                aWait.setDescription("Roll Back Successful. No changes has been made to your database.")
    ''            End If


    ''        End If

    ''        Return False
    ''    End Function



    ''    ''' <summary>
    ''    ''' Transfer the database files in this location to the default database location
    ''    ''' </summary>
    ''    ''' <param name="DbFilesLocation"></param>
    ''    ''' <param name="DBName"></param>
    ''    ''' <param name="PlsWait">Display Process</param>
    ''    ''' <remarks></remarks>
    ''    Private Function CopyDbFilesInThisLocationToDefault(ByVal DbFilesLocation As String,
    ''                                                              ByVal DBName As String,
    ''                                                              ByRef PlsWait As WaitAsync) As Boolean


    ''        Try

    ''            Dim BackUpFiles() As String = FileIO.FileSystem.GetFiles(
    ''                                                                        DbFilesLocation,
    ''                                                                        FileIO.SearchOption.SearchTopLevelOnly,
    ''                                                                      String.Format(
    ''                                                                        "{0}*",
    ''                                                                        DBName
    ''                                                                        )
    ''                                                                    ).ToArray

    ''            Dim RetriedCopy As Boolean = False
    ''BeginCopy:
    ''            PlsWait.setDescription("Copying Database Files ...")
    ''            Dim iCount As Long = 0

    ''            Try
    ''                REM Display Bar Ready to Move
    ''                PlsWait.setProgressBar(BackUpFiles.Count, iCount)

    ''                ''Copy the files to the backup directory
    ''                For Each _file As String In BackUpFiles

    ''                    'Copy both the database file name and the log _log
    ''                    System.IO.File.Copy(
    ''                                    _file,
    ''                                    String.Format("{0}\{1}",
    ''                                                   SQLServerDatabaseFolder,
    ''                                                   FileIO.FileSystem.GetName(_file)
    ''                                                   ),
    ''                                               True
    ''                                            )



    ''                    iCount += 1
    ''                    PlsWait.setProgressBar(BackUpFiles.Count, iCount)
    ''                    Application.DoEvents()
    ''                Next
    ''            Catch ex As Exception
    ''                If Not RetriedCopy Then
    ''                    RetriedCopy = True
    ''                    stopSQLServer()
    ''                    ' If clsDatabaseRecovery.StopDefaultSQLServer(PlsWait) Then
    ''                    GoTo BeginCopy

    ''                    'End If
    ''                End If
    ''            End Try

    ''        Catch ex As Exception
    ''            'Problem file is in use and cannot overwrite
    ''            Return False
    ''        End Try

    ''        startSQLServer()

    ''        ''clsDatabaseRecovery.StartDefaultSQLServer(PlsWait,
    ''        ''                                          InitiateStartUsingDB)
    ''        Return True
    ''    End Function



    ''    ''' <summary>
    ''    ''' Transfer DB Files in a Location to Another
    ''    ''' </summary>
    ''    ''' <param name="DbFilesLocation"></param>
    ''    ''' <param name="DBName"></param>
    ''    ''' <param name="OtherLocation"></param>
    ''    ''' <param name="PlsWait">Displays Process</param>
    ''    ''' <returns></returns>
    ''    ''' <remarks></remarks>
    ''    Private Function CopyDbFilesInThisLocationToAnother(ByVal DbFilesLocation As String, ByVal DBName As String,
    ''                                                                ByVal OtherLocation As String,
    ''                                                                ByRef PlsWait As WaitAsync) As Boolean

    ''        'If trying to copy datafiles to the default location is posing problem
    ''        'Then stop server and do it .. then start server once you are through
    ''        '
    ''        'When DB File is in use, you can not copy it or overwrite it





    ''        Try

    ''            Dim BackUpFiles() As String = FileIO.FileSystem.GetFiles(
    ''                                                                        DbFilesLocation,
    ''                                                                        FileIO.SearchOption.SearchTopLevelOnly,
    ''                                                                      String.Format(
    ''                                                                        "{0}*",
    ''                                                                        DBName
    ''                                                                        )
    ''                                                                    ).ToArray


    ''            Dim RetriedCopy As Boolean = False
    ''BeginCopy:
    ''            PlsWait.setDescription("Copying Database Files ...")
    ''            Dim iCount As Long = 0

    ''            Try
    ''                REM Display Bar Ready to Move
    ''                PlsWait.setProgressBar(BackUpFiles.Count, iCount)

    ''                ''Copy the files to the backup directory
    ''                For Each _file As String In BackUpFiles
    ''                    'Copy both the database file name and the log _log
    ''                    System.IO.File.Copy(
    ''                                    _file,
    ''                                    String.Format("{0}\{1}",
    ''                                                   OtherLocation,
    ''                                                   FileIO.FileSystem.GetName(_file)
    ''                                                   ),
    ''                                               True
    ''                                            )

    ''                    iCount += 1
    ''                    PlsWait.setProgressBar(BackUpFiles.Count, iCount)
    ''                Next
    ''            Catch ex As Exception
    ''                If Not RetriedCopy Then
    ''                    RetriedCopy = True

    ''                    stopSQLServer()

    ''                    ''If clsDatabaseRecovery.StopDefaultSQLServer(PlsWaitFrm) Then
    ''                    GoTo BeginCopy

    ''                    ''End If
    ''                End If
    ''            End Try

    ''        Catch ex As Exception
    ''            'Problem file is in use and cannot overwrite
    ''            Return False
    ''        End Try

    ''        startSQLServer()

    ''        ''clsDatabaseRecovery.StartDefaultSQLServer(PlsWaitFrm)
    ''        Return True
    ''    End Function


    ''    ''' <summary>
    ''    ''' Transfer DB Files in a Location to Another
    ''    ''' </summary>
    ''    ''' <param name="OtherLocation"></param>
    ''    ''' <returns></returns>
    ''    ''' <remarks></remarks>
    ''    Private Function CopyDbFilesInThisLocationToAnother(ByVal BackUpFiles() As String,
    ''                                                                ByVal OtherLocation As String,
    ''                                                                ByRef PlsWait As WaitAsync
    ''                                                                ) As Boolean

    ''        'If trying to copy datafiles to the default location is posing problem
    ''        'Then stop server and do it .. then start server once you are through
    ''        '
    ''        'When DB File is in use, you can not copy it or overwrite it

    ''        Try

    ''            Dim RetriedCopy As Boolean = False
    ''BeginCopy:
    ''            PlsWait.setDescription("Copying Database Files ...")
    ''            Dim iCount As Long = 0

    ''            Try
    ''                REM Display Bar Ready to Move
    ''                PlsWait.setProgressBar(BackUpFiles.Count, iCount)

    ''                ''Copy the files to the backup directory
    ''                For Each _file As String In BackUpFiles
    ''                    'Copy both the database file name and the log _log

    ''                    System.IO.File.Copy(
    ''                                    _file,
    ''                                    String.Format("{0}\{1}",
    ''                                                   OtherLocation,
    ''                                                   FileIO.FileSystem.GetName(_file)
    ''                                                   ),
    ''                                               True
    ''                                            )

    ''                    iCount += 1
    ''                    PlsWait.setProgressBar(BackUpFiles.Count, iCount)

    ''                Next
    ''            Catch ex As Exception
    ''                If Not RetriedCopy Then
    ''                    RetriedCopy = True
    ''                    stopSQLServer()
    ''                    'If clsDatabaseRecovery.StopDefaultSQLServer() Then
    ''                    GoTo BeginCopy

    ''                    'End If
    ''                End If
    ''            End Try

    ''        Catch ex As Exception
    ''            'Problem file is in use and cannot overwrite
    ''            Return False
    ''        End Try


    ''        startSQLServer()


    ''        Return True
    ''    End Function




#End Region



#End Region



#End Region


#Region "Properties"


    Public Overridable ReadOnly Property ServiceInstanceName As String
        Get
            Return "MSSQL$SQLEXPRESS"
        End Get
    End Property

    Private _______SQLInstanceName As String
    ''' <summary>
    ''' Like SQLExpress2014
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SQLInstanceName As String
        Get
            Return Me._______SQLInstanceName
        End Get
    End Property


    Private _______SQLHostName As String
    ''' <summary>
    ''' Like WIN7-HOST5-PC or IP Address
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SQLHostName As String
        Get
            Return Me._______SQLHostName
        End Get


    End Property


    Public ReadOnly Property IsLocalServer As Boolean
        Get
            Return Me._______SQLHostName.equalsIgnoreCase(My.Computer.Name)
        End Get
    End Property


    Public ReadOnly Property CanBackupAndRestore As Boolean
        Get
            Return Me.IsLocalServer
        End Get
    End Property

#End Region



End Class
