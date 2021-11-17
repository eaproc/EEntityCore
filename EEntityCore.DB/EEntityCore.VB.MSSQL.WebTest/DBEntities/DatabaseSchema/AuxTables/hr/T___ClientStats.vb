Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.hr

Public Class T___ClientStats
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defClientID = New DataColumnDefinition(TableColumnNames.ClientID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defTermID = New DataColumnDefinition(TableColumnNames.TermID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defRegisteredStudentCount = New DataColumnDefinition(TableColumnNames.RegisteredStudentCount.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAssignedStudentCount = New DataColumnDefinition(TableColumnNames.AssignedStudentCount.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSCADWAREAccessCount = New DataColumnDefinition(TableColumnNames.SCADWAREAccessCount.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSCADWAREAccessThreshold = New DataColumnDefinition(TableColumnNames.SCADWAREAccessThreshold.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAverageTermBill = New DataColumnDefinition(TableColumnNames.AverageTermBill.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRatePerStudent = New DataColumnDefinition(TableColumnNames.RatePerStudent.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBilledPerStudent = New DataColumnDefinition(TableColumnNames.BilledPerStudent.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotalReceivedOnSCADWAREBill = New DataColumnDefinition(TableColumnNames.TotalReceivedOnSCADWAREBill.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMinimumExpectedOnSCADWAREBill = New DataColumnDefinition(TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpectedOnSCADWAREBill = New DataColumnDefinition(TableColumnNames.ExpectedOnSCADWAREBill.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIPAddress = New DataColumnDefinition(TableColumnNames.IPAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFullScholarshipStudentCount = New DataColumnDefinition(TableColumnNames.FullScholarshipStudentCount.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermStartDate = New DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermEndDate = New DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defClientID.ColumnName, defClientID) 
  ColumnDefns.Add(defTermID.ColumnName, defTermID) 
  ColumnDefns.Add(defRegisteredStudentCount.ColumnName, defRegisteredStudentCount) 
  ColumnDefns.Add(defAssignedStudentCount.ColumnName, defAssignedStudentCount) 
  ColumnDefns.Add(defSCADWAREAccessCount.ColumnName, defSCADWAREAccessCount) 
  ColumnDefns.Add(defSCADWAREAccessThreshold.ColumnName, defSCADWAREAccessThreshold) 
  ColumnDefns.Add(defAverageTermBill.ColumnName, defAverageTermBill) 
  ColumnDefns.Add(defRatePerStudent.ColumnName, defRatePerStudent) 
  ColumnDefns.Add(defBilledPerStudent.ColumnName, defBilledPerStudent) 
  ColumnDefns.Add(defTotalReceivedOnSCADWAREBill.ColumnName, defTotalReceivedOnSCADWAREBill) 
  ColumnDefns.Add(defMinimumExpectedOnSCADWAREBill.ColumnName, defMinimumExpectedOnSCADWAREBill) 
  ColumnDefns.Add(defExpectedOnSCADWAREBill.ColumnName, defExpectedOnSCADWAREBill) 
  ColumnDefns.Add(defIPAddress.ColumnName, defIPAddress) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defFullScholarshipStudentCount.ColumnName, defFullScholarshipStudentCount) 
  ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate) 
  ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_ClientID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.ClientStats", "hr.Client"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_ClientStats_TermID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.ClientStats", "academic.Term"                  
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

       Public Const TABLE_NAME As String = "hr.ClientStats"
       Public Const ClientStats__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM ClientStats"
       Public Const ClientStats__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [ClientID], [TermID], [RegisteredStudentCount], [AssignedStudentCount], [SCADWAREAccessCount], [SCADWAREAccessThreshold], [AverageTermBill], [RatePerStudent], [BilledPerStudent], [TotalReceivedOnSCADWAREBill], [MinimumExpectedOnSCADWAREBill], [ExpectedOnSCADWAREBill], [IPAddress], [CreatedAt], [FullScholarshipStudentCount], [TermStartDate], [TermEndDate] FROM ClientStats"


       Public Enum TableColumnNames

           [ID]
           [ClientID]
           [TermID]
           [RegisteredStudentCount]
           [AssignedStudentCount]
           [SCADWAREAccessCount]
           [SCADWAREAccessThreshold]
           [AverageTermBill]
           [RatePerStudent]
           [BilledPerStudent]
           [TotalReceivedOnSCADWAREBill]
           [MinimumExpectedOnSCADWAREBill]
           [ExpectedOnSCADWAREBill]
           [IPAddress]
           [CreatedAt]
           [FullScholarshipStudentCount]
           [TermStartDate]
           [TermEndDate]
       End Enum 



       Public Enum TableConstraints

           pk_hr_ClientStats 
           fk_hr_ClientStats_ClientID 
           fk_hr_ClientStats_TermID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defClientID As DataColumnDefinition
       Public Shared ReadOnly defTermID As DataColumnDefinition
       Public Shared ReadOnly defRegisteredStudentCount As DataColumnDefinition
       Public Shared ReadOnly defAssignedStudentCount As DataColumnDefinition
       Public Shared ReadOnly defSCADWAREAccessCount As DataColumnDefinition
       Public Shared ReadOnly defSCADWAREAccessThreshold As DataColumnDefinition
       Public Shared ReadOnly defAverageTermBill As DataColumnDefinition
       Public Shared ReadOnly defRatePerStudent As DataColumnDefinition
       Public Shared ReadOnly defBilledPerStudent As DataColumnDefinition
       Public Shared ReadOnly defTotalReceivedOnSCADWAREBill As DataColumnDefinition
       Public Shared ReadOnly defMinimumExpectedOnSCADWAREBill As DataColumnDefinition
       Public Shared ReadOnly defExpectedOnSCADWAREBill As DataColumnDefinition
       Public Shared ReadOnly defIPAddress As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defFullScholarshipStudentCount As DataColumnDefinition
       Public Shared ReadOnly defTermStartDate As DataColumnDefinition
       Public Shared ReadOnly defTermEndDate As DataColumnDefinition

       Public ReadOnly Property [ClientID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ClientID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RegisteredStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.RegisteredStudentCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AssignedStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AssignedStudentCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SCADWAREAccessCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.SCADWAREAccessCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SCADWAREAccessThreshold] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SCADWAREAccessThreshold.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [AverageTermBill] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.AverageTermBill.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [RatePerStudent] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.RatePerStudent.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [BilledPerStudent] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.BilledPerStudent.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [TotalReceivedOnSCADWAREBill] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.TotalReceivedOnSCADWAREBill.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [MinimumExpectedOnSCADWAREBill] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.MinimumExpectedOnSCADWAREBill.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [ExpectedOnSCADWAREBill] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.ExpectedOnSCADWAREBill.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [IPAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IPAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FullScholarshipStudentCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.FullScholarshipStudentCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermStartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermStartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermEndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermEndDate.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___ClientStats                  
            If Me.hasRows() Then Return New T___ClientStats(Me.AllRows(0))                  
            Return New T___ClientStats()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___ClientStats                  
            Return New T___ClientStats(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___ClientStats                  
            Return New T___ClientStats(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___ClientStats                  
            Return New T___ClientStats(Me.RawTable, T___ClientStats.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___ClientStats,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___ClientStats,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___ClientStats                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___ClientStats(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ClientStats(drst.CopyToDataTable(),                  
                    T___ClientStats.TABLE_NAME)                  
                Return New T___ClientStats()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___ClientStats()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___ClientStats                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___ClientStats(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___ClientStats(drst.CopyToDataTable(),                  
                    T___ClientStats.TABLE_NAME)                  
                Return New T___ClientStats()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___ClientStats()                  
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
            Return ClientStats__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pClientID As Int32,
ByVal pTermID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramRegisteredStudentCount As DataColumnParameter = New DataColumnParameter(defRegisteredStudentCount, defRegisteredStudentCount.DefaultValue)
 Dim paramAssignedStudentCount As DataColumnParameter = New DataColumnParameter(defAssignedStudentCount, defAssignedStudentCount.DefaultValue)
 Dim paramSCADWAREAccessCount As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessCount, defSCADWAREAccessCount.DefaultValue)
 Dim paramSCADWAREAccessThreshold As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessThreshold, defSCADWAREAccessThreshold.DefaultValue)
 Dim paramAverageTermBill As DataColumnParameter = New DataColumnParameter(defAverageTermBill, defAverageTermBill.DefaultValue)
 Dim paramRatePerStudent As DataColumnParameter = New DataColumnParameter(defRatePerStudent, defRatePerStudent.DefaultValue)
 Dim paramBilledPerStudent As DataColumnParameter = New DataColumnParameter(defBilledPerStudent, defBilledPerStudent.DefaultValue)
 Dim paramTotalReceivedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defTotalReceivedOnSCADWAREBill, defTotalReceivedOnSCADWAREBill.DefaultValue)
 Dim paramMinimumExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defMinimumExpectedOnSCADWAREBill, defMinimumExpectedOnSCADWAREBill.DefaultValue)
 Dim paramExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defExpectedOnSCADWAREBill, defExpectedOnSCADWAREBill.DefaultValue)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, defIPAddress.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramFullScholarshipStudentCount As DataColumnParameter = New DataColumnParameter(defFullScholarshipStudentCount, defFullScholarshipStudentCount.DefaultValue)
 Dim paramTermStartDate As DataColumnParameter = New DataColumnParameter(defTermStartDate, defTermStartDate.DefaultValue)
 Dim paramTermEndDate As DataColumnParameter = New DataColumnParameter(defTermEndDate, defTermEndDate.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramRegisteredStudentCount.getSQLQuotedValueForAdd(),
paramAssignedStudentCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.getSQLQuotedValueForAdd(),
paramAverageTermBill.getSQLQuotedValueForAdd(),
paramRatePerStudent.getSQLQuotedValueForAdd(),
paramBilledPerStudent.getSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.getSQLQuotedValueForAdd(),
paramTermStartDate.getSQLQuotedValueForAdd(),
paramTermEndDate.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pClientID As Int32,
ByVal pTermID As Int32,
ByVal pRegisteredStudentCount As Int32,
ByVal pAssignedStudentCount As Int32,
ByVal pSCADWAREAccessCount As Int32,
ByVal pSCADWAREAccessThreshold As Decimal,
ByVal pAverageTermBill As Decimal,
ByVal pRatePerStudent As Decimal,
ByVal pBilledPerStudent As Decimal,
ByVal pTotalReceivedOnSCADWAREBill As Decimal,
ByVal pMinimumExpectedOnSCADWAREBill As Decimal,
ByVal pExpectedOnSCADWAREBill As Decimal,
ByVal pIPAddress As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pFullScholarshipStudentCount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermStartDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermEndDate As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramRegisteredStudentCount As DataColumnParameter = New DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount)
 Dim paramAssignedStudentCount As DataColumnParameter = New DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount)
 Dim paramSCADWAREAccessCount As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount)
 Dim paramSCADWAREAccessThreshold As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold)
 Dim paramAverageTermBill As DataColumnParameter = New DataColumnParameter(defAverageTermBill, pAverageTermBill)
 Dim paramRatePerStudent As DataColumnParameter = New DataColumnParameter(defRatePerStudent, pRatePerStudent)
 Dim paramBilledPerStudent As DataColumnParameter = New DataColumnParameter(defBilledPerStudent, pBilledPerStudent)
 Dim paramTotalReceivedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill)
 Dim paramMinimumExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill)
 Dim paramExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramFullScholarshipStudentCount As DataColumnParameter = New DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount)
 Dim paramTermStartDate As DataColumnParameter = New DataColumnParameter(defTermStartDate, pTermStartDate)
 Dim paramTermEndDate As DataColumnParameter = New DataColumnParameter(defTermEndDate, pTermEndDate)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramRegisteredStudentCount.getSQLQuotedValueForAdd(),
paramAssignedStudentCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.getSQLQuotedValueForAdd(),
paramAverageTermBill.getSQLQuotedValueForAdd(),
paramRatePerStudent.getSQLQuotedValueForAdd(),
paramBilledPerStudent.getSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.getSQLQuotedValueForAdd(),
paramTermStartDate.getSQLQuotedValueForAdd(),
paramTermEndDate.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pClientID As Int32,
ByVal pTermID As Int32,
ByVal pRegisteredStudentCount As Int32,
ByVal pAssignedStudentCount As Int32,
ByVal pSCADWAREAccessCount As Int32,
ByVal pSCADWAREAccessThreshold As Decimal,
ByVal pAverageTermBill As Decimal,
ByVal pRatePerStudent As Decimal,
ByVal pBilledPerStudent As Decimal,
ByVal pTotalReceivedOnSCADWAREBill As Decimal,
ByVal pMinimumExpectedOnSCADWAREBill As Decimal,
ByVal pExpectedOnSCADWAREBill As Decimal,
ByVal pIPAddress As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pFullScholarshipStudentCount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermStartDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermEndDate As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramRegisteredStudentCount As DataColumnParameter = New DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount)
 Dim paramAssignedStudentCount As DataColumnParameter = New DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount)
 Dim paramSCADWAREAccessCount As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount)
 Dim paramSCADWAREAccessThreshold As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold)
 Dim paramAverageTermBill As DataColumnParameter = New DataColumnParameter(defAverageTermBill, pAverageTermBill)
 Dim paramRatePerStudent As DataColumnParameter = New DataColumnParameter(defRatePerStudent, pRatePerStudent)
 Dim paramBilledPerStudent As DataColumnParameter = New DataColumnParameter(defBilledPerStudent, pBilledPerStudent)
 Dim paramTotalReceivedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill)
 Dim paramMinimumExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill)
 Dim paramExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramFullScholarshipStudentCount As DataColumnParameter = New DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount)
 Dim paramTermStartDate As DataColumnParameter = New DataColumnParameter(defTermStartDate, pTermStartDate)
 Dim paramTermEndDate As DataColumnParameter = New DataColumnParameter(defTermEndDate, pTermEndDate)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramClientID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramRegisteredStudentCount.getSQLQuotedValueForAdd(),
paramAssignedStudentCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.getSQLQuotedValueForAdd(),
paramAverageTermBill.getSQLQuotedValueForAdd(),
paramRatePerStudent.getSQLQuotedValueForAdd(),
paramBilledPerStudent.getSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.getSQLQuotedValueForAdd(),
paramTermStartDate.getSQLQuotedValueForAdd(),
paramTermEndDate.getSQLQuotedValueForAdd()  ), True)




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
ByVal pTermID As Int32,
ByVal pRegisteredStudentCount As Int32,
ByVal pAssignedStudentCount As Int32,
ByVal pSCADWAREAccessCount As Int32,
ByVal pSCADWAREAccessThreshold As Decimal,
ByVal pAverageTermBill As Decimal,
ByVal pRatePerStudent As Decimal,
ByVal pBilledPerStudent As Decimal,
ByVal pTotalReceivedOnSCADWAREBill As Decimal,
ByVal pMinimumExpectedOnSCADWAREBill As Decimal,
ByVal pExpectedOnSCADWAREBill As Decimal,
ByVal pIPAddress As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pFullScholarshipStudentCount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermStartDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTermEndDate As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramRegisteredStudentCount As DataColumnParameter = New DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount)
 Dim paramAssignedStudentCount As DataColumnParameter = New DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount)
 Dim paramSCADWAREAccessCount As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount)
 Dim paramSCADWAREAccessThreshold As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold)
 Dim paramAverageTermBill As DataColumnParameter = New DataColumnParameter(defAverageTermBill, pAverageTermBill)
 Dim paramRatePerStudent As DataColumnParameter = New DataColumnParameter(defRatePerStudent, pRatePerStudent)
 Dim paramBilledPerStudent As DataColumnParameter = New DataColumnParameter(defBilledPerStudent, pBilledPerStudent)
 Dim paramTotalReceivedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill)
 Dim paramMinimumExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill)
 Dim paramExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramFullScholarshipStudentCount As DataColumnParameter = New DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount)
 Dim paramTermStartDate As DataColumnParameter = New DataColumnParameter(defTermStartDate, pTermStartDate)
 Dim paramTermEndDate As DataColumnParameter = New DataColumnParameter(defTermEndDate, pTermEndDate)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([ClientID],[TermID],[RegisteredStudentCount],[AssignedStudentCount],[SCADWAREAccessCount],[SCADWAREAccessThreshold],[AverageTermBill],[RatePerStudent],[BilledPerStudent],[TotalReceivedOnSCADWAREBill],[MinimumExpectedOnSCADWAREBill],[ExpectedOnSCADWAREBill],[IPAddress],[CreatedAt],[FullScholarshipStudentCount],[TermStartDate],[TermEndDate]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) ", TABLE_NAME,paramClientID.getSQLQuotedValueForAdd(),
paramTermID.getSQLQuotedValueForAdd(),
paramRegisteredStudentCount.getSQLQuotedValueForAdd(),
paramAssignedStudentCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessCount.getSQLQuotedValueForAdd(),
paramSCADWAREAccessThreshold.getSQLQuotedValueForAdd(),
paramAverageTermBill.getSQLQuotedValueForAdd(),
paramRatePerStudent.getSQLQuotedValueForAdd(),
paramBilledPerStudent.getSQLQuotedValueForAdd(),
paramTotalReceivedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramMinimumExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramExpectedOnSCADWAREBill.getSQLQuotedValueForAdd(),
paramIPAddress.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramFullScholarshipStudentCount.getSQLQuotedValueForAdd(),
paramTermStartDate.getSQLQuotedValueForAdd(),
paramTermEndDate.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pTermID As Object=Nothing,
Optional ByVal pRegisteredStudentCount As Object=Nothing,
Optional ByVal pAssignedStudentCount As Object=Nothing,
Optional ByVal pSCADWAREAccessCount As Object=Nothing,
Optional ByVal pSCADWAREAccessThreshold As Object=Nothing,
Optional ByVal pAverageTermBill As Object=Nothing,
Optional ByVal pRatePerStudent As Object=Nothing,
Optional ByVal pBilledPerStudent As Object=Nothing,
Optional ByVal pTotalReceivedOnSCADWAREBill As Object=Nothing,
Optional ByVal pMinimumExpectedOnSCADWAREBill As Object=Nothing,
Optional ByVal pExpectedOnSCADWAREBill As Object=Nothing,
Optional ByVal pIPAddress As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pFullScholarshipStudentCount As Object=Nothing,
Optional ByVal pTermStartDate As Object=Nothing,
Optional ByVal pTermEndDate As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramClientID As DataColumnParameter = New DataColumnParameter(defClientID, pClientID)
 Dim paramTermID As DataColumnParameter = New DataColumnParameter(defTermID, pTermID)
 Dim paramRegisteredStudentCount As DataColumnParameter = New DataColumnParameter(defRegisteredStudentCount, pRegisteredStudentCount)
 Dim paramAssignedStudentCount As DataColumnParameter = New DataColumnParameter(defAssignedStudentCount, pAssignedStudentCount)
 Dim paramSCADWAREAccessCount As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessCount, pSCADWAREAccessCount)
 Dim paramSCADWAREAccessThreshold As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessThreshold, pSCADWAREAccessThreshold)
 Dim paramAverageTermBill As DataColumnParameter = New DataColumnParameter(defAverageTermBill, pAverageTermBill)
 Dim paramRatePerStudent As DataColumnParameter = New DataColumnParameter(defRatePerStudent, pRatePerStudent)
 Dim paramBilledPerStudent As DataColumnParameter = New DataColumnParameter(defBilledPerStudent, pBilledPerStudent)
 Dim paramTotalReceivedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defTotalReceivedOnSCADWAREBill, pTotalReceivedOnSCADWAREBill)
 Dim paramMinimumExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defMinimumExpectedOnSCADWAREBill, pMinimumExpectedOnSCADWAREBill)
 Dim paramExpectedOnSCADWAREBill As DataColumnParameter = New DataColumnParameter(defExpectedOnSCADWAREBill, pExpectedOnSCADWAREBill)
 Dim paramIPAddress As DataColumnParameter = New DataColumnParameter(defIPAddress, pIPAddress)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramFullScholarshipStudentCount As DataColumnParameter = New DataColumnParameter(defFullScholarshipStudentCount, pFullScholarshipStudentCount)
 Dim paramTermStartDate As DataColumnParameter = New DataColumnParameter(defTermStartDate, pTermStartDate)
 Dim paramTermEndDate As DataColumnParameter = New DataColumnParameter(defTermEndDate, pTermEndDate)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [ClientID]={2},[TermID]={3},[RegisteredStudentCount]={4},[AssignedStudentCount]={5},[SCADWAREAccessCount]={6},[SCADWAREAccessThreshold]={7},[AverageTermBill]={8},[RatePerStudent]={9},[BilledPerStudent]={10},[TotalReceivedOnSCADWAREBill]={11},[MinimumExpectedOnSCADWAREBill]={12},[ExpectedOnSCADWAREBill]={13},[IPAddress]={14},[CreatedAt]={15},[FullScholarshipStudentCount]={16},[TermStartDate]={17},[TermEndDate]={18} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramClientID.getSQLQuotedValueForUpdate(),
paramTermID.getSQLQuotedValueForUpdate(),
paramRegisteredStudentCount.getSQLQuotedValueForUpdate(),
paramAssignedStudentCount.getSQLQuotedValueForUpdate(),
paramSCADWAREAccessCount.getSQLQuotedValueForUpdate(),
paramSCADWAREAccessThreshold.getSQLQuotedValueForUpdate(),
paramAverageTermBill.getSQLQuotedValueForUpdate(),
paramRatePerStudent.getSQLQuotedValueForUpdate(),
paramBilledPerStudent.getSQLQuotedValueForUpdate(),
paramTotalReceivedOnSCADWAREBill.getSQLQuotedValueForUpdate(),
paramMinimumExpectedOnSCADWAREBill.getSQLQuotedValueForUpdate(),
paramExpectedOnSCADWAREBill.getSQLQuotedValueForUpdate(),
paramIPAddress.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramFullScholarshipStudentCount.getSQLQuotedValueForUpdate(),
paramTermStartDate.getSQLQuotedValueForUpdate(),
paramTermEndDate.getSQLQuotedValueForUpdate()  ), True)


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
