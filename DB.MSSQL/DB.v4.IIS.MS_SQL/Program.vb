

Imports CODERiT.Logger.v._3._5

Imports DB.v4.IIS.MSSQL.Interfaces
Imports System.Reflection

'
'
'
'
'

Friend Class Program


    Shared Sub New()
        Logger = New Log1(GetType(Program)).Load(Log1.Modes.FILE, True)

    End Sub



#Region "Properties"




    Friend Shared Property Logger As Log1

    Public Shared ReadOnly Property ApplicationStartUpPath As String
        Get
            Return AssemblyDirectory(GetType(Program).Assembly)
        End Get
    End Property


    Public Shared Function AssemblyDirectory(p As Assembly) As String

        Dim codeBase As String = p.CodeBase
        Dim uri__1 As New UriBuilder(codeBase)
        Dim path__2 As String = Uri.UnescapeDataString(uri__1.Path)
        Return IO.Path.GetDirectoryName(path__2)

    End Function


#End Region


#Region "Enums"



#End Region










#Region "Methods"



#End Region





End Class
