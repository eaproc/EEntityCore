Imports CODERiT.Logger.v._3._5
Imports System.Transactions

Imports EPRO.Library.v3._5.Objects
Imports DB.v4.MS_SQL.Interfaces

Namespace DBConcurrency

    Public Class SQLDatabaseTransactionManager

#Region "Constructors"
        ''' <summary>
        ''' Initialize
        ''' </summary>
        ''' <param name="__Logger"></param>
        ''' <param name="ptrConn"></param>
        ''' <param name="IsoLevel"></param>
        ''' <param name="DefaultTimeoutMillSecs">If this is zero secs it will keep waiting forever</param>
        ''' <remarks></remarks>
        Sub New(ByVal __Logger As Log1, ByVal ptrConn As ISQLServerDBPointer,
                Optional ByVal IsoLevel As System.Transactions.IsolationLevel = System.Transactions.IsolationLevel.Snapshot,
                                Optional ByVal DefaultTimeoutMillSecs As Integer = 2000)

            Me.Logger = __Logger
            Me.ptrConn = ptrConn
            Me.___DefaultTimeoutMillSecs = DefaultTimeoutMillSecs
            Me.___IsoLevel = IsoLevel

        End Sub

#End Region


#Region "Properties"
        Protected Logger As Log1
        Private ___IsoLevel As IsolationLevel
        Private ptrConn As ISQLServerDBPointer

        Public ReadOnly Property IsoLevel As IsolationLevel
            Get
                Return Me.___IsoLevel
            End Get
        End Property


        Private ___DefaultTimeoutMillSecs As Integer
        Public ReadOnly Property DefaultTimeoutMillSecs As Integer
            Get
                Return Me.___DefaultTimeoutMillSecs
            End Get
        End Property


#End Region



#Region "Methods"


        Private Function getSystemDataIso(isolationLevel As IsolationLevel) As System.Data.IsolationLevel
            Select Case isolationLevel
                Case Transactions.IsolationLevel.ReadCommitted
                    Return Data.IsolationLevel.ReadCommitted
                Case Transactions.IsolationLevel.ReadUncommitted
                    Return Data.IsolationLevel.ReadUncommitted
                Case Transactions.IsolationLevel.RepeatableRead
                    Return Data.IsolationLevel.RepeatableRead
                Case Transactions.IsolationLevel.Serializable
                    Return Data.IsolationLevel.Serializable
                Case Transactions.IsolationLevel.Snapshot
                    Return Data.IsolationLevel.Snapshot
                Case Transactions.IsolationLevel.Chaos
                    Return Data.IsolationLevel.Chaos
                Case Else REM  Transactions.IsolationLevel.Unspecified
                    Return Data.IsolationLevel.Unspecified
            End Select

        End Function




        ''' <summary>
        ''' ExecuteNonQuery
        ''' </summary>
        ''' <param name="Queries">Queries are executed in order of precedence</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dbExec(
                            ParamArray Queries() As DBExecTrans) As Boolean
            Return Me.dbExec(Me.DefaultTimeoutMillSecs, Queries)
        End Function

        ''' <summary>
        ''' Throws Exception if failed
        ''' </summary>
        ''' <param name="timeoutMillSecs">Queries are executed in order of precedence</param>
        ''' <param name="Queries"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function dbExec(ByVal timeoutMillSecs As Integer,
                                ParamArray Queries() As DBExecTrans) As Boolean

            Dim trans As SqlClient.SqlTransaction = Nothing
            Dim Conn As SqlClient.SqlConnection = Nothing

            Try
                Dim Result As Boolean = False
                Conn = Me.ptrConn.getDBConn().getSQLConnection()
                trans = Conn.BeginTransaction(getSystemDataIso(Me.IsoLevel))

                Using cmd As SqlClient.SqlCommand = Conn.CreateCommand()
                    cmd.CommandTimeout = CInt(CDbl(timeoutMillSecs) / 1000.0#)
                    cmd.Connection = Conn
                    cmd.Transaction = trans

                    For Each Query As DBExecTrans In Queries
                        Query.Execute(cmd)
                        If Query.IsReturnParameter Then Result = Query.boolResult

                    Next

                    REM if no parameter is set to return, always return the first
                    If Not Result Then Result = Queries(0).boolResult

                    trans.Commit()

                End Using

                Return Result

            Catch ex As Exception
                Me.Logger.Print("dbExec_TransMgr", ex)
                Try
                    If trans IsNot Nothing Then trans.Rollback() : trans.Dispose()
                    trans = Nothing
                Catch exTrans As Exception
                    Me.Logger.Print("Rolling Back Transaction", exTrans)
                End Try
                Throw ex

            Finally

                If Conn IsNot Nothing Then Conn.Close()
                Conn = Nothing

            End Try


            ''Try

            ''    Dim Result As Boolean = False
            ''    Using TScope As New Transactions.TransactionScope(TransactionScopeOption.Required,
            ''                                         New TransactionOptions() With {.IsolationLevel = Me.IsoLevel,
            ''                                                                        .Timeout = TimeSpan.FromMilliseconds(timeoutMillSecs)
            ''                                                                       }
            ''                                         )

            ''        Using Conn As SqlClient.SqlConnection = Me.ptrConn.getDBConn().getSQLConnection()

            ''            Using cmd As SqlClient.SqlCommand = Conn.CreateCommand()
            ''                cmd.CommandTimeout = CInt(CDbl(timeoutMillSecs) / 1000.0#)

            ''                For Each Query As DBExecTrans In Queries
            ''                    Query.Execute(cmd)
            ''                    If Query.IsReturnParameter Then Result = Query.boolResult

            ''                Next

            ''                REM if no parameter is set to return, always return the first
            ''                If Not Result Then Result = Queries(0).boolResult

            ''            End Using
            ''        End Using

            ''        TScope.Complete()
            ''    End Using


            ''    Return Result
            ''Catch ex As Exception
            ''    Me.Logger.Print("dbExec_TransMgr", ex)
            ''    Throw ex
            ''End Try

            Return False

        End Function


        ''' <summary>
        ''' Get Result Dataset of a query set to return. Throws Exception
        ''' </summary>
        ''' <param name="Queries">Atleast a query should be set to returnResult</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getRS(ParamArray Queries() As GetRSTrans) As DataSet
            Return Me.getRS(Me.DefaultTimeoutMillSecs, Queries)
        End Function

        ''' <summary>
        ''' Get Result Dataset of a query set to return. Throws Exception
        ''' </summary>
        ''' <param name="timeoutMillSecs"></param>
        ''' <param name="Queries">Atleast a query should be set to returnResult</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getRS(ByVal timeoutMillSecs As Integer, ParamArray Queries() As GetRSTrans) As DataSet

            Dim rs As DataSet = Nothing

            ''Try
            ''    REM Transaction Timeout NOT Working
            ''    REM Switching to Command Timeout

            ''    Using TScope As New TransactionScope(TransactionScopeOption.Required,
            ''                                         New TransactionOptions() With {.IsolationLevel = IsoLevel,
            ''                                                                        .Timeout = TimeSpan.FromMilliseconds(timeoutMillSecs)
            ''                                                                       }
            ''                                         )

            ''        Using Conn As SqlClient.SqlConnection = Me.ptrConn.getDBConn().getSQLConnection()

            ''            Using cmd As SqlClient.SqlCommand = Conn.CreateCommand()
            ''                cmd.CommandTimeout = CInt(CDbl(timeoutMillSecs) / 1000.0#)
            ''                For Each Query As GetRSTrans In Queries
            ''                    Query.Execute(cmd)
            ''                    If Query.IsReturnParameter Then rs = Query.dsResult

            ''                Next

            ''                REM if no parameter is set to return, always return the first
            ''                If rs Is Nothing Then rs = Queries(0).dsResult

            ''            End Using

            ''        End Using

            ''        TScope.Complete()

            ''    End Using


            ''Catch ex As Exception
            ''    Me.Logger.Print("getRS_CachMgr", ex)
            ''    Throw ex
            ''End Try



            Dim trans As SqlClient.SqlTransaction = Nothing
            Dim Conn As SqlClient.SqlConnection = Nothing

            Try

                Conn = Me.ptrConn.getDBConn().getSQLConnection()
                trans = Conn.BeginTransaction(getSystemDataIso(Me.IsoLevel))

                Using cmd As SqlClient.SqlCommand = Conn.CreateCommand()
                    cmd.CommandTimeout = CInt(CDbl(timeoutMillSecs) / 1000.0#)
                    cmd.Connection = Conn
                    cmd.Transaction = trans

                    For Each Query As GetRSTrans In Queries
                        Query.Execute(cmd)
                        If Query.IsReturnParameter Then rs = Query.dsResult

                    Next

                    REM if no parameter is set to return, always return the first
                    If rs Is Nothing Then rs = Queries(0).dsResult

                    trans.Commit()

                End Using

            Catch ex As Exception
                Me.Logger.Print("getRS_CachMgr", ex)
                Try
                    If trans IsNot Nothing Then trans.Rollback() : trans.Dispose()
                    trans = Nothing
                Catch exTrans As Exception
                    Me.Logger.Print("Rolling Back Transaction", exTrans)
                End Try
                Throw ex

            Finally

                If Conn IsNot Nothing Then Conn.Close()
                Conn = Nothing

            End Try



            Return rs

        End Function




#End Region










    End Class

End Namespace