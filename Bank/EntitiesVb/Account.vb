Public Class Account
    Public Property Number As Integer
    Public Property Enabled As Boolean
    Private _balance As Decimal
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
    Public Sub Deposit(value As Decimal)
        plusBalance(value)
    End Sub
    Public Sub Withdraw(value As Decimal)
        plusBalance(-value)
    End Sub
    Private Sub plusBalance(value As Decimal)
        _balance = _balance + value
    End Sub
End Class
