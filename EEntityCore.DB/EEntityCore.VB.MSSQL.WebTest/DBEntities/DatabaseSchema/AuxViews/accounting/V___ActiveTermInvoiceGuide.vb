Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxViews.accounting

Public Class V___ActiveTermInvoiceGuide
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defCompanyName = New DataColumnDefinition(TableColumnNames.CompanyName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermStartDate = New DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCurrentWeek = New DataColumnDefinition(TableColumnNames.CurrentWeek.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFirstBillDeadline = New DataColumnDefinition(TableColumnNames.FirstBillDeadline.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSecondBillDeadline = New DataColumnDefinition(TableColumnNames.SecondBillDeadline.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermEndDate = New DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRatePerStudent = New DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBilledRatePerStudent = New DataColumnDefinition(TableColumnNames.BilledRatePerStudent.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBillableStudentCount = New DataColumnDefinition(TableColumnNames.BillableStudentCount.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpectedMinimumBillable = New DataColumnDefinition(TableColumnNames.ExpectedMinimumBillable.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpectedTotalBillable = New DataColumnDefinition(TableColumnNames.ExpectedTotalBillable.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBilledAmount = New DataColumnDefinition(TableColumnNames.BilledAmount.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBalance = New DataColumnDefinition(TableColumnNames.Balance.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRegisteredStudentCount = New DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFullScholarshipStudentCount = New DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName) 
  ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate) 
  ColumnDefns.Add(defCurrentWeek.ColumnName, defCurrentWeek) 
  ColumnDefns.Add(defFirstBillDeadline.ColumnName, defFirstBillDeadline) 
  ColumnDefns.Add(defSecondBillDeadline.ColumnName, defSecondBillDeadline) 
  ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate) 
  ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent) 
  ColumnDefns.Add(defBilledRatePerStudent.ColumnName, defBilledRatePerStudent) 
  ColumnDefns.Add(defBillableStudentCount.ColumnName, defBillableStudentCount) 
  ColumnDefns.Add(defExpectedMinimumBillable.ColumnName, defExpectedMinimumBillable) 
  ColumnDefns.Add(defExpectedTotalBillable.ColumnName, defExpectedTotalBillable) 
  ColumnDefns.Add(defBilledAmount.ColumnName, defBilledAmount) 
  ColumnDefns.Add(defBalance.ColumnName, defBalance) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount) 
  ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount) 
            ReferencedTableNames = New List(Of String)()                  
            ReferencedTableNames.Add("academic.Term")                  
            ReferencedTableNames.Add("accounting.Invoice")                  
            ReferencedTableNames.Add("accounting.TermBill")                  
            ReferencedTableNames.Add("hr.Client")                  
            ReferencedTableNames.Add("hr.ClientStats")                  

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

       Public Const TABLE_NAME As String = "accounting.ActiveTermInvoiceGuide"
       Public Const ActiveTermInvoiceGuide__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [CompanyName], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [SecondBillDeadline], [TermEndDate], [RatePerStudent], [BilledRatePerStudent], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [ClientID], [RegisteredStudentCount], [FullScholarshipStudentCount] FROM ActiveTermInvoiceGuide"
       Public Const ActiveTermInvoiceGuide__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [CompanyName], [TermStartDate], [CurrentWeek], [FirstBillDeadline], [SecondBillDeadline], [TermEndDate], [RatePerStudent], [BilledRatePerStudent], [BillableStudentCount], [ExpectedMinimumBillable], [ExpectedTotalBillable], [BilledAmount], [Balance], [ClientID], [RegisteredStudentCount], [FullScholarshipStudentCount] FROM ActiveTermInvoiceGuide"


       Public Enum TableColumnNames

           [CompanyName]
           [TermStartDate]
           [CurrentWeek]
           [FirstBillDeadline]
           [SecondBillDeadline]
           [TermEndDate]
           [RatePerStudent]
           [BilledRatePerStudent]
           [BillableStudentCount]
           [ExpectedMinimumBillable]
           [ExpectedTotalBillable]
           [BilledAmount]
           [Balance]
           [ClientID]
           [RegisteredStudentCount]
           [FullScholarshipStudentCount]
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ReferencedTableNames As List(Of String)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defCompanyName As DataColumnDefinition
       Public Shared ReadOnly defTermStartDate As DataColumnDefinition
       Public Shared ReadOnly defCurrentWeek As DataColumnDefinition
       Public Shared ReadOnly defFirstBillDeadline As DataColumnDefinition
       Public Shared ReadOnly defSecondBillDeadline As DataColumnDefinition
       Public Shared ReadOnly defTermEndDate As DataColumnDefinition
       Public Shared ReadOnly defRatePerStudent As DataColumnDefinition
       Public Shared ReadOnly defBilledRatePerStudent As DataColumnDefinition
       Public Shared ReadOnly defBillableStudentCount As DataColumnDefinition
       Public Shared ReadOnly defExpectedMinimumBillable As DataColumnDefinition
       Public Shared ReadOnly defExpectedTotalBillable As DataColumnDefinition
       Public Shared ReadOnly defBilledAmount As DataColumnDefinition
       Public Shared ReadOnly defBalance As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defRegisteredStudentCount As DataColumnDefinition
       Public Shared ReadOnly defFullScholarshipStudentCount As DataColumnDefinition

       Public ReadOnly Property [CompanyName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CompanyName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermStartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermStartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CurrentWeek] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CurrentWeek.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FirstBillDeadline] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.FirstBillDeadline.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SecondBillDeadline] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.SecondBillDeadline.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermEndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermEndDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RatePerStudent] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.RatePerStudent.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [BilledRatePerStudent] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.BilledRatePerStudent.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [BillableStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BillableStudentCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExpectedMinimumBillable] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.ExpectedMinimumBillable.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ExpectedTotalBillable] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.ExpectedTotalBillable.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [BilledAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.BilledAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Balance] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Balance.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RegisteredStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.RegisteredStudentCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FullScholarshipStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.FullScholarshipStudentCount.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As V___ActiveTermInvoiceGuide                  
            If Me.hasRows() Then Return New V___ActiveTermInvoiceGuide(Me.AllRows(0))                  
            Return New V___ActiveTermInvoiceGuide()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As V___ActiveTermInvoiceGuide                  
            Return New V___ActiveTermInvoiceGuide(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As V___ActiveTermInvoiceGuide                  
            Return New V___ActiveTermInvoiceGuide(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As V___ActiveTermInvoiceGuide                  
            Return New V___ActiveTermInvoiceGuide(Me.RawTable, V___ActiveTermInvoiceGuide.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As V___ActiveTermInvoiceGuide,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As V___ActiveTermInvoiceGuide,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As V___ActiveTermInvoiceGuide                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New V___ActiveTermInvoiceGuide(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___ActiveTermInvoiceGuide(drst.CopyToDataTable(),                  
                    V___ActiveTermInvoiceGuide.TABLE_NAME)                  
                Return New V___ActiveTermInvoiceGuide()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New V___ActiveTermInvoiceGuide()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As V___ActiveTermInvoiceGuide                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New V___ActiveTermInvoiceGuide(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___ActiveTermInvoiceGuide(drst.CopyToDataTable(),                  
                    V___ActiveTermInvoiceGuide.TABLE_NAME)                  
                Return New V___ActiveTermInvoiceGuide()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New V___ActiveTermInvoiceGuide()                  
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
