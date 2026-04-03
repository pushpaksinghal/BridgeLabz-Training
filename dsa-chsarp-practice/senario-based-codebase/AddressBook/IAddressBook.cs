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
        void AddAddressBook();
        // making AddContact method signature
        void ShowAddressBook();
        bool OwnerEntry(string name);
        void AddContact(string name);
        // making the method signature for adding multiple contacts
        void AddContactsOfFamily(string name);
        void ShowContact(string name);
        // for UC-3 editing contact method signature
        void EditContact(string name);
        // for UC-4 deleting contact method signature
        void DeleteContact(string name);
        // for Uc-8 searching person by city or state accross multiple address book
        void SearchPersonByCityOrState();
        // for UC-9 viewing person by city or state accross multiple address book
        void ViewAllByCityOrState(string name);
        // for UC-10 counting person by city or state accross multiple address book
        void CountByCityOrState(string name);
        // for UC-11 sorting contacts alphabetically
        void SortContactsAlphabetically(string name)
;
    }
}
