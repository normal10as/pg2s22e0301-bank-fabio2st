Public Class SavingAccount
    Inherits Account
    Public Sub New(number As Integer, balance As Decimal, monthlyInterestRate As Decimal)
        MyBase.New(number, balance)
        Me.MonthlyInterestRate = monthlyInterestRate
    End Sub
    Public Property MonthlyInterestRate As Decimal
    Public Sub DepositMonthlyInterest()
        Deposit(Balance * MonthlyInterestRate / 100)
    End Sub
End Class
