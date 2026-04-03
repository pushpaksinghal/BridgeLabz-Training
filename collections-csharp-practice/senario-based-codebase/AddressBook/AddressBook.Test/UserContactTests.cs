using BridgeLabzTraining.Tests.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgelabzTraining.Tests
{
    [TestClass]
    public class UserContactTests
    {
        [TestMethod]
        public void Getters_ShouldReturnConstructorValues()
        {
            var c = ContactFactory.Create("Rahul", "Sharma", "Delhi", "DL");

            Assert.AreEqual("Rahul", c.FirstName());
            Assert.AreEqual("Sharma", c.LastName());
            Assert.AreEqual("Delhi", c.City());
            Assert.AreEqual("DL", c.State());
        }

        [TestMethod]
        public void ToString_ShouldContainKeyFields()
        {
            var c = ContactFactory.Create("A", "B", "Mumbai", "MH");
            string s = c.ToString();

            StringAssert.Contains(s, "A");
            StringAssert.Contains(s, "B");
            StringAssert.Contains(s, "Mumbai");
            StringAssert.Contains(s, "MH");
        }
    }
}
