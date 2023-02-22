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

        [TestMethod]
        public void TestAddEmployeePositive()
        {
            var emp = new UniversityEmployee(new Person("Vasia", "Petrov"), 12345);
            Assert.IsTrue(univer.AddEmployee(emp));
            Assert.IsTrue(univer.Employees.Count == 1);
            Assert.IsTrue(univer.Employees.Contains(emp));
                        
        }
        [TestMethod]
        public void TestAddEmployeeNegative()
        {
            var emp = new UniversityEmployee(new Person("Petiya", "Petrov"), 2445);
            Assert.IsTrue(univer.AddEmployee(emp));
            Assert.IsFalse(univer.AddEmployee(emp));
            Assert.IsTrue(univer.Employees.Count == 1);
        }
    }

}