using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Flash_Dealz
{
    internal class ProductMenu
    {
        // making the object of the cutitlity class by the refernce of the interface
        IProduct p1 = new ProductUtility();
        // menu class for the user
        public void Menu()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("WELCOME TO THE DEAL BAZZAR");
                Console.WriteLine("1.ADD PRODUCT");
                Console.WriteLine("2.FIND BEST DEAL");
                Console.WriteLine("3.EXIT");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        p1.AddProduct();
                        break;
                    case 2:
                        p1.GetBestDeal();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        flag = false;
                        Console.Error.WriteLine("Invaild INput");
                        break;
                }
            }
        }
    }
}
