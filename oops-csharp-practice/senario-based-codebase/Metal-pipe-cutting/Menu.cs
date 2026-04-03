using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Metal_pipe_cutting
{
    internal class Menu
    {
        public static void Start()
        {
            utility utility = new utility();
            Pipe[] pipes = utility.ReadPipe();

            Console.Write("\nEnter rod length: ");
            int rodLength = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Metal Factory Pipe Cutting");
                Console.WriteLine("1. Scenario A: Max Revenue");
                Console.WriteLine("2. Scenario B: Custom Order Impact");
                Console.WriteLine("3. Scenario C: Edge Case (Invalid Cut)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double revenueA =
                            utility.FindBestCut(pipes, rodLength);
                        Console.WriteLine("Max Revenue:"+revenueA);
                        break;

                    case 2:
                        Console.Write("Enter mandatory cut length: ");
                        int mandatory = Convert.ToInt32(Console.ReadLine());

                        if (mandatory > rodLength)
                        {
                            Console.WriteLine("Custom cut not possible.");
                            break;
                        }

                        double revenueB =
                            utility.FindBestCut(pipes, rodLength - mandatory);

                        Console.WriteLine(
                            "Revenue after mandatory cut:"+revenueB);
                        break;

                    case 3:
                        Console.Write("Enter number of requested cuts: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        int[] cuts = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write($"Cut {i + 1}: ");
                            cuts[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        bool possible =
                            utility.IsCutPossible(pipes, rodLength, cuts);

                        Console.WriteLine(possible? "Cut is possible.": "Edge Case: Requested cut is NOT possible.");
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
