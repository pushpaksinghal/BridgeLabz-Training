using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.EXTRA.csharp_built_in_function
{
    internal class TempConvert
    {
        static void Main(string[] args)
        {
           // input teh number
            string t = Console.ReadLine();
            double v = Convert.ToInt32(Console.ReadLine());
            if (t == "c") Console.WriteLine(CtoF(v));
            else Console.WriteLine(FtoC(v));
        }
        // celcius to far or vice versa
        static double CtoF(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static double FtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
