using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class INdexOutOfOrderString
    {
        static void Main(string[] args)
        {
            //trying to get index out of range for strings
            try
            {
                string s = Console.ReadLine();
                char c = s[100];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
