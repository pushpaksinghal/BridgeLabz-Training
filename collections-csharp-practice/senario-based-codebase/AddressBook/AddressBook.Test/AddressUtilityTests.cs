using BridgelabzTraining.senario_based.AddressBook;
using BridgeLabzTraining.Tests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgelabzTraining.Tests
{
    [TestClass]
    public class AddressUtilityTests
    {
        [TestMethod]
        public void AddAddressBook_ShouldAddOwner_AndOwnerEntryTrue()
        {
            IAddressBook svc = new AddressUtility<UserContact>();

            svc.AddAddressBook("Owner1");

            Assert.IsTrue(svc.OwnerEntry("Owner1"));
            Assert.AreEqual(1, svc.GetAllAddressBookOwners().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(AddressBookNotFoundException))]
        public void GetContacts_UnknownOwner_ShouldThrow()
        {
            IAddressBook svc = new AddressUtility<UserContact>();

            // should throw
            svc.GetContacts("MissingOwner");
        }

        [TestMethod]
        public void AddContact_ShouldAddContact()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One"));

            Assert.AreEqual(1, svc.GetContacts("Owner1").Count);
        }

        [TestMethod]
        [ExpectedException(typeof(DuplicateContactException))]
        public void AddContact_DuplicateFirstLast_ShouldThrow()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One"));
            svc.AddContact("Owner1", ContactFactory.Create("A", "One")); // duplicate
        }

        [TestMethod]
        public void EditContact_Existing_ShouldReplace()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One", "Pune", "MH"));

            var updated = ContactFactory.Create("A", "One", "Mumbai", "MH");
            svc.EditContact("Owner1", "A", "One", updated);

            var contacts = svc.GetContacts("Owner1");
            Assert.AreEqual(1, contacts.Count);
            Assert.AreEqual("Mumbai", contacts[0].City());
        }

        [TestMethod]
        [ExpectedException(typeof(ContactNotFoundException))]
        public void EditContact_NotFound_ShouldThrow()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.EditContact("Owner1", "X", "Y", ContactFactory.Create("X", "Y"));
        }

        [TestMethod]
        public void DeleteContact_Existing_ShouldRemove()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One"));
            svc.DeleteContact("Owner1", "A", "One");

            Assert.AreEqual(0, svc.GetContacts("Owner1").Count);
        }

        [TestMethod]
        public void CountByCityOrState_ShouldReturnCorrectCount()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One", "Pune", "MH"));
            svc.AddContact("Owner1", ContactFactory.Create("B", "Two", "Pune", "MH"));
            svc.AddContact("Owner1", ContactFactory.Create("C", "Three", "Mumbai", "MH"));

            int countCity = svc.CountByCityOrState("Owner1", "Pune");
            int countState = svc.CountByCityOrState("Owner1", "MH");

            Assert.AreEqual(2, countCity);
            Assert.AreEqual(3, countState);
        }

        [TestMethod]
        public void SortContactsAlphabetically_ShouldSortByFirstThenLast()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("B", "Z"));
            svc.AddContact("Owner1", ContactFactory.Create("A", "Z"));
            svc.AddContact("Owner1", ContactFactory.Create("A", "B"));

            svc.SortContactsAlphabetically("Owner1");

            var contacts = svc.GetContacts("Owner1");
            Assert.AreEqual("A", contacts[0].FirstName());
            Assert.AreEqual("B", contacts[0].LastName());
            Assert.AreEqual("A", contacts[1].FirstName());
            Assert.AreEqual("Z", contacts[1].LastName());
            Assert.AreEqual("B", contacts[2].FirstName());
        }

        [TestMethod]
        public void SearchAcrossBooks_ShouldFindMatches()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");
            svc.AddAddressBook("Owner2");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One", "Pune", "MH"));
            svc.AddContact("Owner2", ContactFactory.Create("A", "Two", "Delhi", "DL"));

            var results1 = svc.SearchAcrossBooks("A", "Pune");
            var results2 = svc.SearchAcrossBooks("A", "DL");

            Assert.AreEqual(1, results1.Count);
            Assert.AreEqual("Owner1", results1[0].Owner);

            Assert.AreEqual(1, results2.Count);
            Assert.AreEqual("Owner2", results2[0].Owner);
        }
    }
}
