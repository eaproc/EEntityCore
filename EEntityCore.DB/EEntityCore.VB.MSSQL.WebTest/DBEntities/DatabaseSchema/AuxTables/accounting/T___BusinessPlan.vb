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

Public Class T___BusinessPlan
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defAcademicSessionID = New DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defStudentPopulation = New DataColumnDefinition(TableColumnNames.StudentPopulation.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAveragePricePerStudent = New DataColumnDefinition(TableColumnNames.AveragePricePerStudent.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSCADWAREAccessRevenue = New DataColumnDefinition(TableColumnNames.SCADWAREAccessRevenue.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSideContractRevenue = New DataColumnDefinition(TableColumnNames.SideContractRevenue.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGrossRevenue = New DataColumnDefinition(TableColumnNames.GrossRevenue.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defWages = New DataColumnDefinition(TableColumnNames.Wages.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMarketing = New DataColumnDefinition(TableColumnNames.Marketing.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCharity = New DataColumnDefinition(TableColumnNames.Charity.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defOthers = New DataColumnDefinition(TableColumnNames.Others.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID) 
  ColumnDefns.Add(defStudentPopulation.ColumnName, defStudentPopulation) 
  ColumnDefns.Add(defAveragePricePerStudent.ColumnName, defAveragePricePerStudent) 
  ColumnDefns.Add(defSCADWAREAccessRevenue.ColumnName, defSCADWAREAccessRevenue) 
  ColumnDefns.Add(defSideContractRevenue.ColumnName, defSideContractRevenue) 
  ColumnDefns.Add(defGrossRevenue.ColumnName, defGrossRevenue) 
  ColumnDefns.Add(defWages.ColumnName, defWages) 
  ColumnDefns.Add(defMarketing.ColumnName, defMarketing) 
  ColumnDefns.Add(defCharity.ColumnName, defCharity) 
  ColumnDefns.Add(defOthers.ColumnName, defOthers) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_BusinessPlan_AcademicSessionID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.BusinessPlan", "academic.AcademicSession"                  
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

       Public Const TABLE_NAME As String = "accounting.BusinessPlan"
       Public Const BusinessPlan__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan"
       Public Const BusinessPlan__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [AcademicSessionID], [StudentPopulation], [AveragePricePerStudent], [SCADWAREAccessRevenue], [SideContractRevenue], [GrossRevenue], [Wages], [Marketing], [Charity], [Others], [CreatedAt], [UpdatedAt] FROM BusinessPlan"


       Public Enum TableColumnNames

           [ID]
           [AcademicSessionID]
           [StudentPopulation]
           [AveragePricePerStudent]
           [SCADWAREAccessRevenue]
           [SideContractRevenue]
           [GrossRevenue]
           [Wages]
           [Marketing]
           [Charity]
           [Others]
           [CreatedAt]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_BusinessPlan 
           fk_accounting_BusinessPlan_AcademicSessionID 
           uq_accounting_BusinessPlan_AcademicSessionID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defAcademicSessionID As DataColumnDefinition
       Public Shared ReadOnly defStudentPopulation As DataColumnDefinition
       Public Shared ReadOnly defAveragePricePerStudent As DataColumnDefinition
       Public Shared ReadOnly defSCADWAREAccessRevenue As DataColumnDefinition
       Public Shared ReadOnly defSideContractRevenue As DataColumnDefinition
       Public Shared ReadOnly defGrossRevenue As DataColumnDefinition
       Public Shared ReadOnly defWages As DataColumnDefinition
       Public Shared ReadOnly defMarketing As DataColumnDefinition
       Public Shared ReadOnly defCharity As DataColumnDefinition
       Public Shared ReadOnly defOthers As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [AcademicSessionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AcademicSessionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StudentPopulation] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.StudentPopulation.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AveragePricePerStudent] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.AveragePricePerStudent.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [SCADWAREAccessRevenue] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SCADWAREAccessRevenue.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [SideContractRevenue] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SideContractRevenue.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [GrossRevenue] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.GrossRevenue.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Wages] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Wages.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Marketing] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Marketing.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Charity] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Charity.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [Others] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.Others.ToString())) )
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


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___BusinessPlan                  
            If Me.hasRows() Then Return New T___BusinessPlan(Me.AllRows(0))                  
            Return New T___BusinessPlan()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___BusinessPlan                  
            Return New T___BusinessPlan(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___BusinessPlan                  
            Return New T___BusinessPlan(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___BusinessPlan                  
            Return New T___BusinessPlan(Me.RawTable, T___BusinessPlan.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___BusinessPlan,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___BusinessPlan,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___BusinessPlan                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___BusinessPlan(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___BusinessPlan(drst.CopyToDataTable(),                  
                    T___BusinessPlan.TABLE_NAME)                  
                Return New T___BusinessPlan()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___BusinessPlan()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___BusinessPlan                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___BusinessPlan(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___BusinessPlan(drst.CopyToDataTable(),                  
                    T___BusinessPlan.TABLE_NAME)                  
                Return New T___BusinessPlan()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___BusinessPlan()                  
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
            Return BusinessPlan__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pAcademicSessionID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramStudentPopulation As DataColumnParameter = New DataColumnParameter(defStudentPopulation, defStudentPopulation.DefaultValue)
 Dim paramAveragePricePerStudent As DataColumnParameter = New DataColumnParameter(defAveragePricePerStudent, defAveragePricePerStudent.DefaultValue)
 Dim paramSCADWAREAccessRevenue As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessRevenue, defSCADWAREAccessRevenue.DefaultValue)
 Dim paramSideContractRevenue As DataColumnParameter = New DataColumnParameter(defSideContractRevenue, defSideContractRevenue.DefaultValue)
 Dim paramGrossRevenue As DataColumnParameter = New DataColumnParameter(defGrossRevenue, defGrossRevenue.DefaultValue)
 Dim paramWages As DataColumnParameter = New DataColumnParameter(defWages, defWages.DefaultValue)
 Dim paramMarketing As DataColumnParameter = New DataColumnParameter(defMarketing, defMarketing.DefaultValue)
 Dim paramCharity As DataColumnParameter = New DataColumnParameter(defCharity, defCharity.DefaultValue)
 Dim paramOthers As DataColumnParameter = New DataColumnParameter(defOthers, defOthers.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramStudentPopulation.getSQLQuotedValueForAdd(),
paramAveragePricePerStudent.getSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.getSQLQuotedValueForAdd(),
paramSideContractRevenue.getSQLQuotedValueForAdd(),
paramGrossRevenue.getSQLQuotedValueForAdd(),
paramWages.getSQLQuotedValueForAdd(),
paramMarketing.getSQLQuotedValueForAdd(),
paramCharity.getSQLQuotedValueForAdd(),
paramOthers.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pAcademicSessionID As Int32,
ByVal pStudentPopulation As Int32,
ByVal pAveragePricePerStudent As Decimal,
ByVal pSCADWAREAccessRevenue As Decimal,
ByVal pSideContractRevenue As Decimal,
ByVal pGrossRevenue As Decimal,
ByVal pWages As Decimal,
ByVal pMarketing As Decimal,
ByVal pCharity As Decimal,
ByVal pOthers As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramStudentPopulation As DataColumnParameter = New DataColumnParameter(defStudentPopulation, pStudentPopulation)
 Dim paramAveragePricePerStudent As DataColumnParameter = New DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent)
 Dim paramSCADWAREAccessRevenue As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue)
 Dim paramSideContractRevenue As DataColumnParameter = New DataColumnParameter(defSideContractRevenue, pSideContractRevenue)
 Dim paramGrossRevenue As DataColumnParameter = New DataColumnParameter(defGrossRevenue, pGrossRevenue)
 Dim paramWages As DataColumnParameter = New DataColumnParameter(defWages, pWages)
 Dim paramMarketing As DataColumnParameter = New DataColumnParameter(defMarketing, pMarketing)
 Dim paramCharity As DataColumnParameter = New DataColumnParameter(defCharity, pCharity)
 Dim paramOthers As DataColumnParameter = New DataColumnParameter(defOthers, pOthers)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramStudentPopulation.getSQLQuotedValueForAdd(),
paramAveragePricePerStudent.getSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.getSQLQuotedValueForAdd(),
paramSideContractRevenue.getSQLQuotedValueForAdd(),
paramGrossRevenue.getSQLQuotedValueForAdd(),
paramWages.getSQLQuotedValueForAdd(),
paramMarketing.getSQLQuotedValueForAdd(),
paramCharity.getSQLQuotedValueForAdd(),
paramOthers.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pAcademicSessionID As Int32,
ByVal pStudentPopulation As Int32,
ByVal pAveragePricePerStudent As Decimal,
ByVal pSCADWAREAccessRevenue As Decimal,
ByVal pSideContractRevenue As Decimal,
ByVal pGrossRevenue As Decimal,
ByVal pWages As Decimal,
ByVal pMarketing As Decimal,
ByVal pCharity As Decimal,
ByVal pOthers As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramStudentPopulation As DataColumnParameter = New DataColumnParameter(defStudentPopulation, pStudentPopulation)
 Dim paramAveragePricePerStudent As DataColumnParameter = New DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent)
 Dim paramSCADWAREAccessRevenue As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue)
 Dim paramSideContractRevenue As DataColumnParameter = New DataColumnParameter(defSideContractRevenue, pSideContractRevenue)
 Dim paramGrossRevenue As DataColumnParameter = New DataColumnParameter(defGrossRevenue, pGrossRevenue)
 Dim paramWages As DataColumnParameter = New DataColumnParameter(defWages, pWages)
 Dim paramMarketing As DataColumnParameter = New DataColumnParameter(defMarketing, pMarketing)
 Dim paramCharity As DataColumnParameter = New DataColumnParameter(defCharity, pCharity)
 Dim paramOthers As DataColumnParameter = New DataColumnParameter(defOthers, pOthers)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramStudentPopulation.getSQLQuotedValueForAdd(),
paramAveragePricePerStudent.getSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.getSQLQuotedValueForAdd(),
paramSideContractRevenue.getSQLQuotedValueForAdd(),
paramGrossRevenue.getSQLQuotedValueForAdd(),
paramWages.getSQLQuotedValueForAdd(),
paramMarketing.getSQLQuotedValueForAdd(),
paramCharity.getSQLQuotedValueForAdd(),
paramOthers.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pAcademicSessionID As Int32,
ByVal pStudentPopulation As Int32,
ByVal pAveragePricePerStudent As Decimal,
ByVal pSCADWAREAccessRevenue As Decimal,
ByVal pSideContractRevenue As Decimal,
ByVal pGrossRevenue As Decimal,
ByVal pWages As Decimal,
ByVal pMarketing As Decimal,
ByVal pCharity As Decimal,
ByVal pOthers As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramStudentPopulation As DataColumnParameter = New DataColumnParameter(defStudentPopulation, pStudentPopulation)
 Dim paramAveragePricePerStudent As DataColumnParameter = New DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent)
 Dim paramSCADWAREAccessRevenue As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue)
 Dim paramSideContractRevenue As DataColumnParameter = New DataColumnParameter(defSideContractRevenue, pSideContractRevenue)
 Dim paramGrossRevenue As DataColumnParameter = New DataColumnParameter(defGrossRevenue, pGrossRevenue)
 Dim paramWages As DataColumnParameter = New DataColumnParameter(defWages, pWages)
 Dim paramMarketing As DataColumnParameter = New DataColumnParameter(defMarketing, pMarketing)
 Dim paramCharity As DataColumnParameter = New DataColumnParameter(defCharity, pCharity)
 Dim paramOthers As DataColumnParameter = New DataColumnParameter(defOthers, pOthers)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([AcademicSessionID],[StudentPopulation],[AveragePricePerStudent],[SCADWAREAccessRevenue],[SideContractRevenue],[GrossRevenue],[Wages],[Marketing],[Charity],[Others],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramStudentPopulation.getSQLQuotedValueForAdd(),
paramAveragePricePerStudent.getSQLQuotedValueForAdd(),
paramSCADWAREAccessRevenue.getSQLQuotedValueForAdd(),
paramSideContractRevenue.getSQLQuotedValueForAdd(),
paramGrossRevenue.getSQLQuotedValueForAdd(),
paramWages.getSQLQuotedValueForAdd(),
paramMarketing.getSQLQuotedValueForAdd(),
paramCharity.getSQLQuotedValueForAdd(),
paramOthers.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pAcademicSessionID As Object=Nothing,
Optional ByVal pStudentPopulation As Object=Nothing,
Optional ByVal pAveragePricePerStudent As Object=Nothing,
Optional ByVal pSCADWAREAccessRevenue As Object=Nothing,
Optional ByVal pSideContractRevenue As Object=Nothing,
Optional ByVal pGrossRevenue As Object=Nothing,
Optional ByVal pWages As Object=Nothing,
Optional ByVal pMarketing As Object=Nothing,
Optional ByVal pCharity As Object=Nothing,
Optional ByVal pOthers As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramStudentPopulation As DataColumnParameter = New DataColumnParameter(defStudentPopulation, pStudentPopulation)
 Dim paramAveragePricePerStudent As DataColumnParameter = New DataColumnParameter(defAveragePricePerStudent, pAveragePricePerStudent)
 Dim paramSCADWAREAccessRevenue As DataColumnParameter = New DataColumnParameter(defSCADWAREAccessRevenue, pSCADWAREAccessRevenue)
 Dim paramSideContractRevenue As DataColumnParameter = New DataColumnParameter(defSideContractRevenue, pSideContractRevenue)
 Dim paramGrossRevenue As DataColumnParameter = New DataColumnParameter(defGrossRevenue, pGrossRevenue)
 Dim paramWages As DataColumnParameter = New DataColumnParameter(defWages, pWages)
 Dim paramMarketing As DataColumnParameter = New DataColumnParameter(defMarketing, pMarketing)
 Dim paramCharity As DataColumnParameter = New DataColumnParameter(defCharity, pCharity)
 Dim paramOthers As DataColumnParameter = New DataColumnParameter(defOthers, pOthers)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [AcademicSessionID]={2},[StudentPopulation]={3},[AveragePricePerStudent]={4},[SCADWAREAccessRevenue]={5},[SideContractRevenue]={6},[GrossRevenue]={7},[Wages]={8},[Marketing]={9},[Charity]={10},[Others]={11},[CreatedAt]={12},[UpdatedAt]={13} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramAcademicSessionID.getSQLQuotedValueForUpdate(),
paramStudentPopulation.getSQLQuotedValueForUpdate(),
paramAveragePricePerStudent.getSQLQuotedValueForUpdate(),
paramSCADWAREAccessRevenue.getSQLQuotedValueForUpdate(),
paramSideContractRevenue.getSQLQuotedValueForUpdate(),
paramGrossRevenue.getSQLQuotedValueForUpdate(),
paramWages.getSQLQuotedValueForUpdate(),
paramMarketing.getSQLQuotedValueForUpdate(),
paramCharity.getSQLQuotedValueForUpdate(),
paramOthers.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate()  ), True)


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
