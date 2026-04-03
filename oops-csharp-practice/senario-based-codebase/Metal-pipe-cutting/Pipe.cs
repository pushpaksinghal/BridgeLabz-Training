using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Metal_pipe_cutting
{
    internal class Pipe
    {
        public int length { get; set; }
        public double price { get; set; }

        public Pipe(int length, double price)
        {
            this.length = length;
            this.price = price;
        }
    }
}
