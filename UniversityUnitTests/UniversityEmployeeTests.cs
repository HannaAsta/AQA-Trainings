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
            employee = new UniversityEmployee(new Person("Piotr", "Fanik"), 12345);
        }

        [TestMethod]
        public void TestEquals()
        {
            Assert.IsTrue(employee.Equals(employee));
            Assert.IsFalse(employee.Equals(4545));
        }

        [TestMethod]
        public void EmployeesComparerLess()
        {
            UniversityEmployee addEmployee = new Teacher(new Person("Gsdfck", "Huk"), 42471121, new List<string> { "physics", "mathematic" }, "Ph.D");
            UniversityEmployee addRector = new Rector(new Person("Hasda", "Hfd"), 872471451, "54654131");

            Assert.IsTrue(addEmployee.CompareTo(addRector) < 0);
        }
        [TestMethod]
        public void SortEmployeesComparerEqual()
        {
            UniversityEmployee addEmployee = new Teacher(new Person("Hisdk", "FFuk"), 54211121, new List<string> { "physics", "mathematic" }, "Ph.D");
            UniversityEmployee addRector = new Rector(new Person("Hisdk", "FFuk"), 54211121, "999654131");

            Assert.AreEqual(0, addEmployee.CompareTo(addRector));
        }
        [TestMethod]
        public void SortEmployeesComparerGreater()
        {
            UniversityEmployee addEmployee = new Teacher(new Person("Hisdk", "FFuk"), 872471451, new List<string> { "physics", "mathematic" }, "Ph.D");
            UniversityEmployee addRector = new Rector(new Person("Hвввasda", "Hfd"), 42471121, "999654131");

            Assert.IsTrue(addEmployee.CompareTo(addRector) > 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UniversityEmployeeArgumentExeption()
        {
            new UniversityEmployee(new Person("Gdfvs", "Sfr"), 0);
        }
    }
}


