Namespace Interfaces

    ''' <summary>
    ''' Mainly for pointing to a Specific Server Instance
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ISQLServerDBPointer

        ''' <summary>
        ''' Gets a new instance of SQL Server Connection
        ''' </summary>
        ''' <returns></returns>
        Function GetDBConn() As Server


    End Interface


End Namespace