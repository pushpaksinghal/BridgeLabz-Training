using System;
using System.Collections.Generic;

namespace BridgelabzTraining.senario_based.AddressBook
{
    public class AddressUtility<T> : IAddressBook where T : UserContact
    {
        private readonly List<AddressBook<T>> books = new List<AddressBook<T>>();

        public void AddAddressBook(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new ArgumentException("Owner name cannot be empty.");

            books.Add(new AddressBook<T>(ownerName));
        }

        public List<string> GetAllAddressBookOwners()
        {
            List<string> owners = new List<string>();
            foreach (var book in books)
                owners.Add(book.OwnerName());
            return owners;
        }

        public bool OwnerEntry(string ownerName)
        {
            foreach (var book in books)
                if (book.OwnerName() == ownerName)
                    return true;
            return false;
        }

        private AddressBook<T> GetAddressBook(string ownerName)
        {
            foreach (var book in books)
                if (book.OwnerName() == ownerName)
                    return book;

            throw new AddressBookNotFoundException(ownerName);
        }

        public void AddContact(string ownerName, UserContact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            var book = GetAddressBook(ownerName);

            // Duplicate rule: same FirstName + LastName within same address book
            foreach (var c in book.Contacts())
            {
                if (c.FirstName() == contact.FirstName() &&
                    c.LastName() == contact.LastName())
                {
                    throw new DuplicateContactException(contact.FirstName() + " " + contact.LastName());
                }
            }

            book.AddContact((T)contact);
        }

        public void AddContactsOfFamily(string ownerName, List<UserContact> contacts)
        {
            if (contacts == null)
                throw new ArgumentNullException(nameof(contacts));

            foreach (var c in contacts)
                AddContact(ownerName, c);
        }

        public List<UserContact> GetContacts(string ownerName)
        {
            var book = GetAddressBook(ownerName);
            List<UserContact> result = new List<UserContact>();
            foreach (var c in book.Contacts())
                result.Add(c);
            return result;
        }

        public void EditContact(string ownerName, string firstName, string lastName, UserContact updatedContact)
        {
            if (updatedContact == null)
                throw new ArgumentNullException(nameof(updatedContact));

            var book = GetAddressBook(ownerName);

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == firstName && c.LastName() == lastName)
                {
                    // keep your logic: replace entire record
                    book.Contacts()[i] = (T)updatedContact;
                    return;
                }
            }

            throw new ContactNotFoundException(firstName + " " + lastName);
        }

        public void DeleteContact(string ownerName, string firstName, string lastName)
        {
            var book = GetAddressBook(ownerName);

            for (int i = 0; i < book.Contacts().Count; i++)
            {
                var c = book.Contacts()[i];
                if (c.FirstName() == firstName && c.LastName() == lastName)
                {
                    book.DeleteContactAt(i);
                    return;
                }
            }

            throw new ContactNotFoundException(firstName + " " + lastName);
        }

        public List<(string Owner, UserContact Contact)> SearchAcrossBooks(string firstName, string cityOrState)
        {
            List<(string Owner, UserContact Contact)> results = new List<(string Owner, UserContact Contact)>();

            foreach (var book in books)
            {
                foreach (var c in book.Contacts())
                {
                    if (c.FirstName() == firstName &&
                        (c.City() == cityOrState || c.State() == cityOrState))
                    {
                        results.Add((book.OwnerName(), c));
                    }
                }
            }

            return results;
        }

        public List<UserContact> FilterByCityOrState(string ownerName, string cityOrState)
        {
            var book = GetAddressBook(ownerName);

            List<UserContact> results = new List<UserContact>();
            foreach (var c in book.Contacts())
            {
                if (c.City() == cityOrState || c.State() == cityOrState)
                    results.Add(c);
            }
            return results;
        }

        public int CountByCityOrState(string ownerName, string cityOrState)
        {
            var book = GetAddressBook(ownerName);

            int count = 0;
            foreach (var c in book.Contacts())
                if (c.City() == cityOrState || c.State() == cityOrState)
                    count++;

            return count;
        }

        public void SortContactsAlphabetically(string ownerName)
        {
            var book = GetAddressBook(ownerName);

            book.Contacts().Sort((a, b) =>
            {
                int c = a.FirstName().CompareTo(b.FirstName());
                return c != 0 ? c : a.LastName().CompareTo(b.LastName());
            });
        }
    }
}
