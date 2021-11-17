Imports CODERiT.Logger.Standard.VB.Exceptions

Namespace Exceptions


    REM Encrypt connection string

    Public Class SQLServerConnectionException
        Inherits EException

#Region "Constructors"

        Public Sub New(pValConnectionString As String)

            Me.New("INVALID CONNECTION", pValConnectionString)

        End Sub


        Sub New(ByVal ex As Exception, pValConnectionString As String)

            Me.New(ex.Message, pValConnectionString, ex)

        End Sub



        Sub New(ByVal Title As String, pValConnectionString As String, ByVal ex As Exception)


            Me.Load(Title,
                    New String() {"Check to see that the connection parameters are correct",
                                  "Check to see if this pc can ping the server ip.",
                              "CONNECTION STRING: " & pValConnectionString},
                    New String() {ex.Message, ex.StackTrace}
                    )


        End Sub



        Sub New(ByVal Title As String, pValConnectionString As String)

            Me.New(Title, pValConnectionString, New Exception(Title))

        End Sub




#End Region



    End Class


End Namespace