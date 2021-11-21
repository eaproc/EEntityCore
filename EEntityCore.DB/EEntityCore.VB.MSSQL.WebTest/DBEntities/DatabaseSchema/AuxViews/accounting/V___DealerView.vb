Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxViews.accounting

Public Class V___DealerView
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPersonID = New DataColumnDefinition(TableColumnNames.PersonID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsActive = New DataColumnDefinition(TableColumnNames.IsActive.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDealerCode = New DataColumnDefinition(TableColumnNames.DealerCode.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCompanyName = New DataColumnDefinition(TableColumnNames.CompanyName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defWebsiteUrl = New DataColumnDefinition(TableColumnNames.WebsiteUrl.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defOfficeAddress = New DataColumnDefinition(TableColumnNames.OfficeAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCountryID = New DataColumnDefinition(TableColumnNames.CountryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFullName = New DataColumnDefinition(TableColumnNames.FullName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPictureFileName = New DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHomeAddress = New DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBankName = New DataColumnDefinition(TableColumnNames.BankName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRegisteredEmail = New DataColumnDefinition(TableColumnNames.RegisteredEmail.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRegisteredMobile = New DataColumnDefinition(TableColumnNames.RegisteredMobile.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMobileNumber = New DataColumnDefinition(TableColumnNames.MobileNumber.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUsername = New DataColumnDefinition(TableColumnNames.Username.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUserID = New DataColumnDefinition(TableColumnNames.UserID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defPersonID.ColumnName, defPersonID) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
  ColumnDefns.Add(defIsActive.ColumnName, defIsActive) 
  ColumnDefns.Add(defDealerCode.ColumnName, defDealerCode) 
  ColumnDefns.Add(defCompanyName.ColumnName, defCompanyName) 
  ColumnDefns.Add(defWebsiteUrl.ColumnName, defWebsiteUrl) 
  ColumnDefns.Add(defOfficeAddress.ColumnName, defOfficeAddress) 
  ColumnDefns.Add(defCountryID.ColumnName, defCountryID) 
  ColumnDefns.Add(defFullName.ColumnName, defFullName) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName) 
  ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress) 
  ColumnDefns.Add(defBankName.ColumnName, defBankName) 
  ColumnDefns.Add(defRegisteredEmail.ColumnName, defRegisteredEmail) 
  ColumnDefns.Add(defRegisteredMobile.ColumnName, defRegisteredMobile) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defMobileNumber.ColumnName, defMobileNumber) 
  ColumnDefns.Add(defUsername.ColumnName, defUsername) 
  ColumnDefns.Add(defUserID.ColumnName, defUserID) 
            ReferencedTableNames = New List(Of String)()                  
            ReferencedTableNames.Add("accounting.Dealer")                  
            ReferencedTableNames.Add("auth.UserVerifiedContact")                  
            ReferencedTableNames.Add("common.Bank")                  
            ReferencedTableNames.Add("common.PersonView")                  

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

       Public Const TABLE_NAME As String = "accounting.DealerView"
       Public Const DealerView__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [FullName], [FirstName], [LastName], [PictureFileName], [HomeAddress], [BankName], [RegisteredEmail], [RegisteredMobile], [Email], [MobileNumber], [Username], [UserID] FROM DealerView"
       Public Const DealerView__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [PersonID], [BankID], [AccountNumber], [IsActive], [DealerCode], [CompanyName], [WebsiteUrl], [OfficeAddress], [CountryID], [FullName], [FirstName], [LastName], [PictureFileName], [HomeAddress], [BankName], [RegisteredEmail], [RegisteredMobile], [Email], [MobileNumber], [Username], [UserID] FROM DealerView"


       Public Enum TableColumnNames

           [ID]
           [PersonID]
           [BankID]
           [AccountNumber]
           [IsActive]
           [DealerCode]
           [CompanyName]
           [WebsiteUrl]
           [OfficeAddress]
           [CountryID]
           [FullName]
           [FirstName]
           [LastName]
           [PictureFileName]
           [HomeAddress]
           [BankName]
           [RegisteredEmail]
           [RegisteredMobile]
           [Email]
           [MobileNumber]
           [Username]
           [UserID]
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ReferencedTableNames As List(Of String)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defPersonID As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition
       Public Shared ReadOnly defIsActive As DataColumnDefinition
       Public Shared ReadOnly defDealerCode As DataColumnDefinition
       Public Shared ReadOnly defCompanyName As DataColumnDefinition
       Public Shared ReadOnly defWebsiteUrl As DataColumnDefinition
       Public Shared ReadOnly defOfficeAddress As DataColumnDefinition
       Public Shared ReadOnly defCountryID As DataColumnDefinition
       Public Shared ReadOnly defFullName As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defPictureFileName As DataColumnDefinition
       Public Shared ReadOnly defHomeAddress As DataColumnDefinition
       Public Shared ReadOnly defBankName As DataColumnDefinition
       Public Shared ReadOnly defRegisteredEmail As DataColumnDefinition
       Public Shared ReadOnly defRegisteredMobile As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defMobileNumber As DataColumnDefinition
       Public Shared ReadOnly defUsername As DataColumnDefinition
       Public Shared ReadOnly defUserID As DataColumnDefinition

       Public ReadOnly Property [PersonID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PersonID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BankID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BankID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AccountNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AccountNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsActive] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsActive.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DealerCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DealerCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CompanyName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CompanyName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [WebsiteUrl] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.WebsiteUrl.ToString()))
           End Get
       End Property


       Public ReadOnly Property [OfficeAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.OfficeAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CountryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CountryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FullName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FullName.ToString()))
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


       Public ReadOnly Property [PictureFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PictureFileName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HomeAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HomeAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BankName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BankName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RegisteredEmail] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.RegisteredEmail.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RegisteredMobile] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.RegisteredMobile.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MobileNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.MobileNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Username] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Username.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UserID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UserID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As V___DealerView                  
            If Me.hasRows() Then Return New V___DealerView(Me.AllRows(0))                  
            Return New V___DealerView()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As V___DealerView                  
            Return New V___DealerView(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As V___DealerView                  
            Return New V___DealerView(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As V___DealerView                  
            Return New V___DealerView(Me.RawTable, V___DealerView.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As V___DealerView,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As V___DealerView,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As V___DealerView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New V___DealerView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___DealerView(drst.CopyToDataTable(),                  
                    V___DealerView.TABLE_NAME)                  
                Return New V___DealerView()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New V___DealerView()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As V___DealerView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New V___DealerView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___DealerView(drst.CopyToDataTable(),                  
                    V___DealerView.TABLE_NAME)                  
                Return New V___DealerView()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New V___DealerView()                  
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
                  
                  

                  
        Public Function getReferencedTableNames() As List(Of String) Implements IDBViewDefinitionPlugIn.getReferencedTableNames                  
            Return ReferencedTableNames                  
        End Function                  
                  
        Public Function getViewName() As String Implements IDBViewDefinitionPlugIn.getViewName                  
            Return TABLE_NAME                  
        End Function                  

                  
                  
#End Region                  
                  
                  



End Class


End Namespace
