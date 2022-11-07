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

            #region Customer3
            Customer customer3 = new Customer("Juana", 35466575);
            ShowCustomer(customer3);
            #endregion

            #region Customer4
            Customer customer4 = new Customer("Jhon", 12345678, new DateTime(1990, 2, 25));
            ShowCustomer(customer4);
            #endregion


            customer1.BirthDay = new DateTime(2010, 5, 8);
            Console.WriteLine("Fecha de Nacimiento: " + customer1.BirthDay);
            customer1.BirthDay = new DateTime(1757, 10, 28);
            Console.WriteLine("Fecha de Nacimiento: " + customer1.BirthDay);
            Console.WriteLine("Edad: " + customer1.Age);
            #endregion

            #region Account0
            Account account0 = new Account();
            account0.Number = 323445;
            account0.Enabled = true;
            Console.WriteLine("Cuenta número: " + account0.Number);
            Console.WriteLine("Cuenta habilitada: " + account0.Enabled);
            Console.WriteLine("Saldo: " + account0.Balance);
            account0.Deposit(10000);
            Console.WriteLine("Saldo: " + account0.Balance);
            account0.WithDraw(4000);
            Console.WriteLine("Saldo: " + account0.Balance);
            #endregion
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