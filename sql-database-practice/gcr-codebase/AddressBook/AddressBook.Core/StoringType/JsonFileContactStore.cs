using BridgelabzTraining.senario_based.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public sealed class JsonFileContactStore:IContactStore
    {
        private readonly string _filePath;

        public JsonFileContactStore(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            _filePath = filePath;
        }

        public void Save(string ownerName, List<UserContact> contacts)
        {
            var dtos = new List<ContactJsonDto>();
            foreach (var c in contacts)
                dtos.Add(ContactJsonDto.FromContact(c));

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(_filePath, JsonSerializer.Serialize(dtos, options));
        }

        public List<UserContact> Load(string ownerName)
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("File not found.", _filePath);

            string json = File.ReadAllText(_filePath);

            var dtos = JsonSerializer.Deserialize<List<ContactJsonDto>>(json);
            var list = new List<UserContact>();

            if (dtos == null) return list;

            foreach (var d in dtos)
                list.Add(d.ToContact());

            return list;
        }

        private sealed class ContactJsonDto
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
}
