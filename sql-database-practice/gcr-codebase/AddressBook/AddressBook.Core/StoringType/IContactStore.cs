using BridgelabzTraining.senario_based.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public interface IContactStore
    {
        void Save(string ownerName, List<UserContact> contacts);
        List<UserContact> Load(string ownerName);
    }
}
