Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.auth

Public Class T___Session
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defSessionID = New DataColumnDefinition(TableColumnNames.SessionID.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defSessionTimeoutMins = New DataColumnDefinition(TableColumnNames.SessionTimeoutMins.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUserID = New DataColumnDefinition(TableColumnNames.UserID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsNewSession = New DataColumnDefinition(TableColumnNames.IsNewSession.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsReadOnly = New DataColumnDefinition(TableColumnNames.IsReadOnly.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastActive = New DataColumnDefinition(TableColumnNames.LastActive.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIpAddress = New DataColumnDefinition(TableColumnNames.IpAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBrowser = New DataColumnDefinition(TableColumnNames.Browser.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSessionVariables = New DataColumnDefinition(TableColumnNames.SessionVariables.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defSessionID.ColumnName, defSessionID) 
  ColumnDefns.Add(defSessionTimeoutMins.ColumnName, defSessionTimeoutMins) 
  ColumnDefns.Add(defUserID.ColumnName, defUserID) 
  ColumnDefns.Add(defIsNewSession.ColumnName, defIsNewSession) 
  ColumnDefns.Add(defIsReadOnly.ColumnName, defIsReadOnly) 
  ColumnDefns.Add(defLastActive.ColumnName, defLastActive) 
  ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress) 
  ColumnDefns.Add(defBrowser.ColumnName, defBrowser) 
  ColumnDefns.Add(defSessionVariables.ColumnName, defSessionVariables) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  


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

       Public Const TABLE_NAME As String = "auth.Session"
       Public Const Session__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM Session"
       Public Const Session__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [SessionID], [SessionTimeoutMins], [UserID], [IsNewSession], [IsReadOnly], [LastActive], [IpAddress], [Browser], [SessionVariables], [CreatedAt], [UpdatedAt] FROM Session"


       Public Enum TableColumnNames

           [ID]
           [SessionID]
           [SessionTimeoutMins]
           [UserID]
           [IsNewSession]
           [IsReadOnly]
           [LastActive]
           [IpAddress]
           [Browser]
           [SessionVariables]
           [CreatedAt]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_auth_Session 
           uq_auth_SessionID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defSessionID As DataColumnDefinition
       Public Shared ReadOnly defSessionTimeoutMins As DataColumnDefinition
       Public Shared ReadOnly defUserID As DataColumnDefinition
       Public Shared ReadOnly defIsNewSession As DataColumnDefinition
       Public Shared ReadOnly defIsReadOnly As DataColumnDefinition
       Public Shared ReadOnly defLastActive As DataColumnDefinition
       Public Shared ReadOnly defIpAddress As DataColumnDefinition
       Public Shared ReadOnly defBrowser As DataColumnDefinition
       Public Shared ReadOnly defSessionVariables As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [SessionID] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.SessionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SessionTimeoutMins] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.SessionTimeoutMins.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UserID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsNewSession] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsNewSession.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsReadOnly] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsReadOnly.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LastActive] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.LastActive.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IpAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IpAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Browser] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Browser.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SessionVariables] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.SessionVariables.ToString()))
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


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Session                  
            If Me.hasRows() Then Return New T___Session(Me.AllRows(0))                  
            Return New T___Session()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Session                  
            Return New T___Session(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Session                  
            Return New T___Session(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Session                  
            Return New T___Session(Me.RawTable, T___Session.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Session,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Session,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Session                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Session(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Session(drst.CopyToDataTable(),                  
                    T___Session.TABLE_NAME)                  
                Return New T___Session()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Session()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Session                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Session(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Session(drst.CopyToDataTable(),                  
                    T___Session.TABLE_NAME)                  
                Return New T___Session()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Session()                  
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
            Return Session__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pSessionID As String) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramSessionID As DataColumnParameter = New DataColumnParameter(defSessionID, pSessionID)
 Dim paramSessionTimeoutMins As DataColumnParameter = New DataColumnParameter(defSessionTimeoutMins, defSessionTimeoutMins.DefaultValue)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, defUserID.DefaultValue)
 Dim paramIsNewSession As DataColumnParameter = New DataColumnParameter(defIsNewSession, defIsNewSession.DefaultValue)
 Dim paramIsReadOnly As DataColumnParameter = New DataColumnParameter(defIsReadOnly, defIsReadOnly.DefaultValue)
 Dim paramLastActive As DataColumnParameter = New DataColumnParameter(defLastActive, defLastActive.DefaultValue)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, defIpAddress.DefaultValue)
 Dim paramBrowser As DataColumnParameter = New DataColumnParameter(defBrowser, defBrowser.DefaultValue)
 Dim paramSessionVariables As DataColumnParameter = New DataColumnParameter(defSessionVariables, defSessionVariables.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pSessionID As String,
ByVal pSessionTimeoutMins As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsNewSession As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsReadOnly As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLastActive As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIpAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBrowser As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSessionVariables As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramSessionID As DataColumnParameter = New DataColumnParameter(defSessionID, pSessionID)
 Dim paramSessionTimeoutMins As DataColumnParameter = New DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramIsNewSession As DataColumnParameter = New DataColumnParameter(defIsNewSession, pIsNewSession)
 Dim paramIsReadOnly As DataColumnParameter = New DataColumnParameter(defIsReadOnly, pIsReadOnly)
 Dim paramLastActive As DataColumnParameter = New DataColumnParameter(defLastActive, pLastActive)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramBrowser As DataColumnParameter = New DataColumnParameter(defBrowser, pBrowser)
 Dim paramSessionVariables As DataColumnParameter = New DataColumnParameter(defSessionVariables, pSessionVariables)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pSessionID As String,
ByVal pSessionTimeoutMins As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsNewSession As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsReadOnly As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLastActive As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIpAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBrowser As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSessionVariables As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramSessionID As DataColumnParameter = New DataColumnParameter(defSessionID, pSessionID)
 Dim paramSessionTimeoutMins As DataColumnParameter = New DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramIsNewSession As DataColumnParameter = New DataColumnParameter(defIsNewSession, pIsNewSession)
 Dim paramIsReadOnly As DataColumnParameter = New DataColumnParameter(defIsReadOnly, pIsReadOnly)
 Dim paramLastActive As DataColumnParameter = New DataColumnParameter(defLastActive, pLastActive)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramBrowser As DataColumnParameter = New DataColumnParameter(defBrowser, pBrowser)
 Dim paramSessionVariables As DataColumnParameter = New DataColumnParameter(defSessionVariables, pSessionVariables)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pSessionID As String,
ByVal pSessionTimeoutMins As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsNewSession As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsReadOnly As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLastActive As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIpAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBrowser As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSessionVariables As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramSessionID As DataColumnParameter = New DataColumnParameter(defSessionID, pSessionID)
 Dim paramSessionTimeoutMins As DataColumnParameter = New DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramIsNewSession As DataColumnParameter = New DataColumnParameter(defIsNewSession, pIsNewSession)
 Dim paramIsReadOnly As DataColumnParameter = New DataColumnParameter(defIsReadOnly, pIsReadOnly)
 Dim paramLastActive As DataColumnParameter = New DataColumnParameter(defLastActive, pLastActive)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramBrowser As DataColumnParameter = New DataColumnParameter(defBrowser, pBrowser)
 Dim paramSessionVariables As DataColumnParameter = New DataColumnParameter(defSessionVariables, pSessionVariables)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([SessionID],[SessionTimeoutMins],[UserID],[IsNewSession],[IsReadOnly],[LastActive],[IpAddress],[Browser],[SessionVariables],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramSessionID.getSQLQuotedValueForAdd(),
paramSessionTimeoutMins.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramIsNewSession.getSQLQuotedValueForAdd(),
paramIsReadOnly.getSQLQuotedValueForAdd(),
paramLastActive.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramBrowser.getSQLQuotedValueForAdd(),
paramSessionVariables.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pSessionID As Object=Nothing,
Optional ByVal pSessionTimeoutMins As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUserID As Object=Nothing,
Optional ByVal pIsNewSession As Object=Nothing,
Optional ByVal pIsReadOnly As Object=Nothing,
Optional ByVal pLastActive As Object=Nothing,
Optional ByVal pIpAddress As Object=Nothing,
Optional ByVal pBrowser As Object=Nothing,
Optional ByVal pSessionVariables As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramSessionID As DataColumnParameter = New DataColumnParameter(defSessionID, pSessionID)
 Dim paramSessionTimeoutMins As DataColumnParameter = New DataColumnParameter(defSessionTimeoutMins, pSessionTimeoutMins)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramIsNewSession As DataColumnParameter = New DataColumnParameter(defIsNewSession, pIsNewSession)
 Dim paramIsReadOnly As DataColumnParameter = New DataColumnParameter(defIsReadOnly, pIsReadOnly)
 Dim paramLastActive As DataColumnParameter = New DataColumnParameter(defLastActive, pLastActive)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramBrowser As DataColumnParameter = New DataColumnParameter(defBrowser, pBrowser)
 Dim paramSessionVariables As DataColumnParameter = New DataColumnParameter(defSessionVariables, pSessionVariables)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [SessionID]={2},[SessionTimeoutMins]={3},[UserID]={4},[IsNewSession]={5},[IsReadOnly]={6},[LastActive]={7},[IpAddress]={8},[Browser]={9},[SessionVariables]={10},[CreatedAt]={11},[UpdatedAt]={12} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramSessionID.getSQLQuotedValueForUpdate(),
paramSessionTimeoutMins.getSQLQuotedValueForUpdate(),
paramUserID.getSQLQuotedValueForUpdate(),
paramIsNewSession.getSQLQuotedValueForUpdate(),
paramIsReadOnly.getSQLQuotedValueForUpdate(),
paramLastActive.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramBrowser.getSQLQuotedValueForUpdate(),
paramSessionVariables.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate()  ), True)


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
