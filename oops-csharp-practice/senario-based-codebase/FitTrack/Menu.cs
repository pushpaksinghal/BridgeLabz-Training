using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class Menu
    {
        public void start()
        {
            utility utility = new utility();
            UserProfile user = null;
            user = utility.CreateUser();
            while (true)
            {
                Console.WriteLine("Start your fitness jurney");
                Console.WriteLine("1. Start Workout Challenge");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (user == null)
                        {
                            Console.WriteLine("Please login first.");
                        }
                        else
                        {
                            utility.StartWorkout(user);
                        }
                        break;

                    case 2:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
