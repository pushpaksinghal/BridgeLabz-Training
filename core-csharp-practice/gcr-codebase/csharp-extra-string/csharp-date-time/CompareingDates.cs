using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.chsarp_date_time
{
    internal class CompareingDates
    {
        static void Main(string[] args)
        {
            //taking input in datetime datetype
            DateTime a =Convert.ToDateTime(Console.ReadLine());
            DateTime b =Convert.ToDateTime(Console.ReadLine());
            //if teh date is before print before otherwise after  or same
            if (a < b) Console.WriteLine("before");
            else if (a > b) Console.WriteLine("after");
            else Console.WriteLine("same");
        }
    }
}
