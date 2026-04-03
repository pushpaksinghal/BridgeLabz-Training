using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.chsarp_date_time
{
    internal class TimeZoneShift
    {
        static void Main(string[] args)
        {
            // taking the input from the computer 
            DateTimeOffset current = DateTimeOffset.UtcNow;
            // converting it in IST and PST
            Console.WriteLine(current);
            Console.WriteLine(Time("India Standard Time"));
            Console.WriteLine(Time("Pacific Standard Time"));
        }
        static DateTimeOffset Time(string z)
        {
            TimeZoneInfo t = TimeZoneInfo.FindSystemTimeZoneById(z);
            return TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, t);
        }
    }
}
