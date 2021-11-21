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

Public Class T___Invoice
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defBillDefinition = New DataColumnDefinition(TableColumnNames.BillDefinition.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBillDescription = New DataColumnDefinition(TableColumnNames.BillDescription.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBillAmount = New DataColumnDefinition(TableColumnNames.BillAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotal = New DataColumnDefinition(TableColumnNames.Total.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCanBeDeleted = New DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defQuantity = New DataColumnDefinition(TableColumnNames.Quantity.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIpAddress = New DataColumnDefinition(TableColumnNames.IpAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermID = New DataColumnDefinition(TableColumnNames.TermID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defOriginalBillID = New DataColumnDefinition(TableColumnNames.OriginalBillID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defPaymentTransactionID = New DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defBillDefinition.ColumnName, defBillDefinition) 
  ColumnDefns.Add(defBillDescription.ColumnName, defBillDescription) 
  ColumnDefns.Add(defBillAmount.ColumnName, defBillAmount) 
  ColumnDefns.Add(defTotal.ColumnName, defTotal) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted) 
  ColumnDefns.Add(defQuantity.ColumnName, defQuantity) 
  ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress) 
  ColumnDefns.Add(defTermID.ColumnName, defTermID) 
  ColumnDefns.Add(defOriginalBillID.ColumnName, defOriginalBillID) 
  ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_PaymentTransactionID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "pay_gateway.PaymentTransaction"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_OriginalBillID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "accounting.Bill"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "hr.Client"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_Invoice_TermID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.Invoice", "academic.Term"                  
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

       Public Const TABLE_NAME As String = "accounting.Invoice"
       Public Const Invoice__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM Invoice"
       Public Const Invoice__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [BillDefinition], [BillDescription], [BillAmount], [Total], [CreatedAt], [CreatedByID], [CanBeDeleted], [Quantity], [IpAddress], [TermID], [OriginalBillID], [PaymentTransactionID] FROM Invoice"


       Public Enum TableColumnNames

           [ID]
           [ClientID]
           [BillDefinition]
           [BillDescription]
           [BillAmount]
           [Total]
           [CreatedAt]
           [CreatedByID]
           [CanBeDeleted]
           [Quantity]
           [IpAddress]
           [TermID]
           [OriginalBillID]
           [PaymentTransactionID]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_Invoice 
           fk_accounting_Invoice_PaymentTransactionID 
           fk_accounting_Invoice_OriginalBillID 
           fk_accounting_Invoice_ClientID 
           fk_accounting_Invoice_CreatedByID 
           fk_accounting_Invoice_TermID 
           uq_accounting_Invoice_PaymentTransactionID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defBillDefinition As DataColumnDefinition
       Public Shared ReadOnly defBillDescription As DataColumnDefinition
       Public Shared ReadOnly defBillAmount As DataColumnDefinition
       Public Shared ReadOnly defTotal As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defCanBeDeleted As DataColumnDefinition
       Public Shared ReadOnly defQuantity As DataColumnDefinition
       Public Shared ReadOnly defIpAddress As DataColumnDefinition
       Public Shared ReadOnly defTermID As DataColumnDefinition
       Public Shared ReadOnly defOriginalBillID As DataColumnDefinition
       Public Shared ReadOnly defPaymentTransactionID As DataColumnDefinition

       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BillDefinition] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BillDefinition.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BillDescription] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BillDescription.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BillAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.BillAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Total] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Total.ToString())) )
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


       Public ReadOnly Property [CanBeDeleted] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.CanBeDeleted.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Quantity] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.Quantity.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IpAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IpAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [OriginalBillID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.OriginalBillID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaymentTransactionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentTransactionID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Invoice                  
            If Me.hasRows() Then Return New T___Invoice(Me.AllRows(0))                  
            Return New T___Invoice()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Invoice                  
            Return New T___Invoice(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Invoice                  
            Return New T___Invoice(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Invoice                  
            Return New T___Invoice(Me.RawTable, T___Invoice.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Invoice,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Invoice,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Invoice                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Invoice(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Invoice(drst.CopyToDataTable(),                  
                    T___Invoice.TABLE_NAME)                  
                Return New T___Invoice()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Invoice()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Invoice                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Invoice(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Invoice(drst.CopyToDataTable(),                  
                    T___Invoice.TABLE_NAME)                  
                Return New T___Invoice()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Invoice()                  
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
            Return Invoice__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pClientID As Int32,
ByVal pCreatedByID As Int32,
ByVal pTermID As Int32,
ByVal pOriginalBillID As Int32,
ByVal pPaymentTransactionID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramOriginalBillID As DataColumnParameter = New DataColumnParameter(defOriginalBillID, pOriginalBillID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramBillDefinition As DataColumnParameter = New DataColumnParameter(defBillDefinition, defBillDefinition.DefaultValue)
 Dim paramBillDescription As DataColumnParameter = New DataColumnParameter(defBillDescription, defBillDescription.DefaultValue)
 Dim paramBillAmount As DataColumnParameter = New DataColumnParameter(defBillAmount, defBillAmount.DefaultValue)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, defTotal.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, defCanBeDeleted.DefaultValue)
 Dim paramQuantity As DataColumnParameter = New DataColumnParameter(defQuantity, defQuantity.DefaultValue)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, defIpAddress.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pClientID As Int32,
ByVal pBillDefinition As String,
ByVal pBillAmount As Decimal,
ByVal pTotal As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pCanBeDeleted As Boolean,
ByVal pQuantity As Int32,
ByVal pIpAddress As String,
ByVal pTermID As Int32,
ByVal pOriginalBillID As Int32,
Optional ByVal pBillDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentTransactionID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramBillDefinition As DataColumnParameter = New DataColumnParameter(defBillDefinition, pBillDefinition)
 Dim paramBillDescription As DataColumnParameter = New DataColumnParameter(defBillDescription, pBillDescription)
 Dim paramBillAmount As DataColumnParameter = New DataColumnParameter(defBillAmount, pBillAmount)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramQuantity As DataColumnParameter = New DataColumnParameter(defQuantity, pQuantity)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramOriginalBillID As DataColumnParameter = New DataColumnParameter(defOriginalBillID, pOriginalBillID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pClientID As Int32,
ByVal pBillDefinition As String,
ByVal pBillAmount As Decimal,
ByVal pTotal As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pCanBeDeleted As Boolean,
ByVal pQuantity As Int32,
ByVal pIpAddress As String,
ByVal pTermID As Int32,
ByVal pOriginalBillID As Int32,
Optional ByVal pBillDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentTransactionID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramBillDefinition As DataColumnParameter = New DataColumnParameter(defBillDefinition, pBillDefinition)
 Dim paramBillDescription As DataColumnParameter = New DataColumnParameter(defBillDescription, pBillDescription)
 Dim paramBillAmount As DataColumnParameter = New DataColumnParameter(defBillAmount, pBillAmount)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramQuantity As DataColumnParameter = New DataColumnParameter(defQuantity, pQuantity)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramOriginalBillID As DataColumnParameter = New DataColumnParameter(defOriginalBillID, pOriginalBillID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), True)




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
ByVal pBillDefinition As String,
ByVal pBillAmount As Decimal,
ByVal pTotal As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pCanBeDeleted As Boolean,
ByVal pQuantity As Int32,
ByVal pIpAddress As String,
ByVal pTermID As Int32,
ByVal pOriginalBillID As Int32,
Optional ByVal pBillDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentTransactionID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramBillDefinition As DataColumnParameter = New DataColumnParameter(defBillDefinition, pBillDefinition)
 Dim paramBillDescription As DataColumnParameter = New DataColumnParameter(defBillDescription, pBillDescription)
 Dim paramBillAmount As DataColumnParameter = New DataColumnParameter(defBillAmount, pBillAmount)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramQuantity As DataColumnParameter = New DataColumnParameter(defQuantity, pQuantity)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramOriginalBillID As DataColumnParameter = New DataColumnParameter(defOriginalBillID, pOriginalBillID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([ClientID],[BillDefinition],[BillDescription],[BillAmount],[Total],[CreatedAt],[CreatedByID],[CanBeDeleted],[Quantity],[IpAddress],[TermID],[OriginalBillID],[PaymentTransactionID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramClientID.getSQLQuotedValueForAdd(),
paramBillDefinition.getSQLQuotedValueForAdd(),
paramBillDescription.getSQLQuotedValueForAdd(),
paramBillAmount.getSQLQuotedValueForAdd(),
paramTotal.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramQuantity.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramOriginalBillID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pBillDefinition As Object=Nothing,
Optional ByVal pBillAmount As Object=Nothing,
Optional ByVal pTotal As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pCanBeDeleted As Object=Nothing,
Optional ByVal pQuantity As Object=Nothing,
Optional ByVal pIpAddress As Object=Nothing,
Optional ByVal pTermID As Object=Nothing,
Optional ByVal pOriginalBillID As Object=Nothing,
Optional ByVal pBillDescription As Object=Nothing,
Optional ByVal pPaymentTransactionID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramBillDefinition As DataColumnParameter = New DataColumnParameter(defBillDefinition, pBillDefinition)
 Dim paramBillDescription As DataColumnParameter = New DataColumnParameter(defBillDescription, pBillDescription)
 Dim paramBillAmount As DataColumnParameter = New DataColumnParameter(defBillAmount, pBillAmount)
 Dim paramTotal As DataColumnParameter = New DataColumnParameter(defTotal, pTotal)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramQuantity As DataColumnParameter = New DataColumnParameter(defQuantity, pQuantity)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramOriginalBillID As DataColumnParameter = New DataColumnParameter(defOriginalBillID, pOriginalBillID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[BillDefinition]={3},[BillDescription]={4},[BillAmount]={5},[Total]={6},[CreatedAt]={7},[CreatedByID]={8},[CanBeDeleted]={9},[Quantity]={10},[IpAddress]={11},[TermID]={12},[OriginalBillID]={13},[PaymentTransactionID]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramClientID.getSQLQuotedValueForUpdate(),
paramBillDefinition.getSQLQuotedValueForUpdate(),
paramBillDescription.getSQLQuotedValueForUpdate(),
paramBillAmount.getSQLQuotedValueForUpdate(),
paramTotal.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramCanBeDeleted.getSQLQuotedValueForUpdate(),
paramQuantity.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramTermID.getSQLQuotedValueForUpdate(),
paramOriginalBillID.getSQLQuotedValueForUpdate(),
paramPaymentTransactionID.getSQLQuotedValueForUpdate()  ), True)


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
