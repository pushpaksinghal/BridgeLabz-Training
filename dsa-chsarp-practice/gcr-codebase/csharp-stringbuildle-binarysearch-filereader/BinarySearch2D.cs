using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_stringbuildle_binarysearch_filereader
{
    internal class BinarySearch2D
    {
        static void Main(String[]args)
        {
            int[,] matrix ={{1, 3, 5},{7, 9, 11}};
            int target = 9;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int low = 0, high = rows * cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int value = matrix[mid / cols, mid % cols];

                if (value == target)
                {
                    Console.WriteLine("Found");
                    return;
                }
                if (value < target) low = mid + 1;
                else high = mid - 1;
            }

            Console.WriteLine("Not Found");
        }
    }
}
