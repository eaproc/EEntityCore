

Namespace DBEntities.DatabaseSchema
    Public Class CredentialManager
        Implements IDisposable

        Public Sub New(MASTER_RECORD__DBNAME As String, MASTER_RECORD__USERNAME As String, MASTER_RECORD__USERPASSWORD As String, DATABASE_PORT As Int32,
                                        DATABASE_IP As String)


            DatabaseInit.DBConnectInterface = New DatabaseInit(
            New DefaultDatabaseInit(MASTER_RECORD__DBNAME, MASTER_RECORD__USERNAME, MASTER_RECORD__USERPASSWORD, DATABASE_PORT,
                                    DATABASE_IP)
                                )

            Me.DATABASE_IP = DATABASE_IP
            Me.DATABASE_PORT = DATABASE_PORT
            Me.MASTER_RECORD__DBNAME = MASTER_RECORD__DBNAME
            Me.MASTER_RECORD__USERNAME = MASTER_RECORD__USERNAME
            Me.MASTER_RECORD__USERPASSWORD = MASTER_RECORD__USERPASSWORD

        End Sub

        Public Sub New(cr As CredentialManager)
            Me.New(MASTER_RECORD__DBNAME:=cr.MASTER_RECORD__DBNAME,
               DATABASE_IP:=cr.DATABASE_IP,
               DATABASE_PORT:=cr.DATABASE_PORT,
               MASTER_RECORD__USERNAME:=cr.MASTER_RECORD__USERNAME,
               MASTER_RECORD__USERPASSWORD:=cr.MASTER_RECORD__USERPASSWORD
               )
        End Sub







#Region "Consts"


        Protected DATABASE_PORT As Int32
        Protected DATABASE_IP As String
        Protected MASTER_RECORD__DBNAME As String
        Protected MASTER_RECORD__USERNAME As String
        Protected MASTER_RECORD__USERPASSWORD As String




#End Region



#Region "Structures"



#End Region





#Region "Methods"



#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            Me.disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region


#End Region











    End Class

End Namespace

