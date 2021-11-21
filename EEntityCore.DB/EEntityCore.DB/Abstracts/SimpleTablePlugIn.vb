Imports System.Data
Imports ELibrary.Standard.VB.Objects
Imports EEntityCore.DB.Abstracts.All__DBs
Imports ELibrary.Standard.VB
Imports EEntityCore.DB.Modules

Namespace Abstracts


    ''' <summary>
    ''' Simple Table with target row capability. Entity Template for Generators
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class SimpleTablePlugIn

#Region "Enums & Consts"

        Public Enum RecordAccessibility
            ''' <summary>
            ''' Access table with SQL QUERIES and target record. reloadable with DBConn Valid
            ''' </summary>
            ''' <remarks></remarks>
            FULL_ACCESS
            ''' <summary>
            ''' Access table and target record via direct record (DataRow(s)). reloadable if dbConn is valid
            ''' </summary>
            ''' <remarks></remarks>
            PARTIAL_ACCESS
            ' '' ''' <summary>
            ' '' ''' Access table and target record via direcet record. reloadable
            ' '' ''' </summary>
            ' '' ''' <remarks></remarks>
            ' ''PARTIAL_RELOADABLE_ACCESS
            ' '' ''' <summary>
            ' '' ''' Access table and target record. NOT reloadable [Cached]
            ' '' ''' </summary>
            ' '' ''' <remarks></remarks>
            ' ''PARTIAL_FIXED_ACCESS
            ''' <summary>
            ''' Access target record only. NOT reloadable. No DBConn
            ''' </summary>
            ''' <remarks></remarks>
            SHALLOW_ACCESS

            ''' <summary>
            ''' Signifies EMPTY UNDECIDED CLASS
            ''' </summary>
            ''' <remarks></remarks>
            UNKNOWN

        End Enum


        Public Const DO__NOT____TARGET__ANY_ROWID As Int32 = 0

#End Region

#Region "Contructors"

        Public Sub New()
            Me._OpenAccessFor = RecordAccessibility.UNKNOWN
        End Sub


#Region "Full Access"

        '   Full Access means initial data is loaded directly from database, so DBConn MUST be provided

        ''' <summary>
        ''' FULL ACCESS. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal DBConn As All__DBs)
            Me.New(DBConn, DO__NOT____TARGET__ANY_ROWID)
        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID">Only works if the table contains a column named ID</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal DBConn As All__DBs, ByVal pTargettedRowID As Int64)

            Me._OpenAccessFor = RecordAccessibility.FULL_ACCESS
            Me._____DbConn = DBConn

            REM try load first time
            Me.ReloadClass("SELECT * FROM " & Me.TableName)

            REM If no error then me.LoadID
            Me.LoadID(pTargettedRowID)

        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pDBConn As All__DBs, ByVal pSQL As String)
            Me.New(pDBConn, pSQL, DO__NOT____TARGET__ANY_ROWID)
        End Sub

        ''' <summary>
        ''' Full Access. This will load data with dbconn
        ''' </summary>
        ''' <param name="pDBConn"></param>
        ''' <param name="pTableName"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <param name="pSQL">Load table with your own SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pDBConn As All__DBs, ByVal pSQL As String, ByVal pTargettedRowID As Int64)

            Me._OpenAccessFor = RecordAccessibility.FULL_ACCESS
            Me._____DbConn = pDBConn

            REM try load first time
            Me.ReloadClass(pSQL)

            REM If no error then me.LoadID
            Me.LoadID(pTargettedRowID)

        End Sub

#End Region


#Region "Partial Access"

        ' Partial Simply means initial data is loaded directly from user but DBConn might be provided for reloadClass function to work
        ' Also can have more than one row
        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As DataRowCollection, ByVal pTargettedRowID As Int64)
            Me.New(pTableRows:=pTableRows.Cast(Of DataRow), pTargettedRowID:=pTargettedRowID)
        End Sub


        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow))
            Me.New(pTableRows, DO__NOT____TARGET__ANY_ROWID)
        End Sub


        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="pTableRows"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal pTableRows As IEnumerable(Of DataRow), ByVal pTargettedRowID As Int64)

            Me._OpenAccessFor = RecordAccessibility.PARTIAL_ACCESS

            If pTableRows IsNot Nothing AndAlso pTableRows.Count > 0 Then

                Try
                    Me.LoadFromRows(pTableRows)
                    If pTargettedRowID <> DO__NOT____TARGET__ANY_ROWID Then Me.LoadID(pTargettedRowID)

                Catch ex As Exception
                    Logger.Print("Error Converting from IEnumerable(of datarow) to Table", ex)
                End Try

            End If
        End Sub

        ''' <summary>
        ''' Partial Access
        ''' </summary>
        ''' <param name="FullTable"></param>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal FullTable As DataTable, ByVal pTargettedRowID As Int64)
            Me._OpenAccessFor = RecordAccessibility.PARTIAL_ACCESS

            '   Incase there is empty table
            Me.___RawTable = FullTable

            If FullTable IsNot Nothing AndAlso FullTable.Rows.Count > 0 Then
                Me.LoadID(pTargettedRowID)
            End If

        End Sub


#End Region


#Region "Shallow Access"
        '   In the real definition, shallow reference partial. Just that it means partial with no DBConn
        ' Shallow is always one row
        ''' <summary>
        ''' Shallow Access. Should always target this passed in
        ''' </summary>
        ''' <param name="TargettedRow"></param>
        ''' <remarks>Assuming this Row has a Column Called ID and It will be assigned</remarks>
        Public Sub New(ByVal TargettedRow As DataRow)
            Me.New(New DataRow() {TargettedRow}, pTargettedRowID:=DO__NOT____TARGET__ANY_ROWID)
            Me._OpenAccessFor = RecordAccessibility.SHALLOW_ACCESS
            If Me.HasRows() Then Me.TargettedRow_Cached = Me.AllRows(0)
        End Sub

#End Region



#End Region

#Region "Properties"

        ''' <summary>
        ''' Note: your table must have the column name ID for you to call this
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable ReadOnly Property ID As Int64
            Get
                If Not Me.IsTargettedRowValid Then Return 0
                Return Objects.ELong.valueOf(Me.TargettedRow(Me.NumericPrimaryKeyName))
            End Get
        End Property

        Public Overridable ReadOnly Property NumericPrimaryKeyName As String
            Get
                Return "ID"
            End Get
        End Property


        Protected LastSQL_Passed As String = String.Empty

        ''' <summary>
        ''' Database Connection
        ''' </summary>
        ''' <remarks></remarks>
        Private _____DbConn As All__DBs
        Public ReadOnly Property DBConn As All__DBs
            Get
                Return _____DbConn
            End Get
        End Property

        ''' <summary>
        ''' Only checks if numeric primary key column name is returned by this class not its physical presence in the current data rows
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property HasNumericPrimaryKeyColumn As Boolean
            Get
                Return EStrings.valueOf(Me.NumericPrimaryKeyName) <> String.Empty
            End Get
        End Property


        ''' <summary>
        ''' it is reloadable if db con is valid
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsDBConnValid As Boolean
            Get
                Return Me._____DbConn IsNot Nothing
            End Get
        End Property

        Public MustOverride ReadOnly Property TableName As String


        Private Property ___RawTable As DataTable
        ''' <summary>
        ''' It should always contain data. if there is data at all
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property RawTable As DataTable
            Get
                Return Me.___RawTable
            End Get
        End Property



        ''' <summary>
        ''' For Full Access and Partial. Only for caching selected row
        ''' </summary>
        ''' <remarks></remarks>
        Private TargettedRow_Cached As DataRow = Nothing

        ''' <summary>
        ''' Use this always to receive property. TargettedRow_Cached
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable ReadOnly Property TargettedRow As DataRow
            Get

                Return Me.TargettedRow_Cached
            End Get
        End Property


        Private _OpenAccessFor As RecordAccessibility
        Public ReadOnly Property OpenAccessFor As RecordAccessibility
            Get
                Return Me._OpenAccessFor
            End Get
            'Set(ByVal value As RecordAccessibility)
            '    Me._OpenAccessFor = value
            'End Set
        End Property


        ''' <summary>
        ''' It always returns the enumerated table
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property AllRows As IEnumerable(Of DataRow)
            Get
                If Me.RawTable Is Nothing OrElse Me.RawTable.Rows.Count = 0 Then Return Nothing
                Return From d As DataRow In Me.RawTable.AsEnumerable()
                       Select d

            End Get
        End Property


        Public ReadOnly Property RowCount As Int32
            Get
                If Me.HasRows() Then Return Me.AllRows.Count()
                Return 0
            End Get
        End Property

#End Region


#Region "Methods"


        Friend Function LoadGeneric(Of T As {SimpleTablePlugIn, New})(pDataRow As DataRow) As T
            Me.LoadFromRows(New DataRow() {pDataRow})
            If Me.HasRows() Then Me.TargettedRow_Cached = Me.AllRows(0)
            Me._OpenAccessFor = RecordAccessibility.SHALLOW_ACCESS
            Return Me
        End Function

        Private Sub LoadFromRows(pTableRows As IEnumerable(Of DataRow))
            Try
                Me.___RawTable = pTableRows.CopyToDataTable()
            Catch ex As Exception
                Logger.Print("Error Converting Rows to Table", ex)
            End Try
        End Sub


        ''' <summary>
        ''' Select from the pool of rows loaded the column with ID=pval
        ''' </summary>
        ''' <param name="pTargettedRowID"></param>
        ''' <remarks></remarks>
        Public Sub LoadID(pTargettedRowID As Int64)
            Try

                Me.TargettedRow_Cached = Nothing

                If Me.IsTableValid AndAlso pTargettedRowID <> DO__NOT____TARGET__ANY_ROWID _
                    AndAlso Me.HasNumericPrimaryKeyColumn AndAlso Me.RawTable.Columns.Contains(Me.NumericPrimaryKeyName) Then


                    Dim pMatch As IEnumerable(Of DataRow) = From d As DataRow In Me.AllRows
                                                            Where ELong.valueOf(d(Me.NumericPrimaryKeyName)) = pTargettedRowID
                                                            Select d


                    If pMatch.Count() > 0 Then Me.TargettedRow_Cached = pMatch(0)

                End If

            Catch ex As Exception
                Logger.Print("Selecting ID: " & pTargettedRowID, ex)
            End Try
        End Sub


        ''' <summary>
        ''' Checks if the Table is valid. In other contains any rows
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected Overridable Function IsTableValid() As Boolean
            Return Me.HasRows()
        End Function

        Public ReadOnly Property IsTargettedRowValid As Boolean
            Get
                Return Me.TargettedRow IsNot Nothing
            End Get
        End Property


        ''' <summary>
        ''' Use this only if you have valid Connection
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ReloadClass_usingLast_Passed_SQL()
            Me.ReloadClass(Me.LastSQL_Passed)
        End Sub

        
        ''' <summary>
        ''' Reloads the class with your supplied SQL or else uses SELECT * FROM TABLE. Throws exception. Reloads class and retarget class
        ''' </summary>
        ''' <param name="SQL">This sql is used to load the class if provided else it will select all from the table</param>
        ''' <remarks></remarks>
        Public Overridable Sub ReloadClass(Optional ByVal SQL As String = vbNullString)
            Me.___RawTable = Nothing
            Me.TargettedRow_Cached = Nothing

            Dim pLastID As Int64 = Me.ID

            Try

                If Me.DBConn Is Nothing Then Return


                Dim ds As DataSet
                If SQL = vbNullString OrElse SQL.Equals(String.Empty) Then
                    ds = Me.DBConn.GetRS("SELECT * FROM " & Me.TableName)
                Else
                    ds = Me.DBConn.GetRS(SQL)
                End If

                If All__DBs.IsDataSetValid(ds) Then
                    Me.___RawTable = ds.Tables(0)

                End If

                ' Retarget if possible
                If pLastID <> DO__NOT____TARGET__ANY_ROWID Then Me.LoadID(pLastID)

            Catch ex As Exception
                Logger.Print(ex)
            End Try


        End Sub

        Public Overridable Function HasRows() As Boolean
            If Me.RawTable Is Nothing Then Return False
            Return Me.RawTable.Rows.Count > 0
        End Function



        ''' <summary>
        ''' Deletes a row using an id. *Already functional. if DBConn is valid
        ''' </summary>
        ''' <param name="pID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Overloads Function DeleteRow(ByVal pID As Long) As Boolean
            If DBConn Is Nothing Then Throw New Exception("DbConn was not set for this class. Class Load Status: " & Me.OpenAccessFor.ToString())
            Return DeleteRow(pID:=pID, pDBConn:=Me.DBConn, pTableName:=Me.TableName)
        End Function

        ''' <summary>
        ''' Deletes a row using an id. *Already functional. Only if dbConn is Available
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Overloads Function DeleteRow() As Boolean
            Return Me.DeleteRow(Me.ID)
        End Function

        Public Overloads Shared Function DeleteRow(pDBConn As All__DBs, pID As Int64, pTableName As String) As Boolean
            Try
                If pDBConn Is Nothing Then Throw New Exception("DbConn Is NOT VALID: ")

                With pDBConn
                    Return _
                            .DbExec(
                                String.Format("DELETE FROM {0} WHERE ID={1} ",
                                                pTableName, pID
                                                )
                                )

                End With

            Catch ex As Exception
                Throw
            End Try

            Return False
        End Function


#End Region






    End Class

End Namespace