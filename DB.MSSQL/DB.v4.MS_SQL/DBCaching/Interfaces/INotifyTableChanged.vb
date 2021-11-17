Namespace DBCaching.Interfaces

    Public Interface INotifyTableChanged
        Inherits System.ComponentModel.IComponent


        ''' <summary>
        ''' Fires when a table is updated in Cache Manager. Also, it unscribes this notifier. Threaded. You need to call invoke when necessary
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <remarks></remarks>
        Sub TableChangedEventOccurred(ByVal TableName As String)


    End Interface


End Namespace
