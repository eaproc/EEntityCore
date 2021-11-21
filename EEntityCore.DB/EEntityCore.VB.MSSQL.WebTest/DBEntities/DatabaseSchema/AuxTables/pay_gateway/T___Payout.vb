Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.pay_gateway

Public Class T___Payout
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defPaidInAmount = New DataColumnDefinition(TableColumnNames.PaidInAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaidInCharges = New DataColumnDefinition(TableColumnNames.PaidInCharges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPayoutAmount = New DataColumnDefinition(TableColumnNames.PayoutAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPayoutCharge = New DataColumnDefinition(TableColumnNames.PayoutCharge.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBalance = New DataColumnDefinition(TableColumnNames.Balance.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTransactionStartDate = New DataColumnDefinition(TableColumnNames.TransactionStartDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTransactionEndDate = New DataColumnDefinition(TableColumnNames.TransactionEndDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAwaitingPayout = New DataColumnDefinition(TableColumnNames.AwaitingPayout.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSynced = New DataColumnDefinition(TableColumnNames.Synced.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAccountName = New DataColumnDefinition(TableColumnNames.AccountName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defPaidInAmount.ColumnName, defPaidInAmount) 
  ColumnDefns.Add(defPaidInCharges.ColumnName, defPaidInCharges) 
  ColumnDefns.Add(defPayoutAmount.ColumnName, defPayoutAmount) 
  ColumnDefns.Add(defPayoutCharge.ColumnName, defPayoutCharge) 
  ColumnDefns.Add(defBalance.ColumnName, defBalance) 
  ColumnDefns.Add(defTransactionStartDate.ColumnName, defTransactionStartDate) 
  ColumnDefns.Add(defTransactionEndDate.ColumnName, defTransactionEndDate) 
  ColumnDefns.Add(defAwaitingPayout.ColumnName, defAwaitingPayout) 
  ColumnDefns.Add(defSynced.ColumnName, defSynced) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defAccountName.ColumnName, defAccountName) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_Payout_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "hr.Client"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.Payout", "common.Bank"                  
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

       Public Const TABLE_NAME As String = "pay_gateway.Payout"
       Public Const Payout__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM Payout"
       Public Const Payout__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CreatedByID], [UpdatedByID], [ClientID], [PaidInAmount], [PaidInCharges], [PayoutAmount], [PayoutCharge], [Balance], [TransactionStartDate], [TransactionEndDate], [AwaitingPayout], [Synced], [CreatedAt], [UpdatedAt], [BankID], [AccountName], [AccountNumber] FROM Payout"


       Public Enum TableColumnNames

           [ID]
           [CreatedByID]
           [UpdatedByID]
           [ClientID]
           [PaidInAmount]
           [PaidInCharges]
           [PayoutAmount]
           [PayoutCharge]
           [Balance]
           [TransactionStartDate]
           [TransactionEndDate]
           [AwaitingPayout]
           [Synced]
           [CreatedAt]
           [UpdatedAt]
           [BankID]
           [AccountName]
           [AccountNumber]
       End Enum 



       Public Enum TableConstraints

           pk_pay_gateway_Payout 
           fk_pay_gateway_Payout_CreatedByID 
           fk_pay_gateway_Payout_UpdatedByID 
           fk_pay_gateway_Payout_ClientID 
           fk_hr_Client_BankID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defPaidInAmount As DataColumnDefinition
       Public Shared ReadOnly defPaidInCharges As DataColumnDefinition
       Public Shared ReadOnly defPayoutAmount As DataColumnDefinition
       Public Shared ReadOnly defPayoutCharge As DataColumnDefinition
       Public Shared ReadOnly defBalance As DataColumnDefinition
       Public Shared ReadOnly defTransactionStartDate As DataColumnDefinition
       Public Shared ReadOnly defTransactionEndDate As DataColumnDefinition
       Public Shared ReadOnly defAwaitingPayout As DataColumnDefinition
       Public Shared ReadOnly defSynced As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defAccountName As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition

       Public ReadOnly Property [CreatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CreatedByID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UpdatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UpdatedByID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaidInAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PaidInAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PaidInCharges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PaidInCharges.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PayoutAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PayoutAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PayoutCharge] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PayoutCharge.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Balance] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Balance.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [TransactionStartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TransactionStartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TransactionEndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TransactionEndDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AwaitingPayout] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.AwaitingPayout.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Synced] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.Synced.ToString()))
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


       Public ReadOnly Property [BankID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BankID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountNumber.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Payout                  
            If Me.hasRows() Then Return New T___Payout(Me.AllRows(0))                  
            Return New T___Payout()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Payout                  
            Return New T___Payout(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Payout                  
            Return New T___Payout(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Payout                  
            Return New T___Payout(Me.RawTable, T___Payout.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Payout,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Payout,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Payout                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Payout(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Payout(drst.CopyToDataTable(),                  
                    T___Payout.TABLE_NAME)                  
                Return New T___Payout()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Payout()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Payout                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Payout(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Payout(drst.CopyToDataTable(),                  
                    T___Payout.TABLE_NAME)                  
                Return New T___Payout()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Payout()                  
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
            Return Payout__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
ByVal pClientID As Int32,
ByVal pBankID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramPaidInAmount As DataColumnParameter = New DataColumnParameter(defPaidInAmount, defPaidInAmount.DefaultValue)
 Dim paramPaidInCharges As DataColumnParameter = New DataColumnParameter(defPaidInCharges, defPaidInCharges.DefaultValue)
 Dim paramPayoutAmount As DataColumnParameter = New DataColumnParameter(defPayoutAmount, defPayoutAmount.DefaultValue)
 Dim paramPayoutCharge As DataColumnParameter = New DataColumnParameter(defPayoutCharge, defPayoutCharge.DefaultValue)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, defBalance.DefaultValue)
 Dim paramTransactionStartDate As DataColumnParameter = New DataColumnParameter(defTransactionStartDate, defTransactionStartDate.DefaultValue)
 Dim paramTransactionEndDate As DataColumnParameter = New DataColumnParameter(defTransactionEndDate, defTransactionEndDate.DefaultValue)
 Dim paramAwaitingPayout As DataColumnParameter = New DataColumnParameter(defAwaitingPayout, defAwaitingPayout.DefaultValue)
 Dim paramSynced As DataColumnParameter = New DataColumnParameter(defSynced, defSynced.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, defAccountName.DefaultValue)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramPaidInAmount.getSQLQuotedValueForAdd(),
paramPaidInCharges.getSQLQuotedValueForAdd(),
paramPayoutAmount.getSQLQuotedValueForAdd(),
paramPayoutCharge.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramTransactionStartDate.getSQLQuotedValueForAdd(),
paramTransactionEndDate.getSQLQuotedValueForAdd(),
paramAwaitingPayout.getSQLQuotedValueForAdd(),
paramSynced.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pCreatedByID As Int32,
ByVal pClientID As Int32,
ByVal pPaidInAmount As Decimal,
ByVal pPaidInCharges As Decimal,
ByVal pPayoutAmount As Decimal,
ByVal pPayoutCharge As Decimal,
ByVal pBalance As Decimal,
ByVal pTransactionStartDate As DateTime,
ByVal pTransactionEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingPayout As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSynced As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramPaidInAmount As DataColumnParameter = New DataColumnParameter(defPaidInAmount, pPaidInAmount)
 Dim paramPaidInCharges As DataColumnParameter = New DataColumnParameter(defPaidInCharges, pPaidInCharges)
 Dim paramPayoutAmount As DataColumnParameter = New DataColumnParameter(defPayoutAmount, pPayoutAmount)
 Dim paramPayoutCharge As DataColumnParameter = New DataColumnParameter(defPayoutCharge, pPayoutCharge)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramTransactionStartDate As DataColumnParameter = New DataColumnParameter(defTransactionStartDate, pTransactionStartDate)
 Dim paramTransactionEndDate As DataColumnParameter = New DataColumnParameter(defTransactionEndDate, pTransactionEndDate)
 Dim paramAwaitingPayout As DataColumnParameter = New DataColumnParameter(defAwaitingPayout, pAwaitingPayout)
 Dim paramSynced As DataColumnParameter = New DataColumnParameter(defSynced, pSynced)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramPaidInAmount.getSQLQuotedValueForAdd(),
paramPaidInCharges.getSQLQuotedValueForAdd(),
paramPayoutAmount.getSQLQuotedValueForAdd(),
paramPayoutCharge.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramTransactionStartDate.getSQLQuotedValueForAdd(),
paramTransactionEndDate.getSQLQuotedValueForAdd(),
paramAwaitingPayout.getSQLQuotedValueForAdd(),
paramSynced.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pCreatedByID As Int32,
ByVal pClientID As Int32,
ByVal pPaidInAmount As Decimal,
ByVal pPaidInCharges As Decimal,
ByVal pPayoutAmount As Decimal,
ByVal pPayoutCharge As Decimal,
ByVal pBalance As Decimal,
ByVal pTransactionStartDate As DateTime,
ByVal pTransactionEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingPayout As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSynced As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramPaidInAmount As DataColumnParameter = New DataColumnParameter(defPaidInAmount, pPaidInAmount)
 Dim paramPaidInCharges As DataColumnParameter = New DataColumnParameter(defPaidInCharges, pPaidInCharges)
 Dim paramPayoutAmount As DataColumnParameter = New DataColumnParameter(defPayoutAmount, pPayoutAmount)
 Dim paramPayoutCharge As DataColumnParameter = New DataColumnParameter(defPayoutCharge, pPayoutCharge)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramTransactionStartDate As DataColumnParameter = New DataColumnParameter(defTransactionStartDate, pTransactionStartDate)
 Dim paramTransactionEndDate As DataColumnParameter = New DataColumnParameter(defTransactionEndDate, pTransactionEndDate)
 Dim paramAwaitingPayout As DataColumnParameter = New DataColumnParameter(defAwaitingPayout, pAwaitingPayout)
 Dim paramSynced As DataColumnParameter = New DataColumnParameter(defSynced, pSynced)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramPaidInAmount.getSQLQuotedValueForAdd(),
paramPaidInCharges.getSQLQuotedValueForAdd(),
paramPayoutAmount.getSQLQuotedValueForAdd(),
paramPayoutCharge.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramTransactionStartDate.getSQLQuotedValueForAdd(),
paramTransactionEndDate.getSQLQuotedValueForAdd(),
paramAwaitingPayout.getSQLQuotedValueForAdd(),
paramSynced.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pCreatedByID As Int32,
ByVal pClientID As Int32,
ByVal pPaidInAmount As Decimal,
ByVal pPaidInCharges As Decimal,
ByVal pPayoutAmount As Decimal,
ByVal pPayoutCharge As Decimal,
ByVal pBalance As Decimal,
ByVal pTransactionStartDate As DateTime,
ByVal pTransactionEndDate As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingPayout As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSynced As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramPaidInAmount As DataColumnParameter = New DataColumnParameter(defPaidInAmount, pPaidInAmount)
 Dim paramPaidInCharges As DataColumnParameter = New DataColumnParameter(defPaidInCharges, pPaidInCharges)
 Dim paramPayoutAmount As DataColumnParameter = New DataColumnParameter(defPayoutAmount, pPayoutAmount)
 Dim paramPayoutCharge As DataColumnParameter = New DataColumnParameter(defPayoutCharge, pPayoutCharge)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramTransactionStartDate As DataColumnParameter = New DataColumnParameter(defTransactionStartDate, pTransactionStartDate)
 Dim paramTransactionEndDate As DataColumnParameter = New DataColumnParameter(defTransactionEndDate, pTransactionEndDate)
 Dim paramAwaitingPayout As DataColumnParameter = New DataColumnParameter(defAwaitingPayout, pAwaitingPayout)
 Dim paramSynced As DataColumnParameter = New DataColumnParameter(defSynced, pSynced)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([CreatedByID],[UpdatedByID],[ClientID],[PaidInAmount],[PaidInCharges],[PayoutAmount],[PayoutCharge],[Balance],[TransactionStartDate],[TransactionEndDate],[AwaitingPayout],[Synced],[CreatedAt],[UpdatedAt],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) ", TABLE_NAME,paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramPaidInAmount.getSQLQuotedValueForAdd(),
paramPaidInCharges.getSQLQuotedValueForAdd(),
paramPayoutAmount.getSQLQuotedValueForAdd(),
paramPayoutCharge.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramTransactionStartDate.getSQLQuotedValueForAdd(),
paramTransactionEndDate.getSQLQuotedValueForAdd(),
paramAwaitingPayout.getSQLQuotedValueForAdd(),
paramSynced.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pClientID As Object=Nothing,
Optional ByVal pPaidInAmount As Object=Nothing,
Optional ByVal pPaidInCharges As Object=Nothing,
Optional ByVal pPayoutAmount As Object=Nothing,
Optional ByVal pPayoutCharge As Object=Nothing,
Optional ByVal pBalance As Object=Nothing,
Optional ByVal pTransactionStartDate As Object=Nothing,
Optional ByVal pTransactionEndDate As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pBankID As Object=Nothing,
Optional ByVal pAccountName As Object=Nothing,
Optional ByVal pAccountNumber As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pAwaitingPayout As Object=Nothing,
Optional ByVal pSynced As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramPaidInAmount As DataColumnParameter = New DataColumnParameter(defPaidInAmount, pPaidInAmount)
 Dim paramPaidInCharges As DataColumnParameter = New DataColumnParameter(defPaidInCharges, pPaidInCharges)
 Dim paramPayoutAmount As DataColumnParameter = New DataColumnParameter(defPayoutAmount, pPayoutAmount)
 Dim paramPayoutCharge As DataColumnParameter = New DataColumnParameter(defPayoutCharge, pPayoutCharge)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramTransactionStartDate As DataColumnParameter = New DataColumnParameter(defTransactionStartDate, pTransactionStartDate)
 Dim paramTransactionEndDate As DataColumnParameter = New DataColumnParameter(defTransactionEndDate, pTransactionEndDate)
 Dim paramAwaitingPayout As DataColumnParameter = New DataColumnParameter(defAwaitingPayout, pAwaitingPayout)
 Dim paramSynced As DataColumnParameter = New DataColumnParameter(defSynced, pSynced)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [CreatedByID]={2},[UpdatedByID]={3},[ClientID]={4},[PaidInAmount]={5},[PaidInCharges]={6},[PayoutAmount]={7},[PayoutCharge]={8},[Balance]={9},[TransactionStartDate]={10},[TransactionEndDate]={11},[AwaitingPayout]={12},[Synced]={13},[CreatedAt]={14},[UpdatedAt]={15},[BankID]={16},[AccountName]={17},[AccountNumber]={18} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
paramClientID.getSQLQuotedValueForUpdate(),
paramPaidInAmount.getSQLQuotedValueForUpdate(),
paramPaidInCharges.getSQLQuotedValueForUpdate(),
paramPayoutAmount.getSQLQuotedValueForUpdate(),
paramPayoutCharge.getSQLQuotedValueForUpdate(),
paramBalance.getSQLQuotedValueForUpdate(),
paramTransactionStartDate.getSQLQuotedValueForUpdate(),
paramTransactionEndDate.getSQLQuotedValueForUpdate(),
paramAwaitingPayout.getSQLQuotedValueForUpdate(),
paramSynced.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramBankID.getSQLQuotedValueForUpdate(),
paramAccountName.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate()  ), True)


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
