Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.common

Public Class T___Person
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defIdentificationNo = New DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCountryID = New DataColumnDefinition(TableColumnNames.CountryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defDateOfBirth = New DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGenderID = New DataColumnDefinition(TableColumnNames.GenderID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defHomeAddress = New DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defPersonTitleID = New DataColumnDefinition(TableColumnNames.PersonTitleID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIsSuperUser = New DataColumnDefinition(TableColumnNames.IsSuperUser.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBloodTypeID = New DataColumnDefinition(TableColumnNames.BloodTypeID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defBirthPlace = New DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPictureFileName = New DataColumnDefinition(TableColumnNames.PictureFileName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMaritalStatusID = New DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defCanBeUpdated = New DataColumnDefinition(TableColumnNames.CanBeUpdated.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCanBeDeleted = New DataColumnDefinition(TableColumnNames.CanBeDeleted.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDataMonitorID = New DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defCountryID.ColumnName, defCountryID) 
  ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth) 
  ColumnDefns.Add(defGenderID.ColumnName, defGenderID) 
  ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defPersonTitleID.ColumnName, defPersonTitleID) 
  ColumnDefns.Add(defIsSuperUser.ColumnName, defIsSuperUser) 
  ColumnDefns.Add(defBloodTypeID.ColumnName, defBloodTypeID) 
  ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace) 
  ColumnDefns.Add(defPictureFileName.ColumnName, defPictureFileName) 
  ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID) 
  ColumnDefns.Add(defCanBeUpdated.ColumnName, defCanBeUpdated) 
  ColumnDefns.Add(defCanBeDeleted.ColumnName, defCanBeDeleted) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_DataMonitorID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "import.DataMonitor"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_CountryID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Country"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_GenderID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.Gender"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_PersonTitleID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.PersonTitle"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_BloodTypeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.BloodType"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_common_Person_MaritalStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "common.Person", "common.MaritalStatus"                  
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

       Public Const TABLE_NAME As String = "common.Person"
       Public Const Person__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM Person"
       Public Const Person__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [IdentificationNo], [FirstName], [LastName], [CountryID], [DateOfBirth], [GenderID], [HomeAddress], [Email], [PersonTitleID], [IsSuperUser], [BloodTypeID], [BirthPlace], [PictureFileName], [MaritalStatusID], [CanBeUpdated], [CanBeDeleted], [CreatedAt], [UpdatedAt], [DataMonitorID] FROM Person"


       Public Enum TableColumnNames

           [ID]
           [IdentificationNo]
           [FirstName]
           [LastName]
           [CountryID]
           [DateOfBirth]
           [GenderID]
           [HomeAddress]
           [Email]
           [PersonTitleID]
           [IsSuperUser]
           [BloodTypeID]
           [BirthPlace]
           [PictureFileName]
           [MaritalStatusID]
           [CanBeUpdated]
           [CanBeDeleted]
           [CreatedAt]
           [UpdatedAt]
           [DataMonitorID]
       End Enum 



       Public Enum TableConstraints

           pk_common_Person 
           fk_common_Person_DataMonitorID 
           fk_common_Person_CountryID 
           fk_common_Person_GenderID 
           fk_common_Person_PersonTitleID 
           fk_common_Person_BloodTypeID 
           fk_common_Person_MaritalStatusID 
           uq_common_Person_IdentificationNo 
           uq_common_Person_Email 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defIdentificationNo As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defCountryID As DataColumnDefinition
       Public Shared ReadOnly defDateOfBirth As DataColumnDefinition
       Public Shared ReadOnly defGenderID As DataColumnDefinition
       Public Shared ReadOnly defHomeAddress As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defPersonTitleID As DataColumnDefinition
       Public Shared ReadOnly defIsSuperUser As DataColumnDefinition
       Public Shared ReadOnly defBloodTypeID As DataColumnDefinition
       Public Shared ReadOnly defBirthPlace As DataColumnDefinition
       Public Shared ReadOnly defPictureFileName As DataColumnDefinition
       Public Shared ReadOnly defMaritalStatusID As DataColumnDefinition
       Public Shared ReadOnly defCanBeUpdated As DataColumnDefinition
       Public Shared ReadOnly defCanBeDeleted As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defDataMonitorID As DataColumnDefinition

       Public ReadOnly Property [IdentificationNo] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IdentificationNo.ToString()))
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


       Public ReadOnly Property [CountryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CountryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DateOfBirth] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.DateOfBirth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [GenderID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.GenderID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HomeAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HomeAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PersonTitleID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PersonTitleID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsSuperUser] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsSuperUser.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BloodTypeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BloodTypeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BirthPlace] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BirthPlace.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PictureFileName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PictureFileName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MaritalStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.MaritalStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CanBeUpdated] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.CanBeUpdated.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CanBeDeleted] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.CanBeDeleted.ToString()))
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


       Public ReadOnly Property [DataMonitorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DataMonitorID.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As T___Person                  
            If Me.hasRows() Then Return New T___Person(Me.AllRows(0))                  
            Return New T___Person()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___Person                  
            Return New T___Person(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___Person                  
            Return New T___Person(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___Person                  
            Return New T___Person(Me.RawTable, T___Person.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___Person,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___Person,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___Person                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___Person(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Person(drst.CopyToDataTable(),                  
                    T___Person.TABLE_NAME)                  
                Return New T___Person()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___Person()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___Person                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___Person(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___Person(drst.CopyToDataTable(),                  
                    T___Person.TABLE_NAME)                  
                Return New T___Person()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___Person()                  
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
            Return Person__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pIdentificationNo As String,
ByVal pCountryID As Int32,
ByVal pGenderID As Int32,
ByVal pEmail As String,
ByVal pPersonTitleID As Int32,
ByVal pBloodTypeID As Int32,
ByVal pMaritalStatusID As Int32,
ByVal pDataMonitorID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramCountryID As DataColumnParameter = New DataColumnParameter(defCountryID, pCountryID)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramPersonTitleID As DataColumnParameter = New DataColumnParameter(defPersonTitleID, pPersonTitleID)
 Dim paramBloodTypeID As DataColumnParameter = New DataColumnParameter(defBloodTypeID, pBloodTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, defFirstName.DefaultValue)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, defLastName.DefaultValue)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, defHomeAddress.DefaultValue)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, defIsSuperUser.DefaultValue)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, defBirthPlace.DefaultValue)
 Dim paramPictureFileName As DataColumnParameter = New DataColumnParameter(defPictureFileName, defPictureFileName.DefaultValue)
 Dim paramCanBeUpdated As DataColumnParameter = New DataColumnParameter(defCanBeUpdated, defCanBeUpdated.DefaultValue)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, defCanBeDeleted.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountryID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramPersonTitleID.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramBloodTypeID.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramPictureFileName.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramCanBeUpdated.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pIdentificationNo As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountryID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pGenderID As Int32,
ByVal pIsSuperUser As Boolean,
ByVal pMaritalStatusID As Int32,
ByVal pCanBeUpdated As Boolean,
ByVal pCanBeDeleted As Boolean,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPersonTitleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBloodTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPictureFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountryID As DataColumnParameter = New DataColumnParameter(defCountryID, pCountryID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramPersonTitleID As DataColumnParameter = New DataColumnParameter(defPersonTitleID, pPersonTitleID)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramBloodTypeID As DataColumnParameter = New DataColumnParameter(defBloodTypeID, pBloodTypeID)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramPictureFileName As DataColumnParameter = New DataColumnParameter(defPictureFileName, pPictureFileName)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramCanBeUpdated As DataColumnParameter = New DataColumnParameter(defCanBeUpdated, pCanBeUpdated)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountryID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramPersonTitleID.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramBloodTypeID.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramPictureFileName.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramCanBeUpdated.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pIdentificationNo As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountryID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pGenderID As Int32,
ByVal pIsSuperUser As Boolean,
ByVal pMaritalStatusID As Int32,
ByVal pCanBeUpdated As Boolean,
ByVal pCanBeDeleted As Boolean,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPersonTitleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBloodTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPictureFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountryID As DataColumnParameter = New DataColumnParameter(defCountryID, pCountryID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramPersonTitleID As DataColumnParameter = New DataColumnParameter(defPersonTitleID, pPersonTitleID)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramBloodTypeID As DataColumnParameter = New DataColumnParameter(defBloodTypeID, pBloodTypeID)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramPictureFileName As DataColumnParameter = New DataColumnParameter(defPictureFileName, pPictureFileName)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramCanBeUpdated As DataColumnParameter = New DataColumnParameter(defCanBeUpdated, pCanBeUpdated)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountryID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramPersonTitleID.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramBloodTypeID.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramPictureFileName.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramCanBeUpdated.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)




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
Public Shared Function add(ByVal pIdentificationNo As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountryID As Int32,
ByVal pDateOfBirth As DateTime,
ByVal pGenderID As Int32,
ByVal pIsSuperUser As Boolean,
ByVal pMaritalStatusID As Int32,
ByVal pCanBeUpdated As Boolean,
ByVal pCanBeDeleted As Boolean,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPersonTitleID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBloodTypeID As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPictureFileName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pUpdatedAt As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDataMonitorID As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountryID As DataColumnParameter = New DataColumnParameter(defCountryID, pCountryID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramPersonTitleID As DataColumnParameter = New DataColumnParameter(defPersonTitleID, pPersonTitleID)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramBloodTypeID As DataColumnParameter = New DataColumnParameter(defBloodTypeID, pBloodTypeID)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramPictureFileName As DataColumnParameter = New DataColumnParameter(defPictureFileName, pPictureFileName)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramCanBeUpdated As DataColumnParameter = New DataColumnParameter(defCanBeUpdated, pCanBeUpdated)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([IdentificationNo],[FirstName],[LastName],[CountryID],[DateOfBirth],[GenderID],[HomeAddress],[Email],[PersonTitleID],[IsSuperUser],[BloodTypeID],[BirthPlace],[PictureFileName],[MaritalStatusID],[CanBeUpdated],[CanBeDeleted],[CreatedAt],[UpdatedAt],[DataMonitorID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}) ", TABLE_NAME,paramIdentificationNo.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountryID.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGenderID.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramPersonTitleID.getSQLQuotedValueForAdd(),
paramIsSuperUser.getSQLQuotedValueForAdd(),
paramBloodTypeID.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramPictureFileName.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramCanBeUpdated.getSQLQuotedValueForAdd(),
paramCanBeDeleted.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd(),
paramUpdatedAt.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd()  ), True)


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
Optional ByVal pIdentificationNo As Object=Nothing,
Optional ByVal pFirstName As Object=Nothing,
Optional ByVal pLastName As Object=Nothing,
Optional ByVal pCountryID As Object=Nothing,
Optional ByVal pDateOfBirth As Object=Nothing,
Optional ByVal pGenderID As Object=Nothing,
Optional ByVal pIsSuperUser As Object=Nothing,
Optional ByVal pMaritalStatusID As Object=Nothing,
Optional ByVal pCanBeUpdated As Object=Nothing,
Optional ByVal pCanBeDeleted As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pHomeAddress As Object=Nothing,
Optional ByVal pEmail As Object=Nothing,
Optional ByVal pPersonTitleID As Object=Nothing,
Optional ByVal pBloodTypeID As Object=Nothing,
Optional ByVal pBirthPlace As Object=Nothing,
Optional ByVal pPictureFileName As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pDataMonitorID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountryID As DataColumnParameter = New DataColumnParameter(defCountryID, pCountryID)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGenderID As DataColumnParameter = New DataColumnParameter(defGenderID, pGenderID)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramPersonTitleID As DataColumnParameter = New DataColumnParameter(defPersonTitleID, pPersonTitleID)
 Dim paramIsSuperUser As DataColumnParameter = New DataColumnParameter(defIsSuperUser, pIsSuperUser)
 Dim paramBloodTypeID As DataColumnParameter = New DataColumnParameter(defBloodTypeID, pBloodTypeID)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramPictureFileName As DataColumnParameter = New DataColumnParameter(defPictureFileName, pPictureFileName)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramCanBeUpdated As DataColumnParameter = New DataColumnParameter(defCanBeUpdated, pCanBeUpdated)
 Dim paramCanBeDeleted As DataColumnParameter = New DataColumnParameter(defCanBeDeleted, pCanBeDeleted)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [IdentificationNo]={2},[FirstName]={3},[LastName]={4},[CountryID]={5},[DateOfBirth]={6},[GenderID]={7},[HomeAddress]={8},[Email]={9},[PersonTitleID]={10},[IsSuperUser]={11},[BloodTypeID]={12},[BirthPlace]={13},[PictureFileName]={14},[MaritalStatusID]={15},[CanBeUpdated]={16},[CanBeDeleted]={17},[CreatedAt]={18},[UpdatedAt]={19},[DataMonitorID]={20} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramIdentificationNo.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramCountryID.getSQLQuotedValueForUpdate(),
paramDateOfBirth.getSQLQuotedValueForUpdate(),
paramGenderID.getSQLQuotedValueForUpdate(),
paramHomeAddress.getSQLQuotedValueForUpdate(),
paramEmail.getSQLQuotedValueForUpdate(),
paramPersonTitleID.getSQLQuotedValueForUpdate(),
paramIsSuperUser.getSQLQuotedValueForUpdate(),
paramBloodTypeID.getSQLQuotedValueForUpdate(),
paramBirthPlace.getSQLQuotedValueForUpdate(),
paramPictureFileName.getSQLQuotedValueForUpdate(),
paramMaritalStatusID.getSQLQuotedValueForUpdate(),
paramCanBeUpdated.getSQLQuotedValueForUpdate(),
paramCanBeDeleted.getSQLQuotedValueForUpdate(),
paramCreatedAt.getSQLQuotedValueForUpdate(),
paramUpdatedAt.getSQLQuotedValueForUpdate(),
paramDataMonitorID.getSQLQuotedValueForUpdate()  ), True)


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
