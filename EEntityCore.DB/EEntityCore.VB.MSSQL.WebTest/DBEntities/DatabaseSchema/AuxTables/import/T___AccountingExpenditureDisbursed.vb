Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.import

Public Class T___AccountingExpenditureDisbursed
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defDataMonitorID = New DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defImportStatusID = New DataColumnDefinition(TableColumnNames.ImportStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defRequest = New DataColumnDefinition(TableColumnNames.Request.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDisbursedDate = New DataColumnDefinition(TableColumnNames.DisbursedDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCategory = New DataColumnDefinition(TableColumnNames.Category.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBeneficiary = New DataColumnDefinition(TableColumnNames.Beneficiary.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defNotes = New DataColumnDefinition(TableColumnNames.Notes.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotal = New DataColumnDefinition(TableColumnNames.Total.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defImportComment = New DataColumnDefinition(TableColumnNames.ImportComment.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID) 
  ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID) 
  ColumnDefns.Add(defRequest.ColumnName, defRequest) 
  ColumnDefns.Add(defDisbursedDate.ColumnName, defDisbursedDate) 
  ColumnDefns.Add(defCategory.ColumnName, defCategory) 
  ColumnDefns.Add(defBeneficiary.ColumnName, defBeneficiary) 
  ColumnDefns.Add(defNotes.ColumnName, defNotes) 
  ColumnDefns.Add(defTotal.ColumnName, defTotal) 
  ColumnDefns.Add(defImportComment.ColumnName, defImportComment) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_DataMonitorID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.AccountingExpenditureDisbursed", "import.DataMonitor"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_AccountingExpenditureDisbursed_ImportStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.AccountingExpenditureDisbursed", "import.ImportStatus"                  
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

       Public Const TABLE_NAME As String = "import.AccountingExpenditureDisbursed"
       Public Const AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed"
       Public Const AccountingExpenditureDisbursed__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [DataMonitorID], [ImportStatusID], [Request], [DisbursedDate], [Category], [Beneficiary], [Notes], [Total], [ImportComment], [CreatedAt] FROM AccountingExpenditureDisbursed"


       Public Enum TableColumnNames

           [ID]
           [DataMonitorID]
           [ImportStatusID]
           [Request]
           [DisbursedDate]
           [Category]
           [Beneficiary]
           [Notes]
           [Total]
           [ImportComment]
           [CreatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_import_AccountingExpenditureDisbursed 
           fk_import_AccountingExpenditureDisbursed_DataMonitorID 
           fk_import_AccountingExpenditureDisbursed_ImportStatusID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defDataMonitorID As DataColumnDefinition
       Public Shared ReadOnly defImportStatusID As DataColumnDefinition
       Public Shared ReadOnly defRequest As DataColumnDefinition
       Public Shared ReadOnly defDisbursedDate As DataColumnDefinition
       Public Shared ReadOnly defCategory As DataColumnDefinition
       Public Shared ReadOnly defBeneficiary As DataColumnDefinition
       Public Shared ReadOnly defNotes As DataColumnDefinition
       Public Shared ReadOnly defTotal As DataColumnDefinition
       Public Shared ReadOnly defImportComment As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition

       Public ReadOnly Property [DataMonitorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DataMonitorID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ImportStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ImportStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Request] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Request.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DisbursedDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.DisbursedDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Category] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Category.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Beneficiary] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Beneficiary.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Notes] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Notes.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Total] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Total.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ImportComment] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ImportComment.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___AccountingExpenditureDisbursed                  
            If Me.hasRows() Then Return New T___AccountingExpenditureDisbursed(Me.AllRows(0))                  
            Return New T___AccountingExpenditureDisbursed()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___AccountingExpenditureDisbursed                  
            Return New T___AccountingExpenditureDisbursed(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___AccountingExpenditureDisbursed                  
            Return New T___AccountingExpenditureDisbursed(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___AccountingExpenditureDisbursed                  
            Return New T___AccountingExpenditureDisbursed(Me.RawTable, T___AccountingExpenditureDisbursed.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___AccountingExpenditureDisbursed,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___AccountingExpenditureDisbursed,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___AccountingExpenditureDisbursed                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___AccountingExpenditureDisbursed(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___AccountingExpenditureDisbursed(drst.CopyToDataTable(),                  
                    T___AccountingExpenditureDisbursed.TABLE_NAME)                  
                Return New T___AccountingExpenditureDisbursed()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___AccountingExpenditureDisbursed()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___AccountingExpenditureDisbursed                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___AccountingExpenditureDisbursed(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___AccountingExpenditureDisbursed(drst.CopyToDataTable(),                  
                    T___AccountingExpenditureDisbursed.TABLE_NAME)                  
                Return New T___AccountingExpenditureDisbursed()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___AccountingExpenditureDisbursed()                  
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
            Return AccountingExpenditureDisbursed__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, defRequest.DefaultValue)
 Dim paramDisbursedDate As DataColumnParameter = New DataColumnParameter(defDisbursedDate, defDisbursedDate.DefaultValue)
 Dim paramCategory As DataColumnParameter = New DataColumnParameter(defCategory, defCategory.DefaultValue)
 Dim paramBeneficiary As DataColumnParameter = New DataColumnParameter(defBeneficiary, defBeneficiary.DefaultValue)
 Dim paramNotes As DataColumnParameter = New DataColumnParameter(defNotes, defNotes.DefaultValue)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, defTotal.DefaultValue)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, defImportComment.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pRequest As String,
ByVal pDisbursedDate As DateTime,
ByVal pCategory As String,
ByVal pBeneficiary As String,
ByVal pTotal As Decimal,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pNotes As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramDisbursedDate As DataColumnParameter = New DataColumnParameter(defDisbursedDate, pDisbursedDate)
 Dim paramCategory As DataColumnParameter = New DataColumnParameter(defCategory, pCategory)
 Dim paramBeneficiary As DataColumnParameter = New DataColumnParameter(defBeneficiary, pBeneficiary)
 Dim paramNotes As DataColumnParameter = New DataColumnParameter(defNotes, pNotes)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pRequest As String,
ByVal pDisbursedDate As DateTime,
ByVal pCategory As String,
ByVal pBeneficiary As String,
ByVal pTotal As Decimal,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pNotes As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramDisbursedDate As DataColumnParameter = New DataColumnParameter(defDisbursedDate, pDisbursedDate)
 Dim paramCategory As DataColumnParameter = New DataColumnParameter(defCategory, pCategory)
 Dim paramBeneficiary As DataColumnParameter = New DataColumnParameter(defBeneficiary, pBeneficiary)
 Dim paramNotes As DataColumnParameter = New DataColumnParameter(defNotes, pNotes)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pRequest As String,
ByVal pDisbursedDate As DateTime,
ByVal pCategory As String,
ByVal pBeneficiary As String,
ByVal pTotal As Decimal,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pNotes As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramDisbursedDate As DataColumnParameter = New DataColumnParameter(defDisbursedDate, pDisbursedDate)
 Dim paramCategory As DataColumnParameter = New DataColumnParameter(defCategory, pCategory)
 Dim paramBeneficiary As DataColumnParameter = New DataColumnParameter(defBeneficiary, pBeneficiary)
 Dim paramNotes As DataColumnParameter = New DataColumnParameter(defNotes, pNotes)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([DataMonitorID],[ImportStatusID],[Request],[DisbursedDate],[Category],[Beneficiary],[Notes],[Total],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramRequest.getSQLQuotedValueForAdd(),
paramDisbursedDate.getSQLQuotedValueForAdd(),
paramCategory.getSQLQuotedValueForAdd(),
paramBeneficiary.getSQLQuotedValueForAdd(),
paramNotes.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pDataMonitorID As Object=Nothing,
Optional ByVal pImportStatusID As Object=Nothing,
Optional ByVal pRequest As Object=Nothing,
Optional ByVal pDisbursedDate As Object=Nothing,
Optional ByVal pCategory As Object=Nothing,
Optional ByVal pBeneficiary As Object=Nothing,
Optional ByVal pTotal As Object=Nothing,
Optional ByVal pImportComment As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pNotes As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramRequest As DataColumnParameter = New DataColumnParameter(defRequest, pRequest)
 Dim paramDisbursedDate As DataColumnParameter = New DataColumnParameter(defDisbursedDate, pDisbursedDate)
 Dim paramCategory As DataColumnParameter = New DataColumnParameter(defCategory, pCategory)
 Dim paramBeneficiary As DataColumnParameter = New DataColumnParameter(defBeneficiary, pBeneficiary)
 Dim paramNotes As DataColumnParameter = New DataColumnParameter(defNotes, pNotes)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [DataMonitorID]={2},[ImportStatusID]={3},[Request]={4},[DisbursedDate]={5},[Category]={6},[Beneficiary]={7},[Notes]={8},[Total]={9},[ImportComment]={10},[CreatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramDataMonitorID.getSQLQuotedValueForUpdate(),
paramImportStatusID.getSQLQuotedValueForUpdate(),
paramRequest.getSQLQuotedValueForUpdate(),
paramDisbursedDate.getSQLQuotedValueForUpdate(),
paramCategory.getSQLQuotedValueForUpdate(),
paramBeneficiary.getSQLQuotedValueForUpdate(),
paramNotes.getSQLQuotedValueForUpdate(),
paramTotal.getSQLQuotedValueForUpdate(),
paramImportComment.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate()  ), True)


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
