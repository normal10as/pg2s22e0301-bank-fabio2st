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

#Region "Account0"
        Dim account0 As New Account()
        account0.Number = 23434
        account0.Enabled = True

        Console.WriteLine("Número de cuenta: " & account0.Number)
        Console.WriteLine("Cuenta habilitada: " & account0.Enabled)
        Console.WriteLine("Saldo: " & account0.Balance)
        account0.Deposit(10000)
        Console.WriteLine("Saldo: " & account0.Balance)
        account0.Withdraw(4000)
        Console.WriteLine("Saldo: " & account0.Balance)
#End Region
    End Sub

    Private Sub ShowCustomer(customer0 As Customer)
        Console.WriteLine("Nombre :" & customer0.Name)
        Console.WriteLine("DNI :" & customer0.Dni)
        Console.WriteLine("Fecha de nacimiento :" & customer0.BirthDay)
        Console.WriteLine("Edad :" & customer0.Age)
        Console.WriteLine("Nacionalidad: " & customer0.Nationality)
    End Sub
End Module
