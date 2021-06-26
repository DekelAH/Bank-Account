using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class EngineUI
    {
        readonly ModelAndLogic.Account newAccount = new ModelAndLogic.Account();
        readonly ModelAndLogic.Logic logicAccess = new ModelAndLogic.Logic();

        public void Intro()
        {
            Console.WriteLine("<~~ Welcome To DigiBank! ~~>\nThe Most Effective Bank In The Web World!");
            Console.WriteLine("To start the journy with us and letting us manage your account, please fill up the next details:");
        }

        public void Registration()
        {
            Console.Write("First Name (Minimun 2 characters): ");
            string firstNameInput = Console.ReadLine();
            while (string.IsNullOrEmpty(firstNameInput) || string.IsNullOrWhiteSpace(firstNameInput)
                    || int.TryParse(firstNameInput, out _) || firstNameInput.Length < 2)
            {
                Console.Write("Please enter a valid input! Try again: ");
                firstNameInput = Console.ReadLine();
            }

            Console.Write("Last Name (Minimun 2 characters): ");
            string lastNameInput = Console.ReadLine();
            while (string.IsNullOrEmpty(lastNameInput) || string.IsNullOrWhiteSpace(lastNameInput)
                    || int.TryParse(lastNameInput, out _) || lastNameInput.Length < 2)
            {
                Console.Write("Please enter a valid input! Try again: ");
                lastNameInput = Console.ReadLine();
            }
            newAccount.LastName = lastNameInput;

            Console.Write("Address(country & city(Example: UK, London), (Minimun 2 characters)): ");
            string addressInput = Console.ReadLine();
            while (string.IsNullOrEmpty(addressInput) || string.IsNullOrWhiteSpace(addressInput)
                    || int.TryParse(addressInput, out _) || addressInput.Length < 5)
            {
                Console.Write("Please enter a valid input! Try again: ");
                addressInput = Console.ReadLine();
            }
            newAccount.Address = addressInput;

            Console.Write("Phone Number (Required 10 digits): ");
            string phoneNumInput = Console.ReadLine(); ;
            while (string.IsNullOrEmpty(phoneNumInput) || string.IsNullOrWhiteSpace(phoneNumInput)
                    || phoneNumInput.Length != 10)
            {
                Console.Write("Please enter a valid input! Try again: ");
                phoneNumInput = Console.ReadLine();
            }
            newAccount.PhoneNum = phoneNumInput;


            Console.Write("Choose yourself an account number (Required 8 digits): ");
            string accountNumInput = Console.ReadLine();
            while (string.IsNullOrEmpty(accountNumInput) || string.IsNullOrWhiteSpace(accountNumInput)
                    || accountNumInput.Length != 8)
            {
                Console.Write("Please enter a valid input! Try again: ");
                accountNumInput = Console.ReadLine();
            }
            newAccount.AccountNum = accountNumInput;

            Console.Clear();
            newAccount.ShowPersonalDetails();
            Console.WriteLine("Press any key to continue :)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("<~~ Congrats! We're happy you chose to open an account in our bank! ~~>");
        }

        public void Menu()
        {
            string choiceInput;
            do
            {
                Console.WriteLine("Please choose one of the following actions by pressing the number:\n" +
                     "1.Show Details\n2.Edit Personal Details\n3.Deposit\n4.Withdraw\n5.Check current balance\nType 'e' for Exit");
                choiceInput = Console.ReadLine();

                switch (choiceInput)
                {
                    case "1":
                        Console.Clear();
                        newAccount.ShowPersonalDetails();
                        break;
                    case "2":
                        EditUI();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Please enter an amount to deposit to your account: ");
                        double amountToDeposit;
                        if (double.TryParse(Console.ReadLine(), out amountToDeposit) && amountToDeposit > 0)
                        {
                            logicAccess.Deposit(amountToDeposit);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input! Try again.");
                            continue;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Please enter an amount to withdraw from your account: ");
                        double amountToWithdraw;
                        if (double.TryParse(Console.ReadLine(), out amountToWithdraw))
                        {
                            logicAccess.Withdraw(amountToWithdraw);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input! Try again.");
                            continue;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        logicAccess.CurrentBalance();
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (!choiceInput.Equals("e"));

            Console.Clear();
            Console.WriteLine("See You Next Time! =]");
        }

        public void EditUI()
        {
            string editChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("To edit one of your personal details, please choose one of the following options:\n" +
                                  "1.First name\n2.Last name\n3.Address\n4.Phone number\nType 'e' to exit to menu");
                editChoice = Console.ReadLine();
                switch (editChoice)
                {
                    case "1":
                        Console.Write("Please enter your change: ");
                        string firstNameToEdit = Console.ReadLine();
                        while (string.IsNullOrEmpty(firstNameToEdit) || string.IsNullOrWhiteSpace(firstNameToEdit)
                                || firstNameToEdit.Length < 2)
                        {
                            Console.Write("Please enter a valid input! Try again: ");
                            firstNameToEdit = Console.ReadLine();
                        }
                        newAccount.FirstName = firstNameToEdit;
                        break;
                    case "2":
                        Console.Write("Please enter your change: ");
                        string lastNameToEdit = Console.ReadLine();
                        while (string.IsNullOrEmpty(lastNameToEdit) || string.IsNullOrWhiteSpace(lastNameToEdit)
                                || lastNameToEdit.Length < 2)
                        {
                            Console.Write("Please enter a valid input! Try again: ");
                            lastNameToEdit = Console.ReadLine();
                        }
                        newAccount.LastName = lastNameToEdit;
                        break;
                    case "3":
                        Console.Write("Please enter your change: ");
                        string addressToEdit = Console.ReadLine();
                        while (string.IsNullOrEmpty(addressToEdit) || string.IsNullOrWhiteSpace(addressToEdit)
                                || addressToEdit.Length < 5)
                        {
                            Console.Write("Please enter a valid input! Try again: ");
                            addressToEdit = Console.ReadLine();
                        }
                        newAccount.Address = addressToEdit;
                        break;
                    case "4":
                        Console.Write("Please enter your change: ");
                        string phoneNumToEdit = Console.ReadLine();
                        while (string.IsNullOrEmpty(phoneNumToEdit) || string.IsNullOrWhiteSpace(phoneNumToEdit)
                                || phoneNumToEdit.Length != 10)
                        {
                            Console.Write("Please enter a valid input! Try again: ");
                            phoneNumToEdit = Console.ReadLine();
                        }
                        newAccount.PhoneNum = phoneNumToEdit;
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (!editChoice.Equals("e"));

            Console.Clear();
        }
    }
}
