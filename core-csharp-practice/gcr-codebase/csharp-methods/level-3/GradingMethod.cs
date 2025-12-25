using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class GradingMethod
    {
        static void Main(String[] args)
        {
            // input marks
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] marks = new int[n, 3];
            
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                //taking input of marks of three subjects
                marks[i, 0] = r.Next(10,100);
                marks[i, 1] = r.Next(10,100);
                marks[i, 2] = r.Next(10, 100);
            }
            int[] average = AverageMark(marks);
            for(int i = 0; i < average.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Average: " + average[i]);
                Console.WriteLine(Remark(average));
            }
        }

        static int[] AverageMark(int[,] marks)
        {
            int[] average = new int[n];
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                //taking input of marks of three subjects
                int sum= marks[i, 0] + marks[i, 1] + marks[i, 2];
                average[i] = (sum) / 3;
                
            }
            return average;
        }

        static String Remark(int[] average)
        {
            for(int i = 0; i < average.Length; i++)
            {
                //printing average
                if (average[i] >= 80)
                {
                    return ("Grade: A Remarks: Level-4 Above Agency-normalized standerds");
                }
                else if (average[i] >= 70 && average[i] <= 79)
                {
                    return ("Grade: B Remarks:  Level-3 at Agency-normalized standerds");
                }
                else if (average[i] >= 60 && average[i] <= 69)
                {
                    return("Grade: C Remarks:  Level-2 below but approcching Agency-normalized standerds");
                }
                else if (average[i] >= 50 && average[i] <= 59)
                {
                    return ("Grade: D Remarks:  Level-1 well below the  Agency-normalized standerds");
                }
                else if (average[i] >= 40 && average[i] <= 49)
                {
                    return ("Grade: E Remarks:  Level-1- too below Agency-normalized standerds");
                }
                else
                {
                    return("Grade: R Remarks: Remidial Standerds");
                }
            }
        }
    }
}
