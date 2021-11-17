Imports CODERiT.Logger.v._3._5
Imports DB.v4.MS_SQL.Interfaces


Namespace DBConcurrency

    Public Class ReadCommittedTransactionManager
        Inherits SQLDatabaseTransactionManager

#Region "Constructors"
        ''' <summary>
        ''' Initialize
        ''' </summary>
        ''' <param name="__Logger"></param>
        ''' <param name="ptrConn"></param>
        ''' <param name="DefaultTimeoutMillSecs">If this is zero secs it will keep waiting forever</param>
        ''' <remarks></remarks>
        Sub New(ByVal __Logger As Log1, ByVal ptrConn As ISQLServerDBPointer,
                                Optional ByVal DefaultTimeoutMillSecs As Integer = 2000)

            MyBase.New(__Logger:=__Logger, ptrConn:=ptrConn, IsoLevel:=Transactions.IsolationLevel.ReadCommitted,
                       DefaultTimeoutMillSecs:=DefaultTimeoutMillSecs)
        End Sub

#End Region




#Region "Methods"

        ''' <summary>
        ''' For the whole table. Check if a table is currently locked by select all ID rows using ReadComitted, 
        ''' Need the table to have a ID Column of Int else this function will fail
        ''' </summary>
        ''' <param name="TableName">The name of the table to check</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsDBTableLocked(ByVal TableName As String) As Boolean

            Try

                Dim fakeFastSQL As String = String.Format("SELECT ID FROM {0}", TableName)
                Me.getRS(1000, New GetRSTrans(fakeFastSQL, True))

                Return False
            Catch ex As Exception
                Me.Logger.Print("IsTableLocked", ex)
            End Try

            Return True
        End Function


#End Region


    End Class

End Namespace