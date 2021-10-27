using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasLibraryTest
    {
        private User user;
        private Day day;

        [SetUp]
        public void Init()
        {
            user = new User();
            day = new Day();
        }
        [Test]
        public void UserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }
        [Test]
        public void DayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
        }
    }
}
