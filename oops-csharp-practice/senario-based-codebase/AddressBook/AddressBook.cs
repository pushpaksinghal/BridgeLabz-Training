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
        private UserContact[] contacts;
        private int contactcount;

        public AddressBook(int size, string ownerName)
        {
            contacts = new UserContact[size];
            contactcount = 0;
            this.ownerName = ownerName;
        }

        public UserContact[] Contacts() { return contacts; }
        public int ContactCount() { return contactcount; }
        public string OwnerName() { return ownerName; }
        //Addcontact contion for adding contact
        public void AddContact(UserContact contact)
        {
            if (contactcount < contacts.Length)
            {
                contacts[contactcount++] = contact;
            }
            else
            {
                Console.WriteLine("Address Book is Full");

            }

        }
    }
}
