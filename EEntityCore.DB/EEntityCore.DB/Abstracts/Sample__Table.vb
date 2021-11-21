

Imports System.Data
Imports ELibrary.Standard.VB

Namespace Abstracts


    ''' <summary>
    ''' Copy this Template and adjust as you want. You can remove some of the constructors or add to it
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Sample__Table
        Inherits SimpleTablePlugIn



#Region "Constructors"

        ''' <summary>
        ''' UNKNOWN ACCESS
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New(
                    ByVal TableName As String
                    )
            MyBase.New(TableName)
        End Sub

#Region "Full Access"

        '   Full Access means initial data is loaded directly from database, so DBConn MUST be provided

        ''' <summary>
        ''' FULL ACCESS. This will load data with dbconn
        ''' </summary>
        ''' <param name="DBConn"></param>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Public Sub New(ByVal DBConn As All__DBs,
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
        Sub New(ByVal DBConn As All__DBs,
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
        Public Sub New(ByVal pDBConn As All__DBs,
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
        Sub New(ByVal pDBConn As All__DBs,
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
                     ByVal pDBConn As All__DBs)
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
                     ByVal pDBConn As All__DBs)

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
                      ByVal DBConn As All__DBs)

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



#Region "Properties"

        ' ********************* Very Important **************************
        Public ReadOnly Property isValidRow As Boolean
            Get
                Return Me.isTargettedRowValid
            End Get
        End Property

        ''' <summary>
        ''' Note: your table must have the column name ID for you to call this
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overrides ReadOnly Property ID As Int64
            Get
                If Not Me.isValidRow Then Return 0
                Return Objects.ELong.valueOf(Me.TargettedRow(Me.NumericPrimaryKeyName))
            End Get
        End Property

        Public Overrides ReadOnly Property NumericPrimaryKeyName As String
            Get
                Return "ID"
            End Get
        End Property

#End Region



#Region "Methods"




        ''' <summary>
        ''' Deletes a row using an id. *Already functional. if DBConn is valid
        ''' </summary>
        ''' <param name="pID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Overloads Function delete(ByVal pID As Long) As Boolean
            If DBConn Is Nothing Then Throw New Exception("DbConn was not set for this class. Class Load Status: " & Me.OpenAccessFor.ToString())
            Return delete(pID:=pID, pDBConn:=Me.DBConn, pTableName:=Me.TableName)
        End Function

        ''' <summary>
        ''' Deletes a row using an id. *Already functional. Only if dbConn is Available
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Overridable Overloads Function delete() As Boolean
            Return Me.delete(Me.ID)
        End Function

        Public Overloads Shared Function delete(pDBConn As All__DBs, pID As Int64, pTableName As String) As Boolean
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


        ''' <summary>
        ''' gets net ID from the rows loaded using linq
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetNextID() As Int64
            Try
                If Not Me.hasRows() Then Return 1 ' Might be empty table
                'Dim rs As IEnumerable(Of DataRow) = From dr As DataRow In Me.AllRows
                '                                    Let l As Sample__Table = New Sample__Table(dr)
                '                                    Order By l.ID Descending
                '                                    Select dr
                If Not Me.hasNumericPrimaryKeyColumn Then Throw New Exception("This table doesnt contain a numeric primary key")

                Dim rs As IEnumerable(Of DataRow) = (From dr As DataRow In Me.AllRows
                                                     Order By dr(Me.NumericPrimaryKeyName) Descending
                                                     Select dr).ToList()

                'If rs IsNot Nothing AndAlso rs.Count() > 0 Then Return New Sample__Table(rs(0)).ID + 1
                If rs IsNot Nothing AndAlso rs.Count() > 0 Then Return CLng(rs(0)(Me.NumericPrimaryKeyName)) + 1

                Return 1

            Catch ex As Exception
                All__DBs.Logger.Print("Error GettingNextID", ex)
            End Try

            Return 0
        End Function




        ''' <summary>
        ''' Reloads class and retarget class
        ''' </summary>
        ''' <param name="SQL"></param>
        ''' <remarks></remarks>
        Public Overrides Sub reloadClass(Optional ByVal SQL As String = Nothing)
            Dim pLastID As Int64 = Me.ID
            MyBase.reloadClass(SQL) : Me.LoadID(pLastID)
        End Sub
#End Region





    End Class

End Namespace