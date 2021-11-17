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

Public Class T___OnlinePayment
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPaymentID = New DataColumnDefinition(TableColumnNames.PaymentID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defTransactionDate = New DataColumnDefinition(TableColumnNames.TransactionDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defChannel = New DataColumnDefinition(TableColumnNames.Channel.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIpAddress = New DataColumnDefinition(TableColumnNames.IpAddress.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGatewayCharges = New DataColumnDefinition(TableColumnNames.GatewayCharges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGatewayLogReference = New DataColumnDefinition(TableColumnNames.GatewayLogReference.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGateway = New DataColumnDefinition(TableColumnNames.Gateway.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPlatformCharges = New DataColumnDefinition(TableColumnNames.PlatformCharges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGatewayAmountReceived = New DataColumnDefinition(TableColumnNames.GatewayAmountReceived.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPlatformAmountReceived = New DataColumnDefinition(TableColumnNames.PlatformAmountReceived.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGatewayChargesExplaination = New DataColumnDefinition(TableColumnNames.GatewayChargesExplaination.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPlatformChargesExplaination = New DataColumnDefinition(TableColumnNames.PlatformChargesExplaination.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPaymentID.ColumnName, defPaymentID) 
  ColumnDefns.Add(defTransactionDate.ColumnName, defTransactionDate) 
  ColumnDefns.Add(defChannel.ColumnName, defChannel) 
  ColumnDefns.Add(defIpAddress.ColumnName, defIpAddress) 
  ColumnDefns.Add(defGatewayCharges.ColumnName, defGatewayCharges) 
  ColumnDefns.Add(defGatewayLogReference.ColumnName, defGatewayLogReference) 
  ColumnDefns.Add(defGateway.ColumnName, defGateway) 
  ColumnDefns.Add(defPlatformCharges.ColumnName, defPlatformCharges) 
  ColumnDefns.Add(defGatewayAmountReceived.ColumnName, defGatewayAmountReceived) 
  ColumnDefns.Add(defPlatformAmountReceived.ColumnName, defPlatformAmountReceived) 
  ColumnDefns.Add(defGatewayChargesExplaination.ColumnName, defGatewayChargesExplaination) 
  ColumnDefns.Add(defPlatformChargesExplaination.ColumnName, defPlatformChargesExplaination) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_accounting_OnlinePayment_PaymentID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "accounting.OnlinePayment", "accounting.Payment"                  
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

       Public Const TABLE_NAME As String = "accounting.OnlinePayment"
       Public Const OnlinePayment__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM OnlinePayment"
       Public Const OnlinePayment__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentID], [TransactionDate], [Channel], [IpAddress], [GatewayCharges], [GatewayLogReference], [Gateway], [PlatformCharges], [GatewayAmountReceived], [PlatformAmountReceived], [GatewayChargesExplaination], [PlatformChargesExplaination], [CreatedAt] FROM OnlinePayment"


       Public Enum TableColumnNames

           [ID]
           [PaymentID]
           [TransactionDate]
           [Channel]
           [IpAddress]
           [GatewayCharges]
           [GatewayLogReference]
           [Gateway]
           [PlatformCharges]
           [GatewayAmountReceived]
           [PlatformAmountReceived]
           [GatewayChargesExplaination]
           [PlatformChargesExplaination]
           [CreatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_accounting_OnlinePayment 
           fk_accounting_OnlinePayment_PaymentID 
           uq_accounting_OnlinePayment_PaymentID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPaymentID As DataColumnDefinition
       Public Shared ReadOnly defTransactionDate As DataColumnDefinition
       Public Shared ReadOnly defChannel As DataColumnDefinition
       Public Shared ReadOnly defIpAddress As DataColumnDefinition
       Public Shared ReadOnly defGatewayCharges As DataColumnDefinition
       Public Shared ReadOnly defGatewayLogReference As DataColumnDefinition
       Public Shared ReadOnly defGateway As DataColumnDefinition
       Public Shared ReadOnly defPlatformCharges As DataColumnDefinition
       Public Shared ReadOnly defGatewayAmountReceived As DataColumnDefinition
       Public Shared ReadOnly defPlatformAmountReceived As DataColumnDefinition
       Public Shared ReadOnly defGatewayChargesExplaination As DataColumnDefinition
       Public Shared ReadOnly defPlatformChargesExplaination As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition

       Public ReadOnly Property [PaymentID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TransactionDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TransactionDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Channel] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Channel.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IpAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IpAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [GatewayCharges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.GatewayCharges.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [GatewayLogReference] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.GatewayLogReference.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Gateway] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Gateway.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PlatformCharges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PlatformCharges.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [GatewayAmountReceived] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.GatewayAmountReceived.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [PlatformAmountReceived] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PlatformAmountReceived.ToString())) )
           End Get
       End Property


       Public ReadOnly Property [GatewayChargesExplaination] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.GatewayChargesExplaination.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PlatformChargesExplaination] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PlatformChargesExplaination.ToString()))
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
        Public Function getFirstRow() As T___OnlinePayment                  
            If Me.hasRows() Then Return New T___OnlinePayment(Me.AllRows(0))                  
            Return New T___OnlinePayment()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___OnlinePayment                  
            Return New T___OnlinePayment(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___OnlinePayment                  
            Return New T___OnlinePayment(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___OnlinePayment                  
            Return New T___OnlinePayment(Me.RawTable, T___OnlinePayment.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___OnlinePayment,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___OnlinePayment,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___OnlinePayment                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___OnlinePayment(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___OnlinePayment(drst.CopyToDataTable(),                  
                    T___OnlinePayment.TABLE_NAME)                  
                Return New T___OnlinePayment()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___OnlinePayment()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___OnlinePayment                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___OnlinePayment(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___OnlinePayment(drst.CopyToDataTable(),                  
                    T___OnlinePayment.TABLE_NAME)                  
                Return New T___OnlinePayment()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___OnlinePayment()                  
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
            Return OnlinePayment__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPaymentID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentID As DataColumnParameter = New DataColumnParameter(defPaymentID, pPaymentID)
 Dim paramTransactionDate As DataColumnParameter = New DataColumnParameter(defTransactionDate, defTransactionDate.DefaultValue)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, defChannel.DefaultValue)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, defIpAddress.DefaultValue)
 Dim paramGatewayCharges As DataColumnParameter = New DataColumnParameter(defGatewayCharges, defGatewayCharges.DefaultValue)
 Dim paramGatewayLogReference As DataColumnParameter = New DataColumnParameter(defGatewayLogReference, defGatewayLogReference.DefaultValue)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, defGateway.DefaultValue)
 Dim paramPlatformCharges As DataColumnParameter = New DataColumnParameter(defPlatformCharges, defPlatformCharges.DefaultValue)
 Dim paramGatewayAmountReceived As DataColumnParameter = New DataColumnParameter(defGatewayAmountReceived, defGatewayAmountReceived.DefaultValue)
 Dim paramPlatformAmountReceived As DataColumnParameter = New DataColumnParameter(defPlatformAmountReceived, defPlatformAmountReceived.DefaultValue)
 Dim paramGatewayChargesExplaination As DataColumnParameter = New DataColumnParameter(defGatewayChargesExplaination, defGatewayChargesExplaination.DefaultValue)
 Dim paramPlatformChargesExplaination As DataColumnParameter = New DataColumnParameter(defPlatformChargesExplaination, defPlatformChargesExplaination.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentID.getSQLQuotedValueForAdd(),
paramTransactionDate.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramGatewayCharges.getSQLQuotedValueForAdd(),
paramGatewayLogReference.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd(),
paramPlatformCharges.getSQLQuotedValueForAdd(),
paramGatewayAmountReceived.getSQLQuotedValueForAdd(),
paramPlatformAmountReceived.getSQLQuotedValueForAdd(),
paramGatewayChargesExplaination.getSQLQuotedValueForAdd(),
paramPlatformChargesExplaination.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPaymentID As Int32,
ByVal pTransactionDate As DateTime,
ByVal pChannel As String,
ByVal pIpAddress As String,
ByVal pGatewayCharges As Decimal,
ByVal pGatewayLogReference As String,
ByVal pGateway As String,
ByVal pPlatformCharges As Decimal,
ByVal pGatewayAmountReceived As Decimal,
ByVal pPlatformAmountReceived As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pGatewayChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPlatformChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentID As DataColumnParameter = New DataColumnParameter(defPaymentID, pPaymentID)
 Dim paramTransactionDate As DataColumnParameter = New DataColumnParameter(defTransactionDate, pTransactionDate)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramGatewayCharges As DataColumnParameter = New DataColumnParameter(defGatewayCharges, pGatewayCharges)
 Dim paramGatewayLogReference As DataColumnParameter = New DataColumnParameter(defGatewayLogReference, pGatewayLogReference)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)
 Dim paramPlatformCharges As DataColumnParameter = New DataColumnParameter(defPlatformCharges, pPlatformCharges)
 Dim paramGatewayAmountReceived As DataColumnParameter = New DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived)
 Dim paramPlatformAmountReceived As DataColumnParameter = New DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived)
 Dim paramGatewayChargesExplaination As DataColumnParameter = New DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination)
 Dim paramPlatformChargesExplaination As DataColumnParameter = New DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentID.getSQLQuotedValueForAdd(),
paramTransactionDate.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramGatewayCharges.getSQLQuotedValueForAdd(),
paramGatewayLogReference.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd(),
paramPlatformCharges.getSQLQuotedValueForAdd(),
paramGatewayAmountReceived.getSQLQuotedValueForAdd(),
paramPlatformAmountReceived.getSQLQuotedValueForAdd(),
paramGatewayChargesExplaination.getSQLQuotedValueForAdd(),
paramPlatformChargesExplaination.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPaymentID As Int32,
ByVal pTransactionDate As DateTime,
ByVal pChannel As String,
ByVal pIpAddress As String,
ByVal pGatewayCharges As Decimal,
ByVal pGatewayLogReference As String,
ByVal pGateway As String,
ByVal pPlatformCharges As Decimal,
ByVal pGatewayAmountReceived As Decimal,
ByVal pPlatformAmountReceived As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pGatewayChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPlatformChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPaymentID As DataColumnParameter = New DataColumnParameter(defPaymentID, pPaymentID)
 Dim paramTransactionDate As DataColumnParameter = New DataColumnParameter(defTransactionDate, pTransactionDate)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramGatewayCharges As DataColumnParameter = New DataColumnParameter(defGatewayCharges, pGatewayCharges)
 Dim paramGatewayLogReference As DataColumnParameter = New DataColumnParameter(defGatewayLogReference, pGatewayLogReference)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)
 Dim paramPlatformCharges As DataColumnParameter = New DataColumnParameter(defPlatformCharges, pPlatformCharges)
 Dim paramGatewayAmountReceived As DataColumnParameter = New DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived)
 Dim paramPlatformAmountReceived As DataColumnParameter = New DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived)
 Dim paramGatewayChargesExplaination As DataColumnParameter = New DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination)
 Dim paramPlatformChargesExplaination As DataColumnParameter = New DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentID.getSQLQuotedValueForAdd(),
paramTransactionDate.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramGatewayCharges.getSQLQuotedValueForAdd(),
paramGatewayLogReference.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd(),
paramPlatformCharges.getSQLQuotedValueForAdd(),
paramGatewayAmountReceived.getSQLQuotedValueForAdd(),
paramPlatformAmountReceived.getSQLQuotedValueForAdd(),
paramGatewayChargesExplaination.getSQLQuotedValueForAdd(),
paramPlatformChargesExplaination.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pPaymentID As Int32,
ByVal pTransactionDate As DateTime,
ByVal pChannel As String,
ByVal pIpAddress As String,
ByVal pGatewayCharges As Decimal,
ByVal pGatewayLogReference As String,
ByVal pGateway As String,
ByVal pPlatformCharges As Decimal,
ByVal pGatewayAmountReceived As Decimal,
ByVal pPlatformAmountReceived As Decimal,
ByVal pCreatedAt As DateTime,
Optional ByVal pGatewayChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPlatformChargesExplaination As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramPaymentID As DataColumnParameter = New DataColumnParameter(defPaymentID, pPaymentID)
 Dim paramTransactionDate As DataColumnParameter = New DataColumnParameter(defTransactionDate, pTransactionDate)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramGatewayCharges As DataColumnParameter = New DataColumnParameter(defGatewayCharges, pGatewayCharges)
 Dim paramGatewayLogReference As DataColumnParameter = New DataColumnParameter(defGatewayLogReference, pGatewayLogReference)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)
 Dim paramPlatformCharges As DataColumnParameter = New DataColumnParameter(defPlatformCharges, pPlatformCharges)
 Dim paramGatewayAmountReceived As DataColumnParameter = New DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived)
 Dim paramPlatformAmountReceived As DataColumnParameter = New DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived)
 Dim paramGatewayChargesExplaination As DataColumnParameter = New DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination)
 Dim paramPlatformChargesExplaination As DataColumnParameter = New DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([PaymentID],[TransactionDate],[Channel],[IpAddress],[GatewayCharges],[GatewayLogReference],[Gateway],[PlatformCharges],[GatewayAmountReceived],[PlatformAmountReceived],[GatewayChargesExplaination],[PlatformChargesExplaination],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramPaymentID.getSQLQuotedValueForAdd(),
paramTransactionDate.getSQLQuotedValueForAdd(),
paramChannel.getSQLQuotedValueForAdd(),
paramIpAddress.getSQLQuotedValueForAdd(),
paramGatewayCharges.getSQLQuotedValueForAdd(),
paramGatewayLogReference.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd(),
paramPlatformCharges.getSQLQuotedValueForAdd(),
paramGatewayAmountReceived.getSQLQuotedValueForAdd(),
paramPlatformAmountReceived.getSQLQuotedValueForAdd(),
paramGatewayChargesExplaination.getSQLQuotedValueForAdd(),
paramPlatformChargesExplaination.getSQLQuotedValueForAdd(),
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
Optional ByVal pPaymentID As Object=Nothing,
Optional ByVal pTransactionDate As Object=Nothing,
Optional ByVal pChannel As Object=Nothing,
Optional ByVal pIpAddress As Object=Nothing,
Optional ByVal pGatewayCharges As Object=Nothing,
Optional ByVal pGatewayLogReference As Object=Nothing,
Optional ByVal pGateway As Object=Nothing,
Optional ByVal pPlatformCharges As Object=Nothing,
Optional ByVal pGatewayAmountReceived As Object=Nothing,
Optional ByVal pPlatformAmountReceived As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pGatewayChargesExplaination As Object=Nothing,
Optional ByVal pPlatformChargesExplaination As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPaymentID As DataColumnParameter = New DataColumnParameter(defPaymentID, pPaymentID)
 Dim paramTransactionDate As DataColumnParameter = New DataColumnParameter(defTransactionDate, pTransactionDate)
 Dim paramChannel As DataColumnParameter = New DataColumnParameter(defChannel, pChannel)
 Dim paramIpAddress As DataColumnParameter = New DataColumnParameter(defIpAddress, pIpAddress)
 Dim paramGatewayCharges As DataColumnParameter = New DataColumnParameter(defGatewayCharges, pGatewayCharges)
 Dim paramGatewayLogReference As DataColumnParameter = New DataColumnParameter(defGatewayLogReference, pGatewayLogReference)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)
 Dim paramPlatformCharges As DataColumnParameter = New DataColumnParameter(defPlatformCharges, pPlatformCharges)
 Dim paramGatewayAmountReceived As DataColumnParameter = New DataColumnParameter(defGatewayAmountReceived, pGatewayAmountReceived)
 Dim paramPlatformAmountReceived As DataColumnParameter = New DataColumnParameter(defPlatformAmountReceived, pPlatformAmountReceived)
 Dim paramGatewayChargesExplaination As DataColumnParameter = New DataColumnParameter(defGatewayChargesExplaination, pGatewayChargesExplaination)
 Dim paramPlatformChargesExplaination As DataColumnParameter = New DataColumnParameter(defPlatformChargesExplaination, pPlatformChargesExplaination)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [PaymentID]={2},[TransactionDate]={3},[Channel]={4},[IpAddress]={5},[GatewayCharges]={6},[GatewayLogReference]={7},[Gateway]={8},[PlatformCharges]={9},[GatewayAmountReceived]={10},[PlatformAmountReceived]={11},[GatewayChargesExplaination]={12},[PlatformChargesExplaination]={13},[CreatedAt]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPaymentID.getSQLQuotedValueForUpdate(),
paramTransactionDate.getSQLQuotedValueForUpdate(),
paramChannel.getSQLQuotedValueForUpdate(),
paramIpAddress.getSQLQuotedValueForUpdate(),
paramGatewayCharges.getSQLQuotedValueForUpdate(),
paramGatewayLogReference.getSQLQuotedValueForUpdate(),
paramGateway.getSQLQuotedValueForUpdate(),
paramPlatformCharges.getSQLQuotedValueForUpdate(),
paramGatewayAmountReceived.getSQLQuotedValueForUpdate(),
paramPlatformAmountReceived.getSQLQuotedValueForUpdate(),
paramGatewayChargesExplaination.getSQLQuotedValueForUpdate(),
paramPlatformChargesExplaination.getSQLQuotedValueForUpdate(),
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
