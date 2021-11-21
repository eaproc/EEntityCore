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

Public Class T___BeneficiaryRelation
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defBeneficiaryID = New DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defRelationshipTypeID = New DataColumnDefinition(TableColumnNames.RelationshipTypeID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defMaritalStatusID = New DataColumnDefinition(TableColumnNames.MaritalStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defIsDeceased = New DataColumnDefinition(TableColumnNames.IsDeceased.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defRelationshipNarration = New DataColumnDefinition(TableColumnNames.RelationshipNarration.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defFullName = New DataColumnDefinition(TableColumnNames.FullName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defOccupation = New DataColumnDefinition(TableColumnNames.Occupation.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAddress = New DataColumnDefinition(TableColumnNames.Address.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHomePhone = New DataColumnDefinition(TableColumnNames.HomePhone.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmail = New DataColumnDefinition(TableColumnNames.Email.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDeathCertificatePath = New DataColumnDefinition(TableColumnNames.DeathCertificatePath.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPhotoPath = New DataColumnDefinition(TableColumnNames.PhotoPath.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID) 
  ColumnDefns.Add(defRelationshipTypeID.ColumnName, defRelationshipTypeID) 
  ColumnDefns.Add(defMaritalStatusID.ColumnName, defMaritalStatusID) 
  ColumnDefns.Add(defIsDeceased.ColumnName, defIsDeceased) 
  ColumnDefns.Add(defRelationshipNarration.ColumnName, defRelationshipNarration) 
  ColumnDefns.Add(defFullName.ColumnName, defFullName) 
  ColumnDefns.Add(defOccupation.ColumnName, defOccupation) 
  ColumnDefns.Add(defAddress.ColumnName, defAddress) 
  ColumnDefns.Add(defHomePhone.ColumnName, defHomePhone) 
  ColumnDefns.Add(defEmail.ColumnName, defEmail) 
  ColumnDefns.Add(defDeathCertificatePath.ColumnName, defDeathCertificatePath) 
  ColumnDefns.Add(defPhotoPath.ColumnName, defPhotoPath) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_BeneficiaryID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.BeneficiaryRelation", "charity.Beneficiary"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_RelationshipTypeID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "common.RelationshipType"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_MaritalStatusID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "common.MaritalStatus"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_BeneficiaryRelation_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.BeneficiaryRelation", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "charity.BeneficiaryRelation"
       Public Const BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM BeneficiaryRelation"
       Public Const BeneficiaryRelation__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [BeneficiaryID], [RelationshipTypeID], [MaritalStatusID], [IsDeceased], [RelationshipNarration], [FullName], [Occupation], [Address], [HomePhone], [Email], [DeathCertificatePath], [PhotoPath], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM BeneficiaryRelation"


       Public Enum TableColumnNames

           [ID]
           [BeneficiaryID]
           [RelationshipTypeID]
           [MaritalStatusID]
           [IsDeceased]
           [RelationshipNarration]
           [FullName]
           [Occupation]
           [Address]
           [HomePhone]
           [Email]
           [DeathCertificatePath]
           [PhotoPath]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_charity_BeneficiaryRelation 
           fk_charity_BeneficiaryRelation_BeneficiaryID 
           fk_charity_BeneficiaryRelation_RelationshipTypeID 
           fk_charity_BeneficiaryRelation_MaritalStatusID 
           fk_charity_BeneficiaryRelation_CreatedByID 
           fk_charity_BeneficiaryRelation_UpdatedByID 
           uq_charity_BeneficiaryRelation_BeneficiaryID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defBeneficiaryID As DataColumnDefinition
       Public Shared ReadOnly defRelationshipTypeID As DataColumnDefinition
       Public Shared ReadOnly defMaritalStatusID As DataColumnDefinition
       Public Shared ReadOnly defIsDeceased As DataColumnDefinition
       Public Shared ReadOnly defRelationshipNarration As DataColumnDefinition
       Public Shared ReadOnly defFullName As DataColumnDefinition
       Public Shared ReadOnly defOccupation As DataColumnDefinition
       Public Shared ReadOnly defAddress As DataColumnDefinition
       Public Shared ReadOnly defHomePhone As DataColumnDefinition
       Public Shared ReadOnly defEmail As DataColumnDefinition
       Public Shared ReadOnly defDeathCertificatePath As DataColumnDefinition
       Public Shared ReadOnly defPhotoPath As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition

       Public ReadOnly Property [BeneficiaryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BeneficiaryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RelationshipTypeID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.RelationshipTypeID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [MaritalStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.MaritalStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsDeceased] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsDeceased.ToString()))
           End Get
       End Property


       Public ReadOnly Property [RelationshipNarration] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.RelationshipNarration.ToString()))
           End Get
       End Property


       Public ReadOnly Property [FullName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.FullName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Occupation] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Occupation.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Address] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Address.ToString()))
           End Get
       End Property


       Public ReadOnly Property [HomePhone] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.HomePhone.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Email] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Email.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DeathCertificatePath] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.DeathCertificatePath.ToString()))
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
        Public Function getFirstRow() As T___BeneficiaryRelation                  
            If Me.hasRows() Then Return New T___BeneficiaryRelation(Me.AllRows(0))                  
            Return New T___BeneficiaryRelation()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___BeneficiaryRelation                  
            Return New T___BeneficiaryRelation(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___BeneficiaryRelation                  
            Return New T___BeneficiaryRelation(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___BeneficiaryRelation                  
            Return New T___BeneficiaryRelation(Me.RawTable, T___BeneficiaryRelation.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___BeneficiaryRelation,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___BeneficiaryRelation,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___BeneficiaryRelation                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___BeneficiaryRelation(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___BeneficiaryRelation(drst.CopyToDataTable(),                  
                    T___BeneficiaryRelation.TABLE_NAME)                  
                Return New T___BeneficiaryRelation()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___BeneficiaryRelation()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___BeneficiaryRelation                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___BeneficiaryRelation(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___BeneficiaryRelation(drst.CopyToDataTable(),                  
                    T___BeneficiaryRelation.TABLE_NAME)                  
                Return New T___BeneficiaryRelation()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___BeneficiaryRelation()                  
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
            Return BeneficiaryRelation__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pBeneficiaryID As Int32,
ByVal pRelationshipTypeID As Int32,
ByVal pMaritalStatusID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramRelationshipTypeID As DataColumnParameter = New DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramIsDeceased As DataColumnParameter = New DataColumnParameter(defIsDeceased, defIsDeceased.DefaultValue)
 Dim paramRelationshipNarration As DataColumnParameter = New DataColumnParameter(defRelationshipNarration, defRelationshipNarration.DefaultValue)
 Dim paramFullName As DataColumnParameter = New DataColumnParameter(defFullName, defFullName.DefaultValue)
 Dim paramOccupation As DataColumnParameter = New DataColumnParameter(defOccupation, defOccupation.DefaultValue)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, defAddress.DefaultValue)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, defHomePhone.DefaultValue)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, defEmail.DefaultValue)
 Dim paramDeathCertificatePath As DataColumnParameter = New DataColumnParameter(defDeathCertificatePath, defDeathCertificatePath.DefaultValue)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, defPhotoPath.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramRelationshipTypeID.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramIsDeceased.getSQLQuotedValueForAdd(),
paramRelationshipNarration.getSQLQuotedValueForAdd(),
paramFullName.getSQLQuotedValueForAdd(),
paramOccupation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramDeathCertificatePath.getSQLQuotedValueForAdd(),
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



Public Shared Function addWithID(ByVal pBeneficiaryID As Int32,
ByVal pRelationshipTypeID As Int32,
ByVal pMaritalStatusID As Int32,
ByVal pIsDeceased As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pRelationshipNarration As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pFullName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOccupation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDeathCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramRelationshipTypeID As DataColumnParameter = New DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramIsDeceased As DataColumnParameter = New DataColumnParameter(defIsDeceased, pIsDeceased)
 Dim paramRelationshipNarration As DataColumnParameter = New DataColumnParameter(defRelationshipNarration, pRelationshipNarration)
 Dim paramFullName As DataColumnParameter = New DataColumnParameter(defFullName, pFullName)
 Dim paramOccupation As DataColumnParameter = New DataColumnParameter(defOccupation, pOccupation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramDeathCertificatePath As DataColumnParameter = New DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramRelationshipTypeID.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramIsDeceased.getSQLQuotedValueForAdd(),
paramRelationshipNarration.getSQLQuotedValueForAdd(),
paramFullName.getSQLQuotedValueForAdd(),
paramOccupation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramDeathCertificatePath.getSQLQuotedValueForAdd(),
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



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pBeneficiaryID As Int32,
ByVal pRelationshipTypeID As Int32,
ByVal pMaritalStatusID As Int32,
ByVal pIsDeceased As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pRelationshipNarration As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pFullName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOccupation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDeathCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramRelationshipTypeID As DataColumnParameter = New DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramIsDeceased As DataColumnParameter = New DataColumnParameter(defIsDeceased, pIsDeceased)
 Dim paramRelationshipNarration As DataColumnParameter = New DataColumnParameter(defRelationshipNarration, pRelationshipNarration)
 Dim paramFullName As DataColumnParameter = New DataColumnParameter(defFullName, pFullName)
 Dim paramOccupation As DataColumnParameter = New DataColumnParameter(defOccupation, pOccupation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramDeathCertificatePath As DataColumnParameter = New DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramRelationshipTypeID.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramIsDeceased.getSQLQuotedValueForAdd(),
paramRelationshipNarration.getSQLQuotedValueForAdd(),
paramFullName.getSQLQuotedValueForAdd(),
paramOccupation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramDeathCertificatePath.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pBeneficiaryID As Int32,
ByVal pRelationshipTypeID As Int32,
ByVal pMaritalStatusID As Int32,
ByVal pIsDeceased As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pRelationshipNarration As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pFullName As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pOccupation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pAddress As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHomePhone As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmail As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pDeathCertificatePath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pPhotoPath As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramRelationshipTypeID As DataColumnParameter = New DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramIsDeceased As DataColumnParameter = New DataColumnParameter(defIsDeceased, pIsDeceased)
 Dim paramRelationshipNarration As DataColumnParameter = New DataColumnParameter(defRelationshipNarration, pRelationshipNarration)
 Dim paramFullName As DataColumnParameter = New DataColumnParameter(defFullName, pFullName)
 Dim paramOccupation As DataColumnParameter = New DataColumnParameter(defOccupation, pOccupation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramDeathCertificatePath As DataColumnParameter = New DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([BeneficiaryID],[RelationshipTypeID],[MaritalStatusID],[IsDeceased],[RelationshipNarration],[FullName],[Occupation],[Address],[HomePhone],[Email],[DeathCertificatePath],[PhotoPath],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramRelationshipTypeID.getSQLQuotedValueForAdd(),
paramMaritalStatusID.getSQLQuotedValueForAdd(),
paramIsDeceased.getSQLQuotedValueForAdd(),
paramRelationshipNarration.getSQLQuotedValueForAdd(),
paramFullName.getSQLQuotedValueForAdd(),
paramOccupation.getSQLQuotedValueForAdd(),
paramAddress.getSQLQuotedValueForAdd(),
paramHomePhone.getSQLQuotedValueForAdd(),
paramEmail.getSQLQuotedValueForAdd(),
paramDeathCertificatePath.getSQLQuotedValueForAdd(),
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
Optional ByVal pBeneficiaryID As Object=Nothing,
Optional ByVal pRelationshipTypeID As Object=Nothing,
Optional ByVal pMaritalStatusID As Object=Nothing,
Optional ByVal pIsDeceased As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pRelationshipNarration As Object=Nothing,
Optional ByVal pFullName As Object=Nothing,
Optional ByVal pOccupation As Object=Nothing,
Optional ByVal pAddress As Object=Nothing,
Optional ByVal pHomePhone As Object=Nothing,
Optional ByVal pEmail As Object=Nothing,
Optional ByVal pDeathCertificatePath As Object=Nothing,
Optional ByVal pPhotoPath As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramRelationshipTypeID As DataColumnParameter = New DataColumnParameter(defRelationshipTypeID, pRelationshipTypeID)
 Dim paramMaritalStatusID As DataColumnParameter = New DataColumnParameter(defMaritalStatusID, pMaritalStatusID)
 Dim paramIsDeceased As DataColumnParameter = New DataColumnParameter(defIsDeceased, pIsDeceased)
 Dim paramRelationshipNarration As DataColumnParameter = New DataColumnParameter(defRelationshipNarration, pRelationshipNarration)
 Dim paramFullName As DataColumnParameter = New DataColumnParameter(defFullName, pFullName)
 Dim paramOccupation As DataColumnParameter = New DataColumnParameter(defOccupation, pOccupation)
 Dim paramAddress As DataColumnParameter = New DataColumnParameter(defAddress, pAddress)
 Dim paramHomePhone As DataColumnParameter = New DataColumnParameter(defHomePhone, pHomePhone)
 Dim paramEmail As DataColumnParameter = New DataColumnParameter(defEmail, pEmail)
 Dim paramDeathCertificatePath As DataColumnParameter = New DataColumnParameter(defDeathCertificatePath, pDeathCertificatePath)
 Dim paramPhotoPath As DataColumnParameter = New DataColumnParameter(defPhotoPath, pPhotoPath)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [BeneficiaryID]={2},[RelationshipTypeID]={3},[MaritalStatusID]={4},[IsDeceased]={5},[RelationshipNarration]={6},[FullName]={7},[Occupation]={8},[Address]={9},[HomePhone]={10},[Email]={11},[DeathCertificatePath]={12},[PhotoPath]={13},[CreatedAt]={14},[UpdatedAt]={15},[CreatedByID]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramBeneficiaryID.getSQLQuotedValueForUpdate(),
paramRelationshipTypeID.getSQLQuotedValueForUpdate(),
paramMaritalStatusID.getSQLQuotedValueForUpdate(),
paramIsDeceased.getSQLQuotedValueForUpdate(),
paramRelationshipNarration.getSQLQuotedValueForUpdate(),
paramFullName.getSQLQuotedValueForUpdate(),
paramOccupation.getSQLQuotedValueForUpdate(),
paramAddress.getSQLQuotedValueForUpdate(),
paramHomePhone.getSQLQuotedValueForUpdate(),
paramEmail.getSQLQuotedValueForUpdate(),
paramDeathCertificatePath.getSQLQuotedValueForUpdate(),
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
