using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCs
{
    public class Bank
    {
        private List<Customer> customers;
        public Bank()
        {
            customers = new();
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
