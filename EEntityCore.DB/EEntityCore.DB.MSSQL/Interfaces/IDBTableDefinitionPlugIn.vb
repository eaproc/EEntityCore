

Namespace Interfaces


    Public Interface IDBTableDefinitionPlugIn



        Enum ReferentialAction
            NO_ACTION
            CASCADE
            SET_NULL
            SET_DEFAULT
            UNKNOWN
        End Enum

        <Serializable()> _
        Structure ForeignKeyDefinition
            Public Sub New(pForeignKeyName As String,
                           pIs_disabled As Boolean,
                           pDelete_referential_action_desc As String,
                            pParentName As String,
                            pReferencedParentName As String)
                Me.ForeignKeyName = pForeignKeyName
                Me.is_disabled = pIs_disabled
                Me.delete_referential_action_desc = ReferentialAction.UNKNOWN
                Me.ParentName = pParentName
                Me.ReferencedParentName = pReferencedParentName

                Select Case pDelete_referential_action_desc
                    Case ReferentialAction.CASCADE.ToString()
                        Me.delete_referential_action_desc = ReferentialAction.CASCADE
                    Case ReferentialAction.NO_ACTION.ToString()
                        Me.delete_referential_action_desc = ReferentialAction.NO_ACTION
                    Case ReferentialAction.SET_DEFAULT.ToString()
                        Me.delete_referential_action_desc = ReferentialAction.SET_DEFAULT
                    Case ReferentialAction.SET_NULL.ToString()
                        Me.delete_referential_action_desc = ReferentialAction.SET_NULL
                End Select

            End Sub
            Public Sub New(pForeignKeyName As String,
                           pIs_disabled As Boolean,
                           pDelete_referential_action_desc As ReferentialAction,
                            pParentName As String,
                            pReferencedParentName As String)
                Me.ForeignKeyName = pForeignKeyName
                Me.is_disabled = pIs_disabled
                Me.delete_referential_action_desc = pDelete_referential_action_desc
                Me.ParentName = pParentName
                Me.ReferencedParentName = pReferencedParentName

            End Sub

            Public ForeignKeyName As String, is_disabled As Boolean, delete_referential_action_desc As ReferentialAction,
                ParentName As String, ReferencedParentName As String

        End Structure




        ''' <summary>
        ''' Return the names of tables this view depend on
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function GetForeignKeys() As List(Of ForeignKeyDefinition)


        Function GetTableName() As String

        Function GetFillSQL() As String

    End Interface



End Namespace