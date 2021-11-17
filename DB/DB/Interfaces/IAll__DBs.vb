Namespace Interfaces


    Public Interface IAll__DBs

        'Make saving date and time an interface and saving binaries

        ''' <summary>
        ''' Test if DB is ok [Using Default/No Parameters]
        ''' </summary>
        ''' <remarks></remarks>
        Function PingDB() As Boolean


        ''' <summary>
        ''' Indicate if Connection will be successful using the current parameters
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function CanConnect() As Boolean


        ''' <summary>
        ''' execute()
        ''' </summary>
        ''' <param name="SQL"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function dbExec(ByVal SQL As String) As Boolean


        ''' <summary>
        ''' executeQuery()
        ''' </summary>
        ''' <param name="SQL"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function getRS(ByVal SQL As String) As DataSet




        ''' <summary>
        ''' Executes an SQL File containing SQL Statements
        ''' </summary>
        ''' <param name="SQLFileName">SQL File containing SQL Statements</param>
        ''' <param name="TerminateOnError">If One Statement in the file yields error. The process will break if set to true</param>
        ''' <param name="StatementDelimiter">The delimiter use to identify the end of each sql statement. not case sensitive</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function ExecuteSQLFile(ByVal SQLFileName As String,
                                       Optional ByVal TerminateOnError As Boolean = False,
                                       Optional ByVal StatementDelimiter As String = "GO;") As Boolean



    End Interface

End Namespace