using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class MergeCsv
    {
        static void Main(string[] args)
        {
            var s1 = File.ReadLines("students1.csv").Skip(1)
                .Select(l => l.Split(','));

            var s2 = File.ReadLines("students2.csv").Skip(1)
                .Select(l => l.Split(','));

            var merged = from a in s1
                         join b in s2 on a[0] equals b[0]
                         select $"{a[0]},{a[1]},{a[2]},{b[1]},{b[2]}";

            File.WriteAllLines("merged.csv",
                new[] { "ID,Name,Age,Marks,Grade" }.Concat(merged));
        }
    }
}
