Public Class ThreadExtensions
    Private args() As Object
    Private DelegateToInvoke As [Delegate]

    Public Shared Function QueueUserWorkItem(ByVal method As [Delegate], ByVal ParamArray args() As Object) As Boolean
        Return Threading.ThreadPool.QueueUserWorkItem(AddressOf ProperDelegate, New ThreadExtensions With {.args = args, .DelegateToInvoke = method})
    End Function

    Private Shared Sub ProperDelegate(ByVal state As Object)
        Dim sd As ThreadExtensions = DirectCast(state, ThreadExtensions)

        sd.DelegateToInvoke.DynamicInvoke(sd.args)
    End Sub

    Public Shared Sub ScSend(ByVal sc As Threading.SynchronizationContext, ByVal del As [Delegate], ByVal ParamArray args() As Object)
        sc.Send(New Threading.SendOrPostCallback(AddressOf ProperDelegate), New ThreadExtensions With {.args = args, .DelegateToInvoke = del})
    End Sub

End Class
