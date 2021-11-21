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

Public Class T___PaymentTransaction
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defTransactionStatusID = New DataColumnDefinition(TableColumnNames.TransactionStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defStudentNumber = New DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountName = New DataColumnDefinition(TableColumnNames.AccountName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBank = New DataColumnDefinition(TableColumnNames.Bank.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defChannel = New DataColumnDefinition(TableColumnNames.Channel.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIPAddress = New DataColumnDefinition(TableColumnNames.IPAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSchoolDiscountGiven = New DataColumnDefinition(TableColumnNames.SchoolDiscountGiven.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaymentRequired = New DataColumnDefinition(TableColumnNames.PaymentRequired.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCharges = New DataColumnDefinition(TableColumnNames.Charges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRefundAmount = New DataColumnDefinition(TableColumnNames.RefundAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBalance = New DataColumnDefinition(TableColumnNames.Balance.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defConfirmationThreshold = New DataColumnDefinition(TableColumnNames.ConfirmationThreshold.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defConfirmationDate = New DataColumnDefinition(TableColumnNames.ConfirmationDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAwaitingDisbursement = New DataColumnDefinition(TableColumnNames.AwaitingDisbursement.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defConfirmedExplanation = New DataColumnDefinition(TableColumnNames.ConfirmedExplanation.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defChargesBilledToClient = New DataColumnDefinition(TableColumnNames.ChargesBilledToClient.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaymentRequiredWithoutCharges = New DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsMultiTarget = New DataColumnDefinition(TableColumnNames.IsMultiTarget.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defTransactionStatusID.ColumnName, defTransactionStatusID) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defAccountName.ColumnName, defAccountName) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
  ColumnDefns.Add(defBank.ColumnName, defBank) 
  ColumnDefns.Add(defChannel.ColumnName, defChannel) 
  ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress) 
  ColumnDefns.Add(defSchoolDiscountGiven.ColumnName, defSchoolDiscountGiven) 
  ColumnDefns.Add(defPaymentRequired.ColumnName, defPaymentRequired) 
  ColumnDefns.Add(defCharges.ColumnName, defCharges) 
  ColumnDefns.Add(defRefundAmount.ColumnName, defRefundAmount) 
  ColumnDefns.Add(defBalance.ColumnName, defBalance) 
  ColumnDefns.Add(defConfirmationThreshold.ColumnName, defConfirmationThreshold) 
  ColumnDefns.Add(defConfirmationDate.ColumnName, defConfirmationDate) 
  ColumnDefns.Add(defAwaitingDisbursement.ColumnName, defAwaitingDisbursement) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
  ColumnDefns.Add(defConfirmedExplanation.ColumnName, defConfirmedExplanation) 
  ColumnDefns.Add(defChargesBilledToClient.ColumnName, defChargesBilledToClient) 
  ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges) 
  ColumnDefns.Add(defIsMultiTarget.ColumnName, defIsMultiTarget) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_TransactionStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "pay_gateway.TransactionStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_pay_gateway_PaymentTransaction_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "hr.Client"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransaction_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "pay_gateway.PaymentTransaction", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "pay_gateway.PaymentTransaction"
       Public Const PaymentTransaction__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM PaymentTransaction"
       Public Const PaymentTransaction__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [TransactionStatusID], [ClientID], [StudentNumber], [FirstName], [LastName], [AccountName], [AccountNumber], [Bank], [Channel], [IPAddress], [SchoolDiscountGiven], [PaymentRequired], [Charges], [RefundAmount], [Balance], [ConfirmationThreshold], [ConfirmationDate], [AwaitingDisbursement], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID], [ConfirmedExplanation], [ChargesBilledToClient], [PaymentRequiredWithoutCharges], [IsMultiTarget] FROM PaymentTransaction"


       Public Enum TableColumnNames

           [ID]
           [TransactionStatusID]
           [ClientID]
           [StudentNumber]
           [FirstName]
           [LastName]
           [AccountName]
           [AccountNumber]
           [Bank]
           [Channel]
           [IPAddress]
           [SchoolDiscountGiven]
           [PaymentRequired]
           [Charges]
           [RefundAmount]
           [Balance]
           [ConfirmationThreshold]
           [ConfirmationDate]
           [AwaitingDisbursement]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
           [ConfirmedExplanation]
           [ChargesBilledToClient]
           [PaymentRequiredWithoutCharges]
           [IsMultiTarget]
       End Enum 



       Public Enum TableConstraints

           pk_pay_gateway_PaymentTransaction 
           fk_pay_gateway_PaymentTransaction_TransactionStatusID 
           fk_pay_gateway_PaymentTransaction_ClientID 
           fk_PaymentTransaction_CreatedByID 
           fk_PaymentTransaction_UpdatedByID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defTransactionStatusID As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defStudentNumber As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defAccountName As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition
       Public Shared ReadOnly defBank As DataColumnDefinition
       Public Shared ReadOnly defChannel As DataColumnDefinition
       Public Shared ReadOnly defIPAddress As DataColumnDefinition
       Public Shared ReadOnly defSchoolDiscountGiven As DataColumnDefinition
       Public Shared ReadOnly defPaymentRequired As DataColumnDefinition
       Public Shared ReadOnly defCharges As DataColumnDefinition
       Public Shared ReadOnly defRefundAmount As DataColumnDefinition
       Public Shared ReadOnly defBalance As DataColumnDefinition
       Public Shared ReadOnly defConfirmationThreshold As DataColumnDefinition
       Public Shared ReadOnly defConfirmationDate As DataColumnDefinition
       Public Shared ReadOnly defAwaitingDisbursement As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition
       Public Shared ReadOnly defConfirmedExplanation As DataColumnDefinition
       Public Shared ReadOnly defChargesBilledToClient As DataColumnDefinition
       Public Shared ReadOnly defPaymentRequiredWithoutCharges As DataColumnDefinition
       Public Shared ReadOnly defIsMultiTarget As DataColumnDefinition

       Public ReadOnly Property [TransactionStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TransactionStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StudentNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.StudentNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FirstName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FirstName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LastName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.LastName.ToString()))
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


       Public ReadOnly Property [Bank] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Bank.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Channel] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Channel.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IPAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IPAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SchoolDiscountGiven] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SchoolDiscountGiven.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PaymentRequired] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PaymentRequired.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Charges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Charges.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [RefundAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.RefundAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Balance] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Balance.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ConfirmationThreshold] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.ConfirmationThreshold.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ConfirmationDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.ConfirmationDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AwaitingDisbursement] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.AwaitingDisbursement.ToString()))
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


       Public ReadOnly Property [ConfirmedExplanation] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ConfirmedExplanation.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ChargesBilledToClient] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.ChargesBilledToClient.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaymentRequiredWithoutCharges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PaymentRequiredWithoutCharges.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [IsMultiTarget] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsMultiTarget.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___PaymentTransaction                  
            If Me.hasRows() Then Return New T___PaymentTransaction(Me.AllRows(0))                  
            Return New T___PaymentTransaction()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PaymentTransaction                  
            Return New T___PaymentTransaction(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PaymentTransaction                  
            Return New T___PaymentTransaction(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PaymentTransaction                  
            Return New T___PaymentTransaction(Me.RawTable, T___PaymentTransaction.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PaymentTransaction,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PaymentTransaction,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PaymentTransaction                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PaymentTransaction(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaymentTransaction(drst.CopyToDataTable(),                  
                    T___PaymentTransaction.TABLE_NAME)                  
                Return New T___PaymentTransaction()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PaymentTransaction()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PaymentTransaction                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PaymentTransaction(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaymentTransaction(drst.CopyToDataTable(),                  
                    T___PaymentTransaction.TABLE_NAME)                  
                Return New T___PaymentTransaction()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PaymentTransaction()                  
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
            Return PaymentTransaction__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pTransactionStatusID As Int32,
ByVal pClientID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTransactionStatusID As DataColumnParameter = New DataColumnParameter(defTransactionStatusID, pTransactionStatusID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, defStudentNumber.DefaultValue)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, defFirstName.DefaultValue)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, defLastName.DefaultValue)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, defAccountName.DefaultValue)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, defBank.DefaultValue)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, defChannel.DefaultValue)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, defIPAddress.DefaultValue)
 Dim paramSchoolDiscountGiven As DataColumnParameter = New DataColumnParameter(defSchoolDiscountGiven, defSchoolDiscountGiven.DefaultValue)
 Dim paramPaymentRequired As DataColumnParameter = New DataColumnParameter(defPaymentRequired, defPaymentRequired.DefaultValue)
 Dim paramCharges As DataColumnParameter = New DataColumnParameter(defCharges, defCharges.DefaultValue)
 Dim paramRefundAmount As DataColumnParameter = New DataColumnParameter(defRefundAmount, defRefundAmount.DefaultValue)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, defBalance.DefaultValue)
 Dim paramConfirmationThreshold As DataColumnParameter = New DataColumnParameter(defConfirmationThreshold, defConfirmationThreshold.DefaultValue)
 Dim paramConfirmationDate As DataColumnParameter = New DataColumnParameter(defConfirmationDate, defConfirmationDate.DefaultValue)
 Dim paramAwaitingDisbursement As DataColumnParameter = New DataColumnParameter(defAwaitingDisbursement, defAwaitingDisbursement.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramConfirmedExplanation As DataColumnParameter = New DataColumnParameter(defConfirmedExplanation, defConfirmedExplanation.DefaultValue)
 Dim paramChargesBilledToClient As DataColumnParameter = New DataColumnParameter(defChargesBilledToClient, defChargesBilledToClient.DefaultValue)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, defPaymentRequiredWithoutCharges.DefaultValue)
 Dim paramIsMultiTarget As DataColumnParameter = New DataColumnParameter(defIsMultiTarget, defIsMultiTarget.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTransactionStatusID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramSchoolDiscountGiven.getSQLQuotedValueForAdd(),
paramPaymentRequired.getSQLQuotedValueForAdd(),
paramCharges.getSQLQuotedValueForAdd(),
paramRefundAmount.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramConfirmationThreshold.getSQLQuotedValueForAdd(),
paramConfirmationDate.getSQLQuotedValueForAdd(),
paramAwaitingDisbursement.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramConfirmedExplanation.getSQLQuotedValueForAdd(),
paramChargesBilledToClient.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
paramIsMultiTarget.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pTransactionStatusID As Int32,
ByVal pClientID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
ByVal pBank As String,
ByVal pChannel As String,
ByVal pIPAddress As String,
ByVal pSchoolDiscountGiven As Decimal,
ByVal pPaymentRequired As Decimal,
ByVal pCharges As Decimal,
ByVal pRefundAmount As Decimal,
ByVal pBalance As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
ByVal pPaymentRequiredWithoutCharges As Decimal,
Optional ByVal pConfirmationThreshold As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmationDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingDisbursement As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmedExplanation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChargesBilledToClient As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsMultiTarget As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTransactionStatusID As DataColumnParameter = New DataColumnParameter(defTransactionStatusID, pTransactionStatusID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramSchoolDiscountGiven As DataColumnParameter = New DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven)
 Dim paramPaymentRequired As DataColumnParameter = New DataColumnParameter(defPaymentRequired, pPaymentRequired)
 Dim paramCharges As DataColumnParameter = New DataColumnParameter(defCharges, pCharges)
 Dim paramRefundAmount As DataColumnParameter = New DataColumnParameter(defRefundAmount, pRefundAmount)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramConfirmationThreshold As DataColumnParameter = New DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold)
 Dim paramConfirmationDate As DataColumnParameter = New DataColumnParameter(defConfirmationDate, pConfirmationDate)
 Dim paramAwaitingDisbursement As DataColumnParameter = New DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramConfirmedExplanation As DataColumnParameter = New DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation)
 Dim paramChargesBilledToClient As DataColumnParameter = New DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)
 Dim paramIsMultiTarget As DataColumnParameter = New DataColumnParameter(defIsMultiTarget, pIsMultiTarget)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTransactionStatusID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramSchoolDiscountGiven.getSQLQuotedValueForAdd(),
paramPaymentRequired.getSQLQuotedValueForAdd(),
paramCharges.getSQLQuotedValueForAdd(),
paramRefundAmount.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramConfirmationThreshold.getSQLQuotedValueForAdd(),
paramConfirmationDate.getSQLQuotedValueForAdd(),
paramAwaitingDisbursement.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramConfirmedExplanation.getSQLQuotedValueForAdd(),
paramChargesBilledToClient.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
paramIsMultiTarget.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pTransactionStatusID As Int32,
ByVal pClientID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
ByVal pBank As String,
ByVal pChannel As String,
ByVal pIPAddress As String,
ByVal pSchoolDiscountGiven As Decimal,
ByVal pPaymentRequired As Decimal,
ByVal pCharges As Decimal,
ByVal pRefundAmount As Decimal,
ByVal pBalance As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
ByVal pPaymentRequiredWithoutCharges As Decimal,
Optional ByVal pConfirmationThreshold As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmationDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingDisbursement As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmedExplanation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChargesBilledToClient As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsMultiTarget As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramTransactionStatusID As DataColumnParameter = New DataColumnParameter(defTransactionStatusID, pTransactionStatusID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramSchoolDiscountGiven As DataColumnParameter = New DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven)
 Dim paramPaymentRequired As DataColumnParameter = New DataColumnParameter(defPaymentRequired, pPaymentRequired)
 Dim paramCharges As DataColumnParameter = New DataColumnParameter(defCharges, pCharges)
 Dim paramRefundAmount As DataColumnParameter = New DataColumnParameter(defRefundAmount, pRefundAmount)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramConfirmationThreshold As DataColumnParameter = New DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold)
 Dim paramConfirmationDate As DataColumnParameter = New DataColumnParameter(defConfirmationDate, pConfirmationDate)
 Dim paramAwaitingDisbursement As DataColumnParameter = New DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramConfirmedExplanation As DataColumnParameter = New DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation)
 Dim paramChargesBilledToClient As DataColumnParameter = New DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)
 Dim paramIsMultiTarget As DataColumnParameter = New DataColumnParameter(defIsMultiTarget, pIsMultiTarget)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTransactionStatusID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramSchoolDiscountGiven.getSQLQuotedValueForAdd(),
paramPaymentRequired.getSQLQuotedValueForAdd(),
paramCharges.getSQLQuotedValueForAdd(),
paramRefundAmount.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramConfirmationThreshold.getSQLQuotedValueForAdd(),
paramConfirmationDate.getSQLQuotedValueForAdd(),
paramAwaitingDisbursement.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramConfirmedExplanation.getSQLQuotedValueForAdd(),
paramChargesBilledToClient.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
paramIsMultiTarget.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pTransactionStatusID As Int32,
ByVal pClientID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAccountName As String,
ByVal pAccountNumber As String,
ByVal pBank As String,
ByVal pChannel As String,
ByVal pIPAddress As String,
ByVal pSchoolDiscountGiven As Decimal,
ByVal pPaymentRequired As Decimal,
ByVal pCharges As Decimal,
ByVal pRefundAmount As Decimal,
ByVal pBalance As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
ByVal pPaymentRequiredWithoutCharges As Decimal,
Optional ByVal pConfirmationThreshold As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmationDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAwaitingDisbursement As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pConfirmedExplanation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChargesBilledToClient As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsMultiTarget As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramTransactionStatusID As DataColumnParameter = New DataColumnParameter(defTransactionStatusID, pTransactionStatusID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramSchoolDiscountGiven As DataColumnParameter = New DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven)
 Dim paramPaymentRequired As DataColumnParameter = New DataColumnParameter(defPaymentRequired, pPaymentRequired)
 Dim paramCharges As DataColumnParameter = New DataColumnParameter(defCharges, pCharges)
 Dim paramRefundAmount As DataColumnParameter = New DataColumnParameter(defRefundAmount, pRefundAmount)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramConfirmationThreshold As DataColumnParameter = New DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold)
 Dim paramConfirmationDate As DataColumnParameter = New DataColumnParameter(defConfirmationDate, pConfirmationDate)
 Dim paramAwaitingDisbursement As DataColumnParameter = New DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramConfirmedExplanation As DataColumnParameter = New DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation)
 Dim paramChargesBilledToClient As DataColumnParameter = New DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)
 Dim paramIsMultiTarget As DataColumnParameter = New DataColumnParameter(defIsMultiTarget, pIsMultiTarget)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([TransactionStatusID],[ClientID],[StudentNumber],[FirstName],[LastName],[AccountName],[AccountNumber],[Bank],[Channel],[IPAddress],[SchoolDiscountGiven],[PaymentRequired],[Charges],[RefundAmount],[Balance],[ConfirmationThreshold],[ConfirmationDate],[AwaitingDisbursement],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID],[ConfirmedExplanation],[ChargesBilledToClient],[PaymentRequiredWithoutCharges],[IsMultiTarget]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26}) ", TABLE_NAME,paramTransactionStatusID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramSchoolDiscountGiven.getSQLQuotedValueForAdd(),
paramPaymentRequired.getSQLQuotedValueForAdd(),
paramCharges.getSQLQuotedValueForAdd(),
paramRefundAmount.getSQLQuotedValueForAdd(),
paramBalance.getSQLQuotedValueForAdd(),
paramConfirmationThreshold.getSQLQuotedValueForAdd(),
paramConfirmationDate.getSQLQuotedValueForAdd(),
paramAwaitingDisbursement.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramConfirmedExplanation.getSQLQuotedValueForAdd(),
paramChargesBilledToClient.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd(),
paramIsMultiTarget.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pTransactionStatusID As Object=Nothing,
Optional ByVal pClientID As Object=Nothing,
Optional ByVal pStudentNumber As Object=Nothing,
Optional ByVal pFirstName As Object=Nothing,
Optional ByVal pLastName As Object=Nothing,
Optional ByVal pAccountName As Object=Nothing,
Optional ByVal pAccountNumber As Object=Nothing,
Optional ByVal pBank As Object=Nothing,
Optional ByVal pChannel As Object=Nothing,
Optional ByVal pIPAddress As Object=Nothing,
Optional ByVal pSchoolDiscountGiven As Object=Nothing,
Optional ByVal pPaymentRequired As Object=Nothing,
Optional ByVal pCharges As Object=Nothing,
Optional ByVal pRefundAmount As Object=Nothing,
Optional ByVal pBalance As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pPaymentRequiredWithoutCharges As Object=Nothing,
Optional ByVal pConfirmationThreshold As Object=Nothing,
Optional ByVal pConfirmationDate As Object=Nothing,
Optional ByVal pAwaitingDisbursement As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pConfirmedExplanation As Object=Nothing,
Optional ByVal pChargesBilledToClient As Object=Nothing,
Optional ByVal pIsMultiTarget As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramTransactionStatusID As DataColumnParameter = New DataColumnParameter(defTransactionStatusID, pTransactionStatusID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramSchoolDiscountGiven As DataColumnParameter = New DataColumnParameter(defSchoolDiscountGiven, pSchoolDiscountGiven)
 Dim paramPaymentRequired As DataColumnParameter = New DataColumnParameter(defPaymentRequired, pPaymentRequired)
 Dim paramCharges As DataColumnParameter = New DataColumnParameter(defCharges, pCharges)
 Dim paramRefundAmount As DataColumnParameter = New DataColumnParameter(defRefundAmount, pRefundAmount)
 Dim paramBalance As DataColumnParameter = New DataColumnParameter(defBalance, pBalance)
 Dim paramConfirmationThreshold As DataColumnParameter = New DataColumnParameter(defConfirmationThreshold, pConfirmationThreshold)
 Dim paramConfirmationDate As DataColumnParameter = New DataColumnParameter(defConfirmationDate, pConfirmationDate)
 Dim paramAwaitingDisbursement As DataColumnParameter = New DataColumnParameter(defAwaitingDisbursement, pAwaitingDisbursement)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramConfirmedExplanation As DataColumnParameter = New DataColumnParameter(defConfirmedExplanation, pConfirmedExplanation)
 Dim paramChargesBilledToClient As DataColumnParameter = New DataColumnParameter(defChargesBilledToClient, pChargesBilledToClient)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)
 Dim paramIsMultiTarget As DataColumnParameter = New DataColumnParameter(defIsMultiTarget, pIsMultiTarget)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [TransactionStatusID]={2},[ClientID]={3},[StudentNumber]={4},[FirstName]={5},[LastName]={6},[AccountName]={7},[AccountNumber]={8},[Bank]={9},[Channel]={10},[IPAddress]={11},[SchoolDiscountGiven]={12},[PaymentRequired]={13},[Charges]={14},[RefundAmount]={15},[Balance]={16},[ConfirmationThreshold]={17},[ConfirmationDate]={18},[AwaitingDisbursement]={19},[CreatedAt]={20},[UpdatedAt]={21},[CreatedByID]={22},[UpdatedByID]={23},[ConfirmedExplanation]={24},[ChargesBilledToClient]={25},[PaymentRequiredWithoutCharges]={26},[IsMultiTarget]={27} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramTransactionStatusID.getSQLQuotedValueForUpdate(),
paramClientID.getSQLQuotedValueForUpdate(),
paramStudentNumber.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramAccountName.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate(),
paramBank.getSQLQuotedValueForUpdate(),
paramChannel.getSQLQuotedValueForUpdate(),
paramIPAddress.getSQLQuotedValueForUpdate(),
paramSchoolDiscountGiven.getSQLQuotedValueForUpdate(),
paramPaymentRequired.getSQLQuotedValueForUpdate(),
paramCharges.getSQLQuotedValueForUpdate(),
paramRefundAmount.getSQLQuotedValueForUpdate(),
paramBalance.getSQLQuotedValueForUpdate(),
paramConfirmationThreshold.getSQLQuotedValueForUpdate(),
paramConfirmationDate.getSQLQuotedValueForUpdate(),
paramAwaitingDisbursement.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
paramConfirmedExplanation.getSQLQuotedValueForUpdate(),
paramChargesBilledToClient.getSQLQuotedValueForUpdate(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForUpdate(),
paramIsMultiTarget.getSQLQuotedValueForUpdate()  ), True)


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
