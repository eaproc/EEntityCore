Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.accounting

Public Class T___CashRequest
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defRequest = New DataColumnDefinition(TableColumnNames.Request.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpenditureCategoryID = New DataColumnDefinition(TableColumnNames.ExpenditureCategoryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAmount = New DataColumnDefinition(TableColumnNames.Amount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDeadline = New DataColumnDefinition(TableColumnNames.Deadline.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defBeneficiaryID = New DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defTrackingID = New DataColumnDefinition(TableColumnNames.TrackingID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDataMonitorID = New DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defRequest.ColumnName, defRequest) 
  ColumnDefns.Add(defExpenditureCategoryID.ColumnName, defExpenditureCategoryID) 
  ColumnDefns.Add(defAmount.ColumnName, defAmount) 
  ColumnDefns.Add(defDeadline.ColumnName, defDeadline) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID) 
  ColumnDefns.Add(defTrackingID.ColumnName, defTrackingID) 
  ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_DataMonitorID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "import.DataMonitor"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_ExpenditureCategoryID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "accounting.ExpenditureCategory"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequest_BeneficiaryID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequest", "common.Person"                  
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

       Public Const TABLE_NAME As String = "accounting.CashRequest"
       Public Const CashRequest__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM CashRequest"
       Public Const CashRequest__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [Request], [ExpenditureCategoryID], [Amount], [Deadline], [CreatedAt], [CreatedByID], [BeneficiaryID], [TrackingID], [DataMonitorID] FROM CashRequest"


       Public Enum TableColumnNames

           [ID]
           [Request]
           [ExpenditureCategoryID]
           [Amount]
           [Deadline]
           [CreatedAt]
           [CreatedByID]
           [BeneficiaryID]
           [TrackingID]
           [DataMonitorID]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_CashRequest 
           fk_accounting_CashRequest_DataMonitorID 
           fk_accounting_CashRequest_ExpenditureCategoryID 
           fk_accounting_CashRequest_CreatedByID 
           fk_accounting_CashRequest_BeneficiaryID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defRequest As DataColumnDefinition
       Public Shared ReadOnly defExpenditureCategoryID As DataColumnDefinition
       Public Shared ReadOnly defAmount As DataColumnDefinition
       Public Shared ReadOnly defDeadline As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defBeneficiaryID As DataColumnDefinition
       Public Shared ReadOnly defTrackingID As DataColumnDefinition
       Public Shared ReadOnly defDataMonitorID As DataColumnDefinition

       Public ReadOnly Property [Request] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Request.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExpenditureCategoryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ExpenditureCategoryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Amount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Amount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Deadline] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.Deadline.ToString()))
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


       Public ReadOnly Property [BeneficiaryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BeneficiaryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TrackingID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TrackingID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DataMonitorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DataMonitorID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___CashRequest                  
            If Me.hasRows() Then Return New T___CashRequest(Me.AllRows(0))                  
            Return New T___CashRequest()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___CashRequest                  
            Return New T___CashRequest(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___CashRequest                  
            Return New T___CashRequest(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___CashRequest                  
            Return New T___CashRequest(Me.RawTable, T___CashRequest.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___CashRequest,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___CashRequest,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___CashRequest                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___CashRequest(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CashRequest(drst.CopyToDataTable(),                  
                    T___CashRequest.TABLE_NAME)                  
                Return New T___CashRequest()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___CashRequest()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___CashRequest                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___CashRequest(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CashRequest(drst.CopyToDataTable(),                  
                    T___CashRequest.TABLE_NAME)                  
                Return New T___CashRequest()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___CashRequest()                  
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
            Return CashRequest__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pExpenditureCategoryID As Int32,
ByVal pCreatedByID As Int32,
ByVal pBeneficiaryID As Int32,
ByVal pDataMonitorID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramExpenditureCategoryID As DataColumnParameter = New DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, defRequest.DefaultValue)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, defAmount.DefaultValue)
 Dim paramDeadline As DataColumnParameter = New DataColumnParameter(defDeadline, defDeadline.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramTrackingID As DataColumnParameter = New DataColumnParameter(defTrackingID, defTrackingID.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pRequest As String,
ByVal pExpenditureCategoryID As Int32,
ByVal pAmount As Decimal,
ByVal pDeadline As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pBeneficiaryID As Int32,
Optional ByVal pTrackingID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramExpenditureCategoryID As DataColumnParameter = New DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramDeadline As DataColumnParameter = New DataColumnParameter(defDeadline, pDeadline)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramTrackingID As DataColumnParameter = New DataColumnParameter(defTrackingID, pTrackingID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pRequest As String,
ByVal pExpenditureCategoryID As Int32,
ByVal pAmount As Decimal,
ByVal pDeadline As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pBeneficiaryID As Int32,
Optional ByVal pTrackingID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramExpenditureCategoryID As DataColumnParameter = New DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramDeadline As DataColumnParameter = New DataColumnParameter(defDeadline, pDeadline)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramTrackingID As DataColumnParameter = New DataColumnParameter(defTrackingID, pTrackingID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pRequest As String,
ByVal pExpenditureCategoryID As Int32,
ByVal pAmount As Decimal,
ByVal pDeadline As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pBeneficiaryID As Int32,
Optional ByVal pTrackingID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramExpenditureCategoryID As DataColumnParameter = New DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramDeadline As DataColumnParameter = New DataColumnParameter(defDeadline, pDeadline)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramTrackingID As DataColumnParameter = New DataColumnParameter(defTrackingID, pTrackingID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([Request],[ExpenditureCategoryID],[Amount],[Deadline],[CreatedAt],[CreatedByID],[BeneficiaryID],[TrackingID],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramRequest.getSQLQuotedValueForAdd(),
paramExpenditureCategoryID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramDeadline.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramTrackingID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pRequest As Object=Nothing,
Optional ByVal pExpenditureCategoryID As Object=Nothing,
Optional ByVal pAmount As Object=Nothing,
Optional ByVal pDeadline As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pBeneficiaryID As Object=Nothing,
Optional ByVal pTrackingID As Object=Nothing,
Optional ByVal pDataMonitorID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramExpenditureCategoryID As DataColumnParameter = New DataColumnParameter(defExpenditureCategoryID, pExpenditureCategoryID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramDeadline As DataColumnParameter = New DataColumnParameter(defDeadline, pDeadline)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramTrackingID As DataColumnParameter = New DataColumnParameter(defTrackingID, pTrackingID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [Request]={2},[ExpenditureCategoryID]={3},[Amount]={4},[Deadline]={5},[CreatedAt]={6},[CreatedByID]={7},[BeneficiaryID]={8},[TrackingID]={9},[DataMonitorID]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramRequest.getSQLQuotedValueForUpdate(),
paramExpenditureCategoryID.getSQLQuotedValueForUpdate(),
paramAmount.getSQLQuotedValueForUpdate(),
paramDeadline.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramBeneficiaryID.getSQLQuotedValueForUpdate(),
paramTrackingID.getSQLQuotedValueForUpdate(),
paramDataMonitorID.getSQLQuotedValueForUpdate()  ), True)


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
