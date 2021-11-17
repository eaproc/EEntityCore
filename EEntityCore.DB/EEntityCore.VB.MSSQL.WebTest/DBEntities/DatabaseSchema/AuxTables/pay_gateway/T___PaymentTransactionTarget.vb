Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.pay_gateway

Public Class T___PaymentTransactionTarget
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defPaymentTransactionID = New DataColumnDefinition(TableColumnNames.PaymentTransactionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defStudentNumber = New DataColumnDefinition(TableColumnNames.StudentNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPaymentRequiredWithoutCharges = New DataColumnDefinition(TableColumnNames.PaymentRequiredWithoutCharges.ToString(), GetType(Decimal), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPaymentTransactionID.ColumnName, defPaymentTransactionID) 
  ColumnDefns.Add(defStudentNumber.ColumnName, defStudentNumber) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defPaymentRequiredWithoutCharges.ColumnName, defPaymentRequiredWithoutCharges) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_PaymentTransactionTarget_PaymentTransactionID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "pay_gateway.PaymentTransactionTarget", "pay_gateway.PaymentTransaction"                  
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

       Public Const TABLE_NAME As String = "pay_gateway.PaymentTransactionTarget"
       Public Const PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM PaymentTransactionTarget"
       Public Const PaymentTransactionTarget__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PaymentTransactionID], [StudentNumber], [FirstName], [LastName], [PaymentRequiredWithoutCharges] FROM PaymentTransactionTarget"


       Public Enum TableColumnNames

           [ID]
           [PaymentTransactionID]
           [StudentNumber]
           [FirstName]
           [LastName]
           [PaymentRequiredWithoutCharges]
       End Enum 



       Public Enum TableConstraints

           pk_pay_gateway_PaymentTransactionTarget 
           fk_PaymentTransactionTarget_PaymentTransactionID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPaymentTransactionID As DataColumnDefinition
       Public Shared ReadOnly defStudentNumber As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defPaymentRequiredWithoutCharges As DataColumnDefinition

       Public ReadOnly Property [PaymentTransactionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PaymentTransactionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [StudentNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.StudentNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FirstName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FirstName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LastName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.LastName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PaymentRequiredWithoutCharges] As Decimal
           Get
               If Not Me.isValidRow then Return 0                          
               Return CDec( EDouble.valueOf(Me.TargettedRow(TableColumnNames.PaymentRequiredWithoutCharges.ToString())) )
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___PaymentTransactionTarget                  
            If Me.hasRows() Then Return New T___PaymentTransactionTarget(Me.AllRows(0))                  
            Return New T___PaymentTransactionTarget()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___PaymentTransactionTarget                  
            Return New T___PaymentTransactionTarget(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___PaymentTransactionTarget                  
            Return New T___PaymentTransactionTarget(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___PaymentTransactionTarget                  
            Return New T___PaymentTransactionTarget(Me.RawTable, T___PaymentTransactionTarget.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___PaymentTransactionTarget,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___PaymentTransactionTarget,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___PaymentTransactionTarget                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___PaymentTransactionTarget(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaymentTransactionTarget(drst.CopyToDataTable(),                  
                    T___PaymentTransactionTarget.TABLE_NAME)                  
                Return New T___PaymentTransactionTarget()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___PaymentTransactionTarget()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___PaymentTransactionTarget                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___PaymentTransactionTarget(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___PaymentTransactionTarget(drst.CopyToDataTable(),                  
                    T___PaymentTransactionTarget.TABLE_NAME)                  
                Return New T___PaymentTransactionTarget()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___PaymentTransactionTarget()                  
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
            Return PaymentTransactionTarget__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pPaymentTransactionID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, defStudentNumber.DefaultValue)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, defFirstName.DefaultValue)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, defLastName.DefaultValue)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, defPaymentRequiredWithoutCharges.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pPaymentTransactionID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pPaymentRequiredWithoutCharges As Decimal) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pPaymentTransactionID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pPaymentRequiredWithoutCharges As Decimal) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5},{6}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pPaymentTransactionID As Int32,
ByVal pStudentNumber As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pPaymentRequiredWithoutCharges As Decimal) As Boolean

Try

 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([PaymentTransactionID],[StudentNumber],[FirstName],[LastName],[PaymentRequiredWithoutCharges]) VALUES({1},{2},{3},{4},{5}) ", TABLE_NAME,paramPaymentTransactionID.getSQLQuotedValueForAdd(),
paramStudentNumber.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pPaymentTransactionID As Object=Nothing,
Optional ByVal pStudentNumber As Object=Nothing,
Optional ByVal pFirstName As Object=Nothing,
Optional ByVal pLastName As Object=Nothing,
Optional ByVal pPaymentRequiredWithoutCharges As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramPaymentTransactionID As DataColumnParameter = New DataColumnParameter(defPaymentTransactionID, pPaymentTransactionID)
 Dim paramStudentNumber As DataColumnParameter = New DataColumnParameter(defStudentNumber, pStudentNumber)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramPaymentRequiredWithoutCharges As DataColumnParameter = New DataColumnParameter(defPaymentRequiredWithoutCharges, pPaymentRequiredWithoutCharges)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [PaymentTransactionID]={2},[StudentNumber]={3},[FirstName]={4},[LastName]={5},[PaymentRequiredWithoutCharges]={6} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramPaymentTransactionID.getSQLQuotedValueForUpdate(),
paramStudentNumber.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramPaymentRequiredWithoutCharges.getSQLQuotedValueForUpdate()  ), True)


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
