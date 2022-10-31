namespace EntitiesCs
{
    public class Customer
    {
        private string name;
        private int dni;
        private DateTime birthDay;

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
    }
}