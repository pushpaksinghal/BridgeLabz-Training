using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class CountWordInFile
    {
        static void Main(String[]args)
        {
            string word = "hello";
            int count = 0;

            using (StreamReader reader = new StreamReader("E:\\cshrpProject\\BridgelabzTraining\\BridgelabzTraining\\csharp-stringbuildle-binarysearch-filereader\\data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count += line.Split(word).Length - 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
