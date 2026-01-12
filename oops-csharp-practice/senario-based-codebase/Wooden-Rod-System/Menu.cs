using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class Menu
    {
        public static void Start()
        {
            Utility utility = new Utility();

            // Sample logs (can be replaced with user input)
            woodlog[] logs =
            {
                new woodlog(2, 5, 0.2),
                new woodlog(3, 8, 0.3),
                new woodlog(4, 9, 0.4),
                new woodlog(6, 17, 0.6)
            };

            while (true)
            {
                Console.WriteLine(" Wooden Rod Cutting System");
                Console.WriteLine("1. Scenario A: Maximize Revenue");
                Console.WriteLine("2. Scenario B: Maximize Revenue with Waste Constraint");
                Console.WriteLine("3. Scenario C: Maximize Revenue and Minimize Waste");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            int rodLength = 12;
                            double allowedWaste = double.MaxValue;
                            woodlog[] result = utility.FindOptimalLogs(logs, rodLength, allowedWaste);
                            Display(result);
                            break;
                        }
                    case 2:
                        {
                            int rodLength = 12;
                            Console.Write("Enter allowed waste: ");
                            double allowedWaste = Convert.ToDouble(Console.ReadLine());
                            woodlog[] result = utility.FindOptimalLogs(logs, rodLength, allowedWaste);
                            Display(result);
                            break;
                        }
                    case 3:
                        {
                            int rodLength = 12;
                            Console.Write("Enter allowed waste: ");
                            double allowedWaste = Convert.ToDouble(Console.ReadLine());
                            woodlog[] result = utility.FindOptimalLogs(logs, rodLength, allowedWaste);
                            Display(result);
                            break;
                        }
                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void Display(woodlog[] logs)
        {
            double totalPrice = 0;
            int totalLength = 0;
            double totalWaste = 0;

            Console.WriteLine("\nSelected Logs:");
            foreach (woodlog log in logs)
            {
                Console.WriteLine("Size:"+log.size+", Price: "+log.price+", Waste: "+log.waste);
                totalPrice += log.price;
                totalLength += log.size;
                totalWaste += log.waste;
            }

            Console.WriteLine("Total Length Used:"+totalLength);
            Console.WriteLine("Total Revenue:"+totalPrice);
            Console.WriteLine("Total Waste:"+totalWaste);
        }
    }

}
