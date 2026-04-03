using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Cart
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("milk", 2100, 001, 1001);
            //using the is operator
            if (p1 is Product)
            {
                p1.Display();
            }
            // updating the discount
            Product.UpdateDiscount(10);
        }
    }

    public class Product
    {
        public static int Discount = 5;
        public readonly int ProductID;// using the readonly keyword

        string ProductName;
        int Price;
        int Quantity;

        public Product(string ProductName, int Price, int Quantity, int ProductID)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
            this.ProductID = ProductID;
        }
        // updating the disocunt using method
        public static void UpdateDiscount(int value)
        {
            Discount = value;
            Console.WriteLine(Discount);
        }
        // displaying the details
        public void Display()
        {
            Console.WriteLine(ProductName + " " + Price + " " + Quantity);
        }
    }
}
