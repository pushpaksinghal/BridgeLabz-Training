using BridgelabzTraining.senario_based.AddressBook;
using BridgeLabzTraining.Tests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BridgelabzTraining.Tests
{
    [TestClass]
    public class CsvIoTests
    {
        [TestMethod]
        public void ExportThenImportCsv_ShouldPersistContacts()
        {
            IAddressBook svc = new AddressUtility<UserContact>();
            svc.AddAddressBook("Owner1");

            svc.AddContact("Owner1", ContactFactory.Create("A", "One", "Pune", "MH", zip: "411001"));
            svc.AddContact("Owner1", ContactFactory.Create("B", "Two", "Delhi", "DL", zip: "110001"));

            string tempCsv = Path.Combine(Path.GetTempPath(), "ab_uc14.csv");

            try
            {
                svc.ExportToCsv("Owner1", tempCsv);
                svc.ImportFromCsv("Owner1", tempCsv);

                var contacts = svc.GetContacts("Owner1");
                Assert.AreEqual(2, contacts.Count);
                Assert.AreEqual("A", contacts[0].FirstName());
                Assert.AreEqual("B", contacts[1].FirstName());
            }
            finally
            {
                if (File.Exists(tempCsv))
                    File.Delete(tempCsv);
            }
        }
    }
}
