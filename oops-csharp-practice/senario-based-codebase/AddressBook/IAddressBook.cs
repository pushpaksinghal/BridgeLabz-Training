using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal interface IAddressBook
    {
        // making AddContact method signature
        void AddContact();
        // making the method signature for adding multiple contacts
        void AddContactsOfFamily();
        void ShowContact();
        // for UC-3 editing contact method signature
        void EditContact();
        // for UC-4 deleting contact method signature
        void DeleteContact();
    }
}
