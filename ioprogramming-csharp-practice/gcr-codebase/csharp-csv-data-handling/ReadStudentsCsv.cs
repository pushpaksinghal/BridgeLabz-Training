using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class ReadStudentsCsv
    {
        static void Main(string[]args)
        {
            using StreamReader reader = new StreamReader("students.csv");
            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                { 
                    isHeader = false; 
                    continue; 
                }

                string[] data = line.Split(',');
                Console.WriteLine("ID: "+data[0]+", Name: "+data[1]+", Age: "+data[2]+", Marks: "+data[3]);
            }
        }
    }
}
