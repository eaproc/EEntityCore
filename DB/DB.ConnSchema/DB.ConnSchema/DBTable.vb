




Public Class DBTable
    Implements IColumnParent


#Region "Constructors"

    Public Sub New()
        Me.Columns = New Dictionary(Of String, DBColumn)()
    End Sub


#End Region






#Region "Methods"


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



    Public Function SetTemporalConstraintName(
                                              pCol As DBColumn,
                                pTemporaryConstraintName As String
                                             ) As Boolean
        pCol.TemporaryConstraintName = pTemporaryConstraintName
        Return True
    End Function


    Public Function SetUniqueKey(
                                pCol As DBColumn,
                                pUniqueName As String
                          ) As Boolean
        pCol.UniqueKey = New DBColumn.UniqueKeyDef(pCol, pUniqueName)
        Return True

    End Function



    Public Function SetPrimaryKey(
                                pCol As DBColumn,
                                pPkName As String
                          ) As Boolean
        pCol.PrimaryKey = New DBColumn.UniqueKeyDef(pCol, pPkName)
        pCol.ConstraintType = DBColumn.ConstraintTypes.PRIMARY
        Return True

    End Function


    Public Function SetForeignKey(
                               pCol As DBColumn,
                               pFKName As String,
                               pRefTable As String,
                            pOnDeleteAction As String
                         ) As Boolean
        pCol.ForeignKey = New IDBTableDefinitionPlugIn.ForeignKeyDefinition(
                             pFKName, False, pOnDeleteAction.Replace(" ", "_"), Me.Name, pRefTable)

        pCol.ConstraintType = DBColumn.ConstraintTypes.FOREIGN

        Return True

    End Function


    Public Function getForeignKeys() As List(Of IDBTableDefinitionPlugIn.ForeignKeyDefinition)
        Return (
            From d In Me.Columns.Values.ToList()
            Where d.IsForeignKey
            Select d.ForeignKey
            ).ToList()

    End Function

#End Region




#Region "Properties"

    Public Property Name As String Implements IColumnParent.Name

    Public Property Columns As Dictionary(Of String, DBColumn) Implements IColumnParent.Columns

#End Region




End Class


