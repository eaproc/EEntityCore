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

Public Class T___CashRequestProceeding
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defTitle = New DataColumnDefinition(TableColumnNames.Title.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCashRequestID = New DataColumnDefinition(TableColumnNames.CashRequestID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCashRequestStatusID = New DataColumnDefinition(TableColumnNames.CashRequestStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defRevisedAmount = New DataColumnDefinition(TableColumnNames.RevisedAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defComments = New DataColumnDefinition(TableColumnNames.Comments.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDocumentFileName = New DataColumnDefinition(TableColumnNames.DocumentFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defTitle.ColumnName, defTitle) 
  ColumnDefns.Add(defCashRequestID.ColumnName, defCashRequestID) 
  ColumnDefns.Add(defCashRequestStatusID.ColumnName, defCashRequestStatusID) 
  ColumnDefns.Add(defRevisedAmount.ColumnName, defRevisedAmount) 
  ColumnDefns.Add(defComments.ColumnName, defComments) 
  ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequestStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.CashRequestProceeding", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_CashRequestProceeding_CashRequestID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.CashRequestProceeding", "accounting.CashRequest"                  
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

       Public Const TABLE_NAME As String = "accounting.CashRequestProceeding"
       Public Const CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM CashRequestProceeding"
       Public Const CashRequestProceeding__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [Title], [CashRequestID], [CashRequestStatusID], [RevisedAmount], [Comments], [DocumentFileName], [CreatedAt], [CreatedByID] FROM CashRequestProceeding"


       Public Enum TableColumnNames

           [ID]
           [Title]
           [CashRequestID]
           [CashRequestStatusID]
           [RevisedAmount]
           [Comments]
           [DocumentFileName]
           [CreatedAt]
           [CreatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_CashRequestProceeding 
           fk_accounting_CashRequestProceeding_CashRequestStatusID 
           fk_accounting_CashRequestProceeding_CreatedByID 
           fk_accounting_CashRequestProceeding_CashRequestID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defTitle As DataColumnDefinition
       Public Shared ReadOnly defCashRequestID As DataColumnDefinition
       Public Shared ReadOnly defCashRequestStatusID As DataColumnDefinition
       Public Shared ReadOnly defRevisedAmount As DataColumnDefinition
       Public Shared ReadOnly defComments As DataColumnDefinition
       Public Shared ReadOnly defDocumentFileName As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition

       Public ReadOnly Property [Title] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Title.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CashRequestID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CashRequestID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CashRequestStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CashRequestStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RevisedAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.RevisedAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Comments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Comments.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DocumentFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DocumentFileName.ToString()))
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


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___CashRequestProceeding                  
            If Me.hasRows() Then Return New T___CashRequestProceeding(Me.AllRows(0))                  
            Return New T___CashRequestProceeding()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___CashRequestProceeding                  
            Return New T___CashRequestProceeding(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___CashRequestProceeding                  
            Return New T___CashRequestProceeding(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___CashRequestProceeding                  
            Return New T___CashRequestProceeding(Me.RawTable, T___CashRequestProceeding.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___CashRequestProceeding,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___CashRequestProceeding,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___CashRequestProceeding                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___CashRequestProceeding(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CashRequestProceeding(drst.CopyToDataTable(),                  
                    T___CashRequestProceeding.TABLE_NAME)                  
                Return New T___CashRequestProceeding()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___CashRequestProceeding()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___CashRequestProceeding                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___CashRequestProceeding(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CashRequestProceeding(drst.CopyToDataTable(),                  
                    T___CashRequestProceeding.TABLE_NAME)                  
                Return New T___CashRequestProceeding()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___CashRequestProceeding()                  
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
            Return CashRequestProceeding__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCashRequestID As Int32,
ByVal pCashRequestStatusID As Int32,
ByVal pCreatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramCashRequestID As DataColumnParameter = New DataColumnParameter(defCashRequestID, pCashRequestID)
 Dim paramCashRequestStatusID As DataColumnParameter = New DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, defTitle.DefaultValue)
 Dim paramRevisedAmount As DataColumnParameter = New DataColumnParameter(defRevisedAmount, defRevisedAmount.DefaultValue)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, defComments.DefaultValue)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, defDocumentFileName.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramCashRequestID.getSQLQuotedValueForAdd(),
paramCashRequestStatusID.getSQLQuotedValueForAdd(),
paramRevisedAmount.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pTitle As String,
ByVal pCashRequestID As Int32,
ByVal pCashRequestStatusID As Int32,
ByVal pRevisedAmount As Decimal,
ByVal pComments As String,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramCashRequestID As DataColumnParameter = New DataColumnParameter(defCashRequestID, pCashRequestID)
 Dim paramCashRequestStatusID As DataColumnParameter = New DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID)
 Dim paramRevisedAmount As DataColumnParameter = New DataColumnParameter(defRevisedAmount, pRevisedAmount)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramCashRequestID.getSQLQuotedValueForAdd(),
paramCashRequestStatusID.getSQLQuotedValueForAdd(),
paramRevisedAmount.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pTitle As String,
ByVal pCashRequestID As Int32,
ByVal pCashRequestStatusID As Int32,
ByVal pRevisedAmount As Decimal,
ByVal pComments As String,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramCashRequestID As DataColumnParameter = New DataColumnParameter(defCashRequestID, pCashRequestID)
 Dim paramCashRequestStatusID As DataColumnParameter = New DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID)
 Dim paramRevisedAmount As DataColumnParameter = New DataColumnParameter(defRevisedAmount, pRevisedAmount)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramCashRequestID.getSQLQuotedValueForAdd(),
paramCashRequestStatusID.getSQLQuotedValueForAdd(),
paramRevisedAmount.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pTitle As String,
ByVal pCashRequestID As Int32,
ByVal pCashRequestStatusID As Int32,
ByVal pRevisedAmount As Decimal,
ByVal pComments As String,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramCashRequestID As DataColumnParameter = New DataColumnParameter(defCashRequestID, pCashRequestID)
 Dim paramCashRequestStatusID As DataColumnParameter = New DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID)
 Dim paramRevisedAmount As DataColumnParameter = New DataColumnParameter(defRevisedAmount, pRevisedAmount)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([Title],[CashRequestID],[CashRequestStatusID],[RevisedAmount],[Comments],[DocumentFileName],[CreatedAt],[CreatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramTitle.getSQLQuotedValueForAdd(),
paramCashRequestID.getSQLQuotedValueForAdd(),
paramCashRequestStatusID.getSQLQuotedValueForAdd(),
paramRevisedAmount.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pTitle As Object=Nothing,
Optional ByVal pCashRequestID As Object=Nothing,
Optional ByVal pCashRequestStatusID As Object=Nothing,
Optional ByVal pRevisedAmount As Object=Nothing,
Optional ByVal pComments As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pDocumentFileName As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramCashRequestID As DataColumnParameter = New DataColumnParameter(defCashRequestID, pCashRequestID)
 Dim paramCashRequestStatusID As DataColumnParameter = New DataColumnParameter(defCashRequestStatusID, pCashRequestStatusID)
 Dim paramRevisedAmount As DataColumnParameter = New DataColumnParameter(defRevisedAmount, pRevisedAmount)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [Title]={2},[CashRequestID]={3},[CashRequestStatusID]={4},[RevisedAmount]={5},[Comments]={6},[DocumentFileName]={7},[CreatedAt]={8},[CreatedByID]={9} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramTitle.getSQLQuotedValueForUpdate(),
paramCashRequestID.getSQLQuotedValueForUpdate(),
paramCashRequestStatusID.getSQLQuotedValueForUpdate(),
paramRevisedAmount.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramDocumentFileName.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate()  ), True)


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
