using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class WareHousrItem
    {
        private int itemId;
        private string companyName;
       
        public WareHousrItem(int itemId,string conpanyName)
        {
            this.itemId = itemId;
            this.companyName = conpanyName;
        }

        public int GetItemId() { return itemId; }
        public string GetName() { return companyName; }

        public override string ToString()
        {
            return "Id: " +itemId + "\nCompanyName: " + companyName;
        }
    }

}
