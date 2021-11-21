Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.system

Public Class T___PaystackLog
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPaymentGatewayStatusID = New DataColumnDefinition(TableColumnNames.PaymentGatewayStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIsFinalized = New DataColumnDefinition(TableColumnNames.IsFinalized.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defInitializedByUserID = New DataColumnDefinition(TableColumnNames.InitializedByUserID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defReference = New DataColumnDefinition(TableColumnNames.Reference.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccessCode = New DataColumnDefinition(TableColumnNames.AccessCode.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defInitialLizeURL = New DataColumnDefinition(TableColumnNames.InitialLizeURL.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaymentURL = New DataColumnDefinition(TableColumnNames.PaymentURL.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defVerifiyURL = New DataColumnDefinition(TableColumnNames.VerifiyURL.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAmountKobo = New DataColumnDefinition(TableColumnNames.AmountKobo.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defVerifyResponseJSON = New DataColumnDefinition(TableColumnNames.VerifyResponseJSON.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defVerifiedByUserID = New DataColumnDefinition(TableColumnNames.VerifiedByUserID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPaymentGatewayStatusID.ColumnName, defPaymentGatewayStatusID) 
  ColumnDefns.Add(defIsFinalized.ColumnName, defIsFinalized) 
  ColumnDefns.Add(defInitializedByUserID.ColumnName, defInitializedByUserID) 
  ColumnDefns.Add(defReference.ColumnName, defReference) 
  ColumnDefns.Add(defAccessCode.ColumnName, defAccessCode) 
  ColumnDefns.Add(defInitialLizeURL.ColumnName, defInitialLizeURL) 
  ColumnDefns.Add(defPaymentURL.ColumnName, defPaymentURL) 
  ColumnDefns.Add(defVerifiyURL.ColumnName, defVerifiyURL) 
  ColumnDefns.Add(defAmountKobo.ColumnName, defAmountKobo) 
  ColumnDefns.Add(defVerifyResponseJSON.ColumnName, defVerifyResponseJSON) 
  ColumnDefns.Add(defVerifiedByUserID.ColumnName, defVerifiedByUserID) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_PaymentGatewayStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "system.PaymentGatewayStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_InitializedByUserID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_PaystackLog_VerifiedByUserID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.PaystackLog", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "system.PaystackLog"
       Public Const PaystackLog__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM PaystackLog"
       Public Const PaystackLog__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentGatewayStatusID], [IsFinalized], [InitializedByUserID], [Reference], [AccessCode], [InitialLizeURL], [PaymentURL], [VerifiyURL], [AmountKobo], [VerifyResponseJSON], [VerifiedByUserID], [CreatedAt], [UpdatedAt] FROM PaystackLog"


       Public Enum TableColumnNames

           [ID]
           [PaymentGatewayStatusID]
           [IsFinalized]
           [InitializedByUserID]
           [Reference]
           [AccessCode]
           [InitialLizeURL]
           [PaymentURL]
           [VerifiyURL]
           [AmountKobo]
           [VerifyResponseJSON]
           [VerifiedByUserID]
           [CreatedAt]
           [UpdatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_system_PaystackLog 
           fk_system_PaystackLog_PaymentGatewayStatusID 
           fk_system_PaystackLog_InitializedByUserID 
           fk_system_PaystackLog_VerifiedByUserID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPaymentGatewayStatusID As DataColumnDefinition
       Public Shared ReadOnly defIsFinalized As DataColumnDefinition
       Public Shared ReadOnly defInitializedByUserID As DataColumnDefinition
       Public Shared ReadOnly defReference As DataColumnDefinition
       Public Shared ReadOnly defAccessCode As DataColumnDefinition
       Public Shared ReadOnly defInitialLizeURL As DataColumnDefinition
       Public Shared ReadOnly defPaymentURL As DataColumnDefinition
       Public Shared ReadOnly defVerifiyURL As DataColumnDefinition
       Public Shared ReadOnly defAmountKobo As DataColumnDefinition
       Public Shared ReadOnly defVerifyResponseJSON As DataColumnDefinition
       Public Shared ReadOnly defVerifiedByUserID As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition

       Public ReadOnly Property [PaymentGatewayStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentGatewayStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsFinalized] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsFinalized.ToString()))
           End Get
       End Property


       Public ReadOnly Property [InitializedByUserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.InitializedByUserID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Reference] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Reference.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccessCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccessCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [InitialLizeURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.InitialLizeURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaymentURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PaymentURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [VerifiyURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.VerifiyURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AmountKobo] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AmountKobo.ToString()))
           End Get
       End Property


       Public ReadOnly Property [VerifyResponseJSON] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.VerifyResponseJSON.ToString()))
           End Get
       End Property


       Public ReadOnly Property [VerifiedByUserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.VerifiedByUserID.ToString()))
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
        Public Function getFirstRow() As T___PaystackLog                  
            If Me.hasRows() Then Return New T___PaystackLog(Me.AllRows(0))                  
            Return New T___PaystackLog()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PaystackLog                  
            Return New T___PaystackLog(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PaystackLog                  
            Return New T___PaystackLog(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PaystackLog                  
            Return New T___PaystackLog(Me.RawTable, T___PaystackLog.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PaystackLog,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PaystackLog,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PaystackLog                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PaystackLog(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaystackLog(drst.CopyToDataTable(),                  
                    T___PaystackLog.TABLE_NAME)                  
                Return New T___PaystackLog()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PaystackLog()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PaystackLog                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PaystackLog(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaystackLog(drst.CopyToDataTable(),                  
                    T___PaystackLog.TABLE_NAME)                  
                Return New T___PaystackLog()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PaystackLog()                  
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
            Return PaystackLog__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPaymentGatewayStatusID As Int32,
ByVal pInitializedByUserID As Int32,
ByVal pVerifiedByUserID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentGatewayStatusID As DataColumnParameter = New DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID)
 Dim paramInitializedByUserID As DataColumnParameter = New DataColumnParameter(defInitializedByUserID, pInitializedByUserID)
 Dim paramVerifiedByUserID As DataColumnParameter = New DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID)
 Dim paramIsFinalized As DataColumnParameter = New DataColumnParameter(defIsFinalized, defIsFinalized.DefaultValue)
 Dim paramReference As DataColumnParameter = New DataColumnParameter(defReference, defReference.DefaultValue)
 Dim paramAccessCode As DataColumnParameter = New DataColumnParameter(defAccessCode, defAccessCode.DefaultValue)
 Dim paramInitialLizeURL As DataColumnParameter = New DataColumnParameter(defInitialLizeURL, defInitialLizeURL.DefaultValue)
 Dim paramPaymentURL As DataColumnParameter = New DataColumnParameter(defPaymentURL, defPaymentURL.DefaultValue)
 Dim paramVerifiyURL As DataColumnParameter = New DataColumnParameter(defVerifiyURL, defVerifiyURL.DefaultValue)
 Dim paramAmountKobo As DataColumnParameter = New DataColumnParameter(defAmountKobo, defAmountKobo.DefaultValue)
 Dim paramVerifyResponseJSON As DataColumnParameter = New DataColumnParameter(defVerifyResponseJSON, defVerifyResponseJSON.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentGatewayStatusID.getSQLQuotedValueForAdd(),
paramIsFinalized.getSQLQuotedValueForAdd(),
paramInitializedByUserID.getSQLQuotedValueForAdd(),
paramReference.getSQLQuotedValueForAdd(),
paramAccessCode.getSQLQuotedValueForAdd(),
paramInitialLizeURL.getSQLQuotedValueForAdd(),
paramPaymentURL.getSQLQuotedValueForAdd(),
paramVerifiyURL.getSQLQuotedValueForAdd(),
paramAmountKobo.getSQLQuotedValueForAdd(),
paramVerifyResponseJSON.getSQLQuotedValueForAdd(),
paramVerifiedByUserID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPaymentGatewayStatusID As Int32,
ByVal pIsFinalized As Boolean,
ByVal pInitializedByUserID As Int32,
ByVal pInitialLizeURL As String,
ByVal pAmountKobo As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pReference As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccessCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiyURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifyResponseJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiedByUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentGatewayStatusID As DataColumnParameter = New DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID)
 Dim paramIsFinalized As DataColumnParameter = New DataColumnParameter(defIsFinalized, pIsFinalized)
 Dim paramInitializedByUserID As DataColumnParameter = New DataColumnParameter(defInitializedByUserID, pInitializedByUserID)
 Dim paramReference As DataColumnParameter = New DataColumnParameter(defReference, pReference)
 Dim paramAccessCode As DataColumnParameter = New DataColumnParameter(defAccessCode, pAccessCode)
 Dim paramInitialLizeURL As DataColumnParameter = New DataColumnParameter(defInitialLizeURL, pInitialLizeURL)
 Dim paramPaymentURL As DataColumnParameter = New DataColumnParameter(defPaymentURL, pPaymentURL)
 Dim paramVerifiyURL As DataColumnParameter = New DataColumnParameter(defVerifiyURL, pVerifiyURL)
 Dim paramAmountKobo As DataColumnParameter = New DataColumnParameter(defAmountKobo, pAmountKobo)
 Dim paramVerifyResponseJSON As DataColumnParameter = New DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON)
 Dim paramVerifiedByUserID As DataColumnParameter = New DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentGatewayStatusID.getSQLQuotedValueForAdd(),
paramIsFinalized.getSQLQuotedValueForAdd(),
paramInitializedByUserID.getSQLQuotedValueForAdd(),
paramReference.getSQLQuotedValueForAdd(),
paramAccessCode.getSQLQuotedValueForAdd(),
paramInitialLizeURL.getSQLQuotedValueForAdd(),
paramPaymentURL.getSQLQuotedValueForAdd(),
paramVerifiyURL.getSQLQuotedValueForAdd(),
paramAmountKobo.getSQLQuotedValueForAdd(),
paramVerifyResponseJSON.getSQLQuotedValueForAdd(),
paramVerifiedByUserID.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPaymentGatewayStatusID As Int32,
ByVal pIsFinalized As Boolean,
ByVal pInitializedByUserID As Int32,
ByVal pInitialLizeURL As String,
ByVal pAmountKobo As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pReference As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccessCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiyURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifyResponseJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiedByUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPaymentGatewayStatusID As DataColumnParameter = New DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID)
 Dim paramIsFinalized As DataColumnParameter = New DataColumnParameter(defIsFinalized, pIsFinalized)
 Dim paramInitializedByUserID As DataColumnParameter = New DataColumnParameter(defInitializedByUserID, pInitializedByUserID)
 Dim paramReference As DataColumnParameter = New DataColumnParameter(defReference, pReference)
 Dim paramAccessCode As DataColumnParameter = New DataColumnParameter(defAccessCode, pAccessCode)
 Dim paramInitialLizeURL As DataColumnParameter = New DataColumnParameter(defInitialLizeURL, pInitialLizeURL)
 Dim paramPaymentURL As DataColumnParameter = New DataColumnParameter(defPaymentURL, pPaymentURL)
 Dim paramVerifiyURL As DataColumnParameter = New DataColumnParameter(defVerifiyURL, pVerifiyURL)
 Dim paramAmountKobo As DataColumnParameter = New DataColumnParameter(defAmountKobo, pAmountKobo)
 Dim paramVerifyResponseJSON As DataColumnParameter = New DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON)
 Dim paramVerifiedByUserID As DataColumnParameter = New DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentGatewayStatusID.getSQLQuotedValueForAdd(),
paramIsFinalized.getSQLQuotedValueForAdd(),
paramInitializedByUserID.getSQLQuotedValueForAdd(),
paramReference.getSQLQuotedValueForAdd(),
paramAccessCode.getSQLQuotedValueForAdd(),
paramInitialLizeURL.getSQLQuotedValueForAdd(),
paramPaymentURL.getSQLQuotedValueForAdd(),
paramVerifiyURL.getSQLQuotedValueForAdd(),
paramAmountKobo.getSQLQuotedValueForAdd(),
paramVerifyResponseJSON.getSQLQuotedValueForAdd(),
paramVerifiedByUserID.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pPaymentGatewayStatusID As Int32,
ByVal pIsFinalized As Boolean,
ByVal pInitializedByUserID As Int32,
ByVal pInitialLizeURL As String,
ByVal pAmountKobo As Int32,
ByVal pCreatedAt As DateTime,
Optional ByVal pReference As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccessCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPaymentURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiyURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifyResponseJSON As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVerifiedByUserID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramPaymentGatewayStatusID As DataColumnParameter = New DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID)
 Dim paramIsFinalized As DataColumnParameter = New DataColumnParameter(defIsFinalized, pIsFinalized)
 Dim paramInitializedByUserID As DataColumnParameter = New DataColumnParameter(defInitializedByUserID, pInitializedByUserID)
 Dim paramReference As DataColumnParameter = New DataColumnParameter(defReference, pReference)
 Dim paramAccessCode As DataColumnParameter = New DataColumnParameter(defAccessCode, pAccessCode)
 Dim paramInitialLizeURL As DataColumnParameter = New DataColumnParameter(defInitialLizeURL, pInitialLizeURL)
 Dim paramPaymentURL As DataColumnParameter = New DataColumnParameter(defPaymentURL, pPaymentURL)
 Dim paramVerifiyURL As DataColumnParameter = New DataColumnParameter(defVerifiyURL, pVerifiyURL)
 Dim paramAmountKobo As DataColumnParameter = New DataColumnParameter(defAmountKobo, pAmountKobo)
 Dim paramVerifyResponseJSON As DataColumnParameter = New DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON)
 Dim paramVerifiedByUserID As DataColumnParameter = New DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([PaymentGatewayStatusID],[IsFinalized],[InitializedByUserID],[Reference],[AccessCode],[InitialLizeURL],[PaymentURL],[VerifiyURL],[AmountKobo],[VerifyResponseJSON],[VerifiedByUserID],[CreatedAt],[UpdatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramPaymentGatewayStatusID.getSQLQuotedValueForAdd(),
paramIsFinalized.getSQLQuotedValueForAdd(),
paramInitializedByUserID.getSQLQuotedValueForAdd(),
paramReference.getSQLQuotedValueForAdd(),
paramAccessCode.getSQLQuotedValueForAdd(),
paramInitialLizeURL.getSQLQuotedValueForAdd(),
paramPaymentURL.getSQLQuotedValueForAdd(),
paramVerifiyURL.getSQLQuotedValueForAdd(),
paramAmountKobo.getSQLQuotedValueForAdd(),
paramVerifyResponseJSON.getSQLQuotedValueForAdd(),
paramVerifiedByUserID.getSQLQuotedValueForAdd(),
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
Optional ByVal pPaymentGatewayStatusID As Object=Nothing,
Optional ByVal pIsFinalized As Object=Nothing,
Optional ByVal pInitializedByUserID As Object=Nothing,
Optional ByVal pInitialLizeURL As Object=Nothing,
Optional ByVal pAmountKobo As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pReference As Object=Nothing,
Optional ByVal pAccessCode As Object=Nothing,
Optional ByVal pPaymentURL As Object=Nothing,
Optional ByVal pVerifiyURL As Object=Nothing,
Optional ByVal pVerifyResponseJSON As Object=Nothing,
Optional ByVal pVerifiedByUserID As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPaymentGatewayStatusID As DataColumnParameter = New DataColumnParameter(defPaymentGatewayStatusID, pPaymentGatewayStatusID)
 Dim paramIsFinalized As DataColumnParameter = New DataColumnParameter(defIsFinalized, pIsFinalized)
 Dim paramInitializedByUserID As DataColumnParameter = New DataColumnParameter(defInitializedByUserID, pInitializedByUserID)
 Dim paramReference As DataColumnParameter = New DataColumnParameter(defReference, pReference)
 Dim paramAccessCode As DataColumnParameter = New DataColumnParameter(defAccessCode, pAccessCode)
 Dim paramInitialLizeURL As DataColumnParameter = New DataColumnParameter(defInitialLizeURL, pInitialLizeURL)
 Dim paramPaymentURL As DataColumnParameter = New DataColumnParameter(defPaymentURL, pPaymentURL)
 Dim paramVerifiyURL As DataColumnParameter = New DataColumnParameter(defVerifiyURL, pVerifiyURL)
 Dim paramAmountKobo As DataColumnParameter = New DataColumnParameter(defAmountKobo, pAmountKobo)
 Dim paramVerifyResponseJSON As DataColumnParameter = New DataColumnParameter(defVerifyResponseJSON, pVerifyResponseJSON)
 Dim paramVerifiedByUserID As DataColumnParameter = New DataColumnParameter(defVerifiedByUserID, pVerifiedByUserID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [PaymentGatewayStatusID]={2},[IsFinalized]={3},[InitializedByUserID]={4},[Reference]={5},[AccessCode]={6},[InitialLizeURL]={7},[PaymentURL]={8},[VerifiyURL]={9},[AmountKobo]={10},[VerifyResponseJSON]={11},[VerifiedByUserID]={12},[CreatedAt]={13},[UpdatedAt]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPaymentGatewayStatusID.getSQLQuotedValueForUpdate(),
paramIsFinalized.getSQLQuotedValueForUpdate(),
paramInitializedByUserID.getSQLQuotedValueForUpdate(),
paramReference.getSQLQuotedValueForUpdate(),
paramAccessCode.getSQLQuotedValueForUpdate(),
paramInitialLizeURL.getSQLQuotedValueForUpdate(),
paramPaymentURL.getSQLQuotedValueForUpdate(),
paramVerifiyURL.getSQLQuotedValueForUpdate(),
paramAmountKobo.getSQLQuotedValueForUpdate(),
paramVerifyResponseJSON.getSQLQuotedValueForUpdate(),
paramVerifiedByUserID.getSQLQuotedValueForUpdate(),
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
