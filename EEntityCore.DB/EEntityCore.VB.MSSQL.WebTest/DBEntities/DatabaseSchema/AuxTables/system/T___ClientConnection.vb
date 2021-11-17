Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.system

Public Class T___ClientConnection
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defFileServerUrl = New DataColumnDefinition(TableColumnNames.FileServerUrl.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFileServerAccessKey = New DataColumnDefinition(TableColumnNames.FileServerAccessKey.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFileServerSecretKey = New DataColumnDefinition(TableColumnNames.FileServerSecretKey.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFileServerBucket = New DataColumnDefinition(TableColumnNames.FileServerBucket.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defClientAPIID = New DataColumnDefinition(TableColumnNames.ClientAPIID.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defClientAPIUrl = New DataColumnDefinition(TableColumnNames.ClientAPIUrl.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDB_HOST = New DataColumnDefinition(TableColumnNames.DB_HOST.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDB_DATABASE = New DataColumnDefinition(TableColumnNames.DB_DATABASE.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDB_USERNAME = New DataColumnDefinition(TableColumnNames.DB_USERNAME.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDB_PASSWORD = New DataColumnDefinition(TableColumnNames.DB_PASSWORD.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDB_PORT = New DataColumnDefinition(TableColumnNames.DB_PORT.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFileServerUrlHttps = New DataColumnDefinition(TableColumnNames.FileServerUrlHttps.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defFileServerUrl.ColumnName, defFileServerUrl) 
  ColumnDefns.Add(defFileServerAccessKey.ColumnName, defFileServerAccessKey) 
  ColumnDefns.Add(defFileServerSecretKey.ColumnName, defFileServerSecretKey) 
  ColumnDefns.Add(defFileServerBucket.ColumnName, defFileServerBucket) 
  ColumnDefns.Add(defClientAPIID.ColumnName, defClientAPIID) 
  ColumnDefns.Add(defClientAPIUrl.ColumnName, defClientAPIUrl) 
  ColumnDefns.Add(defDB_HOST.ColumnName, defDB_HOST) 
  ColumnDefns.Add(defDB_DATABASE.ColumnName, defDB_DATABASE) 
  ColumnDefns.Add(defDB_USERNAME.ColumnName, defDB_USERNAME) 
  ColumnDefns.Add(defDB_PASSWORD.ColumnName, defDB_PASSWORD) 
  ColumnDefns.Add(defDB_PORT.ColumnName, defDB_PORT) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defFileServerUrlHttps.ColumnName, defFileServerUrlHttps) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ClientConnection_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ClientConnection", "hr.Client"                  
                            ))                  

End Sub


           Public Sub New() 
               MyBase.New(TABLE_NAME)  
           End Sub 


#Region "Full Access"                  
                  
        '   Full Access means initial data is loaded directly from database, so DBConn MUST be provided                  
                  
        ''' <summary>                  
        ''' FULL ACCESS. This will load data with dbconn                  
        ''' </summary>                  
        ''' <param name="DBConn"></param>                  
        ''' <param name="TableName"></param>                  
        ''' <remarks></remarks>                  
        Public Sub New(ByRef DBConn As All__DBs,                  
                      ByVal TableName As String                  
                     )                  
            MyBase.New(DBConn, TableName)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Full Access. This will load data with dbconn                  
        ''' </summary>                  
        ''' <param name="DBConn"></param>                  
        ''' <param name="pTableName"></param>                  
        ''' <param name="pTargettedRowID">Only works if the table contains a column named ID</param>                  
        ''' <remarks></remarks>                  
        Sub New(ByRef DBConn As All__DBs,                  
                ByVal pTableName As String,                  
                      ByVal pTargettedRowID As Int64)                  
                  
            MyBase.New(DBConn, pTableName, pTargettedRowID:=pTargettedRowID)                  
                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Full Access. This will load data with dbconn                  
        ''' </summary>                  
        ''' <param name="pDBConn"></param>                  
        ''' <param name="pTableName"></param>                  
        ''' <param name="pSQL">Load table with your own SQL</param>                  
        ''' <remarks></remarks>                  
        Public Sub New(ByRef pDBConn As All__DBs,                  
                ByVal pTableName As String,                  
                ByVal pSQL As String)                  
            MyBase.New(pDBConn, pTableName, pSQL)                  
        End Sub                  
                  
                  
        ''' <summary>                  
        ''' Full Access. This will load data with dbconn                  
        ''' </summary>                  
        ''' <param name="pDBConn"></param>                  
        ''' <param name="pTableName"></param>                  
        ''' <param name="pTargettedRowID"></param>                  
        ''' <param name="pSQL">Load table with your own SQL</param>                  
        ''' <remarks></remarks>                  
        Sub New(ByRef pDBConn As All__DBs,                  
                ByVal pTableName As String,                  
                ByVal pSQL As String,                  
                     ByVal pTargettedRowID As Int64)                  
            MyBase.New(pDBConn, pTableName, pSQL, pTargettedRowID)                  
                  
        End Sub                  
                  
#End Region                  
                  
                  
#Region "Partial Access"                  
                  
        ' Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work                  
                  
        ''' <summary>                  
        ''' Partial Access                  
        ''' </summary>                  
        ''' <param name="pDBConn"></param>                  
        ''' <param name="pTableRows"></param>                  
        ''' <param name="pTargettedRowID"></param>                  
        ''' <remarks></remarks>                  
        Sub New(                  
                ByVal pTableRows As DataRowCollection,                  
                      ByVal pTargettedRowID As Int64,                  
                     pTableName As String,                  
                     ByRef pDBConn As All__DBs)                  
            MyBase.New(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        End Sub                  
                  
                  
        ''' <summary>                  
        ''' Partial Access                  
        ''' </summary>                  
        ''' <param name="pDBConn"></param>                  
        ''' <param name="pTableRows"></param>                  
        ''' <param name="pTargettedRowID"></param>                  
        ''' <remarks></remarks>                  
        Sub New(                  
                ByVal pTableRows As IEnumerable(Of DataRow),                  
                      ByVal pTargettedRowID As Int64,                  
                      ByVal pTableName As String,                  
                     ByRef pDBConn As All__DBs)                  
                  
            MyBase.New(pTableRows, pTargettedRowID, pTableName, pDBConn)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Partial Access                  
        ''' </summary>                  
        ''' <param name="DBConn"></param>                  
        ''' <param name="FullTable"></param>                  
        ''' <param name="TargettedRowID"></param>                  
        ''' <remarks></remarks>                  
        Sub New(                  
                ByVal FullTable As DataTable,                  
                      ByVal TargettedRowID As Int32,                  
                      ByVal TableName As String,                  
                      ByRef DBConn As All__DBs)                  
                  
            MyBase.New(FullTable, TargettedRowID, TableName, DBConn)                  
        End Sub                  
                  
                  
#End Region                  
                  
                  
#Region "Shallow Access"                  
        '   In the real definition, shallow reference partial. Just that it means partial with no DBConn                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <param name="TargettedRow"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Sub New(ByVal TargettedRow As DataRow)                  
            MyBase.New(TargettedRow)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <param name="pTableRows"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow))                  
            MyBase.New(pTableRows)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <param name="pTableRows"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),                  
                ByVal pTargettedRowID As Int64                  
                )                  
            MyBase.New(pTableRows, pTargettedRowID)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <param name="pTableRows"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),                  
                ByVal pTargettedRowID As Int64,                  
                ByVal pTableName As String                  
                )                  
            MyBase.New(pTableRows, pTargettedRowID, pTableName)                  
        End Sub                  
                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <remarks></remarks>                  
        Sub New(                  
                ByVal FullTable As DataTable,                  
                ByVal pTableName As String)                  
                  
            MyBase.New(FullTable, pTableName)                  
        End Sub                  
                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <remarks></remarks>                  
        Sub New(                  
                ByVal FullTable As DataTable,                  
                ByVal pTableName As String,                  
                  ByVal pTargettedRowID As Int64)                  
            MyBase.New(FullTable, pTableName, pTargettedRowID)                  
        End Sub                  
                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <remarks></remarks>                  
        Public Sub New(                  
                ByVal pDataRows As DataRowCollection,                  
                ByVal pTableName As String)                  
                  
            MyBase.New(pDataRows, pTableName)                  
                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Shallow Access                  
        ''' </summary>                  
        ''' <param name="pTableRows"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow),                  
                ByVal pTableName As String                  
                )                  
            MyBase.New(pTableRows, pTableName)                  
        End Sub                  
                  
        ''' <summary>                  
        ''' Shallow Access. Should always target this passed in                  
        ''' </summary>                  
        ''' <param name="pTargettedRow"></param>                  
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>                  
        Public Sub New(ByVal pTargettedRow As DataRow, ByVal pTableName As String)                  
            MyBase.New(pTargettedRow, pTableName)                  
        End Sub                  
                  
                  
#End Region                  
                  











#End Region 



#Region "Consts and Enums"

       Public Const TABLE_NAME As String = "system.ClientConnection"
       Public Const ClientConnection__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM ClientConnection"
       Public Const ClientConnection__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [FileServerUrl], [FileServerAccessKey], [FileServerSecretKey], [FileServerBucket], [ClientAPIID], [ClientAPIUrl], [DB_HOST], [DB_DATABASE], [DB_USERNAME], [DB_PASSWORD], [DB_PORT], [CreatedAt], [UpdatedAt], [FileServerUrlHttps] FROM ClientConnection"


       Public Enum TableColumnNames

           [ID]
           [ClientID]
           [FileServerUrl]
           [FileServerAccessKey]
           [FileServerSecretKey]
           [FileServerBucket]
           [ClientAPIID]
           [ClientAPIUrl]
           [DB_HOST]
           [DB_DATABASE]
           [DB_USERNAME]
           [DB_PASSWORD]
           [DB_PORT]
           [CreatedAt]
           [UpdatedAt]
           [FileServerUrlHttps]
       End Enum 



       Public Enum TableConstraints

           pk_system_ClientConnection 
           fk_system_ClientConnection_ClientID 
           uq_system_ClientConnection_ClientID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defFileServerUrl As DataColumnDefinition
       Public Shared ReadOnly defFileServerAccessKey As DataColumnDefinition
       Public Shared ReadOnly defFileServerSecretKey As DataColumnDefinition
       Public Shared ReadOnly defFileServerBucket As DataColumnDefinition
       Public Shared ReadOnly defClientAPIID As DataColumnDefinition
       Public Shared ReadOnly defClientAPIUrl As DataColumnDefinition
       Public Shared ReadOnly defDB_HOST As DataColumnDefinition
       Public Shared ReadOnly defDB_DATABASE As DataColumnDefinition
       Public Shared ReadOnly defDB_USERNAME As DataColumnDefinition
       Public Shared ReadOnly defDB_PASSWORD As DataColumnDefinition
       Public Shared ReadOnly defDB_PORT As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defFileServerUrlHttps As DataColumnDefinition

       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileServerUrl] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FileServerUrl.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileServerAccessKey] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FileServerAccessKey.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileServerSecretKey] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FileServerSecretKey.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileServerBucket] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FileServerBucket.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ClientAPIID] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ClientAPIID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ClientAPIUrl] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ClientAPIUrl.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DB_HOST] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DB_HOST.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DB_DATABASE] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DB_DATABASE.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DB_USERNAME] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DB_USERNAME.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DB_PASSWORD] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DB_PASSWORD.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DB_PORT] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DB_PORT.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UpdatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.UpdatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileServerUrlHttps] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FileServerUrlHttps.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___ClientConnection                  
            If Me.hasRows() Then Return New T___ClientConnection(Me.AllRows(0))                  
            Return New T___ClientConnection()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___ClientConnection                  
            Return New T___ClientConnection(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___ClientConnection                  
            Return New T___ClientConnection(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___ClientConnection                  
            Return New T___ClientConnection(Me.RawTable, T___ClientConnection.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___ClientConnection,                  
                                                                       ParamArray pParams() As DataColumnParameter                  
                                                                            ) As Boolean                  
            Try                  
                If Not Me.hasRows() Then Return False                  
                  
                For Each pParam In pParams                  
                    If Not pRow.RowEqual(pParam.ColumnName, pParam.Value) Then Return False                  
                Next                  
                Return True                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                Return False                  
            End Try                  
                  
        End Function                  
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___ClientConnection,                  
                                            ParamArray pParams() As DataColumnParameter                  
                                            ) As Boolean                  
            Try                  
                If Not Me.hasRows() Then Return False                  
                  
                For Each pParam In pParams                  
                    If pRow.RowEqual(pParam.ColumnName, pParam.Value) Then Return True                  
                Next                  
                Return False                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                Return False                  
            End Try                  
                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___ClientConnection                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___ClientConnection(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ClientConnection(drst.CopyToDataTable(),                  
                    T___ClientConnection.TABLE_NAME)                  
                Return New T___ClientConnection()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___ClientConnection()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___ClientConnection                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___ClientConnection(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ClientConnection(drst.CopyToDataTable(),                  
                    T___ClientConnection.TABLE_NAME)                  
                Return New T___ClientConnection()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___ClientConnection()                  
            End Try                  
                  
        End Function                  
                  
                  
        Public Function getDefinitions() As Dictionary(Of String, DataColumnDefinition) Implements IDataColumnDefinitionsHolder.getDefinitions                  
            Return ColumnDefns                  
        End Function                  
                  
                  
        Private Function RowEqual(pColumnName As String, pColumnValue As Object) As Boolean                  
            Try                  
                  
                If Not Me.isTargettedRowValid Then Return False                  
                  
                Select Case DataColumnDefinition.getTypeAllowed(ColumnDefns(pColumnName).DataType)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.Bool                  
                        Return EBoolean.valueOf(Me.TargettedRow(pColumnName)) = EBoolean.valueOf(pColumnValue)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.Blob                  
                        Return Object.Equals(Me.TargettedRow(pColumnName), pColumnValue)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.DateTime                  
                        Return EDateTime.EqualsDateWithoutTime(                  
                        New NullableDateTime(Me.TargettedRow(pColumnName)).DateTimeValue,                  
                        New NullableDateTime(pColumnValue).DateTimeValue                  
                        )                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.Decimal                  
                        Return EDouble.valueOf(Me.TargettedRow(pColumnName)) = EDouble.valueOf(pColumnValue)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.Int                  
                        Return EInt.valueOf(Me.TargettedRow(pColumnName)) = EInt.valueOf(pColumnValue)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.Long                  
                  
                        Return ELong.valueOf(Me.TargettedRow(pColumnName)) = ELong.valueOf(pColumnValue)                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.String                  
                        Return EStrings.equalsIgnoreCase(EStrings.valueOf(Me.TargettedRow(pColumnName)), EStrings.valueOf(pColumnValue))                  
                  
                    Case DataColumnDefinition.AllowedDataTypes.TimeSpan                  
                        Return Object.Equals(Me.TargettedRow(pColumnName), pColumnValue)                  
                  
                    Case Else                  
                        REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()                                     
                        Return Object.Equals(Me.TargettedRow(pColumnName), pColumnValue)                  
                  
                End Select                  
                  
                  
            Catch ex As Exception                  
                Return False                  
            End Try                  
                  
                  
        End Function                  
                  
                  

        Public Function getForeignKeys() As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition) Implements IDBTableDefinitionPlugIn.getForeignKeys                  
            Return ForeignKeys                  
        End Function                  
                  
        Public Function getTableName() As String Implements IDBTableDefinitionPlugIn.getTableName                  
            Return TABLE_NAME                  
        End Function                  

                  
        Public Overridable Function getFillSQL() As String Implements IDBTableDefinitionPlugIn.getFillSQL                  
            Return ClientConnection__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pClientID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramFileServerUrl As DataColumnParameter = New DataColumnParameter(defFileServerUrl, defFileServerUrl.DefaultValue)
 Dim paramFileServerAccessKey As DataColumnParameter = New DataColumnParameter(defFileServerAccessKey, defFileServerAccessKey.DefaultValue)
 Dim paramFileServerSecretKey As DataColumnParameter = New DataColumnParameter(defFileServerSecretKey, defFileServerSecretKey.DefaultValue)
 Dim paramFileServerBucket As DataColumnParameter = New DataColumnParameter(defFileServerBucket, defFileServerBucket.DefaultValue)
 Dim paramClientAPIID As DataColumnParameter = New DataColumnParameter(defClientAPIID, defClientAPIID.DefaultValue)
 Dim paramClientAPIUrl As DataColumnParameter = New DataColumnParameter(defClientAPIUrl, defClientAPIUrl.DefaultValue)
 Dim paramDB_HOST As DataColumnParameter = New DataColumnParameter(defDB_HOST, defDB_HOST.DefaultValue)
 Dim paramDB_DATABASE As DataColumnParameter = New DataColumnParameter(defDB_DATABASE, defDB_DATABASE.DefaultValue)
 Dim paramDB_USERNAME As DataColumnParameter = New DataColumnParameter(defDB_USERNAME, defDB_USERNAME.DefaultValue)
 Dim paramDB_PASSWORD As DataColumnParameter = New DataColumnParameter(defDB_PASSWORD, defDB_PASSWORD.DefaultValue)
 Dim paramDB_PORT As DataColumnParameter = New DataColumnParameter(defDB_PORT, defDB_PORT.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramFileServerUrlHttps As DataColumnParameter = New DataColumnParameter(defFileServerUrlHttps, defFileServerUrlHttps.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pClientID As Int32,
ByVal pFileServerUrl As String,
ByVal pFileServerAccessKey As String,
ByVal pFileServerSecretKey As String,
ByVal pFileServerBucket As String,
ByVal pClientAPIID As String,
ByVal pClientAPIUrl As String,
ByVal pDB_HOST As String,
ByVal pDB_DATABASE As String,
ByVal pDB_USERNAME As String,
ByVal pDB_PASSWORD As String,
ByVal pDB_PORT As Int32,
ByVal pCreatedAt As DateTime,
ByVal pFileServerUrlHttps As String,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramFileServerUrl As DataColumnParameter = New DataColumnParameter(defFileServerUrl, pFileServerUrl)
 Dim paramFileServerAccessKey As DataColumnParameter = New DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey)
 Dim paramFileServerSecretKey As DataColumnParameter = New DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey)
 Dim paramFileServerBucket As DataColumnParameter = New DataColumnParameter(defFileServerBucket, pFileServerBucket)
 Dim paramClientAPIID As DataColumnParameter = New DataColumnParameter(defClientAPIID, pClientAPIID)
 Dim paramClientAPIUrl As DataColumnParameter = New DataColumnParameter(defClientAPIUrl, pClientAPIUrl)
 Dim paramDB_HOST As DataColumnParameter = New DataColumnParameter(defDB_HOST, pDB_HOST)
 Dim paramDB_DATABASE As DataColumnParameter = New DataColumnParameter(defDB_DATABASE, pDB_DATABASE)
 Dim paramDB_USERNAME As DataColumnParameter = New DataColumnParameter(defDB_USERNAME, pDB_USERNAME)
 Dim paramDB_PASSWORD As DataColumnParameter = New DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD)
 Dim paramDB_PORT As DataColumnParameter = New DataColumnParameter(defDB_PORT, pDB_PORT)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramFileServerUrlHttps As DataColumnParameter = New DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pClientID As Int32,
ByVal pFileServerUrl As String,
ByVal pFileServerAccessKey As String,
ByVal pFileServerSecretKey As String,
ByVal pFileServerBucket As String,
ByVal pClientAPIID As String,
ByVal pClientAPIUrl As String,
ByVal pDB_HOST As String,
ByVal pDB_DATABASE As String,
ByVal pDB_USERNAME As String,
ByVal pDB_PASSWORD As String,
ByVal pDB_PORT As Int32,
ByVal pCreatedAt As DateTime,
ByVal pFileServerUrlHttps As String,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramFileServerUrl As DataColumnParameter = New DataColumnParameter(defFileServerUrl, pFileServerUrl)
 Dim paramFileServerAccessKey As DataColumnParameter = New DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey)
 Dim paramFileServerSecretKey As DataColumnParameter = New DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey)
 Dim paramFileServerBucket As DataColumnParameter = New DataColumnParameter(defFileServerBucket, pFileServerBucket)
 Dim paramClientAPIID As DataColumnParameter = New DataColumnParameter(defClientAPIID, pClientAPIID)
 Dim paramClientAPIUrl As DataColumnParameter = New DataColumnParameter(defClientAPIUrl, pClientAPIUrl)
 Dim paramDB_HOST As DataColumnParameter = New DataColumnParameter(defDB_HOST, pDB_HOST)
 Dim paramDB_DATABASE As DataColumnParameter = New DataColumnParameter(defDB_DATABASE, pDB_DATABASE)
 Dim paramDB_USERNAME As DataColumnParameter = New DataColumnParameter(defDB_USERNAME, pDB_USERNAME)
 Dim paramDB_PASSWORD As DataColumnParameter = New DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD)
 Dim paramDB_PORT As DataColumnParameter = New DataColumnParameter(defDB_PORT, pDB_PORT)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramFileServerUrlHttps As DataColumnParameter = New DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



''' <summary> 
''' You can not save image with this method 
''' </summary> 
''' <returns>Boolean</returns> ''' <remarks></remarks> 
Public Shared Function add(ByVal pClientID As Int32,
ByVal pFileServerUrl As String,
ByVal pFileServerAccessKey As String,
ByVal pFileServerSecretKey As String,
ByVal pFileServerBucket As String,
ByVal pClientAPIID As String,
ByVal pClientAPIUrl As String,
ByVal pDB_HOST As String,
ByVal pDB_DATABASE As String,
ByVal pDB_USERNAME As String,
ByVal pDB_PASSWORD As String,
ByVal pDB_PORT As Int32,
ByVal pCreatedAt As DateTime,
ByVal pFileServerUrlHttps As String,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramFileServerUrl As DataColumnParameter = New DataColumnParameter(defFileServerUrl, pFileServerUrl)
 Dim paramFileServerAccessKey As DataColumnParameter = New DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey)
 Dim paramFileServerSecretKey As DataColumnParameter = New DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey)
 Dim paramFileServerBucket As DataColumnParameter = New DataColumnParameter(defFileServerBucket, pFileServerBucket)
 Dim paramClientAPIID As DataColumnParameter = New DataColumnParameter(defClientAPIID, pClientAPIID)
 Dim paramClientAPIUrl As DataColumnParameter = New DataColumnParameter(defClientAPIUrl, pClientAPIUrl)
 Dim paramDB_HOST As DataColumnParameter = New DataColumnParameter(defDB_HOST, pDB_HOST)
 Dim paramDB_DATABASE As DataColumnParameter = New DataColumnParameter(defDB_DATABASE, pDB_DATABASE)
 Dim paramDB_USERNAME As DataColumnParameter = New DataColumnParameter(defDB_USERNAME, pDB_USERNAME)
 Dim paramDB_PASSWORD As DataColumnParameter = New DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD)
 Dim paramDB_PORT As DataColumnParameter = New DataColumnParameter(defDB_PORT, pDB_PORT)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramFileServerUrlHttps As DataColumnParameter = New DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([ClientID],[FileServerUrl],[FileServerAccessKey],[FileServerSecretKey],[FileServerBucket],[ClientAPIID],[ClientAPIUrl],[DB_HOST],[DB_DATABASE],[DB_USERNAME],[DB_PASSWORD],[DB_PORT],[CreatedAt],[UpdatedAt],[FileServerUrlHttps]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) ", TABLE_NAME,paramClientID.getSQLQuotedValueForAdd(),
paramFileServerUrl.getSQLQuotedValueForAdd(),
paramFileServerAccessKey.getSQLQuotedValueForAdd(),
paramFileServerSecretKey.getSQLQuotedValueForAdd(),
paramFileServerBucket.getSQLQuotedValueForAdd(),
paramClientAPIID.getSQLQuotedValueForAdd(),
paramClientAPIUrl.getSQLQuotedValueForAdd(),
paramDB_HOST.getSQLQuotedValueForAdd(),
paramDB_DATABASE.getSQLQuotedValueForAdd(),
paramDB_USERNAME.getSQLQuotedValueForAdd(),
paramDB_PASSWORD.getSQLQuotedValueForAdd(),
paramDB_PORT.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramFileServerUrlHttps.getSQLQuotedValueForAdd()  ), True)


Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return False    REM this will not run 

End Function 

''' <summary> 
''' Leave a column as nothing to skip and a Nullable Column as Null to actually Null it 
''' </summary> 
''' <returns>Boolean</returns> 
''' <remarks></remarks>                            
Public Shared Function update(ByVal pID As Int64 ,
Optional ByVal pClientID As Object=Nothing,
Optional ByVal pFileServerUrl As Object=Nothing,
Optional ByVal pFileServerAccessKey As Object=Nothing,
Optional ByVal pFileServerSecretKey As Object=Nothing,
Optional ByVal pFileServerBucket As Object=Nothing,
Optional ByVal pClientAPIID As Object=Nothing,
Optional ByVal pClientAPIUrl As Object=Nothing,
Optional ByVal pDB_HOST As Object=Nothing,
Optional ByVal pDB_DATABASE As Object=Nothing,
Optional ByVal pDB_USERNAME As Object=Nothing,
Optional ByVal pDB_PASSWORD As Object=Nothing,
Optional ByVal pDB_PORT As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pFileServerUrlHttps As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramFileServerUrl As DataColumnParameter = New DataColumnParameter(defFileServerUrl, pFileServerUrl)
 Dim paramFileServerAccessKey As DataColumnParameter = New DataColumnParameter(defFileServerAccessKey, pFileServerAccessKey)
 Dim paramFileServerSecretKey As DataColumnParameter = New DataColumnParameter(defFileServerSecretKey, pFileServerSecretKey)
 Dim paramFileServerBucket As DataColumnParameter = New DataColumnParameter(defFileServerBucket, pFileServerBucket)
 Dim paramClientAPIID As DataColumnParameter = New DataColumnParameter(defClientAPIID, pClientAPIID)
 Dim paramClientAPIUrl As DataColumnParameter = New DataColumnParameter(defClientAPIUrl, pClientAPIUrl)
 Dim paramDB_HOST As DataColumnParameter = New DataColumnParameter(defDB_HOST, pDB_HOST)
 Dim paramDB_DATABASE As DataColumnParameter = New DataColumnParameter(defDB_DATABASE, pDB_DATABASE)
 Dim paramDB_USERNAME As DataColumnParameter = New DataColumnParameter(defDB_USERNAME, pDB_USERNAME)
 Dim paramDB_PASSWORD As DataColumnParameter = New DataColumnParameter(defDB_PASSWORD, pDB_PASSWORD)
 Dim paramDB_PORT As DataColumnParameter = New DataColumnParameter(defDB_PORT, pDB_PORT)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramFileServerUrlHttps As DataColumnParameter = New DataColumnParameter(defFileServerUrlHttps, pFileServerUrlHttps)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[FileServerUrl]={3},[FileServerAccessKey]={4},[FileServerSecretKey]={5},[FileServerBucket]={6},[ClientAPIID]={7},[ClientAPIUrl]={8},[DB_HOST]={9},[DB_DATABASE]={10},[DB_USERNAME]={11},[DB_PASSWORD]={12},[DB_PORT]={13},[CreatedAt]={14},[UpdatedAt]={15},[FileServerUrlHttps]={16} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramClientID.getSQLQuotedValueForUpdate(),
paramFileServerUrl.getSQLQuotedValueForUpdate(),
paramFileServerAccessKey.getSQLQuotedValueForUpdate(),
paramFileServerSecretKey.getSQLQuotedValueForUpdate(),
paramFileServerBucket.getSQLQuotedValueForUpdate(),
paramClientAPIID.getSQLQuotedValueForUpdate(),
paramClientAPIUrl.getSQLQuotedValueForUpdate(),
paramDB_HOST.getSQLQuotedValueForUpdate(),
paramDB_DATABASE.getSQLQuotedValueForUpdate(),
paramDB_USERNAME.getSQLQuotedValueForUpdate(),
paramDB_PASSWORD.getSQLQuotedValueForUpdate(),
paramDB_PORT.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramFileServerUrlHttps.getSQLQuotedValueForUpdate()  ), True)


REM Nothing means ignore but null means clear


            Return TRUE 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return FALSE   REM this will not run 

End Function 




Public Overloads Shared Function delete(ByVal pID As Int64) As Boolean 

Try 
Return DBConnectInterface.getDBConn().dbExec( 
String.Format("DELETE FROM {0} WHERE ID={1} ", TABLE_NAME, pID) 
) 

Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

End Function


End Class


End Namespace
