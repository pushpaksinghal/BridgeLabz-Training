using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressUtility : IAddressBook
    {
        //refactoring the whole code to inplement multiple addressBook by taking an array of addressbook
                //UC-2 
                //private AddressBook addressBook;
        AddressBook[] Books = new AddressBook[10];
        int count = 0;

        public void AddAddressBook()
        {
            if (count < Books.Length)
            {
                string ownerName = Console.ReadLine();
                int size  = Convert.ToInt32(Console.ReadLine());
                Books[count++] = new AddressBook(size , ownerName);
            }
            else
            {
                Console.WriteLine("Cannot add more address books.");
            }
        }

        public void ShowAddressBook()
        {
            for(int i = 0; i <count; i++)
            {
                Console.WriteLine(Books[i].OwnerName());
            }
        }
                //public AddressUtility(AddressBook addressBook)
                //{
                //    this.addressBook = addressBook;
                //}
                //taking input for the contact details
        public bool OwnerEntry(String name)
        {
            for(int i=0; i < count; i++)
            {
                if(Books[i].OwnerName() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddContact(string name)
        {
            for(int i = 0; i < count; i++)
            {
                if(Books[i] !=null && Books[i].OwnerName().Equals(name))
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
                    // checking for duplicate contact
                    if (IsDuplicate(fisrtName, lastName,i))
                    {
                        Console.WriteLine("Duplicate contact found. Contact not added.");
                        return;
                    }
                    else
                    {
                        // making a object for UserContact class
                        UserContact contact = new UserContact(fisrtName, lastName, address, city, state, zip, phoneNumber, email);
                        // using AddContact method of AddressBook class to add contact
                        Books[i].AddContact(contact);
                        return;
                    }
                }
            }
        }
        // checking for duplicate contact UC-7
        private bool IsDuplicate(string firstName,string lastName , int i)
        {
            UserContact[] contacts = Books[i].Contacts();
            for(int j = 0; j < contacts.Length; j++)
            {
                if(contacts[j]!=null && contacts[j].FirstName().Equals(firstName) && contacts[j].LastName().Equals(lastName))
                {
                    return true;
                }
            }
            return false;
        }
        // calling the add contact in a for loop for adding multiple contacts
        public void AddContactsOfFamily(string name)
        {
            for (int i= 0; i < count; i++)
            {
                if (Books[i].OwnerName().Equals(name))
                {
                    Console.WriteLine("Enter number of contacts to add:");
                    int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                    if (Books[i].Contacts().Length - Books[i].ContactCount() >= numberOfContacts)
                    {
                        for (int j = 0; j < numberOfContacts; j++)
                        {
                            AddContact(name);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough space in address book to add more contacts.");
                    }
                }
            }
            
        }
        public void ShowContact(string name)
        {
            for(int i=0; i < count; i++)
            {
                if (Books[i].OwnerName().Equals(name))
                {
                    UserContact[] contacts = Books[i].Contacts();
                    int count = Books[i].ContactCount();
                    for (int j = 0; j < count; j++)
                    {
                        Console.WriteLine(contacts[j].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("there are no contacts available");
                }
            }

        }
        //UC-3 editing an existing contact details 
        public void EditContact(string name)
        {
            for(int i = 0; i < count; i++)
            {
                if (Books[i].OwnerName().Equals(name))
                {
                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();

                    if (Books[i].ContactCount() == 0)
                    {
                        Console.WriteLine("No contacts available to edit.");
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < Books[i].ContactCount(); j++)
                        {
                            if (Books[i].Contacts()[j].FirstName() == firstName && Books[i].Contacts()[j].LastName() == lastName)
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
                                Books[i].Contacts()[j] = updatedContact;
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
            }
            
        }
        // UC-4 deleting a contact from address book
        public void DeleteContact(string name)
        {
            for(int i = 0; i < count; i++)
            {
                if (Books[i].OwnerName().Equals(name))
                {
                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();

                    if (Books[i].ContactCount() == 0)
                    {
                        Console.WriteLine("No contacts available to delete.");
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < Books[i].ContactCount(); j++)
                        {
                            if (Books[i].Contacts()[j].FirstName() == firstName && Books[i].Contacts()[j].LastName() == lastName)
                            {
                                if (Books[i].DeleteContactAt(j))
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
        // Search a person accross the multiple address book by city or state UC-8
        public void SearchPersonByCityOrState()
        {
            string firstname = Console.ReadLine();
            string cityorstate = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (Books[i] != null)
                {
                    UserContact[] contacts = Books[i].Contacts();
                    for(int j = 0; j < contacts.Length; j++)
                    {
                        if(contacts[j] != null && contacts[j].FirstName().Equals(firstname) && (contacts[j].City().Equals(cityorstate) || contacts[j].State().Equals(cityorstate)))
                        {
                            Console.WriteLine("Address Book Name:"+ Books[i].OwnerName());
                            Console.WriteLine("Found contact: " + contacts[j].ToString());
                        }
                    }
                }
            }
        }
        public void ViewAllByCityOrState(string name)
        {
            for(int i=0; i < count; i++)
            {
                if(Books[i].OwnerName().Equals(name))
                {
                    string cityorstate = Console.ReadLine();
                    UserContact[] contacts = Books[i].Contacts();
                    for(int j = 0; j < contacts.Length; j++)
                    {
                        if(contacts[j] != null && (contacts[j].City().Equals(cityorstate) || contacts[j].State().Equals(cityorstate)))
                        {
                            Console.WriteLine("Contacts in " + cityorstate + ":");
                            Console.WriteLine(contacts[j].ToString());
                        }
                    }
                }
            }
        }

        public void CountByCityOrState(string name)
        {
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                if (Books[i].OwnerName().Equals(name))
                {
                    string cityorstate = Console.ReadLine();
                    UserContact[] contacts = Books[i].Contacts();
                    for (int j = 0; j < contacts.Length; j++)
                    {
                        if (contacts[j] != null && (contacts[j].City().Equals(cityorstate) || contacts[j].State().Equals(cityorstate)))
                        {
                            temp++;
                        }
                    }
                    Console.WriteLine("Total contacts in " + cityorstate + ": " + temp);
                }
            }

        }

        public void SortContactsAlphabetically(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (Books[i] != null && Books[i].OwnerName().Equals(name))
                {
                    UserContact[] contacts = Books[i].Contacts();
                    int contactCount = Books[i].ContactCount();

                    if (contactCount > 1)
                    {
                        QuickSort(contacts, 0, contactCount - 1);
                    }

                    Console.WriteLine("Contacts sorted alphabetically using Quick Sort.");
                    return;
                }
            }
        }
        // private methods for applying quicj sort algorithm 
        private void QuickSort(UserContact[] contacts, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(contacts, low, high);
                QuickSort(contacts, low, pivotIndex - 1);
                QuickSort(contacts, pivotIndex + 1, high);
            }
        }

        private int Partition(UserContact[] contacts, int low, int high)
        {
            UserContact pivot = contacts[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (CompareContacts(contacts[j], pivot) <= 0)
                {
                    i++;
                    Swap(contacts, i, j);
                }
            }

            Swap(contacts, i + 1, high);
            return i + 1;
        }

        private int CompareContacts(UserContact c1, UserContact c2)
        {
            int firstNameCompare = c1.FirstName().CompareTo(c2.FirstName());
            if (firstNameCompare != 0)
                return firstNameCompare;

            return c1.LastName().CompareTo(c2.LastName());
        }

        private void Swap(UserContact[] contacts, int i, int j)
        {
            UserContact temp = contacts[i];
            contacts[i] = contacts[j];
            contacts[j] = temp;
        }

    }
}
