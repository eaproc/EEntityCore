Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.common

Public Class T___PlannedEvent
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCalendarEventID = New DataColumnDefinition(TableColumnNames.CalendarEventID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defTitle = New DataColumnDefinition(TableColumnNames.Title.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defStartDate = New DataColumnDefinition(TableColumnNames.StartDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEndDate = New DataColumnDefinition(TableColumnNames.EndDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defComments = New DataColumnDefinition(TableColumnNames.Comments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defTrackID = New DataColumnDefinition(TableColumnNames.TrackID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAcademicSessionID = New DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCalendarEventID.ColumnName, defCalendarEventID) 
  ColumnDefns.Add(defTitle.ColumnName, defTitle) 
  ColumnDefns.Add(defStartDate.ColumnName, defStartDate) 
  ColumnDefns.Add(defEndDate.ColumnName, defEndDate) 
  ColumnDefns.Add(defComments.ColumnName, defComments) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defTrackID.ColumnName, defTrackID) 
  ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CalendarEventID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "common.CalendarEvent"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PlannedEvent_AcademicSessionID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PlannedEvent", "academic.AcademicSession"                  
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

       Public Const TABLE_NAME As String = "common.PlannedEvent"
       Public Const PlannedEvent__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM PlannedEvent"
       Public Const PlannedEvent__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CalendarEventID], [Title], [StartDate], [EndDate], [Comments], [CreatedAt], [CreatedByID], [TrackID], [AcademicSessionID] FROM PlannedEvent"


       Public Enum TableColumnNames

           [ID]
           [CalendarEventID]
           [Title]
           [StartDate]
           [EndDate]
           [Comments]
           [CreatedAt]
           [CreatedByID]
           [TrackID]
           [AcademicSessionID]
       End Enum 



       Public Enum TableConstraints

           pk_common_PlannedEvent 
           fk_common_PlannedEvent_CalendarEventID 
           fk_common_PlannedEvent_CreatedByID 
           fk_common_PlannedEvent_AcademicSessionID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCalendarEventID As DataColumnDefinition
       Public Shared ReadOnly defTitle As DataColumnDefinition
       Public Shared ReadOnly defStartDate As DataColumnDefinition
       Public Shared ReadOnly defEndDate As DataColumnDefinition
       Public Shared ReadOnly defComments As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defTrackID As DataColumnDefinition
       Public Shared ReadOnly defAcademicSessionID As DataColumnDefinition

       Public ReadOnly Property [CalendarEventID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CalendarEventID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Title] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Title.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.StartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [EndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.EndDate.ToString()))
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


       Public ReadOnly Property [CreatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CreatedByID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TrackID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TrackID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AcademicSessionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AcademicSessionID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___PlannedEvent                  
            If Me.hasRows() Then Return New T___PlannedEvent(Me.AllRows(0))                  
            Return New T___PlannedEvent()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PlannedEvent                  
            Return New T___PlannedEvent(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PlannedEvent                  
            Return New T___PlannedEvent(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PlannedEvent                  
            Return New T___PlannedEvent(Me.RawTable, T___PlannedEvent.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PlannedEvent,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PlannedEvent,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PlannedEvent                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PlannedEvent(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PlannedEvent(drst.CopyToDataTable(),                  
                    T___PlannedEvent.TABLE_NAME)                  
                Return New T___PlannedEvent()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PlannedEvent()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PlannedEvent                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PlannedEvent(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PlannedEvent(drst.CopyToDataTable(),                  
                    T___PlannedEvent.TABLE_NAME)                  
                Return New T___PlannedEvent()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PlannedEvent()                  
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
            Return PlannedEvent__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCalendarEventID As Int32,
ByVal pCreatedByID As Int32,
ByVal pAcademicSessionID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCalendarEventID As DataColumnParameter = New DataColumnParameter(defCalendarEventID, pCalendarEventID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, defTitle.DefaultValue)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, defStartDate.DefaultValue)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, defEndDate.DefaultValue)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, defComments.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramTrackID As DataColumnParameter = New DataColumnParameter(defTrackID, defTrackID.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCalendarEventID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramTrackID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pCalendarEventID As Int32,
ByVal pTitle As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pAcademicSessionID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTrackID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCalendarEventID As DataColumnParameter = New DataColumnParameter(defCalendarEventID, pCalendarEventID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTrackID As DataColumnParameter = New DataColumnParameter(defTrackID, pTrackID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCalendarEventID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramTrackID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pCalendarEventID As Int32,
ByVal pTitle As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pAcademicSessionID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTrackID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCalendarEventID As DataColumnParameter = New DataColumnParameter(defCalendarEventID, pCalendarEventID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTrackID As DataColumnParameter = New DataColumnParameter(defTrackID, pTrackID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCalendarEventID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramTrackID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pCalendarEventID As Int32,
ByVal pTitle As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pAcademicSessionID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTrackID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramCalendarEventID As DataColumnParameter = New DataColumnParameter(defCalendarEventID, pCalendarEventID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTrackID As DataColumnParameter = New DataColumnParameter(defTrackID, pTrackID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([CalendarEventID],[Title],[StartDate],[EndDate],[Comments],[CreatedAt],[CreatedByID],[TrackID],[AcademicSessionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramCalendarEventID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramTrackID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pCalendarEventID As Object=Nothing,
Optional ByVal pTitle As Object=Nothing,
Optional ByVal pStartDate As Object=Nothing,
Optional ByVal pEndDate As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pAcademicSessionID As Object=Nothing,
Optional ByVal pComments As Object=Nothing,
Optional ByVal pTrackID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCalendarEventID As DataColumnParameter = New DataColumnParameter(defCalendarEventID, pCalendarEventID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTrackID As DataColumnParameter = New DataColumnParameter(defTrackID, pTrackID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [CalendarEventID]={2},[Title]={3},[StartDate]={4},[EndDate]={5},[Comments]={6},[CreatedAt]={7},[CreatedByID]={8},[TrackID]={9},[AcademicSessionID]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCalendarEventID.getSQLQuotedValueForUpdate(),
paramTitle.getSQLQuotedValueForUpdate(),
paramStartDate.getSQLQuotedValueForUpdate(),
paramEndDate.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramTrackID.getSQLQuotedValueForUpdate(),
paramAcademicSessionID.getSQLQuotedValueForUpdate()  ), True)


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
