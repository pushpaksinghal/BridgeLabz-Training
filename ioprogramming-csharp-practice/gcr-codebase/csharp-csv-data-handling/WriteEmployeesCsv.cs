using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class WriteEmployeesCsv
    {
        static void Main(String[] args)
        {
            using StreamWriter writer = new StreamWriter("employee.csv");
            writer.WriteLine("ID,Name,Dept,Salary");
            writer.WriteLine("01,Jhon Doe,HR,120000");
            writer.WriteLine("02,Jhoe Doe,HR,140000");
            writer.WriteLine("03,Jhor Doe,HR,160000");
            writer.WriteLine("04,Jhow Doe,HR,110000");
            writer.WriteLine("05,Jhot Doe,HR,150000");

        }
    }
}
