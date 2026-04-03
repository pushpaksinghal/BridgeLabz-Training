using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.access_modifiers
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();
            BankAccount a2 = new BankAccount(102, "pushpak", 5000);
            SavingsAccount s1 = new SavingsAccount();
            a1.Display();
            a2.Display();
            s1.Display();
        }
    }

    public class BankAccount
    {
        // creating atributes
        public int accountNumber;
        protected string accountHolder;
        private double balance;
        // consturctors
        public BankAccount()
        {
            this.accountNumber = 101;
            this.accountHolder = "Default User";
            this.balance = 1000;
        }
        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        // getter and setter 
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double amount)
        {
            if (amount >= 0)
            {
                balance = amount;
            }
            else
            {
                Console.WriteLine("invalid bal");
            }
        }
        public void Display()
        {
            Console.WriteLine("acc no. is " + accountNumber + " user name is " + accountHolder + " bal is " + GetBalance());
        }
    }
    public class SavingsAccount() : BankAccount(103, "Suresh", 8000)
    {
        // ceraing a display method for child class
        public void Display()
        {
            Console.WriteLine("savings acc no." + accountNumber + " user name is " + accountHolder + " bal is " + GetBalance());
        }
    }
}

