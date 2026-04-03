//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgelabzTraining.CsharpArrays.level1
//{
//    internal class AllTheFactors
//    {
//        static void Main(String[] args)
//        {
//            int number = Convert.ToInt32(Console.ReadLine());
//            int maxIndex = 10;
//            int[] factor = new int[maxIndex];
//            int n = 0;
//            for(int i=1;i<number; i++)
//            {
//                if (number % i == 0)
//                {
//                    if (n == maxIndex)
//                    {
//                        maxIndex = maxIndex * 2;
//                        int[] temp = new int[maxIndex];
//                        for(int j = 0; j < factor.Length; j++)
//                        {
//                            temp[j] = factor[j];
//                        }
//                        factor = temp;
//                    }
//                    factor[n] = i;
//                    n++;
//                }
//            }
//            for (int i = 0; i<n; i++)
//            {
//                Console.WriteLine("Factor " + factor[i]);
//            }

//        }
//    }
//}
