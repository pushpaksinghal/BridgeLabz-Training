using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitnessTracker
{
    internal class FitnessMenu
    {
        IGroup g1 = new GroupUtility();

        public void Menu()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("WELCOME TO THE STEP COUNTER ");
                Console.WriteLine("1. Add a user");
                Console.WriteLine("2. Set LeaderBoard");
                Console.WriteLine("3. Add a days steps to a user");
                Console.WriteLine("4. View Leader Board");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        g1.AddUser();
                        break;
                    case 2:
                        g1.BubbleSortUser();
                        break;
                    case 3:
                        g1.AddSteps();
                        break;
                    case 4:
                        g1.LeaderBoard();
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.Error.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
