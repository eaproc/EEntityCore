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

Public Class T___Payment
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defTermID = New DataColumnDefinition(TableColumnNames.TermID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAmountCharged = New DataColumnDefinition(TableColumnNames.AmountCharged.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDiscountGiven = New DataColumnDefinition(TableColumnNames.DiscountGiven.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDiscountRateApplied = New DataColumnDefinition(TableColumnNames.DiscountRateApplied.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaymentChannelID = New DataColumnDefinition(TableColumnNames.PaymentChannelID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defPaymentEntryModeID = New DataColumnDefinition(TableColumnNames.PaymentEntryModeID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defComments = New DataColumnDefinition(TableColumnNames.Comments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTransactionFileName = New DataColumnDefinition(TableColumnNames.TransactionFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIpAddress = New DataColumnDefinition(TableColumnNames.IpAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotal = New DataColumnDefinition(TableColumnNames.Total.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defTermID.ColumnName, defTermID) 
  ColumnDefns.Add(defAmountCharged.ColumnName, defAmountCharged) 
  ColumnDefns.Add(defDiscountGiven.ColumnName, defDiscountGiven) 
  ColumnDefns.Add(defDiscountRateApplied.ColumnName, defDiscountRateApplied) 
  ColumnDefns.Add(defPaymentChannelID.ColumnName, defPaymentChannelID) 
  ColumnDefns.Add(defPaymentEntryModeID.ColumnName, defPaymentEntryModeID) 
  ColumnDefns.Add(defComments.ColumnName, defComments) 
  ColumnDefns.Add(defTransactionFileName.ColumnName, defTransactionFileName) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress) 
  ColumnDefns.Add(defTotal.ColumnName, defTotal) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_TermID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "academic.Term"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentChannelID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentChannel"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_PaymentEntryModeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "accounting.PaymentEntryMode"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Payment_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Payment", "hr.Client"                  
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

       Public Const TABLE_NAME As String = "accounting.Payment"
       Public Const Payment__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM Payment"
       Public Const Payment__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [TermID], [AmountCharged], [DiscountGiven], [DiscountRateApplied], [PaymentChannelID], [PaymentEntryModeID], [Comments], [TransactionFileName], [CreatedAt], [CreatedByID], [IpAddress], [Total], [ClientID] FROM Payment"


       Public Enum TableColumnNames

           [ID]
           [TermID]
           [AmountCharged]
           [DiscountGiven]
           [DiscountRateApplied]
           [PaymentChannelID]
           [PaymentEntryModeID]
           [Comments]
           [TransactionFileName]
           [CreatedAt]
           [CreatedByID]
           [IpAddress]
           [Total]
           [ClientID]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_Payment 
           fk_accounting_Payment_CreatedByID 
           fk_accounting_Payment_TermID 
           fk_accounting_Payment_PaymentChannelID 
           fk_accounting_Payment_PaymentEntryModeID 
           fk_accounting_Payment_ClientID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defTermID As DataColumnDefinition
       Public Shared ReadOnly defAmountCharged As DataColumnDefinition
       Public Shared ReadOnly defDiscountGiven As DataColumnDefinition
       Public Shared ReadOnly defDiscountRateApplied As DataColumnDefinition
       Public Shared ReadOnly defPaymentChannelID As DataColumnDefinition
       Public Shared ReadOnly defPaymentEntryModeID As DataColumnDefinition
       Public Shared ReadOnly defComments As DataColumnDefinition
       Public Shared ReadOnly defTransactionFileName As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defIpAddress As DataColumnDefinition
       Public Shared ReadOnly defTotal As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition

       Public ReadOnly Property [TermID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AmountCharged] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.AmountCharged.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [DiscountGiven] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.DiscountGiven.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [DiscountRateApplied] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.DiscountRateApplied.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PaymentChannelID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentChannelID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaymentEntryModeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentEntryModeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Comments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Comments.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TransactionFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.TransactionFileName.ToString()))
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


       Public ReadOnly Property [IpAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IpAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Total] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Total.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Payment                  
            If Me.hasRows() Then Return New T___Payment(Me.AllRows(0))                  
            Return New T___Payment()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Payment                  
            Return New T___Payment(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Payment                  
            Return New T___Payment(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Payment                  
            Return New T___Payment(Me.RawTable, T___Payment.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Payment,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Payment,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Payment                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Payment(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Payment(drst.CopyToDataTable(),                  
                    T___Payment.TABLE_NAME)                  
                Return New T___Payment()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Payment()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Payment                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Payment(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Payment(drst.CopyToDataTable(),                  
                    T___Payment.TABLE_NAME)                  
                Return New T___Payment()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Payment()                  
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
            Return Payment__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pTermID As Int32,
ByVal pPaymentChannelID As Int32,
ByVal pPaymentEntryModeID As Int32,
ByVal pCreatedByID As Int32,
ByVal pClientID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramPaymentChannelID As DataColumnParameter = New DataColumnParameter(defPaymentChannelID, pPaymentChannelID)
 Dim paramPaymentEntryModeID As DataColumnParameter = New DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramAmountCharged As DataColumnParameter = New DataColumnParameter(defAmountCharged, defAmountCharged.DefaultValue)
 Dim paramDiscountGiven As DataColumnParameter = New DataColumnParameter(defDiscountGiven, defDiscountGiven.DefaultValue)
 Dim paramDiscountRateApplied As DataColumnParameter = New DataColumnParameter(defDiscountRateApplied, defDiscountRateApplied.DefaultValue)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, defComments.DefaultValue)
 Dim paramTransactionFileName As DataColumnParameter = New DataColumnParameter(defTransactionFileName, defTransactionFileName.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, defIpAddress.DefaultValue)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, defTotal.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramAmountCharged.getSQLQuotedValueForAdd(),
paramDiscountGiven.getSQLQuotedValueForAdd(),
paramDiscountRateApplied.getSQLQuotedValueForAdd(),
paramPaymentChannelID.getSQLQuotedValueForAdd(),
paramPaymentEntryModeID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramTransactionFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pTermID As Int32,
ByVal pAmountCharged As Decimal,
ByVal pDiscountGiven As Decimal,
ByVal pDiscountRateApplied As Decimal,
ByVal pPaymentChannelID As Int32,
ByVal pPaymentEntryModeID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pIpAddress As String,
ByVal pTotal As Decimal,
ByVal pClientID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTransactionFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramAmountCharged As DataColumnParameter = New DataColumnParameter(defAmountCharged, pAmountCharged)
 Dim paramDiscountGiven As DataColumnParameter = New DataColumnParameter(defDiscountGiven, pDiscountGiven)
 Dim paramDiscountRateApplied As DataColumnParameter = New DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied)
 Dim paramPaymentChannelID As DataColumnParameter = New DataColumnParameter(defPaymentChannelID, pPaymentChannelID)
 Dim paramPaymentEntryModeID As DataColumnParameter = New DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramTransactionFileName As DataColumnParameter = New DataColumnParameter(defTransactionFileName, pTransactionFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramAmountCharged.getSQLQuotedValueForAdd(),
paramDiscountGiven.getSQLQuotedValueForAdd(),
paramDiscountRateApplied.getSQLQuotedValueForAdd(),
paramPaymentChannelID.getSQLQuotedValueForAdd(),
paramPaymentEntryModeID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramTransactionFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pTermID As Int32,
ByVal pAmountCharged As Decimal,
ByVal pDiscountGiven As Decimal,
ByVal pDiscountRateApplied As Decimal,
ByVal pPaymentChannelID As Int32,
ByVal pPaymentEntryModeID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pIpAddress As String,
ByVal pTotal As Decimal,
ByVal pClientID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTransactionFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramAmountCharged As DataColumnParameter = New DataColumnParameter(defAmountCharged, pAmountCharged)
 Dim paramDiscountGiven As DataColumnParameter = New DataColumnParameter(defDiscountGiven, pDiscountGiven)
 Dim paramDiscountRateApplied As DataColumnParameter = New DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied)
 Dim paramPaymentChannelID As DataColumnParameter = New DataColumnParameter(defPaymentChannelID, pPaymentChannelID)
 Dim paramPaymentEntryModeID As DataColumnParameter = New DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramTransactionFileName As DataColumnParameter = New DataColumnParameter(defTransactionFileName, pTransactionFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramAmountCharged.getSQLQuotedValueForAdd(),
paramDiscountGiven.getSQLQuotedValueForAdd(),
paramDiscountRateApplied.getSQLQuotedValueForAdd(),
paramPaymentChannelID.getSQLQuotedValueForAdd(),
paramPaymentEntryModeID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramTransactionFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pTermID As Int32,
ByVal pAmountCharged As Decimal,
ByVal pDiscountGiven As Decimal,
ByVal pDiscountRateApplied As Decimal,
ByVal pPaymentChannelID As Int32,
ByVal pPaymentEntryModeID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pIpAddress As String,
ByVal pTotal As Decimal,
ByVal pClientID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTransactionFileName As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramAmountCharged As DataColumnParameter = New DataColumnParameter(defAmountCharged, pAmountCharged)
 Dim paramDiscountGiven As DataColumnParameter = New DataColumnParameter(defDiscountGiven, pDiscountGiven)
 Dim paramDiscountRateApplied As DataColumnParameter = New DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied)
 Dim paramPaymentChannelID As DataColumnParameter = New DataColumnParameter(defPaymentChannelID, pPaymentChannelID)
 Dim paramPaymentEntryModeID As DataColumnParameter = New DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramTransactionFileName As DataColumnParameter = New DataColumnParameter(defTransactionFileName, pTransactionFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([TermID],[AmountCharged],[DiscountGiven],[DiscountRateApplied],[PaymentChannelID],[PaymentEntryModeID],[Comments],[TransactionFileName],[CreatedAt],[CreatedByID],[IpAddress],[Total],[ClientID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramTermID.getSQLQuotedValueForAdd(),
paramAmountCharged.getSQLQuotedValueForAdd(),
paramDiscountGiven.getSQLQuotedValueForAdd(),
paramDiscountRateApplied.getSQLQuotedValueForAdd(),
paramPaymentChannelID.getSQLQuotedValueForAdd(),
paramPaymentEntryModeID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramTransactionFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pTermID As Object=Nothing,
Optional ByVal pAmountCharged As Object=Nothing,
Optional ByVal pDiscountGiven As Object=Nothing,
Optional ByVal pDiscountRateApplied As Object=Nothing,
Optional ByVal pPaymentChannelID As Object=Nothing,
Optional ByVal pPaymentEntryModeID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pIpAddress As Object=Nothing,
Optional ByVal pTotal As Object=Nothing,
Optional ByVal pClientID As Object=Nothing,
Optional ByVal pComments As Object=Nothing,
Optional ByVal pTransactionFileName As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramAmountCharged As DataColumnParameter = New DataColumnParameter(defAmountCharged, pAmountCharged)
 Dim paramDiscountGiven As DataColumnParameter = New DataColumnParameter(defDiscountGiven, pDiscountGiven)
 Dim paramDiscountRateApplied As DataColumnParameter = New DataColumnParameter(defDiscountRateApplied, pDiscountRateApplied)
 Dim paramPaymentChannelID As DataColumnParameter = New DataColumnParameter(defPaymentChannelID, pPaymentChannelID)
 Dim paramPaymentEntryModeID As DataColumnParameter = New DataColumnParameter(defPaymentEntryModeID, pPaymentEntryModeID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramTransactionFileName As DataColumnParameter = New DataColumnParameter(defTransactionFileName, pTransactionFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [TermID]={2},[AmountCharged]={3},[DiscountGiven]={4},[DiscountRateApplied]={5},[PaymentChannelID]={6},[PaymentEntryModeID]={7},[Comments]={8},[TransactionFileName]={9},[CreatedAt]={10},[CreatedByID]={11},[IpAddress]={12},[Total]={13},[ClientID]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramTermID.getSQLQuotedValueForUpdate(),
paramAmountCharged.getSQLQuotedValueForUpdate(),
paramDiscountGiven.getSQLQuotedValueForUpdate(),
paramDiscountRateApplied.getSQLQuotedValueForUpdate(),
paramPaymentChannelID.getSQLQuotedValueForUpdate(),
paramPaymentEntryModeID.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramTransactionFileName.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramTotal.getSQLQuotedValueForUpdate(),
paramClientID.getSQLQuotedValueForUpdate()  ), True)


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
