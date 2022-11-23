Public Class Account
    Public Sub New()

    End Sub
    Public Sub New(number As Integer, balance As Decimal)
        Me.Number = number
        _balance = balance
    End Sub
    Public Property Number As Integer
    Public Property Enabled As Boolean
    Private _balance As Decimal
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property
    Public Property Customer As Customer

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
