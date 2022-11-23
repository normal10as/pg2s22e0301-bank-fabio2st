Imports EntitiesVb

Module Program
    Sub Main(args As String())
#Region "Customer0"
        Dim customer0 As New Customer()
        customer0.Name = "Juan Perez"
        customer0.Dni = 544466
        customer0.BirthDay = #2000-05-8#
        ShowCustomer(customer0)
#End Region
#Region "Customer1"
        Dim customer1 As New Customer()
        customer1.Name = "Alf"
        Console.WriteLine("Nombre :" & customer1.Name)
        customer1.Name = "Alf Tunner"
        Console.WriteLine("Nombre :" & customer1.Name)
        customer1.Dni = 5435
        Console.WriteLine("DNI :" & customer1.Dni)
        customer1.Dni = 54354565
        Console.WriteLine("DNI :" & customer1.Dni)
        customer1.BirthDay = #2010-05-08#
        Console.WriteLine("Fecha de nacimiento :" & customer1.BirthDay)
        customer1.BirthDay = #1757-10-28#
        Console.WriteLine("Fecha de nacimiento :" & customer1.BirthDay)
        Console.WriteLine("Edad :" & customer1.Age)
        customer1.Nationality = "Extraterrestrial"
        Console.WriteLine("Nacionalidad: " & customer1.Nationality)
#End Region
#Region "Customer2"
        Dim customer2 = New Customer("Juana", 34567890)
        ShowCustomer(customer2)
#End Region
#Region "Customer3"
        Dim customer3 = New Customer("Jhon", 12345678, #1990-2-25#)
        ShowCustomer(customer3)
#End Region
#Region "Banco"
        Dim bank As New Bank()
        bank.AddCustomer(customer0)
        bank.AddCustomer(customer1)
        bank.AddCustomer(customer2)
        bank.AddCustomer(customer3)
        Console.WriteLine("Lista de clientes")
        For Each customer As Customer In bank.GetCustomers
            Console.WriteLine(customer.Name)
        Next
#End Region
#Region "Account0"
        Dim account0 As New Account()
        account0.Number = 23434
        account0.Enabled = True
        account0.Customer = customer1
        ShowAccount(account0)
        account0.Deposit(10000)
        Console.WriteLine("Saldo: " & account0.Balance)
        account0.Withdraw(4000)
        Console.WriteLine("Saldo: " & account0.Balance)
#End Region
#Region "Account1"
        Dim account1 As New SavingAccount(34567, 0, 5)
        account1.Customer = customer2
        ShowAccount(account1)
        account1.Deposit(10000)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.Withdraw(4000)
        Console.WriteLine("Saldo: " & account1.Balance)
        account1.DepositMonthlyInterest()
        Console.WriteLine("Saldo: " & account1.Balance)
#End Region
    End Sub

    Private Sub ShowAccount(account As Account)
        Console.WriteLine("Número de cuenta: " & account.Number)
        Console.WriteLine("Cliente: " & account.Customer.Name)
        Console.WriteLine("Cuenta habilitada: " & account.Enabled)
        Console.WriteLine("Saldo: " & account.Balance)
    End Sub
    Private Sub ShowAccount(savingAccount As SavingAccount)
        ShowAccount(DirectCast(savingAccount, Account))
        Console.WriteLine("Interes Mensual: " & savingAccount.MonthlyInterestRate & "%")
    End Sub

    Private Sub ShowCustomer(customer As Customer)
        Console.WriteLine("Nombre: " & customer.Name)
        Console.WriteLine("DNI: " & customer.Dni)
        Console.WriteLine("Fecha de nacimiento: " & customer.BirthDay)
        Console.WriteLine("Edad: " & customer.Age)
        Console.WriteLine("Nacionalidad: " & customer.Nationality)
    End Sub
End Module
