Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.common

Public Class T___PersonIdentificationDetail
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPersonID = New DataColumnDefinition(TableColumnNames.PersonID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defNumber = New DataColumnDefinition(TableColumnNames.Number.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defIdentificationTypeID = New DataColumnDefinition(TableColumnNames.IdentificationTypeID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defIssuedDate = New DataColumnDefinition(TableColumnNames.IssuedDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIssuingCountryID = New DataColumnDefinition(TableColumnNames.IssuingCountryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defExpiryDate = New DataColumnDefinition(TableColumnNames.ExpiryDate.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIdentificationViabilityID = New DataColumnDefinition(TableColumnNames.IdentificationViabilityID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defDocumentFileName = New DataColumnDefinition(TableColumnNames.DocumentFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPersonID.ColumnName, defPersonID) 
  ColumnDefns.Add(defNumber.ColumnName, defNumber) 
  ColumnDefns.Add(defIdentificationTypeID.ColumnName, defIdentificationTypeID) 
  ColumnDefns.Add(defIssuedDate.ColumnName, defIssuedDate) 
  ColumnDefns.Add(defIssuingCountryID.ColumnName, defIssuingCountryID) 
  ColumnDefns.Add(defExpiryDate.ColumnName, defExpiryDate) 
  ColumnDefns.Add(defIdentificationViabilityID.ColumnName, defIdentificationViabilityID) 
  ColumnDefns.Add(defDocumentFileName.ColumnName, defDocumentFileName) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_PersonID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Person"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationTypeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationType"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IssuingCountryID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.Country"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_PersonIdentificationDetail_IdentificationViabilityID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.PersonIdentificationDetail", "common.IdentificationViability"                  
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

       Public Const TABLE_NAME As String = "common.PersonIdentificationDetail"
       Public Const PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM PersonIdentificationDetail"
       Public Const PersonIdentificationDetail__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PersonID], [Number], [IdentificationTypeID], [IssuedDate], [IssuingCountryID], [ExpiryDate], [IdentificationViabilityID], [DocumentFileName], [CreatedAt], [UpdatedAt] FROM PersonIdentificationDetail"


       Public Enum TableColumnNames

           [ID]
           [PersonID]
           [Number]
           [IdentificationTypeID]
           [IssuedDate]
           [IssuingCountryID]
           [ExpiryDate]
           [IdentificationViabilityID]
           [DocumentFileName]
           [CreatedAt]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_common_PersonIdentificationDetail 
           fk_common_PersonIdentificationDetail_PersonID 
           fk_common_PersonIdentificationDetail_IdentificationTypeID 
           fk_common_PersonIdentificationDetail_IssuingCountryID 
           fk_common_PersonIdentificationDetail_IdentificationViabilityID 
           uq_common_PersonIdentificationDetail_PersonID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPersonID As DataColumnDefinition
       Public Shared ReadOnly defNumber As DataColumnDefinition
       Public Shared ReadOnly defIdentificationTypeID As DataColumnDefinition
       Public Shared ReadOnly defIssuedDate As DataColumnDefinition
       Public Shared ReadOnly defIssuingCountryID As DataColumnDefinition
       Public Shared ReadOnly defExpiryDate As DataColumnDefinition
       Public Shared ReadOnly defIdentificationViabilityID As DataColumnDefinition
       Public Shared ReadOnly defDocumentFileName As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [PersonID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PersonID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Number] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Number.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IdentificationTypeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.IdentificationTypeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IssuedDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.IssuedDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IssuingCountryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.IssuingCountryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExpiryDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.ExpiryDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IdentificationViabilityID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.IdentificationViabilityID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DocumentFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DocumentFileName.ToString()))
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
        Public Function getFirstRow() As T___PersonIdentificationDetail                  
            If Me.hasRows() Then Return New T___PersonIdentificationDetail(Me.AllRows(0))                  
            Return New T___PersonIdentificationDetail()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PersonIdentificationDetail                  
            Return New T___PersonIdentificationDetail(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PersonIdentificationDetail                  
            Return New T___PersonIdentificationDetail(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PersonIdentificationDetail                  
            Return New T___PersonIdentificationDetail(Me.RawTable, T___PersonIdentificationDetail.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PersonIdentificationDetail,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PersonIdentificationDetail,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PersonIdentificationDetail                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PersonIdentificationDetail(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PersonIdentificationDetail(drst.CopyToDataTable(),                  
                    T___PersonIdentificationDetail.TABLE_NAME)                  
                Return New T___PersonIdentificationDetail()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PersonIdentificationDetail()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PersonIdentificationDetail                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PersonIdentificationDetail(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PersonIdentificationDetail(drst.CopyToDataTable(),                  
                    T___PersonIdentificationDetail.TABLE_NAME)                  
                Return New T___PersonIdentificationDetail()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PersonIdentificationDetail()                  
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
            Return PersonIdentificationDetail__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPersonID As Int32,
ByVal pNumber As String,
ByVal pIdentificationTypeID As Int32,
ByVal pIssuingCountryID As Int32,
ByVal pIdentificationViabilityID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramNumber As DataColumnParameter = New DataColumnParameter(defNumber, pNumber)
 Dim paramIdentificationTypeID As DataColumnParameter = New DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID)
 Dim paramIssuingCountryID As DataColumnParameter = New DataColumnParameter(defIssuingCountryID, pIssuingCountryID)
 Dim paramIdentificationViabilityID As DataColumnParameter = New DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID)
 Dim paramIssuedDate As DataColumnParameter = New DataColumnParameter(defIssuedDate, defIssuedDate.DefaultValue)
 Dim paramExpiryDate As DataColumnParameter = New DataColumnParameter(defExpiryDate, defExpiryDate.DefaultValue)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, defDocumentFileName.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramNumber.getSQLQuotedValueForAdd(),
paramIdentificationTypeID.getSQLQuotedValueForAdd(),
paramIssuedDate.getSQLQuotedValueForAdd(),
paramIssuingCountryID.getSQLQuotedValueForAdd(),
paramExpiryDate.getSQLQuotedValueForAdd(),
paramIdentificationViabilityID.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPersonID As Int32,
ByVal pNumber As String,
ByVal pIdentificationTypeID As Int32,
ByVal pIssuingCountryID As Int32,
ByVal pIdentificationViabilityID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pIssuedDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpiryDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramNumber As DataColumnParameter = New DataColumnParameter(defNumber, pNumber)
 Dim paramIdentificationTypeID As DataColumnParameter = New DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID)
 Dim paramIssuedDate As DataColumnParameter = New DataColumnParameter(defIssuedDate, pIssuedDate)
 Dim paramIssuingCountryID As DataColumnParameter = New DataColumnParameter(defIssuingCountryID, pIssuingCountryID)
 Dim paramExpiryDate As DataColumnParameter = New DataColumnParameter(defExpiryDate, pExpiryDate)
 Dim paramIdentificationViabilityID As DataColumnParameter = New DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramNumber.getSQLQuotedValueForAdd(),
paramIdentificationTypeID.getSQLQuotedValueForAdd(),
paramIssuedDate.getSQLQuotedValueForAdd(),
paramIssuingCountryID.getSQLQuotedValueForAdd(),
paramExpiryDate.getSQLQuotedValueForAdd(),
paramIdentificationViabilityID.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPersonID As Int32,
ByVal pNumber As String,
ByVal pIdentificationTypeID As Int32,
ByVal pIssuingCountryID As Int32,
ByVal pIdentificationViabilityID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pIssuedDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpiryDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramNumber As DataColumnParameter = New DataColumnParameter(defNumber, pNumber)
 Dim paramIdentificationTypeID As DataColumnParameter = New DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID)
 Dim paramIssuedDate As DataColumnParameter = New DataColumnParameter(defIssuedDate, pIssuedDate)
 Dim paramIssuingCountryID As DataColumnParameter = New DataColumnParameter(defIssuingCountryID, pIssuingCountryID)
 Dim paramExpiryDate As DataColumnParameter = New DataColumnParameter(defExpiryDate, pExpiryDate)
 Dim paramIdentificationViabilityID As DataColumnParameter = New DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPersonID.getSQLQuotedValueForAdd(),
paramNumber.getSQLQuotedValueForAdd(),
paramIdentificationTypeID.getSQLQuotedValueForAdd(),
paramIssuedDate.getSQLQuotedValueForAdd(),
paramIssuingCountryID.getSQLQuotedValueForAdd(),
paramExpiryDate.getSQLQuotedValueForAdd(),
paramIdentificationViabilityID.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pPersonID As Int32,
ByVal pNumber As String,
ByVal pIdentificationTypeID As Int32,
ByVal pIssuingCountryID As Int32,
ByVal pIdentificationViabilityID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pIssuedDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpiryDate As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDocumentFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramNumber As DataColumnParameter = New DataColumnParameter(defNumber, pNumber)
 Dim paramIdentificationTypeID As DataColumnParameter = New DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID)
 Dim paramIssuedDate As DataColumnParameter = New DataColumnParameter(defIssuedDate, pIssuedDate)
 Dim paramIssuingCountryID As DataColumnParameter = New DataColumnParameter(defIssuingCountryID, pIssuingCountryID)
 Dim paramExpiryDate As DataColumnParameter = New DataColumnParameter(defExpiryDate, pExpiryDate)
 Dim paramIdentificationViabilityID As DataColumnParameter = New DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([PersonID],[Number],[IdentificationTypeID],[IssuedDate],[IssuingCountryID],[ExpiryDate],[IdentificationViabilityID],[DocumentFileName],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramPersonID.getSQLQuotedValueForAdd(),
paramNumber.getSQLQuotedValueForAdd(),
paramIdentificationTypeID.getSQLQuotedValueForAdd(),
paramIssuedDate.getSQLQuotedValueForAdd(),
paramIssuingCountryID.getSQLQuotedValueForAdd(),
paramExpiryDate.getSQLQuotedValueForAdd(),
paramIdentificationViabilityID.getSQLQuotedValueForAdd(),
paramDocumentFileName.getSQLQuotedValueForAdd(),
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
Optional ByVal pPersonID As Object=Nothing,
Optional ByVal pNumber As Object=Nothing,
Optional ByVal pIdentificationTypeID As Object=Nothing,
Optional ByVal pIssuingCountryID As Object=Nothing,
Optional ByVal pIdentificationViabilityID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pIssuedDate As Object=Nothing,
Optional ByVal pExpiryDate As Object=Nothing,
Optional ByVal pDocumentFileName As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPersonID As DataColumnParameter = New DataColumnParameter(defPersonID, pPersonID)
 Dim paramNumber As DataColumnParameter = New DataColumnParameter(defNumber, pNumber)
 Dim paramIdentificationTypeID As DataColumnParameter = New DataColumnParameter(defIdentificationTypeID, pIdentificationTypeID)
 Dim paramIssuedDate As DataColumnParameter = New DataColumnParameter(defIssuedDate, pIssuedDate)
 Dim paramIssuingCountryID As DataColumnParameter = New DataColumnParameter(defIssuingCountryID, pIssuingCountryID)
 Dim paramExpiryDate As DataColumnParameter = New DataColumnParameter(defExpiryDate, pExpiryDate)
 Dim paramIdentificationViabilityID As DataColumnParameter = New DataColumnParameter(defIdentificationViabilityID, pIdentificationViabilityID)
 Dim paramDocumentFileName As DataColumnParameter = New DataColumnParameter(defDocumentFileName, pDocumentFileName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [PersonID]={2},[Number]={3},[IdentificationTypeID]={4},[IssuedDate]={5},[IssuingCountryID]={6},[ExpiryDate]={7},[IdentificationViabilityID]={8},[DocumentFileName]={9},[CreatedAt]={10},[UpdatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPersonID.getSQLQuotedValueForUpdate(),
paramNumber.getSQLQuotedValueForUpdate(),
paramIdentificationTypeID.getSQLQuotedValueForUpdate(),
paramIssuedDate.getSQLQuotedValueForUpdate(),
paramIssuingCountryID.getSQLQuotedValueForUpdate(),
paramExpiryDate.getSQLQuotedValueForUpdate(),
paramIdentificationViabilityID.getSQLQuotedValueForUpdate(),
paramDocumentFileName.getSQLQuotedValueForUpdate(),
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
