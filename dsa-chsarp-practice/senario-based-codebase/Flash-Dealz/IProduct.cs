using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Flash_Dealz
{
    internal interface IProduct
    {
        // insitialing the method in the interface  to hide the implementtation of the method
        void AddProduct();
        void GetBestDeal();
    }
}
