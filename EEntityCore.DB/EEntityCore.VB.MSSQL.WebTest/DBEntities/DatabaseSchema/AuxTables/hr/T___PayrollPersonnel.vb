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

Public Class T___PayrollPersonnel
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPayrollID = New DataColumnDefinition(TableColumnNames.PayrollID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defPersonnelID = New DataColumnDefinition(TableColumnNames.PersonnelID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defAttendanceCount = New DataColumnDefinition(TableColumnNames.AttendanceCount.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSalaryAmount = New DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRatePerDay = New DataColumnDefinition(TableColumnNames.RatePerDay.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCalculatedAmount = New DataColumnDefinition(TableColumnNames.CalculatedAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsDisbursed = New DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHRComments = New DataColumnDefinition(TableColumnNames.HRComments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defApprovedAmount = New DataColumnDefinition(TableColumnNames.ApprovedAmount.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBursarComments = New DataColumnDefinition(TableColumnNames.BursarComments.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDisbursedAmount = New DataColumnDefinition(TableColumnNames.DisbursedAmount.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defDisbursedAt = New DataColumnDefinition(TableColumnNames.DisbursedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPayrollID.ColumnName, defPayrollID) 
  ColumnDefns.Add(defPersonnelID.ColumnName, defPersonnelID) 
  ColumnDefns.Add(defAttendanceCount.ColumnName, defAttendanceCount) 
  ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount) 
  ColumnDefns.Add(defRatePerDay.ColumnName, defRatePerDay) 
  ColumnDefns.Add(defCalculatedAmount.ColumnName, defCalculatedAmount) 
  ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed) 
  ColumnDefns.Add(defHRComments.ColumnName, defHRComments) 
  ColumnDefns.Add(defApprovedAmount.ColumnName, defApprovedAmount) 
  ColumnDefns.Add(defBursarComments.ColumnName, defBursarComments) 
  ColumnDefns.Add(defDisbursedAmount.ColumnName, defDisbursedAmount) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defDisbursedAt.ColumnName, defDisbursedAt) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PayrollID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "hr.PayrollPersonnel", "hr.Payroll"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_PayrollPersonnel_PersonnelID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.PayrollPersonnel", "hr.Personnel"                  
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

       Public Const TABLE_NAME As String = "hr.PayrollPersonnel"
       Public Const PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM PayrollPersonnel"
       Public Const PayrollPersonnel__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PayrollID], [PersonnelID], [AttendanceCount], [SalaryAmount], [RatePerDay], [CalculatedAmount], [IsDisbursed], [HRComments], [ApprovedAmount], [BursarComments], [DisbursedAmount], [UpdatedAt], [CreatedAt], [CreatedByID], [DisbursedAt], [UpdatedByID] FROM PayrollPersonnel"


       Public Enum TableColumnNames

           [ID]
           [PayrollID]
           [PersonnelID]
           [AttendanceCount]
           [SalaryAmount]
           [RatePerDay]
           [CalculatedAmount]
           [IsDisbursed]
           [HRComments]
           [ApprovedAmount]
           [BursarComments]
           [DisbursedAmount]
           [UpdatedAt]
           [CreatedAt]
           [CreatedByID]
           [DisbursedAt]
           [UpdatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_hr_PayrollPersonnel 
           fk_hr_PayrollPersonnel_CreatedByID 
           fk_hr_PayrollPersonnel_UpdatedByID 
           fk_hr_PayrollPersonnel_PayrollID 
           fk_hr_PayrollPersonnel_PersonnelID 
           uq_hr_PayrollPersonnel_PersonnelID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPayrollID As DataColumnDefinition
       Public Shared ReadOnly defPersonnelID As DataColumnDefinition
       Public Shared ReadOnly defAttendanceCount As DataColumnDefinition
       Public Shared ReadOnly defSalaryAmount As DataColumnDefinition
       Public Shared ReadOnly defRatePerDay As DataColumnDefinition
       Public Shared ReadOnly defCalculatedAmount As DataColumnDefinition
       Public Shared ReadOnly defIsDisbursed As DataColumnDefinition
       Public Shared ReadOnly defHRComments As DataColumnDefinition
       Public Shared ReadOnly defApprovedAmount As DataColumnDefinition
       Public Shared ReadOnly defBursarComments As DataColumnDefinition
       Public Shared ReadOnly defDisbursedAmount As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defDisbursedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition

       Public ReadOnly Property [PayrollID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PayrollID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PersonnelID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PersonnelID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AttendanceCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AttendanceCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SalaryAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SalaryAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [RatePerDay] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.RatePerDay.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [CalculatedAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.CalculatedAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [IsDisbursed] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsDisbursed.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HRComments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HRComments.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ApprovedAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.ApprovedAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [BursarComments] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BursarComments.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DisbursedAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.DisbursedAmount.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [UpdatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.UpdatedAt.ToString()))
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


       Public ReadOnly Property [DisbursedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.DisbursedAt.ToString()))
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
        Public Function getFirstRow() As T___PayrollPersonnel                  
            If Me.hasRows() Then Return New T___PayrollPersonnel(Me.AllRows(0))                  
            Return New T___PayrollPersonnel()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PayrollPersonnel                  
            Return New T___PayrollPersonnel(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PayrollPersonnel                  
            Return New T___PayrollPersonnel(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PayrollPersonnel                  
            Return New T___PayrollPersonnel(Me.RawTable, T___PayrollPersonnel.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PayrollPersonnel,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PayrollPersonnel,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PayrollPersonnel                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PayrollPersonnel(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PayrollPersonnel(drst.CopyToDataTable(),                  
                    T___PayrollPersonnel.TABLE_NAME)                  
                Return New T___PayrollPersonnel()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PayrollPersonnel()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PayrollPersonnel                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PayrollPersonnel(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PayrollPersonnel(drst.CopyToDataTable(),                  
                    T___PayrollPersonnel.TABLE_NAME)                  
                Return New T___PayrollPersonnel()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PayrollPersonnel()                  
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
            Return PayrollPersonnel__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPayrollID As Int32,
ByVal pPersonnelID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPayrollID As DataColumnParameter = New DataColumnParameter(defPayrollID, pPayrollID)
 Dim paramPersonnelID As DataColumnParameter = New DataColumnParameter(defPersonnelID, pPersonnelID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramAttendanceCount As DataColumnParameter = New DataColumnParameter(defAttendanceCount, defAttendanceCount.DefaultValue)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, defSalaryAmount.DefaultValue)
 Dim paramRatePerDay As DataColumnParameter = New DataColumnParameter(defRatePerDay, defRatePerDay.DefaultValue)
 Dim paramCalculatedAmount As DataColumnParameter = New DataColumnParameter(defCalculatedAmount, defCalculatedAmount.DefaultValue)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, defIsDisbursed.DefaultValue)
 Dim paramHRComments As DataColumnParameter = New DataColumnParameter(defHRComments, defHRComments.DefaultValue)
 Dim paramApprovedAmount As DataColumnParameter = New DataColumnParameter(defApprovedAmount, defApprovedAmount.DefaultValue)
 Dim paramBursarComments As DataColumnParameter = New DataColumnParameter(defBursarComments, defBursarComments.DefaultValue)
 Dim paramDisbursedAmount As DataColumnParameter = New DataColumnParameter(defDisbursedAmount, defDisbursedAmount.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramDisbursedAt As DataColumnParameter = New DataColumnParameter(defDisbursedAt, defDisbursedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPayrollID.getSQLQuotedValueForAdd(),
paramPersonnelID.getSQLQuotedValueForAdd(),
paramAttendanceCount.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramRatePerDay.getSQLQuotedValueForAdd(),
paramCalculatedAmount.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
paramHRComments.getSQLQuotedValueForAdd(),
paramApprovedAmount.getSQLQuotedValueForAdd(),
paramBursarComments.getSQLQuotedValueForAdd(),
paramDisbursedAmount.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramDisbursedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPayrollID As Int32,
ByVal pPersonnelID As Int32,
ByVal pAttendanceCount As Int32,
ByVal pSalaryAmount As Decimal,
ByVal pRatePerDay As Decimal,
ByVal pCalculatedAmount As Decimal,
ByVal pIsDisbursed As Boolean,
ByVal pApprovedAmount As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pHRComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBursarComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPayrollID As DataColumnParameter = New DataColumnParameter(defPayrollID, pPayrollID)
 Dim paramPersonnelID As DataColumnParameter = New DataColumnParameter(defPersonnelID, pPersonnelID)
 Dim paramAttendanceCount As DataColumnParameter = New DataColumnParameter(defAttendanceCount, pAttendanceCount)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramRatePerDay As DataColumnParameter = New DataColumnParameter(defRatePerDay, pRatePerDay)
 Dim paramCalculatedAmount As DataColumnParameter = New DataColumnParameter(defCalculatedAmount, pCalculatedAmount)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramHRComments As DataColumnParameter = New DataColumnParameter(defHRComments, pHRComments)
 Dim paramApprovedAmount As DataColumnParameter = New DataColumnParameter(defApprovedAmount, pApprovedAmount)
 Dim paramBursarComments As DataColumnParameter = New DataColumnParameter(defBursarComments, pBursarComments)
 Dim paramDisbursedAmount As DataColumnParameter = New DataColumnParameter(defDisbursedAmount, pDisbursedAmount)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramDisbursedAt As DataColumnParameter = New DataColumnParameter(defDisbursedAt, pDisbursedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPayrollID.getSQLQuotedValueForAdd(),
paramPersonnelID.getSQLQuotedValueForAdd(),
paramAttendanceCount.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramRatePerDay.getSQLQuotedValueForAdd(),
paramCalculatedAmount.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
paramHRComments.getSQLQuotedValueForAdd(),
paramApprovedAmount.getSQLQuotedValueForAdd(),
paramBursarComments.getSQLQuotedValueForAdd(),
paramDisbursedAmount.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramDisbursedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPayrollID As Int32,
ByVal pPersonnelID As Int32,
ByVal pAttendanceCount As Int32,
ByVal pSalaryAmount As Decimal,
ByVal pRatePerDay As Decimal,
ByVal pCalculatedAmount As Decimal,
ByVal pIsDisbursed As Boolean,
ByVal pApprovedAmount As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pHRComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBursarComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPayrollID As DataColumnParameter = New DataColumnParameter(defPayrollID, pPayrollID)
 Dim paramPersonnelID As DataColumnParameter = New DataColumnParameter(defPersonnelID, pPersonnelID)
 Dim paramAttendanceCount As DataColumnParameter = New DataColumnParameter(defAttendanceCount, pAttendanceCount)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramRatePerDay As DataColumnParameter = New DataColumnParameter(defRatePerDay, pRatePerDay)
 Dim paramCalculatedAmount As DataColumnParameter = New DataColumnParameter(defCalculatedAmount, pCalculatedAmount)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramHRComments As DataColumnParameter = New DataColumnParameter(defHRComments, pHRComments)
 Dim paramApprovedAmount As DataColumnParameter = New DataColumnParameter(defApprovedAmount, pApprovedAmount)
 Dim paramBursarComments As DataColumnParameter = New DataColumnParameter(defBursarComments, pBursarComments)
 Dim paramDisbursedAmount As DataColumnParameter = New DataColumnParameter(defDisbursedAmount, pDisbursedAmount)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramDisbursedAt As DataColumnParameter = New DataColumnParameter(defDisbursedAt, pDisbursedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPayrollID.getSQLQuotedValueForAdd(),
paramPersonnelID.getSQLQuotedValueForAdd(),
paramAttendanceCount.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramRatePerDay.getSQLQuotedValueForAdd(),
paramCalculatedAmount.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
paramHRComments.getSQLQuotedValueForAdd(),
paramApprovedAmount.getSQLQuotedValueForAdd(),
paramBursarComments.getSQLQuotedValueForAdd(),
paramDisbursedAmount.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramDisbursedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pPayrollID As Int32,
ByVal pPersonnelID As Int32,
ByVal pAttendanceCount As Int32,
ByVal pSalaryAmount As Decimal,
ByVal pRatePerDay As Decimal,
ByVal pCalculatedAmount As Decimal,
ByVal pIsDisbursed As Boolean,
ByVal pApprovedAmount As Decimal,
ByVal pCreatedAt As DateTime,
ByVal pCreatedByID As Int32,
Optional ByVal pHRComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBursarComments As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDisbursedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramPayrollID As DataColumnParameter = New DataColumnParameter(defPayrollID, pPayrollID)
 Dim paramPersonnelID As DataColumnParameter = New DataColumnParameter(defPersonnelID, pPersonnelID)
 Dim paramAttendanceCount As DataColumnParameter = New DataColumnParameter(defAttendanceCount, pAttendanceCount)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramRatePerDay As DataColumnParameter = New DataColumnParameter(defRatePerDay, pRatePerDay)
 Dim paramCalculatedAmount As DataColumnParameter = New DataColumnParameter(defCalculatedAmount, pCalculatedAmount)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramHRComments As DataColumnParameter = New DataColumnParameter(defHRComments, pHRComments)
 Dim paramApprovedAmount As DataColumnParameter = New DataColumnParameter(defApprovedAmount, pApprovedAmount)
 Dim paramBursarComments As DataColumnParameter = New DataColumnParameter(defBursarComments, pBursarComments)
 Dim paramDisbursedAmount As DataColumnParameter = New DataColumnParameter(defDisbursedAmount, pDisbursedAmount)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramDisbursedAt As DataColumnParameter = New DataColumnParameter(defDisbursedAt, pDisbursedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([PayrollID],[PersonnelID],[AttendanceCount],[SalaryAmount],[RatePerDay],[CalculatedAmount],[IsDisbursed],[HRComments],[ApprovedAmount],[BursarComments],[DisbursedAmount],[UpdatedAt],[CreatedAt],[CreatedByID],[DisbursedAt],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramPayrollID.getSQLQuotedValueForAdd(),
paramPersonnelID.getSQLQuotedValueForAdd(),
paramAttendanceCount.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramRatePerDay.getSQLQuotedValueForAdd(),
paramCalculatedAmount.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
paramHRComments.getSQLQuotedValueForAdd(),
paramApprovedAmount.getSQLQuotedValueForAdd(),
paramBursarComments.getSQLQuotedValueForAdd(),
paramDisbursedAmount.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramDisbursedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pPayrollID As Object=Nothing,
Optional ByVal pPersonnelID As Object=Nothing,
Optional ByVal pAttendanceCount As Object=Nothing,
Optional ByVal pSalaryAmount As Object=Nothing,
Optional ByVal pRatePerDay As Object=Nothing,
Optional ByVal pCalculatedAmount As Object=Nothing,
Optional ByVal pIsDisbursed As Object=Nothing,
Optional ByVal pApprovedAmount As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pHRComments As Object=Nothing,
Optional ByVal pBursarComments As Object=Nothing,
Optional ByVal pDisbursedAmount As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pDisbursedAt As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPayrollID As DataColumnParameter = New DataColumnParameter(defPayrollID, pPayrollID)
 Dim paramPersonnelID As DataColumnParameter = New DataColumnParameter(defPersonnelID, pPersonnelID)
 Dim paramAttendanceCount As DataColumnParameter = New DataColumnParameter(defAttendanceCount, pAttendanceCount)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramRatePerDay As DataColumnParameter = New DataColumnParameter(defRatePerDay, pRatePerDay)
 Dim paramCalculatedAmount As DataColumnParameter = New DataColumnParameter(defCalculatedAmount, pCalculatedAmount)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramHRComments As DataColumnParameter = New DataColumnParameter(defHRComments, pHRComments)
 Dim paramApprovedAmount As DataColumnParameter = New DataColumnParameter(defApprovedAmount, pApprovedAmount)
 Dim paramBursarComments As DataColumnParameter = New DataColumnParameter(defBursarComments, pBursarComments)
 Dim paramDisbursedAmount As DataColumnParameter = New DataColumnParameter(defDisbursedAmount, pDisbursedAmount)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramDisbursedAt As DataColumnParameter = New DataColumnParameter(defDisbursedAt, pDisbursedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [PayrollID]={2},[PersonnelID]={3},[AttendanceCount]={4},[SalaryAmount]={5},[RatePerDay]={6},[CalculatedAmount]={7},[IsDisbursed]={8},[HRComments]={9},[ApprovedAmount]={10},[BursarComments]={11},[DisbursedAmount]={12},[UpdatedAt]={13},[CreatedAt]={14},[CreatedByID]={15},[DisbursedAt]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPayrollID.getSQLQuotedValueForUpdate(),
paramPersonnelID.getSQLQuotedValueForUpdate(),
paramAttendanceCount.getSQLQuotedValueForUpdate(),
paramSalaryAmount.getSQLQuotedValueForUpdate(),
paramRatePerDay.getSQLQuotedValueForUpdate(),
paramCalculatedAmount.getSQLQuotedValueForUpdate(),
paramIsDisbursed.getSQLQuotedValueForUpdate(),
paramHRComments.getSQLQuotedValueForUpdate(),
paramApprovedAmount.getSQLQuotedValueForUpdate(),
paramBursarComments.getSQLQuotedValueForUpdate(),
paramDisbursedAmount.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramDisbursedAt.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate()  ), True)


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
