using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level1
{
    internal class TwoToOneDimension
    {
        static void Main(String[] args)
        {
            //taking input for 2D array
            int[,] twoD = new int[2, 4];
            for (int i = 0; i < twoD.GetLength(0); i++)
            {
                for (int j = 0; j < twoD.GetLength(1); j++)
                {
                    twoD[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //converting 2D array to 1D array
            int[] oneD = new int[twoD.Length];

            for (int i = 0; i < twoD.GetLength(0); i++)
            {
                for (int j = 0; j < twoD.GetLength(1); j++)
                {
                    oneD[(i * twoD.GetLength(1)) + j] = twoD[i, j];

                }
            }
            //printing 1D array

            for (int i = 0; i < oneD.Length; i++)
            {
                Console.Write(oneD[i] + " ");
            }

        }
    }
}
