
Namespace DBCaching



    Friend Class IEqualityComparer__CachedObjectSubscriber
        Implements IEqualityComparer(Of CachedObjectSubscriber)





        Public Function Equals1(x As CachedObjectSubscriber, y As CachedObjectSubscriber) As Boolean Implements IEqualityComparer(Of CachedObjectSubscriber).Equals
            Return x.Equals(y)
        End Function

        Public Function GetHashCode1(obj As CachedObjectSubscriber) As Integer Implements IEqualityComparer(Of CachedObjectSubscriber).GetHashCode
            Return obj.GetHashCode()
        End Function

    End Class


End Namespace
