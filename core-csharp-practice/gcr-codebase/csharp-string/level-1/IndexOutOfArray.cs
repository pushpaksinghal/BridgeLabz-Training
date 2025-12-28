using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class IndexOutOfArray
    {
        //trying to get index out of range error
        static void Main(string[] args)
        {
            try
            {
                char[] a = { '1', '2', '3' };
                char x = a[10];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
