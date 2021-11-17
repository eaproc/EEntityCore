Imports EEntityCore.DB.Abstracts                   
Imports EEntityCore.DB.Modules                  
Imports ELibrary.Standard.VB.Modules                  
Imports ELibrary.Standard.VB.Objects                  
Imports ELibrary.Standard.VB.Types                  
Imports System.Data                  
                  
Imports EEntityCore.DB.MSSQL.Interfaces                   
                  

Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.DatabaseInit
Imports EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema

Namespace EEntityCore.VB.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxViews.academic

Public Class V___TermView
        Inherits Sample__Table                   
        Implements IDataColumnDefinitionsHolder, IDBViewDefinitionPlugIn                  

#Region "Constructors" 



Shared Sub New()
ColumnDefns = New Dictionary(Of String, DataColumnDefinition)()
  defName = New DataColumnDefinition(TableColumnNames.Name.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermOrder = New DataColumnDefinition(TableColumnNames.TermOrder.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAcademicSession = New DataColumnDefinition(TableColumnNames.AcademicSession.ToString(), GetType(String), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defIsActive = New DataColumnDefinition(TableColumnNames.IsActive.ToString(), GetType(Boolean), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defAcademicSessionID = New DataColumnDefinition(TableColumnNames.AcademicSessionID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermStartDate = New DataColumnDefinition(TableColumnNames.TermStartDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermEndDate = New DataColumnDefinition(TableColumnNames.TermEndDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSessionStartDate = New DataColumnDefinition(TableColumnNames.SessionStartDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defSessionEndDate = New DataColumnDefinition(TableColumnNames.SessionEndDate.ToString(), GetType(DateTime), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defTermOrderID = New DataColumnDefinition(TableColumnNames.TermOrderID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defID = New DataColumnDefinition(TableColumnNames.ID.ToString(), GetType(Int32), False, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 
  defDescription = New DataColumnDefinition(TableColumnNames.Description.ToString(), GetType(String), True, Nothing,DataColumnDefinition.ConstraintTypes.UNKNOWN) 


  ColumnDefns.Add(defName.ColumnName, defName) 
  ColumnDefns.Add(defTermOrder.ColumnName, defTermOrder) 
  ColumnDefns.Add(defAcademicSession.ColumnName, defAcademicSession) 
  ColumnDefns.Add(defIsActive.ColumnName, defIsActive) 
  ColumnDefns.Add(defAcademicSessionID.ColumnName, defAcademicSessionID) 
  ColumnDefns.Add(defTermStartDate.ColumnName, defTermStartDate) 
  ColumnDefns.Add(defTermEndDate.ColumnName, defTermEndDate) 
  ColumnDefns.Add(defSessionStartDate.ColumnName, defSessionStartDate) 
  ColumnDefns.Add(defSessionEndDate.ColumnName, defSessionEndDate) 
  ColumnDefns.Add(defTermOrderID.ColumnName, defTermOrderID) 
  ColumnDefns.Add(defID.ColumnName, defID) 
  ColumnDefns.Add(defDescription.ColumnName, defDescription) 
            ReferencedTableNames = New List(Of String)()                  
            ReferencedTableNames.Add("academic.AcademicSession")                  
            ReferencedTableNames.Add("academic.Term")                  
            ReferencedTableNames.Add("academic.TermOrder")                  

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

       Public Const TABLE_NAME As String = "academic.TermView"
       Public Const TermView__NO__BINARY___SQL_FILL_QUERY As String = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM TermView"
       Public Const TermView__ALL_COLUMNS___SQL_FILL_QUERY As String = "SELECT [Name], [TermOrder], [AcademicSession], [IsActive], [AcademicSessionID], [TermStartDate], [TermEndDate], [SessionStartDate], [SessionEndDate], [TermOrderID], [ID], [Description] FROM TermView"


       Public Enum TableColumnNames

           [Name]
           [TermOrder]
           [AcademicSession]
           [IsActive]
           [AcademicSessionID]
           [TermStartDate]
           [TermEndDate]
           [SessionStartDate]
           [SessionEndDate]
           [TermOrderID]
           [ID]
           [Description]
       End Enum 


#End Region 


#Region "Properties" 

        Private Shared ReferencedTableNames As List(Of String)                  

       Private shared ColumnDefns As Dictionary(Of String, DataColumnDefinition) 

       Public Shared ReadOnly defName As DataColumnDefinition
       Public Shared ReadOnly defTermOrder As DataColumnDefinition
       Public Shared ReadOnly defAcademicSession As DataColumnDefinition
       Public Shared ReadOnly defIsActive As DataColumnDefinition
       Public Shared ReadOnly defAcademicSessionID As DataColumnDefinition
       Public Shared ReadOnly defTermStartDate As DataColumnDefinition
       Public Shared ReadOnly defTermEndDate As DataColumnDefinition
       Public Shared ReadOnly defSessionStartDate As DataColumnDefinition
       Public Shared ReadOnly defSessionEndDate As DataColumnDefinition
       Public Shared ReadOnly defTermOrderID As DataColumnDefinition
       Public Shared ReadOnly defID As DataColumnDefinition
       Public Shared ReadOnly defDescription As DataColumnDefinition

       Public ReadOnly Property [Name] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Name.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermOrder] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.TermOrder.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AcademicSession] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.AcademicSession.ToString()))
           End Get
       End Property


       Public ReadOnly Property [IsActive] As Boolean
           Get
               If Not Me.isValidRow then Return FALSE                          
               Return EBoolean.valueOf(Me.TargettedRow(TableColumnNames.IsActive.ToString()))
           End Get
       End Property


       Public ReadOnly Property [AcademicSessionID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.AcademicSessionID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermStartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermStartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermEndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.TermEndDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SessionStartDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.SessionStartDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [SessionEndDate] As NullableDateTime
           Get
               If Not Me.isValidRow then Return New NullableDateTime(CDate(Nothing))                          
               Return  New NullableDateTime(Me.TargettedRow(TableColumnNames.SessionEndDate.ToString()))
           End Get
       End Property


       Public ReadOnly Property [TermOrderID] As Int32
           Get
               If Not Me.isValidRow then Return 0                          
               Return EInt.valueOf(Me.TargettedRow(TableColumnNames.TermOrderID.ToString()))
           End Get
       End Property


       Public ReadOnly Property [Description] As String
           Get
               If Not Me.isValidRow then Return String.Empty                          
               Return EStrings.valueOf(Me.TargettedRow(TableColumnNames.Description.ToString()))
           End Get
       End Property


#End Region

#Region "Methods"                  
                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getFirstRow() As V___TermView                  
            If Me.hasRows() Then Return New V___TermView(Me.AllRows(0))                  
            Return New V___TermView()                  
        End Function                  
                  
                  
        Public Shared Function getFullTable() As V___TermView                  
            Return New V___TermView(DBConnectInterface.getDBConn(), TABLE_NAME)                  
        End Function                  
                  
        Public Shared Function getRowWhereIDUsingSQL(ByVal pID As Int32) As V___TermView                  
            Return New V___TermView(DBConnectInterface.getDBConn(),                  
                                               TABLE_NAME,                  
                                               String.Format("SELECT * FROM {0} WHERE ID={1}", TABLE_NAME, pID)                  
                                               ).getFirstRow()                  
        End Function                  
                  
        Public Function getRowWhereID(pID As Int32) As V___TermView                  
            Return New V___TermView(Me.RawTable, V___TermView.TABLE_NAME, pID)                  
        End Function                  
                  
                  
        Private Function IsAllRowEqual(ByVal pRow As V___TermView,                  
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
                  
        Private Function IsAnyRowEqual(ByVal pRow As V___TermView,                  
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
        Public Function getAllRowsEquals(ParamArray pParams() As DataColumnParameter) As V___TermView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAllRowEqual(New V___TermView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___TermView(drst.CopyToDataTable(),                  
                    V___TermView.TABLE_NAME)                  
                Return New V___TermView()                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM                errorMsg(ex.Message, 1)                                     
                Return New V___TermView()                  
            End Try                  
        End Function                  
                  
        ''' <summary>                                     
        ''' Returns Empty class on failure                                     
        ''' </summary>                                     
        ''' <returns></returns>                                     
        ''' <remarks></remarks>                                     
        Public Function getAllRowsAny(ParamArray pParams() As DataColumnParameter) As V___TermView                  
            If pParams Is Nothing OrElse pParams.Count = 0 OrElse Not Me.hasRows() Then Return Me                  
            Try                  
                  
                Dim drst As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows                  
                Where Me.IsAnyRowEqual(New V___TermView(dr), pParams)                  
                Select dr                  
                  
                  
                If drst IsNot Nothing AndAlso drst.Count() > 0 Then Return New V___TermView(drst.CopyToDataTable(),                  
                    V___TermView.TABLE_NAME)                  
                Return New V___TermView()                  
                  
            Catch ex As Exception                  
                Logger.Print(ex)                  
                REM errorMsg(ex.Message, 1)                                     
                Return New V___TermView()                  
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
