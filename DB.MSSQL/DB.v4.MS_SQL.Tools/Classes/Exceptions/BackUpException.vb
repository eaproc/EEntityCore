Imports CODERiT.Logger.v._3._5.Exceptions

Namespace Exceptions



    Public Class BackUpException
        Inherits EException

#Region "Constructors"

        Sub New()

            MyBase.New("Error Backing up Database.")
            Me.Load("Error Backing up Database.",
                    New String() {"Check to see you have full access to the destination folder."}
                    )


        End Sub
#End Region


    End Class


End Namespace