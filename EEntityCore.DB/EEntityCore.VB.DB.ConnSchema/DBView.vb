

Public Class DBView
    Implements IColumnParent



#Region "Constructors"

    Public Sub New()
        Me.Columns = New Dictionary(Of String, DBColumn)()
        Me.Dependencies = New List(Of String)()
    End Sub

#End Region


#Region "Methods"

    Public Function SetViewDefinition(pDef As String) As Boolean
        Me.RawViewDefinition = pDef
        Return True
    End Function

    Public Function AddColumn(pName As String,
                            pDataType As System.Type,
                            pIsNullable As Boolean
                            ) As Boolean
        Dim p As New DBColumn(Me)
        p.DataType = pDataType
        p.IsNullable = pIsNullable
        p.Name = pName
        Me.Columns.Add(p.Name, p)
        Return True

    End Function


#End Region




#Region "Properties"


    Public Property Name As String Implements IColumnParent.Name


    Public Property RawViewDefinition As String


    Public Property Columns As Dictionary(Of String, DBColumn) Implements IColumnParent.Columns


    Public Property Dependencies As List(Of String)


#End Region



End Class

