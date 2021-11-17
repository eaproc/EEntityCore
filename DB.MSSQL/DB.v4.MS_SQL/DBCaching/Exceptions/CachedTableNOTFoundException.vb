Imports CODERiT.Logger.v._3._5.Exceptions


Namespace DBCaching.Exceptions

    Public Class CachedTableNOTFoundException
        Inherits EException

        Sub New(TableName As String)
            MyBase.New(TableName & " is not among the cached tables.")
        End Sub

    End Class


End Namespace