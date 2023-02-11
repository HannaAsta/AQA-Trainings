using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityUnitTests
{
    [TestClass]
    public class UniverTests
    {
        Univer univer;

        [TestInitialize]
        public void Setup()
        {
            univer = new Univer(new Rector(new Person("aa", "ss"), 123, "2345678"), new Adress(12, "Street", "City"), new List<Building>() { });
        }
        [TestCleanup]
        public void Cleanup()
        {
        }
        [TestMethod]
        public void TestAddEmployee()
        {
            UniversityEmployee employee = new UniversityEmployee(new Person("VaSIA", "Petrov"), 12345);
            Assert.IsTrue(univer.AddEmployee(employee));
            Assert.IsFalse(univer.AddEmployee(employee));
        }
    }
}