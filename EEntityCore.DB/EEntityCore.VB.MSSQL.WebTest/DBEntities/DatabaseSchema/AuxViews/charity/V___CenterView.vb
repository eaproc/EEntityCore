Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxViews.charity

Public Class V___CenterView
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defName = New DataColumnDefinition(TableColumnNames.Name.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAddress = New DataColumnDefinition(TableColumnNames.Address.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorName = New DataColumnDefinition(TableColumnNames.PastorName.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorEmail = New DataColumnDefinition(TableColumnNames.PastorEmail.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorPhone = New DataColumnDefinition(TableColumnNames.PastorPhone.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorAddress = New DataColumnDefinition(TableColumnNames.PastorAddress.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorID = New DataColumnDefinition(TableColumnNames.PastorID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defPastorPersonID = New DataColumnDefinition(TableColumnNames.PastorPersonID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defBeneficiaryCount = New DataColumnDefinition(TableColumnNames.BeneficiaryCount.ToString(), GetType(Int32), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defChurchCapacity = New DataColumnDefinition(TableColumnNames.ChurchCapacity.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCenterStatusID = New DataColumnDefinition(TableColumnNames.CenterStatusID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defCenterStatus = New DataColumnDefinition(TableColumnNames.CenterStatus.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defName.ColumnName, defName) 
  ColumnDefns.Add(defAddress.ColumnName, defAddress) 
  ColumnDefns.Add(defPastorName.ColumnName, defPastorName) 
  ColumnDefns.Add(defPastorEmail.ColumnName, defPastorEmail) 
  ColumnDefns.Add(defPastorPhone.ColumnName, defPastorPhone) 
  ColumnDefns.Add(defPastorAddress.ColumnName, defPastorAddress) 
  ColumnDefns.Add(defPastorID.ColumnName, defPastorID) 
  ColumnDefns.Add(defPastorPersonID.ColumnName, defPastorPersonID) 
  ColumnDefns.Add(defBeneficiaryCount.ColumnName, defBeneficiaryCount) 
  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defChurchCapacity.ColumnName, defChurchCapacity) 
  ColumnDefns.Add(defCenterStatusID.ColumnName, defCenterStatusID) 
  ColumnDefns.Add(defCenterStatus.ColumnName, defCenterStatus) 
            ReferencedTableNames = New List(Of String)()                  
            ReferencedTableNames.Add("charity.Beneficiary")                  
            ReferencedTableNames.Add("charity.Center")                  
            ReferencedTableNames.Add("charity.CenterStatus")                  
            ReferencedTableNames.Add("charity.ResidingPastor")                  
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

       Public Const TABLE_NAME As String = "charity.CenterView"
       Public Const CenterView__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM CenterView"
       Public Const CenterView__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [Name], [Address], [PastorName], [PastorEmail], [PastorPhone], [PastorAddress], [PastorID], [PastorPersonID], [BeneficiaryCount], [ID], [ChurchCapacity], [CenterStatusID], [CenterStatus] FROM CenterView"


       Public Enum TableColumnNames

           [Name]
           [Address]
           [PastorName]
           [PastorEmail]
           [PastorPhone]
           [PastorAddress]
           [PastorID]
           [PastorPersonID]
           [BeneficiaryCount]
           [ID]
           [ChurchCapacity]
           [CenterStatusID]
           [CenterStatus]
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ReferencedTableNames As List(Of String)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defName As DataColumnDefinition
       Public Shared ReadOnly defAddress As DataColumnDefinition
       Public Shared ReadOnly defPastorName As DataColumnDefinition
       Public Shared ReadOnly defPastorEmail As DataColumnDefinition
       Public Shared ReadOnly defPastorPhone As DataColumnDefinition
       Public Shared ReadOnly defPastorAddress As DataColumnDefinition
       Public Shared ReadOnly defPastorID As DataColumnDefinition
       Public Shared ReadOnly defPastorPersonID As DataColumnDefinition
       Public Shared ReadOnly defBeneficiaryCount As DataColumnDefinition
       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defChurchCapacity As DataColumnDefinition
       Public Shared ReadOnly defCenterStatusID As DataColumnDefinition
       Public Shared ReadOnly defCenterStatus As DataColumnDefinition

       Public ReadOnly Property [Name] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Name.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Address] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Address.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorName] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PastorName.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorEmail] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PastorEmail.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorPhone] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PastorPhone.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorAddress] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.PastorAddress.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PastorID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [PastorPersonID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.PastorPersonID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [BeneficiaryCount] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.BeneficiaryCount.ToString()))
           End Get
       End Property


       Public ReadOnly Property [ChurchCapacity] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.ChurchCapacity.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CenterStatusID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.CenterStatusID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [CenterStatus] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.CenterStatus.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As V___CenterView                  
            If Me.hasRows() Then Return New V___CenterView(Me.AllRows(0))                  
            Return New V___CenterView()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As V___CenterView                  
            Return New V___CenterView(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As V___CenterView                  
            Return New V___CenterView(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As V___CenterView                  
            Return New V___CenterView(Me.RawTable, V___CenterView.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As V___CenterView,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As V___CenterView,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As V___CenterView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New V___CenterView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___CenterView(drst.CopyToDataTable(),                  
                    V___CenterView.TABLE_NAME)                  
                Return New V___CenterView()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New V___CenterView()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As V___CenterView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New V___CenterView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___CenterView(drst.CopyToDataTable(),                  
                    V___CenterView.TABLE_NAME)                  
                Return New V___CenterView()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New V___CenterView()                  
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
