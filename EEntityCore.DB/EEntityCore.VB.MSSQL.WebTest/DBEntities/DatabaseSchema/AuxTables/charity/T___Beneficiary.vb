Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.charity

Public Class T___Beneficiary
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCenterID = New DataColumnDefinition(TableColumnNames.CenterID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defBeneficiaryStatusID = New DataColumnDefinition(TableColumnNames.BeneficiaryStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAddress = New DataColumnDefinition(TableColumnNames.Address.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCity = New DataColumnDefinition(TableColumnNames.City.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defState = New DataColumnDefinition(TableColumnNames.State.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defZipCode = New DataColumnDefinition(TableColumnNames.ZipCode.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSchoolName = New DataColumnDefinition(TableColumnNames.SchoolName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSchoolAddress = New DataColumnDefinition(TableColumnNames.SchoolAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defClassOnEnrollment = New DataColumnDefinition(TableColumnNames.ClassOnEnrollment.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHomePhone = New DataColumnDefinition(TableColumnNames.HomePhone.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAlternatePhone = New DataColumnDefinition(TableColumnNames.AlternatePhone.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGenderID = New DataColumnDefinition(TableColumnNames.GenderID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defDateOfBirth = New DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defVocation = New DataColumnDefinition(TableColumnNames.Vocation.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBirthCertificatePath = New DataColumnDefinition(TableColumnNames.BirthCertificatePath.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPhotoPath = New DataColumnDefinition(TableColumnNames.PhotoPath.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCenterID.ColumnName, defCenterID) 
  ColumnDefns.Add(defBeneficiaryStatusID.ColumnName, defBeneficiaryStatusID) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defAddress.ColumnName, defAddress) 
  ColumnDefns.Add(defCity.ColumnName, defCity) 
  ColumnDefns.Add(defState.ColumnName, defState) 
  ColumnDefns.Add(defZipCode.ColumnName, defZipCode) 
  ColumnDefns.Add(defSchoolName.ColumnName, defSchoolName) 
  ColumnDefns.Add(defSchoolAddress.ColumnName, defSchoolAddress) 
  ColumnDefns.Add(defClassOnEnrollment.ColumnName, defClassOnEnrollment) 
  ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone) 
  ColumnDefns.Add(defAlternatePhone.ColumnName, defAlternatePhone) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defGenderID.ColumnName, defGenderID) 
  ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth) 
  ColumnDefns.Add(defVocation.ColumnName, defVocation) 
  ColumnDefns.Add(defBirthCertificatePath.ColumnName, defBirthCertificatePath) 
  ColumnDefns.Add(defPhotoPath.ColumnName, defPhotoPath) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CenterID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.Beneficiary", "charity.Center"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_GenderID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "common.Gender"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_BeneficiaryStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "charity.BeneficiaryStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_Beneficiary_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.Beneficiary", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "charity.Beneficiary"
       Public Const Beneficiary__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Beneficiary"
       Public Const Beneficiary__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CenterID], [BeneficiaryStatusID], [FirstName], [LastName], [Address], [City], [State], [ZipCode], [SchoolName], [SchoolAddress], [ClassOnEnrollment], [HomePhone], [AlternatePhone], [Email], [GenderID], [DateOfBirth], [Vocation], [BirthCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM Beneficiary"


       Public Enum TableColumnNames

           [ID]
           [CenterID]
           [BeneficiaryStatusID]
           [FirstName]
           [LastName]
           [Address]
           [City]
           [State]
           [ZipCode]
           [SchoolName]
           [SchoolAddress]
           [ClassOnEnrollment]
           [HomePhone]
           [AlternatePhone]
           [Email]
           [GenderID]
           [DateOfBirth]
           [Vocation]
           [BirthCertificatePath]
           [PhotoPath]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_charity_Beneficiary 
           fk_charity_Beneficiary_CenterID 
           fk_charity_Beneficiary_GenderID 
           fk_charity_Beneficiary_BeneficiaryStatusID 
           fk_charity_Beneficiary_CreatedByID 
           fk_charity_Beneficiary_UpdatedByID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCenterID As DataColumnDefinition
       Public Shared ReadOnly defBeneficiaryStatusID As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defAddress As DataColumnDefinition
       Public Shared ReadOnly defCity As DataColumnDefinition
       Public Shared ReadOnly defState As DataColumnDefinition
       Public Shared ReadOnly defZipCode As DataColumnDefinition
       Public Shared ReadOnly defSchoolName As DataColumnDefinition
       Public Shared ReadOnly defSchoolAddress As DataColumnDefinition
       Public Shared ReadOnly defClassOnEnrollment As DataColumnDefinition
       Public Shared ReadOnly defHomePhone As DataColumnDefinition
       Public Shared ReadOnly defAlternatePhone As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defGenderID As DataColumnDefinition
       Public Shared ReadOnly defDateOfBirth As DataColumnDefinition
       Public Shared ReadOnly defVocation As DataColumnDefinition
       Public Shared ReadOnly defBirthCertificatePath As DataColumnDefinition
       Public Shared ReadOnly defPhotoPath As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition

       Public ReadOnly Property [CenterID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CenterID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BeneficiaryStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BeneficiaryStatusID.ToString()))
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


       Public ReadOnly Property [Address] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Address.ToString()))
           End Get
       End Property


       Public ReadOnly Property [City] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.City.ToString()))
           End Get
       End Property


       Public ReadOnly Property [State] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.State.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ZipCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ZipCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SchoolName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.SchoolName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SchoolAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.SchoolAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ClassOnEnrollment] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ClassOnEnrollment.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HomePhone] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HomePhone.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AlternatePhone] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AlternatePhone.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [GenderID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.GenderID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DateOfBirth] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.DateOfBirth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Vocation] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Vocation.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BirthCertificatePath] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BirthCertificatePath.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PhotoPath] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PhotoPath.ToString()))
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


       Public ReadOnly Property [CreatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CreatedByID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [UpdatedByID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.UpdatedByID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Beneficiary                  
            If Me.hasRows() Then Return New T___Beneficiary(Me.AllRows(0))                  
            Return New T___Beneficiary()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Beneficiary                  
            Return New T___Beneficiary(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Beneficiary                  
            Return New T___Beneficiary(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Beneficiary                  
            Return New T___Beneficiary(Me.RawTable, T___Beneficiary.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Beneficiary,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Beneficiary,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Beneficiary                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Beneficiary(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Beneficiary(drst.CopyToDataTable(),                  
                    T___Beneficiary.TABLE_NAME)                  
                Return New T___Beneficiary()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Beneficiary()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Beneficiary                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Beneficiary(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Beneficiary(drst.CopyToDataTable(),                  
                    T___Beneficiary.TABLE_NAME)                  
                Return New T___Beneficiary()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Beneficiary()                  
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
            Return Beneficiary__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCenterID As Int32,
ByVal pBeneficiaryStatusID As Int32,
ByVal pGenderID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramBeneficiaryStatusID As DataColumnParameter = New DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, defFirstName.DefaultValue)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, defLastName.DefaultValue)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, defAddress.DefaultValue)
 Dim paramCity As DataColumnParameter = New DataColumnParameter(defCity, defCity.DefaultValue)
 Dim paramState As DataColumnParameter = New DataColumnParameter(defState, defState.DefaultValue)
 Dim paramZipCode As DataColumnParameter = New DataColumnParameter(defZipCode, defZipCode.DefaultValue)
 Dim paramSchoolName As DataColumnParameter = New DataColumnParameter(defSchoolName, defSchoolName.DefaultValue)
 Dim paramSchoolAddress As DataColumnParameter = New DataColumnParameter(defSchoolAddress, defSchoolAddress.DefaultValue)
 Dim paramClassOnEnrollment As DataColumnParameter = New DataColumnParameter(defClassOnEnrollment, defClassOnEnrollment.DefaultValue)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, defHomePhone.DefaultValue)
 Dim paramAlternatePhone As DataColumnParameter = New DataColumnParameter(defAlternatePhone, defAlternatePhone.DefaultValue)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, defEmail.DefaultValue)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue)
 Dim paramVocation As DataColumnParameter = New DataColumnParameter(defVocation, defVocation.DefaultValue)
 Dim paramBirthCertificatePath As DataColumnParameter = New DataColumnParameter(defBirthCertificatePath, defBirthCertificatePath.DefaultValue)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, defPhotoPath.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramCity.getSQLQuotedValueForAdd(),
paramState.getSQLQuotedValueForAdd(),
paramZipCode.getSQLQuotedValueForAdd(),
paramSchoolName.getSQLQuotedValueForAdd(),
paramSchoolAddress.getSQLQuotedValueForAdd(),
paramClassOnEnrollment.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramAlternatePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramVocation.getSQLQuotedValueForAdd(),
paramBirthCertificatePath.getSQLQuotedValueForAdd(),
paramPhotoPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pCenterID As Int32,
ByVal pBeneficiaryStatusID As Int32,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAddress As String,
ByVal pGenderID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pCity As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pState As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pZipCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pClassOnEnrollment As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAlternatePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVocation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramBeneficiaryStatusID As DataColumnParameter = New DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramCity As DataColumnParameter = New DataColumnParameter(defCity, pCity)
 Dim paramState As DataColumnParameter = New DataColumnParameter(defState, pState)
 Dim paramZipCode As DataColumnParameter = New DataColumnParameter(defZipCode, pZipCode)
 Dim paramSchoolName As DataColumnParameter = New DataColumnParameter(defSchoolName, pSchoolName)
 Dim paramSchoolAddress As DataColumnParameter = New DataColumnParameter(defSchoolAddress, pSchoolAddress)
 Dim paramClassOnEnrollment As DataColumnParameter = New DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramAlternatePhone As DataColumnParameter = New DataColumnParameter(defAlternatePhone, pAlternatePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramVocation As DataColumnParameter = New DataColumnParameter(defVocation, pVocation)
 Dim paramBirthCertificatePath As DataColumnParameter = New DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramCity.getSQLQuotedValueForAdd(),
paramState.getSQLQuotedValueForAdd(),
paramZipCode.getSQLQuotedValueForAdd(),
paramSchoolName.getSQLQuotedValueForAdd(),
paramSchoolAddress.getSQLQuotedValueForAdd(),
paramClassOnEnrollment.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramAlternatePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramVocation.getSQLQuotedValueForAdd(),
paramBirthCertificatePath.getSQLQuotedValueForAdd(),
paramPhotoPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pCenterID As Int32,
ByVal pBeneficiaryStatusID As Int32,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAddress As String,
ByVal pGenderID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pCity As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pState As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pZipCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pClassOnEnrollment As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAlternatePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVocation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramBeneficiaryStatusID As DataColumnParameter = New DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramCity As DataColumnParameter = New DataColumnParameter(defCity, pCity)
 Dim paramState As DataColumnParameter = New DataColumnParameter(defState, pState)
 Dim paramZipCode As DataColumnParameter = New DataColumnParameter(defZipCode, pZipCode)
 Dim paramSchoolName As DataColumnParameter = New DataColumnParameter(defSchoolName, pSchoolName)
 Dim paramSchoolAddress As DataColumnParameter = New DataColumnParameter(defSchoolAddress, pSchoolAddress)
 Dim paramClassOnEnrollment As DataColumnParameter = New DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramAlternatePhone As DataColumnParameter = New DataColumnParameter(defAlternatePhone, pAlternatePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramVocation As DataColumnParameter = New DataColumnParameter(defVocation, pVocation)
 Dim paramBirthCertificatePath As DataColumnParameter = New DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramCity.getSQLQuotedValueForAdd(),
paramState.getSQLQuotedValueForAdd(),
paramZipCode.getSQLQuotedValueForAdd(),
paramSchoolName.getSQLQuotedValueForAdd(),
paramSchoolAddress.getSQLQuotedValueForAdd(),
paramClassOnEnrollment.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramAlternatePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramVocation.getSQLQuotedValueForAdd(),
paramBirthCertificatePath.getSQLQuotedValueForAdd(),
paramPhotoPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pCenterID As Int32,
ByVal pBeneficiaryStatusID As Int32,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pAddress As String,
ByVal pGenderID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pCity As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pState As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pZipCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSchoolAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pClassOnEnrollment As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAlternatePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pVocation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramBeneficiaryStatusID As DataColumnParameter = New DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramCity As DataColumnParameter = New DataColumnParameter(defCity, pCity)
 Dim paramState As DataColumnParameter = New DataColumnParameter(defState, pState)
 Dim paramZipCode As DataColumnParameter = New DataColumnParameter(defZipCode, pZipCode)
 Dim paramSchoolName As DataColumnParameter = New DataColumnParameter(defSchoolName, pSchoolName)
 Dim paramSchoolAddress As DataColumnParameter = New DataColumnParameter(defSchoolAddress, pSchoolAddress)
 Dim paramClassOnEnrollment As DataColumnParameter = New DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramAlternatePhone As DataColumnParameter = New DataColumnParameter(defAlternatePhone, pAlternatePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramVocation As DataColumnParameter = New DataColumnParameter(defVocation, pVocation)
 Dim paramBirthCertificatePath As DataColumnParameter = New DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([CenterID],[BeneficiaryStatusID],[FirstName],[LastName],[Address],[City],[State],[ZipCode],[SchoolName],[SchoolAddress],[ClassOnEnrollment],[HomePhone],[AlternatePhone],[Email],[GenderID],[DateOfBirth],[Vocation],[BirthCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23}) ", TABLE_NAME,paramCenterID.getSQLQuotedValueForAdd(),
paramBeneficiaryStatusID.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramCity.getSQLQuotedValueForAdd(),
paramState.getSQLQuotedValueForAdd(),
paramZipCode.getSQLQuotedValueForAdd(),
paramSchoolName.getSQLQuotedValueForAdd(),
paramSchoolAddress.getSQLQuotedValueForAdd(),
paramClassOnEnrollment.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramAlternatePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramVocation.getSQLQuotedValueForAdd(),
paramBirthCertificatePath.getSQLQuotedValueForAdd(),
paramPhotoPath.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramCreatedByID.getSQLQuotedValueForAdd(),
paramUpdatedByID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pCenterID As Object=Nothing,
Optional ByVal pBeneficiaryStatusID As Object=Nothing,
Optional ByVal pFirstName As Object=Nothing,
Optional ByVal pLastName As Object=Nothing,
Optional ByVal pAddress As Object=Nothing,
Optional ByVal pGenderID As Object=Nothing,
Optional ByVal pDateOfBirth As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pCity As Object=Nothing,
Optional ByVal pState As Object=Nothing,
Optional ByVal pZipCode As Object=Nothing,
Optional ByVal pSchoolName As Object=Nothing,
Optional ByVal pSchoolAddress As Object=Nothing,
Optional ByVal pClassOnEnrollment As Object=Nothing,
Optional ByVal pHomePhone As Object=Nothing,
Optional ByVal pAlternatePhone As Object=Nothing,
Optional ByVal pEmail As Object=Nothing,
Optional ByVal pVocation As Object=Nothing,
Optional ByVal pBirthCertificatePath As Object=Nothing,
Optional ByVal pPhotoPath As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramBeneficiaryStatusID As DataColumnParameter = New DataColumnParameter(defBeneficiaryStatusID, pBeneficiaryStatusID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramCity As DataColumnParameter = New DataColumnParameter(defCity, pCity)
 Dim paramState As DataColumnParameter = New DataColumnParameter(defState, pState)
 Dim paramZipCode As DataColumnParameter = New DataColumnParameter(defZipCode, pZipCode)
 Dim paramSchoolName As DataColumnParameter = New DataColumnParameter(defSchoolName, pSchoolName)
 Dim paramSchoolAddress As DataColumnParameter = New DataColumnParameter(defSchoolAddress, pSchoolAddress)
 Dim paramClassOnEnrollment As DataColumnParameter = New DataColumnParameter(defClassOnEnrollment, pClassOnEnrollment)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramAlternatePhone As DataColumnParameter = New DataColumnParameter(defAlternatePhone, pAlternatePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramVocation As DataColumnParameter = New DataColumnParameter(defVocation, pVocation)
 Dim paramBirthCertificatePath As DataColumnParameter = New DataColumnParameter(defBirthCertificatePath, pBirthCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [CenterID]={2},[BeneficiaryStatusID]={3},[FirstName]={4},[LastName]={5},[Address]={6},[City]={7},[State]={8},[ZipCode]={9},[SchoolName]={10},[SchoolAddress]={11},[ClassOnEnrollment]={12},[HomePhone]={13},[AlternatePhone]={14},[Email]={15},[GenderID]={16},[DateOfBirth]={17},[Vocation]={18},[BirthCertificatePath]={19},[PhotoPath]={20},[CreatedAt]={21},[UpdatedAt]={22},[CreatedByID]={23},[UpdatedByID]={24} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCenterID.getSQLQuotedValueForUpdate(),
paramBeneficiaryStatusID.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramAddress.getSQLQuotedValueForUpdate(),
paramCity.getSQLQuotedValueForUpdate(),
paramState.getSQLQuotedValueForUpdate(),
paramZipCode.getSQLQuotedValueForUpdate(),
paramSchoolName.getSQLQuotedValueForUpdate(),
paramSchoolAddress.getSQLQuotedValueForUpdate(),
paramClassOnEnrollment.getSQLQuotedValueForUpdate(),
paramHomePhone.getSQLQuotedValueForUpdate(),
paramAlternatePhone.getSQLQuotedValueForUpdate(),
paramEmail.getSQLQuotedValueForUpdate(),
paramGenderID.getSQLQuotedValueForUpdate(),
paramDateOfBirth.getSQLQuotedValueForUpdate(),
paramVocation.getSQLQuotedValueForUpdate(),
paramBirthCertificatePath.getSQLQuotedValueForUpdate(),
paramPhotoPath.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramCreatedByID.getSQLQuotedValueForUpdate(),
paramUpdatedByID.getSQLQuotedValueForUpdate()  ), True)


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
