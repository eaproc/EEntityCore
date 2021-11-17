Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxViews.charity

Public Class V___MonthlyDonationView
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defDonationYear = New DataColumnDefinition(TableColumnNames.DonationYear.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDonationMonth = New DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsApproved = New DataColumnDefinition(TableColumnNames.IsApproved.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsDisbursed = New DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotalAmount = New DataColumnDefinition(TableColumnNames.TotalAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotalBeneficiaries = New DataColumnDefinition(TableColumnNames.TotalBeneficiaries.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFullName = New DataColumnDefinition(TableColumnNames.FullName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMobilePhone = New DataColumnDefinition(TableColumnNames.MobilePhone.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defResidingPastorPersonID = New DataColumnDefinition(TableColumnNames.ResidingPastorPersonID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankName = New DataColumnDefinition(TableColumnNames.BankName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCenterName = New DataColumnDefinition(TableColumnNames.CenterName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCenterAddress = New DataColumnDefinition(TableColumnNames.CenterAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCenterID = New DataColumnDefinition(TableColumnNames.CenterID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defResidingPastorID = New DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear) 
  ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
  ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved) 
  ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed) 
  ColumnDefns.Add(defTotalAmount.ColumnName, defTotalAmount) 
  ColumnDefns.Add(defTotalBeneficiaries.ColumnName, defTotalBeneficiaries) 
  ColumnDefns.Add(defFullName.ColumnName, defFullName) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defMobilePhone.ColumnName, defMobilePhone) 
  ColumnDefns.Add(defResidingPastorPersonID.ColumnName, defResidingPastorPersonID) 
  ColumnDefns.Add(defBankName.ColumnName, defBankName) 
  ColumnDefns.Add(defCenterName.ColumnName, defCenterName) 
  ColumnDefns.Add(defCenterAddress.ColumnName, defCenterAddress) 
  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCenterID.ColumnName, defCenterID) 
  ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
            ReferencedTableNames = New List(Of String)()                  
            ReferencedTableNames.Add("charity.Center")                  
            ReferencedTableNames.Add("charity.DonationInvoiceItem")                  
            ReferencedTableNames.Add("charity.MonthlyDonation")                  
            ReferencedTableNames.Add("charity.ResidingPastor")                  
            ReferencedTableNames.Add("common.Bank")                  
            ReferencedTableNames.Add("common.PersonView")                  

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

       Public Const TABLE_NAME As String = "charity.MonthlyDonationView"
       Public Const MonthlyDonationView__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [DonationYear], [DonationMonth], [AccountNumber], [IsApproved], [IsDisbursed], [TotalAmount], [TotalBeneficiaries], [FullName], [Email], [MobilePhone], [ResidingPastorPersonID], [BankName], [CenterName], [CenterAddress], [ID], [CenterID], [ResidingPastorID], [BankID], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonationView"
       Public Const MonthlyDonationView__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [DonationYear], [DonationMonth], [AccountNumber], [IsApproved], [IsDisbursed], [TotalAmount], [TotalBeneficiaries], [FullName], [Email], [MobilePhone], [ResidingPastorPersonID], [BankName], [CenterName], [CenterAddress], [ID], [CenterID], [ResidingPastorID], [BankID], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonationView"


       Public Enum TableColumnNames

           [DonationYear]
           [DonationMonth]
           [AccountNumber]
           [IsApproved]
           [IsDisbursed]
           [TotalAmount]
           [TotalBeneficiaries]
           [FullName]
           [Email]
           [MobilePhone]
           [ResidingPastorPersonID]
           [BankName]
           [CenterName]
           [CenterAddress]
           [ID]
           [CenterID]
           [ResidingPastorID]
           [BankID]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ReferencedTableNames As List(Of String)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defDonationYear As DataColumnDefinition
       Public Shared ReadOnly defDonationMonth As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition
       Public Shared ReadOnly defIsApproved As DataColumnDefinition
       Public Shared ReadOnly defIsDisbursed As DataColumnDefinition
       Public Shared ReadOnly defTotalAmount As DataColumnDefinition
       Public Shared ReadOnly defTotalBeneficiaries As DataColumnDefinition
       Public Shared ReadOnly defFullName As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defMobilePhone As DataColumnDefinition
       Public Shared ReadOnly defResidingPastorPersonID As DataColumnDefinition
       Public Shared ReadOnly defBankName As DataColumnDefinition
       Public Shared ReadOnly defCenterName As DataColumnDefinition
       Public Shared ReadOnly defCenterAddress As DataColumnDefinition
       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCenterID As DataColumnDefinition
       Public Shared ReadOnly defResidingPastorID As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition

       Public ReadOnly Property [DonationYear] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DonationYear.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DonationMonth] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DonationMonth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsApproved] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsApproved.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsDisbursed] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsDisbursed.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TotalAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.TotalAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [TotalBeneficiaries] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TotalBeneficiaries.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FullName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FullName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MobilePhone] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.MobilePhone.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ResidingPastorPersonID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ResidingPastorPersonID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BankName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BankName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CenterName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CenterName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CenterAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CenterAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CenterID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CenterID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ResidingPastorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ResidingPastorID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BankID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BankID.ToString()))
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


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As V___MonthlyDonationView                  
            If Me.hasRows() Then Return New V___MonthlyDonationView(Me.AllRows(0))                  
            Return New V___MonthlyDonationView()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As V___MonthlyDonationView                  
            Return New V___MonthlyDonationView(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As V___MonthlyDonationView                  
            Return New V___MonthlyDonationView(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As V___MonthlyDonationView                  
            Return New V___MonthlyDonationView(Me.RawTable, V___MonthlyDonationView.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As V___MonthlyDonationView,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As V___MonthlyDonationView,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As V___MonthlyDonationView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New V___MonthlyDonationView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___MonthlyDonationView(drst.CopyToDataTable(),                  
                    V___MonthlyDonationView.TABLE_NAME)                  
                Return New V___MonthlyDonationView()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New V___MonthlyDonationView()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As V___MonthlyDonationView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New V___MonthlyDonationView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___MonthlyDonationView(drst.CopyToDataTable(),                  
                    V___MonthlyDonationView.TABLE_NAME)                  
                Return New V___MonthlyDonationView()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New V___MonthlyDonationView()                  
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
                  
                  

                  
        Public Function getReferencedTableNames() As List(Of String) Implements IDBViewDefinitionPlugIn.getReferencedTableNames                  
            Return ReferencedTableNames                  
        End Function                  
                  
        Public Function getViewName() As String Implements IDBViewDefinitionPlugIn.getViewName                  
            Return TABLE_NAME                  
        End Function                  

                  
                  
#End Region                  
                  
                  



End Class


End Namespace
