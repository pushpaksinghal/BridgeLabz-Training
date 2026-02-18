using BridgelabzTraining.senario_based.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public sealed class PipeTextContactStore: IContactStore
    {
        private readonly string _filePath;

        public PipeTextContactStore(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be empty.");

            _filePath = filePath;
        }

        public void Save(string ownerName, List<UserContact> contacts)
        {
            using var writer = new StreamWriter(_filePath, false);
            writer.WriteLine("FirstName|LastName|Address|City|State|Zip|Phone|Email");

            foreach (var c in contacts)
            {
                writer.WriteLine(string.Join("|",
                    Safe(c.FirstName()),
                    Safe(c.LastName()),
                    Safe(c.Address()),
                    Safe(c.City()),
                    Safe(c.State()),
                    Safe(c.Zip()),
                    Safe(c.PhoneNumber()),
                    Safe(c.Email())
                ));
            }
        }

        public List<UserContact> Load(string ownerName)
        {
            if (!File.Exists(_filePath))
                throw new FileNotFoundException("File not found.", _filePath);

            var list = new List<UserContact>();

            using var reader = new StreamReader(_filePath);
            string? line;
            bool firstLine = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                if (firstLine && line.StartsWith("FirstName|", StringComparison.OrdinalIgnoreCase))
                {
                    firstLine = false;
                    continue;
                }
                firstLine = false;

                var parts = line.Split('|');
                if (parts.Length != 8)
                    throw new FormatException("Invalid contact format in file.");

                list.Add(new UserContact(
                    parts[0], parts[1], parts[2], parts[3],
                    parts[4], parts[5], parts[6], parts[7]));
            }

            return list;
        }

        private static string Safe(string s) => (s ?? string.Empty).Replace("|", "/");
    }
}
}
