using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.MarketPlace
{
    internal class MarketProductUtility
    {
        private List<Product<Category>> products = new List<Product<Category>>();

        public void AddProduct(Product<Category> product)
        {
            products.Add(product);
        }

        public void ApplyDiscountToAll()
        {
            foreach (var product in products)
            {
                product.ApplyDiscount();
            }
        }

        public void Display()
        {
            foreach (var product in products)
            {
                System.Console.WriteLine(product);
            }
        }
    }
}
