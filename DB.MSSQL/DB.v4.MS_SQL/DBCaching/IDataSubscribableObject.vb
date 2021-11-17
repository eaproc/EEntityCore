Namespace DBCaching

    Friend Interface IDataSubscribableObject


        Sub unsubcribeUserFromDataChanged(pNotifier As DBCaching.Interfaces.INotifyTableChanged)


        Sub subcribeUserForDataChanged(pNotifyReceiver As DBCaching.Interfaces.INotifyTableChanged,
                                               pIntervalInMillisecs As Int32)

        Sub NotifyAllDataChangedSubscribers()


        Sub NotifyDataChangedSubscriber(pSubscriber As DBCaching.Interfaces.INotifyTableChanged)

    End Interface


End Namespace
