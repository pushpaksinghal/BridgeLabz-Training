using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class ReadFileLineByLine
    {
        static void Main(String[]args)
        {
            using (StreamReader reader = new StreamReader("E:\\cshrpProject\\BridgelabzTraining\\BridgelabzTraining\\csharp-stringbuildle-binarysearch-filereader\\data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
