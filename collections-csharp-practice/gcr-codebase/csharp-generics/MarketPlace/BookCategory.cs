using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.MarketPlace
{
    internal class BookCategory : Category
    {
        public BookCategory()
        {
            Name = "Book";
        }

        public override double ApplyDiscount(double price)
        {
            return price - (price * 10 / 100); // 10% book discount
        }
    }
}
