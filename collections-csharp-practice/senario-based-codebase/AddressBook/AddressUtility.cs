using System;
using System.Collections.Generic;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressUtility<T> : IAddressBook where T : UserContact
    {
        private List<AddressBook<T>> books = new List<AddressBook<T>>();

        public void AddAddressBook()
        {
            string ownerName = Console.ReadLine();
            books.Add(new AddressBook<T>(ownerName));
        }

        public void ShowAddressBook()
        {
            foreach (var book in books)
                Console.WriteLine(book.OwnerName());
        }

        public bool OwnerEntry(string name)
        {
            foreach (var book in books)
                if (book.OwnerName() == name)
                    return true;

            return false;
        }

        private AddressBook<T> GetAddressBook(string name)
        {
            foreach (var book in books)
                if (book.OwnerName() == name)
                    return book;

            Console.WriteLine("Address book not found.");
            return null;
        }

        public void AddContact(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            Console.WriteLine("Enter Details:");
            T contact = (T)Activator.CreateInstance(
                typeof(T),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine(),
                Console.ReadLine()
            );

            if (IsDuplicate(book, contact))
            {
                Console.WriteLine("Duplicate contact found.");
                return;
            }

            book.AddContact(contact);
        }

        private bool IsDuplicate(AddressBook<T> book, T newContact)
        {
            foreach (var c in book.Contacts())
            {
                if (c.FirstName() == newContact.FirstName() &&
                    c.LastName() == newContact.LastName())
                    return true;
            }
            return false;
        }

        public void AddContactsOfFamily(string name)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                AddContact(name);
        }

        public void ShowContact(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            if (book.Contacts().Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (var c in book.Contacts())
                Console.WriteLine(c);
        }

        public void EditContact(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            string fn = Console.ReadLine();
            string ln = Console.ReadLine();

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == fn && c.LastName() == ln)
                {
                    book.Contacts()[i] = (T)Activator.CreateInstance(
                        typeof(T),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine(),
                        Console.ReadLine()
                    );
                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void DeleteContact(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            string fn = Console.ReadLine();
            string ln = Console.ReadLine();

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == fn && c.LastName() == ln)
                {
                    book.DeleteContactAt(i);
                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void SearchPersonByCityOrState()
        {
            string fn = Console.ReadLine();
            string cityOrState = Console.ReadLine();

            foreach (var book in books)
            {
                foreach (var c in book.Contacts())
                {
                    if (c.FirstName() == fn &&
                        (c.City() == cityOrState || c.State() == cityOrState))
                    {
                        Console.WriteLine("Address Book: " + book.OwnerName());
                        Console.WriteLine(c);
                    }
                }
            }
        }

        public void ViewAllByCityOrState(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            string cityOrState = Console.ReadLine();

            foreach (var c in book.Contacts())
                if (c.City() == cityOrState || c.State() == cityOrState)
                    Console.WriteLine(c);
        }

        public void CountByCityOrState(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            string cityOrState = Console.ReadLine();
            int count = 0;

            foreach (var c in book.Contacts())
                if (c.City() == cityOrState || c.State() == cityOrState)
                    count++;

            Console.WriteLine("Total contacts: " + count);
        }

        public void SortContactsAlphabetically(string name)
        {
            var book = GetAddressBook(name);
            if (book == null) return;

            book.Contacts().Sort((a, b) =>
            {
                int c = a.FirstName().CompareTo(b.FirstName());
                return c != 0 ? c : a.LastName().CompareTo(b.LastName());
            });

            Console.WriteLine("Contacts sorted alphabetically.");
        }
    }
}
