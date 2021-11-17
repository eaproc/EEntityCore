Imports ELibrary.Standard.VB.Modules
Imports ELibrary.Standard.VB.Objects
Imports ELibrary.Standard.VB.Types

Namespace DBEntities.DatabaseSchema

    ''' <summary>
    ''' The purpose of this class is to differentiate when you are passing in null parameter or nothing(that is ignoring the parameter)
    ''' </summary>
    ''' <remarks>On Comparison you can't ignore a param. it is treated as null</remarks>
    Public Class DataColumnParameter
        Inherits DataColumnDefinition


        Sub New(ByVal pColumn As DataColumnDefinition,
                ByVal pValue As Object)

            MyBase.New(pColumn.ColumnName, pColumn.DataType, pColumn.Nullable, pColumn.DefaultValue, pColumn.ConstraintType)
            Me.vValue = pValue

        End Sub

        Sub New(ByVal pColumn As String,
               ByVal pValue As Object)

            Me.New(New DataColumnDefinition(pColumn, GetType(Object), False, Nothing), pValue)

        End Sub



        Public Const NULL_SQLServerValue As String = "NULL"


        Private vValue As Object

        Public ReadOnly Property Value As Object
            Get
                Return Me.vValue
            End Get

        End Property

        Public ReadOnly Property IsNullButNotEqualsNothing As Boolean
            Get
                Return New DataColumnNullParamValue().Equals(Me.Value) AndAlso Me.Value IsNot Nothing
            End Get
        End Property

        ''' <summary>
        ''' Returns nothing too as null
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsNull As Boolean
            Get
                Return New DataColumnNullParamValue().Equals(Me.Value)
            End Get
        End Property

        Public Shared ReadOnly Property NULL_Value(ByVal pColumn As DataColumnDefinition) As DataColumnParameter
            Get
                Return New DataColumnParameter(pColumn, New DataColumnNullParamValue())
            End Get
        End Property






        '''' <summary>
        '''' Only for BLob Type with no NULL result. Throws exception
        '''' </summary>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Public Function getByteArrayValue() As Byte()
        '    If Me.Value Is Nothing OrElse
        '        Not DataColumnDefinition.getTypeAllowed(Me.DataType) = AllowedDataTypes.Blob Then Throw New Exception("Wrong Use of this method.")

        '    If Me.IsNull Then Return Nothing REM incase for update
        '    If TypeOf Me.Value Is System.Drawing.Image Then Return EImage.toByteArray(CType(Me.Value, System.Drawing.Image))
        '    Return CType(Me.Value, Byte())

        'End Function

        Private Function getSQLQuotedValue() As Object


            If Me.ConstraintType = ConstraintTypes.FOREIGN And Me.Nullable Then
                REM This must be int
                Try
                    If EInt.valueOf(Me.Value) = 0 Then Return NULL_SQLServerValue
                Catch ex As Exception
                    Throw New Exception("Trying to translate 0 to NULL for NULLABLE FOREIGN KEYS", ex)
                End Try

            End If


            Select Case DataColumnDefinition.getTypeAllowed(Me.DataType)

                Case DataColumnDefinition.AllowedDataTypes.Bool
                    Return EBoolean.valueOf(Me.Value).toInt32()

                Case DataColumnDefinition.AllowedDataTypes.Blob
                    Throw New Exception("You can not pass Blob values as inline SQL. ColumnName: " & Me.ColumnName)

                Case DataColumnDefinition.AllowedDataTypes.DateTime
                    Return DatabaseInit.DBConnectInterface.getDBConn().GetSQLDateTimeFormat(New NullableDateTime(Me.Value), True)

                Case DataColumnDefinition.AllowedDataTypes.Decimal
                    REM Format to English Culture, Since Database Saves in English
                    REM Use Culture to reformat it
                    Return EDouble.valueOf(Me.Value).ToString(
                        New System.Globalization.CultureInfo(1033)
                        )   ' USA

                Case DataColumnDefinition.AllowedDataTypes.Int
                    Return EInt.valueOf(Me.Value)

                Case DataColumnDefinition.AllowedDataTypes.Long

                    Return ELong.valueOf(Me.Value)

                Case DataColumnDefinition.AllowedDataTypes.String
                    Return String.Format("N\'{0}\'", EStrings.valueOf(Me.Value))

                Case DataColumnDefinition.AllowedDataTypes.TimeSpan
                    Throw New Exception("TimeSpan is not currently supported")

                Case Else
                    REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()
                    Throw New Exception(Me.DataType.FullName & " is NOT currently supported!")

            End Select
        End Function

        ''' <summary>
        ''' For add, nothing is treated as null and nullval, else real value is returned
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getSQLQuotedValueForAdd() As Object
            If (Me.Value Is Nothing OrElse Me.IsNull) AndAlso Not Me.Nullable Then Throw New Exception(Me.ColumnName & " can not be NULL")

            If (Me.Value Is Nothing OrElse Me.IsNull) Then Return NULL_SQLServerValue

            Return Me.getSQLQuotedValue()

        End Function

        ''' <summary>
        ''' For update, nothing is treated as leave same value, nullval means null, else real value is returned
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function getSQLQuotedValueForUpdate() As Object
            If Me.IsNullButNotEqualsNothing AndAlso Not Me.Nullable Then Throw New Exception(Me.ColumnName & " can not be NULL")

            If Me.Value Is Nothing Then Return Me.ColumnName
            If (Me.IsNull) Then Return NULL_SQLServerValue



            Return Me.getSQLQuotedValue()


        End Function


        ''' <summary>
        ''' Just limit your result to NULL or Real Value
        ''' </summary>
        ''' <param name="pValue"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function TranslateNothingToNull(ByVal pValue As Object) As Object
            If pValue Is Nothing Then Return New DataColumnNullParamValue()
            Return pValue
        End Function

        ''Public Shared Function getDefinition(pholder As IDataColumnDefinitionsHolder, pColumnName As String) As DataColumnDefinition
        ''    If pholder.getDefinitions().ContainsKey(pColumnName) Then Return pholder.getDefinitions()(pColumnName)
        ''    Throw New Exception(pColumnName & " is not added among the data column definitions.")
        ''End Function


    End Class



End Namespace