using BridgelabzTraining.senario_based.Metal_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class Groceries<T>:WareHousrItem
    {
        private T fresh;

        public Groceries(int itemId, string companyName,T fresh) : base(itemId, companyName)
        {
            this.fresh = fresh;
        }

        public T GetFresh() { return fresh; }

        public override string ToString()
        {
            return base.ToString() + "\nFreshness: " + fresh;
        }
    }
}
