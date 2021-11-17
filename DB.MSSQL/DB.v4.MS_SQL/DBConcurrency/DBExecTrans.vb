Imports CODERiT.Logger.v._3._5.Exceptions

Namespace DBConcurrency


    Public Class DBExecTrans
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





        Public ReadOnly Property boolResult As Boolean
            Get
                Return CBool(MyBase.Result)
            End Get
        End Property




        Friend Overrides Sub Execute(cmd As SqlClient.SqlCommand)
            If Me.hasExecuted() Then Return

            If Me.ExecType = CommandType.Text Then
                MyBase.Execute(cmd)
            Else
                Try
                    cmd.CommandType = Me.ExecType
                    cmd.CommandText = Me.SQL
                    cmd.Parameters.AddRange(SQLParameters)

                    Me.__affectedRows = cmd.ExecuteNonQuery()
                    Me.__Result = True
                Catch ex As Exception
                    Me.__Result = False

                    Throw New EException("SQL: " & Me.SQL, ex)
                End Try

            End If
        End Sub



    End Class


End Namespace