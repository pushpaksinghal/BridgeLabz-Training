using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class HandShakesMethod
    {
        static void Main(String[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int handshake = (number * (number - 1)) / 2;
            Console.WriteLine("the number of handskae possible are " + handshake);

        }
    }
}
