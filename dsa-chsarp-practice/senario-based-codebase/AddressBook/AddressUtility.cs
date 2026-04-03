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
        AddressBookLinkedList Books = new AddressBookLinkedList();


        public void AddAddressBook()
        {
            string ownerName = Console.ReadLine();
            Books.Add(new AddressBook(ownerName));
        }
        public void ShowAddressBook()
        {
            AddressBookNode temp = Books.Head();
            while (temp != null)
            {
                Console.WriteLine(temp.Data.OwnerName());
                temp = temp.Next;
            }
        }
        //public AddressUtility(AddressBook addressBook)
        //{
        //    this.addressBook = addressBook;
        //}
        //taking input for the contact details
        public bool OwnerEntry(string name)
        {
            AddressBookNode temp = Books.Head();

            while (temp != null)
            {
                if (temp.Data.OwnerName().Equals(name))
                    return true;

                temp = temp.Next;
            }
            return false;
        }
        private AddressBookNode GetAddressBook(string name)
        {
            AddressBookNode temp = Books.Head();
            while (temp != null)
            {
                if (temp.Data.OwnerName().Equals(name))
                    return temp;

                temp = temp.Next;
            }
            Console.WriteLine("Address book not found.");
            return null;
        }
        public void AddContact(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            Console.WriteLine("Enter Details:");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string address = Console.ReadLine();
            string city = Console.ReadLine();
            string state = Console.ReadLine();
            string zip = Console.ReadLine();
            string phone = Console.ReadLine();
            string email = Console.ReadLine();

            if (IsDuplicate(bookNode.Data, firstName, lastName))
            {
                Console.WriteLine("Duplicate contact found.");
                return;
            }

            bookNode.Data.AddContact(
                new UserContact(firstName, lastName, address, city, state, zip, phone, email)
            );
        }
        // checking for duplicate contact UC-7
        private bool IsDuplicate(AddressBook book, string first, string last)
        {
            UserNode temp = book.Contacts().Head();
            while (temp != null)
            {
                if (temp.Data.FirstName() == first && temp.Data.LastName() == last)
                {
                    return true;
                }

                temp = temp.Next;
            }
            return false;
        }

        // calling the add contact in a for loop for adding multiple contacts
        public void AddContactsOfFamily(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AddContact(name);
            }
        }
        public void ShowContact(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            UserNode temp = bookNode.Data.Contacts().Head();
            if (temp == null)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        //UC-3 editing an existing contact details 
        public void EditContact(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            UserNode temp = bookNode.Data.Contacts().Head();
            while (temp != null)
            {
                if (temp.Data.FirstName() == firstName &&temp.Data.LastName() == lastName)
                {
                    string fn = Console.ReadLine();
                    string ln = Console.ReadLine();
                    string addr = Console.ReadLine();
                    string city = Console.ReadLine();
                    string state = Console.ReadLine();
                    string zip = Console.ReadLine();
                    string phone = Console.ReadLine();
                    string email = Console.ReadLine();

                    temp.Data = new UserContact(fn, ln, addr, city, state, zip, phone, email);
                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Contact not found.");
        }

        // UC-4 deleting a contact from address book
        public void DeleteContact(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            UserNode curr = bookNode.Data.Contacts().Head();
            UserNode prev = null;
            int index = 0;

            while (curr != null)
            {
                if (curr.Data.FirstName() == firstName && curr.Data.LastName() == lastName)
                {
                    bookNode.Data.DeleteContactAt(index);
                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
                prev = curr;
                curr = curr.Next;
                index++;
            }

            Console.WriteLine("Contact not found.");
        }
        // Search a person accross the multiple address book by city or state UC-8
        public void SearchPersonByCityOrState()
        {
            string firstName = Console.ReadLine();
            string cityOrState = Console.ReadLine();

            AddressBookNode bookNode = Books.Head();
            while (bookNode != null)
            {
                UserNode user = bookNode.Data.Contacts().Head();
                while (user != null)
                {
                    if (user.Data.FirstName() == firstName && (user.Data.City() == cityOrState || user.Data.State() == cityOrState))
                    {
                        Console.WriteLine("Address Book: " + bookNode.Data.OwnerName());
                        Console.WriteLine(user.Data);
                    }
                    user = user.Next;
                }
                bookNode = bookNode.Next;
            }
        }
        public void ViewAllByCityOrState(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            string cityOrState = Console.ReadLine();
            UserNode temp = bookNode.Data.Contacts().Head();

            while (temp != null)
            {
                if (temp.Data.City() == cityOrState || temp.Data.State() == cityOrState)
                {
                    Console.WriteLine(temp.Data);
                }
                temp = temp.Next;
            }
        }

        public void CountByCityOrState(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            string cityOrState = Console.ReadLine();
            int count = 0;

            UserNode temp = bookNode.Data.Contacts().Head();
            while (temp != null)
            {
                if (temp.Data.City() == cityOrState || temp.Data.State() == cityOrState)
                {
                    count++;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Total contacts: " + count);
        }

        public void SortContactsAlphabetically(string name)
        {
            AddressBookNode bookNode = GetAddressBook(name);
            if (bookNode == null) return;

            bool swapped;
            do
            {
                swapped = false;
                UserNode curr = bookNode.Data.Contacts().Head();

                while (curr != null && curr.Next != null)
                {
                    if (Compare(curr.Data, curr.Next.Data) > 0)
                    {
                        UserContact temp = curr.Data;
                        curr.Data = curr.Next.Data;
                        curr.Next.Data = temp;
                        swapped = true;
                    }
                    curr = curr.Next;
                }
            } while (swapped);

            Console.WriteLine("Contacts sorted alphabetically.");
        }

        private int Compare(UserContact a, UserContact b)
        {
            int c = a.FirstName().CompareTo(b.FirstName());
            return c != 0 ? c : a.LastName().CompareTo(b.LastName());
        }
    }
}
