using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class SearchEmployee
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();

            foreach (var line in File.ReadLines("employees.csv"))
            {
                if (line.StartsWith("ID")) continue;

                var d = line.Split(',');
                if (d[1].Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Department: "+d[2]+"\nSalary: "+d[3]);
                    return;
                }
            }

            Console.WriteLine("Employee not found");
        }
    }
}
