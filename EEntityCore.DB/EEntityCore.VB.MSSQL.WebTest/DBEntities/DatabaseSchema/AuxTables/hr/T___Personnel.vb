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

Public Class T___Personnel
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPersonnelNumber = New DataColumnDefinition(TableColumnNames.PersonnelNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defPersonID = New DataColumnDefinition(TableColumnNames.PersonID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIsActive = New DataColumnDefinition(TableColumnNames.IsActive.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmploymentDate = New DataColumnDefinition(TableColumnNames.EmploymentDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsSuperUser = New DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPositionID = New DataColumnDefinition(TableColumnNames.PositionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defSalaryTypeID = New DataColumnDefinition(TableColumnNames.SalaryTypeID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defSalaryAmount = New DataColumnDefinition(TableColumnNames.SalaryAmount.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDuties = New DataColumnDefinition(TableColumnNames.Duties.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsWebVisible = New DataColumnDefinition(TableColumnNames.IsWebVisible.ToString(), GetType(Boolean), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPersonnelNumber.ColumnName, defPersonnelNumber) 
  ColumnDefns.Add(defPersonID.ColumnName, defPersonID) 
  ColumnDefns.Add(defIsActive.ColumnName, defIsActive) 
  ColumnDefns.Add(defEmploymentDate.ColumnName, defEmploymentDate) 
  ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser) 
  ColumnDefns.Add(defPositionID.ColumnName, defPositionID) 
  ColumnDefns.Add(defSalaryTypeID.ColumnName, defSalaryTypeID) 
  ColumnDefns.Add(defSalaryAmount.ColumnName, defSalaryAmount) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defDuties.ColumnName, defDuties) 
  ColumnDefns.Add(defIsWebVisible.ColumnName, defIsWebVisible) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PersonID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "common.Person"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_PositionID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.Position"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_SalaryTypeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "hr.SalaryType"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Personnel_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Personnel", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "hr.Personnel"
       Public Const Personnel__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM Personnel"
       Public Const Personnel__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PersonnelNumber], [PersonID], [IsActive], [EmploymentDate], [IsSuperUser], [PositionID], [SalaryTypeID], [SalaryAmount], [CreatedByID], [UpdatedByID], [CreatedAt], [UpdatedAt], [Duties], [IsWebVisible] FROM Personnel"


       Public Enum TableColumnNames

           [ID]
           [PersonnelNumber]
           [PersonID]
           [IsActive]
           [EmploymentDate]
           [IsSuperUser]
           [PositionID]
           [SalaryTypeID]
           [SalaryAmount]
           [CreatedByID]
           [UpdatedByID]
           [CreatedAt]
           [UpdatedAt]
           [Duties]
           [IsWebVisible]
       End Enum 



       Public Enum TableConstraints

           pk_hr_Personnel 
           fk_hr_Personnel_PersonID 
           fk_hr_Personnel_PositionID 
           fk_hr_Personnel_SalaryTypeID 
           fk_hr_Personnel_CreatedByID 
           fk_hr_Personnel_UpdatedByID 
           uq_hr_Personnel_PersonnelNumber 
           uq_hr_Personnel_PersonID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPersonnelNumber As DataColumnDefinition
       Public Shared ReadOnly defPersonID As DataColumnDefinition
       Public Shared ReadOnly defIsActive As DataColumnDefinition
       Public Shared ReadOnly defEmploymentDate As DataColumnDefinition
       Public Shared ReadOnly defIsSuperUser As DataColumnDefinition
       Public Shared ReadOnly defPositionID As DataColumnDefinition
       Public Shared ReadOnly defSalaryTypeID As DataColumnDefinition
       Public Shared ReadOnly defSalaryAmount As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defDuties As DataColumnDefinition
       Public Shared ReadOnly defIsWebVisible As DataColumnDefinition

       Public ReadOnly Property [PersonnelNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PersonnelNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PersonID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PersonID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsActive] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsActive.ToString()))
           End Get
       End Property


       Public ReadOnly Property [EmploymentDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.EmploymentDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsSuperUser] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsSuperUser.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PositionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PositionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SalaryTypeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.SalaryTypeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SalaryAmount] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SalaryAmount.ToString())) )
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


       Public ReadOnly Property [Duties] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Duties.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsWebVisible] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsWebVisible.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Personnel                  
            If Me.hasRows() Then Return New T___Personnel(Me.AllRows(0))                  
            Return New T___Personnel()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Personnel                  
            Return New T___Personnel(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Personnel                  
            Return New T___Personnel(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Personnel                  
            Return New T___Personnel(Me.RawTable, T___Personnel.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Personnel,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Personnel,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Personnel                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Personnel(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Personnel(drst.CopyToDataTable(),                  
                    T___Personnel.TABLE_NAME)                  
                Return New T___Personnel()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Personnel()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Personnel                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Personnel(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Personnel(drst.CopyToDataTable(),                  
                    T___Personnel.TABLE_NAME)                  
                Return New T___Personnel()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Personnel()                  
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
            Return Personnel__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPersonnelNumber As String,
ByVal pPersonID As Int32,
ByVal pPositionID As Int32,
ByVal pSalaryTypeID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPersonnelNumber As DataColumnParameter = New DataColumnParameter(defPersonnelNumber, pPersonnelNumber)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramPositionID As DataColumnParameter = New DataColumnParameter(defPositionID, pPositionID)
 Dim paramSalaryTypeID As DataColumnParameter = New DataColumnParameter(defSalaryTypeID, pSalaryTypeID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, defIsActive.DefaultValue)
 Dim paramEmploymentDate As DataColumnParameter = New DataColumnParameter(defEmploymentDate, defEmploymentDate.DefaultValue)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, defIsSuperUser.DefaultValue)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, defSalaryAmount.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramDuties As DataColumnParameter = New DataColumnParameter(defDuties, defDuties.DefaultValue)
 Dim paramIsWebVisible As DataColumnParameter = New DataColumnParameter(defIsWebVisible, defIsWebVisible.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonnelNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramEmploymentDate.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramPositionID.getSQLQuotedValueForAdd(),
paramSalaryTypeID.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDuties.getSQLQuotedValueForAdd(),
paramIsWebVisible.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPersonnelNumber As String,
ByVal pPersonID As Int32,
ByVal pIsActive As Boolean,
ByVal pEmploymentDate As DateTime,
ByVal pIsSuperUser As Boolean,
ByVal pPositionID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pSalaryTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSalaryAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDuties As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsWebVisible As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPersonnelNumber As DataColumnParameter = New DataColumnParameter(defPersonnelNumber, pPersonnelNumber)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramEmploymentDate As DataColumnParameter = New DataColumnParameter(defEmploymentDate, pEmploymentDate)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramPositionID As DataColumnParameter = New DataColumnParameter(defPositionID, pPositionID)
 Dim paramSalaryTypeID As DataColumnParameter = New DataColumnParameter(defSalaryTypeID, pSalaryTypeID)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDuties As DataColumnParameter = New DataColumnParameter(defDuties, pDuties)
 Dim paramIsWebVisible As DataColumnParameter = New DataColumnParameter(defIsWebVisible, pIsWebVisible)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonnelNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramEmploymentDate.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramPositionID.getSQLQuotedValueForAdd(),
paramSalaryTypeID.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDuties.getSQLQuotedValueForAdd(),
paramIsWebVisible.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPersonnelNumber As String,
ByVal pPersonID As Int32,
ByVal pIsActive As Boolean,
ByVal pEmploymentDate As DateTime,
ByVal pIsSuperUser As Boolean,
ByVal pPositionID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pSalaryTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSalaryAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDuties As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsWebVisible As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPersonnelNumber As DataColumnParameter = New DataColumnParameter(defPersonnelNumber, pPersonnelNumber)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramEmploymentDate As DataColumnParameter = New DataColumnParameter(defEmploymentDate, pEmploymentDate)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramPositionID As DataColumnParameter = New DataColumnParameter(defPositionID, pPositionID)
 Dim paramSalaryTypeID As DataColumnParameter = New DataColumnParameter(defSalaryTypeID, pSalaryTypeID)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDuties As DataColumnParameter = New DataColumnParameter(defDuties, pDuties)
 Dim paramIsWebVisible As DataColumnParameter = New DataColumnParameter(defIsWebVisible, pIsWebVisible)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonnelNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramEmploymentDate.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramPositionID.getSQLQuotedValueForAdd(),
paramSalaryTypeID.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDuties.getSQLQuotedValueForAdd(),
paramIsWebVisible.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pPersonnelNumber As String,
ByVal pPersonID As Int32,
ByVal pIsActive As Boolean,
ByVal pEmploymentDate As DateTime,
ByVal pIsSuperUser As Boolean,
ByVal pPositionID As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pSalaryTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSalaryAmount As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDuties As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIsWebVisible As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramPersonnelNumber As DataColumnParameter = New DataColumnParameter(defPersonnelNumber, pPersonnelNumber)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramEmploymentDate As DataColumnParameter = New DataColumnParameter(defEmploymentDate, pEmploymentDate)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramPositionID As DataColumnParameter = New DataColumnParameter(defPositionID, pPositionID)
 Dim paramSalaryTypeID As DataColumnParameter = New DataColumnParameter(defSalaryTypeID, pSalaryTypeID)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDuties As DataColumnParameter = New DataColumnParameter(defDuties, pDuties)
 Dim paramIsWebVisible As DataColumnParameter = New DataColumnParameter(defIsWebVisible, pIsWebVisible)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([PersonnelNumber],[PersonID],[IsActive],[EmploymentDate],[IsSuperUser],[PositionID],[SalaryTypeID],[SalaryAmount],[CreatedByID],[UpdatedByID],[CreatedAt],[UpdatedAt],[Duties],[IsWebVisible]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) ", TABLE_NAME,paramPersonnelNumber.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramEmploymentDate.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramPositionID.getSQLQuotedValueForAdd(),
paramSalaryTypeID.getSQLQuotedValueForAdd(),
paramSalaryAmount.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDuties.getSQLQuotedValueForAdd(),
paramIsWebVisible.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pPersonnelNumber As Object=Nothing,
Optional ByVal pPersonID As Object=Nothing,
Optional ByVal pIsActive As Object=Nothing,
Optional ByVal pEmploymentDate As Object=Nothing,
Optional ByVal pIsSuperUser As Object=Nothing,
Optional ByVal pPositionID As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pSalaryTypeID As Object=Nothing,
Optional ByVal pSalaryAmount As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pDuties As Object=Nothing,
Optional ByVal pIsWebVisible As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPersonnelNumber As DataColumnParameter = New DataColumnParameter(defPersonnelNumber, pPersonnelNumber)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramEmploymentDate As DataColumnParameter = New DataColumnParameter(defEmploymentDate, pEmploymentDate)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramPositionID As DataColumnParameter = New DataColumnParameter(defPositionID, pPositionID)
 Dim paramSalaryTypeID As DataColumnParameter = New DataColumnParameter(defSalaryTypeID, pSalaryTypeID)
 Dim paramSalaryAmount As DataColumnParameter = New DataColumnParameter(defSalaryAmount, pSalaryAmount)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDuties As DataColumnParameter = New DataColumnParameter(defDuties, pDuties)
 Dim paramIsWebVisible As DataColumnParameter = New DataColumnParameter(defIsWebVisible, pIsWebVisible)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [PersonnelNumber]={2},[PersonID]={3},[IsActive]={4},[EmploymentDate]={5},[IsSuperUser]={6},[PositionID]={7},[SalaryTypeID]={8},[SalaryAmount]={9},[CreatedByID]={10},[UpdatedByID]={11},[CreatedAt]={12},[UpdatedAt]={13},[Duties]={14},[IsWebVisible]={15} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPersonnelNumber.getSQLQuotedValueForUpdate(),
paramPersonID.getSQLQuotedValueForUpdate(),
paramIsActive.getSQLQuotedValueForUpdate(),
paramEmploymentDate.getSQLQuotedValueForUpdate(),
paramIsSuperUser.getSQLQuotedValueForUpdate(),
paramPositionID.getSQLQuotedValueForUpdate(),
paramSalaryTypeID.getSQLQuotedValueForUpdate(),
paramSalaryAmount.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramDuties.getSQLQuotedValueForUpdate(),
paramIsWebVisible.getSQLQuotedValueForUpdate()  ), True)


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
