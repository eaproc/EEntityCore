Imports CODERiT.Logger.v._3._5.Exceptions


Namespace DBCaching.Exceptions
    Public Class InvalidTableStructureException
        Inherits EException

        Sub New(TableName As String)
            MyBase.New(TableName & " is not well configured. It must have ID (int) and RowVersion (varchar(150)) Column")
        End Sub

    End Class

End Namespace