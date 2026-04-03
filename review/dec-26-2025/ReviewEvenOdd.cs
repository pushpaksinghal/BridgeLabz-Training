using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.review
{
    internal class ReviewEvenOdd
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mainArr = new int[n];
            for(int i = 0; i < n; i++)
            {
                mainArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int e = 0;
            int o = 0;
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if (mainArr[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] arrEven = new int[count];
            int[] arrOdd = new int[n-count];
            for (int i = 0; i < n; i++)
            {
                if (mainArr[i] % 2 == 0)
                {
                    arrEven[e] = mainArr[i];
                    e++;
                }
                else
                {
                    arrOdd[o] = mainArr[i];
                    o++;
                }
            }
            for(int i = 0; i < e; i++)
            {
                Console.Write(arrEven[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < o; i++)
            {
                Console.Write(arrOdd[i] + " ");
            }
        }
    }
}
