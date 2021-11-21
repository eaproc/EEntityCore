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

Public Class T___ServerExceptionLogger
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defTraceID = New DataColumnDefinition(TableColumnNames.TraceID.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defRequestParametersJSON = New DataColumnDefinition(TableColumnNames.RequestParametersJSON.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExceptionMessage = New DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defStackTrace = New DataColumnDefinition(TableColumnNames.StackTrace.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsResolved = New DataColumnDefinition(TableColumnNames.IsResolved.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defComments = New DataColumnDefinition(TableColumnNames.Comments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAbsoluteURL = New DataColumnDefinition(TableColumnNames.AbsoluteURL.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIPAddress = New DataColumnDefinition(TableColumnNames.IPAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUserID = New DataColumnDefinition(TableColumnNames.UserID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defTraceID.ColumnName, defTraceID) 
  ColumnDefns.Add(defRequestParametersJSON.ColumnName, defRequestParametersJSON) 
  ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage) 
  ColumnDefns.Add(defStackTrace.ColumnName, defStackTrace) 
  ColumnDefns.Add(defIsResolved.ColumnName, defIsResolved) 
  ColumnDefns.Add(defComments.ColumnName, defComments) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defAbsoluteURL.ColumnName, defAbsoluteURL) 
  ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress) 
  ColumnDefns.Add(defUserID.ColumnName, defUserID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_ServerExceptionLogger_UserID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.ServerExceptionLogger", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "system.ServerExceptionLogger"
       Public Const ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM ServerExceptionLogger"
       Public Const ServerExceptionLogger__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [TraceID], [RequestParametersJSON], [ExceptionMessage], [StackTrace], [IsResolved], [Comments], [CreatedAt], [UpdatedAt], [AbsoluteURL], [IPAddress], [UserID] FROM ServerExceptionLogger"


       Public Enum TableColumnNames

           [ID]
           [TraceID]
           [RequestParametersJSON]
           [ExceptionMessage]
           [StackTrace]
           [IsResolved]
           [Comments]
           [CreatedAt]
           [UpdatedAt]
           [AbsoluteURL]
           [IPAddress]
           [UserID]
       End Enum 



       Public Enum TableConstraints

           pk_system_ServerExceptionLogger 
           fk_system_ServerExceptionLogger_UserID 
           uq_system_ServerExceptionLogger_TraceID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defTraceID As DataColumnDefinition
       Public Shared ReadOnly defRequestParametersJSON As DataColumnDefinition
       Public Shared ReadOnly defExceptionMessage As DataColumnDefinition
       Public Shared ReadOnly defStackTrace As DataColumnDefinition
       Public Shared ReadOnly defIsResolved As DataColumnDefinition
       Public Shared ReadOnly defComments As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defAbsoluteURL As DataColumnDefinition
       Public Shared ReadOnly defIPAddress As DataColumnDefinition
       Public Shared ReadOnly defUserID As DataColumnDefinition

       Public ReadOnly Property [TraceID] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.TraceID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RequestParametersJSON] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.RequestParametersJSON.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExceptionMessage] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ExceptionMessage.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StackTrace] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.StackTrace.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsResolved] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsResolved.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Comments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Comments.ToString()))
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


       Public ReadOnly Property [AbsoluteURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AbsoluteURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IPAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IPAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UserID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___ServerExceptionLogger                  
            If Me.hasRows() Then Return New T___ServerExceptionLogger(Me.AllRows(0))                  
            Return New T___ServerExceptionLogger()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___ServerExceptionLogger                  
            Return New T___ServerExceptionLogger(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___ServerExceptionLogger                  
            Return New T___ServerExceptionLogger(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___ServerExceptionLogger                  
            Return New T___ServerExceptionLogger(Me.RawTable, T___ServerExceptionLogger.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___ServerExceptionLogger,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___ServerExceptionLogger,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___ServerExceptionLogger                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___ServerExceptionLogger(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ServerExceptionLogger(drst.CopyToDataTable(),                  
                    T___ServerExceptionLogger.TABLE_NAME)                  
                Return New T___ServerExceptionLogger()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___ServerExceptionLogger()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___ServerExceptionLogger                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___ServerExceptionLogger(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ServerExceptionLogger(drst.CopyToDataTable(),                  
                    T___ServerExceptionLogger.TABLE_NAME)                  
                Return New T___ServerExceptionLogger()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___ServerExceptionLogger()                  
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
            Return ServerExceptionLogger__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pTraceID As String,
ByVal pUserID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTraceID As DataColumnParameter = New DataColumnParameter(defTraceID, pTraceID)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramRequestParametersJSON As DataColumnParameter = New DataColumnParameter(defRequestParametersJSON, defRequestParametersJSON.DefaultValue)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, defExceptionMessage.DefaultValue)
 Dim paramStackTrace As DataColumnParameter = New DataColumnParameter(defStackTrace, defStackTrace.DefaultValue)
 Dim paramIsResolved As DataColumnParameter = New DataColumnParameter(defIsResolved, defIsResolved.DefaultValue)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, defComments.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramAbsoluteURL As DataColumnParameter = New DataColumnParameter(defAbsoluteURL, defAbsoluteURL.DefaultValue)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, defIPAddress.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTraceID.getSQLQuotedValueForAdd(),
paramRequestParametersJSON.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramStackTrace.getSQLQuotedValueForAdd(),
paramIsResolved.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAbsoluteURL.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pTraceID As String,
ByVal pExceptionMessage As String,
ByVal pIsResolved As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAbsoluteURL As String,
ByVal pIPAddress As String,
Optional ByVal pRequestParametersJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pStackTrace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTraceID As DataColumnParameter = New DataColumnParameter(defTraceID, pTraceID)
 Dim paramRequestParametersJSON As DataColumnParameter = New DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramStackTrace As DataColumnParameter = New DataColumnParameter(defStackTrace, pStackTrace)
 Dim paramIsResolved As DataColumnParameter = New DataColumnParameter(defIsResolved, pIsResolved)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAbsoluteURL As DataColumnParameter = New DataColumnParameter(defAbsoluteURL, pAbsoluteURL)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTraceID.getSQLQuotedValueForAdd(),
paramRequestParametersJSON.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramStackTrace.getSQLQuotedValueForAdd(),
paramIsResolved.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAbsoluteURL.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pTraceID As String,
ByVal pExceptionMessage As String,
ByVal pIsResolved As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAbsoluteURL As String,
ByVal pIPAddress As String,
Optional ByVal pRequestParametersJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pStackTrace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramTraceID As DataColumnParameter = New DataColumnParameter(defTraceID, pTraceID)
 Dim paramRequestParametersJSON As DataColumnParameter = New DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramStackTrace As DataColumnParameter = New DataColumnParameter(defStackTrace, pStackTrace)
 Dim paramIsResolved As DataColumnParameter = New DataColumnParameter(defIsResolved, pIsResolved)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAbsoluteURL As DataColumnParameter = New DataColumnParameter(defAbsoluteURL, pAbsoluteURL)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTraceID.getSQLQuotedValueForAdd(),
paramRequestParametersJSON.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramStackTrace.getSQLQuotedValueForAdd(),
paramIsResolved.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAbsoluteURL.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pTraceID As String,
ByVal pExceptionMessage As String,
ByVal pIsResolved As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAbsoluteURL As String,
ByVal pIPAddress As String,
Optional ByVal pRequestParametersJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pStackTrace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramTraceID As DataColumnParameter = New DataColumnParameter(defTraceID, pTraceID)
 Dim paramRequestParametersJSON As DataColumnParameter = New DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramStackTrace As DataColumnParameter = New DataColumnParameter(defStackTrace, pStackTrace)
 Dim paramIsResolved As DataColumnParameter = New DataColumnParameter(defIsResolved, pIsResolved)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAbsoluteURL As DataColumnParameter = New DataColumnParameter(defAbsoluteURL, pAbsoluteURL)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([TraceID],[RequestParametersJSON],[ExceptionMessage],[StackTrace],[IsResolved],[Comments],[CreatedAt],[UpdatedAt],[AbsoluteURL],[IPAddress],[UserID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramTraceID.getSQLQuotedValueForAdd(),
paramRequestParametersJSON.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramStackTrace.getSQLQuotedValueForAdd(),
paramIsResolved.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAbsoluteURL.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pTraceID As Object=Nothing,
Optional ByVal pExceptionMessage As Object=Nothing,
Optional ByVal pIsResolved As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pAbsoluteURL As Object=Nothing,
Optional ByVal pIPAddress As Object=Nothing,
Optional ByVal pRequestParametersJSON As Object=Nothing,
Optional ByVal pStackTrace As Object=Nothing,
Optional ByVal pComments As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pUserID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramTraceID As DataColumnParameter = New DataColumnParameter(defTraceID, pTraceID)
 Dim paramRequestParametersJSON As DataColumnParameter = New DataColumnParameter(defRequestParametersJSON, pRequestParametersJSON)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramStackTrace As DataColumnParameter = New DataColumnParameter(defStackTrace, pStackTrace)
 Dim paramIsResolved As DataColumnParameter = New DataColumnParameter(defIsResolved, pIsResolved)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAbsoluteURL As DataColumnParameter = New DataColumnParameter(defAbsoluteURL, pAbsoluteURL)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [TraceID]={2},[RequestParametersJSON]={3},[ExceptionMessage]={4},[StackTrace]={5},[IsResolved]={6},[Comments]={7},[CreatedAt]={8},[UpdatedAt]={9},[AbsoluteURL]={10},[IPAddress]={11},[UserID]={12} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramTraceID.getSQLQuotedValueForUpdate(),
paramRequestParametersJSON.getSQLQuotedValueForUpdate(),
paramExceptionMessage.getSQLQuotedValueForUpdate(),
paramStackTrace.getSQLQuotedValueForUpdate(),
paramIsResolved.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramAbsoluteURL.getSQLQuotedValueForUpdate(),
paramIPAddress.getSQLQuotedValueForUpdate(),
paramUserID.getSQLQuotedValueForUpdate()  ), True)


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
Return DBConnectInterface.GetDBConn().DbExec( 
String.Format("DELETE FROM {0} WHERE ID={1} ", TABLE_NAME, pID) 
) 

Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

End Function


End Class


End Namespace
