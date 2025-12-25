using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class TenStudentVote
    {
        static void Main(String[] args)
        {
            // Input age of 10 students
            int noofStudent = 10;
            int[] age = new int[noofStudent];
            for (int i = 0; i < noofStudent; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Call CanTheyVote method
            TenStudentVote method = new TenStudentVote();
            bool[] canVote = method.CanTheyVote(age);
            for (int i = 0; i < noofStudent; i++)
            {
                Console.WriteLine(canVote[i]);
            }

        }
        bool[] CanTheyVote(int[] age)
        {
            // Determine if each student is eligible to vote (age >= 18)
            bool[] result = new bool[age.Length];
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] >= 18)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
            }
            return result;
        }
    }
}
