using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;

namespace UniversityUnitTests
{
    [TestClass]
    public class UniversityEmployeeTests
    {
        UniversityEmployee employee;
        [TestInitialize]
        public void Setup()
        {
            employee = new UniversityEmployee(new Person("Ert", "FFF"), 12345);
        }
        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A taxId less or equal than 0")]
        public void TestConstructor()
        {
            new UniversityEmployee(new Person("", ""), 0);
        }
        [TestMethod]
        public void TestEquals()
        {
            Assert.IsTrue(employee.Equals(employee));
            Assert.IsFalse(employee.Equals(4545));
            
        }
    }
}
