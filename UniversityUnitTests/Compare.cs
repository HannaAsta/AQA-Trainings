using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using University;

namespace UniversityUnitTests
{
    [TestClass]
    public class CompareTest
    {
        [TestMethod]
        public void Compare()
        {
            UniversityEmployeeComparer comparer = new UniversityEmployeeComparer();
            UniversityEmployee employee1 = new UniversityEmployee(new Person("GHHGJ", "YHjkk"),545431);
            UniversityEmployee employee2 = new UniversityEmployee(new Person("YJK", "KJ"), 99852);
            UniversityEmployee employee3 = new UniversityEmployee(new Person("DD", "KJH"), 99853);
            Assert.AreEqual(1, comparer.Compare(employee1, employee2));
            Assert.AreEqual(0, comparer.Compare(employee2, employee3));
            Assert.AreEqual(-1, comparer.Compare(employee3, employee1));
        }
    }
}