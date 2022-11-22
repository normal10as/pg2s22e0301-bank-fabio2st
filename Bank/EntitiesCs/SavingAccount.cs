using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCs
{
    public class SavingAccount : Account
    {
        public SavingAccount(int number, decimal balance, decimal monthlyInterestRate) : base(number, balance)
        {
            MonthlyInterestRate = monthlyInterestRate;
        }
        public decimal MonthlyInterestRate { get; set; }
        public void DepositMonthlyInterest()
        {
            Deposit(Balance * MonthlyInterestRate / 100);
        }
    }
}
