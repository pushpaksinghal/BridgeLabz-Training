using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_1
{
    internal class DvvideAmongChildern
    {
        static void Main(String[] args)
        {
            //taking input form user
            int chocolate = Convert.ToInt32(Console.ReadLine());
            int childern = Convert.ToInt32(Console.ReadLine());
            // taking output formthe method
            int[] re = Choco(chocolate, childern);
            //printing the result
            Console.WriteLine("the total chocolate per child is " + re[0]+"and the remaining chocolate are " + re[1]);
        }

        static int[] Choco(int chocolate,int childern)
        {
            //taking the values from main and raturning the array storing the chocolate per child and remaining chocolate
            int[] arr = new int[2];
            arr[0] = chocolate / childern;
            arr[1] = chocolate % childern;
            return arr;
        }
    }
}
