using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections
{
    internal class BankingSystem
    {
        public static void Main(string[]args)
        {
            Dictionary<int, double> accounts = new Dictionary<int, double>();
            Queue<int> withdrawalQueue = new Queue<int>();

            accounts[1001] = 50000;
            accounts[1002] = 20000;
            accounts[1003] = 75000;

            withdrawalQueue.Enqueue(1002);
            withdrawalQueue.Enqueue(1001);

            while (withdrawalQueue.Count > 0)
            {
                int acc = withdrawalQueue.Dequeue();
                accounts[acc] -= 5000;
            }

            SortedDictionary<double, int> sortedByBalance = new SortedDictionary<double, int>();
            foreach (var acc in accounts)
                sortedByBalance[acc.Value] = acc.Key;

            Console.WriteLine("Accounts sorted by balance:");
            foreach (var acc in sortedByBalance)
                Console.WriteLine("Account "+acc.Value+" : "+acc.Key);
        }
    }

}
