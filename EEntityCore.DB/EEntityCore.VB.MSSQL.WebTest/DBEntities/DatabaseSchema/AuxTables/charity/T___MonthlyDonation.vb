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

Public Class T___MonthlyDonation
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBTableDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.PRIMARY) 
  defCenterID = New DataColumnDefinition(TableColumnNames.CenterID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defResidingPastorID = New DataColumnDefinition(TableColumnNames.ResidingPastorID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defBankID = New DataColumnDefinition(TableColumnNames.BankID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defAccountNumber = New DataColumnDefinition(TableColumnNames.AccountNumber.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDonationYear = New DataColumnDefinition(TableColumnNames.DonationYear.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDonationMonth = New DataColumnDefinition(TableColumnNames.DonationMonth.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsApproved = New DataColumnDefinition(TableColumnNames.IsApproved.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsDisbursed = New DataColumnDefinition(TableColumnNames.IsDisbursed.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedAt = New DataColumnDefinition(TableColumnNames.CreatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defUpdatedAt = New DataColumnDefinition(TableColumnNames.UpdatedAt.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCreatedByID = New DataColumnDefinition(TableColumnNames.CreatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 
  defUpdatedByID = New DataColumnDefinition(TableColumnNames.UpdatedByID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.FOREIGN) 


  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defCenterID.ColumnName, defCenterID) 
  ColumnDefns.Add(defResidingPastorID.ColumnName, defResidingPastorID) 
  ColumnDefns.Add(defBankID.ColumnName, defBankID) 
  ColumnDefns.Add(defAccountNumber.ColumnName, defAccountNumber) 
  ColumnDefns.Add(defDonationYear.ColumnName, defDonationYear) 
  ColumnDefns.Add(defDonationMonth.ColumnName, defDonationMonth) 
  ColumnDefns.Add(defIsApproved.ColumnName, defIsApproved) 
  ColumnDefns.Add(defIsDisbursed.ColumnName, defIsDisbursed) 
  ColumnDefns.Add(defCreatedAt.ColumnName, defCreatedAt) 
  ColumnDefns.Add(defUpdatedAt.ColumnName, defUpdatedAt) 
  ColumnDefns.Add(defCreatedByID.ColumnName, defCreatedByID) 
  ColumnDefns.Add(defUpdatedByID.ColumnName, defUpdatedByID) 
                  
            ForeignKeys = New List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)()                  
                  

            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_UpdatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CenterID", False, IDBTableDefinitionPlugIn.ReferentialAction.CASCADE,                  
                    "charity.MonthlyDonation", "charity.Center"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_ResidingPastorID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "charity.ResidingPastor"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_CreatedByID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "auth.Users"                  
                            ))                  
            ForeignKeys.Add(New IDBTableDefinitionPlugIn.ForeignKeyDefinition(                  
                    "fk_charity_MonthlyDonation_BankID", False, IDBTableDefinitionPlugIn.ReferentialAction.NO_ACTION,                  
                    "charity.MonthlyDonation", "common.Bank"                  
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

       Public Const TABLE_NAME As String = "charity.MonthlyDonation"
       Public Const MonthlyDonation__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation"
       Public Const MonthlyDonation__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [ID], [CenterID], [ResidingPastorID], [BankID], [AccountNumber], [DonationYear], [DonationMonth], [IsApproved], [IsDisbursed], [CreatedAt], [UpdatedAt], [CreatedByID], [UpdatedByID] FROM MonthlyDonation"


       Public Enum TableColumnNames

           [ID]
           [CenterID]
           [ResidingPastorID]
           [BankID]
           [AccountNumber]
           [DonationYear]
           [DonationMonth]
           [IsApproved]
           [IsDisbursed]
           [CreatedAt]
           [UpdatedAt]
           [CreatedByID]
           [UpdatedByID]
       End Enum 



       Public Enum TableConstraints

           pk_charity_MonthlyDonation 
           fk_charity_MonthlyDonation_UpdatedByID 
           fk_charity_MonthlyDonation_CenterID 
           fk_charity_MonthlyDonation_ResidingPastorID 
           fk_charity_MonthlyDonation_CreatedByID 
           fk_charity_MonthlyDonation_BankID 
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ForeignKeys As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defCenterID As DataColumnDefinition
       Public Shared ReadOnly defResidingPastorID As DataColumnDefinition
       Public Shared ReadOnly defBankID As DataColumnDefinition
       Public Shared ReadOnly defAccountNumber As DataColumnDefinition
       Public Shared ReadOnly defDonationYear As DataColumnDefinition
       Public Shared ReadOnly defDonationMonth As DataColumnDefinition
       Public Shared ReadOnly defIsApproved As DataColumnDefinition
       Public Shared ReadOnly defIsDisbursed As DataColumnDefinition
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


       Public ReadOnly Property [ResidingPastorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ResidingPastorID.ToString()))
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


       Public ReadOnly Property [DonationYear] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DonationYear.ToString()))
           End Get
       End Property


       Public ReadOnly Property [DonationMonth] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.DonationMonth.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsApproved] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsApproved.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsDisbursed] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsDisbursed.ToString()))
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
        Public Function getFirstRow() As T___MonthlyDonation                  
            If Me.hasRows() Then Return New T___MonthlyDonation(Me.AllRows(0))                  
            Return New T___MonthlyDonation()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As T___MonthlyDonation                  
            Return New T___MonthlyDonation(DBConnectInterface.GetDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As T___MonthlyDonation                  
            Return New T___MonthlyDonation(DBConnectInterface.GetDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As T___MonthlyDonation                  
            Return New T___MonthlyDonation(Me.RawTable, T___MonthlyDonation.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As T___MonthlyDonation,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As T___MonthlyDonation,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As T___MonthlyDonation                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New T___MonthlyDonation(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___MonthlyDonation(drst.CopyToDataTable(),                  
                    T___MonthlyDonation.TABLE_NAME)                  
                Return New T___MonthlyDonation()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New T___MonthlyDonation()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As T___MonthlyDonation                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New T___MonthlyDonation(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New T___MonthlyDonation(drst.CopyToDataTable(),                  
                    T___MonthlyDonation.TABLE_NAME)                  
                Return New T___MonthlyDonation()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New T___MonthlyDonation()                  
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
            Return MonthlyDonation__NO__BINARY___SQL_FILL_QUERY                  
        End Function                  
                  
                  
                  
#End Region                  
                  
                  




Public Shared Function addNewDefault(ByVal pCenterID As Int32,
ByVal pResidingPastorID As Int32,
ByVal pBankID As Int32,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramResidingPastorID As DataColumnParameter = New DataColumnParameter(defResidingPastorID, pResidingPastorID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, defAccountNumber.DefaultValue)
 Dim paramDonationYear As DataColumnParameter = New DataColumnParameter(defDonationYear, defDonationYear.DefaultValue)
 Dim paramDonationMonth As DataColumnParameter = New DataColumnParameter(defDonationMonth, defDonationMonth.DefaultValue)
 Dim paramIsApproved As DataColumnParameter = New DataColumnParameter(defIsApproved, defIsApproved.DefaultValue)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, defIsDisbursed.DefaultValue)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, defCreatedAt.DefaultValue)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, defUpdatedAt.DefaultValue)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramResidingPastorID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramDonationYear.getSQLQuotedValueForAdd(),
paramDonationMonth.getSQLQuotedValueForAdd(),
paramIsApproved.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
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
ByVal pResidingPastorID As Int32,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pDonationYear As Int32,
ByVal pDonationMonth As Int32,
ByVal pIsApproved As Boolean,
ByVal pIsDisbursed As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, DatabaseInit.DBConnectInterface.GetDBConn().GETNewID(TABLE_NAME))
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramResidingPastorID As DataColumnParameter = New DataColumnParameter(defResidingPastorID, pResidingPastorID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramDonationYear As DataColumnParameter = New DataColumnParameter(defDonationYear, pDonationYear)
 Dim paramDonationMonth As DataColumnParameter = New DataColumnParameter(defDonationMonth, pDonationMonth)
 Dim paramIsApproved As DataColumnParameter = New DataColumnParameter(defIsApproved, pIsApproved)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramResidingPastorID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramDonationYear.getSQLQuotedValueForAdd(),
paramDonationMonth.getSQLQuotedValueForAdd(),
paramIsApproved.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
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
ByVal pResidingPastorID As Int32,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pDonationYear As Int32,
ByVal pDonationMonth As Int32,
ByVal pIsApproved As Boolean,
ByVal pIsDisbursed As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Int32

Try

 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pParseID )
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramResidingPastorID As DataColumnParameter = New DataColumnParameter(defResidingPastorID, pResidingPastorID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramDonationYear As DataColumnParameter = New DataColumnParameter(defDonationYear, pDonationYear)
 Dim paramDonationMonth As DataColumnParameter = New DataColumnParameter(defDonationMonth, pDonationMonth)
 Dim paramIsApproved As DataColumnParameter = New DataColumnParameter(defIsApproved, pIsApproved)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format(" SET IDENTITY_INSERT {0} ON INSERT INTO {0}([ID],[CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}) SET IDENTITY_INSERT {0} OFF ", TABLE_NAME,paramID.getSQLQuotedValueForAdd(),
paramCenterID.getSQLQuotedValueForAdd(),
paramResidingPastorID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramDonationYear.getSQLQuotedValueForAdd(),
paramDonationMonth.getSQLQuotedValueForAdd(),
paramIsApproved.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
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
ByVal pResidingPastorID As Int32,
ByVal pBankID As Int32,
ByVal pAccountNumber As String,
ByVal pDonationYear As Int32,
ByVal pDonationMonth As Int32,
ByVal pIsApproved As Boolean,
ByVal pIsDisbursed As Boolean,
ByVal pCreatedAt As DateTime,
ByVal pUpdatedAt As DateTime,
ByVal pCreatedByID As Int32,
ByVal pUpdatedByID As Int32) As Boolean

Try

 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramResidingPastorID As DataColumnParameter = New DataColumnParameter(defResidingPastorID, pResidingPastorID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramDonationYear As DataColumnParameter = New DataColumnParameter(defDonationYear, pDonationYear)
 Dim paramDonationMonth As DataColumnParameter = New DataColumnParameter(defDonationMonth, pDonationMonth)
 Dim paramIsApproved As DataColumnParameter = New DataColumnParameter(defIsApproved, pIsApproved)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


Return DBConnectInterface.GetDBConn().dbExec(
     String.Format("INSERT INTO {0}([CenterID],[ResidingPastorID],[BankID],[AccountNumber],[DonationYear],[DonationMonth],[IsApproved],[IsDisbursed],[CreatedAt],[UpdatedAt],[CreatedByID],[UpdatedByID]) VALUES({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}) ", TABLE_NAME,paramCenterID.getSQLQuotedValueForAdd(),
paramResidingPastorID.getSQLQuotedValueForAdd(),
paramBankID.getSQLQuotedValueForAdd(),
paramAccountNumber.getSQLQuotedValueForAdd(),
paramDonationYear.getSQLQuotedValueForAdd(),
paramDonationMonth.getSQLQuotedValueForAdd(),
paramIsApproved.getSQLQuotedValueForAdd(),
paramIsDisbursed.getSQLQuotedValueForAdd(),
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
Optional ByVal pResidingPastorID As Object=Nothing,
Optional ByVal pBankID As Object=Nothing,
Optional ByVal pAccountNumber As Object=Nothing,
Optional ByVal pDonationYear As Object=Nothing,
Optional ByVal pDonationMonth As Object=Nothing,
Optional ByVal pIsApproved As Object=Nothing,
Optional ByVal pIsDisbursed As Object=Nothing,
Optional ByVal pCreatedAt As Object=Nothing,
Optional ByVal pUpdatedAt As Object=Nothing,
Optional ByVal pCreatedByID As Object=Nothing,
Optional ByVal pUpdatedByID As Object=Nothing) As Boolean

Try


 Dim paramID As DataColumnParameter = New DataColumnParameter(defID, pID)
 Dim paramCenterID As DataColumnParameter = New DataColumnParameter(defCenterID, pCenterID)
 Dim paramResidingPastorID As DataColumnParameter = New DataColumnParameter(defResidingPastorID, pResidingPastorID)
 Dim paramBankID As DataColumnParameter = New DataColumnParameter(defBankID, pBankID)
 Dim paramAccountNumber As DataColumnParameter = New DataColumnParameter(defAccountNumber, pAccountNumber)
 Dim paramDonationYear As DataColumnParameter = New DataColumnParameter(defDonationYear, pDonationYear)
 Dim paramDonationMonth As DataColumnParameter = New DataColumnParameter(defDonationMonth, pDonationMonth)
 Dim paramIsApproved As DataColumnParameter = New DataColumnParameter(defIsApproved, pIsApproved)
 Dim paramIsDisbursed As DataColumnParameter = New DataColumnParameter(defIsDisbursed, pIsDisbursed)
 Dim paramCreatedAt As DataColumnParameter = New DataColumnParameter(defCreatedAt, pCreatedAt)
 Dim paramUpdatedAt As DataColumnParameter = New DataColumnParameter(defUpdatedAt, pUpdatedAt)
 Dim paramCreatedByID As DataColumnParameter = New DataColumnParameter(defCreatedByID, pCreatedByID)
 Dim paramUpdatedByID As DataColumnParameter = New DataColumnParameter(defUpdatedByID, pUpdatedByID)


DBConnectInterface.GetDBConn().dbExec(
     String.Format("UPDATE {0} SET [CenterID]={2},[ResidingPastorID]={3},[BankID]={4},[AccountNumber]={5},[DonationYear]={6},[DonationMonth]={7},[IsApproved]={8},[IsDisbursed]={9},[CreatedAt]={10},[UpdatedAt]={11},[CreatedByID]={12},[UpdatedByID]={13} WHERE ID={1} ", TABLE_NAME, paramID.getSQLQuotedValueForUpdate(),paramCenterID.getSQLQuotedValueForUpdate(),
paramResidingPastorID.getSQLQuotedValueForUpdate(),
paramBankID.getSQLQuotedValueForUpdate(),
paramAccountNumber.getSQLQuotedValueForUpdate(),
paramDonationYear.getSQLQuotedValueForUpdate(),
paramDonationMonth.getSQLQuotedValueForUpdate(),
paramIsApproved.getSQLQuotedValueForUpdate(),
paramIsDisbursed.getSQLQuotedValueForUpdate(),
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
