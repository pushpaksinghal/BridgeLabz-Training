using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_collections
{
    internal class ShoppingCart
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            List<string> insertionOrder = new List<string>();
            SortedDictionary<double, string> sortedByPrice = new SortedDictionary<double, string>();

            AddItem("Laptop", 75000);
            AddItem("Mouse", 500);
            AddItem("Keyboard", 1500);

            void AddItem(string product, double price)
            {
                cart[product] = price;
                insertionOrder.Add(product);
                sortedByPrice[price] = product;
            }

            Console.WriteLine("Items sorted by price:");
            foreach (var item in sortedByPrice)
                Console.WriteLine(item.Value+" : "+item.Key);
        }
    }

}
