Public Class Bank
    Private _customers As List(Of Customer)
    Public Sub New()
        _customers = New List(Of Customer)
    End Sub
    Public Sub AddCustomer(customer As Customer)
        _customers.Add(customer)
    End Sub
    Public Function GetCustomers() As List(Of Customer)
        Return _customers
    End Function
End Class
