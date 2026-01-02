using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.Instance_vs_class
{
    internal class ProductInventory
    {
        //atributes 
        string productName;
        double price;
        static int totalProduct;
        //constructor
        public ProductInventory(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProduct++;
        }
        //display methods
        public void DisplayProductDetails()
        {
            Console.WriteLine("the product name is " + productName + "and the price is " + price);
        }
        //udateing the fee
        static public void DisplayTotalProducts()
        {
            Console.WriteLine("total product are " + totalProduct);
        }


    }

    class Displat()
    {
        static void Main(string [] args)
        {
            ProductInventory p1 = new ProductInventory("milk", 10.2);
            p1.DisplayProductDetails();

            ProductInventory p2 = new ProductInventory("oreo", 21.1);
            p2.DisplayProductDetails();

            ProductInventory.DisplayTotalProducts();


        }
    }
}
