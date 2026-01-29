using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class DetectDuplicates
    {
        static void Main(string[] args)
        {
            var records = File.ReadLines("data.csv").Skip(1)
                .Select(l => l.Split(','));

            var duplicates = records
                .GroupBy(r => r[0])
                .Where(g => g.Count() > 1)
                .SelectMany(g => g);

            foreach (var d in duplicates)
                Console.WriteLine(string.Join(",", d));
        }
    }
}
