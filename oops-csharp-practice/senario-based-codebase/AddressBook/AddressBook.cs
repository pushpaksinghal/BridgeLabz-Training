using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressBook
    {
        private UserContact[] contacts;
        private int contactcount;

        public AddressBook(UserContact[]contacts,int contactcount)
        {
            this.contacts = contacts;
            this.contactcount = contactcount;
        }

        public UserContact[] Contacts() { return contacts; }
        public int ContactCount() { return contactcount; }


    }
}
