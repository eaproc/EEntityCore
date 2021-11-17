Imports CODERiT.Logger.v._3._5.Exceptions

Namespace DBCaching.Exceptions

    Public Class PhantomOrDirtyReadException
        Inherits EException

        Sub New(TableName As String)
            MyBase.New(
                String.Format("One of the rows you are trying to UPDATE on {0} table has been deleted or updated since you last checked it. Please, try load table again for recent values!",
                                     TableName)
                                 )

        End Sub

    End Class

End Namespace