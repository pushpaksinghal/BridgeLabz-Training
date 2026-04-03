using BridgelabzTraining.senario_based.AddressBook;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public sealed class CsvContactStore:IContactStore
    {
        private readonly string _filePath;

        public CsvContactStore(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            _filePath = filePath;
        }

        public void Save(string ownerName, List<UserContact> contacts)
        {
            using var writer = new StreamWriter(_filePath, false);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            var rows = new List<ContactCsvRow>();
            foreach (var c in contacts)
                rows.Add(ContactCsvRow.FromContact(c));

            csv.WriteRecords(rows);
        }

        public List<UserContact> Load(string ownerName)
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("File not found.", _filePath);

            using var reader = new StreamReader(_filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var list = new List<UserContact>();
            foreach (var r in csv.GetRecords<ContactCsvRow>())
                list.Add(r.ToContact());

            return list;
        }

        private sealed class ContactCsvRow
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
    }
}
