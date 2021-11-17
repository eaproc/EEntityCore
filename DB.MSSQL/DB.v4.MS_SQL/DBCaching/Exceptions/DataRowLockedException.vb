Imports CODERiT.Logger.v._3._5.Exceptions

Namespace DBCaching.Exceptions

    Public Class DataRowLockedException
        Inherits EException

        Sub New(TableName As String)
            MyBase.New(String.Format("One of the rows you are trying to DELETE or UPDATE on {0} table is in use by another process/user. Please, try again later!",
                                     TableName)
                                 )

        End Sub

    End Class

End Namespace