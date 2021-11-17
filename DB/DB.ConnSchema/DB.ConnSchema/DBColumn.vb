



Public Class DBColumn



#Region "Properties"

    Public Property Name As String

    Public Property DataType As System.Type

    Public Property IsNullable As Boolean



    Public Property ConstraintType As ConstraintTypes

    ''' <summary>
    ''' We only use this in mysql schema generator because we need both the indexes collections and indexColumns to determine the constraints
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TemporaryConstraintName As String

    Public Property UniqueKey As UniqueKeyDef

    Public Property PrimaryKey As UniqueKeyDef

    Public Property ForeignKey As IDBTableDefinitionPlugIn.ForeignKeyDefinition


    Public ReadOnly Property UniqueKeyName As String
        Get
            If Not IsNothing(Me.UniqueKey) Then Return Me.UniqueKey.Name
            Return String.Empty
        End Get
    End Property

    Public ReadOnly Property IsUnique As Boolean
        Get
            Return Me.ConstraintType = ConstraintTypes.PRIMARY OrElse
                UniqueKeyName <> String.Empty
        End Get
    End Property

    Public ReadOnly Property IsForeignKey As Boolean
        Get
            Return Me.ConstraintType = ConstraintTypes.FOREIGN
        End Get
    End Property



    Public ReadOnly Property PrimaryKeyName As String
        Get
            If Not IsNothing(Me.PrimaryKey) Then Return Me.PrimaryKey.Name
            Return String.Empty
        End Get
    End Property





    Private ____Parent As IColumnParent
    Public ReadOnly Property Parent As IColumnParent
        Get
            Return Me.____Parent
        End Get
    End Property

#End Region




#Region "Enumerations"

    Public Enum ConstraintTypes
        FOREIGN
        PRIMARY
        NEUTRAL
    End Enum


    Public Structure UniqueKeyDef
        Public Sub New(pParent As DBColumn,
                    pName As String)
            Me.Parent = pParent
            Me.Name = pName

        End Sub

        Public Parent As DBColumn
        Public Name As String

    End Structure

    ''' <summary>
    ''' Allowed. Means readable not necessarily used in Generation
    ''' </summary>
    ''' <remarks></remarks>
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

#End Region


#Region "Methods"

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


#End Region



    Public Sub New(pParent As IColumnParent)
        Me.____Parent = pParent
        Me.ConstraintType = ConstraintTypes.NEUTRAL
    End Sub





End Class


