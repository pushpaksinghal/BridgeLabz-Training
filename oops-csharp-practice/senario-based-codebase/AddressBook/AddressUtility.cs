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
        // calling the add contact in a for loop for adding multiple contacts
        public void AddContactsOfFamily()
        {
            Console.WriteLine("Enter number of contacts to add:");
            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
            if(addressBook.Contacts().Length-addressBook.ContactCount()>=numberOfContacts)
            {
                for (int i = 0; i < numberOfContacts; i++)
                {
                    AddContact();
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Not enough space in address book to add more contacts.");
            }
            
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
        //UC-3 editing an existing contact details 
        public void EditContact()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            if(addressBook.ContactCount() == 0)
            {
                Console.WriteLine("No contacts available to edit.");
                return;
            }
            else
            {
                for(int i = 0; i < addressBook.ContactCount(); i++)
                {
                    if(addressBook.Contacts()[i].FirstName() == firstName && addressBook.Contacts()[i].LastName() == lastName)
                    {
                        Console.WriteLine("Enter new Details :\nFirst Name\nLast Name\nAddress\nCity\nState\nZip\nPhone Number\nEmail");
                        string newFisrtName = Console.ReadLine();
                        string newLastName = Console.ReadLine();
                        string newAddress = Console.ReadLine();
                        string newCity = Console.ReadLine();
                        string newState = Console.ReadLine();
                        string newZip = Console.ReadLine();
                        string newPhoneNumber = Console.ReadLine();
                        string newEmail = Console.ReadLine();
                        UserContact updatedContact = new UserContact(newFisrtName, newLastName, newAddress, newCity, newState, newZip, newPhoneNumber, newEmail);
                        addressBook.Contacts()[i] = updatedContact;
                        Console.WriteLine("Contact updated successfully.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Contact not found.");
                    }
                }
            }
        }
        // UC-4 deleting a contact from address book
        public void DeleteContact()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            if(addressBook.ContactCount() ==0)
            {
                Console.WriteLine("No contacts available to delete.");
                return;
            }
            else
            {
                for(int i = 0; i < addressBook.ContactCount(); i++)
                {
                    if(addressBook.Contacts()[i].FirstName() == firstName && addressBook.Contacts()[i].LastName() == lastName)
                    {
                        if(addressBook.DeleteContactAt(i))
                        {
                            Console.WriteLine("Contact deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete contact.");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact not found.");
                        return;
                    }
                }
            }
        }
    }
}
