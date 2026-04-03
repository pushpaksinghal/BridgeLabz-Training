using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class woodlog
    {
        public int size { get; set; }
        public double price { get; set; }

        public double  waste { get; set; }

        public woodlog(int size, double price, double waste)
        {
            this.size = size;
            this.price = price;
            this.waste = waste;
        }

    }
}
