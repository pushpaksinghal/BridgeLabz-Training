using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class ConsoleInputToFile
    {
        static void Main(String[]args)
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                string input;
                while ((input = Console.ReadLine()) != "exit")
                {
                    writer.WriteLine(input);
                }
            }
        }
    }
}
