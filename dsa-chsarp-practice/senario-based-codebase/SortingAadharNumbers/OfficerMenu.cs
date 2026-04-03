using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.SortingAadharNumbers
{
    internal class OfficerMenu
    {
        IUtiity utility = new GovernmentUtility();

        public void Start()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO GOVERNMENT OFFICE");
                Console.WriteLine("1. Add Citizen");
                Console.WriteLine("2. Sort By aadhar");
                Console.WriteLine("3. Search By Aadhar");
                Console.WriteLine("4. Display");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        long aadhar = Convert.ToInt64(Console.ReadLine());
                        string name = Console.ReadLine();
                        string dateOfBrith = Console.ReadLine();
                        utility.AddPeople(aadhar, name, dateOfBrith);
                        break;
                    case 2:
                        utility.sort();
                        break;
                    case 3:
                        long aadharr = Convert.ToInt64(Console.ReadLine());
                        utility.search(aadharr);
                        break;
                    default:
                        flag = false;
                        break;

                }
            }
        }
    }
}
