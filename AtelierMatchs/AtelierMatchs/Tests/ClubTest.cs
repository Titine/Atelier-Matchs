using Matchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matchs_Tests
{
    [TestClass()]
    public class ClubTest
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Club target = new Club("Liverpool");
            Assert.AreEqual("Liverpool", target.ToString());
        }

        /// <summary>
        ///Test pour Constructeur Club
        ///</summary>
        [TestMethod()]
        public void ClubConstructorTest()
        {
            Club target = new Club("Liverpool");
            Assert.AreEqual("Liverpool", target.ToString());
        }

    }
}
