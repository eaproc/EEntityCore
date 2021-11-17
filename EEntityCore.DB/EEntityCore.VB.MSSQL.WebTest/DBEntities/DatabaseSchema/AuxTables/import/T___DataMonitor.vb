Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.import

Public Class T___DataMonitor
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defImportTypeID = New DataColumnDefinition(TableColumnNames.ImportTypeID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defImportedFileName = New DataColumnDefinition(TableColumnNames.ImportedFileName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defFileSizeBytes = New DataColumnDefinition(TableColumnNames.FileSizeBytes.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTotalRowsRead = New DataColumnDefinition(TableColumnNames.TotalRowsRead.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defImportTypeID.ColumnName, defImportTypeID) 
  ColumnDefns.Add(defImportedFileName.ColumnName, defImportedFileName) 
  ColumnDefns.Add(defFileSizeBytes.ColumnName, defFileSizeBytes) 
  ColumnDefns.Add(defTotalRowsRead.ColumnName, defTotalRowsRead) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_ImportTypeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "import.ImportType"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_DataMonitor_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.DataMonitor", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "import.DataMonitor"
       Public Const DataMonitor__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM DataMonitor"
       Public Const DataMonitor__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [ImportTypeID], [ImportedFileName], [FileSizeBytes], [TotalRowsRead], [CreatedByID], [CreatedAt], [UpdatedByID], [UpdatedAt] FROM DataMonitor"


       Public Enum TableColumnNames

           [ID]
           [ImportTypeID]
           [ImportedFileName]
           [FileSizeBytes]
           [TotalRowsRead]
           [CreatedByID]
           [CreatedAt]
           [UpdatedByID]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_import_DataMonitor 
           fk_import_DataMonitor_ImportTypeID 
           fk_import_DataMonitor_CreatedByID 
           fk_import_DataMonitor_UpdatedByID 
           uq_import_DataMonitor_ImportedFileName 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defImportTypeID As DataColumnDefinition
       Public Shared ReadOnly defImportedFileName As DataColumnDefinition
       Public Shared ReadOnly defFileSizeBytes As DataColumnDefinition
       Public Shared ReadOnly defTotalRowsRead As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [ImportTypeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ImportTypeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ImportedFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ImportedFileName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FileSizeBytes] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.FileSizeBytes.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TotalRowsRead] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TotalRowsRead.ToString()))
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


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___DataMonitor                  
            If Me.hasRows() Then Return New T___DataMonitor(Me.AllRows(0))                  
            Return New T___DataMonitor()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___DataMonitor                  
            Return New T___DataMonitor(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___DataMonitor                  
            Return New T___DataMonitor(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___DataMonitor                  
            Return New T___DataMonitor(Me.RawTable, T___DataMonitor.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___DataMonitor,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___DataMonitor,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___DataMonitor                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___DataMonitor(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___DataMonitor(drst.CopyToDataTable(),                  
                    T___DataMonitor.TABLE_NAME)                  
                Return New T___DataMonitor()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___DataMonitor()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___DataMonitor                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___DataMonitor(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___DataMonitor(drst.CopyToDataTable(),                  
                    T___DataMonitor.TABLE_NAME)                  
                Return New T___DataMonitor()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___DataMonitor()                  
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
            Return DataMonitor__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pImportTypeID As Int32,
ByVal pImportedFileName As String,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramImportTypeID As DataColumnParameter = New DataColumnParameter(defImportTypeID, pImportTypeID)
 Dim paramImportedFileName As DataColumnParameter = New DataColumnParameter(defImportedFileName, pImportedFileName)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramFileSizeBytes As DataColumnParameter = New DataColumnParameter(defFileSizeBytes, defFileSizeBytes.DefaultValue)
 Dim paramTotalRowsRead As DataColumnParameter = New DataColumnParameter(defTotalRowsRead, defTotalRowsRead.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pImportTypeID As Int32,
ByVal pImportedFileName As String,
ByVal pFileSizeBytes As Int32,
ByVal pTotalRowsRead As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramImportTypeID As DataColumnParameter = New DataColumnParameter(defImportTypeID, pImportTypeID)
 Dim paramImportedFileName As DataColumnParameter = New DataColumnParameter(defImportedFileName, pImportedFileName)
 Dim paramFileSizeBytes As DataColumnParameter = New DataColumnParameter(defFileSizeBytes, pFileSizeBytes)
 Dim paramTotalRowsRead As DataColumnParameter = New DataColumnParameter(defTotalRowsRead, pTotalRowsRead)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pImportTypeID As Int32,
ByVal pImportedFileName As String,
ByVal pFileSizeBytes As Int32,
ByVal pTotalRowsRead As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramImportTypeID As DataColumnParameter = New DataColumnParameter(defImportTypeID, pImportTypeID)
 Dim paramImportedFileName As DataColumnParameter = New DataColumnParameter(defImportedFileName, pImportedFileName)
 Dim paramFileSizeBytes As DataColumnParameter = New DataColumnParameter(defFileSizeBytes, pFileSizeBytes)
 Dim paramTotalRowsRead As DataColumnParameter = New DataColumnParameter(defTotalRowsRead, pTotalRowsRead)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pImportTypeID As Int32,
ByVal pImportedFileName As String,
ByVal pFileSizeBytes As Int32,
ByVal pTotalRowsRead As Int32,
ByVal pCreatedByID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pUpdatedByID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramImportTypeID As DataColumnParameter = New DataColumnParameter(defImportTypeID, pImportTypeID)
 Dim paramImportedFileName As DataColumnParameter = New DataColumnParameter(defImportedFileName, pImportedFileName)
 Dim paramFileSizeBytes As DataColumnParameter = New DataColumnParameter(defFileSizeBytes, pFileSizeBytes)
 Dim paramTotalRowsRead As DataColumnParameter = New DataColumnParameter(defTotalRowsRead, pTotalRowsRead)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([ImportTypeID],[ImportedFileName],[FileSizeBytes],[TotalRowsRead],[CreatedByID],[CreatedAt],[UpdatedByID],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8}) ", TABLE_NAME,paramImportTypeID.getSQLQuotedValueForAdd(),
paramImportedFileName.getSQLQuotedValueForAdd(),
paramFileSizeBytes.getSQLQuotedValueForAdd(),
paramTotalRowsRead.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd(),
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
Optional ByVal pImportTypeID As Object=Nothing,
Optional ByVal pImportedFileName As Object=Nothing,
Optional ByVal pFileSizeBytes As Object=Nothing,
Optional ByVal pTotalRowsRead As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramImportTypeID As DataColumnParameter = New DataColumnParameter(defImportTypeID, pImportTypeID)
 Dim paramImportedFileName As DataColumnParameter = New DataColumnParameter(defImportedFileName, pImportedFileName)
 Dim paramFileSizeBytes As DataColumnParameter = New DataColumnParameter(defFileSizeBytes, pFileSizeBytes)
 Dim paramTotalRowsRead As DataColumnParameter = New DataColumnParameter(defTotalRowsRead, pTotalRowsRead)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [ImportTypeID]={2},[ImportedFileName]={3},[FileSizeBytes]={4},[TotalRowsRead]={5},[CreatedByID]={6},[CreatedAt]={7},[UpdatedByID]={8},[UpdatedAt]={9} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramImportTypeID.getSQLQuotedValueForUpdate(),
paramImportedFileName.getSQLQuotedValueForUpdate(),
paramFileSizeBytes.getSQLQuotedValueForUpdate(),
paramTotalRowsRead.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate(),
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
