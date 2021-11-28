﻿Imports System.Data
Imports EEntityCore.DB.MSSQL.Exceptions
Imports Microsoft.Data

''' <summary>
''' Advances SQL Server Local To Network Opearations
''' </summary>
''' <remarks></remarks>
Public Class Client
    Inherits Server


    REM there are some function available in Client that shouldnt be

#Region "Properties"



    Public Overloads Function getConnectionString() As String
        Return Me.getConnectionString(Me.CurrentDBInUse)
    End Function

    ''' <summary>
    ''' get connection string
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function getConnectionString(ByVal DatabaseN As String) As String

        Return String.Format(
                  "Data Source={0},{1};Integrated Security=False;" &
                  "Initial Catalog={2};User ID={3};Password={4};",
                  Me.SQLServerAddress, Me.SQLServerPort, Me.CurrentDBInUse,
                  Me.SQLServerUserName, Me.SQLServerPassword
                  )

    End Function




#End Region

#Region "Constructors"

    ''' <summary>
    ''' Initialize Class With Necessary Parameters. It tries to connect immediately on constructor
    ''' </summary>
    ''' <param name="sAddress">IP or Name of Host PC on Network full instance name. like db.ciu.edu or 192.163.334.222\sqlexpress2014</param>
    ''' <param name="sUserName"></param>
    ''' <param name="sPassword"></param>
    ''' <remarks></remarks>
    Sub New(ByVal sAddress As String,
            ByVal sPort As Int32,
            ByVal sUserName As String,
            ByVal sPassword As String,
            ByVal sDatabase As String
            )

        MyBase.New(sDatabase)

        Me.__SQLServerAddress = sAddress
        Me.__SQLServerUserName = sUserName
        Me.__SQLServerPassword = sPassword
        Me.__SQLServerPort = sPort


    End Sub






#End Region



    ''' <summary>
    ''' Using SQL Default Path 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSQLConnection(ByVal InitialCatalog As String) As SqlClient.SqlConnection

        Dim sCon As SqlClient.SqlConnection


        Try
            ''sCon = New SqlClient.SqlConnection(
            ''    "Data Source=" & svrServer & ";Initial Catalog=" & dbName &
            ''    ";Integrated Security=True;User ID=" & strUser & ";Password=" & strPassword)


            sCon = New SqlClient.SqlConnection(Me.getConnectionString(InitialCatalog))


            sCon.Open()

            'sCon.Close()

        Catch ex As Exception
            Logger.Log(New SQLServerConnectionException("Error Connecting to MS SQL Server From Client", Me.getConnectionString(InitialCatalog), ex))
            Return Nothing
        End Try

        'sCon = Nothing
        Return sCon

    End Function



    ''' <summary>
    ''' Get my base instance
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getBase() As Server

        REM I don't know if this is going to work for this kind of instance because the base needs
        REM to refer to getConnection of this class
        Return MyBase.getClass()

    End Function

End Class
