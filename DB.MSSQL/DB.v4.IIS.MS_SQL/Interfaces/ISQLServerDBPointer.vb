Imports DB.v4.IIS.MSSQL

Namespace Interfaces

    ''' <summary>
    ''' Mainly for pointing to a Specific Server Instance
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface ISQLServerDBPointer

        Function getDBConn() As Server


    End Interface


End Namespace