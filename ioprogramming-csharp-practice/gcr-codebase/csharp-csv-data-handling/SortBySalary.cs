using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class SortBySalary
    {
        static void Main(string[] args)
        {
            var employees = File.ReadLines("employees.csv").Skip(1).Select(l => l.Split(',')).OrderByDescending(e => int.Parse(e[3])).Take(5);

            foreach (var e in employees)
                Console.WriteLine(e[1] +"- "+e[3]);
        }
    }
}
