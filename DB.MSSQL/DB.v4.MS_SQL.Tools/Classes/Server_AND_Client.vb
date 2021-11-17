REM Am Using this class to Combine the functionality of a Server Class with a TCP Client Class

''' <summary>
''' Combination of a Server and a Client Class
''' </summary>
''' <remarks></remarks>
Public Class Server_AND_Client
    Inherits ServerHelper2008



    ''' <summary>
    ''' Initialize Class With Necessary Parameters
    ''' </summary>
    ''' <param name="sAddress">IP or Name of Host PC on Network</param>
    ''' <param name="sUserName"></param>
    ''' <param name="sPassword"></param>
    ''' <remarks></remarks>
    Sub New(ByVal sAddress As String,
            ByVal sPort As String,
            ByVal sUserName As String,
            ByVal sPassword As String,
            ByVal sDatabase As String)

        MyBase.New(sDatabase)

        Me.aCopyOfClient = New Client(sAddress, CInt(sPort), sUserName, sPassword, sDatabase)


    End Sub

    ''' <summary>
    ''' Set Database to use
    ''' </summary>
    ''' <param name="useDatabase"></param>
    ''' <remarks></remarks>
    Sub New(ByVal useDatabase As String)

        MyBase.New(useDatabase)

    End Sub




    Private aCopyOfClient As Client = Nothing



    Public Enum ConnectionMode
        SERVER
        CLIENT
    End Enum


    Private __SQLConnectionMode As ConnectionMode = ConnectionMode.SERVER
    Public Property SQLConnectionMode As ConnectionMode
        Get
            Return Me.__SQLConnectionMode
        End Get
        Set(ByVal value As ConnectionMode)
            Me.__SQLConnectionMode = value
        End Set
    End Property


    ''' <summary>
    ''' Initialize Class With Necessary Parameters
    ''' </summary>
    ''' <param name="sAddress">IP or Name of Host PC on Network</param>
    ''' <param name="sUserName"></param>
    ''' <param name="sPassword"></param>
    ''' <remarks></remarks>
    Public Sub setClientProperty(ByVal sAddress As String,
            ByVal sPort As String,
            ByVal sUserName As String,
            ByVal sPassword As String,
            ByVal sDatabase As String)

        REM Dispose Initial Copy if Available
        If Me.aCopyOfClient IsNot Nothing Then Me.aCopyOfClient = Nothing

        Me.aCopyOfClient = New Client(sAddress, CInt(sPort), sUserName, sPassword, sDatabase)


    End Sub



    ''' <summary>
    ''' Using SQL Default Path 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getSQLConnection(ByVal InitialCatalog As String) As SqlClient.SqlConnection
        If Me.SQLConnectionMode = ConnectionMode.CLIENT Then
            If Me.aCopyOfClient IsNot Nothing Then Return Me.aCopyOfClient.getSQLConnection(InitialCatalog)

        Else
            Return MyBase.getSQLConnection(InitialCatalog)

        End If

        Return Nothing

    End Function


End Class
