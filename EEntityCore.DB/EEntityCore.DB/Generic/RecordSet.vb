
Namespace Genric

    ''' <summary>
    ''' Helps to Navigate a Record Set
    ''' </summary>
    ''' <remarks></remarks>
    Public NotInheritable Class RecordSet(Of T)

        REM Currently Delete will not be implemented
        REM Just Load Data
        REM Navigate to and From

        REM When a Data is Loaded, specify current index should be kept or move to first if there is




#Region "Constructors"


        Sub New(ByVal DBCursorList() As T)

            Me.DBCursorList = DBCursorList
            Me.moveFirst()

        End Sub



#End Region


#Region "Properties"


        Public ReadOnly Property DBCursor As T
            Get
                If Me.CurrentIndex >= 0 AndAlso Me.hasRecords AndAlso Me.CurrentIndex < Me.DBCursorList.Count Then
                    Return Me.DBCursorList(Me.CurrentIndex)
                End If
                Return Nothing
            End Get
        End Property

        Private CurrentIndex As Int32 = -1

        Private DBCursorList() As T = Nothing


        Public ReadOnly Property hasRecords As Boolean
            Get
                Return Me.DBCursorList IsNot Nothing AndAlso Me.DBCursorList.Count > 0
            End Get
        End Property


        Public ReadOnly Property hasNext As Boolean
            Get
                Return Me.hasRecords AndAlso Me.CurrentIndex < Me.DBCursorList.Count - 1
            End Get
        End Property

        Public ReadOnly Property hasPrevious As Boolean
            Get
                Return Me.hasRecords AndAlso Me.CurrentIndex > 0
            End Get
        End Property

        ''' <summary>
        ''' Indicate it has reach eof of record
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property EOF As Boolean
            Get
                If Me.DBCursorList Is Nothing Then Return True
                Return Me.CurrentIndex + 1 > Me.DBCursorList.Count
            End Get
        End Property


        ''' <summary>
        ''' Indicate Position is at -1 index
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property BOF As Boolean
            Get
                Return Me.CurrentIndex = -1
            End Get
        End Property

        ''' <summary>
        ''' Displays the Absolute index of this current record. Like 1 of 4
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property AbsoluteIndex As Int32
            Get
                REM since there can be minimum of the Lowest digit
                REM Else you have 0 of 0
                If Not Me.EOF Then
                    Return Me.CurrentIndex + 1

                Else

                    Return 0

                End If

            End Get
        End Property


        Public ReadOnly Property TotalRecords As Int32
            Get
                If Me.hasRecords Then Return Me.DBCursorList.Count
                Return 0
            End Get
        End Property

#End Region



#Region "Methods"

        Private Sub NullPointer()
            Me.CurrentIndex = -1
        End Sub

        Public Function moveFirst() As T
            Me.NullPointer()
            If Me.hasRecords Then Me.CurrentIndex = 0
            Return Me.DBCursor
        End Function

        Public Function movePrevious() As T
            Dim __CurrentIndex As Int32 = Me.CurrentIndex
            If Me.hasRecords And __CurrentIndex > 0 Then
                If Me.EOF Then
                    Me.CurrentIndex = Me.DBCursorList.Count - 1
                Else
                    Me.CurrentIndex -= 1
                End If
            Else
                Me.NullPointer() REM No Record at all
            End If
            Return Me.DBCursor
        End Function



        Public Function moveNext() As T
            REM If I do it like this .. It will return the Cursor to the BOF when it reaches EOF
            ''If Me.hasNext Then
            ''    Me.CurrentIndex += 1
            ''Else
            ''    Me.NullPointer()
            ''End If
            Me.CurrentIndex += 1
            Return Me.DBCursor
        End Function

        Public Function moveLast() As T
            Me.NullPointer()
            If Me.hasRecords Then Me.CurrentIndex = Me.DBCursorList.Count - 1
            Return Me.DBCursor
        End Function

        Private Function gotoRecord(ByVal index As Int32) As T
            Me.NullPointer()
            If Me.hasRecords AndAlso index < Me.DBCursorList.Count Then Me.CurrentIndex = index
            Return Me.DBCursor

        End Function


        Public Sub reloadData(ByVal DBCursorList() As T,
                              Optional ByVal maintainCurrentIndex As Boolean = False
                                    )

            Dim __currentIndex As Int32 = Me.CurrentIndex
            Me.DBCursorList = DBCursorList
            If maintainCurrentIndex Then Me.gotoRecord(__currentIndex)

        End Sub

#End Region




    End Class

End Namespace
