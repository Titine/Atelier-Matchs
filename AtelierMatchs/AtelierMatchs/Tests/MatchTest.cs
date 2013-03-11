using Matchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Matchs_Tests
{
    [TestClass()]
    public class MatchTest
    {
        public Club Home = new Club("Liverpool");
        public Club Away = new Club("Manchester");


        [TestMethod()]
        public void AwayTest()
        {
            Match target = new Match(Home, Away, 3, 0); 
            Assert.AreEqual(Away, target.Away);
        }

        [TestMethod()]
        public void AwayGoalsTest()
        {
            Match target = new Match(Home, Away, 3, 3); 
            Assert.AreEqual(3, target.AwayGoals);
        }

        [TestMethod()]
        public void HomeTest()
        {
            Match target = new Match(Home, Away, 3, 1); 
            Assert.AreEqual(Home, target.Home);
        }

        [TestMethod()]
        public void HomeGoalsTest()
        {
            Match target = new Match(Home, Away, 3, 1); 
            Assert.AreEqual(3, target.HomeGoals);
        }

        [TestMethod()]
        public void IsAwayForfeitTest()
        {
            Match target = new Match(Home, Away, 2, 3); 
            Assert.IsTrue(target.IsAwayForfeit);
        }

        [TestMethod()]
        public void IsDrawTest()
        {
            Match target = new Match(Home, Away, 2, 2);
            Assert.IsTrue(target.IsDraw);
        }

        [TestMethod()]
        public void IsHomeForfeitTest()
        {
            Match target = new Match(Home, Away, 4, 1);
            Assert.IsTrue(target.IsHomeForfeit);
        }

       
    }
}
