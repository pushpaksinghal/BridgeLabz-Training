using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal interface IAddressBook
    {
        // making AddContact method signature
        void AddContact();
        void ShowContact();
        // for UC-3 editing contact method signature
        void EditContact();
    }
}
