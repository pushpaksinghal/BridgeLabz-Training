using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.chsarp_date_time
{
    internal class MovingforwardInTime
    {
        static void Main(string[] args)
        {
            //inputing the date 
            DateTime curDate = Convert.ToDateTime(Console.ReadLine());
            // moving teh date fowward in time by adding  
            curDate = curDate.AddDays(7);
            curDate = curDate.AddMonths(1);
            curDate = curDate.AddYears(2);
            curDate = curDate.AddDays(-21);
            Console.WriteLine(curDate);
        }
    }
}
