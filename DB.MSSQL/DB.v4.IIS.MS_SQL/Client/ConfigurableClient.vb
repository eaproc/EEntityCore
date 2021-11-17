
''' <summary>
''' Allows Remote Client to manage tables and Versioning with snapshots
''' </summary>
''' <remarks></remarks>
Public Class ConfigurableClient
    Inherits Client


#Region "Properties"




#End Region




#Region "Constructors"

    ''' <summary>
    ''' Initialize Class With Necessary Parameters. It tries to connect immediately on constructor. Allows Remote Client to manage tables and Versioning with snapshots
    ''' </summary>
    ''' <param name="sAddress">IP or Name of Host PC on Network full instance name. like db.ciu.edu or 192.163.334.222\sqlexpress2014</param>
    ''' <param name="sUserName"></param>
    ''' <param name="sPassword"></param>
    ''' <param name="TargetCurrentDatabaseVersion">The version this database should be in</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sAddress As String,
            ByVal sPort As Int32,
            ByVal sUserName As String,
            ByVal sPassword As String,
            ByVal sDatabase As String,
            Optional ByVal TargetCurrentDatabaseVersion As Double = 0.0,
            Optional ByVal pSetSnaphot As Boolean = True)

        MyBase.New(sAddress, sPort, sUserName, sPassword, sDatabase)


        If Not Me.CanConnect(True) Then Throw New Exceptions.SQLServerConnectionException(Me.getConnectionString())

        If Not IsTableCreatedOnDatabase("DBInfo") Then

            If Not Me.createVersionTable_on_DB(Me.DatabaseName) Then Throw New Exception("Error Creating DBVersion Table!")

        End If


        If pSetSnaphot Then
            If Not Me.setAllowSnapshotOnDatabase(True) Then Throw New Exception("Error setting ALlow_Snapshot On")
        End If


        Dim pCurVersion = Me.FetchDBVersion()
        If pCurVersion < TargetCurrentDatabaseVersion Then
            If Not Me.UpgradeDatabase(TargetCurrentDatabaseVersion, pCurVersion) Then Throw New Exception("Error Upgrading Database")

        End If




    End Sub






#End Region




End Class
