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

Public Class T___AttendeeDetail
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCenterVisitationID = New DataColumnDefinition(TableColumnNames.CenterVisitationID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defBeneficiaryID = New DataColumnDefinition(TableColumnNames.BeneficiaryID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNIQUE) 
  defIsPresent = New DataColumnDefinition(TableColumnNames.IsPresent.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPictureStoredPath = New DataColumnDefinition(TableColumnNames.PictureStoredPath.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEducation = New DataColumnDefinition(TableColumnNames.Education.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defEmotion = New DataColumnDefinition(TableColumnNames.Emotion.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defHealth = New DataColumnDefinition(TableColumnNames.Health.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSpiritual = New DataColumnDefinition(TableColumnNames.Spiritual.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSocial = New DataColumnDefinition(TableColumnNames.Social.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTalent = New DataColumnDefinition(TableColumnNames.Talent.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defObservations = New DataColumnDefinition(TableColumnNames.Observations.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defChristSmilesFeedBack = New DataColumnDefinition(TableColumnNames.ChristSmilesFeedBack.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCenterVisitationID.ColumnName, defCenterVisitationID) 
  ColumnDefns.Add(defBeneficiaryID.ColumnName, defBeneficiaryID) 
  ColumnDefns.Add(defIsPresent.ColumnName, defIsPresent) 
  ColumnDefns.Add(defPictureStoredPath.ColumnName, defPictureStoredPath) 
  ColumnDefns.Add(defEducation.ColumnName, defEducation) 
  ColumnDefns.Add(defEmotion.ColumnName, defEmotion) 
  ColumnDefns.Add(defHealth.ColumnName, defHealth) 
  ColumnDefns.Add(defSpiritual.ColumnName, defSpiritual) 
  ColumnDefns.Add(defSocial.ColumnName, defSocial) 
  ColumnDefns.Add(defTalent.ColumnName, defTalent) 
  ColumnDefns.Add(defObservations.ColumnName, defObservations) 
  ColumnDefns.Add(defChristSmilesFeedBack.ColumnName, defChristSmilesFeedBack) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CenterVisitationID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.AttendeeDetail", "charity.CenterVisitation"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_BeneficiaryID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "charity.Beneficiary"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_AttendeeDetail_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.AttendeeDetail", "auth.Users"                  
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

       Public Const TABLE_NAME As String = "charity.AttendeeDetail"
       Public Const AttendeeDetail__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM AttendeeDetail"
       Public Const AttendeeDetail__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CenterVisitationID], [BeneficiaryID], [IsPresent], [PictureStoredPath], [Education], [Emotion], [Health], [Spiritual], [Social], [Talent], [Observations], [ChristSmilesFeedBack], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM AttendeeDetail"


       Public Enum TableColumnNames

           [ID]
           [CenterVisitationID]
           [BeneficiaryID]
           [IsPresent]
           [PictureStoredPath]
           [Education]
           [Emotion]
           [Health]
           [Spiritual]
           [Social]
           [Talent]
           [Observations]
           [ChristSmilesFeedBack]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_charity_AttendeeDetail 
           fk_charity_AttendeeDetail_CenterVisitationID 
           fk_charity_AttendeeDetail_BeneficiaryID 
           fk_charity_AttendeeDetail_CreatedByID 
           fk_charity_AttendeeDetail_UpdatedByID 
           uq_charity_AttendeeDetail_BeneficiaryID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCenterVisitationID As DataColumnDefinition
       Public Shared ReadOnly defBeneficiaryID As DataColumnDefinition
       Public Shared ReadOnly defIsPresent As DataColumnDefinition
       Public Shared ReadOnly defPictureStoredPath As DataColumnDefinition
       Public Shared ReadOnly defEducation As DataColumnDefinition
       Public Shared ReadOnly defEmotion As DataColumnDefinition
       Public Shared ReadOnly defHealth As DataColumnDefinition
       Public Shared ReadOnly defSpiritual As DataColumnDefinition
       Public Shared ReadOnly defSocial As DataColumnDefinition
       Public Shared ReadOnly defTalent As DataColumnDefinition
       Public Shared ReadOnly defObservations As DataColumnDefinition
       Public Shared ReadOnly defChristSmilesFeedBack As DataColumnDefinition
       Public Shared ReadOnly defCreatedAt As DataColumnDefinition
       Public Shared ReadOnly defUpdatedAt As DataColumnDefinition
       Public Shared ReadOnly defCreatedByID As DataColumnDefinition
       Public Shared ReadOnly defUpdatedByID As DataColumnDefinition

       Public ReadOnly Property [CenterVisitationID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CenterVisitationID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BeneficiaryID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BeneficiaryID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsPresent] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsPresent.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PictureStoredPath] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PictureStoredPath.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Education] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Education.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Emotion] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Emotion.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Health] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Health.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Spiritual] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Spiritual.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Social] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Social.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Talent] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Talent.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Observations] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Observations.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ChristSmilesFeedBack] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.ChristSmilesFeedBack.ToString()))
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
        Public Function getFirstRow() As T___AttendeeDetail                  
            If Me.hasRows() Then Return New T___AttendeeDetail(Me.AllRows(0))                  
            Return New T___AttendeeDetail()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___AttendeeDetail                  
            Return New T___AttendeeDetail(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___AttendeeDetail                  
            Return New T___AttendeeDetail(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___AttendeeDetail                  
            Return New T___AttendeeDetail(Me.RawTable, T___AttendeeDetail.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___AttendeeDetail,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___AttendeeDetail,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___AttendeeDetail                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___AttendeeDetail(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___AttendeeDetail(drst.CopyToDataTable(),                  
                    T___AttendeeDetail.TABLE_NAME)                  
                Return New T___AttendeeDetail()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___AttendeeDetail()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___AttendeeDetail                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___AttendeeDetail(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___AttendeeDetail(drst.CopyToDataTable(),                  
                    T___AttendeeDetail.TABLE_NAME)                  
                Return New T___AttendeeDetail()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___AttendeeDetail()                  
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
            Return AttendeeDetail__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCenterVisitationID As Int32,
ByVal pBeneficiaryID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterVisitationID As DataColumnParameter = New DataColumnParameter(defCenterVisitationID, pCenterVisitationID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramIsPresent As DataColumnParameter = New DataColumnParameter(defIsPresent, defIsPresent.DefaultValue)
 Dim paramPictureStoredPath As DataColumnParameter = New DataColumnParameter(defPictureStoredPath, defPictureStoredPath.DefaultValue)
 Dim paramEducation As DataColumnParameter = New DataColumnParameter(defEducation, defEducation.DefaultValue)
 Dim paramEmotion As DataColumnParameter = New DataColumnParameter(defEmotion, defEmotion.DefaultValue)
 Dim paramHealth As DataColumnParameter = New DataColumnParameter(defHealth, defHealth.DefaultValue)
 Dim paramSpiritual As DataColumnParameter = New DataColumnParameter(defSpiritual, defSpiritual.DefaultValue)
 Dim paramSocial As DataColumnParameter = New DataColumnParameter(defSocial, defSocial.DefaultValue)
 Dim paramTalent As DataColumnParameter = New DataColumnParameter(defTalent, defTalent.DefaultValue)
 Dim paramObservations As DataColumnParameter = New DataColumnParameter(defObservations, defObservations.DefaultValue)
 Dim paramChristSmilesFeedBack As DataColumnParameter = New DataColumnParameter(defChristSmilesFeedBack, defChristSmilesFeedBack.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterVisitationID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramIsPresent.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramEducation.getSQLQuotedValueForAdd(),
paramEmotion.getSQLQuotedValueForAdd(),
paramHealth.getSQLQuotedValueForAdd(),
paramSpiritual.getSQLQuotedValueForAdd(),
paramSocial.getSQLQuotedValueForAdd(),
paramTalent.getSQLQuotedValueForAdd(),
paramObservations.getSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.getSQLQuotedValueForAdd(),
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



Public Shared Function addWithID(ByVal pCenterVisitationID As Int32,
ByVal pBeneficiaryID As Int32,
ByVal pIsPresent As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pPictureStoredPath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEducation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmotion As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHealth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSpiritual As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSocial As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTalent As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pObservations As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChristSmilesFeedBack As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterVisitationID As DataColumnParameter = New DataColumnParameter(defCenterVisitationID, pCenterVisitationID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramIsPresent As DataColumnParameter = New DataColumnParameter(defIsPresent, pIsPresent)
 Dim paramPictureStoredPath As DataColumnParameter = New DataColumnParameter(defPictureStoredPath, pPictureStoredPath)
 Dim paramEducation As DataColumnParameter = New DataColumnParameter(defEducation, pEducation)
 Dim paramEmotion As DataColumnParameter = New DataColumnParameter(defEmotion, pEmotion)
 Dim paramHealth As DataColumnParameter = New DataColumnParameter(defHealth, pHealth)
 Dim paramSpiritual As DataColumnParameter = New DataColumnParameter(defSpiritual, pSpiritual)
 Dim paramSocial As DataColumnParameter = New DataColumnParameter(defSocial, pSocial)
 Dim paramTalent As DataColumnParameter = New DataColumnParameter(defTalent, pTalent)
 Dim paramObservations As DataColumnParameter = New DataColumnParameter(defObservations, pObservations)
 Dim paramChristSmilesFeedBack As DataColumnParameter = New DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterVisitationID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramIsPresent.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramEducation.getSQLQuotedValueForAdd(),
paramEmotion.getSQLQuotedValueForAdd(),
paramHealth.getSQLQuotedValueForAdd(),
paramSpiritual.getSQLQuotedValueForAdd(),
paramSocial.getSQLQuotedValueForAdd(),
paramTalent.getSQLQuotedValueForAdd(),
paramObservations.getSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.getSQLQuotedValueForAdd(),
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



Public Shared Function addWithParseID(Byval pParseID As Int32,ByVal pCenterVisitationID As Int32,
ByVal pBeneficiaryID As Int32,
ByVal pIsPresent As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pPictureStoredPath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEducation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmotion As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHealth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSpiritual As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSocial As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTalent As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pObservations As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChristSmilesFeedBack As Object = DataColumnNullParamValue.NULL_VALUE) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCenterVisitationID As DataColumnParameter = New DataColumnParameter(defCenterVisitationID, pCenterVisitationID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramIsPresent As DataColumnParameter = New DataColumnParameter(defIsPresent, pIsPresent)
 Dim paramPictureStoredPath As DataColumnParameter = New DataColumnParameter(defPictureStoredPath, pPictureStoredPath)
 Dim paramEducation As DataColumnParameter = New DataColumnParameter(defEducation, pEducation)
 Dim paramEmotion As DataColumnParameter = New DataColumnParameter(defEmotion, pEmotion)
 Dim paramHealth As DataColumnParameter = New DataColumnParameter(defHealth, pHealth)
 Dim paramSpiritual As DataColumnParameter = New DataColumnParameter(defSpiritual, pSpiritual)
 Dim paramSocial As DataColumnParameter = New DataColumnParameter(defSocial, pSocial)
 Dim paramTalent As DataColumnParameter = New DataColumnParameter(defTalent, pTalent)
 Dim paramObservations As DataColumnParameter = New DataColumnParameter(defObservations, pObservations)
 Dim paramChristSmilesFeedBack As DataColumnParameter = New DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterVisitationID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramIsPresent.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramEducation.getSQLQuotedValueForAdd(),
paramEmotion.getSQLQuotedValueForAdd(),
paramHealth.getSQLQuotedValueForAdd(),
paramSpiritual.getSQLQuotedValueForAdd(),
paramSocial.getSQLQuotedValueForAdd(),
paramTalent.getSQLQuotedValueForAdd(),
paramObservations.getSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.getSQLQuotedValueForAdd(),
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
Public Shared Function add(ByVal pCenterVisitationID As Int32,
ByVal pBeneficiaryID As Int32,
ByVal pIsPresent As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32,
Optional ByVal pPictureStoredPath As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEducation As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pEmotion As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pHealth As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSpiritual As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pSocial As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pTalent As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pObservations As Object = DataColumnNullParamValue.NULL_VALUE,
Optional ByVal pChristSmilesFeedBack As Object = DataColumnNullParamValue.NULL_VALUE) As Boolean

Try

 Dim paramCenterVisitationID As DataColumnParameter = New DataColumnParameter(defCenterVisitationID, pCenterVisitationID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramIsPresent As DataColumnParameter = New DataColumnParameter(defIsPresent, pIsPresent)
 Dim paramPictureStoredPath As DataColumnParameter = New DataColumnParameter(defPictureStoredPath, pPictureStoredPath)
 Dim paramEducation As DataColumnParameter = New DataColumnParameter(defEducation, pEducation)
 Dim paramEmotion As DataColumnParameter = New DataColumnParameter(defEmotion, pEmotion)
 Dim paramHealth As DataColumnParameter = New DataColumnParameter(defHealth, pHealth)
 Dim paramSpiritual As DataColumnParameter = New DataColumnParameter(defSpiritual, pSpiritual)
 Dim paramSocial As DataColumnParameter = New DataColumnParameter(defSocial, pSocial)
 Dim paramTalent As DataColumnParameter = New DataColumnParameter(defTalent, pTalent)
 Dim paramObservations As DataColumnParameter = New DataColumnParameter(defObservations, pObservations)
 Dim paramChristSmilesFeedBack As DataColumnParameter = New DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([CenterVisitationID],[BeneficiaryID],[IsPresent],[PictureStoredPath],[Education],[Emotion],[Health],[Spiritual],[Social],[Talent],[Observations],[ChristSmilesFeedBack],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}) ", TABLE_NAME,paramCenterVisitationID.getSQLQuotedValueForAdd(),
paramBeneficiaryID.getSQLQuotedValueForAdd(),
paramIsPresent.getSQLQuotedValueForAdd(),
paramPictureStoredPath.getSQLQuotedValueForAdd(),
paramEducation.getSQLQuotedValueForAdd(),
paramEmotion.getSQLQuotedValueForAdd(),
paramHealth.getSQLQuotedValueForAdd(),
paramSpiritual.getSQLQuotedValueForAdd(),
paramSocial.getSQLQuotedValueForAdd(),
paramTalent.getSQLQuotedValueForAdd(),
paramObservations.getSQLQuotedValueForAdd(),
paramChristSmilesFeedBack.getSQLQuotedValueForAdd(),
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
Optional ByVal pCenterVisitationID As Object=Nothing,
Optional ByVal pBeneficiaryID As Object=Nothing,
Optional ByVal pIsPresent As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing,
Optional ByVal pPictureStoredPath As Object=Nothing,
Optional ByVal pEducation As Object=Nothing,
Optional ByVal pEmotion As Object=Nothing,
Optional ByVal pHealth As Object=Nothing,
Optional ByVal pSpiritual As Object=Nothing,
Optional ByVal pSocial As Object=Nothing,
Optional ByVal pTalent As Object=Nothing,
Optional ByVal pObservations As Object=Nothing,
Optional ByVal pChristSmilesFeedBack As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCenterVisitationID As DataColumnParameter = New DataColumnParameter(defCenterVisitationID, pCenterVisitationID)
 Dim paramBeneficiaryID As DataColumnParameter = New DataColumnParameter(defBeneficiaryID, pBeneficiaryID)
 Dim paramIsPresent As DataColumnParameter = New DataColumnParameter(defIsPresent, pIsPresent)
 Dim paramPictureStoredPath As DataColumnParameter = New DataColumnParameter(defPictureStoredPath, pPictureStoredPath)
 Dim paramEducation As DataColumnParameter = New DataColumnParameter(defEducation, pEducation)
 Dim paramEmotion As DataColumnParameter = New DataColumnParameter(defEmotion, pEmotion)
 Dim paramHealth As DataColumnParameter = New DataColumnParameter(defHealth, pHealth)
 Dim paramSpiritual As DataColumnParameter = New DataColumnParameter(defSpiritual, pSpiritual)
 Dim paramSocial As DataColumnParameter = New DataColumnParameter(defSocial, pSocial)
 Dim paramTalent As DataColumnParameter = New DataColumnParameter(defTalent, pTalent)
 Dim paramObservations As DataColumnParameter = New DataColumnParameter(defObservations, pObservations)
 Dim paramChristSmilesFeedBack As DataColumnParameter = New DataColumnParameter(defChristSmilesFeedBack, pChristSmilesFeedBack)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [CenterVisitationID]={2},[BeneficiaryID]={3},[IsPresent]={4},[PictureStoredPath]={5},[Education]={6},[Emotion]={7},[Health]={8},[Spiritual]={9},[Social]={10},[Talent]={11},[Observations]={12},[ChristSmilesFeedBack]={13},[CreatedAt]={14},[UpdatedAt]={15},[CreatedByID]={16},[UpdatedByID]={17} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCenterVisitationID.getSQLQuotedValueForUpdate(),
paramBeneficiaryID.getSQLQuotedValueForUpdate(),
paramIsPresent.getSQLQuotedValueForUpdate(),
paramPictureStoredPath.getSQLQuotedValueForUpdate(),
paramEducation.getSQLQuotedValueForUpdate(),
paramEmotion.getSQLQuotedValueForUpdate(),
paramHealth.getSQLQuotedValueForUpdate(),
paramSpiritual.getSQLQuotedValueForUpdate(),
paramSocial.getSQLQuotedValueForUpdate(),
paramTalent.getSQLQuotedValueForUpdate(),
paramObservations.getSQLQuotedValueForUpdate(),
paramChristSmilesFeedBack.getSQLQuotedValueForUpdate(),
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
