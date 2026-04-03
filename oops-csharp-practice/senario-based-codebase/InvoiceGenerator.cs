using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class InvoiceGenerator
    {
        static string[] ParseInvoice(string input)
        {
            string[] task = input.Split(",");
            return task;
        }

        static int GetTotalAmount(string[] task)
        {
            int total = 0;
            for (int i = 0; i < task.Length; i++)
            {
                string taskWithNoSpace = task[i].Trim();

                string[] taskPart = taskWithNoSpace.Split(" - ");
                string[] getAmount = taskPart[1].Split(" ");

                int amount = Convert.ToInt32(getAmount[0]);
                total += amount;

            }
            return total; //returning total amount.
        }
        static void Main()
        {
            //initialising the variables
            string input;
            string[] tasks = null;
            int total = 0;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press 1 to create a new invoice");
                Console.WriteLine("Press 2 to Generate Total Bill");
                Console.WriteLine("Press 3 to exit this menu");
                int choice = int.Parse(Console.ReadLine()); //freelancer will choose one of the options
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the services user wants to take with its price");
                        input = Console.ReadLine();
                        //calling our methods
                        tasks = ParseInvoice(input);
                        total = GetTotalAmount(tasks);

                        continue;

                    case 2:
                        //Generates total bill
                        Console.WriteLine("Services You have selected are: \n");
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            Console.WriteLine($"{tasks[i].Trim()}");
                        }
                        Console.WriteLine($"Total amount   -       {total} INR");
                        continue;

                    case 3:
                        //exit
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
