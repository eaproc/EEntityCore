Imports CODERiT.Logger.v._3._5.Exceptions

Namespace DBConcurrency


    Public MustInherit Class DBQueryTrans

        ''' <summary>
        ''' Makes sure the apostrophe issue is corrected in the strings. 
        ''' NB: For your original SQL Query you should use \' for apostrophe
        ''' </summary>
        ''' <param name="vSQL"></param>
        ''' <param name="vIsReturnParam"></param>
        ''' <param name="vHandleApostrophe">Indicate it is apostrophe encoded like Name=\'Fred's Computer\'</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal vSQL As String,
                       Optional ByVal vIsReturnParam As Boolean = False,
                   Optional ByVal vHandleApostrophe As Boolean = False)

            If vHandleApostrophe Then
                vSQL = Replace(vSQL, "\'", "[*===*]") REM Keep Original Apostrophe Encoded
                vSQL = Replace(vSQL, "'", "''")
                vSQL = Replace(vSQL, "[*===*]", "'")  REM Return Original Apostrophe Encoded
            End If

            Me.__SQL = vSQL
            Me.__IsReturnParameter = vIsReturnParam
        End Sub







        Private __SQL As String
        Public ReadOnly Property SQL As String
            Get
                Return Me.__SQL
            End Get
        End Property

        Private __IsReturnParameter As Boolean
        Public ReadOnly Property IsReturnParameter As Boolean
            Get
                Return Me.__IsReturnParameter
            End Get
        End Property

        Protected __Result As Object
        Protected ReadOnly Property Result As Object
            Get
                Return Me.__Result
            End Get
        End Property

        Protected __ExecType As CommandType
        Public ReadOnly Property ExecType As CommandType
            Get
                Return Me.__ExecType
            End Get
        End Property


        Protected __SQLParameters As SqlClient.SqlParameter()
        Public ReadOnly Property SQLParameters() As SqlClient.SqlParameter()
            Get
                Return Me.__SQLParameters
            End Get
        End Property


        Protected __affectedRows As Int32
        Public ReadOnly Property affectedRows As Int32
            Get
                Return Me.__affectedRows
            End Get
        End Property






        Public Function hasExecuted() As Boolean
            Return Me.Result IsNot Nothing
        End Function


        ''' <summary>
        ''' Throws Exception
        ''' </summary>
        ''' <param name="cmd"></param>
        ''' <remarks></remarks>
        Friend Overridable Sub Execute(cmd As SqlClient.SqlCommand)
            Try
                If Me.hasExecuted() Then Return

                cmd.CommandType = CommandType.Text
                cmd.CommandText = Me.SQL


                Me.__affectedRows = cmd.ExecuteNonQuery()
                Me.__Result = True

            Catch ex As Exception
                Me.__Result = False

                Throw New EException("SQL: " & Me.SQL, ex)
            End Try

        End Sub




    End Class

End Namespace