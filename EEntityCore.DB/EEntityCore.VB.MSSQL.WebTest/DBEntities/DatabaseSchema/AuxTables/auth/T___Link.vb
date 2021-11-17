Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.auth

Public Class T___Link
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defAppModuleID = New DataColumnDefinition(TableColumnNames.AppModuleID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defName = New DataColumnDefinition(TableColumnNames.Name.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLink = New DataColumnDefinition(TableColumnNames.Link.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defLinkPermissionID = New DataColumnDefinition(TableColumnNames.LinkPermissionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defLinkParentID = New DataColumnDefinition(TableColumnNames.LinkParentID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defOwnedByRoleID = New DataColumnDefinition(TableColumnNames.OwnedByRoleID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defDescription = New DataColumnDefinition(TableColumnNames.Description.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defAppModuleID.ColumnName, defAppModuleID) 
  ColumnDefns.Add(defName.ColumnName, defName) 
  ColumnDefns.Add(defLink.ColumnName, defLink) 
  ColumnDefns.Add(defLinkPermissionID.ColumnName, defLinkPermissionID) 
  ColumnDefns.Add(defLinkParentID.ColumnName, defLinkParentID) 
  ColumnDefns.Add(defOwnedByRoleID.ColumnName, defOwnedByRoleID) 
  ColumnDefns.Add(defDescription.ColumnName, defDescription) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_AppModuleID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.AppModule"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkPermissionID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.LinkPermission"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_LinkParentID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Link"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_Link_OwnedByRoleID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.Link", "auth.Role"                  
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

       Public Const TABLE_NAME As String = "auth.Link"
       Public Const Link__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM Link"
       Public Const Link__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [AppModuleID], [Name], [Link], [LinkPermissionID], [LinkParentID], [OwnedByRoleID], [Description], [CreatedAt], [UpdatedAt] FROM Link"


       Public Enum TableColumnNames

           [ID]
           [AppModuleID]
           [Name]
           [Link]
           [LinkPermissionID]
           [LinkParentID]
           [OwnedByRoleID]
           [Description]
           [CreatedAt]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_auth_Link 
           fk_auth_Link_AppModuleID 
           fk_auth_Link_LinkPermissionID 
           fk_auth_Link_LinkParentID 
           fk_auth_Link_OwnedByRoleID 
           uq_auth_Link_Link 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defAppModuleID As DataColumnDefinition
       Public Shared ReadOnly defName As DataColumnDefinition
       Public Shared ReadOnly defLink As DataColumnDefinition
       Public Shared ReadOnly defLinkPermissionID As DataColumnDefinition
       Public Shared ReadOnly defLinkParentID As DataColumnDefinition
       Public Shared ReadOnly defOwnedByRoleID As DataColumnDefinition
       Public Shared ReadOnly defDescription As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [AppModuleID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AppModuleID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Name] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Name.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Link] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Link.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LinkPermissionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.LinkPermissionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LinkParentID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.LinkParentID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [OwnedByRoleID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.OwnedByRoleID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Description] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Description.ToString()))
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
        Public Function getFirstRow() As T___Link                  
            If Me.hasRows() Then Return New T___Link(Me.AllRows(0))                  
            Return New T___Link()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Link                  
            Return New T___Link(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Link                  
            Return New T___Link(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Link                  
            Return New T___Link(Me.RawTable, T___Link.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Link,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Link,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Link                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Link(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Link(drst.CopyToDataTable(),                  
                    T___Link.TABLE_NAME)                  
                Return New T___Link()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Link()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Link                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Link(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Link(drst.CopyToDataTable(),                  
                    T___Link.TABLE_NAME)                  
                Return New T___Link()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Link()                  
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
            Return Link__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pAppModuleID As Int32,
ByVal pLink As String,
ByVal pLinkPermissionID As Int32,
ByVal pLinkParentID As Int32,
ByVal pOwnedByRoleID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramAppModuleID As DataColumnParameter = New DataColumnParameter(defAppModuleID, pAppModuleID)
 Dim paramLink As DataColumnParameter = New DataColumnParameter(defLink, pLink)
 Dim paramLinkPermissionID As DataColumnParameter = New DataColumnParameter(defLinkPermissionID, pLinkPermissionID)
 Dim paramLinkParentID As DataColumnParameter = New DataColumnParameter(defLinkParentID, pLinkParentID)
 Dim paramOwnedByRoleID As DataColumnParameter = New DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, defName.DefaultValue)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, defDescription.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pAppModuleID As Int32,
ByVal pName As String,
ByVal pLink As String,
ByVal pLinkPermissionID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pLinkParentID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOwnedByRoleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramAppModuleID As DataColumnParameter = New DataColumnParameter(defAppModuleID, pAppModuleID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramLink As DataColumnParameter = New DataColumnParameter(defLink, pLink)
 Dim paramLinkPermissionID As DataColumnParameter = New DataColumnParameter(defLinkPermissionID, pLinkPermissionID)
 Dim paramLinkParentID As DataColumnParameter = New DataColumnParameter(defLinkParentID, pLinkParentID)
 Dim paramOwnedByRoleID As DataColumnParameter = New DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pAppModuleID As Int32,
ByVal pName As String,
ByVal pLink As String,
ByVal pLinkPermissionID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pLinkParentID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOwnedByRoleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramAppModuleID As DataColumnParameter = New DataColumnParameter(defAppModuleID, pAppModuleID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramLink As DataColumnParameter = New DataColumnParameter(defLink, pLink)
 Dim paramLinkPermissionID As DataColumnParameter = New DataColumnParameter(defLinkPermissionID, pLinkPermissionID)
 Dim paramLinkParentID As DataColumnParameter = New DataColumnParameter(defLinkParentID, pLinkParentID)
 Dim paramOwnedByRoleID As DataColumnParameter = New DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pAppModuleID As Int32,
ByVal pName As String,
ByVal pLink As String,
ByVal pLinkPermissionID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pLinkParentID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOwnedByRoleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramAppModuleID As DataColumnParameter = New DataColumnParameter(defAppModuleID, pAppModuleID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramLink As DataColumnParameter = New DataColumnParameter(defLink, pLink)
 Dim paramLinkPermissionID As DataColumnParameter = New DataColumnParameter(defLinkPermissionID, pLinkPermissionID)
 Dim paramLinkParentID As DataColumnParameter = New DataColumnParameter(defLinkParentID, pLinkParentID)
 Dim paramOwnedByRoleID As DataColumnParameter = New DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([AppModuleID],[Name],[Link],[LinkPermissionID],[LinkParentID],[OwnedByRoleID],[Description],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9}) ", TABLE_NAME,paramAppModuleID.getSQLQuotedValueForAdd(),
paramName.getSQLQuotedValueForAdd(),
paramLink.getSQLQuotedValueForAdd(),
paramLinkPermissionID.getSQLQuotedValueForAdd(),
paramLinkParentID.getSQLQuotedValueForAdd(),
paramOwnedByRoleID.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
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
Optional ByVal pAppModuleID As Object=Nothing,
Optional ByVal pName As Object=Nothing,
Optional ByVal pLink As Object=Nothing,
Optional ByVal pLinkPermissionID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pLinkParentID As Object=Nothing,
Optional ByVal pOwnedByRoleID As Object=Nothing,
Optional ByVal pDescription As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramAppModuleID As DataColumnParameter = New DataColumnParameter(defAppModuleID, pAppModuleID)
 Dim paramName As DataColumnParameter = New DataColumnParameter(defName, pName)
 Dim paramLink As DataColumnParameter = New DataColumnParameter(defLink, pLink)
 Dim paramLinkPermissionID As DataColumnParameter = New DataColumnParameter(defLinkPermissionID, pLinkPermissionID)
 Dim paramLinkParentID As DataColumnParameter = New DataColumnParameter(defLinkParentID, pLinkParentID)
 Dim paramOwnedByRoleID As DataColumnParameter = New DataColumnParameter(defOwnedByRoleID, pOwnedByRoleID)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [AppModuleID]={2},[Name]={3},[Link]={4},[LinkPermissionID]={5},[LinkParentID]={6},[OwnedByRoleID]={7},[Description]={8},[CreatedAt]={9},[UpdatedAt]={10} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramAppModuleID.getSQLQuotedValueForUpdate(),
paramName.getSQLQuotedValueForUpdate(),
paramLink.getSQLQuotedValueForUpdate(),
paramLinkPermissionID.getSQLQuotedValueForUpdate(),
paramLinkParentID.getSQLQuotedValueForUpdate(),
paramOwnedByRoleID.getSQLQuotedValueForUpdate(),
paramDescription.getSQLQuotedValueForUpdate(),
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
