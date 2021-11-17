Imports CODERiT.Logger.v._3._5.Exceptions

Namespace Exceptions



    Public Class OnNetworkClientConnectionException
        Inherits EException

#Region "Constructors"

        Sub New(ByVal Port As Int32)


            Me.Load("Clients Can NOT Connect to this PC as a Server Machine",
                    New String() {String.Format("Check to see that the connection port [ {0} ] is not in used.", Port),
                                  "Check to see if this pc can ping the server ip.",
                                  "Check to see if firewall does not have blocked inbound rule for this app or port."}
                    )


        End Sub
#End Region


    End Class


End Namespace