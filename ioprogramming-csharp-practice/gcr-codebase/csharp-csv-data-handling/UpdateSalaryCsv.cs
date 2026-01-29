using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class UpdateSalaryCsv
    {
        static void Main()
        {
            using var writer = new StreamWriter("updated_employees.csv");
            foreach (var line in File.ReadLines("employees.csv"))
            {
                if (line.StartsWith("ID"))
                {
                    writer.WriteLine(line);
                    continue;
                }

                var d = line.Split(',');
                if (d[2] == "IT")
                {
                    double salary = double.Parse(d[3]) * 1.10;
                    d[3] = salary.ToString("F0");
                }
                writer.WriteLine(string.Join(",", d));
            }
        }
    }
}
