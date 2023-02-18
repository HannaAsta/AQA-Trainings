using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace PersonTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), " Expected Exception not thrown")]
        public void FullNameLenghtPositive()
        {
            new Person("Gijgsdgh", "fdhfhfvz");
        }
        [TestMethod]
        public void FullNameLenghtNegative()
        {
            new Person("Gjgsdgh", "fd");
        }

        [TestMethod]
        public void AdressTest()
        {
            var address = new Adress(6, "Gjgsdgh", "fd");
            Assert.AreEqual(6u, address.NumberLokal);
            Assert.AreEqual("Gjgsdgh", address.Street);
            Assert.AreEqual("fd", address.City);
        }
    }
}
