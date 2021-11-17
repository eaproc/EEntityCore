

Imports System.Reflection
Imports CODERiT.Logger.Standard.VB

'
'
'
'
'

Public Class Program


    Shared Sub New()
        Logger = New Log1(GetType(Program)).Load(Log1.Modes.FILE, True)

    End Sub



#Region "Properties"




    Friend Shared Property Logger As Log1

    Public Shared ReadOnly Property ApplicationStartUpPath As String
        Get
            Return AppDomain.CurrentDomain.BaseDirectory
        End Get
    End Property


#End Region


#Region "Enums"



#End Region










#Region "Methods"



#End Region





End Class
