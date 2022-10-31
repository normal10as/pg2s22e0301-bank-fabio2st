using EntitiesCs;
namespace DemoCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Customer1
            Customer customer0 = new Customer();
            customer0.Name = "Juan Perez";
            customer0.Dni = 35456665;
            customer0.BirthDay = new DateTime(2000, 5, 8);

            Console.WriteLine("Nombre: " + customer0.Name);
            Console.WriteLine("DNI: " + customer0.Dni);
            Console.WriteLine("Fecha de Nacimiento: " + customer0.BirthDay);
            Console.WriteLine("Edad: " + customer0.Age);
            #endregion

            #region Customer2
            Customer customer1 = new Customer();
            customer1.Name = "Alf";
            Console.WriteLine("Nombre: " + customer1.Name);
            customer1.Name = "Alf Tunner";
            Console.WriteLine("Nombre: " + customer1.Name);
            customer1.Dni = 235435;
            Console.WriteLine("DNI: " + customer1.Dni);
            customer1.Dni = 2354355;
            Console.WriteLine("DNI: " + customer1.Dni);

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
            #region
        }
    }
}