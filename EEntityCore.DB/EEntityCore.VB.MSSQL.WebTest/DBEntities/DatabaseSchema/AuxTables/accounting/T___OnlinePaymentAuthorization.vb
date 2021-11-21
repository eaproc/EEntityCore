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

Public Class T___OnlinePaymentAuthorization
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defOnlinePaymentID = New DataColumnDefinition(TableColumnNames.OnlinePaymentID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defAuthorizationCode = New DataColumnDefinition(TableColumnNames.AuthorizationCode.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCardType = New DataColumnDefinition(TableColumnNames.CardType.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBIN = New DataColumnDefinition(TableColumnNames.BIN.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLast4Digits = New DataColumnDefinition(TableColumnNames.Last4Digits.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpirationMonth = New DataColumnDefinition(TableColumnNames.ExpirationMonth.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExpirationYear = New DataColumnDefinition(TableColumnNames.ExpirationYear.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBank = New DataColumnDefinition(TableColumnNames.Bank.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCountryCode = New DataColumnDefinition(TableColumnNames.CountryCode.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defOnlinePaymentID.ColumnName, defOnlinePaymentID) 
  ColumnDefns.Add(defAuthorizationCode.ColumnName, defAuthorizationCode) 
  ColumnDefns.Add(defCardType.ColumnName, defCardType) 
  ColumnDefns.Add(defBIN.ColumnName, defBIN) 
  ColumnDefns.Add(defLast4Digits.ColumnName, defLast4Digits) 
  ColumnDefns.Add(defExpirationMonth.ColumnName, defExpirationMonth) 
  ColumnDefns.Add(defExpirationYear.ColumnName, defExpirationYear) 
  ColumnDefns.Add(defBank.ColumnName, defBank) 
  ColumnDefns.Add(defCountryCode.ColumnName, defCountryCode) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePaymentAuthorization", "accounting.OnlinePayment"                  
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

       Public Const TABLE_NAME As String = "accounting.OnlinePaymentAuthorization"
       Public Const OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM OnlinePaymentAuthorization"
       Public Const OnlinePaymentAuthorization__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [OnlinePaymentID], [AuthorizationCode], [CardType], [BIN], [Last4Digits], [ExpirationMonth], [ExpirationYear], [Bank], [CountryCode], [CreatedAt] FROM OnlinePaymentAuthorization"


       Public Enum TableColumnNames

           [ID]
           [OnlinePaymentID]
           [AuthorizationCode]
           [CardType]
           [BIN]
           [Last4Digits]
           [ExpirationMonth]
           [ExpirationYear]
           [Bank]
           [CountryCode]
           [CreatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_OnlinePaymentAuthorization 
           fk_accounting_OnlinePaymentAuthorization_OnlinePaymentID 
           uq_accounting_OnlinePaymentAuthorization_OnlinePaymentID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defOnlinePaymentID As DataColumnDefinition
       Public Shared ReadOnly defAuthorizationCode As DataColumnDefinition
       Public Shared ReadOnly defCardType As DataColumnDefinition
       Public Shared ReadOnly defBIN As DataColumnDefinition
       Public Shared ReadOnly defLast4Digits As DataColumnDefinition
       Public Shared ReadOnly defExpirationMonth As DataColumnDefinition
       Public Shared ReadOnly defExpirationYear As DataColumnDefinition
       Public Shared ReadOnly defBank As DataColumnDefinition
       Public Shared ReadOnly defCountryCode As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition

       Public ReadOnly Property [OnlinePaymentID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.OnlinePaymentID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AuthorizationCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AuthorizationCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CardType] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CardType.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BIN] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BIN.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Last4Digits] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Last4Digits.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExpirationMonth] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ExpirationMonth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExpirationYear] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ExpirationYear.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Bank] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Bank.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CountryCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CountryCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___OnlinePaymentAuthorization                  
            If Me.hasRows() Then Return New T___OnlinePaymentAuthorization(Me.AllRows(0))                  
            Return New T___OnlinePaymentAuthorization()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___OnlinePaymentAuthorization                  
            Return New T___OnlinePaymentAuthorization(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___OnlinePaymentAuthorization                  
            Return New T___OnlinePaymentAuthorization(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___OnlinePaymentAuthorization                  
            Return New T___OnlinePaymentAuthorization(Me.RawTable, T___OnlinePaymentAuthorization.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___OnlinePaymentAuthorization,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___OnlinePaymentAuthorization,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___OnlinePaymentAuthorization                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___OnlinePaymentAuthorization(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___OnlinePaymentAuthorization(drst.CopyToDataTable(),                  
                    T___OnlinePaymentAuthorization.TABLE_NAME)                  
                Return New T___OnlinePaymentAuthorization()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___OnlinePaymentAuthorization()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___OnlinePaymentAuthorization                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___OnlinePaymentAuthorization(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___OnlinePaymentAuthorization(drst.CopyToDataTable(),                  
                    T___OnlinePaymentAuthorization.TABLE_NAME)                  
                Return New T___OnlinePaymentAuthorization()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___OnlinePaymentAuthorization()                  
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
            Return OnlinePaymentAuthorization__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pOnlinePaymentID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramOnlinePaymentID As DataColumnParameter = New DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID)
 Dim paramAuthorizationCode As DataColumnParameter = New DataColumnParameter(defAuthorizationCode, defAuthorizationCode.DefaultValue)
 Dim paramCardType As DataColumnParameter = New DataColumnParameter(defCardType, defCardType.DefaultValue)
 Dim paramBIN As DataColumnParameter = New DataColumnParameter(defBIN, defBIN.DefaultValue)
 Dim paramLast4Digits As DataColumnParameter = New DataColumnParameter(defLast4Digits, defLast4Digits.DefaultValue)
 Dim paramExpirationMonth As DataColumnParameter = New DataColumnParameter(defExpirationMonth, defExpirationMonth.DefaultValue)
 Dim paramExpirationYear As DataColumnParameter = New DataColumnParameter(defExpirationYear, defExpirationYear.DefaultValue)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, defBank.DefaultValue)
 Dim paramCountryCode As DataColumnParameter = New DataColumnParameter(defCountryCode, defCountryCode.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramOnlinePaymentID.getSQLQuotedValueForAdd(),
paramAuthorizationCode.getSQLQuotedValueForAdd(),
paramCardType.getSQLQuotedValueForAdd(),
paramBIN.getSQLQuotedValueForAdd(),
paramLast4Digits.getSQLQuotedValueForAdd(),
paramExpirationMonth.getSQLQuotedValueForAdd(),
paramExpirationYear.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramCountryCode.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pOnlinePaymentID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pAuthorizationCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCardType As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBIN As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLast4Digits As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationMonth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationYear As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBank As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCountryCode As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramOnlinePaymentID As DataColumnParameter = New DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID)
 Dim paramAuthorizationCode As DataColumnParameter = New DataColumnParameter(defAuthorizationCode, pAuthorizationCode)
 Dim paramCardType As DataColumnParameter = New DataColumnParameter(defCardType, pCardType)
 Dim paramBIN As DataColumnParameter = New DataColumnParameter(defBIN, pBIN)
 Dim paramLast4Digits As DataColumnParameter = New DataColumnParameter(defLast4Digits, pLast4Digits)
 Dim paramExpirationMonth As DataColumnParameter = New DataColumnParameter(defExpirationMonth, pExpirationMonth)
 Dim paramExpirationYear As DataColumnParameter = New DataColumnParameter(defExpirationYear, pExpirationYear)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramCountryCode As DataColumnParameter = New DataColumnParameter(defCountryCode, pCountryCode)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramOnlinePaymentID.getSQLQuotedValueForAdd(),
paramAuthorizationCode.getSQLQuotedValueForAdd(),
paramCardType.getSQLQuotedValueForAdd(),
paramBIN.getSQLQuotedValueForAdd(),
paramLast4Digits.getSQLQuotedValueForAdd(),
paramExpirationMonth.getSQLQuotedValueForAdd(),
paramExpirationYear.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramCountryCode.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pOnlinePaymentID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pAuthorizationCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCardType As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBIN As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLast4Digits As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationMonth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationYear As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBank As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCountryCode As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramOnlinePaymentID As DataColumnParameter = New DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID)
 Dim paramAuthorizationCode As DataColumnParameter = New DataColumnParameter(defAuthorizationCode, pAuthorizationCode)
 Dim paramCardType As DataColumnParameter = New DataColumnParameter(defCardType, pCardType)
 Dim paramBIN As DataColumnParameter = New DataColumnParameter(defBIN, pBIN)
 Dim paramLast4Digits As DataColumnParameter = New DataColumnParameter(defLast4Digits, pLast4Digits)
 Dim paramExpirationMonth As DataColumnParameter = New DataColumnParameter(defExpirationMonth, pExpirationMonth)
 Dim paramExpirationYear As DataColumnParameter = New DataColumnParameter(defExpirationYear, pExpirationYear)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramCountryCode As DataColumnParameter = New DataColumnParameter(defCountryCode, pCountryCode)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramOnlinePaymentID.getSQLQuotedValueForAdd(),
paramAuthorizationCode.getSQLQuotedValueForAdd(),
paramCardType.getSQLQuotedValueForAdd(),
paramBIN.getSQLQuotedValueForAdd(),
paramLast4Digits.getSQLQuotedValueForAdd(),
paramExpirationMonth.getSQLQuotedValueForAdd(),
paramExpirationYear.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramCountryCode.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pOnlinePaymentID As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pAuthorizationCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCardType As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBIN As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLast4Digits As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationMonth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExpirationYear As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBank As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pCountryCode As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramOnlinePaymentID As DataColumnParameter = New DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID)
 Dim paramAuthorizationCode As DataColumnParameter = New DataColumnParameter(defAuthorizationCode, pAuthorizationCode)
 Dim paramCardType As DataColumnParameter = New DataColumnParameter(defCardType, pCardType)
 Dim paramBIN As DataColumnParameter = New DataColumnParameter(defBIN, pBIN)
 Dim paramLast4Digits As DataColumnParameter = New DataColumnParameter(defLast4Digits, pLast4Digits)
 Dim paramExpirationMonth As DataColumnParameter = New DataColumnParameter(defExpirationMonth, pExpirationMonth)
 Dim paramExpirationYear As DataColumnParameter = New DataColumnParameter(defExpirationYear, pExpirationYear)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramCountryCode As DataColumnParameter = New DataColumnParameter(defCountryCode, pCountryCode)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([OnlinePaymentID],[AuthorizationCode],[CardType],[BIN],[Last4Digits],[ExpirationMonth],[ExpirationYear],[Bank],[CountryCode],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10}) ", TABLE_NAME,paramOnlinePaymentID.getSQLQuotedValueForAdd(),
paramAuthorizationCode.getSQLQuotedValueForAdd(),
paramCardType.getSQLQuotedValueForAdd(),
paramBIN.getSQLQuotedValueForAdd(),
paramLast4Digits.getSQLQuotedValueForAdd(),
paramExpirationMonth.getSQLQuotedValueForAdd(),
paramExpirationYear.getSQLQuotedValueForAdd(),
paramBank.getSQLQuotedValueForAdd(),
paramCountryCode.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pOnlinePaymentID As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pAuthorizationCode As Object=Nothing,
Optional ByVal pCardType As Object=Nothing,
Optional ByVal pBIN As Object=Nothing,
Optional ByVal pLast4Digits As Object=Nothing,
Optional ByVal pExpirationMonth As Object=Nothing,
Optional ByVal pExpirationYear As Object=Nothing,
Optional ByVal pBank As Object=Nothing,
Optional ByVal pCountryCode As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramOnlinePaymentID As DataColumnParameter = New DataColumnParameter(defOnlinePaymentID, pOnlinePaymentID)
 Dim paramAuthorizationCode As DataColumnParameter = New DataColumnParameter(defAuthorizationCode, pAuthorizationCode)
 Dim paramCardType As DataColumnParameter = New DataColumnParameter(defCardType, pCardType)
 Dim paramBIN As DataColumnParameter = New DataColumnParameter(defBIN, pBIN)
 Dim paramLast4Digits As DataColumnParameter = New DataColumnParameter(defLast4Digits, pLast4Digits)
 Dim paramExpirationMonth As DataColumnParameter = New DataColumnParameter(defExpirationMonth, pExpirationMonth)
 Dim paramExpirationYear As DataColumnParameter = New DataColumnParameter(defExpirationYear, pExpirationYear)
 Dim paramBank As DataColumnParameter = New DataColumnParameter(defBank, pBank)
 Dim paramCountryCode As DataColumnParameter = New DataColumnParameter(defCountryCode, pCountryCode)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [OnlinePaymentID]={2},[AuthorizationCode]={3},[CardType]={4},[BIN]={5},[Last4Digits]={6},[ExpirationMonth]={7},[ExpirationYear]={8},[Bank]={9},[CountryCode]={10},[CreatedAt]={11} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramOnlinePaymentID.getSQLQuotedValueForUpdate(),
paramAuthorizationCode.getSQLQuotedValueForUpdate(),
paramCardType.getSQLQuotedValueForUpdate(),
paramBIN.getSQLQuotedValueForUpdate(),
paramLast4Digits.getSQLQuotedValueForUpdate(),
paramExpirationMonth.getSQLQuotedValueForUpdate(),
paramExpirationYear.getSQLQuotedValueForUpdate(),
paramBank.getSQLQuotedValueForUpdate(),
paramCountryCode.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate()  ), True)


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
