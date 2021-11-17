Imports CODERiT.Logger.v._3._5.Exceptions

Namespace Exceptions



    Public Class SQLCodeException
        Inherits EException

#Region "Constructors"


        Sub New(ByVal ex As Exception)

            Me.New(ex.Message, ex)

        End Sub



        Sub New(ByVal SQLCode As String, ByVal ex As Exception)


            Me.Load(SQLCode,
                    New String() {"Check SQL Query Syntax."},
                    New String() {ex.Message, ex.StackTrace}
                    )


        End Sub

#End Region




    End Class


End Namespace