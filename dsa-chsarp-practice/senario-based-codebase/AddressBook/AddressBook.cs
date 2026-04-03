using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressBook
    {
        private string ownerName;
        private UserLinkedList contacts;

        public AddressBook(string ownerName)
        {
            this.ownerName = ownerName;
            contacts = new UserLinkedList();
        }

        public UserLinkedList Contacts() { return contacts; }
        public int ContactCount() { return contacts.Count(); }
        public string OwnerName() { return ownerName; }

        public void AddContact(UserContact contact)
        {
            contacts.Add(contact);
        }

        public bool DeleteContactAt(int index)
        {
            return contacts.RemoveAt(index);
        }

    }
}
