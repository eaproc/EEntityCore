Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.hr

Public Class T___Client
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCompanyName = New DataColumnDefinition(TableColumnNames.CompanyName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defOwnerID = New DataColumnDefinition(TableColumnNames.OwnerID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defSLAFileName = New DataColumnDefinition(TableColumnNames.SLAFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defScadwareURL = New DataColumnDefinition(TableColumnNames.ScadwareURL.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMobile = New DataColumnDefinition(TableColumnNames.Mobile.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defWebsiteURL = New DataColumnDefinition(TableColumnNames.WebsiteURL.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLogoFileName = New DataColumnDefinition(TableColumnNames.LogoFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsActive = New DataColumnDefinition(TableColumnNames.IsActive.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defNameAbbreviation = New DataColumnDefinition(TableColumnNames.NameAbbreviation.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAddress = New DataColumnDefinition(TableColumnNames.Address.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAccountName = New DataColumnDefinition(TableColumnNames.AccountName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defOwnerID.ColumnName, defOwnerID) 
  ColumnDefns.Add(defSLAFileName.ColumnName, defSLAFileName) 
  ColumnDefns.Add(defScadwareURL.ColumnName, defScadwareURL) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defMobile.ColumnName, defMobile) 
  ColumnDefns.Add(defWebsiteURL.ColumnName, defWebsiteURL) 
  ColumnDefns.Add(defLogoFileName.ColumnName, defLogoFileName) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defIsActive.ColumnName, defIsActive) 
  ColumnDefns.Add(defNameAbbreviation.ColumnName, defNameAbbreviation) 
  ColumnDefns.Add(defAddress.ColumnName, defAddress) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defAccountName.ColumnName, defAccountName) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_BankID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Bank"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_hr_Client_OwnerID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "hr.Client", "common.Person"                  
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

       Public Const TABLE_NAME As String = "hr.Client"
       Public Const Client__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM Client"
       Public Const Client__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CompanyName], [CreatedAt], [OwnerID], [SLAFileName], [ScadwareURL], [Email], [Mobile], [WebsiteURL], [LogoFileName], [UpdatedAt], [IsActive], [NameAbbreviation], [Address], [BankID], [AccountName], [AccountNumber] FROM Client"


       Public Enum TableColumnNames

           [ID]
           [CompanyName]
           [CreatedAt]
           [OwnerID]
           [SLAFileName]
           [ScadwareURL]
           [Email]
           [Mobile]
           [WebsiteURL]
           [LogoFileName]
           [UpdatedAt]
           [IsActive]
           [NameAbbreviation]
           [Address]
           [BankID]
           [AccountName]
           [AccountNumber]
       End Enum 



       Public Enum TableConstraints

           pk_hr_Client 
           fk_hr_Client_BankID 
           fk_hr_Client_OwnerID 
           uq_hr_Client_CompanyName 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCompanyName As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defOwnerID As DataColumnDefinition
       Public Shared ReadOnly defSLAFileName As DataColumnDefinition
       Public Shared ReadOnly defScadwareURL As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defMobile As DataColumnDefinition
       Public Shared ReadOnly defWebsiteURL As DataColumnDefinition
       Public Shared ReadOnly defLogoFileName As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defIsActive As DataColumnDefinition
       Public Shared ReadOnly defNameAbbreviation As DataColumnDefinition
       Public Shared ReadOnly defAddress As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defAccountName As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition

       Public ReadOnly Property [CompanyName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CompanyName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CreatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.CreatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [OwnerID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.OwnerID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SLAFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.SLAFileName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ScadwareURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ScadwareURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Mobile] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Mobile.ToString()))
           End Get
       End Property


       Public ReadOnly Property [WebsiteURL] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.WebsiteURL.ToString()))
           End Get
       End Property


       Public ReadOnly Property [LogoFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.LogoFileName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UpdatedAt] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.UpdatedAt.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsActive] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsActive.ToString()))
           End Get
       End Property


       Public ReadOnly Property [NameAbbreviation] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.NameAbbreviation.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Address] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Address.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BankID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BankID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountNumber.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Client                  
            If Me.hasRows() Then Return New T___Client(Me.AllRows(0))                  
            Return New T___Client()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Client                  
            Return New T___Client(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Client                  
            Return New T___Client(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Client                  
            Return New T___Client(Me.RawTable, T___Client.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Client,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Client,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Client                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Client(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Client(drst.CopyToDataTable(),                  
                    T___Client.TABLE_NAME)                  
                Return New T___Client()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Client()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Client                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Client(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Client(drst.CopyToDataTable(),                  
                    T___Client.TABLE_NAME)                  
                Return New T___Client()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Client()                  
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
            Return Client__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCompanyName As String,
ByVal pOwnerID As Int32,
ByVal pBankID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCompanyName As DataColumnParameter = New DataColumnParameter(defCompanyName, pCompanyName)
 Dim paramOwnerID As DataColumnParameter = New DataColumnParameter(defOwnerID, pOwnerID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramSLAFileName As DataColumnParameter = New DataColumnParameter(defSLAFileName, defSLAFileName.DefaultValue)
 Dim paramScadwareURL As DataColumnParameter = New DataColumnParameter(defScadwareURL, defScadwareURL.DefaultValue)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, defEmail.DefaultValue)
 Dim paramMobile As DataColumnParameter = New DataColumnParameter(defMobile, defMobile.DefaultValue)
 Dim paramWebsiteURL As DataColumnParameter = New DataColumnParameter(defWebsiteURL, defWebsiteURL.DefaultValue)
 Dim paramLogoFileName As DataColumnParameter = New DataColumnParameter(defLogoFileName, defLogoFileName.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, defIsActive.DefaultValue)
 Dim paramNameAbbreviation As DataColumnParameter = New DataColumnParameter(defNameAbbreviation, defNameAbbreviation.DefaultValue)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, defAddress.DefaultValue)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, defAccountName.DefaultValue)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCompanyName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramOwnerID.getSQLQuotedValueForAdd(),
paramSLAFileName.getSQLQuotedValueForAdd(),
paramScadwareURL.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramMobile.getSQLQuotedValueForAdd(),
paramWebsiteURL.getSQLQuotedValueForAdd(),
paramLogoFileName.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramNameAbbreviation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pCompanyName As String,
ByVal pCreatedAt As DateTime,
ByVal pOwnerID As Int32,
ByVal pIsActive As Boolean,
ByVal pNameAbbreviation As String,
Optional ByVal pSLAFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pScadwareURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobile As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pWebsiteURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLogoFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBankID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCompanyName As DataColumnParameter = New DataColumnParameter(defCompanyName, pCompanyName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramOwnerID As DataColumnParameter = New DataColumnParameter(defOwnerID, pOwnerID)
 Dim paramSLAFileName As DataColumnParameter = New DataColumnParameter(defSLAFileName, pSLAFileName)
 Dim paramScadwareURL As DataColumnParameter = New DataColumnParameter(defScadwareURL, pScadwareURL)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramMobile As DataColumnParameter = New DataColumnParameter(defMobile, pMobile)
 Dim paramWebsiteURL As DataColumnParameter = New DataColumnParameter(defWebsiteURL, pWebsiteURL)
 Dim paramLogoFileName As DataColumnParameter = New DataColumnParameter(defLogoFileName, pLogoFileName)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramNameAbbreviation As DataColumnParameter = New DataColumnParameter(defNameAbbreviation, pNameAbbreviation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCompanyName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramOwnerID.getSQLQuotedValueForAdd(),
paramSLAFileName.getSQLQuotedValueForAdd(),
paramScadwareURL.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramMobile.getSQLQuotedValueForAdd(),
paramWebsiteURL.getSQLQuotedValueForAdd(),
paramLogoFileName.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramNameAbbreviation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pCompanyName As String,
ByVal pCreatedAt As DateTime,
ByVal pOwnerID As Int32,
ByVal pIsActive As Boolean,
ByVal pNameAbbreviation As String,
Optional ByVal pSLAFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pScadwareURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobile As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pWebsiteURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLogoFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBankID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCompanyName As DataColumnParameter = New DataColumnParameter(defCompanyName, pCompanyName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramOwnerID As DataColumnParameter = New DataColumnParameter(defOwnerID, pOwnerID)
 Dim paramSLAFileName As DataColumnParameter = New DataColumnParameter(defSLAFileName, pSLAFileName)
 Dim paramScadwareURL As DataColumnParameter = New DataColumnParameter(defScadwareURL, pScadwareURL)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramMobile As DataColumnParameter = New DataColumnParameter(defMobile, pMobile)
 Dim paramWebsiteURL As DataColumnParameter = New DataColumnParameter(defWebsiteURL, pWebsiteURL)
 Dim paramLogoFileName As DataColumnParameter = New DataColumnParameter(defLogoFileName, pLogoFileName)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramNameAbbreviation As DataColumnParameter = New DataColumnParameter(defNameAbbreviation, pNameAbbreviation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCompanyName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramOwnerID.getSQLQuotedValueForAdd(),
paramSLAFileName.getSQLQuotedValueForAdd(),
paramScadwareURL.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramMobile.getSQLQuotedValueForAdd(),
paramWebsiteURL.getSQLQuotedValueForAdd(),
paramLogoFileName.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramNameAbbreviation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pCompanyName As String,
ByVal pCreatedAt As DateTime,
ByVal pOwnerID As Int32,
ByVal pIsActive As Boolean,
ByVal pNameAbbreviation As String,
Optional ByVal pSLAFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pScadwareURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobile As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pWebsiteURL As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pLogoFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBankID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAccountNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramCompanyName As DataColumnParameter = New DataColumnParameter(defCompanyName, pCompanyName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramOwnerID As DataColumnParameter = New DataColumnParameter(defOwnerID, pOwnerID)
 Dim paramSLAFileName As DataColumnParameter = New DataColumnParameter(defSLAFileName, pSLAFileName)
 Dim paramScadwareURL As DataColumnParameter = New DataColumnParameter(defScadwareURL, pScadwareURL)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramMobile As DataColumnParameter = New DataColumnParameter(defMobile, pMobile)
 Dim paramWebsiteURL As DataColumnParameter = New DataColumnParameter(defWebsiteURL, pWebsiteURL)
 Dim paramLogoFileName As DataColumnParameter = New DataColumnParameter(defLogoFileName, pLogoFileName)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramNameAbbreviation As DataColumnParameter = New DataColumnParameter(defNameAbbreviation, pNameAbbreviation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([CompanyName],[CreatedAt],[OwnerID],[SLAFileName],[ScadwareURL],[Email],[Mobile],[WebsiteURL],[LogoFileName],[UpdatedAt],[IsActive],[NameAbbreviation],[Address],[BankID],[AccountName],[AccountNumber]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramCompanyName.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramOwnerID.getSQLQuotedValueForAdd(),
paramSLAFileName.getSQLQuotedValueForAdd(),
paramScadwareURL.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramMobile.getSQLQuotedValueForAdd(),
paramWebsiteURL.getSQLQuotedValueForAdd(),
paramLogoFileName.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramIsActive.getSQLQuotedValueForAdd(),
paramNameAbbreviation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountName.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pCompanyName As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pOwnerID As Object=Nothing,
Optional ByVal pIsActive As Object=Nothing,
Optional ByVal pNameAbbreviation As Object=Nothing,
Optional ByVal pSLAFileName As Object=Nothing,
Optional ByVal pScadwareURL As Object=Nothing,
Optional ByVal pEmail As Object=Nothing,
Optional ByVal pMobile As Object=Nothing,
Optional ByVal pWebsiteURL As Object=Nothing,
Optional ByVal pLogoFileName As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pAddress As Object=Nothing,
Optional ByVal pBankID As Object=Nothing,
Optional ByVal pAccountName As Object=Nothing,
Optional ByVal pAccountNumber As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCompanyName As DataColumnParameter = New DataColumnParameter(defCompanyName, pCompanyName)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramOwnerID As DataColumnParameter = New DataColumnParameter(defOwnerID, pOwnerID)
 Dim paramSLAFileName As DataColumnParameter = New DataColumnParameter(defSLAFileName, pSLAFileName)
 Dim paramScadwareURL As DataColumnParameter = New DataColumnParameter(defScadwareURL, pScadwareURL)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramMobile As DataColumnParameter = New DataColumnParameter(defMobile, pMobile)
 Dim paramWebsiteURL As DataColumnParameter = New DataColumnParameter(defWebsiteURL, pWebsiteURL)
 Dim paramLogoFileName As DataColumnParameter = New DataColumnParameter(defLogoFileName, pLogoFileName)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramIsActive As DataColumnParameter = New DataColumnParameter(defIsActive, pIsActive)
 Dim paramNameAbbreviation As DataColumnParameter = New DataColumnParameter(defNameAbbreviation, pNameAbbreviation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountName As DataColumnParameter = New DataColumnParameter(defAccountName, pAccountName)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [CompanyName]={2},[CreatedAt]={3},[OwnerID]={4},[SLAFileName]={5},[ScadwareURL]={6},[Email]={7},[Mobile]={8},[WebsiteURL]={9},[LogoFileName]={10},[UpdatedAt]={11},[IsActive]={12},[NameAbbreviation]={13},[Address]={14},[BankID]={15},[AccountName]={16},[AccountNumber]={17} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCompanyName.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramOwnerID.getSQLQuotedValueForUpdate(),
paramSLAFileName.getSQLQuotedValueForUpdate(),
paramScadwareURL.getSQLQuotedValueForUpdate(),
paramEmail.getSQLQuotedValueForUpdate(),
paramMobile.getSQLQuotedValueForUpdate(),
paramWebsiteURL.getSQLQuotedValueForUpdate(),
paramLogoFileName.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramIsActive.getSQLQuotedValueForUpdate(),
paramNameAbbreviation.getSQLQuotedValueForUpdate(),
paramAddress.getSQLQuotedValueForUpdate(),
paramBankID.getSQLQuotedValueForUpdate(),
paramAccountName.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate()  ), True)


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
