using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(123456789, "pushpak");
            BankAccount acc2 = new BankAccount(123456790, "singhal");

            acc1.Display();
            acc2.Display();

            BankAccount.TotalAccount();
            // using is operator
            if (acc1 is BankAccount)
            {
                Console.WriteLine("acc1 is obj of BankAccount");
            }

        }



    }
    public class BankAccount
    {    // static variable
        public static string name = "B.D.V. indian bank";
        private static int totalAccount = 0;

        protected string userName;
        private readonly int AccountNumber;
        public BankAccount(int accountNumber,string userName)
        {
            // using this keyword
            this.AccountNumber = accountNumber;
            this.userName = userName;
            totalAccount++;
        }

        public static void TotalAccount()
        {
            Console.WriteLine("the total number of account are " + totalAccount);
        }

        public void Display()
        {
            Console.WriteLine("hte user name is " + userName + " the account number is " + AccountNumber + " in " + name +);
        }

    }
}
