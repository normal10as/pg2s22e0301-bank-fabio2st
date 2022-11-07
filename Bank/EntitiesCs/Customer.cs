namespace EntitiesCs
{
    public class Customer
    {
        private string name;
        private int dni;
        private DateTime birthDay;
        public Customer()
        {
            Nationality = "Argentino";
        }
        public Customer(string name, int dni) : this()
        {
            Name = name;
            Dni = dni;
        }
        public Customer(string name, int dni, DateTime birthDay) : this(name, dni)
        {
            BirthDay = birthDay;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                    name = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                if (value > 999999)
                    dni = value;
            }
        }
        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set 
            {
                if (value.AddYears(18) < DateTime.Now)
                    birthDay = value;
            }
        }
        public UInt16 Age
        {
            get
            {
                int age = DateTime.Now.Year - birthDay.Year;
                // si no cumplio años descontar
                return (UInt16)age;
            }
        }
        public string Nationality { get; set; }
    }
}