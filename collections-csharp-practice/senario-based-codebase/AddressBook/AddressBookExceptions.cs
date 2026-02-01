using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AddressBook
{
    internal class AddressBookNotFoundException : Exception
    {
        public AddressBookNotFoundException(string owner)
            : base($"Address book for '{owner}' not found.") { }
    }

    internal class DuplicateContactException : Exception
    {
        public DuplicateContactException(string name)
            : base($"Duplicate contact found: {name}") { }
    }

    internal class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string name)
            : base($"Contact not found: {name}") { }
    }
}
