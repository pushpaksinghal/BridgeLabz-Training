using BridgelabzTraining.senario_based.AddressBook;
using BridgeLabzTraining.Tests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgelabzTraining.Tests
{
    [TestClass]
    public class AddressBookTests
    {
        [TestMethod]
        public void Constructor_ShouldSetOwner_AndStartEmpty()
        {
            var book = new AddressBook<UserContact>("Owner1");

            Assert.AreEqual("Owner1", book.OwnerName());
            Assert.AreEqual(0, book.ContactCount());
            Assert.AreEqual(0, book.Contacts().Count);
        }

        [TestMethod]
        public void AddContact_ShouldIncreaseCount()
        {
            var book = new AddressBook<UserContact>("Owner1");
            book.AddContact(ContactFactory.Create());

            Assert.AreEqual(1, book.ContactCount());
        }

        [TestMethod]
        public void DeleteContactAt_ValidIndex_ShouldRemove_AndReturnTrue()
        {
            var book = new AddressBook<UserContact>("Owner1");
            var c1 = ContactFactory.Create("A", "One");
            var c2 = ContactFactory.Create("B", "Two");
            book.AddContact(c1);
            book.AddContact(c2);

            bool deleted = book.DeleteContactAt(0);

            Assert.IsTrue(deleted);
            Assert.AreEqual(1, book.ContactCount());
            Assert.AreSame(c2, book.Contacts()[0]);
        }

        [TestMethod]
        public void DeleteContactAt_InvalidIndex_ShouldReturnFalse_AndNotChange()
        {
            var book = new AddressBook<UserContact>("Owner1");
            book.AddContact(ContactFactory.Create());

            bool deletedNeg = book.DeleteContactAt(-1);
            bool deletedBig = book.DeleteContactAt(99);

            Assert.IsFalse(deletedNeg);
            Assert.IsFalse(deletedBig);
            Assert.AreEqual(1, book.ContactCount());
        }
    }
}
