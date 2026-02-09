using BridgelabzTraining.senario_based.AddressBook;
using BridgeLabzTraining.Tests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BridgelabzTraining.Tests
{
    [TestClass]
    public class JsonIoTests
    {
        [TestMethod]
        public void ExportThenImportJson_ShouldPersistContacts()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One", "Pune", "MH", zip: "411001"));
            svc.AddContact("Owner1", ContactFactory.Create("B", "Two", "Delhi", "DL", zip: "110001"));

            string tempJson = Path.Combine(Path.GetTempPath(), "ab_uc15.json");

            try
            {
                svc.ExportToJson("Owner1", tempJson);
                svc.ImportFromJson("Owner1", tempJson);

                var contacts = svc.GetContacts("Owner1");
                Assert.AreEqual(2, contacts.Count);
                Assert.AreEqual("A", contacts[0].FirstName());
                Assert.AreEqual("B", contacts[1].FirstName());
            }
            finally
            {
                if (File.Exists(tempJson))
                    File.Delete(tempJson);
            }
        }
    }
}
