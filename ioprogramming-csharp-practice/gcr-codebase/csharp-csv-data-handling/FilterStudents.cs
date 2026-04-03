using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class FilterStudents
    {
        static void Main(string[] args)
        {
            foreach (var line in File.ReadLines("students.csv"))
            {
                if (line.StartsWith("ID")) continue;

                var data = line.Split(',');
                int marks = int.Parse(data[3]);

                if (marks > 80)
                    Console.WriteLine(line);
            }
        }
    }
}
