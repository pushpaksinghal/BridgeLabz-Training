using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressUtility : IAddressBook
    {
        //UC-2 
        private AddressBook addressBook;

        public AddressUtility(AddressBook addressBook)
        {
            this.addressBook = addressBook;
        }
        //taking input for the contact details
        public void AddContact()
        {
            Console.WriteLine("Enter Details :\nFirst Name\nLast Name\nAddress\nCity\nState\nZip\nPhone Number\nEmail");
            string fisrtName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string address = Console.ReadLine();
            string city = Console.ReadLine();
            string state = Console.ReadLine();
            string zip = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string email = Console.ReadLine();
            // making a object for UserContact class
            UserContact contact = new UserContact(fisrtName, lastName, address, city, state, zip, phoneNumber, email);
            // using AddContact method of AddressBook class to add contact
            addressBook.AddContact(contact);

        }

        public void ShowContact()
        {
            UserContact[] contacts = addressBook.Contacts();
            int count = addressBook.ContactCount();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(contacts[i].ToString());
            }

        }
    }
}
