using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class JsonCsvConvert
    {
        static void Main(string[] args)
        {
            var students = JsonSerializer.Deserialize<List<Student>>(
                File.ReadAllText("students.json"));

            using StreamWriter writer = new StreamWriter("students.csv");
            writer.WriteLine("Id,Name,Age,Marks");

            foreach (var s in students)
                writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Marks}");
        }
    }
}
