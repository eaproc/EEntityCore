

Namespace Interfaces


    Public Interface IDBViewDefinitionPlugIn


        ''' <summary>
        ''' Return the names of tables this view depend on
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GetReferencedTableNames() As List(Of String)

        Function GetViewName() As String

        Function GetFillSQL() As String

    End Interface



End Namespace