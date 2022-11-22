using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCs
{
    public class Account
    {
        private Decimal _balance = 0;
        public Account()
        {
        }
        public Account(int number, decimal balance)
        {
            Number = number;
            _balance = balance;
        }
        public int Number { get; set; }
        public bool Enabled { get; set; }
        public Decimal Balance { get => _balance; }
        public void Deposit(Decimal value)
        {
            plusBalance(value);
        }
        public void WithDraw(Decimal value)
        {
            plusBalance(-value);
        }
        private void plusBalance(decimal value)
        {
            _balance += value;
        }
    }
}
