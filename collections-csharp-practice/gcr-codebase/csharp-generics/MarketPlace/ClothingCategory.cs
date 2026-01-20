using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.MarketPlace
{
    internal class ClothingCategory : Category
    {
        public ClothingCategory()
        {
            Name = "Clothing";
        }

        public override double ApplyDiscount(double price)
        {
            return price - (price * 20 / 100); // 20% clothing discount
        }
    }
}
