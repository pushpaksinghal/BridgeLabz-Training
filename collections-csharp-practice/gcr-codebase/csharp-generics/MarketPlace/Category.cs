using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.MarketPlace
{
    internal abstract class Category
    {
        public string Name { get; protected set; }
        public abstract double ApplyDiscount(double price);
    }
}
