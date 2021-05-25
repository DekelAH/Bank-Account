using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAndLogic
{
    public class Logic
    {
        readonly Account propAccess = new Account();
        public void Withdraw(double amount)
        {
            propAccess.CurrentAmount -= amount;
            Console.WriteLine($"Your current balance is: {propAccess.CurrentAmount}$");
        }

        public void Deposit(double amount)
        {
            propAccess.CurrentAmount += amount;
            Console.WriteLine($"Your current balance is: {propAccess.CurrentAmount}$");
        }

        public void CurrentBalance()
        {
            Console.WriteLine($"Your current balance is: {propAccess.CurrentAmount}$");
        }

    }
}
