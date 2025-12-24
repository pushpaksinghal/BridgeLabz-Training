using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class NumberOfHandshakeMethod
    {
        static void Main(String[] args)
        {
            //taking input from user
            int number = Convert.ToInt32(Console.ReadLine());
            //printing the value from function
            Console.WriteLine("the number of handskae possible are " + Handshake(number));

        }
        static int Handshake(int n)
        {
            //taking teh value from teh main and calculating the no of handshake
            int handshake = (n * (n - 1)) / 2;
            return handshake;
        }
    }
}
