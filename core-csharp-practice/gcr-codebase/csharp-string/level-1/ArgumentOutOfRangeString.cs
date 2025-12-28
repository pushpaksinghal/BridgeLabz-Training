using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class ArgumentOutOfRangeString
    {
        //input a string and check for the Argument range exception
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                //trying to take a substring out of range to get exception
                string r = s.Substring(5, 100);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //catching it
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
