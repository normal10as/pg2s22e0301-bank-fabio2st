using EntitiesCs;
namespace DemoCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Customer0
            Customer customer0 = new Customer();
            customer0.Name = "Juan Perez";
            customer0.Dni = 35456665;
            customer0.BirthDay = new DateTime(2000, 5, 8);

            ShowCustomer(customer0);
            #endregion
            #region Customer1
            Customer customer1 = new Customer();
            customer1.Name = "Alf";
            Console.WriteLine("Nombre: " + customer1.Name);
            customer1.Name = "Alf Tunner";
            Console.WriteLine("Nombre: " + customer1.Name);
            customer1.Dni = 235435;
            Console.WriteLine("DNI: " + customer1.Dni);
            customer1.Dni = 2354355;
            Console.WriteLine("DNI: " + customer1.Dni);
            customer1.Nationality = "Extraterrestial";
            Console.WriteLine("Nacionalidad: " + customer1.Nationality);
            customer1.BirthDay = new DateTime(2010, 5, 8);
            Console.WriteLine("Fecha de Nacimiento: " + customer1.BirthDay);
            customer1.BirthDay = new DateTime(1757, 10, 28);
            Console.WriteLine("Fecha de Nacimiento: " + customer1.BirthDay);
            Console.WriteLine("Edad: " + customer1.Age);
            #endregion
            #region Customer2
            Customer customer2 = new Customer("Juana", 35466575);
            ShowCustomer(customer2);
            #endregion
            #region Customer3
            Customer customer3 = new Customer("Jhon", 12345678, new DateTime(1990, 2, 25));
            ShowCustomer(customer3);
            #endregion
            #region
            Bank bank = new Bank();
            bank.AddCustomer(customer0);
            bank.AddCustomer(customer1);
            bank.AddCustomer(customer2);
            bank.AddCustomer(customer3);

            Console.WriteLine("Lista de clientes");
            foreach (Customer customer in bank.GetCustomers())
            {
                Console.WriteLine(customer.Name);
            }
            #endregion
            #region Account0
            Account account0 = new Account();
            account0.Number = 323445;
            account0.Enabled = true;
            account0.Customer = customer1;
            ShowAccount(account0);
            account0.Deposit(10000);
            Console.WriteLine("Saldo: " + account0.Balance);
            account0.WithDraw(4000);
            Console.WriteLine("Saldo: " + account0.Balance);
            #endregion
            #region Account1
            SavingAccount account1 = new SavingAccount(34567, 0, 5);
            account1.Customer = customer2;
            ShowAccount(account1);
            
            account1.Deposit(10000);          
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.WithDraw(4000);
            Console.WriteLine("Saldo: " + account1.Balance);
            account1.DepositMonthlyInterest();
            Console.WriteLine("Saldo: " + account1.Balance);
            #endregion        
        }

        private static void ShowAccount(Account account)
        {
            Console.WriteLine("Cuenta número: " + account.Number);
            Console.WriteLine("Cliente: " + account.Customer.Name);
            Console.WriteLine("Cuenta habilitada: " + account.Enabled);
            Console.WriteLine("Saldo: " + account.Balance);
        }
        private static void ShowAccount(SavingAccount savingAccount)
        {
            ShowAccount((Account)savingAccount);
            Console.WriteLine("Interes mensual: " + savingAccount.MonthlyInterestRate);
        }
        private static void ShowCustomer(Customer customer)
        {
            Console.WriteLine("Nombre: " + customer.Name);
            Console.WriteLine("DNI: " + customer.Dni);
            Console.WriteLine("Fecha de Nacimiento: " + customer.BirthDay);
            Console.WriteLine("Edad: " + customer.Age);
            Console.WriteLine("Nacionalidad: " + customer.Nationality);
        }
    }
}