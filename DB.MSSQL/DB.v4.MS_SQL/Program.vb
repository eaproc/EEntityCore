Imports EPRO.Library.v3._5
Imports EPRO.Library.v3._5.Objects
Imports EPRO.Library.v3._5.AppConfigurations

Imports CODERiT.Logger.v._3._5

Imports DB.v4.MS_SQL.Interfaces

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




#End Region


#Region "Enums"



#End Region










#Region "Methods"



#End Region





End Class
