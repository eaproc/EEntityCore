

Imports System.Data
Imports System.IO
Imports CODERiT.Logger.Standard.VB.Exceptions
Imports EEntityCore.DB.Abstracts
Imports EEntityCore.DB.Exceptions
Imports ELibrary.Standard.VB
Imports ELibrary.Standard.VB.Objects
Imports ELibrary.Standard.VB.Modules
Imports Microsoft.Data
Imports Microsoft.Data.SqlClient

''' <summary>
''' Contains Basic Operations to perform when using MS SQL Server [2008] in your project as a Server/Standlone
''' </summary>
''' <remarks>I assume this is Local. On Local Connections</remarks>
Public MustInherit Class Server
    Inherits All__DBs
    Implements IDisposable


#Region "Properties"

#Region "Private"


    REM 
    ''' <summary>
    ''' Actually When you initiate Local you dont need to pass any credential apart from the database
    ''' You wish to use
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend CurrentDBInUse As String


#End Region


#Region "Public "



    Protected Property __SQLServerAddress As String

    ''' <summary>
    ''' Server address or host name with address like WINHOST-PC\SQLEXPRESS
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable ReadOnly Property SQLServerAddress As String
        Get
            REM If Not __SQLServerAddress.ToLower().EndsWith("\sqlexpress") Then __SQLServerAddress &= "\sqlexpress"
            Return __SQLServerAddress
        End Get
    End Property

    Protected __SQLServerUserName As String = Nothing
    Public ReadOnly Property SQLServerUserName As String
        Get
            Return Me.__SQLServerUserName
        End Get
    End Property

    Protected __SQLServerPassword As String = Nothing
    Public ReadOnly Property SQLServerPassword As String
        Get
            Return Me.__SQLServerPassword
        End Get
    End Property

    ''' <summary>
    ''' SQL Server Default Port Number
    ''' </summary>
    ''' <remarks></remarks>
    Public Const DEFAULT_PORT As Int32 = 1433

    Protected __SQLServerPort As Int32 = 0
    Public ReadOnly Property SQLServerPort As Int32
        Get
            Return Me.__SQLServerPort
        End Get
    End Property

    Public ReadOnly Property DatabaseName As String
        Get
            Return Me.CurrentDBInUse
        End Get
    End Property



#End Region


#Region "Constants"


#End Region

#End Region


#Region "Constructors"



    ''' <summary>
    ''' Set Database to use
    ''' </summary>
    ''' <param name="useDatabase"></param>
    ''' <param name="pSQLServerFullAddress">Enter full instance name like pcName\SqlExpress2014</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal useDatabase As String, pSQLServerFullAddress As String)
        Me.CurrentDBInUse = useDatabase

        Me.__SQLServerAddress = pSQLServerFullAddress

    End Sub


    ''' <summary>
    ''' Set Database to use
    ''' </summary>
    ''' <param name="useDatabase">Database on MyPC\sqlexpress</param>
    ''' <remarks></remarks>
    Sub New(ByVal useDatabase As String)
        Me.New(useDatabase, "localhost\sqlexpress")
    End Sub



#End Region


#Region "Methods"

#Region "Private"



#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
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
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

    ''' <summary>
    ''' Incase your database is using 'Date', you might need to encode it to \'Date\' if you are using encoding
    ''' </summary>
    ''' <param name="__str "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Encode__Apostrophe(ByVal __str As String) As String

        Return Replace(__str, "'", "\'")

    End Function

#End Region


#Region "Public"
    'Note Parameters that changes Depending on the database you are working with
    '
    ' SQL Server Does Not Support ` sign for quoting fields
    ' Also Does Not support # for Date quoting Use ' instead
    '
    '
    '
    '

    '
    '
    ' SQL Server Does Not Support ` sign for quoting fields
    ' Also Does Not support # for Date quoting Use ' instead

#Region "has direct Relation With getConnection()"

#Region "dbExec and getRS"


    ''' <summary>
    ''' Using SQL Default Path and DB 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function getSQLConnection() As SqlClient.SqlConnection

        Return Me.getSQLConnection(Me.CurrentDBInUse)

    End Function

    ''' <summary>
    ''' Using SQL Default Path and DB 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public MustOverride Function getSQLConnection(ByVal InitialCatalog As String) As SqlClient.SqlConnection



    ''' <summary>
    ''' Execute SQL StoredProcedures ... Using Current Database
    ''' </summary>
    ''' <param name="SQLParameters"></param>
    ''' <remarks></remarks>
    Public Overloads Function dbExec(ByVal StoredProcedure As String,
                                ByVal ParamArray SQLParameters() As SqlClient.SqlParameter) As Boolean



        Dim sqlDBCon As New SqlClient.SqlConnection
        sqlDBCon = getSQLConnection()
        If basExtensions.IsNothing(sqlDBCon) Then Return False


        Try

            Dim sqlCommand As New SqlClient.SqlCommand(StoredProcedure)
            Using sqlCommand
                sqlCommand.Connection = sqlDBCon
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.CommandTimeout = 0  ' no time out here
                sqlCommand.Parameters.AddRange(SQLParameters)


                sqlCommand.ExecuteNonQuery()


                sqlDBCon.Close()
                sqlDBCon = Nothing
            End Using

        Catch ex As Exception
            ' Logger.Log(New SQLCodeException(ex))
            Throw

        Finally

            If sqlDBCon IsNot Nothing Then
                If sqlDBCon.State <> Data.ConnectionState.Closed Then sqlDBCon.Close()
                sqlDBCon = Nothing

            End If

        End Try


        Return True
    End Function

    ''' <summary>
    ''' Using current loaded database
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function DbExec(ByVal SQL As String) As Boolean
        Return Me.dbExec(SQL, Me.CurrentDBInUse)
    End Function


    ''' <summary>
    ''' Specify database to use
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function dbExec(ByVal SQL As String,
                                     ByVal UsingDatabase As String) As Boolean



        '
        '   Be careful because tracking works on the database name passed in
        '

        Dim sqlDBCon As New SqlClient.SqlConnection
        sqlDBCon = getSQLConnection(UsingDatabase)
        If basExtensions.IsNothing(sqlDBCon) Then Return False


        Try


            Dim sqlCommand As New SqlClient.SqlCommand
            Using sqlCommand
                sqlCommand.Connection = sqlDBCon
                sqlCommand.CommandType = CommandType.Text
                sqlCommand.CommandTimeout = 0  ' no time out here
                sqlCommand.CommandText = SQL

                sqlCommand.ExecuteNonQuery()



            End Using

        Catch ex As Exception

            Dim ex2 = New SQLCodeException(SQL, ex)

            ' Logger.Log(New SQLCodeException(SQL, ex))

            Throw ex2

        Finally

            If sqlDBCon IsNot Nothing Then
                If sqlDBCon.State <> Data.ConnectionState.Closed Then sqlDBCon.Close()
                sqlDBCon = Nothing

            End If

        End Try

        Return True
    End Function


    ''' <summary>
    ''' Get RS using Specific DB. Throws Exception.
    ''' Returns DataSet or throws Exception
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    ''' <exception cref="Exception"></exception>
    ''' <remarks></remarks>
    Public Overrides Function GetRS(ByVal SQL As String) As System.Data.DataSet
        Return Me.GetRS(SQL, Me.CurrentDBInUse)
    End Function


    ''' <summary>
    ''' Get RS using Specific DB. Throws Exception.
    ''' Returns DataSet or throws Exception
    ''' </summary>
    ''' <param name="SQL"></param>
    ''' <returns></returns>
    ''' <exception cref="Exception"></exception>
    ''' <remarks></remarks>
    Public Overloads Function GetRS(ByVal SQL As String,
                                     ByVal UsingDatabase As String) As System.Data.DataSet

        '
        '   Be careful because tracking works on the database name passed in
        '

        Dim srs As New DataSet()

        Dim sqlDBCon As New SqlClient.SqlConnection
        sqlDBCon = getSQLConnection(UsingDatabase)
        If basExtensions.IsNothing(sqlDBCon) Then Return Nothing


        Try


            Dim sqlCommand As New SqlClient.SqlCommand
            Using sqlCommand
                sqlCommand.Connection = sqlDBCon
                sqlCommand.CommandType = CommandType.Text
                sqlCommand.CommandTimeout = 0  ' no time out here

                sqlCommand.CommandText = SQL

                Dim da As New SqlClient.SqlDataAdapter(sqlCommand)

                da.Fill(srs)

                da.Dispose()
                da = Nothing

            End Using

        Catch ex As Exception
            Throw New SQLCodeException(SQL, ex)
        Finally

            If sqlDBCon IsNot Nothing Then
                If sqlDBCon.State <> Data.ConnectionState.Closed Then sqlDBCon.Close()
                sqlDBCon = Nothing

            End If

        End Try

        Return srs

    End Function


    ''' <summary>
    ''' Get RS using default DB and Stored Procedures
    ''' </summary>
    ''' <param name="StoredProcedure "></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function GetRS(ByVal StoredProcedure As String,
                                ByVal ParamArray SQLParameters() As SqlClient.SqlParameter) As System.Data.DataSet



        Dim srs As New DataSet()

        Dim sqlDBCon As New SqlClient.SqlConnection
        sqlDBCon = getSQLConnection()
        If basExtensions.IsNothing(sqlDBCon) Then Return Nothing

        Try


            Dim sqlCommand As New SqlClient.SqlCommand
            Using sqlCommand
                With sqlCommand
                    .Connection = sqlDBCon
                    .CommandType = CommandType.StoredProcedure

                    .CommandText = StoredProcedure
                    .Parameters.AddRange(SQLParameters)

                    Dim da As New SqlClient.SqlDataAdapter(sqlCommand)

                    da.Fill(srs)

                    da.Dispose()
                    da = Nothing

                End With
            End Using

        Catch ex As Exception
            Logger.Log(New SQLCodeException(ex))
            Return Nothing


        Finally

            If sqlDBCon IsNot Nothing Then
                If sqlDBCon.State <> Data.ConnectionState.Closed Then sqlDBCon.Close()
                sqlDBCon = Nothing

            End If

        End Try

        Return srs

    End Function


#End Region

#Region "Testing Connection"

    ''' <summary>
    ''' Test if DB is Ok. Always use master db
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Function PingDB() As Boolean

        Return IsDataSetValid(
            GetRS("SELECT * FROM sys.server_principals")
            )

    End Function

    ''' <summary>
    ''' Indicate if Connection will be successful using the current parameters
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function CanConnect() As Boolean
        Return CanConnect(True)

    End Function


    ''' <summary>
    ''' Indicate if Connection will be successful using the current parameters.
    ''' Silent Run
    ''' </summary>
    ''' <param name="Silent">dummy input</param>
    ''' <remarks></remarks>
    Public Overloads Function CanConnect(ByVal Silent As Boolean) As Boolean


        Dim aCon As SqlConnection = Me.getSQLConnection()

        Try
            If Not basExtensions.IsNothing(aCon) Then Return True

        Catch ex As Exception
            Logger.Log(New EException("Exception Under CanConnect (SQL Server)", ex))
        Finally

            If Not basExtensions.IsNothing(aCon) Then

                aCon.Close() : aCon = Nothing

            End If

        End Try

        Return False

    End Function

#End Region


#Region "Saving Binaries to Database"

#Region "Saving Image to Database"

    ''' <summary>
    ''' Save Image On a Table Using a Unique ID
    ''' </summary>
    ''' <param name="TableName"></param>
    ''' <param name="ImageColumnName"></param>
    ''' <param name="ColumnIDName"></param>
    ''' <param name="ColumnID"></param>
    ''' <param name="ImageToSave"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function SaveThisImageOnTable(ByVal TableName As String,
                                         ByVal ImageColumnName As String,
                                          ByVal ColumnIDName As String,
                                         ByVal ColumnID As Long,
                                         Optional ByVal ImageToSave As Byte() = Nothing) As Boolean

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim sql As String = String.Format(
                                        "UPDATE {0} SET {1} = @photo  WHERE {2}={3} ",
                                            TableName, ImageColumnName, ColumnIDName, ColumnID
                                        )

            'When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
            'to automatically set null
            Dim sqlNull As String = String.Format(
                                        "UPDATE {0} SET {1} =NULL  WHERE {2}={3} ",
                                            TableName, ImageColumnName, ColumnIDName, ColumnID
                                        )



            If ImageToSave IsNot Nothing Then
                Dim data As Byte() = Nothing
                Dim cmd As New SqlClient.SqlCommand(sql, Con)
                data = ImageToSave
                Dim p As New SqlClient.SqlParameter("@photo", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()

            Else

                Return DbExec(sqlNull)

            End If

        Catch ex As Exception
            Return False
        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try



        Return True
    End Function


    ''' <summary>
    ''' Fectch Image Value From Database
    ''' </summary>
    ''' <param name="TableName">The Table name we want to extract from</param>
    ''' <param name="ImageColumnName">Image Column Name</param>
    ''' <param name="ColumnIDName">A unique ID column Name [Must Contain Numeric]</param>
    ''' <param name="ColumnID">Unique Column ID Value</param>
    ''' <returns>Image or Nothing</returns>
    ''' <remarks></remarks>
    Public Function FetchImageFromTable(ByVal TableName As String,
                                         ByVal ImageColumnName As String,
                                         ByVal ColumnIDName As String,
                                         ByVal ColumnID As Long) As Byte()


        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return Nothing

        Try
            Dim sql As String = String.Format(
                                          "SELECT {1} FROM {0} WHERE {2}={3} ",
                                              TableName, ImageColumnName, ColumnIDName, ColumnID
                                          )
            Dim cmd As New SqlClient.SqlCommand(sql, Con)

            Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())

            If Not imageData Is Nothing Then
                Using ms As New IO.MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    Return ms.GetBuffer()
                End Using

            End If
        Catch ex As Exception

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try

        Return Nothing
    End Function

#End Region


#Region "Saving Other Files to Database"

    ''' <summary>
    ''' Save VarBinary On a Table Using a Unique ID [long]
    ''' </summary>
    ''' <param name="TableName">The table where to insert the file</param>
    ''' <param name="FileColumnName">The Column on Table for the file</param>
    ''' <param name="ColumnIDValue">The primary key id value</param>
    ''' <returns>boolean on success</returns>
    ''' <remarks></remarks>
    Public Function SaveVarBinaryOnTable(ByVal TableName As String,
                                         ByVal FileColumnName As String,
                                         ByVal ColumnIDValue As Long,
                                         Optional ByVal pContents As Byte() = Nothing) As Boolean

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim sql As String = String.Format(
                                        "UPDATE {0} SET {1} = @sfile  WHERE ID={2} ",
                                            TableName, FileColumnName, ColumnIDValue
                                        )

            'When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
            'to automatically set null
            Dim sqlNull As String = String.Format(
                                        "UPDATE {0} SET {1} =NULL  WHERE ID={2} ",
                                            TableName, FileColumnName, ColumnIDValue
                                        )


            If pContents IsNot Nothing Then

                Dim data As Byte() = pContents
                Dim cmd As New SqlClient.SqlCommand(sql, Con)

                Dim p As New SqlClient.SqlParameter("@sfile", SqlDbType.VarBinary)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()

            Else

SaveAsNull:
                Return DbExec(sqlNull)

            End If

        Catch ex As Exception
            Return False
        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try



        Return True
    End Function


    ''' <summary>
    ''' Save File On a Table Using a Unique ID [long]
    ''' </summary>
    ''' <param name="TableName">The table where to insert the file</param>
    ''' <param name="FileColumnName">The Column on Table for the file</param>
    ''' <param name="ColumnIDName">The primary key name</param>
    ''' <param name="ColumnIDValue">The primary key id value</param>
    ''' <param name="FilePath">The path of the file to save to database</param>
    ''' <returns>boolean on success</returns>
    ''' <remarks></remarks>
    Public Function SaveThisFileOnTable(ByVal TableName As String,
                                         ByVal FileColumnName As String,
                                         ByVal ColumnIDValue As Long,
                                         Optional ByVal ColumnIDName As String = "ID",
                                         Optional ByVal FilePath As String = Nothing) As Boolean

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim sql As String = String.Format(
                                        "UPDATE {0} SET {1} = @sfile  WHERE {2}={3} ",
                                            TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                        )

            'When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
            'to automatically set null
            Dim sqlNull As String = String.Format(
                                        "UPDATE {0} SET {1} =NULL  WHERE {2}={3} ",
                                            TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                        )



            If FilePath IsNot Nothing Then

                If Not File.Exists(FilePath) Then GoTo SaveAsNull

                Dim data As Byte() = Nothing
                Dim cmd As New SqlClient.SqlCommand(sql, Con)

                data = File.ReadAllBytes(FilePath)
                Dim p As New SqlClient.SqlParameter("@sfile", SqlDbType.VarBinary)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()

            Else

SaveAsNull:
                Return DbExec(sqlNull)

            End If

        Catch ex As Exception
            Return False
        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try



        Return True
    End Function

    ''' <summary>
    ''' Save File On a Table Using a Unique ID [long]
    ''' </summary>
    ''' <param name="TableName">The table where to insert the file</param>
    ''' <param name="FileColumnName">The Column on Table for the file</param>
    ''' <param name="ColumnIDName">The unique key name</param>
    ''' <param name="ColumnIDValue">The primary key id value</param>
    ''' <param name="FilePath">The path of the file to save to database</param>
    ''' <returns>boolean on success</returns>
    ''' <remarks></remarks>
    Public Function SaveThisFileOnTable(ByVal TableName As String,
                                         ByVal FileColumnName As String,
                                         ByVal ColumnIDValue As String,
                                         Optional ByVal ColumnIDName As String = "ID",
                                         Optional ByVal FilePath As String = Nothing) As Boolean

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim sql As String = String.Format(
                                        "UPDATE {0} SET {1} = @sfile  WHERE {2}='{3}' ",
                                            TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                        )

            'When it nothing you have to set NULL yourself using string .. it doesn't work on parameters 
            'to automatically set null
            Dim sqlNull As String = String.Format(
                                        "UPDATE {0} SET {1} =NULL  WHERE {2}='{3}' ",
                                            TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                        )



            If FilePath IsNot Nothing Then

                If Not File.Exists(FilePath) Then GoTo SaveAsNull

                Dim data As Byte() = Nothing
                Dim cmd As New SqlClient.SqlCommand(sql, Con)

                data = File.ReadAllBytes(FilePath)
                Dim p As New SqlClient.SqlParameter("@sfile", SqlDbType.VarBinary)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.ExecuteNonQuery()

            Else

SaveAsNull:
                Return DbExec(sqlNull)

            End If

        Catch ex As Exception
            Return False
        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try



        Return True
    End Function


    ''' <summary>
    ''' Fectch Image Value From Database
    ''' </summary>
    ''' <param name="TableName">The Table name we want to extract from</param>
    ''' <param name="FileColumnName">Image Column Name</param>
    ''' <param name="ColumnIDName">A unique ID column Name [Must Contain Numeric]</param>
    ''' <param name="ColumnIDValue">Unique Column ID Value</param>
    ''' <returns>Image or Nothing</returns>
    ''' <remarks></remarks>
    Private Function FetchFileFromTable(ByVal TableName As String,
                                         ByVal FileColumnName As String,
                                         ByVal ColumnIDValue As Long,
                                         Optional ByVal ColumnIDName As String = "ID") As Byte()

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return Nothing


        Try
            Dim sql As String = String.Format(
                                          "SELECT {1} FROM {0} WHERE {2}={3} ",
                                              TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                          )
            Dim cmd As New SqlClient.SqlCommand(sql, Con)

            Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())

            Return imageData

            ''If Not imageData Is Nothing Then
            ''    Using ms As New IO.MemoryStream(imageData, 0, imageData.Length)
            ''        ms.Write(imageData, 0, imageData.Length)
            ''        Return Image.FromStream(ms, True)
            ''    End Using

            ''End If
        Catch ex As Exception

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try

        Return Nothing
    End Function


    ''' <summary>
    ''' Fectch File Data Value From Database
    ''' </summary>
    ''' <param name="TableName">The Table name we want to extract from</param>
    ''' <param name="FileColumnName">Image Column Name</param>
    ''' <param name="ColumnIDName">A unique ID column Name [Must Contain String]</param>
    ''' <param name="ColumnIDValue">Unique Column ID Value</param>
    ''' <returns>File or Nothing</returns>
    ''' <remarks></remarks>
    Private Function FetchFileFromTable(ByVal TableName As String,
                                         ByVal FileColumnName As String,
                                         ByVal ColumnIDValue As String,
                                         Optional ByVal ColumnIDName As String = "ID") As Byte()

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return Nothing


        Try
            Dim sql As String = String.Format(
                                          "SELECT {1} FROM {0} WHERE {2}='{3}' ",
                                              TableName, FileColumnName, ColumnIDName, ColumnIDValue
                                          )
            Dim cmd As New SqlClient.SqlCommand(sql, Con)

            Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())

            Return imageData

        Catch ex As Exception

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try

        Return Nothing
    End Function



    ''' <summary>
    ''' Fetch file from database and returns filepath [Make sure you invoke with administrative rights to write to disk]
    ''' </summary>
    ''' <param name="TableName">The Table Name Containing the File</param>
    ''' <param name="FileColumnName">The Column Name Containing the File bytes</param>
    ''' <param name="ColumnIDName">A unique column on the table</param>
    ''' <param name="ColumnIDValue">The unique column value</param>
    ''' <param name="FolderPath" >The destination directory to store the extracted file</param>
    ''' <param name="suggestedFileName" >The suggested file name</param>
    ''' <param name="Overwrite" >Overwrite File if it already exist in the directory</param>
    ''' <returns>It returns the name of the file written if succeeded</returns>
    ''' <remarks></remarks>
    Public Function FetchFileFromTable(ByVal TableName As String,
                                        ByVal FileColumnName As String,
                                        ByVal ColumnIDName As String,
                                        ByVal ColumnIDValue As Long,
                                        ByVal FolderPath As String,
                                        Optional ByVal suggestedFileName As String = "File.dat",
                                        Optional ByVal Overwrite As Boolean = True) As String

        Throw New NotImplementedException()
        'If Not Directory.Exists(FolderPath) Then Return vbNullString

        'Dim __byte() As Byte = Me.FetchFileFromTable(TableName, FileColumnName, ColumnIDValue, ColumnIDName)


        'If __byte IsNot Nothing Then
        '    Dim originalFileName As String = String.Format("{0}\{1}", FolderPath, suggestedFileName)
        '    If Overwrite Then
        '        If File.Exists(originalFileName) Then File.Delete(originalFileName)
        '    Else
        '        REM Fetch Available File name
        '        originalFileName = EIO.getAvailableFileName(FolderPath, suggestedFileName)
        '    End If

        '    File.WriteAllBytes(originalFileName, __byte)
        '    Return originalFileName
        'Else
        '    Return vbNullString
        'End If

    End Function

    ''' <summary>
    ''' Fetch file from database and returns filepath [Make sure you invoke with administrative rights to write to disk]
    ''' </summary>
    ''' <param name="TableName">The Table Name Containing the File</param>
    ''' <param name="FileColumnName">The Column Name Containing the File bytes</param>
    ''' <param name="ColumnIDName">A unique column on the table</param>
    ''' <param name="ColumnIDValue">The unique column value</param>
    ''' <param name="FolderPath" >The destination directory to store the extracted file</param>
    ''' <param name="suggestedFileName" >The suggested file name</param>
    ''' <param name="Overwrite" >Overwrite File if it already exist in the directory</param>
    ''' <returns>It returns the name of the file written if succeeded</returns>
    ''' <remarks></remarks>
    Public Function FetchFileFromTable(ByVal TableName As String,
                                        ByVal FileColumnName As String,
                                        ByVal ColumnIDName As String,
                                        ByVal ColumnIDValue As String,
                                        ByVal FolderPath As String,
                                        Optional ByVal suggestedFileName As String = "File.dat",
                                        Optional ByVal Overwrite As Boolean = True) As String
        Throw New NotImplementedException()

        'If Not Directory.Exists(FolderPath) Then Return vbNullString

        'Dim __byte() As Byte = Me.FetchFileFromTable(TableName, FileColumnName, ColumnIDValue, ColumnIDName)


        'If __byte IsNot Nothing Then
        '    Dim originalFileName As String = String.Format("{0}\{1}", FolderPath, suggestedFileName)
        '    If Overwrite Then
        '        If File.Exists(originalFileName) Then File.Delete(originalFileName)
        '    Else
        '        REM Fetch Available File name
        '        originalFileName = EIO.getAvailableFileName(FolderPath, suggestedFileName)
        '    End If

        '    File.WriteAllBytes(originalFileName, __byte)
        '    Return originalFileName
        'Else
        '    Return vbNullString
        'End If

    End Function


#End Region





#End Region

#Region "Filling Datasets and DataTables"

    ''' <summary>
    ''' Fill All Data For Tables in this Hard-Coded dataset
    ''' </summary>
    ''' <param name="MyDataSet"></param>
    ''' <remarks></remarks>
    Public Overrides Function FillMyTables(ByRef MyDataSet As DataSet) As Boolean


        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim da As SqlClient.SqlDataAdapter

            For Each OneTable As DataTable In MyDataSet.Tables

                'Clear previous info to avoid cache
                OneTable.Clear()

                da =
                    New SqlClient.SqlDataAdapter("Select * From " & OneTable.TableName,
                                               Con)

                da.Fill(
                    MyDataSet.Tables(OneTable.TableName)
                    )

                'Application.DoEvents()

            Next

            Return True
        Catch ex As Exception
            REM Report Error

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If


        End Try

        Return False

    End Function

    ''' <summary>
    ''' Fill All Data For Table
    ''' </summary>
    ''' <param name="OneTable"></param>
    ''' <remarks></remarks>
    Public Overrides Function FillMyTable(ByRef OneTable As DataTable) As Boolean


        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False

        Try
            Dim da As SqlClient.SqlDataAdapter


            'Clear previous info to avoid cache
            OneTable.Clear()

            da =
                New SqlClient.SqlDataAdapter("Select * From " & OneTable.TableName,
                                           Con)

            da.Fill(
                OneTable
                )
            'Application.DoEvents()

            Return True

        Catch ex As Exception



        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try

        Return False

    End Function


    ''' <summary>
    ''' Fill All Data For Table
    ''' </summary>
    ''' <param name="OneTable"></param>
    ''' <param name="SQLWHERECondition__Or__FullSQL_Statement" >You can pass in a full sql state or only where condition</param>
    ''' <remarks></remarks>
    Public Overloads Function FillMyTable(ByRef OneTable As DataTable,
                                          ByVal SQLWHERECondition__Or__FullSQL_Statement As String) As Boolean

        REM No Spaces
        If SQLWHERECondition__Or__FullSQL_Statement IsNot Nothing Then _
            SQLWHERECondition__Or__FullSQL_Statement = SQLWHERECondition__Or__FullSQL_Statement.Trim

        REM Decide which one we are going for here
        Dim SQL_Statement = String.Format("Select * From {0} {1}",
                                          OneTable.TableName,
                                          SQLWHERECondition__Or__FullSQL_Statement)

        REM IF it is full sql then override
        If SQLWHERECondition__Or__FullSQL_Statement <> vbNullString Then
            If SQLWHERECondition__Or__FullSQL_Statement.IndexOf("SELECT") = 0 Then

                SQL_Statement = SQLWHERECondition__Or__FullSQL_Statement

            End If
        End If


        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False


        Try
            Dim da As SqlClient.SqlDataAdapter

            'Clear previous info to avoid cache
            OneTable.Clear()

            da =
                New SqlClient.SqlDataAdapter(SQL_Statement,
                                           Con)

            da.Fill(
                OneTable
                )
            'Application.DoEvents()

            Return True

        Catch ex As Exception

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try


        Return False

    End Function


    ''' <summary>
    ''' Fill All Data For Table
    ''' </summary>
    ''' <param name="OneTable"></param>
    ''' <param name="SQL " >SQL For Table</param>
    ''' <remarks></remarks>
    Public Overrides Function FillMyTable(ByVal SQL As String, ByRef OneTable As System.Data.DataTable) As Boolean

        Dim Con As SqlClient.SqlConnection = Me.getSQLConnection()
        If Con Is Nothing Then Return False


        Try
            Dim da As SqlClient.SqlDataAdapter

            'Clear previous info to avoid cache
            OneTable.Clear()

            da =
                New SqlClient.SqlDataAdapter(SQL,
                                           Con)

            da.Fill(
                OneTable
                )
            'Application.DoEvents()

            Return True

        Catch ex As Exception

        Finally

            If Con IsNot Nothing Then
                If Con.State <> Data.ConnectionState.Closed Then Con.Close()
                Con = Nothing

            End If

        End Try


        Return False

    End Function


    ''' <summary>
    ''' Fill All Data For Table With Provided StoredProcedure
    ''' </summary>
    ''' <param name="OneTable"></param>
    ''' <remarks></remarks>
    Public Overloads Function FillMyTable(ByRef OneTable As DataTable,
                                          ByVal StoredProcedure As String,
                                ByVal ParamArray SQLParameters() As SqlClient.SqlParameter) As Boolean

        Dim sqlDBCon As New SqlClient.SqlConnection
        sqlDBCon = getSQLConnection()
        If basExtensions.IsNothing(sqlDBCon) Then Return Nothing


        Try

            Dim sqlCommand As New SqlClient.SqlCommand
            Using sqlCommand
                With sqlCommand
                    .Connection = sqlDBCon
                    .CommandType = CommandType.StoredProcedure

                    .CommandText = StoredProcedure
                    .Parameters.AddRange(SQLParameters)

                    Dim da As New SqlClient.SqlDataAdapter(sqlCommand)


                    'Clear previous info to avoid cache
                    OneTable.Clear()

                    da.Fill(
                        OneTable
                        )
                    'Application.DoEvents()

                    da.Dispose()
                    da = Nothing
                    sqlDBCon.Close()
                    sqlDBCon = Nothing
                End With
            End Using

            Return True

        Catch ex As Exception
        Finally

            If sqlDBCon IsNot Nothing Then
                If sqlDBCon.State <> Data.ConnectionState.Closed Then sqlDBCon.Close()
                sqlDBCon = Nothing

            End If

        End Try

        Return False

    End Function

#End Region


#End Region



#Region "Executing SQL File"



    ''' <summary>
    ''' Executes an SQL File containing SQL Statements. Uses System.Text.Encoding.Default - WINDOWS ANSII
    ''' </summary>
    ''' <param name="pSQLFileName">SQL File containing SQL Statements</param>
    ''' <param name="pTerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ExecuteSQLFile(ByVal pSQLFileName As String,
                                    ByVal pTerminateOnError As Boolean,
                                   ByVal pIsScriptEncrypted As Boolean,
                                     pEncoding As System.Text.Encoding
                                   ) As Boolean
        Return Me.ExecuteSQLFile(pSQLFileName, pEncoding, pTerminateOnError, "GO;", pIsScriptEncrypted)
    End Function



    ''' <summary>
    ''' Executes an SQL File containing SQL Statements. Uses System.Text.Encoding.Default - WINDOWS ANSII
    ''' </summary>
    ''' <param name="pSQLFileName">SQL File containing SQL Statements</param>
    ''' <param name="pTerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
    ''' <param name="pStatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ExecuteSQLFile(ByVal pSQLFileName As String,
                                    ByVal pTerminateOnError As Boolean,
                                   ByVal pStatementDelimiter As String,
                                   ByVal pIsScriptEncrypted As Boolean,
                                     pEncoding As System.Text.Encoding
                                   ) As Boolean
        Return Me.ExecuteSQLFile(pSQLFileName, pEncoding, pTerminateOnError, pStatementDelimiter, pIsScriptEncrypted)
    End Function



    ''' <summary>
    ''' Executes an SQL File containing SQL Statements. Uses System.Text.Encoding.Default - WINDOWS ANSII
    ''' </summary>
    ''' <param name="SQLFileName">SQL File containing SQL Statements</param>
    ''' <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
    ''' <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ExecuteSQLFile(ByVal SQLFileName As String,
                                   Optional ByVal TerminateOnError As Boolean = False,
                                   Optional ByVal StatementDelimiter As String = "GO;") As Boolean
        Return Me.ExecuteSQLFile(SQLFileName, System.Text.Encoding.Default, TerminateOnError, StatementDelimiter, False)
    End Function


    ''' <summary>
    ''' Executes an SQL File containing SQL Statements
    ''' </summary>
    ''' <param name="SQLFileName">SQL File containing SQL Statements</param>
    ''' <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
    ''' <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function ExecuteSQLFile(ByVal SQLFileName As String,
                                             pEncoding As System.Text.Encoding,
                                   ByVal TerminateOnError As Boolean,
                                   ByVal StatementDelimiter As String,
                                    ByVal pIsScriptEncrypted As Boolean
                                   ) As Boolean


        Try


            If FileIO.FileSystem.FileExists(SQLFileName) Then
                Dim pScriptContext = FileIO.FileSystem.ReadAllText(SQLFileName, encoding:=pEncoding)

                '   
                ' Decode
                '
                If pIsScriptEncrypted Then pScriptContext = pEncoding.GetString(Convert.FromBase64String(pScriptContext))



                '
                ' Split the content
                Dim SQLs As String() = Split(pScriptContext, StatementDelimiter)




                Dim rValue As Boolean = False

                Dim iCount As ULong = 0

                For Each SQLCommand As String In SQLs

                    SQLCommand = SQLCommand.Trim()
                    If SQLCommand <> "" Then
                        If Not DbExec(SQLCommand) And TerminateOnError Then
                            rValue = False
                            GoTo CleanUP
                        End If

                    End If
                    iCount = CULng(iCount + 1)
                Next
                REM If No Error
                rValue = True

CleanUP:

                Return rValue

            End If




        Catch ex As Exception
            Logger.Print(ex)
        End Try



        REM If invalid file
        Return False

    End Function



#End Region





    ''' <summary>
    ''' Package the DateTime Output in the correct saving Order.
    ''' Pack a formatted SQL Server save date into quoted string '{_dateValue}'
    ''' </summary>
    ''' <param name="_DateTime"></param>
    ''' <returns></returns>
    ''' <remarks>NB: If date should be empty it should be set to Null</remarks>
    Public Function PackageDateTimeForSavingOnSQL2008(ByVal _DateTime As String) As String
        If _DateTime Is Nothing Then Return "Null"
        If _DateTime.Equals("") Then Return "Null"

        Return String.Format(
                            "'{0}'", _DateTime
                            )
    End Function

#Region "Saving Date and Time in SQL Server 2008"


    Public Overrides Function GetSQLDateTimeFormat(ByVal _DateTime As Types.NullableDateTime) As String

        Return Me.GetSQLDateTimeFormat(_DateTime, False)

    End Function

    Public Overloads Function GetSQLDateTimeFormat(ByVal _DateTime As Types.NullableDateTime,
                                                   ByVal EncodeApostrophe As Boolean) As String

        If _DateTime Is Nothing OrElse _DateTime.isNull Then Return PackageDateTimeForSavingOnSQL2008(vbNullString)


        If EncodeApostrophe Then
            Return Me.Encode__Apostrophe(
                PackageDateTimeForSavingOnSQL2008(
                EDateTime.valueOf(_DateTime, EDateTime.SpecialDateTimeFormats.STYLE2)
                    )
                )
        Else
            Return PackageDateTimeForSavingOnSQL2008(
                 EDateTime.valueOf(_DateTime, EDateTime.SpecialDateTimeFormats.STYLE2)
                    )

        End If
    End Function

    Public Overloads Function GetSQLDateFormat(ByVal _Date As Types.NullableDateTime,
                                                            ByVal EncodeApostrophe As Boolean) As String

        If _Date Is Nothing OrElse _Date.isNull Then Return PackageDateTimeForSavingOnSQL2008(vbNullString)


        If EncodeApostrophe Then
            Return Me.Encode__Apostrophe(
                PackageDateTimeForSavingOnSQL2008(
                               EDateTime.valueOf(_Date, EDateTime.SpecialDateTimeFormats.STYLE1)
                    )
                )
        Else
            Return PackageDateTimeForSavingOnSQL2008(
                EDateTime.valueOf(_Date, EDateTime.SpecialDateTimeFormats.STYLE1)
                    )

        End If

    End Function

    Public Overrides Function GetSQLDateFormat(ByVal _Date As Types.NullableDateTime) As String

        Return Me.GetSQLDateFormat(_Date, False)

    End Function

    Public Overloads Function GetSQLTimeFormat(ByVal _Time As Types.NullableDateTime,
                                                            ByVal EncodeApostrophe As Boolean) As String

        If _Time Is Nothing OrElse _Time.isNull Then Return PackageDateTimeForSavingOnSQL2008(vbNullString)


        If EncodeApostrophe Then
            Return Me.Encode__Apostrophe(
                PackageDateTimeForSavingOnSQL2008(
                EDateTime.valueOf(_Time, EDateTime.TimeFormatUsedWithoutSeconds)
                    )
                )
        Else
            Return PackageDateTimeForSavingOnSQL2008(
                EDateTime.valueOf(_Time, EDateTime.TimeFormatUsedWithoutSeconds)
                    )

        End If

    End Function

    Public Overrides Function GetSQLTimeFormat(ByVal _Time As Types.NullableDateTime) As String
        Return Me.GetSQLTimeFormat(_Time, False)
    End Function


#End Region





    ''' <summary>
    ''' Check If Table is Created on Current Database in Use. ISOLATION LEVEL: READ_COMMITTED
    ''' </summary>
    ''' <param name="pTableName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsTableCreatedOnDatabase(ByVal pTableName As String, pDatabase As String) As Boolean
        Return IsDataSetValid(GetRS(String.Format("Select * from sys.tables c WHERE c.name='{0}'", pTableName), pDatabase))
    End Function


    ''' <summary>
    ''' Check If Table is Created on Current Database in Use. ISOLATION LEVEL: READ_COMMITTED
    ''' </summary>
    ''' <param name="pTableName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsTableCreatedOnDatabase(ByVal pTableName As String) As Boolean
        Return IsTableCreatedOnDatabase(pTableName, Me.DatabaseName)
    End Function







    ''' <summary>
    ''' Check If Allow_Snapshot is set to ON on the indicated database name. It using current connect to perform the query
    ''' </summary>
    ''' <param name="pDatabase"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsSnapshotSetOnDatabase(ByVal pDatabase As String) As Boolean
        Dim p = GetRS(
                              String.Format("SELECT snapshot_isolation_state FROM sys.databases WHERE [name]='{0}'",
                                                  pDatabase)
                                              )
        If IsDataSetValid(p) Then
            Return EBoolean.valueOf(p.Tables(0)(0)(0))
        End If
        Return False
    End Function


    ''' <summary>
    ''' Check If Allow_Snapshot is set to ON on the this current database name.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsSnapshotSetOnDatabase() As Boolean
        Return IsSnapshotSetOnDatabase(Me.DatabaseName)
    End Function



    Public Function setAllowSnapshotOnDatabase(pSetOn As Boolean, pDatabaseName As String) As Boolean
        If pSetOn Then Return DbExec(String.Format("ALTER DATABASE {0} SET ALLOW_SNAPSHOT_ISOLATION ON", pDatabaseName))
        Return DbExec(String.Format("ALTER DATABASE {0} SET ALLOW_SNAPSHOT_ISOLATION OFF", pDatabaseName))
    End Function

    Public Function setAllowSnapshotOnDatabase(pSetOn As Boolean) As Boolean
        Return setAllowSnapshotOnDatabase(pSetOn, pDatabaseName:=Me.DatabaseName)
    End Function

#End Region

#Region "Protected"




#Region "DB Versioning"

    ''' <summary>
    ''' Get the default database dbversion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FetchDBVersion() As Double

        Try
            'Dont Remove This debugging .. it solve the On/Off issue of fectching DBVersion
            'For Debugging
            Logger.Log(
                    String.Format(
                        "Connection to Database: {0} ",
                                getSQLConnection().State
                        )
                    )
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Dim DBVersion As DataSet = GetRS("SELECT Version From DBInfo")
            Logger.Log(
                    String.Format(
                        "DBInfo Table Located: {0}",
                            IsDataSetValid(DBVersion)
                        )
                    )

            If IsDataSetValid(DBVersion) Then
                Return DBVersion.Tables(0).Rows(0)("Version").ToString().toDouble()
            End If
        Catch ex As Exception
            Logger.Log(New EException("Error fetching DB Version", ex))
        End Try


        Return 0
    End Function


    ''' <summary>
    ''' Update the DB Version to the upgraded 
    ''' </summary>
    ''' <param name="_Version"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function UpdateDBVersion(ByVal _Version As Double) As Boolean

        Try
            Return DbExec(
                String.Format(
                        "UPDATE DBInfo SET Version={0} WHERE ID=1 ",
                        _Version)
                    )

        Catch ex As Exception

        End Try


        Return False
    End Function


    ''' <summary>
    ''' Inserts the DBInfo Table on Database
    ''' </summary>
    ''' <param name="DatabaseName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function createVersionTable_on_DB(ByVal DatabaseName As String) As Boolean

        REM Structure Format
        REM Database

        ''CREATE TABLE [dbo].[DBInfo](
        ''	[Version] [decimal](19, 2) NOT NULL,
        ''	[ID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL
        '') ON [PRIMARY]

        ''GO



        If Not dbExec(
"CREATE TABLE [dbo].[DBInfo] ( " &
  "[Version] decimal(19, 2) DEFAULT 0 NOT NULL, " &
  "[ID] int IDENTITY(1, 1) NOT FOR REPLICATION NOT NULL " &
") " &
"ON [PRIMARY]", DatabaseName
) Then Return False REM I expect by now this table shouldnt be on db

        Return dbExec(
       String.Format(
           "INSERT INTO DBInfo (Version ) " &
        "VALUES({0})", 0
        ), DatabaseName
       )


    End Function






    ''' <summary>
    ''' Upgrade the database file to the suggested version. uses folder "{AppPath}\DBUpgrades\SQL_Upgrade_{No}.sql"
    ''' </summary>
    ''' <param name="pDBTarget_Version ">The Current DB Version you want it to be</param>
    ''' <param name="pCurrent_Loaded_DB_Version">The Version of the BackedUp DB to be upgraded to current</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UpgradeDatabase(ByVal pDBTarget_Version As Double,
                                           ByVal pCurrent_Loaded_DB_Version As Double) As Boolean
        Return Me.UpgradeDatabase(pDBTarget_Version, pCurrent_Loaded_DB_Version,
                                  False
                                  )
    End Function


    ''' <summary>
    ''' Upgrade the database file to the suggested version. uses folder "{AppPath}\DBUpgrades\SQL_Upgrade_{No}.sql"
    ''' </summary>
    ''' <param name="pDBTarget_Version ">The Current DB Version you want it to be</param>
    ''' <param name="Current_Loaded_DB_Version">The Version of the BackedUp DB to be upgraded to current</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UpgradeDatabase(ByVal pDBTarget_Version As Double,
                                           ByVal Current_Loaded_DB_Version As Double,
                                           ByVal pIsScriptEncrypted As Boolean
                                           ) As Boolean

        'Lets Say Target is 1
        'and current version is 2
        'Set Increament rate to 1 to the last part, so we have 10 iterations ahead

        'Do while current Version is  < Target Version
        '   Increment Version
        '   Execute SQL_Upgrade_11
        '
        'Loo

        'Check if the version we are about to restore is lower than the expected version
        'If yes ... Upgrade Else Continue


        Dim vEncoding As System.Text.Encoding = System.Text.Encoding.Default
        If pIsScriptEncrypted Then vEncoding = System.Text.Encoding.UTF8





        Logger.Log(
            String.Format(
                "Upgrading database from version {0} to {1}",
                 Current_Loaded_DB_Version, pDBTarget_Version
                )
            )
        If Current_Loaded_DB_Version < pDBTarget_Version Then



            ''basDatabaseFunctions.PingDB()
            ''basGeneralFunctions.Sleep(7000) 'Sleep App for 10secs

            'Start Update
            Do While Current_Loaded_DB_Version < pDBTarget_Version

                Current_Loaded_DB_Version += 1
                Dim NextUpdateFile As String = String.Format(
                                                            "{0}\DBUpgrades\SQL_Upgrade_{1}.sql",
                                                            Program.ApplicationStartUpPath,
                                                            Current_Loaded_DB_Version
                                                            )

                Logger.Log("Executing File: " & NextUpdateFile)
                'Check if the SQLDatabase File Exist
                If Not FileIO.FileSystem.FileExists(NextUpdateFile) Then Return False

                REM I disabled this for now .. because i noticed .. Upgrading a system that already has the tables pops error
                REM   If Not ExecuteSQLFile(NextUpdateFile, True) Then

                If Not ExecuteSQLFile(NextUpdateFile, False, pIsScriptEncrypted, vEncoding) Then
                    'Error Occurred While Upgrading so return false
                    Return False
                End If


            Loop

        End If


        REM Update DB Version if successful
        UpdateDBVersion(pDBTarget_Version)

        Return True
    End Function


#End Region






    ''' <summary>
    ''' Return the instance of this class
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function getClass() As Server

        Return Me

    End Function

#End Region

#End Region


End Class



