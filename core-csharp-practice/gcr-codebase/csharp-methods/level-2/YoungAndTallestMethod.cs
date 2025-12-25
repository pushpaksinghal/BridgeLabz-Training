using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_2
{
    internal class YoungAndTallestMethod
    {
        static void Main(String[] args)
        {// Input from user
            int age1 = Convert.ToInt32(Console.ReadLine());
            int age2 = Convert.ToInt32(Console.ReadLine());
            int age3 = Convert.ToInt32(Console.ReadLine());

            int height1 = Convert.ToInt32(Console.ReadLine());
            int height2 = Convert.ToInt32(Console.ReadLine());
            int height3 = Convert.ToInt32(Console.ReadLine());

            YoungAndTallestMethod method = new YoungAndTallestMethod();
            Console.WriteLine("Youngest age is: " + method.Young(age1, age2, age3) + "and the tallest is " + method.Tallest(height1, height2, height3));
        }
        // Method to find the youngest age
        int Young(int age1, int age2, int age3)
        {
            return Math.Min(age1, Math.Min(age2, age3));
        }

        int Tallest(int height1, int height2, int height3)
        {
            return Math.Max(height1, Math.Max(height2, height3));
        }
    }
}
