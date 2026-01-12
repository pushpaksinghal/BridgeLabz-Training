using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class Utility : ILogOperations
    {
        public woodlog[] ReadLogsFromUser()
        {
            Console.Write("Enter number of log types: ");
            int n = Convert.ToInt32(Console.ReadLine());

            woodlog[] logs = new woodlog[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nLog {i + 1}");

                Console.Write("Enter size: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter waste: ");
                double waste = Convert.ToDouble(Console.ReadLine());

                logs[i] = new woodlog(size, price, waste);
            }

            return logs;
        }
        public woodlog[] FindOptimalLogs(woodlog[] logs, int rodLength, double allowedWaste)
        {
            double maxRevenue = 0;
            double minWaste = double.MaxValue;

            woodlog[] bestCombination = new woodlog[0];
            int n = logs.Length;

            int totalCombinations = 1 << n;

            for (int mask = 1; mask < totalCombinations; mask++)
            {
                int usedLength = 0;
                double totalWaste = 0;
                double revenue = 0;

                woodlog[] temp = new woodlog[n];
                int index = 0;

                for (int i = 0; i < n; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        usedLength += logs[i].size;
                        totalWaste += logs[i].waste;
                        revenue += logs[i].price;
                        temp[index++] = logs[i];
                    }
                }

                if (usedLength <= rodLength && totalWaste <= allowedWaste)
                {
                    // Scenario C logic:
                    if (revenue > maxRevenue || (revenue == maxRevenue && totalWaste < minWaste))
                    {
                        maxRevenue = revenue;
                        minWaste = totalWaste;

                        bestCombination = new woodlog[index];
                        for (int j = 0; j < index; j++)
                        {
                            bestCombination[j] = temp[j];
                        }
                    }
                }
            }

            return bestCombination;
        }
    }

}
