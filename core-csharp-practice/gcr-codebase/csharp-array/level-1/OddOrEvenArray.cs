using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class OddOrEvenArray
    {
        static void Main(String[] args)
        {
            //taking input from the user
            int number = Convert.ToInt32(Console.ReadLine());
            int[] evenArr = new int[(number / 2) + 1];
            int[] oddArr = new int[(number / 2) + 1];
            int n = 0; int m = 0;
            //separating even and odd numbers into different arrays
            for (int i = 2; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    evenArr[n] = i;
                    n++;
                }
                else
                {
                    oddArr[m] = i;
                    m++;
                }
            }
            //printing even and odd arrays
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Even number " + evenArr[i]);
            }
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Odd number " + oddArr[i]);
            }
        }
    }
}
