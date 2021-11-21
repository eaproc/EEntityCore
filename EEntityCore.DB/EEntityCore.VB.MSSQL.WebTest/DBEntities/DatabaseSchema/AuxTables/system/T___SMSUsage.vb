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

Public Class T___SMSUsage
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defSMSDeliveryStatusID = New DataColumnDefinition(TableColumnNames.SMSDeliveryStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defSender = New DataColumnDefinition(TableColumnNames.Sender.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defReceiver = New DataColumnDefinition(TableColumnNames.Receiver.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMessage = New DataColumnDefinition(TableColumnNames.Message.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUID = New DataColumnDefinition(TableColumnNames.UID.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAPICreateResponse = New DataColumnDefinition(TableColumnNames.APICreateResponse.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAPIUpdateResponse = New DataColumnDefinition(TableColumnNames.APIUpdateResponse.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSMSCostNaira = New DataColumnDefinition(TableColumnNames.SMSCostNaira.ToString(), GetType(Decimal), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExceptionMessage = New DataColumnDefinition(TableColumnNames.ExceptionMessage.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defExceptionStackTrace = New DataColumnDefinition(TableColumnNames.ExceptionStackTrace.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGateway = New DataColumnDefinition(TableColumnNames.Gateway.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defSMSDeliveryStatusID.ColumnName, defSMSDeliveryStatusID) 
  ColumnDefns.Add(defSender.ColumnName, defSender) 
  ColumnDefns.Add(defReceiver.ColumnName, defReceiver) 
  ColumnDefns.Add(defMessage.ColumnName, defMessage) 
  ColumnDefns.Add(defUID.ColumnName, defUID) 
  ColumnDefns.Add(defAPICreateResponse.ColumnName, defAPICreateResponse) 
  ColumnDefns.Add(defAPIUpdateResponse.ColumnName, defAPIUpdateResponse) 
  ColumnDefns.Add(defSMSCostNaira.ColumnName, defSMSCostNaira) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defExceptionMessage.ColumnName, defExceptionMessage) 
  ColumnDefns.Add(defExceptionStackTrace.ColumnName, defExceptionStackTrace) 
  ColumnDefns.Add(defGateway.ColumnName, defGateway) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_system_SMSUsage_SMSDeliveryStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "system.SMSUsage", "system.SMSDeliveryStatus"                  
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

       Public Const TABLE_NAME As String = "system.SMSUsage"
       Public Const SMSUsage__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM SMSUsage"
       Public Const SMSUsage__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [SMSDeliveryStatusID], [Sender], [Receiver], [Message], [UID], [APICreateResponse], [APIUpdateResponse], [SMSCostNaira], [CreatedAt], [UpdatedAt], [ExceptionMessage], [ExceptionStackTrace], [Gateway] FROM SMSUsage"


       Public Enum TableColumnNames

           [ID]
           [SMSDeliveryStatusID]
           [Sender]
           [Receiver]
           [Message]
           [UID]
           [APICreateResponse]
           [APIUpdateResponse]
           [SMSCostNaira]
           [CreatedAt]
           [UpdatedAt]
           [ExceptionMessage]
           [ExceptionStackTrace]
           [Gateway]
       End Enum 



       Public Enum TableConstraints

           pk_system_SMSUsage 
           fk_system_SMSUsage_SMSDeliveryStatusID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defSMSDeliveryStatusID As DataColumnDefinition
       Public Shared ReadOnly defSender As DataColumnDefinition
       Public Shared ReadOnly defReceiver As DataColumnDefinition
       Public Shared ReadOnly defMessage As DataColumnDefinition
       Public Shared ReadOnly defUID As DataColumnDefinition
       Public Shared ReadOnly defAPICreateResponse As DataColumnDefinition
       Public Shared ReadOnly defAPIUpdateResponse As DataColumnDefinition
       Public Shared ReadOnly defSMSCostNaira As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defExceptionMessage As DataColumnDefinition
       Public Shared ReadOnly defExceptionStackTrace As DataColumnDefinition
       Public Shared ReadOnly defGateway As DataColumnDefinition

       Public ReadOnly Property [SMSDeliveryStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.SMSDeliveryStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Sender] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Sender.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Receiver] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Receiver.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Message] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Message.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UID] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.UID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [APICreateResponse] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.APICreateResponse.ToString()))
           End Get
       End Property


       Public ReadOnly Property [APIUpdateResponse] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.APIUpdateResponse.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SMSCostNaira] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.SMSCostNaira.ToString())) )
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


       Public ReadOnly Property [ExceptionMessage] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ExceptionMessage.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ExceptionStackTrace] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ExceptionStackTrace.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Gateway] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Gateway.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___SMSUsage                  
            If Me.hasRows() Then Return New T___SMSUsage(Me.AllRows(0))                  
            Return New T___SMSUsage()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___SMSUsage                  
            Return New T___SMSUsage(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___SMSUsage                  
            Return New T___SMSUsage(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___SMSUsage                  
            Return New T___SMSUsage(Me.RawTable, T___SMSUsage.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___SMSUsage,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___SMSUsage,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___SMSUsage                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___SMSUsage(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___SMSUsage(drst.CopyToDataTable(),                  
                    T___SMSUsage.TABLE_NAME)                  
                Return New T___SMSUsage()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___SMSUsage()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___SMSUsage                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___SMSUsage(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___SMSUsage(drst.CopyToDataTable(),                  
                    T___SMSUsage.TABLE_NAME)                  
                Return New T___SMSUsage()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___SMSUsage()                  
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
            Return SMSUsage__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pSMSDeliveryStatusID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramSMSDeliveryStatusID As DataColumnParameter = New DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID)
 Dim paramSender As DataColumnParameter = New DataColumnParameter(defSender, defSender.DefaultValue)
 Dim paramReceiver As DataColumnParameter = New DataColumnParameter(defReceiver, defReceiver.DefaultValue)
 Dim paramMessage As DataColumnParameter = New DataColumnParameter(defMessage, defMessage.DefaultValue)
 Dim paramUID As DataColumnParameter = New DataColumnParameter(defUID, defUID.DefaultValue)
 Dim paramAPICreateResponse As DataColumnParameter = New DataColumnParameter(defAPICreateResponse, defAPICreateResponse.DefaultValue)
 Dim paramAPIUpdateResponse As DataColumnParameter = New DataColumnParameter(defAPIUpdateResponse, defAPIUpdateResponse.DefaultValue)
 Dim paramSMSCostNaira As DataColumnParameter = New DataColumnParameter(defSMSCostNaira, defSMSCostNaira.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, defExceptionMessage.DefaultValue)
 Dim paramExceptionStackTrace As DataColumnParameter = New DataColumnParameter(defExceptionStackTrace, defExceptionStackTrace.DefaultValue)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, defGateway.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pSMSDeliveryStatusID As Int32,
ByVal pSender As String,
ByVal pReceiver As String,
ByVal pMessage As String,
ByVal pCreatedAt As DateTime,
ByVal pGateway As String,
Optional ByVal pUID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPICreateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPIUpdateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSMSCostNaira As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionMessage As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionStackTrace As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramSMSDeliveryStatusID As DataColumnParameter = New DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID)
 Dim paramSender As DataColumnParameter = New DataColumnParameter(defSender, pSender)
 Dim paramReceiver As DataColumnParameter = New DataColumnParameter(defReceiver, pReceiver)
 Dim paramMessage As DataColumnParameter = New DataColumnParameter(defMessage, pMessage)
 Dim paramUID As DataColumnParameter = New DataColumnParameter(defUID, pUID)
 Dim paramAPICreateResponse As DataColumnParameter = New DataColumnParameter(defAPICreateResponse, pAPICreateResponse)
 Dim paramAPIUpdateResponse As DataColumnParameter = New DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse)
 Dim paramSMSCostNaira As DataColumnParameter = New DataColumnParameter(defSMSCostNaira, pSMSCostNaira)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramExceptionStackTrace As DataColumnParameter = New DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pSMSDeliveryStatusID As Int32,
ByVal pSender As String,
ByVal pReceiver As String,
ByVal pMessage As String,
ByVal pCreatedAt As DateTime,
ByVal pGateway As String,
Optional ByVal pUID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPICreateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPIUpdateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSMSCostNaira As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionMessage As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionStackTrace As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramSMSDeliveryStatusID As DataColumnParameter = New DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID)
 Dim paramSender As DataColumnParameter = New DataColumnParameter(defSender, pSender)
 Dim paramReceiver As DataColumnParameter = New DataColumnParameter(defReceiver, pReceiver)
 Dim paramMessage As DataColumnParameter = New DataColumnParameter(defMessage, pMessage)
 Dim paramUID As DataColumnParameter = New DataColumnParameter(defUID, pUID)
 Dim paramAPICreateResponse As DataColumnParameter = New DataColumnParameter(defAPICreateResponse, pAPICreateResponse)
 Dim paramAPIUpdateResponse As DataColumnParameter = New DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse)
 Dim paramSMSCostNaira As DataColumnParameter = New DataColumnParameter(defSMSCostNaira, pSMSCostNaira)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramExceptionStackTrace As DataColumnParameter = New DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pSMSDeliveryStatusID As Int32,
ByVal pSender As String,
ByVal pReceiver As String,
ByVal pMessage As String,
ByVal pCreatedAt As DateTime,
ByVal pGateway As String,
Optional ByVal pUID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPICreateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAPIUpdateResponse As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSMSCostNaira As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionMessage As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pExceptionStackTrace As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramSMSDeliveryStatusID As DataColumnParameter = New DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID)
 Dim paramSender As DataColumnParameter = New DataColumnParameter(defSender, pSender)
 Dim paramReceiver As DataColumnParameter = New DataColumnParameter(defReceiver, pReceiver)
 Dim paramMessage As DataColumnParameter = New DataColumnParameter(defMessage, pMessage)
 Dim paramUID As DataColumnParameter = New DataColumnParameter(defUID, pUID)
 Dim paramAPICreateResponse As DataColumnParameter = New DataColumnParameter(defAPICreateResponse, pAPICreateResponse)
 Dim paramAPIUpdateResponse As DataColumnParameter = New DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse)
 Dim paramSMSCostNaira As DataColumnParameter = New DataColumnParameter(defSMSCostNaira, pSMSCostNaira)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramExceptionStackTrace As DataColumnParameter = New DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([SMSDeliveryStatusID],[Sender],[Receiver],[Message],[UID],[APICreateResponse],[APIUpdateResponse],[SMSCostNaira],[CreatedAt],[UpdatedAt],[ExceptionMessage],[ExceptionStackTrace],[Gateway]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) ", TABLE_NAME,paramSMSDeliveryStatusID.getSQLQuotedValueForAdd(),
paramSender.getSQLQuotedValueForAdd(),
paramReceiver.getSQLQuotedValueForAdd(),
paramMessage.getSQLQuotedValueForAdd(),
paramUID.getSQLQuotedValueForAdd(),
paramAPICreateResponse.getSQLQuotedValueForAdd(),
paramAPIUpdateResponse.getSQLQuotedValueForAdd(),
paramSMSCostNaira.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramExceptionMessage.getSQLQuotedValueForAdd(),
paramExceptionStackTrace.getSQLQuotedValueForAdd(),
paramGateway.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pSMSDeliveryStatusID As Object=Nothing,
Optional ByVal pSender As Object=Nothing,
Optional ByVal pReceiver As Object=Nothing,
Optional ByVal pMessage As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pGateway As Object=Nothing,
Optional ByVal pUID As Object=Nothing,
Optional ByVal pAPICreateResponse As Object=Nothing,
Optional ByVal pAPIUpdateResponse As Object=Nothing,
Optional ByVal pSMSCostNaira As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pExceptionMessage As Object=Nothing,
Optional ByVal pExceptionStackTrace As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramSMSDeliveryStatusID As DataColumnParameter = New DataColumnParameter(defSMSDeliveryStatusID, pSMSDeliveryStatusID)
 Dim paramSender As DataColumnParameter = New DataColumnParameter(defSender, pSender)
 Dim paramReceiver As DataColumnParameter = New DataColumnParameter(defReceiver, pReceiver)
 Dim paramMessage As DataColumnParameter = New DataColumnParameter(defMessage, pMessage)
 Dim paramUID As DataColumnParameter = New DataColumnParameter(defUID, pUID)
 Dim paramAPICreateResponse As DataColumnParameter = New DataColumnParameter(defAPICreateResponse, pAPICreateResponse)
 Dim paramAPIUpdateResponse As DataColumnParameter = New DataColumnParameter(defAPIUpdateResponse, pAPIUpdateResponse)
 Dim paramSMSCostNaira As DataColumnParameter = New DataColumnParameter(defSMSCostNaira, pSMSCostNaira)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramExceptionMessage As DataColumnParameter = New DataColumnParameter(defExceptionMessage, pExceptionMessage)
 Dim paramExceptionStackTrace As DataColumnParameter = New DataColumnParameter(defExceptionStackTrace, pExceptionStackTrace)
 Dim paramGateway As DataColumnParameter = New DataColumnParameter(defGateway, pGateway)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [SMSDeliveryStatusID]={2},[Sender]={3},[Receiver]={4},[Message]={5},[UID]={6},[APICreateResponse]={7},[APIUpdateResponse]={8},[SMSCostNaira]={9},[CreatedAt]={10},[UpdatedAt]={11},[ExceptionMessage]={12},[ExceptionStackTrace]={13},[Gateway]={14} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramSMSDeliveryStatusID.getSQLQuotedValueForUpdate(),
paramSender.getSQLQuotedValueForUpdate(),
paramReceiver.getSQLQuotedValueForUpdate(),
paramMessage.getSQLQuotedValueForUpdate(),
paramUID.getSQLQuotedValueForUpdate(),
paramAPICreateResponse.getSQLQuotedValueForUpdate(),
paramAPIUpdateResponse.getSQLQuotedValueForUpdate(),
paramSMSCostNaira.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramExceptionMessage.getSQLQuotedValueForUpdate(),
paramExceptionStackTrace.getSQLQuotedValueForUpdate(),
paramGateway.getSQLQuotedValueForUpdate()  ), True)


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
