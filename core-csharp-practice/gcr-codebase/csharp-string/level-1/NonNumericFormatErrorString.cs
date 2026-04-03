using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class NonNumericFormatErrorString
    {

        //converting a non numaric into int 
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                int n = int.Parse(s);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
