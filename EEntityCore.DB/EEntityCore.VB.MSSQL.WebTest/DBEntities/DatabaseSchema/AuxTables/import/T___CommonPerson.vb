Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.import

Public Class T___CommonPerson
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defDataMonitorID = New DataColumnDefinition(TableColumnNames.DataMonitorID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defImportStatusID = New DataColumnDefinition(TableColumnNames.ImportStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIdentificationNo = New DataColumnDefinition(TableColumnNames.IdentificationNo.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPersonTitle = New DataColumnDefinition(TableColumnNames.PersonTitle.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFirstName = New DataColumnDefinition(TableColumnNames.FirstName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defLastName = New DataColumnDefinition(TableColumnNames.LastName.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCountry = New DataColumnDefinition(TableColumnNames.Country.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDateOfBirth = New DataColumnDefinition(TableColumnNames.DateOfBirth.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defGender = New DataColumnDefinition(TableColumnNames.Gender.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHomeAddress = New DataColumnDefinition(TableColumnNames.HomeAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBirthPlace = New DataColumnDefinition(TableColumnNames.BirthPlace.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMobileAreaCode = New DataColumnDefinition(TableColumnNames.MobileAreaCode.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defMobileNumber = New DataColumnDefinition(TableColumnNames.MobileNumber.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defImportComment = New DataColumnDefinition(TableColumnNames.ImportComment.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defDataMonitorID.ColumnName, defDataMonitorID) 
  ColumnDefns.Add(defImportStatusID.ColumnName, defImportStatusID) 
  ColumnDefns.Add(defIdentificationNo.ColumnName, defIdentificationNo) 
  ColumnDefns.Add(defPersonTitle.ColumnName, defPersonTitle) 
  ColumnDefns.Add(defFirstName.ColumnName, defFirstName) 
  ColumnDefns.Add(defLastName.ColumnName, defLastName) 
  ColumnDefns.Add(defCountry.ColumnName, defCountry) 
  ColumnDefns.Add(defDateOfBirth.ColumnName, defDateOfBirth) 
  ColumnDefns.Add(defGender.ColumnName, defGender) 
  ColumnDefns.Add(defHomeAddress.ColumnName, defHomeAddress) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defBirthPlace.ColumnName, defBirthPlace) 
  ColumnDefns.Add(defMobileAreaCode.ColumnName, defMobileAreaCode) 
  ColumnDefns.Add(defMobileNumber.ColumnName, defMobileNumber) 
  ColumnDefns.Add(defImportComment.ColumnName, defImportComment) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_CommonPerson_DataMonitorID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "import.CommonPerson", "import.DataMonitor"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_import_CommonPerson_ImportStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "import.CommonPerson", "import.ImportStatus"                  
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

       Public Const TABLE_NAME As String = "import.CommonPerson"
       Public Const CommonPerson__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM CommonPerson"
       Public Const CommonPerson__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [DataMonitorID], [ImportStatusID], [IdentificationNo], [PersonTitle], [FirstName], [LastName], [Country], [DateOfBirth], [Gender], [HomeAddress], [Email], [BirthPlace], [MobileAreaCode], [MobileNumber], [ImportComment], [CreatedAt] FROM CommonPerson"


       Public Enum TableColumnNames

           [ID]
           [DataMonitorID]
           [ImportStatusID]
           [IdentificationNo]
           [PersonTitle]
           [FirstName]
           [LastName]
           [Country]
           [DateOfBirth]
           [Gender]
           [HomeAddress]
           [Email]
           [BirthPlace]
           [MobileAreaCode]
           [MobileNumber]
           [ImportComment]
           [CreatedAt]
       End Enum 



       Public Enum TableConstraints

           pk_import_CommonPerson 
           fk_import_CommonPerson_DataMonitorID 
           fk_import_CommonPerson_ImportStatusID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defDataMonitorID As DataColumnDefinition
       Public Shared ReadOnly defImportStatusID As DataColumnDefinition
       Public Shared ReadOnly defIdentificationNo As DataColumnDefinition
       Public Shared ReadOnly defPersonTitle As DataColumnDefinition
       Public Shared ReadOnly defFirstName As DataColumnDefinition
       Public Shared ReadOnly defLastName As DataColumnDefinition
       Public Shared ReadOnly defCountry As DataColumnDefinition
       Public Shared ReadOnly defDateOfBirth As DataColumnDefinition
       Public Shared ReadOnly defGender As DataColumnDefinition
       Public Shared ReadOnly defHomeAddress As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defBirthPlace As DataColumnDefinition
       Public Shared ReadOnly defMobileAreaCode As DataColumnDefinition
       Public Shared ReadOnly defMobileNumber As DataColumnDefinition
       Public Shared ReadOnly defImportComment As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition

       Public ReadOnly Property [DataMonitorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DataMonitorID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ImportStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ImportStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IdentificationNo] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.IdentificationNo.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PersonTitle] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PersonTitle.ToString()))
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


       Public ReadOnly Property [Country] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Country.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DateOfBirth] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.DateOfBirth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Gender] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Gender.ToString()))
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


       Public ReadOnly Property [BirthPlace] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.BirthPlace.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MobileAreaCode] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.MobileAreaCode.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MobileNumber] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.MobileNumber.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ImportComment] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ImportComment.ToString()))
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
        Public Function getFirstRow() As T___CommonPerson                  
            If Me.hasRows() Then Return New T___CommonPerson(Me.AllRows(0))                  
            Return New T___CommonPerson()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___CommonPerson                  
            Return New T___CommonPerson(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___CommonPerson                  
            Return New T___CommonPerson(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___CommonPerson                  
            Return New T___CommonPerson(Me.RawTable, T___CommonPerson.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___CommonPerson,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___CommonPerson,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___CommonPerson                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___CommonPerson(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CommonPerson(drst.CopyToDataTable(),                  
                    T___CommonPerson.TABLE_NAME)                  
                Return New T___CommonPerson()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___CommonPerson()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___CommonPerson                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___CommonPerson(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___CommonPerson(drst.CopyToDataTable(),                  
                    T___CommonPerson.TABLE_NAME)                  
                Return New T___CommonPerson()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___CommonPerson()                  
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
            Return CommonPerson__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, defIdentificationNo.DefaultValue)
 Dim paramPersonTitle As DataColumnParameter = New DataColumnParameter(defPersonTitle, defPersonTitle.DefaultValue)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, defFirstName.DefaultValue)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, defLastName.DefaultValue)
 Dim paramCountry As DataColumnParameter = New DataColumnParameter(defCountry, defCountry.DefaultValue)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, defDateOfBirth.DefaultValue)
 Dim paramGender As DataColumnParameter = New DataColumnParameter(defGender, defGender.DefaultValue)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, defHomeAddress.DefaultValue)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, defEmail.DefaultValue)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, defBirthPlace.DefaultValue)
 Dim paramMobileAreaCode As DataColumnParameter = New DataColumnParameter(defMobileAreaCode, defMobileAreaCode.DefaultValue)
 Dim paramMobileNumber As DataColumnParameter = New DataColumnParameter(defMobileNumber, defMobileNumber.DefaultValue)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, defImportComment.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)


DBConnectInterface.getDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramPersonTitle.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountry.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGender.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramMobileAreaCode.getSQLQuotedValueForAdd(),
paramMobileNumber.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithID(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pIdentificationNo As String,
ByVal pPersonTitle As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountry As String,
ByVal pDateOfBirth As DateTime,
ByVal pGender As String,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileAreaCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.getDBConn().GETNewID(TABLE_NAME))
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramPersonTitle As DataColumnParameter = New DataColumnParameter(defPersonTitle, pPersonTitle)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountry As DataColumnParameter = New DataColumnParameter(defCountry, pCountry)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGender As DataColumnParameter = New DataColumnParameter(defGender, pGender)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramMobileAreaCode As DataColumnParameter = New DataColumnParameter(defMobileAreaCode, pMobileAreaCode)
 Dim paramMobileNumber As DataColumnParameter = New DataColumnParameter(defMobileNumber, pMobileNumber)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramPersonTitle.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountry.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGender.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramMobileAreaCode.getSQLQuotedValueForAdd(),
paramMobileNumber.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
paramCreatedAt.getSQLQuotedValueForAdd()  ), True)




            Return EInt.valueOf(paramID.Value) 
Catch ex As Exception 
Logger.Print(ex) 
Throw 
End Try 

Return 0    REM this will not run 

End Function 



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pIdentificationNo As String,
ByVal pPersonTitle As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountry As String,
ByVal pDateOfBirth As DateTime,
ByVal pGender As String,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileAreaCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramPersonTitle As DataColumnParameter = New DataColumnParameter(defPersonTitle, pPersonTitle)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountry As DataColumnParameter = New DataColumnParameter(defCountry, pCountry)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGender As DataColumnParameter = New DataColumnParameter(defGender, pGender)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramMobileAreaCode As DataColumnParameter = New DataColumnParameter(defMobileAreaCode, pMobileAreaCode)
 Dim paramMobileNumber As DataColumnParameter = New DataColumnParameter(defMobileNumber, pMobileNumber)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramPersonTitle.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountry.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGender.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramMobileAreaCode.getSQLQuotedValueForAdd(),
paramMobileNumber.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pDataMonitorID As Int32,
ByVal pImportStatusID As Int32,
ByVal pIdentificationNo As String,
ByVal pPersonTitle As String,
ByVal pFirstName As String,
ByVal pLastName As String,
ByVal pCountry As String,
ByVal pDateOfBirth As DateTime,
ByVal pGender As String,
ByVal pImportComment As String,
ByVal pCreatedAt As DateTime,
Optional ByVal pHomeAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pBirthPlace As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileAreaCode As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pMobileNumber As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramPersonTitle As DataColumnParameter = New DataColumnParameter(defPersonTitle, pPersonTitle)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountry As DataColumnParameter = New DataColumnParameter(defCountry, pCountry)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGender As DataColumnParameter = New DataColumnParameter(defGender, pGender)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramMobileAreaCode As DataColumnParameter = New DataColumnParameter(defMobileAreaCode, pMobileAreaCode)
 Dim paramMobileNumber As DataColumnParameter = New DataColumnParameter(defMobileNumber, pMobileNumber)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


Return DBConnectInterface.getDBConn().dbExec(
     String.Format("INSERT INTO {0}([DataMonitorID],[ImportStatusID],[IdentificationNo],[PersonTitle],[FirstName],[LastName],[Country],[DateOfBirth],[Gender],[HomeAddress],[Email],[BirthPlace],[MobileAreaCode],[MobileNumber],[ImportComment],[CreatedAt]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramDataMonitorID.getSQLQuotedValueForAdd(),
paramImportStatusID.getSQLQuotedValueForAdd(),
paramIdentificationNo.getSQLQuotedValueForAdd(),
paramPersonTitle.getSQLQuotedValueForAdd(),
paramFirstName.getSQLQuotedValueForAdd(),
paramLastName.getSQLQuotedValueForAdd(),
paramCountry.getSQLQuotedValueForAdd(),
paramDateOfBirth.getSQLQuotedValueForAdd(),
paramGender.getSQLQuotedValueForAdd(),
paramHomeAddress.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramBirthPlace.getSQLQuotedValueForAdd(),
paramMobileAreaCode.getSQLQuotedValueForAdd(),
paramMobileNumber.getSQLQuotedValueForAdd(),
paramImportComment.getSQLQuotedValueForAdd(),
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
Optional ByVal pDataMonitorID As Object=Nothing,
Optional ByVal pImportStatusID As Object=Nothing,
Optional ByVal pIdentificationNo As Object=Nothing,
Optional ByVal pPersonTitle As Object=Nothing,
Optional ByVal pFirstName As Object=Nothing,
Optional ByVal pLastName As Object=Nothing,
Optional ByVal pCountry As Object=Nothing,
Optional ByVal pDateOfBirth As Object=Nothing,
Optional ByVal pGender As Object=Nothing,
Optional ByVal pImportComment As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pHomeAddress As Object=Nothing,
Optional ByVal pEmail As Object=Nothing,
Optional ByVal pBirthPlace As Object=Nothing,
Optional ByVal pMobileAreaCode As Object=Nothing,
Optional ByVal pMobileNumber As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramDataMonitorID As DataColumnParameter = New DataColumnParameter(defDataMonitorID, pDataMonitorID)
 Dim paramImportStatusID As DataColumnParameter = New DataColumnParameter(defImportStatusID, pImportStatusID)
 Dim paramIdentificationNo As DataColumnParameter = New DataColumnParameter(defIdentificationNo, pIdentificationNo)
 Dim paramPersonTitle As DataColumnParameter = New DataColumnParameter(defPersonTitle, pPersonTitle)
 Dim paramFirstName As DataColumnParameter = New DataColumnParameter(defFirstName, pFirstName)
 Dim paramLastName As DataColumnParameter = New DataColumnParameter(defLastName, pLastName)
 Dim paramCountry As DataColumnParameter = New DataColumnParameter(defCountry, pCountry)
 Dim paramDateOfBirth As DataColumnParameter = New DataColumnParameter(defDateOfBirth, pDateOfBirth)
 Dim paramGender As DataColumnParameter = New DataColumnParameter(defGender, pGender)
 Dim paramHomeAddress As DataColumnParameter = New DataColumnParameter(defHomeAddress, pHomeAddress)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramBirthPlace As DataColumnParameter = New DataColumnParameter(defBirthPlace, pBirthPlace)
 Dim paramMobileAreaCode As DataColumnParameter = New DataColumnParameter(defMobileAreaCode, pMobileAreaCode)
 Dim paramMobileNumber As DataColumnParameter = New DataColumnParameter(defMobileNumber, pMobileNumber)
 Dim paramImportComment As DataColumnParameter = New DataColumnParameter(defImportComment, pImportComment)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)


DBConnectInterface.getDBConn().dbExec(
     String.Format("UPDATE {0} SET [DataMonitorID]={2},[ImportStatusID]={3},[IdentificationNo]={4},[PersonTitle]={5},[FirstName]={6},[LastName]={7},[Country]={8},[DateOfBirth]={9},[Gender]={10},[HomeAddress]={11},[Email]={12},[BirthPlace]={13},[MobileAreaCode]={14},[MobileNumber]={15},[ImportComment]={16},[CreatedAt]={17} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramDataMonitorID.getSQLQuotedValueForUpdate(),
paramImportStatusID.getSQLQuotedValueForUpdate(),
paramIdentificationNo.getSQLQuotedValueForUpdate(),
paramPersonTitle.getSQLQuotedValueForUpdate(),
paramFirstName.getSQLQuotedValueForUpdate(),
paramLastName.getSQLQuotedValueForUpdate(),
paramCountry.getSQLQuotedValueForUpdate(),
paramDateOfBirth.getSQLQuotedValueForUpdate(),
paramGender.getSQLQuotedValueForUpdate(),
paramHomeAddress.getSQLQuotedValueForUpdate(),
paramEmail.getSQLQuotedValueForUpdate(),
paramBirthPlace.getSQLQuotedValueForUpdate(),
paramMobileAreaCode.getSQLQuotedValueForUpdate(),
paramMobileNumber.getSQLQuotedValueForUpdate(),
paramImportComment.getSQLQuotedValueForUpdate(),
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
