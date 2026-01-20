using BridgelabzTraining.senario_based.Metal_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class Electornics<T>:WareHousrItem
    {
        private T model;

        public Electornics(int itemId, string companyName, T model) : base(itemId, companyName)
        {
            this.model = model;
        }

        public T GetModel() { return model; }

        public override string ToString()
        {
            return base.ToString() + "\nModel: " + model;
        }
    }
}
