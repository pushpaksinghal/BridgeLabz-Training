using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    sealed internal class Menu
    {
        public void start()
        {
            Utility utility = new Utility();
            while (true)
            {
                Console.WriteLine("1. Input Loan Details");
                Console.WriteLine("2. Get Loan Status");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.InputDetail();
                        break;
                    case 2:
                        utility.GetLoanStatus();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
