using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    public class AddressBookNotFoundException : Exception
    {
        public AddressBookNotFoundException(string owner)
            : base($"Address book for '{owner}' not found.") { }
    }

    public class DuplicateContactException : Exception
    {
        public DuplicateContactException(string name)
            : base($"Duplicate contact found: {name}") { }
    }

    public class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string name)
            : base($"Contact not found: {name}") { }
    }
}
