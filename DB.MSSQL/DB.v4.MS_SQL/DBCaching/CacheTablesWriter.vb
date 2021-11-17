Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization


Namespace DBCaching

    <Serializable()> _
    Friend Class CacheTablesWriter
        REM  Implements ISerializable


        Sub New(__CachedTables As Dictionary(Of String, DBCaching.CachedTable))

            Me.___CachedTables = __CachedTables

        End Sub

        Private ___CachedTables As Dictionary(Of String, DBCaching.CachedTable)
        Public ReadOnly Property CachedTables As Dictionary(Of String, DBCaching.CachedTable)
            Get
                Return Me.___CachedTables
            End Get
        End Property


        Public Function Write(ByVal CachedTableMgrFileFullPath As String) As Boolean
            Try
                REM Try to create directory if it doesn't exist
                If Not Directory.Exists(FileIO.FileSystem.GetParentPath(CachedTableMgrFileFullPath)) Then Directory.CreateDirectory(FileIO.FileSystem.GetParentPath(CachedTableMgrFileFullPath))

                Using fw As New FileStream(CachedTableMgrFileFullPath, FileMode.Create)
                    Dim bw As New BinaryFormatter()
                    bw.Serialize(fw, Me)
                    fw.Close()
                End Using
                Return True
            Catch ex As Exception
                Throw ex
            End Try
            Return False
        End Function

        ''' <summary>
        ''' Throws Exception.
        ''' </summary>
        ''' <param name="CachedTableMgrFileFullPath"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Read(ByVal CachedTableMgrFileFullPath As String) As Dictionary(Of String, DBCaching.CachedTable)
            Try
                Using fw As New FileStream(CachedTableMgrFileFullPath, FileMode.Open)
                    Dim bw As New BinaryFormatter()
                    Dim ctw As CacheTablesWriter = CType(bw.Deserialize(fw), CacheTablesWriter)
                    fw.Close()
                    Return ctw.CachedTables
                End Using
            Catch ex As Exception
                Throw ex
            End Try
            Return Nothing
        End Function


        'Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        '    info.AddValue("___CachedTables", Me.___CachedTables)
        'End Sub
    End Class

End Namespace