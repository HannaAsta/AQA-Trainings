using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using University;

namespace UniversityUnitTests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void RoomNumberPositive()
        {
            var resultRoom1 = new Room(54, "Lecture");
            var resultRoom2 = new Room(44, "Educational");

            Assert.IsFalse(resultRoom1.Equals(resultRoom2));
        }

        [TestMethod]
        public void RoomNumberNegative()
        {
            var resultRoom1 = new Room(69, "Academic");
            var resultRoom2 = new Room(69, "Academic");

            Assert.IsTrue(resultRoom1.Equals(resultRoom2));
            Assert.IsTrue(resultRoom1.GetHashCode().Equals(resultRoom2.GetHashCode()));
        }
    }
}