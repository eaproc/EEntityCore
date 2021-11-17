Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.academic

Public Class T___Term
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defName = New DataColumnDefinition(TableColumnNames.Name.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defDescription = New DataColumnDefinition(TableColumnNames.Description.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defStartDate = New DataColumnDefinition(TableColumnNames.StartDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEndDate = New DataColumnDefinition(TableColumnNames.EndDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsActive = New DataColumnDefinition(TableColumnNames.IsActive.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAcademicSessionID = New DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defTermOrderID = New DataColumnDefinition(TableColumnNames.TermOrderID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defName.ColumnName, defName) 
  ColumnDefns.Add(defDescription.ColumnName, defDescription) 
  ColumnDefns.Add(defStartDate.ColumnName, defStartDate) 
  ColumnDefns.Add(defEndDate.ColumnName, defEndDate) 
  ColumnDefns.Add(defIsActive.ColumnName, defIsActive) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID) 
  ColumnDefns.Add(defTermOrderID.ColumnName, defTermOrderID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_academic_Term_AcademicSessionID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "academic.Term", "academic.AcademicSession"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_academic_Term_TermOrderID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "academic.Term", "academic.TermOrder"                  
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

       Public Const TABLE_NAME As String = "academic.Term"
       Public Const Term__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [Name], [Description], [StartDate], [EndDate], [IsActive], [CreatedAt], [UpdatedAt], [AcademicSessionID], [TermOrderID] FROM Term"
       Public Const Term__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [Name], [Description], [StartDate], [EndDate], [IsActive], [CreatedAt], [UpdatedAt], [AcademicSessionID], [TermOrderID] FROM Term"


       Public Enum TableColumnNames

           [ID]
           [Name]
           [Description]
           [StartDate]
           [EndDate]
           [IsActive]
           [CreatedAt]
           [UpdatedAt]
           [AcademicSessionID]
           [TermOrderID]
       End Enum 



       Public Enum TableConstraints

           pk_academic_Term 
           fk_academic_Term_AcademicSessionID 
           fk_academic_Term_TermOrderID 
           uq_academic_Term_AcademicSessionID 
           uq_academic_Term_name 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defName As DataColumnDefinition
       Public Shared ReadOnly defDescription As DataColumnDefinition
       Public Shared ReadOnly defStartDate As DataColumnDefinition
       Public Shared ReadOnly defEndDate As DataColumnDefinition
       Public Shared ReadOnly defIsActive As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defAcademicSessionID As DataColumnDefinition
       Public Shared ReadOnly defTermOrderID As DataColumnDefinition

       Public ReadOnly Property [Name] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Name.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Description] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Description.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.StartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [EndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.EndDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsActive] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsActive.ToString()))
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


       Public ReadOnly Property [AcademicSessionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AcademicSessionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermOrderID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermOrderID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Term                  
            If Me.hasRows() Then Return New T___Term(Me.AllRows(0))                  
            Return New T___Term()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Term                  
            Return New T___Term(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Term                  
            Return New T___Term(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Term                  
            Return New T___Term(Me.RawTable, T___Term.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Term,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Term,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Term                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Term(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Term(drst.CopyToDataTable(),                  
                    T___Term.TABLE_NAME)                  
                Return New T___Term()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Term()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Term                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Term(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Term(drst.CopyToDataTable(),                  
                    T___Term.TABLE_NAME)                  
                Return New T___Term()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Term()                  
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
            Return Term__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pName As String,
ByVal pAcademicSessionID As Int32,
ByVal pTermOrderID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTermOrderID As DataColumnParameter = New DataColumnParameter(defTermOrderID, pTermOrderID)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, defDescription.DefaultValue)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, defStartDate.DefaultValue)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, defEndDate.DefaultValue)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, defIsActive.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramTermOrderID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pName As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pIsActive As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAcademicSessionID As Int32,
ByVal pTermOrderID As Int32,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTermOrderID As DataColumnParameter = New DataColumnParameter(defTermOrderID, pTermOrderID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramTermOrderID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pName As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pIsActive As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAcademicSessionID As Int32,
ByVal pTermOrderID As Int32,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTermOrderID As DataColumnParameter = New DataColumnParameter(defTermOrderID, pTermOrderID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramTermOrderID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pName As String,
ByVal pStartDate As DateTime,
ByVal pEndDate As DateTime,
ByVal pIsActive As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pAcademicSessionID As Int32,
ByVal pTermOrderID As Int32,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTermOrderID As DataColumnParameter = New DataColumnParameter(defTermOrderID, pTermOrderID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([Name],[Description],[StartDate],[EndDate],[IsActive],[CreatedAt],[UpdatedAt],[AcademicSessionID],[TermOrderID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramName.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramStartDate.getSQLQuotedValueForAdd(),
paramEndDate.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramAcademicSessionID.getSQLQuotedValueForAdd(),
paramTermOrderID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pName As Object=Nothing,
Optional ByVal pStartDate As Object=Nothing,
Optional ByVal pEndDate As Object=Nothing,
Optional ByVal pIsActive As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pAcademicSessionID As Object=Nothing,
Optional ByVal pTermOrderID As Object=Nothing,
Optional ByVal pDescription As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramStartDate As DataColumnParameter = New DataColumnParameter(defStartDate, pStartDate)
 Dim paramEndDate As DataColumnParameter = New DataColumnParameter(defEndDate, pEndDate)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramAcademicSessionID As DataColumnParameter = New DataColumnParameter(defAcademicSessionID, pAcademicSessionID)
 Dim paramTermOrderID As DataColumnParameter = New DataColumnParameter(defTermOrderID, pTermOrderID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [Name]={2},[Description]={3},[StartDate]={4},[EndDate]={5},[IsActive]={6},[CreatedAt]={7},[UpdatedAt]={8},[AcademicSessionID]={9},[TermOrderID]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramName.getSQLQuotedValueForUpdate(),
paramDescription.getSQLQuotedValueForUpdate(),
paramStartDate.getSQLQuotedValueForUpdate(),
paramEndDate.getSQLQuotedValueForUpdate(),
paramIsActive.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramAcademicSessionID.getSQLQuotedValueForUpdate(),
paramTermOrderID.getSQLQuotedValueForUpdate()  ), True)


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
