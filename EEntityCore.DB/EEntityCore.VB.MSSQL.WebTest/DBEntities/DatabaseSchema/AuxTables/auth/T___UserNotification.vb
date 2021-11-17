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

Public Class T___UserNotification
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defUserID = New DataColumnDefinition(TableColumnNames.UserID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defTitle = New DataColumnDefinition(TableColumnNames.Title.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defQuickNote = New DataColumnDefinition(TableColumnNames.QuickNote.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDescription = New DataColumnDefinition(TableColumnNames.Description.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIconClass = New DataColumnDefinition(TableColumnNames.IconClass.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHeadingColorClass = New DataColumnDefinition(TableColumnNames.HeadingColorClass.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defReadAt = New DataColumnDefinition(TableColumnNames.ReadAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIdentifier = New DataColumnDefinition(TableColumnNames.Identifier.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTargetURL = New DataColumnDefinition(TableColumnNames.TargetURL.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defUserID.ColumnName, defUserID) 
  ColumnDefns.Add(defTitle.ColumnName, defTitle) 
  ColumnDefns.Add(defQuickNote.ColumnName, defQuickNote) 
  ColumnDefns.Add(defDescription.ColumnName, defDescription) 
  ColumnDefns.Add(defIconClass.ColumnName, defIconClass) 
  ColumnDefns.Add(defHeadingColorClass.ColumnName, defHeadingColorClass) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defReadAt.ColumnName, defReadAt) 
  ColumnDefns.Add(defIdentifier.ColumnName, defIdentifier) 
  ColumnDefns.Add(defTargetURL.ColumnName, defTargetURL) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_auth_UserNotification_UserID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "auth.UserNotification", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "auth.UserNotification"
       Public Const UserNotification__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM UserNotification"
       Public Const UserNotification__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [UserID], [Title], [QuickNote], [Description], [IconClass], [HeadingColorClass], [CreatedAt], [ReadAt], [Identifier], [TargetURL] FROM UserNotification"


       Public Enum TableColumnNames

           [ID]
           [UserID]
           [Title]
           [QuickNote]
           [Description]
           [IconClass]
           [HeadingColorClass]
           [CreatedAt]
           [ReadAt]
           [Identifier]
           [TargetURL]
       End Enum 



       Public Enum TableConstraints

           pk_auth_UserNotification 
           fk_auth_UserNotification_UserID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defUserID As DataColumnDefinition
       Public Shared ReadOnly defTitle As DataColumnDefinition
       Public Shared ReadOnly defQuickNote As DataColumnDefinition
       Public Shared ReadOnly defDescription As DataColumnDefinition
       Public Shared ReadOnly defIconClass As DataColumnDefinition
       Public Shared ReadOnly defHeadingColorClass As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defReadAt As DataColumnDefinition
       Public Shared ReadOnly defIdentifier As DataColumnDefinition
       Public Shared ReadOnly defTargetURL As DataColumnDefinition

       Public ReadOnly Property [UserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UserID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Title] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Title.ToString()))
           End Get
       End Property


       Public ReadOnly Property [QuickNote] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.QuickNote.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Description] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Description.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IconClass] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IconClass.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HeadingColorClass] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HeadingColorClass.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ReadAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.ReadAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Identifier] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Identifier.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TargetURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.TargetURL.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___UserNotification                  
            If Me.hasRows() Then Return New T___UserNotification(Me.AllRows(0))                  
            Return New T___UserNotification()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___UserNotification                  
            Return New T___UserNotification(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___UserNotification                  
            Return New T___UserNotification(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___UserNotification                  
            Return New T___UserNotification(Me.RawTable, T___UserNotification.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___UserNotification,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___UserNotification,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___UserNotification                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___UserNotification(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___UserNotification(drst.CopyToDataTable(),                  
                    T___UserNotification.TABLE_NAME)                  
                Return New T___UserNotification()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___UserNotification()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___UserNotification                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___UserNotification(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___UserNotification(drst.CopyToDataTable(),                  
                    T___UserNotification.TABLE_NAME)                  
                Return New T___UserNotification()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___UserNotification()                  
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
            Return UserNotification__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pUserID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, defTitle.DefaultValue)
 Dim paramQuickNote As DataColumnParameter = New DataColumnParameter(defQuickNote, defQuickNote.DefaultValue)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, defDescription.DefaultValue)
 Dim paramIconClass As DataColumnParameter = New DataColumnParameter(defIconClass, defIconClass.DefaultValue)
 Dim paramHeadingColorClass As DataColumnParameter = New DataColumnParameter(defHeadingColorClass, defHeadingColorClass.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramReadAt As DataColumnParameter = New DataColumnParameter(defReadAt, defReadAt.DefaultValue)
 Dim paramIdentifier As DataColumnParameter = New DataColumnParameter(defIdentifier, defIdentifier.DefaultValue)
 Dim paramTargetURL As DataColumnParameter = New DataColumnParameter(defTargetURL, defTargetURL.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pUserID As Int32,
ByVal pTitle As String,
ByVal pCreatedAt As DateTime,
ByVal pTargetURL As String,
Optional ByVal pQuickNote As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIconClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHeadingColorClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pReadAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIdentifier As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramQuickNote As DataColumnParameter = New DataColumnParameter(defQuickNote, pQuickNote)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramIconClass As DataColumnParameter = New DataColumnParameter(defIconClass, pIconClass)
 Dim paramHeadingColorClass As DataColumnParameter = New DataColumnParameter(defHeadingColorClass, pHeadingColorClass)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramReadAt As DataColumnParameter = New DataColumnParameter(defReadAt, pReadAt)
 Dim paramIdentifier As DataColumnParameter = New DataColumnParameter(defIdentifier, pIdentifier)
 Dim paramTargetURL As DataColumnParameter = New DataColumnParameter(defTargetURL, pTargetURL)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pUserID As Int32,
ByVal pTitle As String,
ByVal pCreatedAt As DateTime,
ByVal pTargetURL As String,
Optional ByVal pQuickNote As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIconClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHeadingColorClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pReadAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIdentifier As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramQuickNote As DataColumnParameter = New DataColumnParameter(defQuickNote, pQuickNote)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramIconClass As DataColumnParameter = New DataColumnParameter(defIconClass, pIconClass)
 Dim paramHeadingColorClass As DataColumnParameter = New DataColumnParameter(defHeadingColorClass, pHeadingColorClass)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramReadAt As DataColumnParameter = New DataColumnParameter(defReadAt, pReadAt)
 Dim paramIdentifier As DataColumnParameter = New DataColumnParameter(defIdentifier, pIdentifier)
 Dim paramTargetURL As DataColumnParameter = New DataColumnParameter(defTargetURL, pTargetURL)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pUserID As Int32,
ByVal pTitle As String,
ByVal pCreatedAt As DateTime,
ByVal pTargetURL As String,
Optional ByVal pQuickNote As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDescription As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIconClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHeadingColorClass As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pReadAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pIdentifier As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramQuickNote As DataColumnParameter = New DataColumnParameter(defQuickNote, pQuickNote)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramIconClass As DataColumnParameter = New DataColumnParameter(defIconClass, pIconClass)
 Dim paramHeadingColorClass As DataColumnParameter = New DataColumnParameter(defHeadingColorClass, pHeadingColorClass)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramReadAt As DataColumnParameter = New DataColumnParameter(defReadAt, pReadAt)
 Dim paramIdentifier As DataColumnParameter = New DataColumnParameter(defIdentifier, pIdentifier)
 Dim paramTargetURL As DataColumnParameter = New DataColumnParameter(defTargetURL, pTargetURL)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([UserID],[Title],[QuickNote],[Description],[IconClass],[HeadingColorClass],[CreatedAt],[ReadAt],[Identifier],[TargetURL]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramUserID.getSQLQuotedValueForAdd(),
paramTitle.getSQLQuotedValueForAdd(),
paramQuickNote.getSQLQuotedValueForAdd(),
paramDescription.getSQLQuotedValueForAdd(),
paramIconClass.getSQLQuotedValueForAdd(),
paramHeadingColorClass.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramReadAt.getSQLQuotedValueForAdd(),
paramIdentifier.getSQLQuotedValueForAdd(),
paramTargetURL.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pUserID As Object=Nothing,
Optional ByVal pTitle As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pTargetURL As Object=Nothing,
Optional ByVal pQuickNote As Object=Nothing,
Optional ByVal pDescription As Object=Nothing,
Optional ByVal pIconClass As Object=Nothing,
Optional ByVal pHeadingColorClass As Object=Nothing,
Optional ByVal pReadAt As Object=Nothing,
Optional ByVal pIdentifier As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramUserID As DataColumnParameter = New DataColumnParameter(defUserID, pUserID)
 Dim paramTitle As DataColumnParameter = New DataColumnParameter(defTitle, pTitle)
 Dim paramQuickNote As DataColumnParameter = New DataColumnParameter(defQuickNote, pQuickNote)
 Dim paramDescription As DataColumnParameter = New DataColumnParameter(defDescription, pDescription)
 Dim paramIconClass As DataColumnParameter = New DataColumnParameter(defIconClass, pIconClass)
 Dim paramHeadingColorClass As DataColumnParameter = New DataColumnParameter(defHeadingColorClass, pHeadingColorClass)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramReadAt As DataColumnParameter = New DataColumnParameter(defReadAt, pReadAt)
 Dim paramIdentifier As DataColumnParameter = New DataColumnParameter(defIdentifier, pIdentifier)
 Dim paramTargetURL As DataColumnParameter = New DataColumnParameter(defTargetURL, pTargetURL)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [UserID]={2},[Title]={3},[QuickNote]={4},[Description]={5},[IconClass]={6},[HeadingColorClass]={7},[CreatedAt]={8},[ReadAt]={9},[Identifier]={10},[TargetURL]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramUserID.getSQLQuotedValueForUpdate(),
paramTitle.getSQLQuotedValueForUpdate(),
paramQuickNote.getSQLQuotedValueForUpdate(),
paramDescription.getSQLQuotedValueForUpdate(),
paramIconClass.getSQLQuotedValueForUpdate(),
paramHeadingColorClass.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramReadAt.getSQLQuotedValueForUpdate(),
paramIdentifier.getSQLQuotedValueForUpdate(),
paramTargetURL.getSQLQuotedValueForUpdate()  ), True)


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
