using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.CsharpArrays.level_2
{
    internal class GradeOfThreeSubjects
    {
        static void Main(String[] args)
        {
            // input marks
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] marks = new int[n, 3];
            int[] average = new int[n];
            for (int i = 0; i < n; i++)
            {
                //taking input of marks of three subjects
                marks[i, 0] = Convert.ToInt32(Console.ReadLine());
                marks[i, 1] = Convert.ToInt32(Console.ReadLine());
                marks[i, 2] = Convert.ToInt32(Console.ReadLine());
                average[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

                //printing average
                if (average[i] >= 80)
                {
                    Console.WriteLine("Grade: A");
                    Console.WriteLine("Remarks: Level-4 Above Agency-normalized standerds");
                }
                else if (average[i] >= 70 && average[i] <= 79)
                {
                    Console.WriteLine("Grade: B");
                    Console.WriteLine("Remarks:  Level-3 at Agency-normalized standerds");
                }
                else if (average[i] >= 60 && average[i] <= 69)
                {
                    Console.WriteLine("Grade: C");
                    Console.WriteLine("Remarks:  Level-2 below but approcching Agency-normalized standerds");
                }
                else if (average[i] >= 50 && average[i] <= 59)
                {
                    Console.WriteLine("Grade: D");
                    Console.WriteLine("Remarks:  Level-1 well below the  Agency-normalized standerds");
                }
                else if (average[i] >= 40 && average[i] <= 49)
                {
                    Console.WriteLine("Grade: E");
                    Console.WriteLine("Remarks:  Level-1- too below Agency-normalized standerds");
                }
                else
                {
                    Console.WriteLine("Grade: R");
                    Console.WriteLine("Remarks: Remidial Standerds");
                }
            }
        }
    }
}
