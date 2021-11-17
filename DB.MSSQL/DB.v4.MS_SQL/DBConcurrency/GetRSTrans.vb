Imports CODERiT.Logger.v._3._5.Exceptions

Namespace DBConcurrency

    Public Class GetRSTrans
        Inherits DBQueryTrans


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="vSQL"></param>
        ''' <param name="vIsReturnParam"></param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <remarks></remarks>
        Sub New(ByVal vSQL As String,
                   Optional ByVal vIsReturnParam As Boolean = False,
                   Optional ByVal vHandleApostrophe As Boolean = False)
            MyBase.New(vSQL, vIsReturnParam, vHandleApostrophe)
            Me.__ExecType = CommandType.Text
        End Sub

        Sub New(ByVal StoredProcedure As String,
                      ByVal vIsReturnParam As Boolean,
                       ByVal ParamArray __SQLParameters() As SqlClient.SqlParameter
                       )
            MyBase.New(StoredProcedure, vIsReturnParam)
            Me.__ExecType = CommandType.StoredProcedure
            Me.__SQLParameters = __SQLParameters
        End Sub





        Public ReadOnly Property dsResult As DataSet
            Get
                Return CType(Me.Result, DataSet)
            End Get
        End Property



        Friend Overrides Sub Execute(cmd As SqlClient.SqlCommand)
            If Me.hasExecuted() Then Return
            Dim rs As DataSet = Nothing
            REM Dim da As SqlClient.SqlDataAdapter

            Try

                rs = New DataSet()
                cmd.CommandType = Me.ExecType
                cmd.CommandText = Me.SQL

                If Me.ExecType = CommandType.StoredProcedure Then
                    cmd.Parameters.AddRange(SQLParameters)
                End If

                ''Using da As New SqlClient.SqlDataAdapter(cmd)
                ''    da.Fill(rs)

                ''    'da.Dispose()
                ''    'da = Nothing
                ''    Me.__Result = rs
                ''End Using

                Using drr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                    Dim Table1 As New DataTable("Table")
                    Table1.Load(drr)
                    rs.Tables.Add(Table1)
                    drr.Close()
                    Me.__Result = rs
                End Using


            Catch ex As Exception
                Me.__Result = rs  REM Mark hasExecuted
                Throw New EException("SQL: " & Me.SQL, ex)
            End Try
        End Sub










    End Class

End Namespace