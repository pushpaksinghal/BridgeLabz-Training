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

            throw new AddressBookNotFoundException(name);
        }

        public void AddContact(string name)
        {
            var book = GetAddressBook(name);
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

            foreach (var c in book.Contacts())
            {
                if (c.FirstName() == contact.FirstName() &&
                    c.LastName() == contact.LastName())
                {
                    throw new DuplicateContactException(
                        contact.FirstName() + " " + contact.LastName());
                }
            }

            book.AddContact(contact);
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

            if (book.Contacts().Count == 0)
                throw new ContactNotFoundException("No contacts");

            foreach (var c in book.Contacts())
                Console.WriteLine(c);
        }

        public void EditContact(string name)
        {
            var book = GetAddressBook(name);

            string fn = Console.ReadLine();
            string ln = Console.ReadLine();

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == fn && c.LastName() == ln)
                {
                    Console.WriteLine("Enter Details:");
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
                    return;
                }
            }

            throw new ContactNotFoundException(fn + " " + ln);
        }

        public void DeleteContact(string name)
        {
            var book = GetAddressBook(name);

            string fn = Console.ReadLine();
            string ln = Console.ReadLine();

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == fn && c.LastName() == ln)
                {
                    book.DeleteContactAt(i);
                    return;
                }
            }

            throw new ContactNotFoundException(fn + " " + ln);
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
            string cityOrState = Console.ReadLine();

            foreach (var c in book.Contacts())
                if (c.City() == cityOrState || c.State() == cityOrState)
                    Console.WriteLine(c);
        }

        public void CountByCityOrState(string name)
        {
            var book = GetAddressBook(name);
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

            book.Contacts().Sort((a, b) =>
            {
                int c = a.FirstName().CompareTo(b.FirstName());
                return c != 0 ? c : a.LastName().CompareTo(b.LastName());
            });
        }
    }
}
