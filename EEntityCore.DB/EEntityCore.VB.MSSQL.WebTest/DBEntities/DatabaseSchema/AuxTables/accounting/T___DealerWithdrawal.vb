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

Public Class T___DealerWithdrawal
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defDealerID = New DataColumnDefinition(TableColumnNames.DealerID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAmount = New DataColumnDefinition(TableColumnNames.Amount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defWithdrawalStatusID = New DataColumnDefinition(TableColumnNames.WithdrawalStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defComments = New DataColumnDefinition(TableColumnNames.Comments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermID = New DataColumnDefinition(TableColumnNames.TermID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defDealerID.ColumnName, defDealerID) 
  ColumnDefns.Add(defAmount.ColumnName, defAmount) 
  ColumnDefns.Add(defWithdrawalStatusID.ColumnName, defWithdrawalStatusID) 
  ColumnDefns.Add(defComments.ColumnName, defComments) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
  ColumnDefns.Add(defTermID.ColumnName, defTermID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_TermID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "academic.Term"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_DealerID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "accounting.Dealer"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_WithdrawalStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "accounting.WithdrawalStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_DealerWithdrawal_BankID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "accounting.DealerWithdrawal", "common.Bank"                  
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

       Public Const TABLE_NAME As String = "accounting.DealerWithdrawal"
       Public Const DealerWithdrawal__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [DealerID], [Amount], [WithdrawalStatusID], [Comments], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt], [BankID], [AccountNumber], [TermID] FROM DealerWithdrawal"
       Public Const DealerWithdrawal__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [DealerID], [Amount], [WithdrawalStatusID], [Comments], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt], [BankID], [AccountNumber], [TermID] FROM DealerWithdrawal"


       Public Enum TableColumnNames

           [ID]
           [DealerID]
           [Amount]
           [WithdrawalStatusID]
           [Comments]
           [CreatedByID]
           [CreatedAt]
           [UpdatedByID]
           [UpdatedAt]
           [BankID]
           [AccountNumber]
           [TermID]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_DealerWithdrawal 
           fk_accounting_DealerWithdrawal_TermID 
           fk_accounting_DealerWithdrawal_DealerID 
           fk_accounting_DealerWithdrawal_WithdrawalStatusID 
           fk_accounting_DealerWithdrawal_CreatedByID 
           fk_accounting_DealerWithdrawal_UpdatedByID 
           fk_accounting_DealerWithdrawal_BankID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defDealerID As DataColumnDefinition
       Public Shared ReadOnly defAmount As DataColumnDefinition
       Public Shared ReadOnly defWithdrawalStatusID As DataColumnDefinition
       Public Shared ReadOnly defComments As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition
       Public Shared ReadOnly defTermID As DataColumnDefinition

       Public ReadOnly Property [DealerID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DealerID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Amount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Amount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [WithdrawalStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.WithdrawalStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Comments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Comments.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CreatedByID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UpdatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UpdatedByID.ToString()))
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


       Public ReadOnly Property [AccountNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___DealerWithdrawal                  
            If Me.hasRows() Then Return New T___DealerWithdrawal(Me.AllRows(0))                  
            Return New T___DealerWithdrawal()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___DealerWithdrawal                  
            Return New T___DealerWithdrawal(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___DealerWithdrawal                  
            Return New T___DealerWithdrawal(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___DealerWithdrawal                  
            Return New T___DealerWithdrawal(Me.RawTable, T___DealerWithdrawal.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___DealerWithdrawal,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___DealerWithdrawal,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___DealerWithdrawal                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___DealerWithdrawal(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___DealerWithdrawal(drst.CopyToDataTable(),                  
                    T___DealerWithdrawal.TABLE_NAME)                  
                Return New T___DealerWithdrawal()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___DealerWithdrawal()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___DealerWithdrawal                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___DealerWithdrawal(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___DealerWithdrawal(drst.CopyToDataTable(),                  
                    T___DealerWithdrawal.TABLE_NAME)                  
                Return New T___DealerWithdrawal()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___DealerWithdrawal()                  
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
            Return DealerWithdrawal__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pDealerID As Int32,
ByVal pWithdrawalStatusID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
ByVal pBankID As Int32,
ByVal pTermID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDealerID As DataColumnParameter = New DataColumnParameter(defDealerID, pDealerID)
 Dim paramWithdrawalStatusID As DataColumnParameter = New DataColumnParameter(defWithdrawalStatusID, pWithdrawalStatusID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, defAmount.DefaultValue)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, defComments.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[Amount],[WithdrawalStatusID],[Comments],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[BankID],[AccountNumber],[TermID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDealerID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramWithdrawalStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pDealerID As Int32,
ByVal pAmount As Decimal,
ByVal pWithdrawalStatusID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pTermID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDealerID As DataColumnParameter = New DataColumnParameter(defDealerID, pDealerID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramWithdrawalStatusID As DataColumnParameter = New DataColumnParameter(defWithdrawalStatusID, pWithdrawalStatusID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[Amount],[WithdrawalStatusID],[Comments],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[BankID],[AccountNumber],[TermID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDealerID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramWithdrawalStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pDealerID As Int32,
ByVal pAmount As Decimal,
ByVal pWithdrawalStatusID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pTermID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramDealerID As DataColumnParameter = New DataColumnParameter(defDealerID, pDealerID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramWithdrawalStatusID As DataColumnParameter = New DataColumnParameter(defWithdrawalStatusID, pWithdrawalStatusID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DealerID],[Amount],[WithdrawalStatusID],[Comments],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[BankID],[AccountNumber],[TermID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDealerID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramWithdrawalStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pDealerID As Int32,
ByVal pAmount As Decimal,
ByVal pWithdrawalStatusID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pTermID As Int32,
Optional ByVal pComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramDealerID As DataColumnParameter = New DataColumnParameter(defDealerID, pDealerID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramWithdrawalStatusID As DataColumnParameter = New DataColumnParameter(defWithdrawalStatusID, pWithdrawalStatusID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([DealerID],[Amount],[WithdrawalStatusID],[Comments],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt],[BankID],[AccountNumber],[TermID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) ", TABLE_NAME,paramDealerID.getSQLQuotedValueForAdd(),
paramAmount.getSQLQuotedValueForAdd(),
paramWithdrawalStatusID.getSQLQuotedValueForAdd(),
paramComments.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pDealerID As Object=Nothing,
Optional ByVal pAmount As Object=Nothing,
Optional ByVal pWithdrawalStatusID As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pBankID As Object=Nothing,
Optional ByVal pAccountNumber As Object=Nothing,
Optional ByVal pTermID As Object=Nothing,
Optional ByVal pComments As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramDealerID As DataColumnParameter = New DataColumnParameter(defDealerID, pDealerID)
 Dim paramAmount As DataColumnParameter = New DataColumnParameter(defAmount, pAmount)
 Dim paramWithdrawalStatusID As DataColumnParameter = New DataColumnParameter(defWithdrawalStatusID, pWithdrawalStatusID)
 Dim paramComments As DataColumnParameter = New DataColumnParameter(defComments, pComments)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [DealerID]={2},[Amount]={3},[WithdrawalStatusID]={4},[Comments]={5},[CreatedByID]={6},[CreatedAt]={7},[UpdatedByID]={8},[UpdatedAt]={9},[BankID]={10},[AccountNumber]={11},[TermID]={12} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramDealerID.getSQLQuotedValueForUpdate(),
paramAmount.getSQLQuotedValueForUpdate(),
paramWithdrawalStatusID.getSQLQuotedValueForUpdate(),
paramComments.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramBankID.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate(),
paramTermID.getSQLQuotedValueForUpdate()  ), True)


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
