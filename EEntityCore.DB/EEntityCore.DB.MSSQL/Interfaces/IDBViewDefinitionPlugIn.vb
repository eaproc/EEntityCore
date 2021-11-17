

Namespace Interfaces


    Public Interface IDBViewDefinitionPlugIn


        ''' <summary>
        ''' Return the names of tables this view depend on
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function getReferencedTableNames() As List(Of String)

        Function getViewName() As String

    End Interface



End Namespace