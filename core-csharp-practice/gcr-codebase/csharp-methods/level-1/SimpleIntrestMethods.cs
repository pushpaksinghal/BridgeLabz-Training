using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class SimpleIntrestMethods
    {
        static void Main(String[] args)
        {
            //taking the input from user
            int principle = Convert.ToInt32(Console.ReadLine());
            int rate = Convert.ToInt32(Console.ReadLine());
            int time = Convert.ToInt32(Console.ReadLine());
            //printing the value from function
            Console.WriteLine("the simple intrest is " + Intrest(principle, rate, time));

        }
        public static int Intrest(int principle, int rate, int time)
        {
            //calculating simple intrest
            int simple = (principle * rate * time) / 100;
            return simple;

        }
    }
}
