using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.WareHouseStorage
{
    internal class Furniture<T>:WareHousrItem
    {
        private T piece;

        public Furniture(int itemId, string companyName,T piece) : base(itemId, companyName)
        {
            this.piece = piece;
        }

        public T GetPiece() { return piece; }

        public override string ToString()
        {
            return base.ToString() + "\nPieces: " + piece;
        }
    }
}
