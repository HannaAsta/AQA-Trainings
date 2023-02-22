using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using University;

namespace UniversityUnitTests
{
    [TestClass]
    public class BuildingTest
    {
        [TestMethod]
        public void AdressBuldingEqual()
        {
            Room room5 = new Room(565, "styding");
            Room room6 = new Room(652, "lecture");

            Adress addr6  = new Adress(12, "Plechanova", "Minsk");
            Adress addr7 = new Adress(52, "Halturina", "Brest");

            Building build1 = new Building(new List<Room>{ room5, room6 }, addr6);
            Building build2 = new Building(new List<Room>{ room5, room6 }, addr7);
            Building build3 = new Building(new List<Room> { room5, room6 }, addr7);
            build1.Equals(build2);

            Assert.AreNotEqual(build1, build2);
            Assert.AreEqual(build2, build3);
        }
    }
}