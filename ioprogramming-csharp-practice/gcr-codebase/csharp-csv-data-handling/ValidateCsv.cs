using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class ValidateCsv
    {
        static void Main(string[] args)
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\d{10}$");

            foreach (var line in File.ReadLines("data.csv").Skip(1))
            {
                var d = line.Split(',');
                if (!emailRegex.IsMatch(d[2]) || !phoneRegex.IsMatch(d[3]))
                    Console.WriteLine($"Invalid Row: {line}");
            }
        }
    }
}
