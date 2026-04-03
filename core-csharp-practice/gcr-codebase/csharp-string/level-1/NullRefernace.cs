using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_string.level_1
{
    internal class NullRefernace
    {
        static void Main(string[] args)
        {
            // trying to get a numm exception
            try
            {
                string s = null;
                int l = s.Length;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
