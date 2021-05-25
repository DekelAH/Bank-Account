using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAndLogic
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string AccountNum { get; set; }
        public double CurrentAmount { get; set; }

        public Account(string firstName, string lastName, string address, string phoneNum, string accountNum, int currentAmount)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNum = phoneNum;
            AccountNum = accountNum;
            CurrentAmount = currentAmount;
        }

        // Registration
        public Account(string firstName, string lastName, string address, string phoneNum, string accountNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNum = phoneNum;
            AccountNum = accountNum;
        }

        public Account()
        {

        }

        public void ShowPersonalDetails()
        {
            Console.WriteLine($"-- Personal Details --\nFirst Name: {FirstName}\nLast Name: {LastName}\nAddress: {Address}\n" +
                              $"Phone Number: {PhoneNum}\nAccount Number: {AccountNum}");
            Console.WriteLine("<---------------------------------------------->\n");
        }

        public void EditPersonalDetails(string firstName, string lastName, string address, string phoneNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNum = phoneNum;
        }
    }
}
