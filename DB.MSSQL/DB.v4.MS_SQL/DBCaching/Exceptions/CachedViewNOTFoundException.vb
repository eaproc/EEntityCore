Imports CODERiT.Logger.v._3._5.Exceptions


Namespace DBCaching.Exceptions

    Public Class CachedViewNOTFoundException
        Inherits EException

        Sub New(ViewName As String)
            MyBase.New(ViewName & " is not among the cached views.")
        End Sub

    End Class


End Namespace