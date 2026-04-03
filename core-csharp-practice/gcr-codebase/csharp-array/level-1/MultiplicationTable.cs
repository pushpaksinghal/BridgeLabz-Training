using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class MultiplicationTable
    {
        static void Main(String[] args)
        {
            //same but with the whole table
            int number = Convert.ToInt32(Console.ReadLine());
            int[] multiply = new int[10];

            for (int i = 0; i < 10; i++)
            {
                multiply[i] = (i + 1) * number;
                Console.WriteLine(number + " * " + (i + 1) + " = " + multiply[i]);
            }

        }
    }
}
