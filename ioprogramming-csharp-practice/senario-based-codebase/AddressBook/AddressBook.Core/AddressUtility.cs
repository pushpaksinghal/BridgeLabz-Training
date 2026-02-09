using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using CsvHelper;

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

        public void SortContactsByCity(string ownerName)
        {
            var book = GetAddressBook(ownerName);
            book.Contacts().Sort((a, b) => a.City().CompareTo(b.City()));
        }

        public void SortContactsByState(string ownerName)
        {
            var book = GetAddressBook(ownerName);
            book.Contacts().Sort((a, b) => a.State().CompareTo(b.State()));
        }

        public void SortContactsByZip(string ownerName)
        {
            var book = GetAddressBook(ownerName);
            book.Contacts().Sort((a, b) => a.Zip().CompareTo(b.Zip()));
        }

        //------------------------ File I/O part---------------------------

        public void SaveAddressBookToFile(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            var contacts = GetContacts(ownerName);

            using (var writer = new StreamWriter(filePath, false))
            {
                // header (optional)
                writer.WriteLine("FirstName|LastName|Address|City|State|Zip|Phone|Email");

                foreach (var c in contacts)
                {
                    writer.WriteLine(ToLine(c));
                }
            }
        }

        public void LoadAddressBookFromFile(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            var book = GetAddressBook(ownerName);

            // Replace existing contacts
            book.Contacts().Clear();

            using (var reader = new StreamReader(filePath))
            {
                string? line;
                bool firstLine = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // skip header
                    if (firstLine && line.StartsWith("FirstName|", StringComparison.OrdinalIgnoreCase))
                    {
                        firstLine = false;
                        continue;
                    }

                    firstLine = false;

                    var contact = FromLine(line);
                    book.AddContact((T)contact);
                }
            }
        }

        private static string Safe(string s) => (s ?? string.Empty).Replace("|", "/");

        private static string ToLine(UserContact c)
        {
            return string.Join("|",
                Safe(c.FirstName()),
                Safe(c.LastName()),
                Safe(c.Address()),
                Safe(c.City()),
                Safe(c.State()),
                Safe(c.Zip()),
                Safe(c.PhoneNumber()),
                Safe(c.Email())
            );
        }

        private static UserContact FromLine(string line)
        {
            var parts = line.Split('|');
            if (parts.Length != 8)
                throw new FormatException("Invalid contact format in file.");

            return new UserContact(
                parts[0], parts[1], parts[2], parts[3],
                parts[4], parts[5], parts[6], parts[7]
            );
        }

        public void ExportToCsv(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            var contacts = GetContacts(ownerName);

            using var writer = new StreamWriter(filePath, false);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            var rows = new List<ContactCsvRow>();
            foreach (var c in contacts)
                rows.Add(ContactCsvRow.FromContact(c));

            csv.WriteRecords(rows);
        }

        public void ImportFromCsv(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            var book = GetAddressBook(ownerName);
            book.Contacts().Clear();

            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var rows = csv.GetRecords<ContactCsvRow>();
            foreach (var r in rows)
                book.AddContact((T)r.ToContact());
        }
        public void ExportToJson(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            var contacts = GetContacts(ownerName);

            var jsonContacts = new List<ContactJsonDto>();
            foreach (var c in contacts)
                jsonContacts.Add(ContactJsonDto.FromContact(c));

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(jsonContacts, options);
            File.WriteAllText(filePath, json);
        }

        public void ImportFromJson(string ownerName, string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found.", filePath);

            var book = GetAddressBook(ownerName);
            book.Contacts().Clear(); // replace existing contacts

            string json = File.ReadAllText(filePath);

            var jsonContacts = JsonSerializer.Deserialize<List<ContactJsonDto>>(json);
            if (jsonContacts == null) return;

            foreach (var dto in jsonContacts)
                book.AddContact((T)dto.ToContact());
        }

    }
    sealed class ContactCsvRow
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        public static ContactCsvRow FromContact(UserContact c) => new ContactCsvRow
        {
            FirstName = c.FirstName(),
            LastName = c.LastName(),
            Address = c.Address(),
            City = c.City(),
            State = c.State(),
            Zip = c.Zip(),
            Phone = c.PhoneNumber(),
            Email = c.Email()
        };

        public UserContact ToContact() => new UserContact(
            FirstName, LastName, Address, City, State, Zip, Phone, Email
        );
    }
    
    sealed class ContactJsonDto
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Zip { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        public static ContactJsonDto FromContact(UserContact c) => new ContactJsonDto
        {
            FirstName = c.FirstName(),
            LastName = c.LastName(),
            Address = c.Address(),
            City = c.City(),
            State = c.State(),
            Zip = c.Zip(),
            Phone = c.PhoneNumber(),
            Email = c.Email()
        };

        public UserContact ToContact() => new UserContact(
            FirstName, LastName, Address, City, State, Zip, Phone, Email
        );
    }

}
