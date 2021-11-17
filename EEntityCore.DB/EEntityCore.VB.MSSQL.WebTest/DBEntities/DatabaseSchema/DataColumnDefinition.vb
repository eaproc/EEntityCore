

Namespace DBEntities.DatabaseSchema

    Public Class DataColumnDefinition

#Region "Constructors"
        Sub New(ByVal pColumnName As String,
                ByVal pDataType As System.Type,
                ByVal pNullable As Boolean,
                ByVal pDefaultValue As Object,
                Optional ByVal pConstraintType As ConstraintTypes = ConstraintTypes.UNKNOWN)

            Me.vNullable = pNullable
            Me.vDefaultValue = pDefaultValue
            Me.vDataType = pDataType
            Me.vColumnName = pColumnName
            Me.vConstraintType = pConstraintType

        End Sub

#End Region


#Region "Constructors"

        Private vColumnName As String, vDataType As System.Type, vDefaultValue As Object, vNullable As Boolean, vConstraintType As ConstraintTypes

        Public ReadOnly Property ColumnName As String
            Get
                Return Me.vColumnName
            End Get
        End Property
        Public ReadOnly Property DataType As System.Type
            Get
                Return Me.vDataType
            End Get
        End Property


        Public ReadOnly Property DefaultValue As Object
            Get
                If Not Me.Nullable Then
                    REM WHoop up something
                    Select Case DataColumnDefinition.getTypeAllowed(Me.DataType)

                        Case DataColumnDefinition.AllowedDataTypes.Bool
                            Return False

                        Case DataColumnDefinition.AllowedDataTypes.Blob
                            Return New Byte() {}

                        Case DataColumnDefinition.AllowedDataTypes.DateTime
                            Return DateTime.Now

                        Case DataColumnDefinition.AllowedDataTypes.Decimal, DataColumnDefinition.AllowedDataTypes.Int, DataColumnDefinition.AllowedDataTypes.Long
                            Return 0

                        Case DataColumnDefinition.AllowedDataTypes.String
                            Return " "              REM Some database sees "" as NULL

                        Case DataColumnDefinition.AllowedDataTypes.TimeSpan
                            Throw New NotImplementedException("Time Span is not implemented")

                        Case Else
                            REM DataColumnDefinition.AllowedDataTypes.UNKNOWN()
                            Throw New NotImplementedException("UNKNOWN DATA TYPE")

                    End Select

                Else
                    REM If it is date and is not null or nothing return now
                    ''If DataColumnDefinition.getTypeAllowed(Me.DataType) = AllowedDataTypes.DateTime AndAlso
                    ''    (Me.vDefaultValue IsNot Nothing OrElse Not IsDBNull(Me.vDefaultValue)) Then Return DateTime.Now


                    Return Me.vDefaultValue
                End If
            End Get
        End Property

        Public ReadOnly Property Nullable As Boolean
            Get
                Return Me.vNullable
            End Get
        End Property

        Public ReadOnly Property ConstraintType As ConstraintTypes
            Get
                Return Me.vConstraintType
            End Get
        End Property

#End Region


#Region "Enums and Consts"


        Public Enum AllowedDataTypes
            [Bool]
            [Int]
            [Long]
            [Decimal]
            [String]
            [Blob]
            [DateTime]
            [TimeSpan]
            [UNKNOWN]
        End Enum

        Public Enum ConstraintTypes
            FOREIGN
            PRIMARY
            UNIQUE
            CHECK
            UNKNOWN
        End Enum

#End Region


        Public Shared Function getTypeAllowed(pType As Type) As AllowedDataTypes
            Select Case pType
                Case GetType(Boolean)
                    Return AllowedDataTypes.Bool

                Case GetType(Byte), GetType(SByte), GetType(Int16), GetType(UInt16), GetType(Int32), GetType(UInt32)
                    Return AllowedDataTypes.Int

                Case GetType(Int64), GetType(UInt64)
                    Return AllowedDataTypes.Long

                Case GetType(Decimal), GetType(Double)
                    Return AllowedDataTypes.Decimal

                Case GetType(String), GetType(Char)
                    Return AllowedDataTypes.String

                Case GetType(Byte())
                    Return AllowedDataTypes.Blob

                Case GetType(DateTime)
                    Return AllowedDataTypes.DateTime

                Case GetType(TimeSpan)
                    Return AllowedDataTypes.TimeSpan

                Case Else
                    Return AllowedDataTypes.UNKNOWN

            End Select
        End Function



    End Class



End Namespace