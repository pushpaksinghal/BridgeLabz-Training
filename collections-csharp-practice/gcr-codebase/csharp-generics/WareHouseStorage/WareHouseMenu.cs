using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class WareHouseMenu
    {
        Storage<WareHousrItem> store = new Storage<WareHousrItem>();

        public void Menu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO STORE");
                Console.WriteLine("1. Add.");
                Console.WriteLine("2. Display.");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        store.Add();
                        break;
                    case 2:
                        store.Display();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }

    }
}
