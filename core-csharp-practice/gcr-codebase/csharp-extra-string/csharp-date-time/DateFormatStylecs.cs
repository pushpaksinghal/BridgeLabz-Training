using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.chsarp_date_time
{
    internal class DateFormatStylecs
    {
        static void Main(string[] args)
        {
            // inputing date
            DateTime d = DateTime.Now;
            //showing differnt format of showing date
            Console.WriteLine(d.ToString("dd/MM/yyyy"));
            Console.WriteLine(d.ToString("yyyy-MM-dd"));
            Console.WriteLine(d.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
