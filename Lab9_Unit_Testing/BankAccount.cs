using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Unit_Testing
{
   public class BankAccount
    {
        public decimal Balance { get; set; }
        public decimal OverdraftLimit { get; set; }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void WithDraw(decimal amount)
        {
            decimal availableFunds = Balance + OverdraftLimit;
            if (availableFunds >= amount) //Checks that there is enough money in Balance
            {

                Balance -= amount;
            }
         
        }
    }
}
